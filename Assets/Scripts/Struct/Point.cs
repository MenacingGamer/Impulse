﻿/*****************************************
 * This file is part of Impulse Framework.

    Impulse Framework is free software: you can redistribute it and/or modify
    it under the terms of the GNU Lesser General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    any later version.

    Impulse Framework is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Lesser General Public License for more details.

    You should have received a copy of the GNU Lesser General Public License
    along with Impulse Framework.  If not, see <http://www.gnu.org/licenses/>.
*****************************************/

using System;
using UnityEngine;
using System.Collections;

[System.Serializable]
// A Point consists of x,y coordinates that are usually represented in x,z space.
public struct Point : IEquatable<Point>
{
    // Point components.
    public int x;
    public int y;

    // Constructor.
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // Neighbors.
    public Point Right()
    {
        return new Point(x + 1, y);
    }

    public Point Left()
    {
        return new Point(x - 1, y);
    }

    public Point Up()
    {
        return new Point(x, y + 1);
    }

    public Point Down()
    {
        return new Point(x, y - 1);
    }

    public Point UpRight()
    {
        return new Point(x + 1, y + 1);
    }

    public Point UpLeft()
    {
        return new Point(x - 1, y + 1);
    }

    public Point DownRight()
    {
        return new Point(x + 1, y - 1);
    }

    public Point DownLeft()
    {
        return new Point(x - 1, y - 1);
    }

    // Operators
    public static Point operator +(Point a, Point b)
    {
        return new Point(a.x + b.x, a.y + b.y);
    }

    public static Point operator -(Point a, Point b)
    {
        return new Point(a.x - b.x, a.y - b.y);
    }

    public static bool operator ==(Point a, Point b)
    {
        return a.x == b.x && a.y == b.y;
    }

    public static bool operator !=(Point a, Point b)
    {
        return !(a == b);
    }

    public override bool Equals(object obj)
    {
        if (obj is Point)
        {
            Point p = (Point)obj;
            return x == p.x && y == p.y;
        }
        return false;
    }

    public bool Equals(Point p)
    {
        return x == p.x && y == p.y;
    }

    public override int GetHashCode()
    {
        return x.GetHashCode() ^ y.GetHashCode();
    }

    // Override ToString() to make it easier for debugging.
    public override string ToString()
    {
        return string.Format("({0},{1})", x, y);
    }

    public static explicit operator Point(Vector2 v)
    {
        return new Point((int)v.x, (int)v.y);
    }
}
