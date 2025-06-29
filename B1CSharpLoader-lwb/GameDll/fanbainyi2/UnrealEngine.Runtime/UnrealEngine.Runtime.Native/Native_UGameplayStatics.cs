using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

public static class Native_UGameplayStatics
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GetAllActorsOfClass(IntPtr WorldContextObject, IntPtr ActorClass, IntPtr OutActors);

	public static Del_GetAllActorsOfClass GetAllActorsOfClass;
}
