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
            double expectancyPerPlayStyle;
            double shooterExpectancy = GetShooterExpectancy(PlayTypeSkillLevel[PgPlayType.Shooter]);
            double slasherExpectancy = GetSlasherExpectancy(PlayTypeSkillLevel[PgPlayType.Slasher]);
            double distributorExpectancy = GetDistributorExpectancy(PlayTypeSkillLevel[PgPlayType.Distributor]);
            double defenderExpectancy = GetDefenderExpectancy(PlayTypeSkillLevel[PgPlayType.Defender]);

            expectancyPerPlayStyle = (shooterExpectancy + slasherExpectancy + distributorExpectancy + defenderExpectancy) / 4;

            return expectancyPerPlayStyle;
        }

        Dictionary<PositionsCommon.SkillThresholds, double> DefenderValues;

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

        internal double GetDefenderExpectancy(int skillLevel)
        {
            DefenderValues = new Dictionary<PositionsCommon.SkillThresholds, double>
            {
                { PositionsCommon.SkillThresholds.Unplayable, 0.0 },
                { PositionsCommon.SkillThresholds.NonFactor, 2.0 },
                { PositionsCommon.SkillThresholds.Average, 3.5 },
                { PositionsCommon.SkillThresholds.Good, 4.0 },
                { PositionsCommon.SkillThresholds.Great, 5.0 },
                { PositionsCommon.SkillThresholds.Starter, 6.0 },
                { PositionsCommon.SkillThresholds.ImpactPlayer, 8.0 }
            };
            return GetExpectancy(skillLevel, DefenderValues);
        }

        private double GetDistributorExpectancy(int skillLevel)
        {
            DefenderValues = new Dictionary<PositionsCommon.SkillThresholds, double>
            {
                { PositionsCommon.SkillThresholds.Unplayable, 0.0 },
                { PositionsCommon.SkillThresholds.NonFactor, 0.0 },
                { PositionsCommon.SkillThresholds.Average, 1.0 },
                { PositionsCommon.SkillThresholds.Good, 3.0 },
                { PositionsCommon.SkillThresholds.Great, 4.0 },
                { PositionsCommon.SkillThresholds.Starter, 5.0 },
                { PositionsCommon.SkillThresholds.ImpactPlayer, 7.0 }
            };
            return GetExpectancy(skillLevel, DefenderValues);
        }

        private double GetSlasherExpectancy(int skillLevel)
        {
            DefenderValues = new Dictionary<PositionsCommon.SkillThresholds, double>
            {
                { PositionsCommon.SkillThresholds.Unplayable, 0.0 },
                { PositionsCommon.SkillThresholds.NonFactor, 0.5 },
                { PositionsCommon.SkillThresholds.Average, 1.0 },
                { PositionsCommon.SkillThresholds.Good, 1.5 },
                { PositionsCommon.SkillThresholds.Great, 2.0 },
                { PositionsCommon.SkillThresholds.Starter, 4.0 },
                { PositionsCommon.SkillThresholds.ImpactPlayer, 6.5 }
            };
            return GetExpectancy(skillLevel, DefenderValues);
        }

        private double GetShooterExpectancy(int skillLevel)
        {
            DefenderValues = new Dictionary<PositionsCommon.SkillThresholds, double>
            {
                { PositionsCommon.SkillThresholds.Unplayable, 0.0 },
                { PositionsCommon.SkillThresholds.NonFactor, 0.5 },
                { PositionsCommon.SkillThresholds.Average, 1.0 },
                { PositionsCommon.SkillThresholds.Good, 2.0 },
                { PositionsCommon.SkillThresholds.Great, 3.5 },
                { PositionsCommon.SkillThresholds.Starter, 6.0 },
                { PositionsCommon.SkillThresholds.ImpactPlayer, 8.5 }
            };
            return GetExpectancy(skillLevel, DefenderValues);
        }
    }
}
