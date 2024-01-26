
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace BowlingTester
{
    [TestClass]
    public class Bowlingtester
    {

        [TestMethod]
        public void WhenBowling_Roll_FallenPin_ShouldNotBe_Below_0()
        {
            // Arrange
            Bowling bowling = new();

            // Act

            // Assert

            Assert.ThrowsException<NotBelowZeroException>(() => bowling.Roll(-2));

        }



    }
}
