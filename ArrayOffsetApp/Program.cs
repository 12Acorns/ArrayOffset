namespace ArrayOffsetApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] _result = OffsetArray(new int[5]
			{
			1,
			2,
			3,
			4,
			5
			}, 2);
			for(int i = 0; i < _result.Length; i++)
			{
				Console.Write(_result[i] + "\n");
			}
			Console.WriteLine();
			Console.ReadLine();
		}
		public static int[] OffsetArray(int[] _input, int _offset)
		{
			int _length = _input.Length;
			if(_input.Length <= 0)
			{
				return Array.Empty<int>();
			}
			int[] _arrayOut = new int[_length];
			for(int i = 0; i < _length; i++)
			{
				int _newPosition = 0;
				if((_offset + (_length - 1)) - i == _length)
				{
					_newPosition = _length - 1;
				}
				else
				{
					_newPosition = (((_length - 1) + _offset) - i) % _length;
				}
				_arrayOut[i] = _input[_newPosition];
			}
			return _arrayOut;
		}
	}
}
