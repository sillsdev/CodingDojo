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
		[TestCase(int.MaxValue/2,2,Result=int.MaxValue/2*2)]
		[TestCase(int.MaxValue, 1, Result = int.MaxValue)]
		[TestCase(1, int.MaxValue, Result = int.MaxValue)]

		[TestCase(int.MaxValue - 1, 1, Result = int.MaxValue - 1)]
		[Test]
		public int Mul(int a, int b)
		{
			return PeasantMul.Mul(a, b);
		}

		[TestCase(-1,1)]
		[TestCase(1, -1)]
		[Test]
		public void NegativeArgThrows(int l, int r)
		{
			Assert.Throws<ArgumentOutOfRangeException>(()=>PeasantMul.Mul(l, r));
		}

		[TestCase(int.MaxValue,2)]
		[TestCase(2,int.MaxValue)]
		[TestCase(int.MaxValue,int.MaxValue)]
		[Test]
		public void OverflowThrows(int l,int r)
		{
			Assert.Throws<OverflowException>(() => PeasantMul.Mul(l,r));
		}
    }
}
