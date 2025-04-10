using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_McVey_Cason
{
    static class Calculate
    {
        // equal to 0.0f
        public static float result = 0.0f;

        // Static constructor is equal to 0.0f too
        static Calculate()
        {
            result = 0.0f;
        }


        // INTEGERS
        
        // Static integers of Add, Sub, Mult, and Div and return it
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mult(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }


        // FLOATING

        // Static float of Add, Sub, Mult, and Div and return it
        public static float Add(float x, float y)
        {
            return x + y;
        }

        public static float Sub(float x, float y)
        {
            return x - y;
        }

        public static float Mult(float x, float y)
        {
            return x * y;
        }

        public static float Div(float x, float y)
        {
            return x / y;
        }

    }
}
