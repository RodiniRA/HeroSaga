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

    public class HeroTypeDAL : IRepo<HeroType>
    {
        public int Save(HeroType heroType)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection("CONNECT ME!");
                cmd.CommandType = CommandType.StoredProcedure;

                if (heroType.HeroTypeId > 0)
                {
                    cmd.CommandText = "dbo.Update_HeroType";
                    cmd.Parameters.AddWithValue("@HeroTypeID", heroType.HeroTypeId);
                    cmd.Parameters.AddWithValue("@Name", heroType.Name);
                    cmd.Parameters.AddWithValue("@Description", heroType.Description);
                }
                else
                {
                    cmd.CommandText = "dbo.Save_HeroType";
                    cmd.Parameters.AddWithValue("@Name", heroType.Name);
                    cmd.Parameters.AddWithValue("@Description", heroType.Description);
                }

                int index = (int)cmd.ExecuteScalar();
                return index;
            }
        }

        public HeroType Load(int heroTypeId)
        {
            using (var cmd = new SqlCommand())
            {
                var sqlDA = new SqlDataAdapter();
                var resultDS = new DataSet();

                sqlDA.SelectCommand = new SqlCommand();
                sqlDA.SelectCommand.Connection = new SqlConnection("CONNECT ME!");
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.CommandText = "dbo.Get_HeroTypeByID";
                sqlDA.SelectCommand.Parameters.AddWithValue("@HeroTypeID", heroTypeId);

                sqlDA.Fill(resultDS, "HeroType");
                var heroType = InItFromDB(resultDS.Tables["HeroType"].Rows[0]);
                return heroType;
            }
        }

        public void Delete(int heroTypeId)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection("CONNECT ME!");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Delete_HeroType";
                cmd.Parameters.AddWithValue("@HeroTypeID", heroTypeId);
            }
        }

       
    }
}
