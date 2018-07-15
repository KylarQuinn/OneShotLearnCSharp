using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OneShotLearnCSharp.Positions.PositionsCommon;
using static OneShotLearnCSharp.Positions.PointGuard;

namespace OneShotLearnCSharp.PlayerAttributes
{
    class PlayerAge
    {
        Dictionary<int, int> MinutesPerSeason;
        int Position;
        int LiteralAge;

        public PlayerAge(int position)
        {
            Position = position;
        }

        public PlayerAge(int position, int yearOfExperience, int minutes)
        {
            Position = position;
            if (!MinutesPerSeason.ContainsKey(yearOfExperience))
            {
                MinutesPerSeason.Add(yearOfExperience, minutes);
            }
        }

        public PlayerAge(int position, int yearOfExperience, int minutes, int age)
        {
            Position = position;
            if (!MinutesPerSeason.ContainsKey(yearOfExperience))
            {
                MinutesPerSeason.Add(yearOfExperience, minutes);
            }

        }

        public PlayerAge(int position, Dictionary<int, int> minutesPerSeason)
        {
            Position = position;
            MinutesPerSeason = minutesPerSeason;
        }

        double GetNbaAge(int position, Positions.PointGuard.PgPlayType playType)
        {
            int TotalMinutes = 0;
            int TotalYears = 0;

            foreach (int year in MinutesPerSeason.Keys)
            {
                TotalMinutes += MinutesPerSeason[year];
                TotalYears += 1;
            }

            if (Position == 1)
            {
                if (playType == Positions.PointGuard.PgPlayType.Slasher)
                {

                }
                else if (playType == Positions.PointGuard.PgPlayType.Shooter)
                {

                }
                else if (playType = 3)
                {

                }
            }
        }
    }
}
