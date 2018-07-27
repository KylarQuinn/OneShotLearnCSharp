using System;
using Converters;

namespace PlayerRoles
{

    public class Player
    {
        readonly int LiteralAge;
        readonly BaseRole role;

        public Player(int literalAge, int position)
        {
            LiteralAge = literalAge;
            role = RoleFactory.CreateInstance(EthanConvert.ToRole(position));
        }

        public double GetExpectancy()
        {
            // Better...
            return role.GetExpectancy(role.Role, LiteralAge);
        }
    }
}
