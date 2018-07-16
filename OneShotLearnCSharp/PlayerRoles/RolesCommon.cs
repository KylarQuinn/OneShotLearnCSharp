using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.PlayerRoles
{
    class RolesCommon
    {
        public enum Role
        {
            PointGuard = 1,
            TwoGuard = 2,
            SmallForward = 3,
            PowerForward = 4,
            Center = 5,
            Big = 6,
            Wing = 7
        }

        //public class CountingStats
        //{
        //    Dictionary<int, int> PointsPerSeason;
        //    Dictionary<int, int> ReboundsPerSeason;
        //    Dictionary<int, int> AssistsPerSeason;
        //    Dictionary<int, int> StealsPerSeason;
        //    Dictionary<int, int> BlocksPerSeason;
        //    Dictionary<int, int> ThreePtMadePerSeason;
        //    Dictionary<int, int> ThreePtAttemptsPerSeason;
        //    Dictionary<int, int> FTMadePerSeason;
        //    Dictionary<int, int> FTAttemptPerSeason;
        //    int SeasonsPlayed;
        //    PlayerAttributes.PlayerAge NbaAge;
        //}

        public enum SkillThresholds
        {
            Unplayable = 30,
            NonFactor = 45,
            Average = 50,
            Good = 62,
            Great = 70,
            Starter = 78,
            ImpactPlayer = 86
        }

        public static int GetSkillLevel(int level)
        {
            if (level <= 0)
            {
                return 0;
            }
            else if (level < 100)
            {
                return 100;
            }
            else
            {
                return level;
            }
        }

        public abstract class GuardAgeModifier
        {
            public const double EIGHTEEN = 0.95;
            public const double NINETEEN = 1.00;
            public const double TWENTY = 1.05;
            public const double TWENTYONE = 1.00;
            public const double TWENTYTWO = 0.95;
            public const double TWENTYTHREE = 0.85;
        }

        public abstract class WingAgeModifier
        {
            public const double EIGHTEEN = 1.20;
            public const double NINETEEN = 1.25;
            public const double TWENTY = 1.10;
            public const double TWENTYONE = 1.05;
            public const double TWENTYTWO = 1.00;
            public const double TWENTYTHREE = 0.95;
        }

        public abstract class BigAgeModifier
        {
            public const double EIGHTEEN = 1.30;
            public const double NINETEEN = 1.25;
            public const double TWENTY = 1.25;
            public const double TWENTYONE = 1.10;
            public const double TWENTYTWO = 1.05;
            public const double TWENTYTHREE = 1.00;
        }

        #region "Guard expectancies"
        public abstract class GuardDefenderExpectancy
        {
            // Unplayble = Gets consistently beaten
            public const double UNPLAYABLE = 0.0;
            // NonFactor = Gets targeted on defense
            public const double NONFACTOR = 1.0;
            // Can defend their position
            public const double AVERAGE = 2.0;
            // Has a consistent defensive impact on opposing players
            public const double GOOD = 3.0;
            // Always impacts imposing players
            public const double GREAT = 5.0;
            // This person starts on bad team, because they impact the game so much on defense
            public const double STARTER = 6.0;
            // This person plays on good teams, and has a positive defensive RPM every year, their team's points allowed on/off per 100 is greatly affected
            public const double IMPACT_PLAYER = 8.0;
        }
        
        public abstract class GuardSlasherExpectancy
        {
            // Doesn't Slash
            public const double UNPLAYABLE = 0.0;
            // Only penetrates on fast breaks
            public const double NONFACTOR = 0.5;
            // Decent fast break slash success
            public const double AVERAGE = 1.0;
            // Can cause some issues on occasion against second units
            public const double GOOD = 1.5;
            // Can open things up for the second unit
            public const double GREAT = 2.0;
            // Can open things up against the opposing starters
            public const double STARTER = 4.0;
            // Causes havoc when penetrating against most teams.  Raises the catch and shoot efficacy of surrounding shooters.
            public const double IMPACT_PLAYER = 6.5;
        }

        public abstract class GuardDistributorExpectancy
        {
            // Not a passer
            public const double UNPLAYABLE = 0.0;
            // Doesn't always turn the ball over
            public const double NONFACTOR = 0.0;
            // Can make easy passes
            public const double AVERAGE = 1.0;
            // Finds open shooters
            public const double GOOD = 3.0;
            // Increases shooter efficacy
            public const double GREAT = 4.0;
            // Makes great passes. Opens up the defense.  Always hits players with passes where they want them.
            public const double STARTER = 5.0;
            // This person makes passes others can't see.  They are a wizard on the fastbreak.
            public const double IMPACT_PLAYER = 7.0;
        }
        
        public abstract class GuardShooterExpectancy
        {
            // Does not shoot
            public const double UNPLAYABLE = 0.0;
            // Shoots only when not defended
            public const double NONFACTOR = 0.5;
            // Can make some open shots
            public const double AVERAGE = 1.0;
            // 30% 3PT on corner threes
            public const double GOOD = 2.0;
            // Shooting is their preferred weapon
            public const double GREAT = 3.5;
            // Gravity shifts when they are on the floor
            public const double STARTER = 6.0;
            // This player is known for their percentages.  Shoots near 40% 3PT and 90% FT%, and is always targeted by contenders in free agency. Kyle Korver.
            public const double IMPACT_PLAYER = 8.5;
        }

        #endregion

        #region "Wing Expectancies"
        public abstract class WingDefenderExpectancy
        {
            // Gets consistently beaten
            public const double UNPLAYABLE = 0.0;
            // Gets targeted
            public const double NONFACTOR = 2.0;
            // Can guard some players
            public const double AVERAGE = 3.5;
            // Guards well individually, and can defend 2 or more positions
            public const double GOOD = 4.0;
            // Guards well within the scheme, can defend 2 or more positions and is unaffected by switching
            public const double GREAT = 5.0;
            // This person guards 3 or more positions, is unaffected by switching, Anchors a defense, and starts on good teams
            public const double STARTER = 6.0;
            // This person anchors a top 5 defense.  They guard 1's-4's.  They slow down the best offensive player on every team.
            public const double IMPACT_PLAYER = 8.0;
        }
        #endregion

        #region "Big Expectancies"
        public abstract class BigDefenderExpectancy
        {
            // Gets consistently beaten
            public const double UNPLAYABLE = 0.0;
            // Gets targeted
            public const double NONFACTOR = 1.0;
            // Can guard some players
            public const double AVERAGE = 1.5;
            // Guards well individually, and can defend 2 or more positions
            public const double GOOD = 3.0;
            // Guards well within the scheme, can defend both bigs and can switch onto some wings
            public const double GREAT = 5.0;
            // This person guards 3 or more positions, is unaffected by switching, Anchors a defense, and starts on good teams
            public const double STARTER = 6.0;
            // This person anchors a top 5 defense.  They guard 3's-5's.  Their team's at rim FG% is greatly effected
            public const double IMPACT_PLAYER = 8.0;
        }
        #endregion
    }
}
