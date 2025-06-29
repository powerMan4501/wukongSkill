using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UObjectRedirector
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_DestinationObject(IntPtr instance);

	public static Del_Get_DestinationObject Get_DestinationObject;
}
