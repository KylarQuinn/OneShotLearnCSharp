using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.PlayerRoles
{
    class RoleFactory
    {
        public static BaseRole CreateInstance(Role role)
        {
            switch (role)
            {
                case Role.PointGuard:
                    return new PointGuard(role);
                case Role.TwoGuard:
                    return new TwoGuard(role);
                case Role.SmallForward:
                    return new SmallForward(role);
                case Role.PowerForward:
                    return new PowerForward(role);
                case Role.Center:
                    return new Center(role);
                case Role.Big:
                    return new Big(role);
                case Role.Wing:
                    return new Wing(role);
                default:
                    throw new InvalidOperationException("Player role encountered that is not defined.");
            }
        }
    }
}
