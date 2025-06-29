using System;
using System.Text;

namespace b1;

public struct FixedString256
{
	public unsafe fixed char Chr[256];

	public unsafe FixedString256(string Str)
	{
		if (Str.Length > 256)
		{
			throw new Exception("FixedString256 size too large!");
		}
		for (int i = 0; i < Str.Length; i++)
		{
			Chr[i] = Str[i];
		}
	}

	public unsafe override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		for (int i = 0; i < 256 && !Chr[i].Equals('\0'); i++)
		{
			stringBuilder.Append(Chr[i]);
		}
		return stringBuilder.ToString();
	}
}
