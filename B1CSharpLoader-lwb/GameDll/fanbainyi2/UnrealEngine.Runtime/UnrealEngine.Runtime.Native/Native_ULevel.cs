using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_ULevel
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GetLevelBlueprints(IntPtr instance, IntPtr outLevelBlueprints);

	public static Del_GetLevelBlueprints GetLevelBlueprints;
}
