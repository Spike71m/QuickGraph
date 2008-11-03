﻿using System;

namespace QuickGraph
{
    /// <summary>
    /// Colors used in vertex coloring algorithms
    /// </summary>
    [Serializable]
    public enum GraphColor
    {
        /// <summary>
        /// Usually initial color,
        /// </summary>
        White = 0,
        /// <summary>
        /// Usually intermidiate color,
        /// </summary>
        Gray,
        /// <summary>
        /// Usually finished color
        /// </summary>
        Black
    }
}