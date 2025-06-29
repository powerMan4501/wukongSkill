using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FMulticastScriptDelegate
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_ProcessMulticastDelegate(ref FMulticastScriptDelegate instance, IntPtr parameters);

	public static Del_ProcessMulticastDelegate ProcessMulticastDelegate;
}
