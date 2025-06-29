namespace System.Collections.Specialized;

internal class BackCompatibleStringComparer : IEqualityComparer
{
	internal static IEqualityComparer Default = new BackCompatibleStringComparer();

	internal BackCompatibleStringComparer()
	{
	}

	public unsafe static int GetHashCode(string obj)
	{
		fixed (char* ptr = obj)
		{
			int num = 5381;
			char* ptr2 = ptr;
			int num2;
			while ((num2 = *ptr2) != 0)
			{
				num = ((num << 5) + num) ^ num2;
				ptr2++;
			}
			return num;
		}
	}

	bool IEqualityComparer.Equals(object a, object b)
	{
		return object.Equals(a, b);
	}

	public virtual int GetHashCode(object o)
	{
		if (!(o is string obj))
		{
			return o.GetHashCode();
		}
		return GetHashCode(obj);
	}
}
