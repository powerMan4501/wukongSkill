using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FARFilter
{
	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_New();

	[MonoNativeFunctionWrapper]
	public delegate void Del_Delete(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_PackageNames(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_PackagePaths(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ObjectPaths(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_ClassNames(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_TagsAndValues(IntPtr instance, IntPtr keys, IntPtr values);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_RecursiveClassesExclusionSet(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_bRecursivePaths(IntPtr instance, csbool value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_bRecursiveClasses(IntPtr instance, csbool value);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_bIncludeOnlyOnDiskAssets(IntPtr instance, csbool value);

	public static Del_New New;

	public static Del_Delete Delete;

	public static Del_Set_PackageNames Set_PackageNames;

	public static Del_Set_PackagePaths Set_PackagePaths;

	public static Del_Set_ObjectPaths Set_ObjectPaths;

	public static Del_Set_ClassNames Set_ClassNames;

	public static Del_Set_TagsAndValues Set_TagsAndValues;

	public static Del_Set_RecursiveClassesExclusionSet Set_RecursiveClassesExclusionSet;

	public static Del_Set_bRecursivePaths Set_bRecursivePaths;

	public static Del_Set_bRecursiveClasses Set_bRecursiveClasses;

	public static Del_Set_bIncludeOnlyOnDiskAssets Set_bIncludeOnlyOnDiskAssets;
}
