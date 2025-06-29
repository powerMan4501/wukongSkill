using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_AActor
{
	[MonoNativeFunctionWrapper]
	public delegate float Del_GetActorTimeDilationOrDefault(IntPtr worldContextObject);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorld(IntPtr instance);

	public static Del_GetActorTimeDilationOrDefault GetActorTimeDilationOrDefault;

	public static Del_GetWorld GetWorld;
}
