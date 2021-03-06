﻿using System;
using Styles;

namespace NativeTextDemo
{
    public static class ColorSwatches
    {
        public static ColorRGB SpotColor = ColorRGB.FromHex("#ff6f00");

        public static ColorRGB RandomColor
        {
            get
            {
                Random r = new Random();

                return ColorRGB.FromRGBA(
                    r.Next(0, 255),
                    r.Next(0, 255),
                    r.Next(0, 255),
                    1
                );
            }
        }
    }
}
