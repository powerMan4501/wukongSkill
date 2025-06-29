using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public static class FStringPool
{
	private static Stack<FStringUnsafe> available = new Stack<FStringUnsafe>();

	public static FStringUnsafe New(string value)
	{
		FStringUnsafe fStringUnsafe = New();
		fStringUnsafe.Value = value;
		return fStringUnsafe;
	}

	public static FStringUnsafe New()
	{
		if (available.Count > 0)
		{
			return available.Pop();
		}
		return new FStringUnsafe
		{
			isPooled = true
		};
	}

	public static void Return(FStringUnsafe obj)
	{
		obj.Array.ZeroMemory();
		available.Push(obj);
	}
}
