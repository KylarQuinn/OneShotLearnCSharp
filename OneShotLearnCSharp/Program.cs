using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Player
    {
        String PlayerName { get; set; }
        String PlayerNumber { get; set; }
        int Age { get; set; }
        CountingStats CountingStats { get; set; }
    }

    class CountingStats
    {
        Dictionary<int, int> PointsPerSeason;
        Dictionary<int, int> ReboundsPerSeason;
        Dictionary<int, int> AssistsPerSeason;
        Dictionary<int, int> StealsPerSeason;
        Dictionary<int, int> BlocksPerSeason;
        Dictionary<int, int> ThreePtMadePerSeason;
        Dictionary<int, int> ThreePtAttemptsPerSeason;
        Dictionary<int, int> FTMadePerSeason;
        Dictionary<int, int> FTAttemptPerSeason;
        int SeasonsPlayed;
        Age NbaAge;
    }

    class Age
    {
        Dictionary<int, int> MinutesPerSeason;
        int Position;
        int LiteralAge;
        PlayType playType;

        public Age(int position)
        {
            Position = position;
        }

        public Age(int position, int yearOfExperience, int minutes)
        {
            Position = position;
            if (!MinutesPerSeason.ContainsKey(yearOfExperience))
            {
                MinutesPerSeason.Add(yearOfExperience, minutes);
            }
        }

        public Age(int position, int yearOfExperience, int minutes, int age)
        {
            Position = position;
            if (!MinutesPerSeason.ContainsKey(yearOfExperience))
            {
                MinutesPerSeason.Add(yearOfExperience, minutes);
            }
            
        }

        public Age(int position, Dictionary<int, int> minutesPerSeason)
        {
            Position = position;
            MinutesPerSeason = minutesPerSeason;
        }



        double GetNbaAge()
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
                if(playType = PgPlayType.Slasher)
                {

                }
                else if(playType = 2)
                {

                }
                else if(playType = 3)
                {

                }
            }
        }

    }
}
