using System;
using AOT;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public static class UEngineDelegates
{
	public class OnWorldAddedHandler : NativeMulticastDelegate<Native_UEngineDelegates.Del_OnWorldAdded, Native_UEngineDelegates.Del_Reg_OnWorldAdded, OnWorldAddedHandler.Signature>
	{
		public delegate void Signature(IntPtr world);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(IntPtr world)
		{
			try
			{
				NativeDelegate<Native_UEngineDelegates.Del_OnWorldAdded, Native_UEngineDelegates.Del_Reg_OnWorldAdded, Signature>.managed.Delegate?.Invoke(world);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public class OnWorldDestroyedHandler : NativeMulticastDelegate<Native_UEngineDelegates.Del_OnWorldDestroyed, Native_UEngineDelegates.Del_Reg_OnWorldDestroyed, OnWorldDestroyedHandler.Signature>
	{
		public delegate void Signature(IntPtr world);

		[MonoPInvokeCallback(typeof(Signature))]
		private static void NativeCallback(IntPtr world)
		{
			try
			{
				NativeDelegate<Native_UEngineDelegates.Del_OnWorldDestroyed, Native_UEngineDelegates.Del_Reg_OnWorldDestroyed, Signature>.managed.Delegate?.Invoke(world);
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	public static OnWorldAddedHandler OnWorldAdded;

	public static OnWorldDestroyedHandler OnWorldDestroyed;

	static UEngineDelegates()
	{
		OnWorldAdded = new OnWorldAddedHandler();
		OnWorldDestroyed = new OnWorldDestroyedHandler();
		HotReload.RegisterNativeDelegateManager(typeof(UEngineDelegates));
	}
}
