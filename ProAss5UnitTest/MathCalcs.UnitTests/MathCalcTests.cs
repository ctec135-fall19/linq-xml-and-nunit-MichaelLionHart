using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using Prob3;

namespace MathCalcs.UnitTests
{
    [TestFixture]
    public class MathCalcTests
    {
        [Test]
        public void Add_SumWithinByteRange_ReturnCorrectSum()
        {
            Assert.AreEqual(195, Prob3.MathCalcs2.Add(96, 99));
        }
        [Test]
        public void Add_SumOutsideByteRange_ReturnIncorrectSum()
        {
            Assert.AreEqual(307, Prob3.MathCalcs2.Add(106, 201));
        }
        [Test]
        public void Add_SumWithinByteRange_AlternateAssert()
        {
            Assert.That(Prob3.MathCalcs2.Add(96, 99), Is.EqualTo(195));
        }
        [Test]
        public void Add_SumOutsideByteRange_ThrowsException()
        {
            Assert.That(() => Prob3.MathCalcs2.Add(96, 201), Throws.Exception);
        }
    }
}
