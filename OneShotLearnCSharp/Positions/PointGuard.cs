using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.Positions
{
    class PointGuard
    {
        enum PgPlayType
        {
            Slasher = 1,
            Distributor = 2,
            Shooter = 3,
            Defender = 4
        }

        Dictionary<PgPlayType, int> PlayTypeSkillLevel;
        Dictionary<PositionsCommon.SkillThresholds, double> SkillExpectancy;

        public PointGuard(int slasher, int distributor, int shooter, int defender)
        {

            PlayTypeSkillLevel = new Dictionary<PgPlayType, int>
            {
                { PgPlayType.Slasher, PositionsCommon.GetSkillLevel(slasher) },
                { PgPlayType.Distributor, PositionsCommon.GetSkillLevel(distributor) },
                { PgPlayType.Shooter, PositionsCommon.GetSkillLevel(shooter) },
                { PgPlayType.Defender, PositionsCommon.GetSkillLevel(defender) }
            };
        }

        double AvgNbaAgeExpectancyPerPlaystyle()
        {

            double shooterExpectancy = GetShooterExpectancy(PlayTypeSkillLevel[PgPlayType.Shooter]);
            double slasherExpectancy = GetSlasherExpectancy(PlayTypeSkillLevel[PgPlayType.Slasher]);
            double distributorExpectancy = GetDistributorExpectancy(PlayTypeSkillLevel[PgPlayType.Distributor]);
            double defenderExpectancy = GetDefenderExpectancy(PlayTypeSkillLevel[PgPlayType.Defender]);

            return (shooterExpectancy + slasherExpectancy + distributorExpectancy + defenderExpectancy) / 4;
        }

        internal double GetDefenderExpectancy(int skillLevel)
        {
            SkillExpectancy = new Dictionary<PositionsCommon.SkillThresholds, double>
            {
                { PositionsCommon.SkillThresholds.Unplayable, PositionsCommon.GuardDefenderExpectancy.UNPLAYABLE},
                { PositionsCommon.SkillThresholds.NonFactor, PositionsCommon.GuardDefenderExpectancy.NONFACTOR},
                { PositionsCommon.SkillThresholds.Average, PositionsCommon.GuardDefenderExpectancy.AVERAGE},
                { PositionsCommon.SkillThresholds.Good, PositionsCommon.GuardDefenderExpectancy.GOOD },
                { PositionsCommon.SkillThresholds.Great, PositionsCommon.GuardDefenderExpectancy.GREAT },
                { PositionsCommon.SkillThresholds.Starter, PositionsCommon.GuardDefenderExpectancy.STARTER },
                { PositionsCommon.SkillThresholds.ImpactPlayer, PositionsCommon.GuardDefenderExpectancy.IMPACT_PLAYER }
            };
            return GetExpectancy(skillLevel, SkillExpectancy);
        }

        private double GetDistributorExpectancy(int skillLevel)
        {
            SkillExpectancy = new Dictionary<PositionsCommon.SkillThresholds, double>
            {
                { PositionsCommon.SkillThresholds.Unplayable, PositionsCommon.GuardDistributorExpectancy.UNPLAYABLE },
                { PositionsCommon.SkillThresholds.NonFactor, PositionsCommon.GuardDistributorExpectancy.NONFACTOR },
                { PositionsCommon.SkillThresholds.Average, PositionsCommon.GuardDistributorExpectancy.AVERAGE },
                { PositionsCommon.SkillThresholds.Good, PositionsCommon.GuardDistributorExpectancy.GOOD },
                { PositionsCommon.SkillThresholds.Great, PositionsCommon.GuardDistributorExpectancy.GREAT },
                { PositionsCommon.SkillThresholds.Starter, PositionsCommon.GuardDistributorExpectancy.STARTER },
                { PositionsCommon.SkillThresholds.ImpactPlayer, PositionsCommon.GuardDistributorExpectancy.IMPACT_PLAYER }
            };
            return GetExpectancy(skillLevel, SkillExpectancy);
        }

        private double GetSlasherExpectancy(int skillLevel)
        {
            SkillExpectancy = new Dictionary<PositionsCommon.SkillThresholds, double>
            {
                { PositionsCommon.SkillThresholds.Unplayable, PositionsCommon.GuardSlasherExpectancy.UNPLAYABLE },
                { PositionsCommon.SkillThresholds.NonFactor, PositionsCommon.GuardSlasherExpectancy.NONFACTOR },
                { PositionsCommon.SkillThresholds.Average, PositionsCommon.GuardSlasherExpectancy.AVERAGE },
                { PositionsCommon.SkillThresholds.Good, PositionsCommon.GuardSlasherExpectancy.GOOD },
                { PositionsCommon.SkillThresholds.Great, PositionsCommon.GuardSlasherExpectancy.GREAT },
                { PositionsCommon.SkillThresholds.Starter, PositionsCommon.GuardSlasherExpectancy.STARTER },
                { PositionsCommon.SkillThresholds.ImpactPlayer, PositionsCommon.GuardSlasherExpectancy.IMPACT_PLAYER }
            };
            return GetExpectancy(skillLevel, SkillExpectancy);
        }

        private double GetShooterExpectancy(int skillLevel)
        {
            SkillExpectancy = new Dictionary<PositionsCommon.SkillThresholds, double>
            {
                { PositionsCommon.SkillThresholds.Unplayable, PositionsCommon.GuardShooterExpectancy.UNPLAYABLE },
                { PositionsCommon.SkillThresholds.NonFactor, PositionsCommon.GuardShooterExpectancy.NONFACTOR },
                { PositionsCommon.SkillThresholds.Average, PositionsCommon.GuardShooterExpectancy.AVERAGE },
                { PositionsCommon.SkillThresholds.Good, PositionsCommon.GuardShooterExpectancy.GOOD },
                { PositionsCommon.SkillThresholds.Great, PositionsCommon.GuardShooterExpectancy.GREAT },
                { PositionsCommon.SkillThresholds.Starter, PositionsCommon.GuardShooterExpectancy.STARTER },
                { PositionsCommon.SkillThresholds.ImpactPlayer, PositionsCommon.GuardShooterExpectancy.IMPACT_PLAYER }
            };
            return GetExpectancy(skillLevel, SkillExpectancy);
        }

        private double GetExpectancy(int skillLevel, Dictionary<PositionsCommon.SkillThresholds, double> expectancyPairs)
        {
            double expectancy = 0;

            if (skillLevel < Convert.ToInt32(PositionsCommon.SkillThresholds.NonFactor))
            {
                expectancy = expectancyPairs[PositionsCommon.SkillThresholds.NonFactor];
            }
            else if (skillLevel < Convert.ToInt32(PositionsCommon.SkillThresholds.Average))
            {
                expectancy = expectancyPairs[PositionsCommon.SkillThresholds.Average];
            }
            else if (skillLevel < Convert.ToInt32(PositionsCommon.SkillThresholds.Good))
            {
                expectancy = expectancyPairs[PositionsCommon.SkillThresholds.Good];
            }
            else if (skillLevel < Convert.ToInt32(PositionsCommon.SkillThresholds.Great))
            {
                expectancy = expectancyPairs[PositionsCommon.SkillThresholds.Great];
            }
            else if (skillLevel < Convert.ToInt32(PositionsCommon.SkillThresholds.Starter))
            {
                expectancy = expectancyPairs[PositionsCommon.SkillThresholds.Starter];
            }
            else if (skillLevel < Convert.ToInt32(PositionsCommon.SkillThresholds.ImpactPlayer))
            {
                expectancy = expectancyPairs[PositionsCommon.SkillThresholds.ImpactPlayer];
            }

            return expectancy;
        }
    }
}
