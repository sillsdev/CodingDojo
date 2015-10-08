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
		[TestCase(1,1,1)]
		[TestCase(1,2,2)]
		[Test]
		public void Mul1Times1Is1(int a, int b, int result)
		{
			Assert.That(PeasantMul.Mul(a,b), Is.EqualTo(result));
		}
    }
}
