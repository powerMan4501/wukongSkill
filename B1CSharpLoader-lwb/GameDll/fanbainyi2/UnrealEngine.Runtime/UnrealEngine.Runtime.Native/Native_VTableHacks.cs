using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_VTableHacks
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_VTableCallback(ref FScriptArray dummyName, IntPtr callback);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CallOriginal_GetLifetimeReplicatedProps(IntPtr originalFunc, IntPtr obj, IntPtr outLifetimeProps);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CallOriginal_SetupPlayerInputComponent(IntPtr originalFunc, IntPtr obj, IntPtr inputComponent);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CallOriginal_ActorBeginPlay(IntPtr originalFunc, IntPtr obj);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CallOriginal_ActorEndPlay(IntPtr originalFunc, IntPtr obj, byte endPlayReason);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CallOriginal_ActorComponentBeginPlay(IntPtr originalFunc, IntPtr obj);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CallOriginal_ActorComponentEndPlay(IntPtr originalFunc, IntPtr obj, byte endPlayReason);

	public static Del_Set_VTableCallback Set_VTableCallback;

	public static Del_CallOriginal_GetLifetimeReplicatedProps CallOriginal_GetLifetimeReplicatedProps;

	public static Del_CallOriginal_SetupPlayerInputComponent CallOriginal_SetupPlayerInputComponent;

	public static Del_CallOriginal_ActorBeginPlay CallOriginal_ActorBeginPlay;

	public static Del_CallOriginal_ActorEndPlay CallOriginal_ActorEndPlay;

	public static Del_CallOriginal_ActorComponentBeginPlay CallOriginal_ActorComponentBeginPlay;

	public static Del_CallOriginal_ActorComponentEndPlay CallOriginal_ActorComponentEndPlay;
}
