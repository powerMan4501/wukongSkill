using System;
using AOT;
using UnrealEngine.Engine;

namespace UnrealEngine.Runtime.Native;

public static class Native_UEngine
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CopyPropertiesForUnrelatedObjects(IntPtr oldObject, IntPtr newObject, ref FCopyPropertiesForUnrelatedObjectsParams parameters);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldFromContextObject(IntPtr obj, EGetWorldErrorMode errorMode);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromWorld(IntPtr world);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromGameViewport(IntPtr viewport);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromPendingNetGame(IntPtr pendingNetGame);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromPendingNetGameNetDriver(IntPtr pendingNetGame);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromHandle(ref FName worldContextHandle);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromPIEInstance(int pieInstance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromWorldChecked(IntPtr world);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromGameViewportChecked(IntPtr viewport);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromPendingNetGameCheckedChecked(IntPtr pendingNetGame);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromPendingNetGameNetDriverChecked(IntPtr pendingNetGame);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromHandleChecked(ref FName worldContextHandle);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldContextFromPIEInstanceChecked(int pieInstance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetWorldContexts(IntPtr result);

	public static Del_CopyPropertiesForUnrelatedObjects CopyPropertiesForUnrelatedObjects;

	public static Del_GetWorldFromContextObject GetWorldFromContextObject;

	public static Del_GetWorldContextFromWorld GetWorldContextFromWorld;

	public static Del_GetWorldContextFromGameViewport GetWorldContextFromGameViewport;

	public static Del_GetWorldContextFromPendingNetGame GetWorldContextFromPendingNetGame;

	public static Del_GetWorldContextFromPendingNetGameNetDriver GetWorldContextFromPendingNetGameNetDriver;

	public static Del_GetWorldContextFromHandle GetWorldContextFromHandle;

	public static Del_GetWorldContextFromPIEInstance GetWorldContextFromPIEInstance;

	public static Del_GetWorldContextFromWorldChecked GetWorldContextFromWorldChecked;

	public static Del_GetWorldContextFromGameViewportChecked GetWorldContextFromGameViewportChecked;

	public static Del_GetWorldContextFromPendingNetGameCheckedChecked GetWorldContextFromPendingNetGameCheckedChecked;

	public static Del_GetWorldContextFromPendingNetGameNetDriverChecked GetWorldContextFromPendingNetGameNetDriverChecked;

	public static Del_GetWorldContextFromHandleChecked GetWorldContextFromHandleChecked;

	public static Del_GetWorldContextFromPIEInstanceChecked GetWorldContextFromPIEInstanceChecked;

	public static Del_GetWorldContexts GetWorldContexts;
}
