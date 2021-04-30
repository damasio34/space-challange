using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Test
{
    [TestClass]
    public class ChallengeTest
    {
        [TestMethod]
        [DataRow(2, new int[] { 8, 2, 4, 6, 3 })]
        public void TestMethod1(int x, int[] spaces)
        {
            var maximum = 0;

            for (var i = 0; i < spaces.Count() - (x - 1); i++)
            {
                var minima = 0;

                for (var j = i; j < (i + x); j++)
                {
                    if (minima == 0 || spaces[j] < minima)
                    {
                        minima = spaces[j];
                    }
                }

                if (maximum == 0 || maximum < minima)
                {
                    maximum = minima;
                }
            }

            Assert.AreEqual(maximum, 4);
        }
    }
}
