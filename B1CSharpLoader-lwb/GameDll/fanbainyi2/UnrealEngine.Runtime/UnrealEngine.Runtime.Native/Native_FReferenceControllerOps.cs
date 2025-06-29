using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FReferenceControllerOps
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_GetSharedReferenceCount(IntPtr referenceController, ESPMode mode);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AddSharedReference(IntPtr referenceController, ESPMode mode);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ConditionallyAddSharedReference(IntPtr referenceController, ESPMode mode);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ReleaseSharedReference(IntPtr referenceController, ESPMode mode);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AddWeakReference(IntPtr referenceController, ESPMode mode);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ReleaseWeakReference(IntPtr referenceController, ESPMode mode);

	public static Del_GetSharedReferenceCount GetSharedReferenceCount;

	public static Del_AddSharedReference AddSharedReference;

	public static Del_ConditionallyAddSharedReference ConditionallyAddSharedReference;

	public static Del_ReleaseSharedReference ReleaseSharedReference;

	public static Del_AddWeakReference AddWeakReference;

	public static Del_ReleaseWeakReference ReleaseWeakReference;
}
