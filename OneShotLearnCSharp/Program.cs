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

}
