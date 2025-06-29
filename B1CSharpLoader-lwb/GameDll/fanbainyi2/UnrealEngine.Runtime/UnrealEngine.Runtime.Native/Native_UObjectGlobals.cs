using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UObjectGlobals
{
	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Get_GIsSavingPackage();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsGarbageCollecting();

	[MonoNativeFunctionWrapper]
	public delegate void Del_CollectGarbage(EObjectFlags keepFlags, csbool performFullPurge);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CollectGarbageDefault();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_TryCollectGarbage(EObjectFlags keepFlags, csbool performFullPurge);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_TryCollectGarbageDefault();

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsIncrementalPurgePending();

	[MonoNativeFunctionWrapper]
	public delegate void Del_IncrementalPurgeGarbage(csbool useTimeLimit, float timeLimit);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MakeUniqueObjectName(IntPtr outer, IntPtr unrealClass, ref FName baseName, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MakeObjectNameFromDisplayLabel(ref FScriptArray displayLabel, ref FName currentObjectName, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsReferenced(IntPtr res, EObjectFlags keepFlags, EInternalObjectFlags internalKeepFlags, csbool checkSubObjects, IntPtr foundReferences);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsLoading();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetTransientPackage();

	[MonoNativeFunctionWrapper]
	public delegate void Del_CheckIsClassChildOf_Internal(IntPtr parent, IntPtr child);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StaticConstructObject_Internal(IntPtr unrealClass, IntPtr inOuter, ref FName name, EObjectFlags setFlags, EInternalObjectFlags internalSetFlags, IntPtr template, csbool copyTransientsFromClassDefaults, IntPtr instanceGraph);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StaticDuplicateObject(IntPtr sourceObject, IntPtr destOuter, ref FName destName, EObjectFlags flagMask, IntPtr destClass, EDuplicateMode duplicateMode, EInternalObjectFlags internalFlagsMask);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StaticFindObjectFast(IntPtr unrealClass, IntPtr inOuter, ref FName inName, csbool exactClass, csbool anyPackage, EObjectFlags exclusiveFlags, EInternalObjectFlags exclusiveInternalFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StaticFindObject(IntPtr unrealClass, IntPtr inOuter, ref FScriptArray name, csbool exactClass);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StaticFindObjectChecked(IntPtr unrealClass, IntPtr inOuter, ref FScriptArray name, csbool exactClass);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StaticFindObjectSafe(IntPtr unrealClass, IntPtr inOuter, ref FScriptArray name, csbool exactClass);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StaticLoadObject(IntPtr unrealClass, IntPtr inOuter, ref FScriptArray name, ref FScriptArray filename, ELoadFlags loadFlags, IntPtr sandbox, csbool allowObjectReconciliation);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StaticLoadClass(IntPtr baseClass, IntPtr inOuter, ref FScriptArray name, ref FScriptArray filename, ELoadFlags loadFlags, IntPtr sandbox);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_LoadPackage(IntPtr inOuter, ref FScriptArray inLongPackageName, ELoadFlags loadFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_FindPackage(IntPtr inOuter, ref FScriptArray packageName);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_CreatePackage(ref FScriptArray packageName);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_StaticAllocateObject(IntPtr unrealClass, IntPtr inOuter, ref FName name, EObjectFlags setFlags, EInternalObjectFlags internalSetFlags, csbool canReuseSubobjects, out csbool outReusedSubobject);

	public static Del_Get_GIsSavingPackage Get_GIsSavingPackage;

	public static Del_IsGarbageCollecting IsGarbageCollecting;

	public static Del_CollectGarbage CollectGarbage;

	public static Del_CollectGarbageDefault CollectGarbageDefault;

	public static Del_TryCollectGarbage TryCollectGarbage;

	public static Del_TryCollectGarbageDefault TryCollectGarbageDefault;

	public static Del_IsIncrementalPurgePending IsIncrementalPurgePending;

	public static Del_IncrementalPurgeGarbage IncrementalPurgeGarbage;

	public static Del_MakeUniqueObjectName MakeUniqueObjectName;

	public static Del_MakeObjectNameFromDisplayLabel MakeObjectNameFromDisplayLabel;

	public static Del_IsReferenced IsReferenced;

	public static Del_IsLoading IsLoading;

	public static Del_GetTransientPackage GetTransientPackage;

	public static Del_CheckIsClassChildOf_Internal CheckIsClassChildOf_Internal;

	public static Del_StaticConstructObject_Internal StaticConstructObject_Internal;

	public static Del_StaticDuplicateObject StaticDuplicateObject;

	public static Del_StaticFindObjectFast StaticFindObjectFast;

	public static Del_StaticFindObject StaticFindObject;

	public static Del_StaticFindObjectChecked StaticFindObjectChecked;

	public static Del_StaticFindObjectSafe StaticFindObjectSafe;

	public static Del_StaticLoadObject StaticLoadObject;

	public static Del_StaticLoadClass StaticLoadClass;

	public static Del_LoadPackage LoadPackage;

	public static Del_FindPackage FindPackage;

	public static Del_CreatePackage CreatePackage;

	public static Del_StaticAllocateObject StaticAllocateObject;
}
