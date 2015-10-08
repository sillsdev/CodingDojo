using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace PeasantMultiplication
{
	[TestFixture]
    public class TestMultiplication
    {
		[Test]
		public void Mul1Times1Is1()
		{
			Assert.That(PeasantMul.Mul(1,1), Is.EqualTo(1));
		}
    }
}
