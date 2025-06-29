using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FUObjectArray
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetGUObjectArray();

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetObjectArrayNum(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetObjectAtIndex(IntPtr instance, int index);

	public static Del_GetGUObjectArray GetGUObjectArray;

	public static Del_GetObjectArrayNum GetObjectArrayNum;

	public static Del_GetObjectAtIndex GetObjectAtIndex;
}
