using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FWorldContext
{
	[MonoNativeFunctionWrapper]
	public delegate byte Del_Get_WorldType(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_ContextHandle(IntPtr instance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_TravelURL(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate byte Del_Get_TravelType(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GameViewport(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_OwningGameInstance(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_Get_PIEInstance(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_PIEPrefix(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_RunAsDedicated(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_bWaitingOnOnlineSubsystem(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate uint Del_Get_AudioDeviceHandle(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetCurrentWorld(IntPtr instance, IntPtr world);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_World(IntPtr instance);

	public static Del_Get_WorldType Get_WorldType;

	public static Del_Get_ContextHandle Get_ContextHandle;

	public static Del_Get_TravelURL Get_TravelURL;

	public static Del_Get_TravelType Get_TravelType;

	public static Del_Get_GameViewport Get_GameViewport;

	public static Del_Get_OwningGameInstance Get_OwningGameInstance;

	public static Del_Get_PIEInstance Get_PIEInstance;

	public static Del_Get_PIEPrefix Get_PIEPrefix;

	public static Del_Get_RunAsDedicated Get_RunAsDedicated;

	public static Del_Get_bWaitingOnOnlineSubsystem Get_bWaitingOnOnlineSubsystem;

	public static Del_Get_AudioDeviceHandle Get_AudioDeviceHandle;

	public static Del_SetCurrentWorld SetCurrentWorld;

	public static Del_World World;
}
