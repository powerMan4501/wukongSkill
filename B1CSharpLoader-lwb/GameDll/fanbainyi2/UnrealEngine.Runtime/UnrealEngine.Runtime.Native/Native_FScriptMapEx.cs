using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FScriptMapEx
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_FindPairIndex(IntPtr instance, IntPtr key, ref FScriptMapLayout layout, IntPtr KeyProperty);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_FindValue(IntPtr instance, IntPtr key, ref FScriptMapLayout layout, IntPtr KeyProperty);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Add(IntPtr instance, IntPtr key, IntPtr value, ref FScriptMapLayout layout, IntPtr KeyProperty, IntPtr ValueProperty);

	public static Del_FindPairIndex FindPairIndex;

	public static Del_FindValue FindValue;

	public static Del_Add Add;
}
