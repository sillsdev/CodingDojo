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
		[TestCase(1, 1, Result=1)]
		[TestCase(1, 2, Result=2)]
		[TestCase(2, 1, Result=2)]
		[TestCase(3, 2, Result=6)]
		[TestCase(9,5, Result=45)]
		[TestCase(12,22, Result=12*22)]
		[TestCase(0,1, Result=0)]
		[TestCase(3,0, Result=0)]
		[Test]
		public int Mul(int a, int b)
		{
			return PeasantMul.Mul(a, b);
		}

		[Test]
		public void NegativeThrows()
		{
			Assert.Throws<ArgumentOutOfRangeException>(()=>PeasantMul.Mul(-1, 1));
		}
    }
}
