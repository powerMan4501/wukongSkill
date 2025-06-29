namespace System.Text;

internal static class StringBuilderCache
{
	internal const int MAX_BUILDER_SIZE = 360;

	[ThreadStatic]
	private static StringBuilder CachedInstance;

	public static StringBuilder Acquire(int capacity = 16)
	{
		if (capacity <= 360)
		{
			StringBuilder cachedInstance = CachedInstance;
			if (cachedInstance != null && capacity <= cachedInstance.Capacity)
			{
				CachedInstance = null;
				cachedInstance.Clear();
				return cachedInstance;
			}
		}
		return new StringBuilder(capacity);
	}

	public static void Release(StringBuilder sb)
	{
		if (sb.Capacity <= 360)
		{
			CachedInstance = sb;
		}
	}

	public static string GetStringAndRelease(StringBuilder sb)
	{
		string result = sb.ToString();
		Release(sb);
		return result;
	}
}
