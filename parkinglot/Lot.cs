﻿using System;

namespace Parkinglot
{
    public class Lot
    {
        private int _spaces;
        public int Spaces => _spaces;
        public Lot()
        {
            _spaces = 12;
        }
    }
}
