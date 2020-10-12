﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Docnet.Core.Models
{
    public struct Vector
    {
        public int X { get; }

        public int Y { get; }

        public Vector(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
