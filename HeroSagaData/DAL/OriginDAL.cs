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
    public class OriginDAL : IRepo<Origin>
    {
        public int Save(Origin origin)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Save_Origin";
                cmd.Parameters.AddWithValue("@OriginID", origin.OriginId);
                cmd.Parameters.AddWithValue("@Name", origin.Name);
                cmd.Parameters.AddWithValue("@Description", origin.Description);

                int index = (int)cmd.ExecuteScalar();
                return index;
            }
        }

        public Origin Load(int originId)
        {
            using (var cmd = new SqlCommand())
            {
                var sqlDA = new SqlDataAdapter();
                var resultDS = new DataSet();

                sqlDA.SelectCommand = new SqlCommand();
                sqlDA.SelectCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.CommandText = "dbo.Get_OriginTypeByID";
                sqlDA.SelectCommand.Parameters.AddWithValue("@OriginID", originId);

                sqlDA.Fill(resultDS, "Origin");
								Origin entity = new Origin();
								if (resultDS.Tables[0].Rows.Count > 0)
								{
									entity = Mapping.MapToOrigin(resultDS.Tables[0].Rows[0]);

								}
								return entity;
            }
        }

        public void Delete(int originId)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Delete_Origin";
                cmd.Parameters.AddWithValue("@OriginID", originId);
            }
        }

         
    }
}
