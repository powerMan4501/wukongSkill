using System.Collections.Specialized;
using System.Text;

namespace System.Diagnostics;

internal static class EnvironmentBlock
{
	public static byte[] ToByteArray(StringDictionary sd, bool unicode)
	{
		string[] array = new string[sd.Count];
		byte[] array2 = null;
		sd.Keys.CopyTo(array, 0);
		string[] array3 = new string[sd.Count];
		sd.Values.CopyTo(array3, 0);
		Array.Sort(array, array3, OrdinalCaseInsensitiveComparer.Default);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < sd.Count; i++)
		{
			stringBuilder.Append(array[i]);
			stringBuilder.Append('=');
			stringBuilder.Append(array3[i]);
			stringBuilder.Append('\0');
		}
		stringBuilder.Append('\0');
		if (unicode)
		{
			array2 = Encoding.Unicode.GetBytes(stringBuilder.ToString());
		}
		else
		{
			array2 = Encoding.Default.GetBytes(stringBuilder.ToString());
			if (array2.Length > 65535)
			{
				throw new InvalidOperationException(SR.GetString("EnvironmentBlockTooLong", array2.Length));
			}
		}
		return array2;
	}
}
