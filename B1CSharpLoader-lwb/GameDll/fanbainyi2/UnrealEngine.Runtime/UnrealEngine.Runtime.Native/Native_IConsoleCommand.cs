using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_IConsoleCommand
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_Execute(IntPtr instance, IntPtr args, IntPtr world, IntPtr outputDevice);

	public static Del_Execute Execute;
}
