using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UserValidationTesting
{
    class CompareValueInObject
    {
        public static bool IsEqual(List<string> obj1, List<string> obj2)
        {
            int i;
            if (obj1.Count != obj1.Count)
                return false;
            if (obj1.Intersect(obj2).Count() < obj2.Count)
                return false;
            return true;
        }
    }
}
