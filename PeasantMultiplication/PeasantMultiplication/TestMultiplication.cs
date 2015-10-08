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
		[Test]
		public int Mul(int a, int b)
		{
			return PeasantMul.Mul(a, b);
		}
    }
}
