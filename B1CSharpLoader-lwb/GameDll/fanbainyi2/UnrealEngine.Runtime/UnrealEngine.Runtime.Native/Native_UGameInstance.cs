using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UGameInstance
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetTimerManager(IntPtr instance);

	public static Del_GetTimerManager GetTimerManager;
}
