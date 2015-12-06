using System;
using System.Collections.Generic;
using System.Configuration;
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
    public class MonsterStatDAL : IRepo<MonsterStat>
    {
        private StatBLL statBll;

        public MonsterStatDAL()
        {
            statBll = new StatBLL();
        }

        public int Save(MonsterStat monsterStat)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;

                if (monsterStat.MonsterStatId > 0) 
                {
                    cmd.CommandText = "dbo.Update_MonsterStat";
                    cmd.Parameters.AddWithValue("@MonsterStatID", monsterStat.MonsterStatId);
                    cmd.Parameters.AddWithValue("@MonsterID", monsterStat.MonsterId);
                    cmd.Parameters.AddWithValue("@StatID", monsterStat.Stat.StatId);
                    cmd.Parameters.AddWithValue("@CurrentValue", monsterStat.CurrentValue);
                }
                else 
                {
                    cmd.CommandText = "dbo.Save_MonsterStat";
                    cmd.Parameters.AddWithValue("@MonsterID", monsterStat.MonsterId);
                    cmd.Parameters.AddWithValue("@StatID", monsterStat.Stat.StatId);
                    cmd.Parameters.AddWithValue("@CurrentValue", monsterStat.CurrentValue);
                }

                int index = (int)cmd.ExecuteScalar();
                return index;
            }
        }

        public MonsterStat Load(int monsterStatId)
        {
            using (var cmd = new SqlCommand())
            {
                var sqlDA = new SqlDataAdapter();
                var resultDS = new DataSet();

                sqlDA.SelectCommand = new SqlCommand();
                sqlDA.SelectCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.CommandText = "dbo.Get_MonsterStatByID";
                sqlDA.SelectCommand.Parameters.AddWithValue("@MonsterStatID", monsterStatId);

                sqlDA.Fill(resultDS, "MonsterStat");
								MonsterStat entity = new MonsterStat();
								if (resultDS.Tables[0].Rows.Count > 0)
								{
									entity = Mapping.MapToMonsterStat(resultDS.Tables[0].Rows[0]);

								}
								return entity;
            }
        }

        public void Delete(int monsterStatId)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Delete_MonsterStat";
                cmd.Parameters.AddWithValue("@MonsterStatID", monsterStatId);
            }
        }

    }
}
