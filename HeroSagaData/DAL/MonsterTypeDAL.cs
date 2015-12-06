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

namespace HeroSagaData.DAL
{
    public class MonsterTypeDAL : IRepo<MonsterType>
    {
        public int Save(MonsterType monsterType)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;

                if (monsterType.MonsterTypeId > 0)
                {
                    cmd.CommandText = "dbo.Update_MonsterType";
                    cmd.Parameters.AddWithValue("@MonsterTypeID", monsterType.MonsterTypeId);
                    cmd.Parameters.AddWithValue("@Name", monsterType.Name);
                    cmd.Parameters.AddWithValue("@Description", monsterType.Description);
                }
                else
                {
                    cmd.CommandText = "dbo.Save_MonsterType";
                    cmd.Parameters.AddWithValue("@Name", monsterType.Name);
                    cmd.Parameters.AddWithValue("@Description", monsterType.Description);
                }

                int index = (int)cmd.ExecuteScalar();
                return index;
            }
        }

        public MonsterType Load(int monsterTypeId)
        {
            using (var cmd = new SqlCommand())
            {
                var sqlDA = new SqlDataAdapter();
                var resultDS = new DataSet();

                sqlDA.SelectCommand = new SqlCommand();
                sqlDA.SelectCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.CommandText = "dbo.Get_MonsterTypeByID";
                sqlDA.SelectCommand.Parameters.AddWithValue("@MonsterTypeID", monsterTypeId);

                sqlDA.Fill(resultDS, "MonsterType");
								MonsterType entity = new MonsterType();
								if (resultDS.Tables[0].Rows.Count > 0)
								{
									entity = Mapping.MapToMonsterType(resultDS.Tables[0].Rows[0]);

								}
								return entity;
            }
        }

        public void Delete(int monsterTypeId)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Delete_MonsterType";
                cmd.Parameters.AddWithValue("@MonsterTypeID", monsterTypeId);
            }
        }

        
    }
}
