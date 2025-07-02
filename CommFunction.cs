using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myproject
{
    public static class CommFunction
    {
        public static float  getMax(float n1, float n2, float n3)
        {
            return Math.Max(n1, Math.Max(n2, n3));
        }
        public static float getMin(float n1, float n2, float n3)
        {
            return Math.Min(n1, Math.Max(n2, n3));
        }
    }
}
