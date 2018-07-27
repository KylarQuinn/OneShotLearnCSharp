using System;
using PlayerRoles;

namespace PlayerAttributes
{
    // Simplify the concept to only incoming draft prospects.  The scope explodes otherwise.
    class PlayerAge
    {
        Role Role;
        int LiteralAge;

        public PlayerAge(Role role, int literalAge)
        {
            Role = role;
            LiteralAge = literalAge;
        }

        public double ModifyExpectancyBasedOnRole()
        {
            switch (Role)
            {
                case Role.PointGuard:
                case Role.TwoGuard:
                    return ModifyGuardsBasedOnAge(LiteralAge);
                case Role.SmallForward:
                case Role.Wing:
                    return ModifyWingsBasedOnAge(LiteralAge);
                case Role.PowerForward:
                case Role.Big:
                case Role.Center:
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
                    return RolesCommon.BigAgeModifier.EIGHTEEN;
                case 19:
                    return RolesCommon.BigAgeModifier.NINETEEN;
                case 20:
                    return RolesCommon.BigAgeModifier.TWENTY;
                case 21:
                    return RolesCommon.BigAgeModifier.TWENTYONE;
                case 22:
                    return RolesCommon.BigAgeModifier.TWENTYTWO;
                case 23:
                    return RolesCommon.BigAgeModifier.TWENTYTHREE;
                default:
                    return 0;
            }
        }

        private double ModifyWingsBasedOnAge(int literalAge)
        {
            switch (literalAge)
            {
                case 18:
                    return RolesCommon.WingAgeModifier.EIGHTEEN;
                case 19:
                    return RolesCommon.WingAgeModifier.NINETEEN;
                case 20:
                    return RolesCommon.WingAgeModifier.TWENTY;
                case 21:
                    return RolesCommon.WingAgeModifier.TWENTYONE;
                case 22:
                    return RolesCommon.WingAgeModifier.TWENTYTWO;
                case 23:
                    return RolesCommon.WingAgeModifier.TWENTYTHREE;
                default:
                    return 0.0;
            }
        }

        private double ModifyGuardsBasedOnAge(int literalAge)
        {
            switch (literalAge)
            {
                case 18:
                    return RolesCommon.GuardAgeModifier.EIGHTEEN;
                case 19:
                    return RolesCommon.GuardAgeModifier.NINETEEN;
                case 20:
                    return RolesCommon.GuardAgeModifier.TWENTY;
                case 21:
                    return RolesCommon.GuardAgeModifier.TWENTYONE;
                case 22:
                    return RolesCommon.GuardAgeModifier.TWENTYTWO;
                case 23:
                    return RolesCommon.GuardAgeModifier.TWENTYTHREE;
                default:
                    return 0.0;
            }
        }
    }
}
