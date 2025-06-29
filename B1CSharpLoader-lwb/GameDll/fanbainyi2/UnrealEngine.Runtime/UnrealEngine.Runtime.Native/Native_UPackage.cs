using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UPackage
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_Get_FileName(IntPtr instance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_FileName(IntPtr instance, ref FName value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_MetaData(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate float Del_GetLoadTime(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetFolderName(IntPtr instance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetDirtyFlag(IntPtr instance, csbool isDirty);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsDirty(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MarkAsFullyLoaded(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsFullyLoaded(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FullyLoad(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ContainsMap(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetPackageFlags(IntPtr instance, EPackageFlags newFlags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearPackageFlags(IntPtr instance, EPackageFlags newFlags);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAnyPackageFlags(IntPtr instance, EPackageFlags flagsToCheck);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_HasAllPackagesFlags(IntPtr instance, EPackageFlags flagsToCheck);

	[MonoNativeFunctionWrapper]
	public delegate EPackageFlags Del_GetPackageFlags(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetGuid(IntPtr instance, out Guid result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_MakeNewGuid(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetGuid(IntPtr instance, ref Guid guid);

	[MonoNativeFunctionWrapper]
	public delegate long Del_GetFileSize(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetMetaData(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_WaitForAsyncFileWrites();

	public static Del_Get_FileName Get_FileName;

	public static Del_Set_FileName Set_FileName;

	public static Del_Get_MetaData Get_MetaData;

	public static Del_GetLoadTime GetLoadTime;

	public static Del_GetFolderName GetFolderName;

	public static Del_SetDirtyFlag SetDirtyFlag;

	public static Del_IsDirty IsDirty;

	public static Del_MarkAsFullyLoaded MarkAsFullyLoaded;

	public static Del_IsFullyLoaded IsFullyLoaded;

	public static Del_FullyLoad FullyLoad;

	public static Del_ContainsMap ContainsMap;

	public static Del_SetPackageFlags SetPackageFlags;

	public static Del_ClearPackageFlags ClearPackageFlags;

	public static Del_HasAnyPackageFlags HasAnyPackageFlags;

	public static Del_HasAllPackagesFlags HasAllPackagesFlags;

	public static Del_GetPackageFlags GetPackageFlags;

	public static Del_GetGuid GetGuid;

	public static Del_MakeNewGuid MakeNewGuid;

	public static Del_SetGuid SetGuid;

	public static Del_GetFileSize GetFileSize;

	public static Del_GetMetaData GetMetaData;

	public static Del_WaitForAsyncFileWrites WaitForAsyncFileWrites;
}
