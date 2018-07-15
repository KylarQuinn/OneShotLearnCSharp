using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.Positions
{
    class PositionsCommon
    {
        enum SkillLevel
        {
            
        }

        public enum SkillThresholds
        {
            Unplayable = 30,
            NonFactor = 45,
            Average = 50,
            Good = 62,
            Great = 70,
            Starter = 78,
            ImpactPlayer = 86
        }

        public static int GetSkillLevel(int level)
        {
            if(level <= 0)
            {
                return 0;
            }
            else if(level < 100)
            {
                return 100;
            }
            else
            {
                return level;
            }
        }
    }
}
