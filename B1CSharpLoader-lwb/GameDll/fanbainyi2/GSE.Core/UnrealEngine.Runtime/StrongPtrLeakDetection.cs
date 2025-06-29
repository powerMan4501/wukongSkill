using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public static class StrongPtrLeakDetection
{
	private static bool EventMemoryLeakTest;

	public static List<WeakReference<TStrongObjectPtrBase>> s_weakReferences;

	static StrongPtrLeakDetection()
	{
		EventMemoryLeakTest = false;
		s_weakReferences = new List<WeakReference<TStrongObjectPtrBase>>();
		IConsoleVariable consoleVariable = IConsoleManager.Get().FindConsoleVariable("DebugConfig.EventMemoryLeakTest");
		EventMemoryLeakTest = (object)consoleVariable != null && consoleVariable.GetInt() >= 0;
	}

	public static void JoinDetection(TStrongObjectPtrBase Obj)
	{
		if (EventMemoryLeakTest)
		{
			s_weakReferences.Add(new WeakReference<TStrongObjectPtrBase>(Obj));
		}
	}

	public static void SetEventMemoryLeakTest(bool InEventMemoryLeakTest)
	{
		EventMemoryLeakTest = InEventMemoryLeakTest;
		if (!EventMemoryLeakTest)
		{
			s_weakReferences.Clear();
		}
	}
}
