﻿using OneShotLearnCSharp.Positions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static OneShotLearnCSharp.PlayerAttributes.PlayerAge;

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
        PositionsCommon.CountingStats CountingStats { get; set; }
    }

}
