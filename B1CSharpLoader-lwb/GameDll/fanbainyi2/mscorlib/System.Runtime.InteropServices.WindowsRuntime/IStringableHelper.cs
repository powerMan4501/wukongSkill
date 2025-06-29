namespace System.Runtime.InteropServices.WindowsRuntime;

internal class IStringableHelper
{
	internal static string ToString(object obj)
	{
		if (obj is IStringable stringable)
		{
			return stringable.ToString();
		}
		return obj.ToString();
	}
}
