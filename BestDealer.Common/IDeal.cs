﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestDealer.Common
{
    interface IDeal
    {
        float Price { get; }

        string Description { get; }
    }
}
