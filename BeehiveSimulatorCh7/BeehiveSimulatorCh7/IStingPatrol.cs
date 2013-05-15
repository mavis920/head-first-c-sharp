﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeehiveSimulatorCh7
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLength { get; }
        bool LookForEnemies();
        int SharpenStinger(int length);
    }
}
