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
            readonly BaseRole role;

            public Player(string playerName, string playerNumber, int literalAge, int position)
            {
                PlayerName = playerName;
                PlayerNumber = playerNumber;
                LiteralAge = literalAge;
                role = RoleFactory.CreateInstance(position);
            }

            public double GetExpectancy(int age)
            {
                return role.GetExpectancy(age);
            }
        }
    }
}
