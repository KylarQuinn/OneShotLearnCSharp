﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.PlayerRoles
{
    class PointGuard : BaseRole
    {
        public enum PgPlayType
        {
            Slasher = 1,
            Distributor = 2,
            Shooter = 3,
            Defender = 4
        }

        Dictionary<PgPlayType, int> PlayTypeSkillLevel;
        Dictionary<RolesCommon.SkillThresholds, double> SkillExpectancy;

        public PointGuard(){ }

        public override void SetSkills(int first, int second, int third, int fourth)
        {
            int slasher = first,
                distributor = second,
                shooter = third,
                defender = fourth;
            PlayTypeSkillLevel = new Dictionary<PgPlayType, int>
            {
                { PgPlayType.Slasher, RolesCommon.GetSkillLevel(slasher) },
                { PgPlayType.Distributor, RolesCommon.GetSkillLevel(distributor) },
                { PgPlayType.Shooter, RolesCommon.GetSkillLevel(shooter) },
                { PgPlayType.Defender, RolesCommon.GetSkillLevel(defender) }
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
            SkillExpectancy = new Dictionary<RolesCommon.SkillThresholds, double>
            {
                { RolesCommon.SkillThresholds.Unplayable, RolesCommon.GuardDefenderExpectancy.UNPLAYABLE},
                { RolesCommon.SkillThresholds.NonFactor, RolesCommon.GuardDefenderExpectancy.NONFACTOR},
                { RolesCommon.SkillThresholds.Average, RolesCommon.GuardDefenderExpectancy.AVERAGE},
                { RolesCommon.SkillThresholds.Good, RolesCommon.GuardDefenderExpectancy.GOOD },
                { RolesCommon.SkillThresholds.Great, RolesCommon.GuardDefenderExpectancy.GREAT },
                { RolesCommon.SkillThresholds.Starter, RolesCommon.GuardDefenderExpectancy.STARTER },
                { RolesCommon.SkillThresholds.ImpactPlayer, RolesCommon.GuardDefenderExpectancy.IMPACT_PLAYER }
            };
            return GetExpectancy(skillLevel, SkillExpectancy);
        }

        private double GetDistributorExpectancy(int skillLevel)
        {
            SkillExpectancy = new Dictionary<RolesCommon.SkillThresholds, double>
            {
                { RolesCommon.SkillThresholds.Unplayable, RolesCommon.GuardDistributorExpectancy.UNPLAYABLE },
                { RolesCommon.SkillThresholds.NonFactor, RolesCommon.GuardDistributorExpectancy.NONFACTOR },
                { RolesCommon.SkillThresholds.Average, RolesCommon.GuardDistributorExpectancy.AVERAGE },
                { RolesCommon.SkillThresholds.Good, RolesCommon.GuardDistributorExpectancy.GOOD },
                { RolesCommon.SkillThresholds.Great, RolesCommon.GuardDistributorExpectancy.GREAT },
                { RolesCommon.SkillThresholds.Starter, RolesCommon.GuardDistributorExpectancy.STARTER },
                { RolesCommon.SkillThresholds.ImpactPlayer, RolesCommon.GuardDistributorExpectancy.IMPACT_PLAYER }
            };
            return GetExpectancy(skillLevel, SkillExpectancy);
        }

        private double GetSlasherExpectancy(int skillLevel)
        {
            SkillExpectancy = new Dictionary<RolesCommon.SkillThresholds, double>
            {
                { RolesCommon.SkillThresholds.Unplayable, RolesCommon.GuardSlasherExpectancy.UNPLAYABLE },
                { RolesCommon.SkillThresholds.NonFactor, RolesCommon.GuardSlasherExpectancy.NONFACTOR },
                { RolesCommon.SkillThresholds.Average, RolesCommon.GuardSlasherExpectancy.AVERAGE },
                { RolesCommon.SkillThresholds.Good, RolesCommon.GuardSlasherExpectancy.GOOD },
                { RolesCommon.SkillThresholds.Great, RolesCommon.GuardSlasherExpectancy.GREAT },
                { RolesCommon.SkillThresholds.Starter, RolesCommon.GuardSlasherExpectancy.STARTER },
                { RolesCommon.SkillThresholds.ImpactPlayer, RolesCommon.GuardSlasherExpectancy.IMPACT_PLAYER }
            };
            return GetExpectancy(skillLevel, SkillExpectancy);
        }

        private double GetShooterExpectancy(int skillLevel)
        {
            SkillExpectancy = new Dictionary<RolesCommon.SkillThresholds, double>
            {
                { RolesCommon.SkillThresholds.Unplayable, RolesCommon.GuardShooterExpectancy.UNPLAYABLE },
                { RolesCommon.SkillThresholds.NonFactor, RolesCommon.GuardShooterExpectancy.NONFACTOR },
                { RolesCommon.SkillThresholds.Average, RolesCommon.GuardShooterExpectancy.AVERAGE },
                { RolesCommon.SkillThresholds.Good, RolesCommon.GuardShooterExpectancy.GOOD },
                { RolesCommon.SkillThresholds.Great, RolesCommon.GuardShooterExpectancy.GREAT },
                { RolesCommon.SkillThresholds.Starter, RolesCommon.GuardShooterExpectancy.STARTER },
                { RolesCommon.SkillThresholds.ImpactPlayer, RolesCommon.GuardShooterExpectancy.IMPACT_PLAYER }
            };
            return GetExpectancy(skillLevel, SkillExpectancy);
        }

        private double GetExpectancy(int skillLevel, Dictionary<RolesCommon.SkillThresholds, double> expectancyPairs)
        {
            if (skillLevel < Convert.ToInt32(RolesCommon.SkillThresholds.Unplayable))
            {
                return expectancyPairs[RolesCommon.SkillThresholds.Unplayable];
            }
            else if (skillLevel < Convert.ToInt32(RolesCommon.SkillThresholds.NonFactor))
            {
                return expectancyPairs[RolesCommon.SkillThresholds.NonFactor];
            }
            else if (skillLevel < Convert.ToInt32(RolesCommon.SkillThresholds.Average))
            {
                return expectancyPairs[RolesCommon.SkillThresholds.Average];
            }
            else if (skillLevel < Convert.ToInt32(RolesCommon.SkillThresholds.Good))
            {
                return expectancyPairs[RolesCommon.SkillThresholds.Good];
            }
            else if (skillLevel < Convert.ToInt32(RolesCommon.SkillThresholds.Great))
            {
                return expectancyPairs[RolesCommon.SkillThresholds.Great];
            }
            else if (skillLevel < Convert.ToInt32(RolesCommon.SkillThresholds.Starter))
            {
                return expectancyPairs[RolesCommon.SkillThresholds.Starter];
            }
            else
            {
                return expectancyPairs[RolesCommon.SkillThresholds.ImpactPlayer];
            }
        }
    }
}
