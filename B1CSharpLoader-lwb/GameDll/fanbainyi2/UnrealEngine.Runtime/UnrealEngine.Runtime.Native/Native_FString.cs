using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FString
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_GetCharSize();

	[MonoNativeFunctionWrapper]
	public delegate void Del_FromCharPtr(IntPtr charArray, ref FScriptArray result);

	public static Del_GetCharSize GetCharSize;

	public static Del_FromCharPtr FromCharPtr;
}
