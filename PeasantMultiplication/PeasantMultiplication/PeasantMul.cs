namespace PeasantMultiplication
{
	public class PeasantMul
	{
		public static int Mul(int l, int r)
		{
			var result = 0;
			while (l > 0) {
				result += r;
				l >>= 1;
			}
			return result;
		}
	}
}