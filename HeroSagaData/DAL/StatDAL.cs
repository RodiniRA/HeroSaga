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
    public class StatDAL : IRepo<Stat>
    {
        public int Save(Stat stat)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;

                if (stat.StatId > 0)
                {
                    cmd.CommandText = "dbo.Update_Stat";
                    cmd.Parameters.AddWithValue("@StatID", stat.StatId);
                    cmd.Parameters.AddWithValue("@Name", stat.Name);
                }
                else
                {
                    cmd.CommandText = "dbo.Save_Stat";
                    cmd.Parameters.AddWithValue("@Name", stat.Name);
                }

                int index = (int)cmd.ExecuteScalar();
                return index;
            }
        }

        public Stat Load(int statId)
        {
            using (var cmd = new SqlCommand())
            {
                var sqlDA = new SqlDataAdapter();
                var resultDS = new DataSet();

                sqlDA.SelectCommand = new SqlCommand();
                sqlDA.SelectCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.CommandText = "dbo.Get_StatTypeByID";
                sqlDA.SelectCommand.Parameters.AddWithValue("@StatID", statId);

                sqlDA.Fill(resultDS, "Stat");
								Stat entity = new Stat();
								if (resultDS.Tables[0].Rows.Count > 0)
								{
									entity = Mapping.MapToStat(resultDS.Tables[0].Rows[0]);

								}
								return entity;
            }
        }

        public void Delete(int statId)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Delete_Stat";
                cmd.Parameters.AddWithValue("@StatID", statId);
            }
        }

       
    }
}
