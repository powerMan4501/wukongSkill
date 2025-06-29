using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UObjectBaseUtility
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_SetFlags(IntPtr instance, EObjectFlags newFlags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearFlags(IntPtr instance, EObjectFlags newFlags);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAnyFlags(IntPtr instance, EObjectFlags flagsToCheck);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAllFlags(IntPtr instance, EObjectFlags flagsToCheck);

	[MonoNativeFunctionWrapper]
	public delegate EObjectFlags Del_GetMaskedFlags(IntPtr instance, EObjectFlags mask);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Mark(IntPtr instance, EObjectMark marks);

	[MonoNativeFunctionWrapper]
	public delegate void Del_UnMark(IntPtr instance, EObjectMark marks);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAnyMarks(IntPtr instance, EObjectMark marks);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAllMarks(IntPtr instance, EObjectMark marks);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsPendingKill(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MarkPendingKill(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearPendingKill(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AddToRoot(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RemoveFromRoot(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsRooted(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ThisThreadAtomicallyClearedRFUnreachable(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsUnreachable(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsPendingKillOrUnreachable(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsNative(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetInternalFlags(IntPtr instance, EInternalObjectFlags flagsToSet);

	[MonoNativeFunctionWrapper]
	public delegate EInternalObjectFlags Del_GetInternalFlags(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAnyInternalFlags(IntPtr instance, EInternalObjectFlags flagsToCheck);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearInternalFlags(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_AtomicallyClearInternalFlags(IntPtr instance, EInternalObjectFlags flagsToCheck);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetFullName(IntPtr instance, IntPtr stopOuter, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetPathName(IntPtr instance, IntPtr stopOuter, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CanBeClusterRoot(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CanBeInCluster(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CreateCluster(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_OnClusterMarkedAsPendingKill(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AddToCluster(IntPtr instance, IntPtr clusterRootOrObjectFromCluster, csbool addAsMutableObject);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetFullGroupName(IntPtr instance, csbool startWithOuter, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetName(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetNameOut(IntPtr instance, ref FScriptArray resultString);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AppendName(IntPtr instance, ref FScriptArray resultString);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetOutermost(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_MarkPackageDirty(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsTemplate(IntPtr instance, EObjectFlags templateTypes);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetTypedOuter(IntPtr instance, IntPtr target);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsIn(IntPtr instance, IntPtr someOuter);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInA(IntPtr instance, IntPtr someBaseClass);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_RootPackageHasAnyFlags(IntPtr instance, EPackageFlags checkFlagMask);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsA(IntPtr instance, IntPtr someBaseClass);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_FindNearestCommonBaseClass(IntPtr instance, IntPtr testClass);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetInterfaceAddress(IntPtr instance, IntPtr interfaceClass);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetNativeInterfaceAddress(IntPtr instance, IntPtr interfaceClass);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsDefaultSubobject(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetLinker(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetLinkerIndex(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetLinkerUE4Version(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetLinkerLicenseeUE4Version(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetLinkerCustomVersion(IntPtr instance, ref Guid customVersionKey);

	public static Del_SetFlags SetFlags;

	public static Del_ClearFlags ClearFlags;

	public static Del_HasAnyFlags HasAnyFlags;

	public static Del_HasAllFlags HasAllFlags;

	public static Del_GetMaskedFlags GetMaskedFlags;

	public static Del_Mark Mark;

	public static Del_UnMark UnMark;

	public static Del_HasAnyMarks HasAnyMarks;

	public static Del_HasAllMarks HasAllMarks;

	public static Del_IsPendingKill IsPendingKill;

	public static Del_MarkPendingKill MarkPendingKill;

	public static Del_ClearPendingKill ClearPendingKill;

	public static Del_AddToRoot AddToRoot;

	public static Del_RemoveFromRoot RemoveFromRoot;

	public static Del_IsRooted IsRooted;

	public static Del_ThisThreadAtomicallyClearedRFUnreachable ThisThreadAtomicallyClearedRFUnreachable;

	public static Del_IsUnreachable IsUnreachable;

	public static Del_IsPendingKillOrUnreachable IsPendingKillOrUnreachable;

	public static Del_IsNative IsNative;

	public static Del_SetInternalFlags SetInternalFlags;

	public static Del_GetInternalFlags GetInternalFlags;

	public static Del_HasAnyInternalFlags HasAnyInternalFlags;

	public static Del_ClearInternalFlags ClearInternalFlags;

	public static Del_AtomicallyClearInternalFlags AtomicallyClearInternalFlags;

	public static Del_GetFullName GetFullName;

	public static Del_GetPathName GetPathName;

	public static Del_CanBeClusterRoot CanBeClusterRoot;

	public static Del_CanBeInCluster CanBeInCluster;

	public static Del_CreateCluster CreateCluster;

	public static Del_OnClusterMarkedAsPendingKill OnClusterMarkedAsPendingKill;

	public static Del_AddToCluster AddToCluster;

	public static Del_GetFullGroupName GetFullGroupName;

	public static Del_GetName GetName;

	public static Del_GetNameOut GetNameOut;

	public static Del_AppendName AppendName;

	public static Del_GetOutermost GetOutermost;

	public static Del_MarkPackageDirty MarkPackageDirty;

	public static Del_IsTemplate IsTemplate;

	public static Del_GetTypedOuter GetTypedOuter;

	public static Del_IsIn IsIn;

	public static Del_IsInA IsInA;

	public static Del_RootPackageHasAnyFlags RootPackageHasAnyFlags;

	public static Del_IsA IsA;

	public static Del_FindNearestCommonBaseClass FindNearestCommonBaseClass;

	public static Del_GetInterfaceAddress GetInterfaceAddress;

	public static Del_GetNativeInterfaceAddress GetNativeInterfaceAddress;

	public static Del_IsDefaultSubobject IsDefaultSubobject;

	public static Del_GetLinker GetLinker;

	public static Del_GetLinkerIndex GetLinkerIndex;

	public static Del_GetLinkerUE4Version GetLinkerUE4Version;

	public static Del_GetLinkerLicenseeUE4Version GetLinkerLicenseeUE4Version;

	public static Del_GetLinkerCustomVersion GetLinkerCustomVersion;
}
