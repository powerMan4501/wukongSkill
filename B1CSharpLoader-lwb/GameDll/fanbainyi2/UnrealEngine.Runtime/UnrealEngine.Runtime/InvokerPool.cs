using System.Collections.Generic;

namespace UnrealEngine.Runtime;

internal static class InvokerPool
{
	private static Stack<Invoker> available = new Stack<Invoker>();

	public static Invoker GetObject()
	{
		if (available.Count > 0)
		{
			return available.Pop();
		}
		return new Invoker
		{
			IsPooled = true
		};
	}

	public static void ReturnObject(Invoker obj)
	{
		available.Push(obj);
		obj.Reset();
	}
}
