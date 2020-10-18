using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Matrix4x4
    {
        public float[][] m = new float[4][] { new float[4], new float[4], new float[4], new float[4] };

        public Matrix4x4(Vector4 col0, Vector4 col1, Vector4 col2, Vector4 col3)
        {
            m[0][0] = col0.x; m[0][1] = col1.x; m[0][2] = col2.x; m[0][3] = col3.x;
            m[1][0] = col0.y; m[1][1] = col1.y; m[1][2] = col2.y; m[1][3] = col3.y;
            m[2][0] = col0.z; m[2][1] = col1.z; m[2][2] = col2.z; m[2][3] = col3.z;
            m[3][0] = col0.w; m[3][1] = col1.w; m[3][2] = col2.w; m[3][3] = col3.w;

        }

        public static Matrix4x4 Identity
        {
            get {
                return new Matrix4x4(new Vector4(1, 0, 0, 0),
                                     new Vector4(0, 1, 0, 0),
                                     new Vector4(0, 0, 1, 0),
                                     new Vector4(0, 0, 0, 1));
            }
        }

        public float Determinant
        {
            /// idk
            get { throw new NotImplementedException(); }
        }

        public Matrix4x4 Inverse
        {
            get { throw new NotImplementedException(); }
            /// idk
            //get {

            //    return (
            //        for (int j = 0; j < 4; j++)
            //        {
            //            for (int i = 0; i < 4; i++)
            //            {
            //                if (this.m[j][i] == 0){
            //                    this.m[j][i] = 1;
            //                }
            //                else if (this.m[j][i] == 1)
            //                {
            //                    this.m[j][i] = 0;
            //                }
            //            }
            //        }
            //    );
            //}
        }

        public static Matrix4x4 Translate(Vector3 translation)
        {
            return new Matrix4x4(new Vector4(1, 0, 0, translation.x),
                               new Vector4(0, 1, 0, translation.y),
                               new Vector4(0, 0, 1, translation.z),
                               new Vector4(0, 0, 0, 1));


        }

        public static Matrix4x4 Rotate(Vector3 rotation)
        {
            //idk
            //Er zijn 2 manieren om deze te berekenen
            throw new NotImplementedException();
        }

        public static Matrix4x4 RotateX(float rotation)
        {

            return new Matrix4x4(new Vector4(1, 0, 0, 0),
                            new Vector4(0, (float)Math.Cos(rotation), (float)Math.Asin(rotation), 0),
                            new Vector4(0, (float)Math.Sin(rotation), (float)Math.Cos(rotation), 0),
                            new Vector4(0, 0, 0, 1));

        
        }

        public static Matrix4x4 RotateY(float rotation)
        {

            return new Matrix4x4(new Vector4((float)Math.Cos(rotation), 0, (float)Math.Asin(rotation), 0),
                                  new Vector4(0, 1, 0, 0),
                                  new Vector4((float)Math.Sin(rotation), 0, (float)Math.Cos(rotation), 0),
                                  new Vector4(0, 0, 0, 1));
        }

        public static Matrix4x4 RotateZ(float rotation)
        {
            return new Matrix4x4(new Vector4((float)Math.Cos(rotation), (float)Math.Asin(rotation), 0, 0),
                                new Vector4((float)Math.Sin(rotation), (float)Math.Cos(rotation), 0, 0),
                                new Vector4(0, 0, 1, 0),
                                new Vector4(0, 0, 0, 1));

         
        }

        public static Matrix4x4 Scale(Vector3 scale)
        {

            return new Matrix4x4(new Vector4(scale.x, 0, 0, 0),
                                    new Vector4(0, scale.y, 0, 0),
                                    new Vector4(0, 0, scale.z, 0),
                                    new Vector4(0, 0, 0, 1));
        }

        public static Matrix4x4 operator *(Matrix4x4 lhs, Matrix4x4 rhs)
        {
      
            return new Matrix4x4(new Vector4(lhs.m[0][0] * rhs.m[0][0] + lhs.m[0][1] * rhs.m[1][0] + lhs.m[0][2] * rhs.m[2][0] + lhs.m[0][3] * rhs.m[3][0],
                               lhs.m[0][0] * rhs.m[0][1] + lhs.m[0][1] * rhs.m[1][1] + lhs.m[0][2] * rhs.m[2][1] + lhs.m[0][3] * rhs.m[3][1],
                               lhs.m[0][0] * rhs.m[0][2] + lhs.m[0][1] * rhs.m[1][2] + lhs.m[0][2] * rhs.m[2][2] + lhs.m[0][3] * rhs.m[3][2],
                               lhs.m[0][0] * rhs.m[0][3] + lhs.m[0][1] * rhs.m[1][3] + lhs.m[0][2] * rhs.m[2][3] + lhs.m[0][3] * rhs.m[3][3]),

                               new Vector4(lhs.m[1][0] * rhs.m[0][0] + lhs.m[1][1] * rhs.m[1][0] + lhs.m[1][2] * rhs.m[2][0] + lhs.m[1][3] * rhs.m[3][0],
                               lhs.m[1][0] * rhs.m[0][1] + lhs.m[1][1] * rhs.m[1][1] + lhs.m[1][2] * rhs.m[2][1] + lhs.m[1][3] * rhs.m[3][1],
                               lhs.m[1][0] * rhs.m[0][2] + lhs.m[1][1] * rhs.m[1][2] + lhs.m[1][2] * rhs.m[2][2] + lhs.m[1][3] * rhs.m[3][2],
                               lhs.m[1][0] * rhs.m[0][3] + lhs.m[1][1] * rhs.m[1][3] + lhs.m[1][2] * rhs.m[2][3] + lhs.m[1][3] * rhs.m[3][3]),

                               new Vector4(lhs.m[2][0] * rhs.m[0][0] + lhs.m[2][1] * rhs.m[1][0] + lhs.m[2][2] * rhs.m[2][0] + lhs.m[2][3] * rhs.m[3][0],
                               lhs.m[2][0] * rhs.m[0][1] + lhs.m[2][1] * rhs.m[1][1] + lhs.m[2][2] * rhs.m[2][1] + lhs.m[2][3] * rhs.m[3][1],
                               lhs.m[2][0] * rhs.m[0][2] + lhs.m[2][1] * rhs.m[1][2] + lhs.m[2][2] * rhs.m[2][2] + lhs.m[2][3] * rhs.m[3][2],
                               lhs.m[2][0] * rhs.m[0][3] + lhs.m[2][1] * rhs.m[1][3] + lhs.m[2][2] * rhs.m[2][3] + lhs.m[2][3] * rhs.m[3][3]),

                               new Vector4(lhs.m[3][0] * rhs.m[0][0] + lhs.m[3][1] * rhs.m[1][0] + lhs.m[3][2] * rhs.m[2][0] + lhs.m[3][3] * rhs.m[3][0],
                               lhs.m[3][0] * rhs.m[0][1] + lhs.m[3][1] * rhs.m[1][1] + lhs.m[3][2] * rhs.m[2][1] + lhs.m[3][3] * rhs.m[3][1],
                               lhs.m[3][0] * rhs.m[0][2] + lhs.m[3][1] * rhs.m[1][2] + lhs.m[3][2] * rhs.m[2][2] + lhs.m[3][3] * rhs.m[3][2],
                               lhs.m[3][0] * rhs.m[0][3] + lhs.m[3][1] * rhs.m[1][3] + lhs.m[3][2] * rhs.m[2][3] + lhs.m[3][3] * rhs.m[3][3]));

        }

        public static Vector4 operator *(Matrix4x4 lhs, Vector4 rhs)
        {
         
            return new Vector4(lhs.m[0][0] * rhs.x + lhs.m[0][1] * rhs.y + lhs.m[0][2] * rhs.z + lhs.m[0][3] * rhs.w,
                lhs.m[1][0] * rhs.x + lhs.m[1][1] * rhs.y + lhs.m[1][2] * rhs.z + lhs.m[1][3] * rhs.w,
                lhs.m[2][0] * rhs.x + lhs.m[2][1] * rhs.y + lhs.m[2][2] * rhs.z + lhs.m[2][3] * rhs.w,
                lhs.m[3][0] * rhs.x + lhs.m[3][1] * rhs.y + lhs.m[3][2] * rhs.z + lhs.m[3][3] * rhs.w);
        }
    }
}
