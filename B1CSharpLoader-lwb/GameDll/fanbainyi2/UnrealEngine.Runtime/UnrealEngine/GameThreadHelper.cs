using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using AOT;
using UnrealEngine.Runtime;

namespace UnrealEngine;

internal static class GameThreadHelper
{
	public delegate void FSimpleDelegate();

	private class CallbackInfo
	{
		public FSimpleDelegate Callback;

		public AutoResetEvent WaitHandle;
	}

	[MonoNativeFunctionWrapper]
	public delegate bool FTickerDelegate(float deltaTime);

	[MonoNativeFunctionWrapper]
	private delegate void Del_AddStaticTicker(FTickerDelegate func, float delay);

	[MonoNativeFunctionWrapper]
	private delegate csbool Del_IsInGameThread();

	private static Queue<CallbackInfo> callbacks = new Queue<CallbackInfo>();

	private static Del_AddStaticTicker addStaticTicker;

	private static FTickerDelegate ticker;

	private static Del_IsInGameThread isInGameThread;

	private static uint lastRuntimeCounter;

	public static FSimpleDelegate OnRuntimeChanged;

	public static void Init(IntPtr addTickerAddr, IntPtr isInGameThreadAddr, FSimpleDelegate onRuntimeChanged)
	{
		isInGameThread = (Del_IsInGameThread)Marshal.GetDelegateForFunctionPointer(isInGameThreadAddr, typeof(Del_IsInGameThread));
		addStaticTicker = (Del_AddStaticTicker)Marshal.GetDelegateForFunctionPointer(addTickerAddr, typeof(Del_AddStaticTicker));
		ticker = Tick;
		addStaticTicker(ticker, 0f);
		OnRuntimeChanged = onRuntimeChanged;
	}

	public static bool IsInGameThread()
	{
		return isInGameThread();
	}

	private unsafe static bool Tick(float deltaTime)
	{
		if (lastRuntimeCounter != SharedRuntimeState.Instance->RuntimeCounter)
		{
			if (SharedRuntimeState.IsActiveRuntime || SharedRuntimeState.Instance->IsActiveRuntimeComplete != 0)
			{
				lastRuntimeCounter = SharedRuntimeState.Instance->RuntimeCounter;
				OnRuntimeChanged();
			}
			else if (SharedRuntimeState.Instance->NextRuntime == EDotNetRuntime.None)
			{
				lastRuntimeCounter = SharedRuntimeState.Instance->RuntimeCounter;
			}
		}
		else if (SharedRuntimeState.Instance->Reload > 0 && SharedRuntimeState.IsActiveRuntime)
		{
			OnRuntimeChanged();
		}
		lock (callbacks)
		{
			while (callbacks.Count > 0)
			{
				CallbackInfo callbackInfo = callbacks.Dequeue();
				callbackInfo.Callback();
				callbackInfo.WaitHandle.Set();
			}
		}
		return true;
	}

	public static void Run(FSimpleDelegate callback)
	{
		if (IsInGameThread())
		{
			callback();
			return;
		}
		CallbackInfo callbackInfo = new CallbackInfo
		{
			Callback = callback,
			WaitHandle = new AutoResetEvent(initialState: false)
		};
		lock (callbacks)
		{
			callbacks.Enqueue(callbackInfo);
		}
		callbackInfo.WaitHandle.WaitOne(-1);
		callbackInfo.WaitHandle.Close();
	}
}
