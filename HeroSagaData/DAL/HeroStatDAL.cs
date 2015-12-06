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
    public class HeroStatDAL : IRepo<HeroStat>
    {
        private StatBLL statBll;

        public HeroStatDAL()
        {
            statBll = new StatBLL();
        }

        public int Save(HeroStat heroStat)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;

                if (heroStat.HeroStatId > 0)
                {
                    cmd.CommandText = "dbo.Update_HeroStat";
                    cmd.Parameters.AddWithValue("@HeroStatID", heroStat.HeroStatId);
                    cmd.Parameters.AddWithValue("@HeroID", heroStat.HeroId);
                    cmd.Parameters.AddWithValue("@StatID", heroStat.StatId);
                    cmd.Parameters.AddWithValue("@CurrentValue", heroStat.CurrentValue);
                }
                else
                {
                    cmd.CommandText = "dbo.Save_HeroStat";
                    cmd.Parameters.AddWithValue("@HeroID", heroStat.HeroId);
                    cmd.Parameters.AddWithValue("@StatID", heroStat.StatId);
                    cmd.Parameters.AddWithValue("@CurrentValue", heroStat.CurrentValue);
                }

                int index = (int)cmd.ExecuteScalar();
                return index;
            }
        }

        public HeroStat Load(int heroStatId)
        {
            using (var cmd = new SqlCommand())
            {
                var sqlDA = new SqlDataAdapter();
                var resultDS = new DataSet();

                sqlDA.SelectCommand = new SqlCommand();
                sqlDA.SelectCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.CommandText = "dbo.Get_HeroStatByID";
                sqlDA.SelectCommand.Parameters.AddWithValue("@HeroStatID", heroStatId);

                sqlDA.Fill(resultDS, "HeroStat");
								HeroStat entity = new HeroStat();
								if (resultDS.Tables[0].Rows.Count > 0)
								{
									entity = Mapping.MapToHeroStat(resultDS.Tables[0].Rows[0]);

								}
								return entity;
            }
        }

        public void Delete(int heroStatId)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Delete_HeroStat";
                cmd.Parameters.AddWithValue("@HeroStatID", heroStatId);
            }
        }

        
    }
}
