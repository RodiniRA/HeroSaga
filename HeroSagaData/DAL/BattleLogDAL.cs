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
								cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
								cmd.CommandType = CommandType.StoredProcedure;

								if (battleLog.BattleLogId > 0)
								{
										cmd.CommandText = "dbo.Update_BattleLog";
										cmd.Parameters.AddWithValue("@BattleLogID", battleLog.BattleLogId);
										cmd.Parameters.AddWithValue("@BattleDate", battleLog.BattleDate);
										cmd.Parameters.AddWithValue("@MonsterID", battleLog.MonsterId);
										cmd.Parameters.AddWithValue("@HeroID", battleLog.HeroID);
										cmd.Parameters.AddWithValue("@VictoryStatus", battleLog.VictoryStatus);
								}
								else
								{
										cmd.CommandText = "dbo.Save_battleLof";
										cmd.Parameters.AddWithValue("@BattleDate", battleLog.BattleDate);
										cmd.Parameters.AddWithValue("@MonsterID", battleLog.MonsterId);
										cmd.Parameters.AddWithValue("@HeroID", battleLog.HeroID);
										cmd.Parameters.AddWithValue("@VictoryStatus", battleLog.VictoryStatus);
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
								sqlDA.SelectCommand.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
								sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
								sqlDA.SelectCommand.CommandText = "dbo.Get_BattleLogByID";
								sqlDA.SelectCommand.Parameters.AddWithValue("@BattleLogID", battleLogId);

								sqlDA.Fill(resultDS, "BattleLog");
								BattleLog entity = new BattleLog();
								if (resultDS.Tables[0].Rows.Count > 0)
							{
								 entity = Mapping.MapToBattleLog(resultDS.Tables[0].Rows[0]);
								
							}
							return entity;
						}
				}

				public void Delete(int battleLogId)
				{
						using (var cmd = new SqlCommand())
						{
								cmd.Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
								cmd.CommandType = CommandType.StoredProcedure;
								cmd.CommandText = "dbo.Delete_BattleLog";
								cmd.Parameters.AddWithValue("@BattleLogID", battleLogId);
						}
				}


			public IEnumerable<BattleLog> GetByHeroId(int heroid)
			{
				List<BattleLog> entity = new List<BattleLog>();
				using (var cmd = new SqlCommand())
				{
					var sqlDA = new SqlDataAdapter();
					var resultDS = new DataSet();
					sqlDA.SelectCommand = new SqlCommand
					{
						Connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString),
						CommandType = CommandType.StoredProcedure,
						CommandText = "dbo.Get_BattleLogByHeroID"
					};
					sqlDA.SelectCommand.Parameters.AddWithValue("@heroid", heroid);

					sqlDA.Fill(resultDS, "BattleLog");
					if (resultDS.Tables[0].Rows.Count > 0)
					{
						entity.AddRange(resultDS.Tables[0].Rows.Cast<DataRow>().Select(Mapping.MapToBattleLog));
					}
					return entity;
				}
			}
		}
}
