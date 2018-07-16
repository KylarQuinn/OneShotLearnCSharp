using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.PlayerAttributes
{
    // Simplify the concept to only incoming draft prospects.  The scope explodes otherwise.
    class PlayerAge
    {
        PlayerRoles.RolesCommon.Role Position;
        int LiteralAge;

        public PlayerAge(PlayerRoles.RolesCommon.Role position, int literalAge)
        {
            Position = position;
            LiteralAge = literalAge;
        }

        public double ModifyExpectancyBasedOnRole()
        {
            switch (Position)
            {
                case PlayerRoles.RolesCommon.Role.PointGuard:
                case PlayerRoles.RolesCommon.Role.TwoGuard:
                    return ModifyGuardsBasedOnAge(LiteralAge);
                case PlayerRoles.RolesCommon.Role.SmallForward:
                case PlayerRoles.RolesCommon.Role.Wing:
                    return ModifyWingsBasedOnAge(LiteralAge);
                case PlayerRoles.RolesCommon.Role.PowerForward:
                case PlayerRoles.RolesCommon.Role.Big:
                case PlayerRoles.RolesCommon.Role.Center:
                    return ModifyBigsBasedOnAge(LiteralAge);
                default:
                    throw new InvalidOperationException("Enountered undefined role.");
            }
        }

        private double ModifyBigsBasedOnAge(int literalAge)
        {
            switch (literalAge)
            {
                case 18:
                    return PlayerRoles.RolesCommon.BigAgeModifier.EIGHTEEN;
                case 19:
                    return PlayerRoles.RolesCommon.BigAgeModifier.NINETEEN;
                case 20:
                    return PlayerRoles.RolesCommon.BigAgeModifier.TWENTY;
                case 21:
                    return PlayerRoles.RolesCommon.BigAgeModifier.TWENTYONE;
                case 22:
                    return PlayerRoles.RolesCommon.BigAgeModifier.TWENTYTWO;
                case 23:
                    return PlayerRoles.RolesCommon.BigAgeModifier.TWENTYTHREE;
                default:
                    return 0;
            }
        }

        private double ModifyWingsBasedOnAge(int literalAge)
        {
            switch (literalAge)
            {
                case 18:
                    return PlayerRoles.RolesCommon.WingAgeModifier.EIGHTEEN;
                case 19:
                    return PlayerRoles.RolesCommon.WingAgeModifier.NINETEEN;
                case 20:
                    return PlayerRoles.RolesCommon.WingAgeModifier.TWENTY;
                case 21:
                    return PlayerRoles.RolesCommon.WingAgeModifier.TWENTYONE;
                case 22:
                    return PlayerRoles.RolesCommon.WingAgeModifier.TWENTYTWO;
                case 23:
                    return PlayerRoles.RolesCommon.WingAgeModifier.TWENTYTHREE;
                default:
                    return 0.0;
            }
        }

        private double ModifyGuardsBasedOnAge(int literalAge)
        {
            switch (literalAge)
            {
                case 18:
                    return PlayerRoles.RolesCommon.GuardAgeModifier.EIGHTEEN;
                case 19:
                    return PlayerRoles.RolesCommon.GuardAgeModifier.NINETEEN;
                case 20:
                    return PlayerRoles.RolesCommon.GuardAgeModifier.TWENTY;
                case 21:
                    return PlayerRoles.RolesCommon.GuardAgeModifier.TWENTYONE;
                case 22:
                    return PlayerRoles.RolesCommon.GuardAgeModifier.TWENTYTWO;
                case 23:
                    return PlayerRoles.RolesCommon.GuardAgeModifier.TWENTYTHREE;
                default:
                    return 0.0;
            }
        }
    }
}
