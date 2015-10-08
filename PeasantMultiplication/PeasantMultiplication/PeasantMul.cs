using System;
using System.Security.AccessControl;

namespace PeasantMultiplication
{
	public class PeasantMul
	{
		public static int Mul(int l, int r)
		{
			long right = r;
			if (l < 0)
				throw new ArgumentOutOfRangeException ("l", "Huh?");
			if (right < 0)
				throw new ArgumentOutOfRangeException("r", "Huh?");
			long result = 0;
			while (l > 0) {
				if (IsOdd(l))
				{
					result += right;
				}
				right <<= 1;
				l >>= 1;
			}
			return Convert.ToInt32(result);
		}

		private static bool IsOdd(int l)
		{
			return (l & 1) != 0;
		}
	}
}