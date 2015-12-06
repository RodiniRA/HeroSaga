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
    public class MonsterDAL : IRepo<Monster>
    {
        private MonsterTypeBLL monsterTypeBll;

        public MonsterDAL()
        {
            monsterTypeBll = new MonsterTypeBLL();
        }

        public int Save(Monster monster)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;

                if (monster.MonsterId > 0)
                {
                    cmd.CommandText = "dbo.Update_Monster";
                    cmd.Parameters.AddWithValue("@MonsterID", monster.MonsterId);
                    cmd.Parameters.AddWithValue("@MonsterTypeID", monster.MonsterType.MonsterTypeId);
                    cmd.Parameters.AddWithValue("@Name", monster.Name);
                    cmd.Parameters.AddWithValue("@Level", monster.Level);
                    cmd.Parameters.AddWithValue("@XPWorth", monster.XPWorth);
                    cmd.Parameters.AddWithValue("@IsActive", monster.IsActive);
                }
                else
                {
                    cmd.CommandText = "dbo.Save_Monster";
                    cmd.Parameters.AddWithValue("@MonsterTypeID", monster.MonsterType.MonsterTypeId);
                    cmd.Parameters.AddWithValue("@Name", monster.Name);
                    cmd.Parameters.AddWithValue("@Level", monster.Level);
                    cmd.Parameters.AddWithValue("@XPWorth", monster.XPWorth);
                    cmd.Parameters.AddWithValue("@IsActive", monster.IsActive);
                }

                int index = (int)cmd.ExecuteScalar();
                return index;
            }
        }

        public Monster Load(int heroId)
        {
            using (var cmd = new SqlCommand())
            {
                var sqlDA = new SqlDataAdapter();
                var resultDS = new DataSet();

                sqlDA.SelectCommand = new SqlCommand();
                sqlDA.SelectCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.CommandText = "dbo.Get_MonsterByID";
                sqlDA.SelectCommand.Parameters.AddWithValue("@MonsterID", heroId);

                sqlDA.Fill(resultDS, "Monster");
								Monster entity = new Monster();
								if (resultDS.Tables[0].Rows.Count > 0)
								{
									entity = Mapping.MapToMonster(resultDS.Tables[0].Rows[0]);

								}
								return entity;
                
            }
        }

        public void Delete(int monsterId)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Delete_Monster";
                cmd.Parameters.AddWithValue("@MonsterID", monsterId);
            }
        }

       
    }
}
