using System.Collections;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

internal static class CoroutinePool
{
	private static Stack<Coroutine> available = new Stack<Coroutine>();

	private static Coroutine GetObject()
	{
		if (available.Count > 0)
		{
			return available.Pop();
		}
		return new Coroutine
		{
			IsPooled = true
		};
	}

	public static Coroutine New(IEnumerator coroutine)
	{
		Coroutine coroutine2 = GetObject();
		coroutine2.Enumerator = coroutine;
		return coroutine2;
	}

	public static void ReturnObject(Coroutine obj)
	{
		available.Push(obj);
		obj.Reset();
	}
}
