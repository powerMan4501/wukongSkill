using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FScriptDelegate
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_ProcessDelegate(ref FScriptDelegate instance, IntPtr parameters);

	public static Del_ProcessDelegate ProcessDelegate;
}
