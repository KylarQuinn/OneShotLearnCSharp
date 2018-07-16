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
                    return new PointGuard();
                case 2:
                    return new TwoGuard();
                case 3:
                    return new SmallForward();
                case 4:
                    return new PowerForward();
                case 5:
                    return new Center();
                case 6:
                    return new Big();
                case 7:
                    return new Wing();
                default:
                    throw new InvalidOperationException("Player role encountered that is not defined.");
            }
        }
    }
}
