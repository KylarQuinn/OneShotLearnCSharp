using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.PlayerRoles
{
    class Center : PlayerRoles.BaseRole
    {
        public Center(Role role) : base(role)
        {

        }

        public override double AvgNbaExpectancyPerPlaystyle()
        {
            throw new NotImplementedException();
        }

        public override void SetSkills(int first, int second, int third, int fourth)
        {
            throw new NotImplementedException();
        }
    }
}
