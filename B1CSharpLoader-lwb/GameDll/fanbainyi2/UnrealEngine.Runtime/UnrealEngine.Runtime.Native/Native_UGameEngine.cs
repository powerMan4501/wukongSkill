using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UGameEngine
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_GameInstance(IntPtr instance);

	public static Del_Get_GameInstance Get_GameInstance;
}
