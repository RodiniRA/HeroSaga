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
    public class HeroDAL : IRepo<Hero>
    {

        private HeroTypeBLL heroTypeBll;
        private OriginBLL originBll;

        public HeroDAL()
        {
            heroTypeBll = new HeroTypeBLL();
            originBll = new OriginBLL();
        }

        public int Save(Hero hero)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection("CONNECT ME!");
                cmd.CommandType = CommandType.StoredProcedure;

                if (hero.HeroId > 0)
                {
                    cmd.CommandText = "dbo.Update_Hero";
                    cmd.Parameters.AddWithValue("@HeroID", hero.HeroId);
                    cmd.Parameters.AddWithValue("@HeroTypeID", hero.HeroType.HeroTypeId);
                    cmd.Parameters.AddWithValue("@Name", hero.Name);
                    cmd.Parameters.AddWithValue("@Level", hero.Level);
                    cmd.Parameters.AddWithValue("@CurrentXP", hero.CurrentXP);
                    cmd.Parameters.AddWithValue("@Gender", hero.Gender);
                    cmd.Parameters.AddWithValue("@OriginID", hero.Origin.OriginId);
                    cmd.Parameters.AddWithValue("@IsActive", hero.IsActive);
                }
                else
                {
                    cmd.CommandText = "dbo.Save_Hero";
                    cmd.Parameters.AddWithValue("@HeroTypeID", hero.HeroType.HeroTypeId);
                    cmd.Parameters.AddWithValue("@Name", hero.Name);
                    cmd.Parameters.AddWithValue("@Level", hero.Level);
                    cmd.Parameters.AddWithValue("@CurrentXP", hero.CurrentXP);
                    cmd.Parameters.AddWithValue("@Gender", hero.Gender);
                    cmd.Parameters.AddWithValue("@OriginID", hero.Origin.OriginId);
                    cmd.Parameters.AddWithValue("@IsActive", hero.IsActive);
                }

                int index = (int)cmd.ExecuteScalar();
                return index;
            }

        }

        public Hero Load(int heroId)
        {
            using (var cmd = new SqlCommand())
            {
                var sqlDA = new SqlDataAdapter();
                var resultDS = new DataSet();

                sqlDA.SelectCommand = new SqlCommand();
                sqlDA.SelectCommand.Connection = new SqlConnection("CONNECT ME!");
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDA.SelectCommand.CommandText = "dbo.Get_HeroByID";
                sqlDA.SelectCommand.Parameters.AddWithValue("@HeroID", heroId);

                sqlDA.Fill(resultDS, "Hero");
                var hero = HeroSaga.Models.Mapping.MapToHero(resultDS.Tables["Hero"].Rows[0]);
                return hero;
            }
        }

        public void Delete(int heroId)
        {
            using (var cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection("CONNECT ME!");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "dbo.Delete_Hero";
                cmd.Parameters.AddWithValue("@HeroID", heroId);
            }
        }

      
    }
}
