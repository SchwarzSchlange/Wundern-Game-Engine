using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wundern
{
    class Vector2
    {
        public int x { get; set; }
        public int y { get; set; }



        public static Vector2 operator +(Vector2 first, Vector2 second)
        {
            return new Vector2(first.x + second.x, first.y + second.y);
        }


        public static Vector2 operator -(Vector2 first, Vector2 second)
        {
            return new Vector2(first.x - second.x, first.y - second.y);
        }


        public static Vector2 operator /(Vector2 first, Vector2 second)
        {
            return new Vector2(first.x / second.x, first.y / second.y);
        }


        public static Vector2 operator *(Vector2 first, Vector2 second)
        {
            return new Vector2(first.x * second.x, first.y * second.y);
        }


        public Vector2 Reverse()
        {
            Vector2 a = this;

            a.x = x * -1;
            a.y = y * -1;

            return a;
        }

        public Vector2(int _x, int _y)
        {
            this.x = _x;
            this.y = _y;
        }

        public static bool IsEqual(Vector2 vec1,Vector2 vec2)
        {
            if((vec1.x == vec2.x) && (vec1.y == vec2.y))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
