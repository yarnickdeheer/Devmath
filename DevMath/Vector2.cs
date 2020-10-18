using DevMath;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector2
    {
        public float x;
        public float y;

        public float Magnitude
        {
            get { return (float)Math.Sqrt((x * x) + (y * y)); }
        }

        public Vector2 Normalized
        {
        get {
                if (Magnitude > 0)
                {
                    return new Vector2((x / Magnitude), (y / Magnitude));
                }
                else
                {
                    return new Vector2(0, 0);
                }
            }
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
          ///  float Dotproduct = (lhs.x * rhs.x) + (lhs.y * rhs.y);
            return((float)(lhs.x * rhs.x) + (lhs.y * rhs.y));
        }

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            return new Vector2(a.x + (b.x - a.x) * t , a.y + (b.y - a.y) * t);
        }

        public static float Angle(Vector2 lhs, Vector2 rhs)
        {

            return ((float)Math.Atan2(rhs.x, rhs.y) - (float)Math.Atan2(lhs.x, lhs.y));
        }

        public static Vector2 DirectionFromAngle(float angle)
        {
            // reverse angle
            // je hebt angle moet terug naar vector
            return new Vector2((float)Math.Cos(angle), (float)Math.Sin(angle));
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
        }

        public static Vector2 operator -(Vector2 v)
        {
            return new Vector2(-v.x,-v.y);
        }

        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.x * scalar, lhs.y * scalar);
        }

        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            return new Vector2(lhs.x / scalar, lhs.y / scalar);
        }
    }
}
