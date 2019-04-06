using System;
using Xunit;

using Core.Math.SetTheory;

namespace UnitTests
{
    public class UnitTest1
    {
        // declaration
        Core.Math.SetTheory.Set<int> set_int_01;
        Set<int> set_int_02;

        [Fact]
        public void Test_Constructor_01()
        {

            // definition
            set_int_01 = new Core.Math.SetTheory.Set<int>()
            {
                1,
                3,
                4,
                4,
            };

            set_int_02 = new Set<int>() { 10, 5, 3, 3, };

            // one-liner = declaration and definition
            Set<double> set_02 = new Set<double>() { 0.1, 1.1, 2.2, 3.1, 2.2 };

            return;
        }

        [Fact]
        public void Test_Union_01()
        {
            Test_Constructor_01();

            Set<int> union = set_int_01 + set_int_02;

            return;
        }

    }
}
