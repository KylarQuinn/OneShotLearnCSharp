using OneShotLearnCSharp.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.PlayerRoles
{
    class RoleFactory
    {
        public static BaseRole CreateInstance(int role)
        {
            switch (role)
            {
                case 1:
                    return new PointGuard(role);
                case 2:
                    return new TwoGuard(role);
                case 3:
                    return new SmallForward(role);
                case 4:
                    return new PowerForward(role);
                case 5:
                    return new Center(role);
                case 6:
                    return new Big(role);
                case 7:
                    return new Wing(role);
                default:
                    throw new InvalidOperationException("Player role encountered that is not defined.");
            }
        }
    }
}
