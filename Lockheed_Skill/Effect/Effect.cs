﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSFML
{
    public abstract class Effect
    {
        public static readonly double MovementModifier = 5;

        private string directory;
        private int distance;
        private double X;
        private double Y;

        public Effect(string directory, int distance, double X, double Y) 
        {
            this.directory = directory;
            this.distance = distance;
            this.X = X;
            this.Y = Y;
        }

        public static abstract bool checkCollision();

    }
}