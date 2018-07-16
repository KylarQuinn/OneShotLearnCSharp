﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.Converters
{
    public abstract class EthanConvert
    {
        public static PlayerRoles.Role ToRole(int position)
        {
            switch (position)
            {
                case 1:
                    return PlayerRoles.Role.PointGuard;
                case 2:
                    return PlayerRoles.Role.TwoGuard;
                case 3:
                    return PlayerRoles.Role.SmallForward;
                case 4:
                    return PlayerRoles.Role.PowerForward;
                case 5:
                    return PlayerRoles.Role.Center;
                case 6:
                    return PlayerRoles.Role.Big;
                case 7:
                    return PlayerRoles.Role.Wing;
                default:
                    throw new InvalidCastException("Unable to convert position: " + position.ToString() + " to a valid player role.");
            }
        }
    }
}
