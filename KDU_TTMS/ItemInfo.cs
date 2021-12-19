﻿using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace KDU_Time_Table_Management_System
{
    public class ItemInfo
    {
        public DateTime StartTime;
        public DateTime EndTime;
        public string Text;
        public int A;
        public int R;
        public int G;
        public int B;
        HatchStyle pattern;
        Color patternColor;

        public ItemInfo()
        { }

        public ItemInfo(DateTime startTime, DateTime endTime, string text, Color color)
        {
            StartTime = startTime;
            EndTime = endTime;
            Text = text;
            A = color.A;
            R = color.R;
            G = color.G;
            B = color.B;
        }
    }
}
