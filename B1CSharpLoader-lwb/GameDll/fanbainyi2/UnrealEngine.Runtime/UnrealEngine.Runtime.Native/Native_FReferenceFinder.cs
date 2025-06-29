using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FReferenceFinder
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_New(IntPtr objectArray, IntPtr outer, csbool requireDirectOuter, csbool shouldIgnoreArchetype, csbool serializeRecursively, csbool shouldIgnoreTransient);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Delete(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FindReferences(IntPtr instance, IntPtr obj, IntPtr referencingObject, IntPtr referencingProperty);

	public static Del_New New;

	public static Del_Delete Delete;

	public static Del_FindReferences FindReferences;
}
