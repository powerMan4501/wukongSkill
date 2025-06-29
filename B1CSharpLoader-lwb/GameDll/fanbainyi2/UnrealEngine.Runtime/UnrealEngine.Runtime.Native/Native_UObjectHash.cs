using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UObjectHash
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_GetObjectsWithOuter(IntPtr outer, IntPtr results, csbool includeNestedObjects, EObjectFlags exclusionFlags, EInternalObjectFlags exclusionInternalFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_FindObjectWithOuter(IntPtr outer, IntPtr classToLookFor, ref FName nameToLookFor);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetObjectsOfClass(IntPtr classToLookFor, IntPtr results, csbool includeDerivedClasses, EObjectFlags additionalExcludeFlags, EInternalObjectFlags exclusionInternalFlags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetDerivedClasses(IntPtr classToLookFor, IntPtr results, csbool recursive);

	public static Del_GetObjectsWithOuter GetObjectsWithOuter;

	public static Del_FindObjectWithOuter FindObjectWithOuter;

	public static Del_GetObjectsOfClass GetObjectsOfClass;

	public static Del_GetDerivedClasses GetDerivedClasses;
}
