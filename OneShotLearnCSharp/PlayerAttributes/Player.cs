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
            BaseRole role;

            public Player(string playerName, string playerNumber, int literalAge)
            {
                PlayerName = playerName;
                PlayerNumber = playerNumber;
                LiteralAge = literalAge;
            }

            public void SetRole(int position)
            {
                //Figure out how to translate RtiConvert.ToEnum(of EnumName)(string enum.ToString())
                role = RoleFactory.CreateInstance(position);
            }

            public double GetExpectancy(int age)
            {
                return role.GetExpectancy(age);
            }
        }
    }
}
