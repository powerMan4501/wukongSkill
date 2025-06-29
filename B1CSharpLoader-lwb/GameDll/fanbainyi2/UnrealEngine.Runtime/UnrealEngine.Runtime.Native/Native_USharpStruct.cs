using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_USharpStruct
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_CreateGuid(IntPtr instance);

	public static Del_CreateGuid CreateGuid;
}
