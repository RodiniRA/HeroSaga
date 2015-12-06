using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace HeroSaga.Models
{
    public static class Mapping
    {
        

        public static BattleLog MapToBattleLog(DataRow row)
        {
            var battleLog = new BattleLog();
            var hero = new Hero();
            var heroType = new HeroType();
            var origin = new Origin();
            var monster = new Monster();
            var monsterType = new MonsterType();

            hero.HeroId = int.Parse(row["HeroID"].ToString());
            heroType.HeroTypeId = int.Parse(row["HeroTypeID"].ToString()); ;
            heroType.Name = row["HeroTypeName"].ToString();
            heroType.Description = row["HeroTypeDescription"].ToString();
            hero.HeroType = heroType;
            origin.OriginId = int.Parse(row["OriginID"].ToString());
            origin.Name = row["OriginName"].ToString();
            origin.Description = row["OriginDescription"].ToString();
            hero.Origin = origin;
            hero.Level = int.Parse(row["Level"].ToString());
            hero.Name = row["HeroName"].ToString();

            monsterType.MonsterTypeId = int.Parse(row["MonsterTypeID"].ToString());
            if (row["BattleLogID"] != null) battleLog.BattleLogId = int.Parse(row["BattleLogID"].ToString());
            if (row["BattleDate"] != null) battleLog.BattleDate = DateTime.Parse(row["BattleDate"].ToString());
            if (row["HeroID"] != null) battleLog.Hero = hero;
            if (row["MonsterID"] != null) monster.MonsterId = int.Parse(row["MonsterID"].ToString());
            if (row["VictoryStatus"] != null) battleLog.VictoryStatus = bool.Parse(row["VictoryStatus"].ToString());
            if (row["IsActive"] != null) battleLog.IsActive = bool.Parse(row["IsActive"].ToString());
            return battleLog;
        }

        public static Hero MapToHero(DataRow row)
        {
            var hero = new Hero();
            var heroType = new HeroType();
            var origin = new Origin();

            heroType.HeroTypeId = int.Parse(row["HeroTypeID"].ToString());
            heroType.Name = row["HeroTypeName"].ToString();
            heroType.Description = row["HeroTypeDescription"].ToString();

            origin.OriginId = int.Parse(row["OriginID"].ToString());
            origin.Name = row["OriginName"].ToString();
            origin.Description = row["OriginDescription"].ToString();

            if (row["HeroID"] != null) hero.HeroId = int.Parse(row["HeroID"].ToString());
            if (row["HeroTypeID"] != null) hero.HeroType = heroType;
            if (row["OriginID"] != null) hero.Origin = origin;
            if (row["Level"] != null) hero.Level = int.Parse(row["Level"].ToString());
            if (row["CurrentXP"] != null) hero.CurrentXP = int.Parse(row["CurrentXP"].ToString());
            if (row["Gender"] != null) hero.Gender = row["Gender"].ToString();
            if (row["HeroName"] != null) hero.Name = row["HeroName"].ToString();
            if (row["IsActive"] != null) hero.IsActive = bool.Parse(row["IsActive"].ToString());
            return hero;
        }

        public static HeroStat MapToHeroStat(DataRow row)
        {
            var heroStat = new HeroStat();
            if (row["HeroStatID"] != null) heroStat.HeroStatId = int.Parse(row["HeroStatID"].ToString());
            if (row["HeroID"] != null) heroStat.HeroId = int.Parse(row["HeroID"].ToString());
            if (row["StatID"] != null) heroStat.Stat = statBll.Load(int.Parse(row["StatID"].ToString()));
            if (row["CurrentValue"] != null) heroStat.CurrentValue = decimal.Parse(row["CurrentValue"].ToString());
            if (row["IsActive"] != null) heroStat.IsActive = bool.Parse(row["IsActive"].ToString());
            return heroStat;
        }

        public static HeroType MapToHeroType(DataRow row)
        {
            var heroType = new HeroType();
            if (row["HeroTypeID"] != null) heroType.HeroTypeId = int.Parse(row["HeroTypeID"].ToString());
            if (row["HeroTypeName"] != null) heroType.Name = row["HeroTypeName"].ToString();
            if (row["HeroTypeDescription"] != null) heroType.Description = row["HeroTypeDescription"].ToString();
            if (row["IsActive"] != null) heroType.IsActive = bool.Parse(row["IsActive"].ToString());
            return heroType;
        }

        public static Monster MapToMonster(DataRow row)
        {
            var monster = new Monster();
            if (row["MonsterID"] != null) monster.MonsterId = int.Parse(row["MonsterID"].ToString());
            if (row["MonsterTypeID"] != null) monster.MonsterType = monsterTypeBll.Load(int.Parse(row["MonsterTypeID"].ToString()));
            if (row["Level"] != null) monster.Level = int.Parse(row["Level"].ToString());
            if (row["XPWorth"] != null) monster.XPWorth = int.Parse(row["CPWorth"].ToString());
            if (row["MonsterName"] != null) monster.Name = row["MonsterName"].ToString();
            if (row["IsActive"] != null) monster.IsActive = bool.Parse(row["IsActive"].ToString());
            return monster;
        }

        public static MonsterStat MapToMonsterStat(DataRow row)
        {
            var monsterStat = new MonsterStat();
            if (row["MonsterStatID"] != null) monsterStat.MonsterStatId = int.Parse(row["MonsterStatID"].ToString());
            if (row["MonsterID"] != null) monsterStat.MonsterId = int.Parse(row["MonsterID"].ToString());
            if (row["StatID"] != null) monsterStat.Stat = statBll.Load(int.Parse(row["StatID"].ToString()));
            if (row["CurrentValue"] != null) monsterStat.CurrentValue = decimal.Parse(row["CurrentValue"].ToString());
            if (row["IsActive"] != null) monsterStat.IsActive = bool.Parse(row["IsActive"].ToString());
            return monsterStat;
        }

        public static MonsterType MapToMonsterType(DataRow row)
        {
            var monsterType = new MonsterType();
            if (row["MonsterTypeID"] != null) monsterType.MonsterTypeId = int.Parse(row["MonsterTypeID"].ToString());
            if (row["MonsterTypeName"] != null) monsterType.Name = row["MonsterTypeName"].ToString();
            if (row["MonsterTypeDescription"] != null) monsterType.Description = row["MonsterTypeDescription"].ToString();
            if (row["IsActive"] != null) monsterType.IsActive = bool.Parse(row["IsActive"].ToString());
            return monsterType;
        }

        public static Origin MapToOrigin(DataRow row)
        {
            var origin = new Origin();
            if (row["OriginID"] != null) origin.OriginId = int.Parse(row["OriginID"].ToString());
            if (row["OriginName"] != null) origin.Name = row["OriginName"].ToString();
            if (row["OriginDescription"] != null) origin.Description = row["OriginDescription"].ToString();
            if (row["IsActive"] != null) origin.IsActive = bool.Parse(row["IsActive"].ToString());
            return origin;
        }

        public static Stat MapToStat(DataRow row)
        {
            var stat = new Stat();
            if (row["OriginID"] != null) stat.StatId = int.Parse(row["StatID"].ToString());
            if (row["StatName"] != null) stat.Name = row["StatName"].ToString();
            if (row["IsActive"] != null) stat.IsActive = bool.Parse(row["IsActive"].ToString());
            return stat;
        }
    }
}