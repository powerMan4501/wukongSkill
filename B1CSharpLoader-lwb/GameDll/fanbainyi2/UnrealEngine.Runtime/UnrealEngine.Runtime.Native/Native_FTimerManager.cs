using System;
using AOT;
using UnrealEngine.Engine;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FTimerManager
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Tick(IntPtr instance, float deltaTime);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetTimer(IntPtr instance, ref FTimerHandle inOutHandle, ref FScriptDelegate dynDelegate, float rate, bool loop, float firstDelay);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetTimerForNextTick(IntPtr instance, ref FScriptDelegate dynDelegate);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearTimer(IntPtr instance, ref FTimerHandle inOutHandle);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearAllTimersForObject(IntPtr instance, IntPtr obj);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PauseTimer(IntPtr instance, ref FTimerHandle handle);

	[MonoNativeFunctionWrapper]
	public delegate void Del_UnPauseTimer(IntPtr instance, ref FTimerHandle handle);

	[MonoNativeFunctionWrapper]
	public delegate float Del_GetTimerRate(IntPtr instance, ref FTimerHandle handle);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsTimerActive(IntPtr instance, ref FTimerHandle handle);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsTimerPaused(IntPtr instance, ref FTimerHandle handle);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsTimerPending(IntPtr instance, ref FTimerHandle handle);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_TimerExists(IntPtr instance, ref FTimerHandle handle);

	[MonoNativeFunctionWrapper]
	public delegate float Del_GetTimerElapsed(IntPtr instance, ref FTimerHandle handle);

	[MonoNativeFunctionWrapper]
	public delegate float Del_GetTimerRemaining(IntPtr instance, ref FTimerHandle handle);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasBeenTickedThisFrame(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_K2_FindDynamicTimerHandle(IntPtr instance, ref FScriptDelegate dynamicDelegate, ref FTimerHandle result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ListTimers(IntPtr instance);

	public static Del_Tick Tick;

	public static Del_SetTimer SetTimer;

	public static Del_SetTimerForNextTick SetTimerForNextTick;

	public static Del_ClearTimer ClearTimer;

	public static Del_ClearAllTimersForObject ClearAllTimersForObject;

	public static Del_PauseTimer PauseTimer;

	public static Del_UnPauseTimer UnPauseTimer;

	public static Del_GetTimerRate GetTimerRate;

	public static Del_IsTimerActive IsTimerActive;

	public static Del_IsTimerPaused IsTimerPaused;

	public static Del_IsTimerPending IsTimerPending;

	public static Del_TimerExists TimerExists;

	public static Del_GetTimerElapsed GetTimerElapsed;

	public static Del_GetTimerRemaining GetTimerRemaining;

	public static Del_HasBeenTickedThisFrame HasBeenTickedThisFrame;

	public static Del_K2_FindDynamicTimerHandle K2_FindDynamicTimerHandle;

	public static Del_ListTimers ListTimers;
}
