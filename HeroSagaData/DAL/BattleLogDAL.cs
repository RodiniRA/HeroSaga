using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroSaga.Models;
using System.Data;
using System.Data.SqlClient;
using HeroSagaData.Interfaces;
using HeroSagaData.BLL;

namespace HeroSagaData.DAL
{
    public class BattleLogDAL : IRepo<BattleLog>
    {
        private HeroBLL heroBll;
        private MonsterBLL monsterBll;

        public BattleLogDAL()
        {
            heroBll = new HeroBLL();
            monsterBll = new MonsterBLL();
        }

        public int Save(BattleLog battleLog)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection("CONNECT ME!");
                cmd.CommandType = CommandType.StoredProcedure;

                if (battleLog.BattleLogId > 0)
                {
                    cmd.CommandText = "dbo.Update_BattleLog";
                    cmd.Parameters.AddWithValue("@BattleLogID", battleLog.BattleLogId);
                    cmd.Parameters.AddWithValue("@BattleDate", battleLog.BattleDate);
                    cmd.Parameters.AddWithValue("@MonsterID", battleLog.Monster.MonsterId);
                    cmd.Parameters.AddWithValue("@HeroID", battleLog.Hero.HeroId);
                    cmd.Parameters.AddWithValue("@VictoryStatus", battleLog.VictoryStatus);
                    cmd.Parameters.AddWithValue("@IsActive", battleLog.IsActive);
                }
                else
                {
                    cmd.CommandText = "dbo.Save_battleLof";
                    cmd.Parameters.AddWithValue("@BattleDate", battleLog.BattleDate);
                    cmd.Parameters.AddWithValue("@MonsterID", battleLog.Monster.MonsterId);
                    cmd.Parameters.AddWithValue("@HeroID", battleLog.Hero.HeroId);
                    cmd.Parameters.AddWithValue("@VictoryStatus", battleLog.VictoryStatus);
                    cmd.Parameters.AddWithValue("@IsActive", battleLog.IsActive);
                }

                int index = (int)cmd.ExecuteScalar();
                return index;
            }
        }

        public BattleLog Load(int battleLogId)
        {
            using (var cmd = new SqlCommand())
            {
                var sqlDA = new SqlDataAdapter();
                var resultDS = new DataSet();

                sqlDA.SelectCommand = new SqlCommand();
                sqlDA.SelectCommand.Connection = new SqlConnection("CONNECT ME!");
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.CommandText = "dbo.Get_BattleLogByID";
                sqlDA.SelectCommand.Parameters.AddWithValue("@BattleLogID", battleLogId);

                sqlDA.Fill(resultDS, "BattleLog");
                var battleLog = InItFromDB(resultDS.Tables["BattleLog"].Rows[0]);
                return battleLog;
            }
        }

        public void Delete(int battleLogId)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection("CONNECT ME!");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Delete_BattleLog";
                cmd.Parameters.AddWithValue("@BattleLogID", battleLogId);
            }
        }

        
    }
}
