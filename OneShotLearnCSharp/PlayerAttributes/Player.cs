using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OneShotLearnCSharp.PlayerRoles.RolesCommon;

namespace OneShotLearnCSharp.PlayerRoles
{

    namespace OneShotLearnCSharp
    {
        class Player
        {
            readonly String PlayerName;
            readonly String PlayerNumber;
            readonly int LiteralAge;
            CountingStats countingStats;
            BaseRole role;
            Dictionary<int, Dictionary<int, int>> NbaYear_PlayTypeSkill_SkillLevel;

            public Player(string playerName, string playerNumber, int literalAge)
            {
                PlayerName = playerName;
                PlayerNumber = playerNumber;
                LiteralAge = literalAge;
            }

            public void SetRole(int position)
            {
                //Figure out how to translate RtiConvert.ToEnum(of enum)(string enumName)
                role = RoleFactory.CreateInstance(position);
            }

            public void GetExpectancy(int skillOne, int skillTwo, int skillThree, int skillFour)
            {

            }
        }
    }
}
