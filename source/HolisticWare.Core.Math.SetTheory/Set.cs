using System;
using System.Collections;
using System.Linq;
using System.Collections.Generic;

namespace Core.Math.SetTheory;



/// <summary>
///
/// </summary>
/// <typeparam name="T"></typeparam>
/// <see href="https://en.wikipedia.org/wiki/Set_theory"/>
/// <see href="https://en.wikipedia.org/wiki/Set_(mathematics)"/>
/// <see href="https://www.geeksforgeeks.org/set-theory/"/>
///
public partial class
                                        Set<T>
                                        :
                                        System.Collections.Generic.IEnumerable<T>
{
    private IEnumerator<T> container_collection;

    // ctor = constructor
    public
                                        Set
                                        (
                                        )
                                        : base()
    {
        container_collection = new List<T>();
        
        return;
    }

    public
                                        Set
                                        (
                                            IEnumerable<T> ie
                                        )
                                        : base()
    {
        this.container_collection = ie;
        
        return;
    }

    // Cartersian product   - operator %
    // negation ??
    /// <summary>
    /// union             - operator +      (logical OR )
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs"></param>
    /// <returns></returns>
    public static
        Set<T>
                                        operator +
                                        (
                                            Set<T> lhs,
                                            Set<T> rhs
                                        )
    {
        Set<T> result = new Set<T>();
        result.AddRange(lhs);
        result.AddRange(rhs);

        result = new Set<T>(result.Distinct());

        return result;
    }

    /// <summary>
    /// intersection         - operator *   (logical AND )
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs"></param>
    /// <returns>Set<T></returns>
    public static
        Set<T>
                                        operator *
                                        (
                                            Set<T> lhs,
                                            Set<T> rhs
                                        )
    {
        Set<T> lhs_sorted = new Set<T>(lhs.OrderBy(x => x));
        Set<T> rhs_sorted = new Set<T>(rhs.OrderBy(x => x));
        Set<T> result = new Set<T>();
        result.AddRange(lhs);
        result.AddRange(rhs);

        result = new Set<T>(result.Distinct());

        return result;
    }

    /// <summary>
    /// PowerSet
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs"></param>
    /// <returns>Set<T></returns>
    public
        Set<Set<T>>
                                        PowerSet
                                        (
                                            Set<T> lhs
                                        )
    {
        Set<T> lhs_sorted = new Set<T>(lhs.OrderBy(x => x));
        result = new Set<T>(result.Distinct());

        return result;
    }

    /// <summary>
    /// PowerSet
    /// </summary>
    /// <param name="lhs"></param>
    /// <param name="rhs"></param>
    /// <returns>Set<T></returns>
    public static
        Set<T>
                                        PowerSet
                                        (
                                            Set<T> lhs
                                        )
    {
        Set<T> lhs_sorted = new Set<T>(lhs.OrderBy(x => x));
        Set<T> rhs_sorted = new Set<T>(rhs.OrderBy(x => x));
        Set<T> result = new Set<T>();
        result.AddRange(lhs);
        result.AddRange(rhs);

        result = new Set<T>(result.Distinct());

        return result;
    }

    public
        IEnumerator<T>
                                        GetEnumerator
                                        (
                                        )
    {
    }

    IEnumerator IEnumerable.GetEnumerator() {
        return GetEnumerator();
    }
}
