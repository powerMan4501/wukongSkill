using System;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

public class FTimerManager
{
	public IntPtr Address { get; private set; }

	public UObject Owner { get; private set; }

	public static FTimerManager EngineEditor
	{
		get
		{
			if (FBuild.WithEditor)
			{
				IntPtr gEditor = FGlobals.GEditor;
				if (gEditor != IntPtr.Zero)
				{
					return FTimerManagerCache.GetManager(Native_UEditorEngine.GetTimerManager(gEditor));
				}
			}
			return null;
		}
	}

	public static FTimerManager PIEWorld
	{
		get
		{
			if (FBuild.WithEditor)
			{
				IntPtr gEditor = FGlobals.GEditor;
				if (gEditor != IntPtr.Zero)
				{
					FWorldContext fWorldContext = new FWorldContext(Native_UEditorEngine.GetPIEWorldContext(gEditor));
					if (fWorldContext.Address != IntPtr.Zero)
					{
						IntPtr currentWorld = fWorldContext.CurrentWorld;
						if (currentWorld != IntPtr.Zero)
						{
							return FTimerManagerCache.GetManager(Native_UWorld.GetTimerManager(currentWorld));
						}
					}
				}
			}
			return null;
		}
	}

	public static FTimerManager EngineWorld
	{
		get
		{
			IntPtr gEngine = FGlobals.GEngine;
			if (gEngine != IntPtr.Zero)
			{
				IntPtr intPtr = Native_UObject.GetWorld(gEngine);
				if (intPtr != IntPtr.Zero)
				{
					return FTimerManagerCache.GetManager(Native_UWorld.GetTimerManager(intPtr));
				}
			}
			return null;
		}
	}

	public static FTimerManager GameInstance
	{
		get
		{
			IntPtr gEngine = FGlobals.GEngine;
			if (gEngine != IntPtr.Zero && Classes.UGameEngine != IntPtr.Zero && (bool)Native_UObjectBaseUtility.IsA(gEngine, Classes.UGameEngine))
			{
				IntPtr intPtr = Native_UGameEngine.Get_GameInstance(gEngine);
				if (intPtr != IntPtr.Zero)
				{
					return FTimerManagerCache.GetManager(Native_UGameInstance.GetTimerManager(intPtr));
				}
			}
			return null;
		}
	}

	internal FTimerManager(IntPtr address)
	{
		Address = address;
	}

	public static FTimerManager GetManager(IntPtr address)
	{
		return FTimerManagerCache.GetManager(address);
	}

	public void Tick(float deltaTime)
	{
		Native_FTimerManager.Tick(Address, deltaTime);
	}

	public FTimerHandle SetTimer(UObject obj, string functionName, float time, bool looping = false, float firstDelay = -1f)
	{
		FTimerHandle inOutHandle = default(FTimerHandle);
		SetTimer(ref inOutHandle, obj, new FName(functionName), time, looping, firstDelay);
		return inOutHandle;
	}

	public FTimerHandle SetTimer(UObject obj, FSimpleDelegate function, float time, bool looping = false, float firstDelay = -1f)
	{
		FTimerHandle inOutHandle = default(FTimerHandle);
		SetTimer(ref inOutHandle, obj, GetFunctionName(obj, function), time, looping, firstDelay);
		return inOutHandle;
	}

	public FTimerHandle SetTimer(UObject obj, FName functionName, float time, bool looping, float firstDelay)
	{
		FTimerHandle inOutHandle = default(FTimerHandle);
		SetTimer(ref inOutHandle, obj, functionName, time, looping, firstDelay);
		return inOutHandle;
	}

	public void SetTimer(ref FTimerHandle inOutHandle, UObject obj, string functionName, float time, bool looping = false, float firstDelay = -1f)
	{
		SetTimer(ref inOutHandle, obj, new FName(functionName), time, looping, firstDelay);
	}

	public void SetTimer(ref FTimerHandle inOutHandle, UObject obj, FSimpleDelegate function, float time, bool looping = false, float firstDelay = -1f)
	{
		SetTimer(ref inOutHandle, obj, GetFunctionName(obj, function), time, looping, firstDelay);
	}

	public void SetTimer(ref FTimerHandle inOutHandle, UObject obj, FName functionName, float time, bool looping, float firstDelay)
	{
		if (ValidateFunction(obj, functionName))
		{
			FScriptDelegate dynDelegate = new FScriptDelegate(obj, functionName);
			Native_FTimerManager.SetTimer(Address, ref inOutHandle, ref dynDelegate, time, looping, firstDelay);
		}
	}

	public void SetTimerForNextTick(UObject obj, FSimpleDelegate function)
	{
		SetTimerForNextTick(obj, GetFunctionName(obj, function));
	}

	public void SetTimerForNextTick(UObject obj, string functionName)
	{
		SetTimerForNextTick(obj, new FName(functionName));
	}

	public void SetTimerForNextTick(UObject obj, FName functionName)
	{
		if (ValidateFunction(obj, functionName))
		{
			FScriptDelegate dynDelegate = new FScriptDelegate(obj, functionName);
			Native_FTimerManager.SetTimerForNextTick(Address, ref dynDelegate);
		}
	}

	public void ClearTimer(ref FTimerHandle handle)
	{
		Native_FTimerManager.ClearTimer(Address, ref handle);
	}

	public void ClearAllTimersForObject(UObject obj)
	{
		Native_FTimerManager.ClearAllTimersForObject(Address, obj.Address);
	}

	public void PauseTimer(FTimerHandle handle)
	{
		Native_FTimerManager.PauseTimer(Address, ref handle);
	}

	public void UnPauseTimer(FTimerHandle handle)
	{
		Native_FTimerManager.UnPauseTimer(Address, ref handle);
	}

	public float GetTimerRate(FTimerHandle handle)
	{
		return Native_FTimerManager.GetTimerRate(Address, ref handle);
	}

	public bool IsTimerActive(FTimerHandle handle)
	{
		return Native_FTimerManager.IsTimerActive(Address, ref handle);
	}

	public bool IsTimerPaused(FTimerHandle handle)
	{
		return Native_FTimerManager.IsTimerPaused(Address, ref handle);
	}

	public bool IsTimerPending(FTimerHandle handle)
	{
		return Native_FTimerManager.IsTimerPending(Address, ref handle);
	}

	public bool TimerExists(FTimerHandle handle)
	{
		return Native_FTimerManager.TimerExists(Address, ref handle);
	}

	public float GetTimerElapsed(FTimerHandle handle)
	{
		return Native_FTimerManager.GetTimerElapsed(Address, ref handle);
	}

	public float GetTimerRemaining(FTimerHandle handle)
	{
		return Native_FTimerManager.GetTimerRemaining(Address, ref handle);
	}

	public bool HasBeenTickedThisFrame()
	{
		return Native_FTimerManager.HasBeenTickedThisFrame(Address);
	}

	public FTimerHandle FindTimerHandle(UObject obj, string functionName)
	{
		return FindTimerHandle(obj, new FName(functionName));
	}

	public FTimerHandle FindTimerHandle(UObject obj, FSimpleDelegate function)
	{
		return FindTimerHandle(obj, GetFunctionName(obj, function));
	}

	public FTimerHandle FindTimerHandle(UObject obj, FName functionName)
	{
		FTimerHandle result = default(FTimerHandle);
		if (obj != null && functionName != FName.None)
		{
			FScriptDelegate dynamicDelegate = new FScriptDelegate(obj, functionName);
			Native_FTimerManager.K2_FindDynamicTimerHandle(Address, ref dynamicDelegate, ref result);
		}
		return result;
	}

	public void ListTimers()
	{
		Native_FTimerManager.ListTimers(Address);
	}

	private static bool ValidateFunction(UObject obj, FName functionName)
	{
		if (obj != null && functionName != FName.None)
		{
			IntPtr intPtr = Native_UObject.FindFunction(obj.Address, ref functionName);
			if (intPtr != IntPtr.Zero && Native_UFunction.Get_ParmsSize(intPtr) > 0)
			{
				FMessage.Log(ELogVerbosity.Warning, "SetTimer passed a function (" + NativeReflection.GetUFieldPathName(intPtr) + ") that expects parameters.");
				return false;
			}
		}
		return true;
	}

	private static FName GetFunctionName(UObject obj, FSimpleDelegate function)
	{
		if (function != null)
		{
			UObject uObject = function.Target as UObject;
			if (uObject != null)
			{
				IntPtr instance = NativeReflection.LookupTable.FindFunction(uObject, function.Method);
				Native_UObjectBase.GetFName(instance, out var result);
				return result;
			}
		}
		return FName.None;
	}
}
