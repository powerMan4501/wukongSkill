using System;
using AOT;
using UnrealEngine.Engine;

namespace UnrealEngine.Runtime.Native;

public static class Native_UWorld
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_Offset_TimeSeconds();

	[MonoNativeFunctionWrapper]
	public delegate int Del_Offset_UnpausedTimeSeconds();

	[MonoNativeFunctionWrapper]
	public delegate int Del_Offset_RealTimeSeconds();

	[MonoNativeFunctionWrapper]
	public delegate int Del_Offset_DeltaTimeSeconds();

	[MonoNativeFunctionWrapper]
	public delegate int Del_Offset_PauseDelay();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_bDebugPauseExecution(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate EWorldType Del_Get_WorldType(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetLevels(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetGameInstance(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetTimerManager(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsPaused(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_SpawnActor(IntPtr instance, IntPtr unrealClass, ref FVector location, ref FRotator rotation, ref FActorSpawnParametersInterop parameters);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_SpawnActorByTransform(IntPtr instance, IntPtr unrealClass, ref FTransform transform, ref FActorSpawnParametersInterop parameters);

	public static Del_Offset_TimeSeconds Offset_TimeSeconds;

	public static Del_Offset_UnpausedTimeSeconds Offset_UnpausedTimeSeconds;

	public static Del_Offset_RealTimeSeconds Offset_RealTimeSeconds;

	public static Del_Offset_DeltaTimeSeconds Offset_DeltaTimeSeconds;

	public static Del_Offset_PauseDelay Offset_PauseDelay;

	public static Del_Get_bDebugPauseExecution Get_bDebugPauseExecution;

	public static Del_Get_WorldType Get_WorldType;

	public static Del_GetLevels GetLevels;

	public static Del_GetGameInstance GetGameInstance;

	public static Del_GetTimerManager GetTimerManager;

	public static Del_IsPaused IsPaused;

	public static Del_SpawnActor SpawnActor;

	public static Del_SpawnActorByTransform SpawnActorByTransform;
}
