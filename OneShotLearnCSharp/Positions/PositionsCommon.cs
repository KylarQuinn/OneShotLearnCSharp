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
