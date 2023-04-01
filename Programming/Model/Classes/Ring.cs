﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public class Ring
    {
        private double _radiusOut;
        private double _radiusIn;

        public Point2D Center { get; set; }

        public double RadiusOut
        {
            get => _radiusOut;
            set
            {
                if (_radiusIn == default)
                {
                    Validator.AssertOnPositiveValue(value);
                }
                else
                {
                    Validator.AssertValueInRange(value, RadiusIn, Double.MaxValue);
                }
                _radiusOut = value;
            }
        }

        public double RadiusIn
        {
            get => _radiusIn;
            set
            {
                if (_radiusOut == default)
                {
                    Validator.AssertOnPositiveValue(value);
                }
                else
                {
                    Validator.AssertValueInRange(value, 0, RadiusOut);
                }
                _radiusIn = value; 
            }
        }

        public double Area
        {
            get
            {
                return Math.PI*(Math.Pow(RadiusOut,2) - Math.Pow(RadiusIn,2));
            }
        }

        public Ring (Point2D center, double radiusOut, double radiusIn)
        {
            Center = center;
            RadiusOut = radiusOut;
            RadiusIn = radiusIn;
        }
    }
}
