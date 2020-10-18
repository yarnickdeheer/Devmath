using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Circle
    {
        public Vector2 Position
        {
            get ; set ;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle)
        {

            float dx = this.Position.x +- circle.Position.x;
            float dy = this.Position.y +- circle.Position.y;

            Vector2 delta = new Vector2((this.Position.x +- circle.Position.y) , (this.Position.x +- circle.Position.y));

            float Ldelta = (float)Math.Sqrt((dx * dx) + (dy * dy));

            float col = Ldelta - (this.Radius + circle.Radius);

            if (col == 0)
            {
                //tegenelkaar
                return true;
            }
            else if (col < 0)
            {
                //overlap
                return true;
            }
            else
            {
                // geen collision   
                return false;
            }
        }
    }
}
                                    