using System;
namespace PeasantMultiplication
{
	public class PeasantMul
	{
		public static int Mul(int l, int r)
		{
			if (l < 0)
				throw new ArgumentOutOfRangeException ("l", "Huh?");
			var result = 0;
			while (l > 0) {
				if (IsOdd(l))
					result += r;
				r <<= 1;
				l >>= 1;
			}
			return result;
		}

		private static bool IsOdd(int l)
		{
			return (l & 1) != 0;
		}
	}
}