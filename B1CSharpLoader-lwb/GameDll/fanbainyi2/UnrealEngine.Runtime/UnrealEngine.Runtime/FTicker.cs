using System;
using System.Collections.Generic;
using System.Reflection;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class FTicker
{
	private FTickerDelegate del;

	private FDelegateHandle handle;

	private Native_FTicker.Del_RegisterTicker callback;

	private static Dictionary<FTicker, MethodInfo> handlers = new Dictionary<FTicker, MethodInfo>();

	private static Dictionary<MethodInfo, FTicker> handlersReverse = new Dictionary<MethodInfo, FTicker>();

	private csbool OnTick(float deltaTime)
	{
		return del != null && del(deltaTime);
	}

	public FTicker()
	{
		callback = OnTick;
	}

	public static void AddTicker(FTickerDelegate del, float delay = 0f)
	{
		if (SharedRuntimeState.IsAOT || del == null || del.Method == null)
		{
			return;
		}
		if (!FThreading.IsInGameThread())
		{
			FThreading.RunOnGameThread(delegate
			{
				AddTicker(del, delay);
			});
			return;
		}
		if (handlersReverse.TryGetValue(del.Method, out var _))
		{
			RemoveTicker(del);
		}
		FTicker fTicker = new FTicker();
		fTicker.del = del;
		Native_FTicker.Reg_CoreTicker(IntPtr.Zero, fTicker.callback, ref fTicker.handle, true, delay);
		handlers[fTicker] = del.Method;
		handlersReverse[del.Method] = fTicker;
	}

	public static void RemoveTicker(FTickerDelegate del)
	{
		if (SharedRuntimeState.IsAOT || del == null || del.Method == null)
		{
			return;
		}
		FTicker value;
		if (!FThreading.IsInGameThread())
		{
			FThreading.RunOnGameThread(delegate
			{
				RemoveTicker(del);
			});
		}
		else if (handlersReverse.TryGetValue(del.Method, out value))
		{
			handlers.Remove(value);
			handlersReverse.Remove(del.Method);
			Native_FTicker.Reg_CoreTicker(IntPtr.Zero, value.callback, ref value.handle, false, 0f);
		}
	}

	public static void Tick(float deltaTime)
	{
		if (SharedRuntimeState.IsAOT)
		{
			return;
		}
		if (!FThreading.IsInGameThread())
		{
			FThreading.RunOnGameThread(delegate
			{
				Tick(deltaTime);
			});
		}
		else
		{
			Native_FTicker.Tick(deltaTime);
		}
	}

	public static void OnUnload()
	{
		if (SharedRuntimeState.IsAOT)
		{
			return;
		}
		foreach (KeyValuePair<FTicker, MethodInfo> item in new Dictionary<FTicker, MethodInfo>(handlers))
		{
			Native_FTicker.Reg_CoreTicker(IntPtr.Zero, item.Key.callback, ref item.Key.handle, false, 0f);
		}
		handlers.Clear();
		handlersReverse.Clear();
	}
}
