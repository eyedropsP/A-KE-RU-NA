namespace Akeruna.Models
{
	public class Sanity
	{
		public int Value { get; private set; }

		public Sanity(int value)
		{
			Value = value;
		}
		
		public static int operator +(Sanity x, Sanity y)
		{
			return x.Value + y.Value;
		}

		public static int operator -(Sanity x, Sanity y)
		{
			return x.Value - y.Value;
		}

		public override string ToString()
		{
			return $"{Value} %";
		}
	}
}