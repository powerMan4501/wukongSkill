using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FObjectInitializer
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetArchetype(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetObj(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetClass(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_CreateEditorOnlyDefaultSubobject(IntPtr instance, IntPtr outer, ref FName subobjectName, IntPtr returnType, csbool transient);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_CreateDefaultSubobject(IntPtr instance, IntPtr outer, ref FName subobjectFName, IntPtr returnType, IntPtr classToCreateByDefault, csbool isRequired, csbool isTransient);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_DoNotCreateDefaultSubobject(IntPtr instance, ref FName subobjectName);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_DoNotCreateDefaultSubobjectStr(IntPtr instance, ref FScriptArray subobjectName);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IslegalOverride(IntPtr instance, ref FName componentName, IntPtr derivedComponentClass, IntPtr baseComponentClass);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FinalizeSubobjectClassInitialization(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AssertIfInConstructor(IntPtr outer, ref FScriptArray errorMessage);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get();

	public static Del_GetArchetype GetArchetype;

	public static Del_GetObj GetObj;

	public static Del_GetClass GetClass;

	public static Del_CreateEditorOnlyDefaultSubobject CreateEditorOnlyDefaultSubobject;

	public static Del_CreateDefaultSubobject CreateDefaultSubobject;

	public static Del_DoNotCreateDefaultSubobject DoNotCreateDefaultSubobject;

	public static Del_DoNotCreateDefaultSubobjectStr DoNotCreateDefaultSubobjectStr;

	public static Del_IslegalOverride IslegalOverride;

	public static Del_FinalizeSubobjectClassInitialization FinalizeSubobjectClassInitialization;

	public static Del_AssertIfInConstructor AssertIfInConstructor;

	public static Del_Get Get;
}
