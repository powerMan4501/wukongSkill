using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_AssetUtilFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool LoadObjectsFromAssetData_IsValid;

	private static IntPtr LoadObjectsFromAssetData_FunctionAddress;

	private static int LoadObjectsFromAssetData_ParamsSize;

	private static bool LoadObjectsFromAssetData_Assets_IsValid;

	private static FFieldAddress LoadObjectsFromAssetData_Assets_PropertyAddress;

	private static int LoadObjectsFromAssetData_Assets_Offset;

	private static bool LoadObjectsFromAssetData_ReturnValue_IsValid;

	private static FFieldAddress LoadObjectsFromAssetData_ReturnValue_PropertyAddress;

	private static int LoadObjectsFromAssetData_ReturnValue_Offset;

	private static bool GetReferenceAssetsFromObjects_IsValid;

	private static IntPtr GetReferenceAssetsFromObjects_FunctionAddress;

	private static int GetReferenceAssetsFromObjects_ParamsSize;

	private static bool GetReferenceAssetsFromObjects_LoadedSourceAssets_IsValid;

	private static FFieldAddress GetReferenceAssetsFromObjects_LoadedSourceAssets_PropertyAddress;

	private static int GetReferenceAssetsFromObjects_LoadedSourceAssets_Offset;

	private static bool GetReferenceAssetsFromObjects_ReturnValue_IsValid;

	private static FFieldAddress GetReferenceAssetsFromObjects_ReturnValue_PropertyAddress;

	private static int GetReferenceAssetsFromObjects_ReturnValue_Offset;

	private static bool GetReferenceAssetsFromAssets_IsValid;

	private static IntPtr GetReferenceAssetsFromAssets_FunctionAddress;

	private static int GetReferenceAssetsFromAssets_ParamsSize;

	private static bool GetReferenceAssetsFromAssets_Assets_IsValid;

	private static FFieldAddress GetReferenceAssetsFromAssets_Assets_PropertyAddress;

	private static int GetReferenceAssetsFromAssets_Assets_Offset;

	private static bool GetReferenceAssetsFromAssets_ReturnValue_IsValid;

	private static FFieldAddress GetReferenceAssetsFromAssets_ReturnValue_PropertyAddress;

	private static int GetReferenceAssetsFromAssets_ReturnValue_Offset;

	private static bool GetDependenciesAssetsFromAssets_IsValid;

	private static IntPtr GetDependenciesAssetsFromAssets_FunctionAddress;

	private static int GetDependenciesAssetsFromAssets_ParamsSize;

	private static bool GetDependenciesAssetsFromAssets_Assets_IsValid;

	private static FFieldAddress GetDependenciesAssetsFromAssets_Assets_PropertyAddress;

	private static int GetDependenciesAssetsFromAssets_Assets_Offset;

	private static bool GetDependenciesAssetsFromAssets_ReturnValue_IsValid;

	private static FFieldAddress GetDependenciesAssetsFromAssets_ReturnValue_PropertyAddress;

	private static int GetDependenciesAssetsFromAssets_ReturnValue_Offset;

	private static bool GetAssetsInFolder_IsValid;

	private static IntPtr GetAssetsInFolder_FunctionAddress;

	private static int GetAssetsInFolder_ParamsSize;

	private static bool GetAssetsInFolder_FolderPath_IsValid;

	private static FFieldAddress GetAssetsInFolder_FolderPath_PropertyAddress;

	private static int GetAssetsInFolder_FolderPath_Offset;

	private static bool GetAssetsInFolder_bRecursive_IsValid;

	private static FFieldAddress GetAssetsInFolder_bRecursive_PropertyAddress;

	private static int GetAssetsInFolder_bRecursive_Offset;

	private static bool GetAssetsInFolder_bIncludeOnlyOnDiskAssets_IsValid;

	private static FFieldAddress GetAssetsInFolder_bIncludeOnlyOnDiskAssets_PropertyAddress;

	private static int GetAssetsInFolder_bIncludeOnlyOnDiskAssets_Offset;

	private static bool GetAssetsInFolder_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsInFolder_ReturnValue_PropertyAddress;

	private static int GetAssetsInFolder_ReturnValue_Offset;

	private static bool GetAssetsByPath_IsValid;

	private static IntPtr GetAssetsByPath_FunctionAddress;

	private static int GetAssetsByPath_ParamsSize;

	private static bool GetAssetsByPath_Paths_IsValid;

	private static FFieldAddress GetAssetsByPath_Paths_PropertyAddress;

	private static int GetAssetsByPath_Paths_Offset;

	private static bool GetAssetsByPath_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsByPath_ReturnValue_PropertyAddress;

	private static int GetAssetsByPath_ReturnValue_Offset;

	private static bool GetAssetDataTagValue_IsValid;

	private static IntPtr GetAssetDataTagValue_FunctionAddress;

	private static int GetAssetDataTagValue_ParamsSize;

	private static bool GetAssetDataTagValue_AssetData_IsValid;

	private static FFieldAddress GetAssetDataTagValue_AssetData_PropertyAddress;

	private static int GetAssetDataTagValue_AssetData_Offset;

	private static bool GetAssetDataTagValue_TagName_IsValid;

	private static FFieldAddress GetAssetDataTagValue_TagName_PropertyAddress;

	private static int GetAssetDataTagValue_TagName_Offset;

	private static bool GetAssetDataTagValue_ReturnValue_IsValid;

	private static FFieldAddress GetAssetDataTagValue_ReturnValue_PropertyAddress;

	private static int GetAssetDataTagValue_ReturnValue_Offset;

	private static bool GetAssetDataFromPackageObj_IsValid;

	private static IntPtr GetAssetDataFromPackageObj_FunctionAddress;

	private static int GetAssetDataFromPackageObj_ParamsSize;

	private static bool GetAssetDataFromPackageObj_PackageObjects_IsValid;

	private static FFieldAddress GetAssetDataFromPackageObj_PackageObjects_PropertyAddress;

	private static int GetAssetDataFromPackageObj_PackageObjects_Offset;

	private static bool GetAssetDataFromPackageObj_ReturnValue_IsValid;

	private static FFieldAddress GetAssetDataFromPackageObj_ReturnValue_PropertyAddress;

	private static int GetAssetDataFromPackageObj_ReturnValue_Offset;

	private static bool GetAssetDataClass_IsValid;

	private static IntPtr GetAssetDataClass_FunctionAddress;

	private static int GetAssetDataClass_ParamsSize;

	private static bool GetAssetDataClass_AssetData_IsValid;

	private static FFieldAddress GetAssetDataClass_AssetData_PropertyAddress;

	private static int GetAssetDataClass_AssetData_Offset;

	private static bool GetAssetDataClass_ReturnValue_IsValid;

	private static FFieldAddress GetAssetDataClass_ReturnValue_PropertyAddress;

	private static int GetAssetDataClass_ReturnValue_Offset;

	private static bool GetAssetDataAsset_IsValid;

	private static IntPtr GetAssetDataAsset_FunctionAddress;

	private static int GetAssetDataAsset_ParamsSize;

	private static bool GetAssetDataAsset_AssetData_IsValid;

	private static FFieldAddress GetAssetDataAsset_AssetData_PropertyAddress;

	private static int GetAssetDataAsset_AssetData_Offset;

	private static bool GetAssetDataAsset_ReturnValue_IsValid;

	private static FFieldAddress GetAssetDataAsset_ReturnValue_PropertyAddress;

	private static int GetAssetDataAsset_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib:LoadObjectsFromAssetData")]
	public unsafe static List<UObject> LoadObjectsFromAssetData(UAssetDataArray Assets)
	{
		if (!LoadObjectsFromAssetData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AssetUtilFuncLib:LoadObjectsFromAssetData");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadObjectsFromAssetData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadObjectsFromAssetData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, LoadObjectsFromAssetData_Assets_Offset), 0, LoadObjectsFromAssetData_Assets_PropertyAddress.Address, Assets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadObjectsFromAssetData_FunctionAddress, intPtr, LoadObjectsFromAssetData_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, LoadObjectsFromAssetData_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, LoadObjectsFromAssetData_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(LoadObjectsFromAssetData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetReferenceAssetsFromObjects")]
	public unsafe static UAssetDataArray GetReferenceAssetsFromObjects(List<UObject> LoadedSourceAssets)
	{
		if (!GetReferenceAssetsFromObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetReferenceAssetsFromObjects");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReferenceAssetsFromObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReferenceAssetsFromObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, GetReferenceAssetsFromObjects_LoadedSourceAssets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, GetReferenceAssetsFromObjects_LoadedSourceAssets_Offset), LoadedSourceAssets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetReferenceAssetsFromObjects_FunctionAddress, intPtr, GetReferenceAssetsFromObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetReferenceAssetsFromObjects_LoadedSourceAssets_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetReferenceAssetsFromObjects_ReturnValue_Offset), 0, GetReferenceAssetsFromObjects_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetReferenceAssetsFromAssets")]
	public unsafe static UAssetDataArray GetReferenceAssetsFromAssets(UAssetDataArray Assets)
	{
		if (!GetReferenceAssetsFromAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetReferenceAssetsFromAssets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReferenceAssetsFromAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReferenceAssetsFromAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, GetReferenceAssetsFromAssets_Assets_Offset), 0, GetReferenceAssetsFromAssets_Assets_PropertyAddress.Address, Assets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetReferenceAssetsFromAssets_FunctionAddress, intPtr, GetReferenceAssetsFromAssets_ParamsSize);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetReferenceAssetsFromAssets_ReturnValue_Offset), 0, GetReferenceAssetsFromAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetDependenciesAssetsFromAssets")]
	public unsafe static UAssetDataArray GetDependenciesAssetsFromAssets(UAssetDataArray Assets)
	{
		if (!GetDependenciesAssetsFromAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetDependenciesAssetsFromAssets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDependenciesAssetsFromAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDependenciesAssetsFromAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, GetDependenciesAssetsFromAssets_Assets_Offset), 0, GetDependenciesAssetsFromAssets_Assets_PropertyAddress.Address, Assets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDependenciesAssetsFromAssets_FunctionAddress, intPtr, GetDependenciesAssetsFromAssets_ParamsSize);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetDependenciesAssetsFromAssets_ReturnValue_Offset), 0, GetDependenciesAssetsFromAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetsInFolder")]
	public unsafe static UAssetDataArray GetAssetsInFolder(FName FolderPath, bool bRecursive = false, bool bIncludeOnlyOnDiskAssets = false)
	{
		if (!GetAssetsInFolder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetsInFolder");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsInFolder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsInFolder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAssetsInFolder_FolderPath_Offset), 0, GetAssetsInFolder_FolderPath_PropertyAddress.Address, FolderPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsInFolder_bRecursive_Offset), 0, GetAssetsInFolder_bRecursive_PropertyAddress.Address, bRecursive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsInFolder_bIncludeOnlyOnDiskAssets_Offset), 0, GetAssetsInFolder_bIncludeOnlyOnDiskAssets_PropertyAddress.Address, bIncludeOnlyOnDiskAssets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetsInFolder_FunctionAddress, intPtr, GetAssetsInFolder_ParamsSize);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetAssetsInFolder_ReturnValue_Offset), 0, GetAssetsInFolder_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetsByPath")]
	public unsafe static UAssetDataArray GetAssetsByPath(List<string> Paths)
	{
		if (!GetAssetsByPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetsByPath");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsByPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsByPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, GetAssetsByPath_Paths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GetAssetsByPath_Paths_Offset), Paths);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetsByPath_FunctionAddress, intPtr, GetAssetsByPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetsByPath_Paths_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetAssetsByPath_ReturnValue_Offset), 0, GetAssetsByPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339878913u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataTagValue")]
	public unsafe static string GetAssetDataTagValue(UAssetDataArray AssetData, FName TagName)
	{
		if (!GetAssetDataTagValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataTagValue");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetDataTagValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetDataTagValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, GetAssetDataTagValue_AssetData_Offset), 0, GetAssetDataTagValue_AssetData_PropertyAddress.Address, AssetData);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAssetDataTagValue_TagName_Offset), 0, GetAssetDataTagValue_TagName_PropertyAddress.Address, TagName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetDataTagValue_FunctionAddress, intPtr, GetAssetDataTagValue_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAssetDataTagValue_ReturnValue_Offset), 0, GetAssetDataTagValue_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAssetDataTagValue_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataFromPackageObj")]
	public unsafe static UAssetDataArray GetAssetDataFromPackageObj(List<UObject> PackageObjects)
	{
		if (!GetAssetDataFromPackageObj_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataFromPackageObj");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetDataFromPackageObj_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetDataFromPackageObj_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, GetAssetDataFromPackageObj_PackageObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, GetAssetDataFromPackageObj_PackageObjects_Offset), PackageObjects);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetDataFromPackageObj_FunctionAddress, intPtr, GetAssetDataFromPackageObj_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetDataFromPackageObj_PackageObjects_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UAssetDataArray>.FromNative(IntPtr.Add(intPtr, GetAssetDataFromPackageObj_ReturnValue_Offset), 0, GetAssetDataFromPackageObj_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataClass")]
	public unsafe static TSubclassOf<UObject> GetAssetDataClass(UAssetDataArray AssetData)
	{
		if (!GetAssetDataClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetDataClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetDataClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, GetAssetDataClass_AssetData_Offset), 0, GetAssetDataClass_AssetData_PropertyAddress.Address, AssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetDataClass_FunctionAddress, intPtr, GetAssetDataClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetAssetDataClass_ReturnValue_Offset), 0, GetAssetDataClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataAsset")]
	public unsafe static UObject GetAssetDataAsset(UAssetDataArray AssetData)
	{
		if (!GetAssetDataAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetDataAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetDataAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAssetDataArray>.ToNative(IntPtr.Add(intPtr, GetAssetDataAsset_AssetData_Offset), 0, GetAssetDataAsset_AssetData_PropertyAddress.Address, AssetData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetDataAsset_FunctionAddress, intPtr, GetAssetDataAsset_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetAssetDataAsset_ReturnValue_Offset), 0, GetAssetDataAsset_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_AssetUtilFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_AssetUtilFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_AssetUtilFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_AssetUtilFuncLib");
		LoadObjectsFromAssetData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadObjectsFromAssetData");
		LoadObjectsFromAssetData_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadObjectsFromAssetData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadObjectsFromAssetData_Assets_PropertyAddress, LoadObjectsFromAssetData_FunctionAddress, "Assets");
		LoadObjectsFromAssetData_Assets_Offset = NativeReflectionCached.GetPropertyOffset(LoadObjectsFromAssetData_FunctionAddress, "Assets");
		LoadObjectsFromAssetData_Assets_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadObjectsFromAssetData_FunctionAddress, "Assets", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadObjectsFromAssetData_ReturnValue_PropertyAddress, LoadObjectsFromAssetData_FunctionAddress, "ReturnValue");
		LoadObjectsFromAssetData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadObjectsFromAssetData_FunctionAddress, "ReturnValue");
		LoadObjectsFromAssetData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadObjectsFromAssetData_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		LoadObjectsFromAssetData_IsValid = LoadObjectsFromAssetData_FunctionAddress != IntPtr.Zero && LoadObjectsFromAssetData_Assets_IsValid && LoadObjectsFromAssetData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AssetUtilFuncLib:LoadObjectsFromAssetData", LoadObjectsFromAssetData_IsValid);
		GetReferenceAssetsFromObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetReferenceAssetsFromObjects");
		GetReferenceAssetsFromObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReferenceAssetsFromObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReferenceAssetsFromObjects_LoadedSourceAssets_PropertyAddress, GetReferenceAssetsFromObjects_FunctionAddress, "LoadedSourceAssets");
		GetReferenceAssetsFromObjects_LoadedSourceAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetReferenceAssetsFromObjects_FunctionAddress, "LoadedSourceAssets");
		GetReferenceAssetsFromObjects_LoadedSourceAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferenceAssetsFromObjects_FunctionAddress, "LoadedSourceAssets", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferenceAssetsFromObjects_ReturnValue_PropertyAddress, GetReferenceAssetsFromObjects_FunctionAddress, "ReturnValue");
		GetReferenceAssetsFromObjects_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReferenceAssetsFromObjects_FunctionAddress, "ReturnValue");
		GetReferenceAssetsFromObjects_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferenceAssetsFromObjects_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetReferenceAssetsFromObjects_IsValid = GetReferenceAssetsFromObjects_FunctionAddress != IntPtr.Zero && GetReferenceAssetsFromObjects_LoadedSourceAssets_IsValid && GetReferenceAssetsFromObjects_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetReferenceAssetsFromObjects", GetReferenceAssetsFromObjects_IsValid);
		GetReferenceAssetsFromAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetReferenceAssetsFromAssets");
		GetReferenceAssetsFromAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReferenceAssetsFromAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReferenceAssetsFromAssets_Assets_PropertyAddress, GetReferenceAssetsFromAssets_FunctionAddress, "Assets");
		GetReferenceAssetsFromAssets_Assets_Offset = NativeReflectionCached.GetPropertyOffset(GetReferenceAssetsFromAssets_FunctionAddress, "Assets");
		GetReferenceAssetsFromAssets_Assets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferenceAssetsFromAssets_FunctionAddress, "Assets", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferenceAssetsFromAssets_ReturnValue_PropertyAddress, GetReferenceAssetsFromAssets_FunctionAddress, "ReturnValue");
		GetReferenceAssetsFromAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReferenceAssetsFromAssets_FunctionAddress, "ReturnValue");
		GetReferenceAssetsFromAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferenceAssetsFromAssets_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetReferenceAssetsFromAssets_IsValid = GetReferenceAssetsFromAssets_FunctionAddress != IntPtr.Zero && GetReferenceAssetsFromAssets_Assets_IsValid && GetReferenceAssetsFromAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetReferenceAssetsFromAssets", GetReferenceAssetsFromAssets_IsValid);
		GetDependenciesAssetsFromAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDependenciesAssetsFromAssets");
		GetDependenciesAssetsFromAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDependenciesAssetsFromAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDependenciesAssetsFromAssets_Assets_PropertyAddress, GetDependenciesAssetsFromAssets_FunctionAddress, "Assets");
		GetDependenciesAssetsFromAssets_Assets_Offset = NativeReflectionCached.GetPropertyOffset(GetDependenciesAssetsFromAssets_FunctionAddress, "Assets");
		GetDependenciesAssetsFromAssets_Assets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependenciesAssetsFromAssets_FunctionAddress, "Assets", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDependenciesAssetsFromAssets_ReturnValue_PropertyAddress, GetDependenciesAssetsFromAssets_FunctionAddress, "ReturnValue");
		GetDependenciesAssetsFromAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDependenciesAssetsFromAssets_FunctionAddress, "ReturnValue");
		GetDependenciesAssetsFromAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependenciesAssetsFromAssets_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetDependenciesAssetsFromAssets_IsValid = GetDependenciesAssetsFromAssets_FunctionAddress != IntPtr.Zero && GetDependenciesAssetsFromAssets_Assets_IsValid && GetDependenciesAssetsFromAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetDependenciesAssetsFromAssets", GetDependenciesAssetsFromAssets_IsValid);
		GetAssetsInFolder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetsInFolder");
		GetAssetsInFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsInFolder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsInFolder_FolderPath_PropertyAddress, GetAssetsInFolder_FunctionAddress, "FolderPath");
		GetAssetsInFolder_FolderPath_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsInFolder_FunctionAddress, "FolderPath");
		GetAssetsInFolder_FolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsInFolder_FunctionAddress, "FolderPath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsInFolder_bRecursive_PropertyAddress, GetAssetsInFolder_FunctionAddress, "bRecursive");
		GetAssetsInFolder_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsInFolder_FunctionAddress, "bRecursive");
		GetAssetsInFolder_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsInFolder_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsInFolder_bIncludeOnlyOnDiskAssets_PropertyAddress, GetAssetsInFolder_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsInFolder_bIncludeOnlyOnDiskAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsInFolder_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsInFolder_bIncludeOnlyOnDiskAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsInFolder_FunctionAddress, "bIncludeOnlyOnDiskAssets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsInFolder_ReturnValue_PropertyAddress, GetAssetsInFolder_FunctionAddress, "ReturnValue");
		GetAssetsInFolder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsInFolder_FunctionAddress, "ReturnValue");
		GetAssetsInFolder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsInFolder_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetsInFolder_IsValid = GetAssetsInFolder_FunctionAddress != IntPtr.Zero && GetAssetsInFolder_FolderPath_IsValid && GetAssetsInFolder_bRecursive_IsValid && GetAssetsInFolder_bIncludeOnlyOnDiskAssets_IsValid && GetAssetsInFolder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetsInFolder", GetAssetsInFolder_IsValid);
		GetAssetsByPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetsByPath");
		GetAssetsByPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsByPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPath_Paths_PropertyAddress, GetAssetsByPath_FunctionAddress, "Paths");
		GetAssetsByPath_Paths_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPath_FunctionAddress, "Paths");
		GetAssetsByPath_Paths_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPath_FunctionAddress, "Paths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPath_ReturnValue_PropertyAddress, GetAssetsByPath_FunctionAddress, "ReturnValue");
		GetAssetsByPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPath_FunctionAddress, "ReturnValue");
		GetAssetsByPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPath_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetsByPath_IsValid = GetAssetsByPath_FunctionAddress != IntPtr.Zero && GetAssetsByPath_Paths_IsValid && GetAssetsByPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetsByPath", GetAssetsByPath_IsValid);
		GetAssetDataTagValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetDataTagValue");
		GetAssetDataTagValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetDataTagValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataTagValue_AssetData_PropertyAddress, GetAssetDataTagValue_FunctionAddress, "AssetData");
		GetAssetDataTagValue_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataTagValue_FunctionAddress, "AssetData");
		GetAssetDataTagValue_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataTagValue_FunctionAddress, "AssetData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataTagValue_TagName_PropertyAddress, GetAssetDataTagValue_FunctionAddress, "TagName");
		GetAssetDataTagValue_TagName_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataTagValue_FunctionAddress, "TagName");
		GetAssetDataTagValue_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataTagValue_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataTagValue_ReturnValue_PropertyAddress, GetAssetDataTagValue_FunctionAddress, "ReturnValue");
		GetAssetDataTagValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataTagValue_FunctionAddress, "ReturnValue");
		GetAssetDataTagValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataTagValue_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAssetDataTagValue_IsValid = GetAssetDataTagValue_FunctionAddress != IntPtr.Zero && GetAssetDataTagValue_AssetData_IsValid && GetAssetDataTagValue_TagName_IsValid && GetAssetDataTagValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataTagValue", GetAssetDataTagValue_IsValid);
		GetAssetDataFromPackageObj_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetDataFromPackageObj");
		GetAssetDataFromPackageObj_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetDataFromPackageObj_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataFromPackageObj_PackageObjects_PropertyAddress, GetAssetDataFromPackageObj_FunctionAddress, "PackageObjects");
		GetAssetDataFromPackageObj_PackageObjects_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataFromPackageObj_FunctionAddress, "PackageObjects");
		GetAssetDataFromPackageObj_PackageObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataFromPackageObj_FunctionAddress, "PackageObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataFromPackageObj_ReturnValue_PropertyAddress, GetAssetDataFromPackageObj_FunctionAddress, "ReturnValue");
		GetAssetDataFromPackageObj_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataFromPackageObj_FunctionAddress, "ReturnValue");
		GetAssetDataFromPackageObj_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataFromPackageObj_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetDataFromPackageObj_IsValid = GetAssetDataFromPackageObj_FunctionAddress != IntPtr.Zero && GetAssetDataFromPackageObj_PackageObjects_IsValid && GetAssetDataFromPackageObj_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataFromPackageObj", GetAssetDataFromPackageObj_IsValid);
		GetAssetDataClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetDataClass");
		GetAssetDataClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetDataClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataClass_AssetData_PropertyAddress, GetAssetDataClass_FunctionAddress, "AssetData");
		GetAssetDataClass_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataClass_FunctionAddress, "AssetData");
		GetAssetDataClass_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataClass_FunctionAddress, "AssetData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataClass_ReturnValue_PropertyAddress, GetAssetDataClass_FunctionAddress, "ReturnValue");
		GetAssetDataClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataClass_FunctionAddress, "ReturnValue");
		GetAssetDataClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetAssetDataClass_IsValid = GetAssetDataClass_FunctionAddress != IntPtr.Zero && GetAssetDataClass_AssetData_IsValid && GetAssetDataClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataClass", GetAssetDataClass_IsValid);
		GetAssetDataAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetDataAsset");
		GetAssetDataAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetDataAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataAsset_AssetData_PropertyAddress, GetAssetDataAsset_FunctionAddress, "AssetData");
		GetAssetDataAsset_AssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataAsset_FunctionAddress, "AssetData");
		GetAssetDataAsset_AssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataAsset_FunctionAddress, "AssetData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetDataAsset_ReturnValue_PropertyAddress, GetAssetDataAsset_FunctionAddress, "ReturnValue");
		GetAssetDataAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetDataAsset_FunctionAddress, "ReturnValue");
		GetAssetDataAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetDataAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetAssetDataAsset_IsValid = GetAssetDataAsset_FunctionAddress != IntPtr.Zero && GetAssetDataAsset_AssetData_IsValid && GetAssetDataAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_AssetUtilFuncLib:GetAssetDataAsset", GetAssetDataAsset_IsValid);
	}
}
