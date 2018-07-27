using System;
using Converters;

namespace PlayerRoles
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
                role = RoleFactory.CreateInstance(EthanConvert.ToRole(position));
            }

            public double GetExpectancy(int age)
            {
                // This doesn't feel right.
                return role.GetExpectancy(role.Role, age);
            }
        }
    }
}
