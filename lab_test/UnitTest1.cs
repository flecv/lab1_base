using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace lab_test
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1_1()
        {
            var input = new List<object> { 10, 3, "computer", "list", 7, 22 };
            var output = lab.lab1_base.GetIntegerFromList(input);
            var expected = new List<int> { 10, 3, 7, 22 };
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void Test1_2()
        {
            var input = new List<object> { 1, 2, 3, 7, 6, 5, 4, '1', '2', '3', '7', '6', '5', '4' };
            var output = lab.lab1_base.GetIntegerFromList(input);
            var expected = new List<int> { 1, 2, 3, 7, 6, 5, 4 };
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void Test2_1()
        {
            string output = lab.lab1_base.first_non_repeated_letter("sTreSs");
            string expected = "T";
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void Test2_2()
        {
            string output = lab.lab1_base.first_non_repeated_letter("hHIitT");
            string expected = "";
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void Test3_1()
        {
            int output = lab.lab1_base.digit_root(321);
            int expected = 6;
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void Test3_2()
        {
            int output = lab.lab1_base.digit_root(7592475);
            int expected = 3;
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void Test4_1()
        {
            int output = lab.lab1_base.count_pairs(new int[] { 1, 2, 7, 3, 2, 4, 7, 1 }, 5);
            int expected = 4;
            Assert.AreEqual(expected, output);
        }
        [Test]
        public void Test4_2()
        {
            int output = lab.lab1_base.count_pairs(new int[] { 5, 6, 7, 8, 9, 10, 11, 12 }, 4);
            int expected = 0;
            Assert.AreEqual(expected, output);
        }
        public void Test5_1()
        {
            string output = lab.lab1_base.sort_guests("Fred:Corwill;Wilfred:Corwill;Barney:Tornbull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill");
            string expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";
            Assert.AreEqual(expected, output);
        }
        public void Test5_2()
        {
            string output = lab.lab1_base.sort_guests("Sasha:Ovcharenko;Masha:Ovcharenko;Sasha:Ponomarenko");
            string expected = "(OVCHARENKO, MASHA)(OBCHARENKO, SASHA)(PONOMARENKO, SASHA)";
            Assert.AreEqual(expected, output);
        }
    }
}