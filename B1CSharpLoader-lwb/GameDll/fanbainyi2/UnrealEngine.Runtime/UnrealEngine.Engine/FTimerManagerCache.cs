using System;
using System.Collections.Generic;
using AOT;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

internal static class FTimerManagerCache
{
	private struct TimerManagerInfo
	{
		public FWeakObjectPtr Owner;

		public FTimerManager TimeManager;
	}

	private static Dictionary<FWeakObjectPtr, IntPtr> timerManagerOwners = new Dictionary<FWeakObjectPtr, IntPtr>();

	private static Dictionary<IntPtr, TimerManagerInfo> timerManagers = new Dictionary<IntPtr, TimerManagerInfo>();

	private static bool hasClasses = false;

	private static IntPtr worldClass;

	private static IntPtr gameInstanceClass;

	private static IntPtr editorEngineClass;

	public static FTimerManager GetManager(IntPtr address)
	{
		if (address == IntPtr.Zero)
		{
			return null;
		}
		if (timerManagers.TryGetValue(address, out var value))
		{
			return value.TimeManager;
		}
		UpdateOwnerClasses();
		IntPtr intPtr = IntPtr.Zero;
		if (intPtr == IntPtr.Zero && worldClass != IntPtr.Zero)
		{
			foreach (IntPtr item in new NativeReflection.NativeObjectIterator(worldClass))
			{
				if (Native_UWorld.GetTimerManager(item) == address)
				{
					IntPtr intPtr3 = Native_UWorld.GetGameInstance(item);
					intPtr = ((!(intPtr3 != IntPtr.Zero) || !(Native_UGameInstance.GetTimerManager(intPtr3) == address)) ? item : intPtr3);
					break;
				}
			}
		}
		if (intPtr == IntPtr.Zero && gameInstanceClass != IntPtr.Zero)
		{
			foreach (IntPtr item2 in new NativeReflection.NativeObjectIterator(gameInstanceClass))
			{
				if (Native_UGameInstance.GetTimerManager(item2) == address)
				{
					intPtr = item2;
					break;
				}
			}
		}
		if (intPtr == IntPtr.Zero && editorEngineClass != IntPtr.Zero)
		{
			foreach (IntPtr item3 in new NativeReflection.NativeObjectIterator(editorEngineClass))
			{
				if (Native_UEditorEngine.GetTimerManager(item3) == address)
				{
					intPtr = item3;
					break;
				}
			}
		}
		if (intPtr != IntPtr.Zero)
		{
			FWeakObjectPtr fWeakObjectPtr = default(FWeakObjectPtr);
			fWeakObjectPtr.Set(intPtr);
			value = new TimerManagerInfo
			{
				Owner = fWeakObjectPtr,
				TimeManager = new FTimerManager(address)
			};
			timerManagers.Add(address, value);
			timerManagerOwners[fWeakObjectPtr] = address;
			return value.TimeManager;
		}
		return new FTimerManager(address);
	}

	private static void UpdateOwnerClasses()
	{
		if (hasClasses)
		{
			return;
		}
		if (worldClass == IntPtr.Zero)
		{
			worldClass = UClass.GetClassAddress("/Script/Engine.World");
		}
		if (gameInstanceClass == IntPtr.Zero)
		{
			gameInstanceClass = UClass.GetClassAddress("/Script/Engine.GameInstance");
		}
		hasClasses = worldClass != IntPtr.Zero && gameInstanceClass != IntPtr.Zero;
		if (FBuild.WithEditor)
		{
			if (editorEngineClass == IntPtr.Zero)
			{
				editorEngineClass = UClass.GetClassAddress("/Script/UnrealEd.EditorEngine");
			}
			hasClasses = hasClasses && editorEngineClass != IntPtr.Zero;
		}
	}

	[MonoPInvokeCallback(typeof(Del_Void))]
	private static void OnPostGarbageCollect()
	{
		try
		{
			List<FWeakObjectPtr> list = null;
			foreach (FWeakObjectPtr key in timerManagerOwners.Keys)
			{
				if (!key.IsValid())
				{
					if (list == null)
					{
						list = new List<FWeakObjectPtr>();
					}
					list.Add(key);
				}
			}
			if (list == null)
			{
				return;
			}
			foreach (FWeakObjectPtr item in list)
			{
				foreach (KeyValuePair<IntPtr, TimerManagerInfo> item2 in new Dictionary<IntPtr, TimerManagerInfo>(timerManagers))
				{
					if (item2.Value.Owner == item)
					{
						timerManagers.Remove(item2.Key);
					}
				}
				timerManagerOwners.Remove(item);
			}
		}
		catch (Exception e)
		{
			USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
		}
	}

	internal static void OnNativeFunctionsRegistered()
	{
		FCoreUObjectDelegates.PostGarbageCollect.Bind(OnPostGarbageCollect);
	}
}
