using System;
using System.Collections.Generic;
using AOT;
using UnrealEngine.Engine;
using UnrealEngine.Runtime.Native;
using UnrealEngine.UnrealEd;

namespace UnrealEngine.Runtime;

public static class StaticVarManager
{
	private delegate void Del_OnPostWorldCleanup(IntPtr world, bool sessionEnded, bool cleanupResources);

	internal static List<StaticVar> Vars = new List<StaticVar>();

	internal static void OnNativeFunctionsRegistered()
	{
		FEditorDelegates.PreBeginPIE.Bind(OnPreBeginPIE);
		FEditorDelegates.EndPIE.Bind(OnEndPIE);
		FWorldDelegates.OnPostWorldCreation.Bind(OnPostWorldCreation);
		FWorldDelegates.OnPostWorldCleanup.Bind(OnPostWorldCleanup);
	}

	internal static void OnUnload()
	{
		foreach (StaticVar var in Vars)
		{
			var.OnUnload();
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidCSBool))]
	private static void OnPreBeginPIE(csbool simulating)
	{
		try
		{
			foreach (StaticVar var in Vars)
			{
				var.OnPIEBegin(simulating);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidCSBool))]
	private static void OnEndPIE(csbool simulating)
	{
		try
		{
			foreach (StaticVar var in Vars)
			{
				var.OnPIEEnd(simulating);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_VoidIntPtr))]
	private static void OnPostWorldCreation(IntPtr world)
	{
		try
		{
			foreach (StaticVar var in Vars)
			{
				var.OnWorldDestroyed(world);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	[MonoPInvokeCallback(typeof(Del_OnPostWorldCleanup))]
	private static void OnPostWorldCleanup(IntPtr world, bool sessionEnded, bool cleanupResources)
	{
		try
		{
			IntPtr intPtr = Native_UWorld.GetGameInstance(world);
			foreach (StaticVar var in Vars)
			{
				if (intPtr != IntPtr.Zero)
				{
					var.OnGameInstanceShutdown(intPtr);
				}
				var.OnWorldDestroyed(world);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}
}
