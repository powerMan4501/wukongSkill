using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_ManagedUnrealType
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_GetType(ref FScriptArray path, ref FScriptArray hash, ref IntPtr obj);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AddType(ref FScriptArray path, ref FScriptArray hash, IntPtr obj);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RemoveType(ref FScriptArray path);

	public new static Del_GetType GetType;

	public static Del_AddType AddType;

	public static Del_RemoveType RemoveType;
}
