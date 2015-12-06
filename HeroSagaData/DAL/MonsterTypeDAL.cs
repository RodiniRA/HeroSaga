using System;
using System.Collections.Generic;
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
                cmd.Connection = new SqlConnection("CONNECT ME!");
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
                sqlDA.SelectCommand.Connection = new SqlConnection("CONNECT ME!");
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.CommandText = "dbo.Get_MonsterTypeByID";
                sqlDA.SelectCommand.Parameters.AddWithValue("@MonsterTypeID", monsterTypeId);

                sqlDA.Fill(resultDS, "MonsterType");
                var monsterType = InItFromDB(resultDS.Tables["MonsterType"].Rows[0]);
                return monsterType;
            }
        }

        public void Delete(int monsterTypeId)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection("CONNECT ME!");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Delete_MonsterType";
                cmd.Parameters.AddWithValue("@MonsterTypeID", monsterTypeId);
            }
        }

        
    }
}
