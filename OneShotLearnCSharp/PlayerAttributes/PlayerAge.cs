using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.PlayerAttributes
{

    class PlayerAge
    {
        Dictionary<int, int> MinutesPerSeason;
        PlayerRoles.RolesCommon.Role Position;
        int LiteralAge;

        public PlayerAge(PlayerRoles.RolesCommon.Role position, int literalAge)
        {
            Position = position;
            LiteralAge = literalAge;
        }

        public PlayerAge(PlayerRoles.RolesCommon.Role position, int yearOfExperience, int minutes)
        {
            Position = position;
            if (!MinutesPerSeason.ContainsKey(yearOfExperience))
            {
                MinutesPerSeason.Add(yearOfExperience, minutes);
            }
        }

        public PlayerAge(Role position, int yearOfExperience, int minutes, int age)
        {
            Position = position;
            if (!MinutesPerSeason.ContainsKey(yearOfExperience))
            {
                MinutesPerSeason.Add(yearOfExperience, minutes);
            }
            LiteralAge = age;
        }

        public PlayerAge(Role position, Dictionary<int, int> minutesPerSeason)
        {
            Position = position;
            MinutesPerSeason = minutesPerSeason;
        }

        double GetNbaAge(Role position, PgPlayType playType)
        {
            int TotalMinutes = 0;
            int TotalYears = 0;

            foreach (int year in MinutesPerSeason.Keys)
            {
                TotalMinutes += MinutesPerSeason[year];
                TotalYears += 1;
            }

            if (position == Role.PointGuard)
            {
                if (playType == PgPlayType.Slasher)
                {

                }
                else if (playType == PgPlayType.Distributor)
                {

                }
                else if (playType == PgPlayType.Shooter)
                {

                }
                else if (playType == PgPlayType.Defender)
                {

                }
            }
        }
    }
}
