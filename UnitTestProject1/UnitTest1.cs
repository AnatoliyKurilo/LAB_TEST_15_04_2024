using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LAB_TEST_15_04_2024;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var sw = new StringWriter())
            {
                string a = "2";
                string b = "3";
                string Expected = "x в степени n = 8";
                Console.SetOut(sw);
                LAB_TEST_15_04_2024.Program.Test(a,b);
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod2()
        {
            using (var sw = new StringWriter())
            {
                string a = "-1";
                string b = "2";
                string Expected = "число x за пределами диапозона [0;999]";
                Console.SetOut(sw);
                LAB_TEST_15_04_2024.Program.Test(a, b);
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }


        [TestMethod]
        public void TestMethod3()
        {
            using (var sw = new StringWriter())
            {
                string a = "1000";
                string b = "5";
                string Expected = "число x за пределами диапозона [0;999]";
                Console.SetOut(sw);
                LAB_TEST_15_04_2024.Program.Test(a, b);
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod4()
        {
            using (var sw = new StringWriter())
            {
                string a = "100";
                string b = "0";
                string Expected = "число n за пределами диапозона [1;100]";
                Console.SetOut(sw);
                LAB_TEST_15_04_2024.Program.Test(a, b);
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod5()
        {
            using (var sw = new StringWriter())
            {
                string a = "100";
                string b = "200";
                string Expected = "число n за пределами диапозона [1;100]";
                Console.SetOut(sw);
                LAB_TEST_15_04_2024.Program.Test(a, b);
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod6()
        {
            using (var sw = new StringWriter())
            {
                string a = "ads";
                string b = "ads";
                string Expected = "не число";
                Console.SetOut(sw);
                LAB_TEST_15_04_2024.Program.Test(a, b);
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod7()
        {
            using (var sw = new StringWriter())
            {
                string a = "999";
                string b = "1";
                string Expected = "x в степени n = 999";
                Console.SetOut(sw);
                LAB_TEST_15_04_2024.Program.Test(a, b);
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }

        [TestMethod]
        public void TestMethod8()
        {
            using (var sw = new StringWriter())
            {
                string a = "0";
                string b = "100";
                string Expected = "x в степени n = 0";
                Console.SetOut(sw);
                LAB_TEST_15_04_2024.Program.Test(a, b);
                var result = sw.ToString().Trim();
                Assert.AreEqual(Expected, result);
            }
        }
    }
}
