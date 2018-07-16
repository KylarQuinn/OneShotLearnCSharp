using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.PlayerRoles
{
    abstract class BaseRole
    {
        public abstract void SetSkills(int first, int second, int third, int fourth);
        public abstract double GetExpectancy(int Age);
        public abstract double AvgNbaExpectancyPerPlaystyle();
    }
}
