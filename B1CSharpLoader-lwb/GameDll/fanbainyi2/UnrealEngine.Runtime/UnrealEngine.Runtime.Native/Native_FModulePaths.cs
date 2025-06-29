using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FModulePaths
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_FindModulePaths(ref FScriptArray namePattern, csbool canUseCache, IntPtr keys, IntPtr values);

	public static Del_FindModulePaths FindModulePaths;
}
