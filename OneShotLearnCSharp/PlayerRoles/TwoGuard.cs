using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneShotLearnCSharp.PlayerRoles
{
    class TwoGuard : BaseRole
    {
        public TwoGuard(Role role) : base(role)
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
