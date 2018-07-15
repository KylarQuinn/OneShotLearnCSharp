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
        
        double AvgNbaAgeExpectancyPerPlaystyle()
        {
            double expectancyPerPlayStyle;
            double shooterExpectancy;
            double slasherExpectancy;
            double distributorExpectancy;
            double defenderExpectancy;



            return expectancyPerPlayStyle;
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
    }
}
