using OneShotLearnCSharp.PlayerAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.PlayerRoles
{
    abstract class BaseRole
    {
        internal Dictionary<RolesCommon.SkillThresholds, double> SkillExpectancy;
        PlayerAge PlayerAge;
        public readonly Role Role;

        protected BaseRole(Role role)
        {
            Role = role;
        }

        #region "To Override"

        public abstract void SetSkills(int first, int second, int third, int fourth);
        public abstract double AvgNbaExpectancyPerPlaystyle();

        #endregion

        #region "Common methods"

        public double GetExpectancy(Role role, int age)
        {
            PlayerAge = new PlayerAge(role, age);
            return PlayerAge.ModifyExpectancyBasedOnRole() * AvgNbaExpectancyPerPlaystyle();
        }

        #endregion
    }
}
