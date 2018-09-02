using System;
using System.Linq;
using System.Collections.Generic;

namespace Core.Math.SetTheory
{
    public partial class Set<T>
        :
        System.Collections.Generic.IEnumerable<T>
    {
        // ctor = constructor
        public Set()
            : base()
        {
            return;
        }

        public Set(IEnumerable<T> ie)
            : base(ie)
        {
            return;
        }

        // intersection         - operator *   (logical AND )
        // union                - operator + 
        // Cartersian product   - operator % 
        // negation ??

        public static Set<T> operator +(Set<T> lhs, Set<T> rhs)
        {
            Set<T> result = new Set<T>();
            result.AddRange(lhs);
            result.AddRange(rhs);

            result = new Set<T>(result.Distinct());

            return result;
        }

    }





}
