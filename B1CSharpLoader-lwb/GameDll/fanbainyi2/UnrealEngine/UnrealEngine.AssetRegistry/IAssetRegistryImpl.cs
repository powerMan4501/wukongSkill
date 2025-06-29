using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AssetRegistry;

public sealed class IAssetRegistryImpl : IInterfaceImpl, IAssetRegistry, IInterface
{
	private static bool WaitForPackage_IsValid;

	private IntPtr WaitForPackage_InstanceFunctionAddress;

	private static IntPtr WaitForPackage_FunctionAddress;

	private static int WaitForPackage_ParamsSize;

	private static bool WaitForPackage_PackageName_IsValid;

	private static FFieldAddress WaitForPackage_PackageName_PropertyAddress;

	private static int WaitForPackage_PackageName_Offset;

	private static bool WaitForCompletion_IsValid;

	private IntPtr WaitForCompletion_InstanceFunctionAddress;

	private static IntPtr WaitForCompletion_FunctionAddress;

	private static int WaitForCompletion_ParamsSize;

	private static bool UseFilterToExcludeAssets_IsValid;

	private IntPtr UseFilterToExcludeAssets_InstanceFunctionAddress;

	private static IntPtr UseFilterToExcludeAssets_FunctionAddress;

	private static int UseFilterToExcludeAssets_ParamsSize;

	private static bool UseFilterToExcludeAssets_AssetDataList_IsValid;

	private static FFieldAddress UseFilterToExcludeAssets_AssetDataList_PropertyAddress;

	private static int UseFilterToExcludeAssets_AssetDataList_Offset;

	private static bool UseFilterToExcludeAssets_Filter_IsValid;

	private static FFieldAddress UseFilterToExcludeAssets_Filter_PropertyAddress;

	private static int UseFilterToExcludeAssets_Filter_Offset;

	private static bool SearchAllAssets_IsValid;

	private IntPtr SearchAllAssets_InstanceFunctionAddress;

	private static IntPtr SearchAllAssets_FunctionAddress;

	private static int SearchAllAssets_ParamsSize;

	private static bool SearchAllAssets_bSynchronousSearch_IsValid;

	private static FFieldAddress SearchAllAssets_bSynchronousSearch_PropertyAddress;

	private static int SearchAllAssets_bSynchronousSearch_Offset;

	private static bool ScanPathsSynchronous_IsValid;

	private IntPtr ScanPathsSynchronous_InstanceFunctionAddress;

	private static IntPtr ScanPathsSynchronous_FunctionAddress;

	private static int ScanPathsSynchronous_ParamsSize;

	private static bool ScanPathsSynchronous_InPaths_IsValid;

	private static FFieldAddress ScanPathsSynchronous_InPaths_PropertyAddress;

	private static int ScanPathsSynchronous_InPaths_Offset;

	private static bool ScanPathsSynchronous_bForceRescan_IsValid;

	private static FFieldAddress ScanPathsSynchronous_bForceRescan_PropertyAddress;

	private static int ScanPathsSynchronous_bForceRescan_Offset;

	private static bool ScanPathsSynchronous_bIgnoreDenyListScanFilters_IsValid;

	private static FFieldAddress ScanPathsSynchronous_bIgnoreDenyListScanFilters_PropertyAddress;

	private static int ScanPathsSynchronous_bIgnoreDenyListScanFilters_Offset;

	private static bool ScanModifiedAssetFiles_IsValid;

	private IntPtr ScanModifiedAssetFiles_InstanceFunctionAddress;

	private static IntPtr ScanModifiedAssetFiles_FunctionAddress;

	private static int ScanModifiedAssetFiles_ParamsSize;

	private static bool ScanModifiedAssetFiles_InFilePaths_IsValid;

	private static FFieldAddress ScanModifiedAssetFiles_InFilePaths_PropertyAddress;

	private static int ScanModifiedAssetFiles_InFilePaths_Offset;

	private static bool ScanFilesSynchronous_IsValid;

	private IntPtr ScanFilesSynchronous_InstanceFunctionAddress;

	private static IntPtr ScanFilesSynchronous_FunctionAddress;

	private static int ScanFilesSynchronous_ParamsSize;

	private static bool ScanFilesSynchronous_InFilePaths_IsValid;

	private static FFieldAddress ScanFilesSynchronous_InFilePaths_PropertyAddress;

	private static int ScanFilesSynchronous_InFilePaths_Offset;

	private static bool ScanFilesSynchronous_bForceRescan_IsValid;

	private static FFieldAddress ScanFilesSynchronous_bForceRescan_PropertyAddress;

	private static int ScanFilesSynchronous_bForceRescan_Offset;

	private static bool RunAssetsThroughFilter_IsValid;

	private IntPtr RunAssetsThroughFilter_InstanceFunctionAddress;

	private static IntPtr RunAssetsThroughFilter_FunctionAddress;

	private static int RunAssetsThroughFilter_ParamsSize;

	private static bool RunAssetsThroughFilter_AssetDataList_IsValid;

	private static FFieldAddress RunAssetsThroughFilter_AssetDataList_PropertyAddress;

	private static int RunAssetsThroughFilter_AssetDataList_Offset;

	private static bool RunAssetsThroughFilter_Filter_IsValid;

	private static FFieldAddress RunAssetsThroughFilter_Filter_PropertyAddress;

	private static int RunAssetsThroughFilter_Filter_Offset;

	private static bool PrioritizeSearchPath_IsValid;

	private IntPtr PrioritizeSearchPath_InstanceFunctionAddress;

	private static IntPtr PrioritizeSearchPath_FunctionAddress;

	private static int PrioritizeSearchPath_ParamsSize;

	private static bool PrioritizeSearchPath_PathToPrioritize_IsValid;

	private static FFieldAddress PrioritizeSearchPath_PathToPrioritize_PropertyAddress;

	private static int PrioritizeSearchPath_PathToPrioritize_Offset;

	private static bool GetReferencers_IsValid;

	private IntPtr GetReferencers_InstanceFunctionAddress;

	private static IntPtr GetReferencers_FunctionAddress;

	private static int GetReferencers_ParamsSize;

	private static bool GetReferencers_PackageName_IsValid;

	private static FFieldAddress GetReferencers_PackageName_PropertyAddress;

	private static int GetReferencers_PackageName_Offset;

	private static bool GetReferencers_ReferenceOptions_IsValid;

	private static FFieldAddress GetReferencers_ReferenceOptions_PropertyAddress;

	private static int GetReferencers_ReferenceOptions_Offset;

	private static bool GetReferencers_OutReferencers_IsValid;

	private static FFieldAddress GetReferencers_OutReferencers_PropertyAddress;

	private static int GetReferencers_OutReferencers_Offset;

	private static bool GetReferencers_ReturnValue_IsValid;

	private static FFieldAddress GetReferencers_ReturnValue_PropertyAddress;

	private static int GetReferencers_ReturnValue_Offset;

	private static bool GetDependencies_IsValid;

	private IntPtr GetDependencies_InstanceFunctionAddress;

	private static IntPtr GetDependencies_FunctionAddress;

	private static int GetDependencies_ParamsSize;

	private static bool GetDependencies_PackageName_IsValid;

	private static FFieldAddress GetDependencies_PackageName_PropertyAddress;

	private static int GetDependencies_PackageName_Offset;

	private static bool GetDependencies_DependencyOptions_IsValid;

	private static FFieldAddress GetDependencies_DependencyOptions_PropertyAddress;

	private static int GetDependencies_DependencyOptions_Offset;

	private static bool GetDependencies_OutDependencies_IsValid;

	private static FFieldAddress GetDependencies_OutDependencies_PropertyAddress;

	private static int GetDependencies_OutDependencies_Offset;

	private static bool GetDependencies_ReturnValue_IsValid;

	private static FFieldAddress GetDependencies_ReturnValue_PropertyAddress;

	private static int GetDependencies_ReturnValue_Offset;

	private static bool IsSearchAsync_IsValid;

	private IntPtr IsSearchAsync_InstanceFunctionAddress;

	private static IntPtr IsSearchAsync_FunctionAddress;

	private static int IsSearchAsync_ParamsSize;

	private static bool IsSearchAsync_ReturnValue_IsValid;

	private static FFieldAddress IsSearchAsync_ReturnValue_PropertyAddress;

	private static int IsSearchAsync_ReturnValue_Offset;

	private static bool IsSearchAllAssets_IsValid;

	private IntPtr IsSearchAllAssets_InstanceFunctionAddress;

	private static IntPtr IsSearchAllAssets_FunctionAddress;

	private static int IsSearchAllAssets_ParamsSize;

	private static bool IsSearchAllAssets_ReturnValue_IsValid;

	private static FFieldAddress IsSearchAllAssets_ReturnValue_PropertyAddress;

	private static int IsSearchAllAssets_ReturnValue_Offset;

	private static bool IsLoadingAssets_IsValid;

	private IntPtr IsLoadingAssets_InstanceFunctionAddress;

	private static IntPtr IsLoadingAssets_FunctionAddress;

	private static int IsLoadingAssets_ParamsSize;

	private static bool IsLoadingAssets_ReturnValue_IsValid;

	private static FFieldAddress IsLoadingAssets_ReturnValue_PropertyAddress;

	private static int IsLoadingAssets_ReturnValue_Offset;

	private static bool HasAssets_IsValid;

	private IntPtr HasAssets_InstanceFunctionAddress;

	private static IntPtr HasAssets_FunctionAddress;

	private static int HasAssets_ParamsSize;

	private static bool HasAssets_PackagePath_IsValid;

	private static FFieldAddress HasAssets_PackagePath_PropertyAddress;

	private static int HasAssets_PackagePath_Offset;

	private static bool HasAssets_bRecursive_IsValid;

	private static FFieldAddress HasAssets_bRecursive_PropertyAddress;

	private static int HasAssets_bRecursive_Offset;

	private static bool HasAssets_ReturnValue_IsValid;

	private static FFieldAddress HasAssets_ReturnValue_PropertyAddress;

	private static int HasAssets_ReturnValue_Offset;

	private static bool GetSubPaths_IsValid;

	private IntPtr GetSubPaths_InstanceFunctionAddress;

	private static IntPtr GetSubPaths_FunctionAddress;

	private static int GetSubPaths_ParamsSize;

	private static bool GetSubPaths_InBasePath_IsValid;

	private static FFieldAddress GetSubPaths_InBasePath_PropertyAddress;

	private static int GetSubPaths_InBasePath_Offset;

	private static bool GetSubPaths_OutPathList_IsValid;

	private static FFieldAddress GetSubPaths_OutPathList_PropertyAddress;

	private static int GetSubPaths_OutPathList_Offset;

	private static bool GetSubPaths_bInRecurse_IsValid;

	private static FFieldAddress GetSubPaths_bInRecurse_PropertyAddress;

	private static int GetSubPaths_bInRecurse_Offset;

	private static bool GetAssetsByPaths_IsValid;

	private IntPtr GetAssetsByPaths_InstanceFunctionAddress;

	private static IntPtr GetAssetsByPaths_FunctionAddress;

	private static int GetAssetsByPaths_ParamsSize;

	private static bool GetAssetsByPaths_PackagePaths_IsValid;

	private static FFieldAddress GetAssetsByPaths_PackagePaths_PropertyAddress;

	private static int GetAssetsByPaths_PackagePaths_Offset;

	private static bool GetAssetsByPaths_OutAssetData_IsValid;

	private static FFieldAddress GetAssetsByPaths_OutAssetData_PropertyAddress;

	private static int GetAssetsByPaths_OutAssetData_Offset;

	private static bool GetAssetsByPaths_bRecursive_IsValid;

	private static FFieldAddress GetAssetsByPaths_bRecursive_PropertyAddress;

	private static int GetAssetsByPaths_bRecursive_Offset;

	private static bool GetAssetsByPaths_bIncludeOnlyOnDiskAssets_IsValid;

	private static FFieldAddress GetAssetsByPaths_bIncludeOnlyOnDiskAssets_PropertyAddress;

	private static int GetAssetsByPaths_bIncludeOnlyOnDiskAssets_Offset;

	private static bool GetAssetsByPaths_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsByPaths_ReturnValue_PropertyAddress;

	private static int GetAssetsByPaths_ReturnValue_Offset;

	private static bool GetAssetsByPath_IsValid;

	private IntPtr GetAssetsByPath_InstanceFunctionAddress;

	private static IntPtr GetAssetsByPath_FunctionAddress;

	private static int GetAssetsByPath_ParamsSize;

	private static bool GetAssetsByPath_PackagePath_IsValid;

	private static FFieldAddress GetAssetsByPath_PackagePath_PropertyAddress;

	private static int GetAssetsByPath_PackagePath_Offset;

	private static bool GetAssetsByPath_OutAssetData_IsValid;

	private static FFieldAddress GetAssetsByPath_OutAssetData_PropertyAddress;

	private static int GetAssetsByPath_OutAssetData_Offset;

	private static bool GetAssetsByPath_bRecursive_IsValid;

	private static FFieldAddress GetAssetsByPath_bRecursive_PropertyAddress;

	private static int GetAssetsByPath_bRecursive_Offset;

	private static bool GetAssetsByPath_bIncludeOnlyOnDiskAssets_IsValid;

	private static FFieldAddress GetAssetsByPath_bIncludeOnlyOnDiskAssets_PropertyAddress;

	private static int GetAssetsByPath_bIncludeOnlyOnDiskAssets_Offset;

	private static bool GetAssetsByPath_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsByPath_ReturnValue_PropertyAddress;

	private static int GetAssetsByPath_ReturnValue_Offset;

	private static bool GetAssetsByPackageName_IsValid;

	private IntPtr GetAssetsByPackageName_InstanceFunctionAddress;

	private static IntPtr GetAssetsByPackageName_FunctionAddress;

	private static int GetAssetsByPackageName_ParamsSize;

	private static bool GetAssetsByPackageName_PackageName_IsValid;

	private static FFieldAddress GetAssetsByPackageName_PackageName_PropertyAddress;

	private static int GetAssetsByPackageName_PackageName_Offset;

	private static bool GetAssetsByPackageName_OutAssetData_IsValid;

	private static FFieldAddress GetAssetsByPackageName_OutAssetData_PropertyAddress;

	private static int GetAssetsByPackageName_OutAssetData_Offset;

	private static bool GetAssetsByPackageName_bIncludeOnlyOnDiskAssets_IsValid;

	private static FFieldAddress GetAssetsByPackageName_bIncludeOnlyOnDiskAssets_PropertyAddress;

	private static int GetAssetsByPackageName_bIncludeOnlyOnDiskAssets_Offset;

	private static bool GetAssetsByPackageName_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsByPackageName_ReturnValue_PropertyAddress;

	private static int GetAssetsByPackageName_ReturnValue_Offset;

	private static bool GetAssetsByClass_IsValid;

	private IntPtr GetAssetsByClass_InstanceFunctionAddress;

	private static IntPtr GetAssetsByClass_FunctionAddress;

	private static int GetAssetsByClass_ParamsSize;

	private static bool GetAssetsByClass_ClassName_IsValid;

	private static FFieldAddress GetAssetsByClass_ClassName_PropertyAddress;

	private static int GetAssetsByClass_ClassName_Offset;

	private static bool GetAssetsByClass_OutAssetData_IsValid;

	private static FFieldAddress GetAssetsByClass_OutAssetData_PropertyAddress;

	private static int GetAssetsByClass_OutAssetData_Offset;

	private static bool GetAssetsByClass_bSearchSubClasses_IsValid;

	private static FFieldAddress GetAssetsByClass_bSearchSubClasses_PropertyAddress;

	private static int GetAssetsByClass_bSearchSubClasses_Offset;

	private static bool GetAssetsByClass_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsByClass_ReturnValue_PropertyAddress;

	private static int GetAssetsByClass_ReturnValue_Offset;

	private static bool GetAssets_IsValid;

	private IntPtr GetAssets_InstanceFunctionAddress;

	private static IntPtr GetAssets_FunctionAddress;

	private static int GetAssets_ParamsSize;

	private static bool GetAssets_Filter_IsValid;

	private static FFieldAddress GetAssets_Filter_PropertyAddress;

	private static int GetAssets_Filter_Offset;

	private static bool GetAssets_OutAssetData_IsValid;

	private static FFieldAddress GetAssets_OutAssetData_PropertyAddress;

	private static int GetAssets_OutAssetData_Offset;

	private static bool GetAssets_ReturnValue_IsValid;

	private static FFieldAddress GetAssets_ReturnValue_PropertyAddress;

	private static int GetAssets_ReturnValue_Offset;

	private static bool GetAssetByObjectPath_IsValid;

	private IntPtr GetAssetByObjectPath_InstanceFunctionAddress;

	private static IntPtr GetAssetByObjectPath_FunctionAddress;

	private static int GetAssetByObjectPath_ParamsSize;

	private static bool GetAssetByObjectPath_ObjectPath_IsValid;

	private static FFieldAddress GetAssetByObjectPath_ObjectPath_PropertyAddress;

	private static int GetAssetByObjectPath_ObjectPath_Offset;

	private static bool GetAssetByObjectPath_bIncludeOnlyOnDiskAssets_IsValid;

	private static FFieldAddress GetAssetByObjectPath_bIncludeOnlyOnDiskAssets_PropertyAddress;

	private static int GetAssetByObjectPath_bIncludeOnlyOnDiskAssets_Offset;

	private static bool GetAssetByObjectPath_ReturnValue_IsValid;

	private static FFieldAddress GetAssetByObjectPath_ReturnValue_PropertyAddress;

	private static int GetAssetByObjectPath_ReturnValue_Offset;

	private static bool GetAllCachedPaths_IsValid;

	private IntPtr GetAllCachedPaths_InstanceFunctionAddress;

	private static IntPtr GetAllCachedPaths_FunctionAddress;

	private static int GetAllCachedPaths_ParamsSize;

	private static bool GetAllCachedPaths_OutPathList_IsValid;

	private static FFieldAddress GetAllCachedPaths_OutPathList_PropertyAddress;

	private static int GetAllCachedPaths_OutPathList_Offset;

	private static bool GetAllAssets_IsValid;

	private IntPtr GetAllAssets_InstanceFunctionAddress;

	private static IntPtr GetAllAssets_FunctionAddress;

	private static int GetAllAssets_ParamsSize;

	private static bool GetAllAssets_OutAssetData_IsValid;

	private static FFieldAddress GetAllAssets_OutAssetData_PropertyAddress;

	private static int GetAllAssets_OutAssetData_Offset;

	private static bool GetAllAssets_bIncludeOnlyOnDiskAssets_IsValid;

	private static FFieldAddress GetAllAssets_bIncludeOnlyOnDiskAssets_PropertyAddress;

	private static int GetAllAssets_bIncludeOnlyOnDiskAssets_Offset;

	private static bool GetAllAssets_ReturnValue_IsValid;

	private static FFieldAddress GetAllAssets_ReturnValue_PropertyAddress;

	private static int GetAllAssets_ReturnValue_Offset;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:WaitForPackage")]
	public unsafe void WaitForPackage(string PackageName)
	{
		CheckDestroyed();
		if (!WaitForPackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:WaitForPackage");
			return;
		}
		if (WaitForPackage_InstanceFunctionAddress == IntPtr.Zero)
		{
			WaitForPackage_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "WaitForPackage");
		}
		byte* ptr = stackalloc byte[(int)(uint)(WaitForPackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WaitForPackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, WaitForPackage_PackageName_Offset), 0, WaitForPackage_PackageName_PropertyAddress.Address, PackageName);
		NativeReflection.InvokeFunctionOptimized(base.Address, WaitForPackage_InstanceFunctionAddress, intPtr, WaitForPackage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(WaitForPackage_PackageName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:WaitForCompletion")]
	public unsafe void WaitForCompletion()
	{
		CheckDestroyed();
		if (!WaitForCompletion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:WaitForCompletion");
			return;
		}
		if (WaitForCompletion_InstanceFunctionAddress == IntPtr.Zero)
		{
			WaitForCompletion_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "WaitForCompletion");
		}
		byte* ptr = stackalloc byte[(int)(uint)(WaitForCompletion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WaitForCompletion_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: WaitForCompletion_InstanceFunctionAddress, argsSize: WaitForCompletion_ParamsSize);
	}

	[UFunction(Flags = 1153565696u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:UseFilterToExcludeAssets")]
	public unsafe void UseFilterToExcludeAssets(ref List<FAssetData> AssetDataList, FARFilter Filter)
	{
		CheckDestroyed();
		if (!UseFilterToExcludeAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:UseFilterToExcludeAssets");
			return;
		}
		if (UseFilterToExcludeAssets_InstanceFunctionAddress == IntPtr.Zero)
		{
			UseFilterToExcludeAssets_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "UseFilterToExcludeAssets");
		}
		byte* ptr = stackalloc byte[(int)(uint)(UseFilterToExcludeAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UseFilterToExcludeAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TArrayCopyMarshaler<FAssetData> tArrayCopyMarshaler = new TArrayCopyMarshaler<FAssetData>(1, UseFilterToExcludeAssets_AssetDataList_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, UseFilterToExcludeAssets_AssetDataList_Offset), AssetDataList);
		NativeReflection.InitializeValue_InContainer(UseFilterToExcludeAssets_Filter_PropertyAddress.Address, intPtr);
		FARFilter.ToNative(IntPtr.Add(intPtr, UseFilterToExcludeAssets_Filter_Offset), 0, UseFilterToExcludeAssets_Filter_PropertyAddress.Address, Filter);
		NativeReflection.InvokeFunctionOptimized(base.Address, UseFilterToExcludeAssets_InstanceFunctionAddress, intPtr, UseFilterToExcludeAssets_ParamsSize);
		AssetDataList = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, UseFilterToExcludeAssets_AssetDataList_Offset));
		NativeReflection.DestroyValue_InContainer(UseFilterToExcludeAssets_AssetDataList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UseFilterToExcludeAssets_Filter_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:SearchAllAssets")]
	public unsafe void SearchAllAssets(bool bSynchronousSearch)
	{
		CheckDestroyed();
		if (!SearchAllAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:SearchAllAssets");
			return;
		}
		if (SearchAllAssets_InstanceFunctionAddress == IntPtr.Zero)
		{
			SearchAllAssets_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SearchAllAssets");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SearchAllAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SearchAllAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SearchAllAssets_bSynchronousSearch_Offset), 0, SearchAllAssets_bSynchronousSearch_PropertyAddress.Address, bSynchronousSearch);
		NativeReflection.InvokeFunctionOptimized(base.Address, SearchAllAssets_InstanceFunctionAddress, intPtr, SearchAllAssets_ParamsSize);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:ScanPathsSynchronous")]
	public unsafe void ScanPathsSynchronous(List<string> InPaths, bool bForceRescan = false, bool bIgnoreDenyListScanFilters = false)
	{
		CheckDestroyed();
		if (!ScanPathsSynchronous_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:ScanPathsSynchronous");
			return;
		}
		if (ScanPathsSynchronous_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScanPathsSynchronous_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScanPathsSynchronous");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScanPathsSynchronous_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScanPathsSynchronous_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, ScanPathsSynchronous_InPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ScanPathsSynchronous_InPaths_Offset), InPaths);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScanPathsSynchronous_bForceRescan_Offset), 0, ScanPathsSynchronous_bForceRescan_PropertyAddress.Address, bForceRescan);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScanPathsSynchronous_bIgnoreDenyListScanFilters_Offset), 0, ScanPathsSynchronous_bIgnoreDenyListScanFilters_PropertyAddress.Address, bIgnoreDenyListScanFilters);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScanPathsSynchronous_InstanceFunctionAddress, intPtr, ScanPathsSynchronous_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScanPathsSynchronous_InPaths_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:ScanModifiedAssetFiles")]
	public unsafe void ScanModifiedAssetFiles(List<string> InFilePaths)
	{
		CheckDestroyed();
		if (!ScanModifiedAssetFiles_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:ScanModifiedAssetFiles");
			return;
		}
		if (ScanModifiedAssetFiles_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScanModifiedAssetFiles_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScanModifiedAssetFiles");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScanModifiedAssetFiles_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScanModifiedAssetFiles_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, ScanModifiedAssetFiles_InFilePaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ScanModifiedAssetFiles_InFilePaths_Offset), InFilePaths);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScanModifiedAssetFiles_InstanceFunctionAddress, intPtr, ScanModifiedAssetFiles_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScanModifiedAssetFiles_InFilePaths_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:ScanFilesSynchronous")]
	public unsafe void ScanFilesSynchronous(List<string> InFilePaths, bool bForceRescan = false)
	{
		CheckDestroyed();
		if (!ScanFilesSynchronous_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:ScanFilesSynchronous");
			return;
		}
		if (ScanFilesSynchronous_InstanceFunctionAddress == IntPtr.Zero)
		{
			ScanFilesSynchronous_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ScanFilesSynchronous");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScanFilesSynchronous_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScanFilesSynchronous_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, ScanFilesSynchronous_InFilePaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ScanFilesSynchronous_InFilePaths_Offset), InFilePaths);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScanFilesSynchronous_bForceRescan_Offset), 0, ScanFilesSynchronous_bForceRescan_PropertyAddress.Address, bForceRescan);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScanFilesSynchronous_InstanceFunctionAddress, intPtr, ScanFilesSynchronous_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ScanFilesSynchronous_InFilePaths_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1153565696u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:RunAssetsThroughFilter")]
	public unsafe void RunAssetsThroughFilter(ref List<FAssetData> AssetDataList, FARFilter Filter)
	{
		CheckDestroyed();
		if (!RunAssetsThroughFilter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:RunAssetsThroughFilter");
			return;
		}
		if (RunAssetsThroughFilter_InstanceFunctionAddress == IntPtr.Zero)
		{
			RunAssetsThroughFilter_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RunAssetsThroughFilter");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RunAssetsThroughFilter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RunAssetsThroughFilter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TArrayCopyMarshaler<FAssetData> tArrayCopyMarshaler = new TArrayCopyMarshaler<FAssetData>(1, RunAssetsThroughFilter_AssetDataList_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, RunAssetsThroughFilter_AssetDataList_Offset), AssetDataList);
		NativeReflection.InitializeValue_InContainer(RunAssetsThroughFilter_Filter_PropertyAddress.Address, intPtr);
		FARFilter.ToNative(IntPtr.Add(intPtr, RunAssetsThroughFilter_Filter_Offset), 0, RunAssetsThroughFilter_Filter_PropertyAddress.Address, Filter);
		NativeReflection.InvokeFunctionOptimized(base.Address, RunAssetsThroughFilter_InstanceFunctionAddress, intPtr, RunAssetsThroughFilter_ParamsSize);
		AssetDataList = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, RunAssetsThroughFilter_AssetDataList_Offset));
		NativeReflection.DestroyValue_InContainer(RunAssetsThroughFilter_AssetDataList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RunAssetsThroughFilter_Filter_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:PrioritizeSearchPath")]
	public unsafe void PrioritizeSearchPath(string PathToPrioritize)
	{
		CheckDestroyed();
		if (!PrioritizeSearchPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:PrioritizeSearchPath");
			return;
		}
		if (PrioritizeSearchPath_InstanceFunctionAddress == IntPtr.Zero)
		{
			PrioritizeSearchPath_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PrioritizeSearchPath");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrioritizeSearchPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrioritizeSearchPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PrioritizeSearchPath_PathToPrioritize_Offset), 0, PrioritizeSearchPath_PathToPrioritize_PropertyAddress.Address, PathToPrioritize);
		NativeReflection.InvokeFunctionOptimized(base.Address, PrioritizeSearchPath_InstanceFunctionAddress, intPtr, PrioritizeSearchPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PrioritizeSearchPath_PathToPrioritize_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1145177088u, OriginalName = "K2_GetReferencers")]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:K2_GetReferencers")]
	public unsafe bool GetReferencers(FName PackageName, FAssetRegistryDependencyOptions ReferenceOptions, out List<FName> OutReferencers)
	{
		CheckDestroyed();
		if (!GetReferencers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:K2_GetReferencers");
			OutReferencers = null;
			return false;
		}
		if (GetReferencers_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetReferencers_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_GetReferencers");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetReferencers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetReferencers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetReferencers_PackageName_Offset), 0, GetReferencers_PackageName_PropertyAddress.Address, PackageName);
		NativeReflection.InitializeValue_InContainer(GetReferencers_ReferenceOptions_PropertyAddress.Address, intPtr);
		FAssetRegistryDependencyOptions.ToNative(IntPtr.Add(intPtr, GetReferencers_ReferenceOptions_Offset), 0, GetReferencers_ReferenceOptions_PropertyAddress.Address, ReferenceOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetReferencers_InstanceFunctionAddress, intPtr, GetReferencers_ParamsSize);
		OutReferencers = new TArrayCopyMarshaler<FName>(1, GetReferencers_OutReferencers_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetReferencers_OutReferencers_Offset));
		NativeReflection.DestroyValue_InContainer(GetReferencers_OutReferencers_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetReferencers_ReturnValue_Offset), 0, GetReferencers_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1145177088u, OriginalName = "K2_GetDependencies")]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:K2_GetDependencies")]
	public unsafe bool GetDependencies(FName PackageName, FAssetRegistryDependencyOptions DependencyOptions, out List<FName> OutDependencies)
	{
		CheckDestroyed();
		if (!GetDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:K2_GetDependencies");
			OutDependencies = null;
			return false;
		}
		if (GetDependencies_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetDependencies_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "K2_GetDependencies");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetDependencies_PackageName_Offset), 0, GetDependencies_PackageName_PropertyAddress.Address, PackageName);
		NativeReflection.InitializeValue_InContainer(GetDependencies_DependencyOptions_PropertyAddress.Address, intPtr);
		FAssetRegistryDependencyOptions.ToNative(IntPtr.Add(intPtr, GetDependencies_DependencyOptions_Offset), 0, GetDependencies_DependencyOptions_PropertyAddress.Address, DependencyOptions);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDependencies_InstanceFunctionAddress, intPtr, GetDependencies_ParamsSize);
		OutDependencies = new TArrayCopyMarshaler<FName>(1, GetDependencies_OutDependencies_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetDependencies_OutDependencies_Offset));
		NativeReflection.DestroyValue_InContainer(GetDependencies_OutDependencies_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetDependencies_ReturnValue_Offset), 0, GetDependencies_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:IsSearchAsync")]
	public unsafe bool IsSearchAsync()
	{
		CheckDestroyed();
		if (!IsSearchAsync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:IsSearchAsync");
			return false;
		}
		if (IsSearchAsync_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsSearchAsync_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsSearchAsync");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSearchAsync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSearchAsync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSearchAsync_InstanceFunctionAddress, intPtr, IsSearchAsync_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSearchAsync_ReturnValue_Offset), 0, IsSearchAsync_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:IsSearchAllAssets")]
	public unsafe bool IsSearchAllAssets()
	{
		CheckDestroyed();
		if (!IsSearchAllAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:IsSearchAllAssets");
			return false;
		}
		if (IsSearchAllAssets_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsSearchAllAssets_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsSearchAllAssets");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSearchAllAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSearchAllAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsSearchAllAssets_InstanceFunctionAddress, intPtr, IsSearchAllAssets_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSearchAllAssets_ReturnValue_Offset), 0, IsSearchAllAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:IsLoadingAssets")]
	public unsafe bool IsLoadingAssets()
	{
		CheckDestroyed();
		if (!IsLoadingAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:IsLoadingAssets");
			return false;
		}
		if (IsLoadingAssets_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsLoadingAssets_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsLoadingAssets");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLoadingAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLoadingAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLoadingAssets_InstanceFunctionAddress, intPtr, IsLoadingAssets_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLoadingAssets_ReturnValue_Offset), 0, IsLoadingAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1140982784u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:HasAssets")]
	public unsafe bool HasAssets(FName PackagePath, bool bRecursive = false)
	{
		CheckDestroyed();
		if (!HasAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:HasAssets");
			return false;
		}
		if (HasAssets_InstanceFunctionAddress == IntPtr.Zero)
		{
			HasAssets_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HasAssets");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, HasAssets_PackagePath_Offset), 0, HasAssets_PackagePath_PropertyAddress.Address, PackagePath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HasAssets_bRecursive_Offset), 0, HasAssets_bRecursive_PropertyAddress.Address, bRecursive);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasAssets_InstanceFunctionAddress, intPtr, HasAssets_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasAssets_ReturnValue_Offset), 0, HasAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetSubPaths")]
	public unsafe void GetSubPaths(string InBasePath, out List<string> OutPathList, bool bInRecurse)
	{
		CheckDestroyed();
		if (!GetSubPaths_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:GetSubPaths");
			OutPathList = null;
			return;
		}
		if (GetSubPaths_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetSubPaths_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetSubPaths");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSubPaths_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSubPaths_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetSubPaths_InBasePath_Offset), 0, GetSubPaths_InBasePath_PropertyAddress.Address, InBasePath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetSubPaths_bInRecurse_Offset), 0, GetSubPaths_bInRecurse_PropertyAddress.Address, bInRecurse);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSubPaths_InstanceFunctionAddress, intPtr, GetSubPaths_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetSubPaths_InBasePath_PropertyAddress.Address, intPtr);
		OutPathList = new TArrayCopyMarshaler<string>(1, GetSubPaths_OutPathList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetSubPaths_OutPathList_Offset));
		NativeReflection.DestroyValue_InContainer(GetSubPaths_OutPathList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssetsByPaths")]
	public unsafe bool GetAssetsByPaths(List<FName> PackagePaths, out List<FAssetData> OutAssetData, bool bRecursive = false, bool bIncludeOnlyOnDiskAssets = false)
	{
		CheckDestroyed();
		if (!GetAssetsByPaths_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:GetAssetsByPaths");
			OutAssetData = null;
			return false;
		}
		if (GetAssetsByPaths_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAssetsByPaths_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAssetsByPaths");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsByPaths_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsByPaths_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, GetAssetsByPaths_PackagePaths_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, GetAssetsByPaths_PackagePaths_Offset), PackagePaths);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByPaths_bRecursive_Offset), 0, GetAssetsByPaths_bRecursive_PropertyAddress.Address, bRecursive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByPaths_bIncludeOnlyOnDiskAssets_Offset), 0, GetAssetsByPaths_bIncludeOnlyOnDiskAssets_PropertyAddress.Address, bIncludeOnlyOnDiskAssets);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetsByPaths_InstanceFunctionAddress, intPtr, GetAssetsByPaths_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetsByPaths_PackagePaths_PropertyAddress.Address, intPtr);
		OutAssetData = new TArrayCopyMarshaler<FAssetData>(1, GetAssetsByPaths_OutAssetData_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAssetsByPaths_OutAssetData_Offset));
		NativeReflection.DestroyValue_InContainer(GetAssetsByPaths_OutAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAssetsByPaths_ReturnValue_Offset), 0, GetAssetsByPaths_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssetsByPath")]
	public unsafe bool GetAssetsByPath(FName PackagePath, out List<FAssetData> OutAssetData, bool bRecursive = false, bool bIncludeOnlyOnDiskAssets = false)
	{
		CheckDestroyed();
		if (!GetAssetsByPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:GetAssetsByPath");
			OutAssetData = null;
			return false;
		}
		if (GetAssetsByPath_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAssetsByPath_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAssetsByPath");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsByPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsByPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAssetsByPath_PackagePath_Offset), 0, GetAssetsByPath_PackagePath_PropertyAddress.Address, PackagePath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByPath_bRecursive_Offset), 0, GetAssetsByPath_bRecursive_PropertyAddress.Address, bRecursive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByPath_bIncludeOnlyOnDiskAssets_Offset), 0, GetAssetsByPath_bIncludeOnlyOnDiskAssets_PropertyAddress.Address, bIncludeOnlyOnDiskAssets);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetsByPath_InstanceFunctionAddress, intPtr, GetAssetsByPath_ParamsSize);
		OutAssetData = new TArrayCopyMarshaler<FAssetData>(1, GetAssetsByPath_OutAssetData_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAssetsByPath_OutAssetData_Offset));
		NativeReflection.DestroyValue_InContainer(GetAssetsByPath_OutAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAssetsByPath_ReturnValue_Offset), 0, GetAssetsByPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssetsByPackageName")]
	public unsafe bool GetAssetsByPackageName(FName PackageName, out List<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets = false)
	{
		CheckDestroyed();
		if (!GetAssetsByPackageName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:GetAssetsByPackageName");
			OutAssetData = null;
			return false;
		}
		if (GetAssetsByPackageName_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAssetsByPackageName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAssetsByPackageName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsByPackageName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsByPackageName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAssetsByPackageName_PackageName_Offset), 0, GetAssetsByPackageName_PackageName_PropertyAddress.Address, PackageName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByPackageName_bIncludeOnlyOnDiskAssets_Offset), 0, GetAssetsByPackageName_bIncludeOnlyOnDiskAssets_PropertyAddress.Address, bIncludeOnlyOnDiskAssets);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetsByPackageName_InstanceFunctionAddress, intPtr, GetAssetsByPackageName_ParamsSize);
		OutAssetData = new TArrayCopyMarshaler<FAssetData>(1, GetAssetsByPackageName_OutAssetData_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAssetsByPackageName_OutAssetData_Offset));
		NativeReflection.DestroyValue_InContainer(GetAssetsByPackageName_OutAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAssetsByPackageName_ReturnValue_Offset), 0, GetAssetsByPackageName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssetsByClass")]
	public unsafe bool GetAssetsByClass(FName ClassName, out List<FAssetData> OutAssetData, bool bSearchSubClasses = false)
	{
		CheckDestroyed();
		if (!GetAssetsByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:GetAssetsByClass");
			OutAssetData = null;
			return false;
		}
		if (GetAssetsByClass_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAssetsByClass_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAssetsByClass");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAssetsByClass_ClassName_Offset), 0, GetAssetsByClass_ClassName_PropertyAddress.Address, ClassName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByClass_bSearchSubClasses_Offset), 0, GetAssetsByClass_bSearchSubClasses_PropertyAddress.Address, bSearchSubClasses);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetsByClass_InstanceFunctionAddress, intPtr, GetAssetsByClass_ParamsSize);
		OutAssetData = new TArrayCopyMarshaler<FAssetData>(1, GetAssetsByClass_OutAssetData_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAssetsByClass_OutAssetData_Offset));
		NativeReflection.DestroyValue_InContainer(GetAssetsByClass_OutAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAssetsByClass_ReturnValue_Offset), 0, GetAssetsByClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1153565696u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssets")]
	public unsafe bool GetAssets(FARFilter Filter, out List<FAssetData> OutAssetData)
	{
		CheckDestroyed();
		if (!GetAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:GetAssets");
			OutAssetData = null;
			return false;
		}
		if (GetAssets_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAssets_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAssets");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAssets_Filter_PropertyAddress.Address, intPtr);
		FARFilter.ToNative(IntPtr.Add(intPtr, GetAssets_Filter_Offset), 0, GetAssets_Filter_PropertyAddress.Address, Filter);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssets_InstanceFunctionAddress, intPtr, GetAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssets_Filter_PropertyAddress.Address, intPtr);
		OutAssetData = new TArrayCopyMarshaler<FAssetData>(1, GetAssets_OutAssetData_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAssets_OutAssetData_Offset));
		NativeReflection.DestroyValue_InContainer(GetAssets_OutAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAssets_ReturnValue_Offset), 0, GetAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1149371392u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAssetByObjectPath")]
	public unsafe FAssetData GetAssetByObjectPath(FName ObjectPath, bool bIncludeOnlyOnDiskAssets = false)
	{
		CheckDestroyed();
		if (!GetAssetByObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:GetAssetByObjectPath");
			return default(FAssetData);
		}
		if (GetAssetByObjectPath_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAssetByObjectPath_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAssetByObjectPath");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetByObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetByObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAssetByObjectPath_ObjectPath_Offset), 0, GetAssetByObjectPath_ObjectPath_PropertyAddress.Address, ObjectPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetByObjectPath_bIncludeOnlyOnDiskAssets_Offset), 0, GetAssetByObjectPath_bIncludeOnlyOnDiskAssets_PropertyAddress.Address, bIncludeOnlyOnDiskAssets);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAssetByObjectPath_InstanceFunctionAddress, intPtr, GetAssetByObjectPath_ParamsSize);
		FAssetData result = FAssetData.FromNative(IntPtr.Add(intPtr, GetAssetByObjectPath_ReturnValue_Offset), 0, GetAssetByObjectPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAssetByObjectPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAllCachedPaths")]
	public unsafe void GetAllCachedPaths(out List<string> OutPathList)
	{
		CheckDestroyed();
		if (!GetAllCachedPaths_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:GetAllCachedPaths");
			OutPathList = null;
			return;
		}
		if (GetAllCachedPaths_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAllCachedPaths_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAllCachedPaths");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllCachedPaths_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllCachedPaths_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllCachedPaths_InstanceFunctionAddress, intPtr, GetAllCachedPaths_ParamsSize);
		OutPathList = new TArrayCopyMarshaler<string>(1, GetAllCachedPaths_OutPathList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllCachedPaths_OutPathList_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllCachedPaths_OutPathList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1145177088u)]
	[UMetaPath("/Script/AssetRegistry.AssetRegistry:GetAllAssets")]
	public unsafe bool GetAllAssets(out List<FAssetData> OutAssetData, bool bIncludeOnlyOnDiskAssets = false)
	{
		CheckDestroyed();
		if (!GetAllAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetRegistry.AssetRegistry:GetAllAssets");
			OutAssetData = null;
			return false;
		}
		if (GetAllAssets_InstanceFunctionAddress == IntPtr.Zero)
		{
			GetAllAssets_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GetAllAssets");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllAssets_bIncludeOnlyOnDiskAssets_Offset), 0, GetAllAssets_bIncludeOnlyOnDiskAssets_PropertyAddress.Address, bIncludeOnlyOnDiskAssets);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllAssets_InstanceFunctionAddress, intPtr, GetAllAssets_ParamsSize);
		OutAssetData = new TArrayCopyMarshaler<FAssetData>(1, GetAllAssets_OutAssetData_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAssets_OutAssetData_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAssets_OutAssetData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllAssets_ReturnValue_Offset), 0, GetAllAssets_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		WaitForPackage_InstanceFunctionAddress = IntPtr.Zero;
		WaitForCompletion_InstanceFunctionAddress = IntPtr.Zero;
		UseFilterToExcludeAssets_InstanceFunctionAddress = IntPtr.Zero;
		SearchAllAssets_InstanceFunctionAddress = IntPtr.Zero;
		ScanPathsSynchronous_InstanceFunctionAddress = IntPtr.Zero;
		ScanModifiedAssetFiles_InstanceFunctionAddress = IntPtr.Zero;
		ScanFilesSynchronous_InstanceFunctionAddress = IntPtr.Zero;
		RunAssetsThroughFilter_InstanceFunctionAddress = IntPtr.Zero;
		PrioritizeSearchPath_InstanceFunctionAddress = IntPtr.Zero;
		GetReferencers_InstanceFunctionAddress = IntPtr.Zero;
		GetDependencies_InstanceFunctionAddress = IntPtr.Zero;
		IsSearchAsync_InstanceFunctionAddress = IntPtr.Zero;
		IsSearchAllAssets_InstanceFunctionAddress = IntPtr.Zero;
		IsLoadingAssets_InstanceFunctionAddress = IntPtr.Zero;
		HasAssets_InstanceFunctionAddress = IntPtr.Zero;
		GetSubPaths_InstanceFunctionAddress = IntPtr.Zero;
		GetAssetsByPaths_InstanceFunctionAddress = IntPtr.Zero;
		GetAssetsByPath_InstanceFunctionAddress = IntPtr.Zero;
		GetAssetsByPackageName_InstanceFunctionAddress = IntPtr.Zero;
		GetAssetsByClass_InstanceFunctionAddress = IntPtr.Zero;
		GetAssets_InstanceFunctionAddress = IntPtr.Zero;
		GetAssetByObjectPath_InstanceFunctionAddress = IntPtr.Zero;
		GetAllCachedPaths_InstanceFunctionAddress = IntPtr.Zero;
		GetAllAssets_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IAssetRegistryImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IAssetRegistryImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IAssetRegistryImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AssetRegistry.AssetRegistry");
		WaitForPackage_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WaitForPackage");
		WaitForPackage_ParamsSize = NativeReflection.GetFunctionParamsSize(WaitForPackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WaitForPackage_PackageName_PropertyAddress, WaitForPackage_FunctionAddress, "PackageName");
		WaitForPackage_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(WaitForPackage_FunctionAddress, "PackageName");
		WaitForPackage_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(WaitForPackage_FunctionAddress, "PackageName", Classes.FStrProperty);
		WaitForPackage_IsValid = WaitForPackage_FunctionAddress != IntPtr.Zero && WaitForPackage_PackageName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:WaitForPackage", WaitForPackage_IsValid);
		WaitForCompletion_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WaitForCompletion");
		WaitForCompletion_ParamsSize = NativeReflection.GetFunctionParamsSize(WaitForCompletion_FunctionAddress);
		WaitForCompletion_IsValid = WaitForCompletion_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:WaitForCompletion", WaitForCompletion_IsValid);
		UseFilterToExcludeAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UseFilterToExcludeAssets");
		UseFilterToExcludeAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(UseFilterToExcludeAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UseFilterToExcludeAssets_AssetDataList_PropertyAddress, UseFilterToExcludeAssets_FunctionAddress, "AssetDataList");
		UseFilterToExcludeAssets_AssetDataList_Offset = NativeReflectionCached.GetPropertyOffset(UseFilterToExcludeAssets_FunctionAddress, "AssetDataList");
		UseFilterToExcludeAssets_AssetDataList_IsValid = NativeReflectionCached.ValidatePropertyClass(UseFilterToExcludeAssets_FunctionAddress, "AssetDataList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UseFilterToExcludeAssets_Filter_PropertyAddress, UseFilterToExcludeAssets_FunctionAddress, "Filter");
		UseFilterToExcludeAssets_Filter_Offset = NativeReflectionCached.GetPropertyOffset(UseFilterToExcludeAssets_FunctionAddress, "Filter");
		UseFilterToExcludeAssets_Filter_IsValid = NativeReflectionCached.ValidatePropertyClass(UseFilterToExcludeAssets_FunctionAddress, "Filter", Classes.FStructProperty);
		UseFilterToExcludeAssets_IsValid = UseFilterToExcludeAssets_FunctionAddress != IntPtr.Zero && UseFilterToExcludeAssets_AssetDataList_IsValid && UseFilterToExcludeAssets_Filter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:UseFilterToExcludeAssets", UseFilterToExcludeAssets_IsValid);
		SearchAllAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SearchAllAssets");
		SearchAllAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(SearchAllAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SearchAllAssets_bSynchronousSearch_PropertyAddress, SearchAllAssets_FunctionAddress, "bSynchronousSearch");
		SearchAllAssets_bSynchronousSearch_Offset = NativeReflectionCached.GetPropertyOffset(SearchAllAssets_FunctionAddress, "bSynchronousSearch");
		SearchAllAssets_bSynchronousSearch_IsValid = NativeReflectionCached.ValidatePropertyClass(SearchAllAssets_FunctionAddress, "bSynchronousSearch", Classes.FBoolProperty);
		SearchAllAssets_IsValid = SearchAllAssets_FunctionAddress != IntPtr.Zero && SearchAllAssets_bSynchronousSearch_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:SearchAllAssets", SearchAllAssets_IsValid);
		ScanPathsSynchronous_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScanPathsSynchronous");
		ScanPathsSynchronous_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanPathsSynchronous_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScanPathsSynchronous_InPaths_PropertyAddress, ScanPathsSynchronous_FunctionAddress, "InPaths");
		ScanPathsSynchronous_InPaths_Offset = NativeReflectionCached.GetPropertyOffset(ScanPathsSynchronous_FunctionAddress, "InPaths");
		ScanPathsSynchronous_InPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanPathsSynchronous_FunctionAddress, "InPaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanPathsSynchronous_bForceRescan_PropertyAddress, ScanPathsSynchronous_FunctionAddress, "bForceRescan");
		ScanPathsSynchronous_bForceRescan_Offset = NativeReflectionCached.GetPropertyOffset(ScanPathsSynchronous_FunctionAddress, "bForceRescan");
		ScanPathsSynchronous_bForceRescan_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanPathsSynchronous_FunctionAddress, "bForceRescan", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanPathsSynchronous_bIgnoreDenyListScanFilters_PropertyAddress, ScanPathsSynchronous_FunctionAddress, "bIgnoreDenyListScanFilters");
		ScanPathsSynchronous_bIgnoreDenyListScanFilters_Offset = NativeReflectionCached.GetPropertyOffset(ScanPathsSynchronous_FunctionAddress, "bIgnoreDenyListScanFilters");
		ScanPathsSynchronous_bIgnoreDenyListScanFilters_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanPathsSynchronous_FunctionAddress, "bIgnoreDenyListScanFilters", Classes.FBoolProperty);
		ScanPathsSynchronous_IsValid = ScanPathsSynchronous_FunctionAddress != IntPtr.Zero && ScanPathsSynchronous_InPaths_IsValid && ScanPathsSynchronous_bForceRescan_IsValid && ScanPathsSynchronous_bIgnoreDenyListScanFilters_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:ScanPathsSynchronous", ScanPathsSynchronous_IsValid);
		ScanModifiedAssetFiles_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScanModifiedAssetFiles");
		ScanModifiedAssetFiles_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanModifiedAssetFiles_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScanModifiedAssetFiles_InFilePaths_PropertyAddress, ScanModifiedAssetFiles_FunctionAddress, "InFilePaths");
		ScanModifiedAssetFiles_InFilePaths_Offset = NativeReflectionCached.GetPropertyOffset(ScanModifiedAssetFiles_FunctionAddress, "InFilePaths");
		ScanModifiedAssetFiles_InFilePaths_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanModifiedAssetFiles_FunctionAddress, "InFilePaths", Classes.FArrayProperty);
		ScanModifiedAssetFiles_IsValid = ScanModifiedAssetFiles_FunctionAddress != IntPtr.Zero && ScanModifiedAssetFiles_InFilePaths_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:ScanModifiedAssetFiles", ScanModifiedAssetFiles_IsValid);
		ScanFilesSynchronous_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ScanFilesSynchronous");
		ScanFilesSynchronous_ParamsSize = NativeReflection.GetFunctionParamsSize(ScanFilesSynchronous_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScanFilesSynchronous_InFilePaths_PropertyAddress, ScanFilesSynchronous_FunctionAddress, "InFilePaths");
		ScanFilesSynchronous_InFilePaths_Offset = NativeReflectionCached.GetPropertyOffset(ScanFilesSynchronous_FunctionAddress, "InFilePaths");
		ScanFilesSynchronous_InFilePaths_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanFilesSynchronous_FunctionAddress, "InFilePaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ScanFilesSynchronous_bForceRescan_PropertyAddress, ScanFilesSynchronous_FunctionAddress, "bForceRescan");
		ScanFilesSynchronous_bForceRescan_Offset = NativeReflectionCached.GetPropertyOffset(ScanFilesSynchronous_FunctionAddress, "bForceRescan");
		ScanFilesSynchronous_bForceRescan_IsValid = NativeReflectionCached.ValidatePropertyClass(ScanFilesSynchronous_FunctionAddress, "bForceRescan", Classes.FBoolProperty);
		ScanFilesSynchronous_IsValid = ScanFilesSynchronous_FunctionAddress != IntPtr.Zero && ScanFilesSynchronous_InFilePaths_IsValid && ScanFilesSynchronous_bForceRescan_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:ScanFilesSynchronous", ScanFilesSynchronous_IsValid);
		RunAssetsThroughFilter_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RunAssetsThroughFilter");
		RunAssetsThroughFilter_ParamsSize = NativeReflection.GetFunctionParamsSize(RunAssetsThroughFilter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RunAssetsThroughFilter_AssetDataList_PropertyAddress, RunAssetsThroughFilter_FunctionAddress, "AssetDataList");
		RunAssetsThroughFilter_AssetDataList_Offset = NativeReflectionCached.GetPropertyOffset(RunAssetsThroughFilter_FunctionAddress, "AssetDataList");
		RunAssetsThroughFilter_AssetDataList_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAssetsThroughFilter_FunctionAddress, "AssetDataList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RunAssetsThroughFilter_Filter_PropertyAddress, RunAssetsThroughFilter_FunctionAddress, "Filter");
		RunAssetsThroughFilter_Filter_Offset = NativeReflectionCached.GetPropertyOffset(RunAssetsThroughFilter_FunctionAddress, "Filter");
		RunAssetsThroughFilter_Filter_IsValid = NativeReflectionCached.ValidatePropertyClass(RunAssetsThroughFilter_FunctionAddress, "Filter", Classes.FStructProperty);
		RunAssetsThroughFilter_IsValid = RunAssetsThroughFilter_FunctionAddress != IntPtr.Zero && RunAssetsThroughFilter_AssetDataList_IsValid && RunAssetsThroughFilter_Filter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:RunAssetsThroughFilter", RunAssetsThroughFilter_IsValid);
		PrioritizeSearchPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PrioritizeSearchPath");
		PrioritizeSearchPath_ParamsSize = NativeReflection.GetFunctionParamsSize(PrioritizeSearchPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PrioritizeSearchPath_PathToPrioritize_PropertyAddress, PrioritizeSearchPath_FunctionAddress, "PathToPrioritize");
		PrioritizeSearchPath_PathToPrioritize_Offset = NativeReflectionCached.GetPropertyOffset(PrioritizeSearchPath_FunctionAddress, "PathToPrioritize");
		PrioritizeSearchPath_PathToPrioritize_IsValid = NativeReflectionCached.ValidatePropertyClass(PrioritizeSearchPath_FunctionAddress, "PathToPrioritize", Classes.FStrProperty);
		PrioritizeSearchPath_IsValid = PrioritizeSearchPath_FunctionAddress != IntPtr.Zero && PrioritizeSearchPath_PathToPrioritize_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:PrioritizeSearchPath", PrioritizeSearchPath_IsValid);
		GetReferencers_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetReferencers");
		GetReferencers_ParamsSize = NativeReflection.GetFunctionParamsSize(GetReferencers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetReferencers_PackageName_PropertyAddress, GetReferencers_FunctionAddress, "PackageName");
		GetReferencers_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(GetReferencers_FunctionAddress, "PackageName");
		GetReferencers_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferencers_FunctionAddress, "PackageName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferencers_ReferenceOptions_PropertyAddress, GetReferencers_FunctionAddress, "ReferenceOptions");
		GetReferencers_ReferenceOptions_Offset = NativeReflectionCached.GetPropertyOffset(GetReferencers_FunctionAddress, "ReferenceOptions");
		GetReferencers_ReferenceOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferencers_FunctionAddress, "ReferenceOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferencers_OutReferencers_PropertyAddress, GetReferencers_FunctionAddress, "OutReferencers");
		GetReferencers_OutReferencers_Offset = NativeReflectionCached.GetPropertyOffset(GetReferencers_FunctionAddress, "OutReferencers");
		GetReferencers_OutReferencers_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferencers_FunctionAddress, "OutReferencers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetReferencers_ReturnValue_PropertyAddress, GetReferencers_FunctionAddress, "ReturnValue");
		GetReferencers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetReferencers_FunctionAddress, "ReturnValue");
		GetReferencers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetReferencers_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetReferencers_IsValid = GetReferencers_FunctionAddress != IntPtr.Zero && GetReferencers_PackageName_IsValid && GetReferencers_ReferenceOptions_IsValid && GetReferencers_OutReferencers_IsValid && GetReferencers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:K2_GetReferencers", GetReferencers_IsValid);
		GetDependencies_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetDependencies");
		GetDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDependencies_PackageName_PropertyAddress, GetDependencies_FunctionAddress, "PackageName");
		GetDependencies_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(GetDependencies_FunctionAddress, "PackageName");
		GetDependencies_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependencies_FunctionAddress, "PackageName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDependencies_DependencyOptions_PropertyAddress, GetDependencies_FunctionAddress, "DependencyOptions");
		GetDependencies_DependencyOptions_Offset = NativeReflectionCached.GetPropertyOffset(GetDependencies_FunctionAddress, "DependencyOptions");
		GetDependencies_DependencyOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependencies_FunctionAddress, "DependencyOptions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDependencies_OutDependencies_PropertyAddress, GetDependencies_FunctionAddress, "OutDependencies");
		GetDependencies_OutDependencies_Offset = NativeReflectionCached.GetPropertyOffset(GetDependencies_FunctionAddress, "OutDependencies");
		GetDependencies_OutDependencies_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependencies_FunctionAddress, "OutDependencies", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDependencies_ReturnValue_PropertyAddress, GetDependencies_FunctionAddress, "ReturnValue");
		GetDependencies_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDependencies_FunctionAddress, "ReturnValue");
		GetDependencies_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDependencies_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetDependencies_IsValid = GetDependencies_FunctionAddress != IntPtr.Zero && GetDependencies_PackageName_IsValid && GetDependencies_DependencyOptions_IsValid && GetDependencies_OutDependencies_IsValid && GetDependencies_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:K2_GetDependencies", GetDependencies_IsValid);
		IsSearchAsync_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSearchAsync");
		IsSearchAsync_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSearchAsync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSearchAsync_ReturnValue_PropertyAddress, IsSearchAsync_FunctionAddress, "ReturnValue");
		IsSearchAsync_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSearchAsync_FunctionAddress, "ReturnValue");
		IsSearchAsync_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSearchAsync_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSearchAsync_IsValid = IsSearchAsync_FunctionAddress != IntPtr.Zero && IsSearchAsync_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:IsSearchAsync", IsSearchAsync_IsValid);
		IsSearchAllAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsSearchAllAssets");
		IsSearchAllAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSearchAllAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSearchAllAssets_ReturnValue_PropertyAddress, IsSearchAllAssets_FunctionAddress, "ReturnValue");
		IsSearchAllAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSearchAllAssets_FunctionAddress, "ReturnValue");
		IsSearchAllAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSearchAllAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSearchAllAssets_IsValid = IsSearchAllAssets_FunctionAddress != IntPtr.Zero && IsSearchAllAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:IsSearchAllAssets", IsSearchAllAssets_IsValid);
		IsLoadingAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLoadingAssets");
		IsLoadingAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLoadingAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLoadingAssets_ReturnValue_PropertyAddress, IsLoadingAssets_FunctionAddress, "ReturnValue");
		IsLoadingAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLoadingAssets_FunctionAddress, "ReturnValue");
		IsLoadingAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLoadingAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLoadingAssets_IsValid = IsLoadingAssets_FunctionAddress != IntPtr.Zero && IsLoadingAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:IsLoadingAssets", IsLoadingAssets_IsValid);
		HasAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasAssets");
		HasAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasAssets_PackagePath_PropertyAddress, HasAssets_FunctionAddress, "PackagePath");
		HasAssets_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(HasAssets_FunctionAddress, "PackagePath");
		HasAssets_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAssets_FunctionAddress, "PackagePath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAssets_bRecursive_PropertyAddress, HasAssets_FunctionAddress, "bRecursive");
		HasAssets_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(HasAssets_FunctionAddress, "bRecursive");
		HasAssets_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAssets_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HasAssets_ReturnValue_PropertyAddress, HasAssets_FunctionAddress, "ReturnValue");
		HasAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasAssets_FunctionAddress, "ReturnValue");
		HasAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAssets_IsValid = HasAssets_FunctionAddress != IntPtr.Zero && HasAssets_PackagePath_IsValid && HasAssets_bRecursive_IsValid && HasAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:HasAssets", HasAssets_IsValid);
		GetSubPaths_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSubPaths");
		GetSubPaths_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSubPaths_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSubPaths_InBasePath_PropertyAddress, GetSubPaths_FunctionAddress, "InBasePath");
		GetSubPaths_InBasePath_Offset = NativeReflectionCached.GetPropertyOffset(GetSubPaths_FunctionAddress, "InBasePath");
		GetSubPaths_InBasePath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubPaths_FunctionAddress, "InBasePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubPaths_OutPathList_PropertyAddress, GetSubPaths_FunctionAddress, "OutPathList");
		GetSubPaths_OutPathList_Offset = NativeReflectionCached.GetPropertyOffset(GetSubPaths_FunctionAddress, "OutPathList");
		GetSubPaths_OutPathList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubPaths_FunctionAddress, "OutPathList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSubPaths_bInRecurse_PropertyAddress, GetSubPaths_FunctionAddress, "bInRecurse");
		GetSubPaths_bInRecurse_Offset = NativeReflectionCached.GetPropertyOffset(GetSubPaths_FunctionAddress, "bInRecurse");
		GetSubPaths_bInRecurse_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSubPaths_FunctionAddress, "bInRecurse", Classes.FBoolProperty);
		GetSubPaths_IsValid = GetSubPaths_FunctionAddress != IntPtr.Zero && GetSubPaths_InBasePath_IsValid && GetSubPaths_OutPathList_IsValid && GetSubPaths_bInRecurse_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:GetSubPaths", GetSubPaths_IsValid);
		GetAssetsByPaths_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAssetsByPaths");
		GetAssetsByPaths_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsByPaths_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPaths_PackagePaths_PropertyAddress, GetAssetsByPaths_FunctionAddress, "PackagePaths");
		GetAssetsByPaths_PackagePaths_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPaths_FunctionAddress, "PackagePaths");
		GetAssetsByPaths_PackagePaths_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPaths_FunctionAddress, "PackagePaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPaths_OutAssetData_PropertyAddress, GetAssetsByPaths_FunctionAddress, "OutAssetData");
		GetAssetsByPaths_OutAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPaths_FunctionAddress, "OutAssetData");
		GetAssetsByPaths_OutAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPaths_FunctionAddress, "OutAssetData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPaths_bRecursive_PropertyAddress, GetAssetsByPaths_FunctionAddress, "bRecursive");
		GetAssetsByPaths_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPaths_FunctionAddress, "bRecursive");
		GetAssetsByPaths_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPaths_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPaths_bIncludeOnlyOnDiskAssets_PropertyAddress, GetAssetsByPaths_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsByPaths_bIncludeOnlyOnDiskAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPaths_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsByPaths_bIncludeOnlyOnDiskAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPaths_FunctionAddress, "bIncludeOnlyOnDiskAssets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPaths_ReturnValue_PropertyAddress, GetAssetsByPaths_FunctionAddress, "ReturnValue");
		GetAssetsByPaths_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPaths_FunctionAddress, "ReturnValue");
		GetAssetsByPaths_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPaths_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAssetsByPaths_IsValid = GetAssetsByPaths_FunctionAddress != IntPtr.Zero && GetAssetsByPaths_PackagePaths_IsValid && GetAssetsByPaths_OutAssetData_IsValid && GetAssetsByPaths_bRecursive_IsValid && GetAssetsByPaths_bIncludeOnlyOnDiskAssets_IsValid && GetAssetsByPaths_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:GetAssetsByPaths", GetAssetsByPaths_IsValid);
		GetAssetsByPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAssetsByPath");
		GetAssetsByPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsByPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPath_PackagePath_PropertyAddress, GetAssetsByPath_FunctionAddress, "PackagePath");
		GetAssetsByPath_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPath_FunctionAddress, "PackagePath");
		GetAssetsByPath_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPath_FunctionAddress, "PackagePath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPath_OutAssetData_PropertyAddress, GetAssetsByPath_FunctionAddress, "OutAssetData");
		GetAssetsByPath_OutAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPath_FunctionAddress, "OutAssetData");
		GetAssetsByPath_OutAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPath_FunctionAddress, "OutAssetData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPath_bRecursive_PropertyAddress, GetAssetsByPath_FunctionAddress, "bRecursive");
		GetAssetsByPath_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPath_FunctionAddress, "bRecursive");
		GetAssetsByPath_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPath_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPath_bIncludeOnlyOnDiskAssets_PropertyAddress, GetAssetsByPath_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsByPath_bIncludeOnlyOnDiskAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPath_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsByPath_bIncludeOnlyOnDiskAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPath_FunctionAddress, "bIncludeOnlyOnDiskAssets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPath_ReturnValue_PropertyAddress, GetAssetsByPath_FunctionAddress, "ReturnValue");
		GetAssetsByPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPath_FunctionAddress, "ReturnValue");
		GetAssetsByPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAssetsByPath_IsValid = GetAssetsByPath_FunctionAddress != IntPtr.Zero && GetAssetsByPath_PackagePath_IsValid && GetAssetsByPath_OutAssetData_IsValid && GetAssetsByPath_bRecursive_IsValid && GetAssetsByPath_bIncludeOnlyOnDiskAssets_IsValid && GetAssetsByPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:GetAssetsByPath", GetAssetsByPath_IsValid);
		GetAssetsByPackageName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAssetsByPackageName");
		GetAssetsByPackageName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsByPackageName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPackageName_PackageName_PropertyAddress, GetAssetsByPackageName_FunctionAddress, "PackageName");
		GetAssetsByPackageName_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPackageName_FunctionAddress, "PackageName");
		GetAssetsByPackageName_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPackageName_FunctionAddress, "PackageName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPackageName_OutAssetData_PropertyAddress, GetAssetsByPackageName_FunctionAddress, "OutAssetData");
		GetAssetsByPackageName_OutAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPackageName_FunctionAddress, "OutAssetData");
		GetAssetsByPackageName_OutAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPackageName_FunctionAddress, "OutAssetData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPackageName_bIncludeOnlyOnDiskAssets_PropertyAddress, GetAssetsByPackageName_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsByPackageName_bIncludeOnlyOnDiskAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPackageName_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsByPackageName_bIncludeOnlyOnDiskAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPackageName_FunctionAddress, "bIncludeOnlyOnDiskAssets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByPackageName_ReturnValue_PropertyAddress, GetAssetsByPackageName_FunctionAddress, "ReturnValue");
		GetAssetsByPackageName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByPackageName_FunctionAddress, "ReturnValue");
		GetAssetsByPackageName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByPackageName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAssetsByPackageName_IsValid = GetAssetsByPackageName_FunctionAddress != IntPtr.Zero && GetAssetsByPackageName_PackageName_IsValid && GetAssetsByPackageName_OutAssetData_IsValid && GetAssetsByPackageName_bIncludeOnlyOnDiskAssets_IsValid && GetAssetsByPackageName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:GetAssetsByPackageName", GetAssetsByPackageName_IsValid);
		GetAssetsByClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAssetsByClass");
		GetAssetsByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClass_ClassName_PropertyAddress, GetAssetsByClass_FunctionAddress, "ClassName");
		GetAssetsByClass_ClassName_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClass_FunctionAddress, "ClassName");
		GetAssetsByClass_ClassName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClass_FunctionAddress, "ClassName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClass_OutAssetData_PropertyAddress, GetAssetsByClass_FunctionAddress, "OutAssetData");
		GetAssetsByClass_OutAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClass_FunctionAddress, "OutAssetData");
		GetAssetsByClass_OutAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClass_FunctionAddress, "OutAssetData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClass_bSearchSubClasses_PropertyAddress, GetAssetsByClass_FunctionAddress, "bSearchSubClasses");
		GetAssetsByClass_bSearchSubClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClass_FunctionAddress, "bSearchSubClasses");
		GetAssetsByClass_bSearchSubClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClass_FunctionAddress, "bSearchSubClasses", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClass_ReturnValue_PropertyAddress, GetAssetsByClass_FunctionAddress, "ReturnValue");
		GetAssetsByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClass_FunctionAddress, "ReturnValue");
		GetAssetsByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClass_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAssetsByClass_IsValid = GetAssetsByClass_FunctionAddress != IntPtr.Zero && GetAssetsByClass_ClassName_IsValid && GetAssetsByClass_OutAssetData_IsValid && GetAssetsByClass_bSearchSubClasses_IsValid && GetAssetsByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:GetAssetsByClass", GetAssetsByClass_IsValid);
		GetAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAssets");
		GetAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssets_Filter_PropertyAddress, GetAssets_FunctionAddress, "Filter");
		GetAssets_Filter_Offset = NativeReflectionCached.GetPropertyOffset(GetAssets_FunctionAddress, "Filter");
		GetAssets_Filter_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssets_FunctionAddress, "Filter", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssets_OutAssetData_PropertyAddress, GetAssets_FunctionAddress, "OutAssetData");
		GetAssets_OutAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAssets_FunctionAddress, "OutAssetData");
		GetAssets_OutAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssets_FunctionAddress, "OutAssetData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssets_ReturnValue_PropertyAddress, GetAssets_FunctionAddress, "ReturnValue");
		GetAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssets_FunctionAddress, "ReturnValue");
		GetAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAssets_IsValid = GetAssets_FunctionAddress != IntPtr.Zero && GetAssets_Filter_IsValid && GetAssets_OutAssetData_IsValid && GetAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:GetAssets", GetAssets_IsValid);
		GetAssetByObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAssetByObjectPath");
		GetAssetByObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetByObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetByObjectPath_ObjectPath_PropertyAddress, GetAssetByObjectPath_FunctionAddress, "ObjectPath");
		GetAssetByObjectPath_ObjectPath_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetByObjectPath_FunctionAddress, "ObjectPath");
		GetAssetByObjectPath_ObjectPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetByObjectPath_FunctionAddress, "ObjectPath", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetByObjectPath_bIncludeOnlyOnDiskAssets_PropertyAddress, GetAssetByObjectPath_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetByObjectPath_bIncludeOnlyOnDiskAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetByObjectPath_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetByObjectPath_bIncludeOnlyOnDiskAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetByObjectPath_FunctionAddress, "bIncludeOnlyOnDiskAssets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetByObjectPath_ReturnValue_PropertyAddress, GetAssetByObjectPath_FunctionAddress, "ReturnValue");
		GetAssetByObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetByObjectPath_FunctionAddress, "ReturnValue");
		GetAssetByObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetByObjectPath_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetAssetByObjectPath_IsValid = GetAssetByObjectPath_FunctionAddress != IntPtr.Zero && GetAssetByObjectPath_ObjectPath_IsValid && GetAssetByObjectPath_bIncludeOnlyOnDiskAssets_IsValid && GetAssetByObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:GetAssetByObjectPath", GetAssetByObjectPath_IsValid);
		GetAllCachedPaths_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllCachedPaths");
		GetAllCachedPaths_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllCachedPaths_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllCachedPaths_OutPathList_PropertyAddress, GetAllCachedPaths_FunctionAddress, "OutPathList");
		GetAllCachedPaths_OutPathList_Offset = NativeReflectionCached.GetPropertyOffset(GetAllCachedPaths_FunctionAddress, "OutPathList");
		GetAllCachedPaths_OutPathList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllCachedPaths_FunctionAddress, "OutPathList", Classes.FArrayProperty);
		GetAllCachedPaths_IsValid = GetAllCachedPaths_FunctionAddress != IntPtr.Zero && GetAllCachedPaths_OutPathList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:GetAllCachedPaths", GetAllCachedPaths_IsValid);
		GetAllAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllAssets");
		GetAllAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllAssets_OutAssetData_PropertyAddress, GetAllAssets_FunctionAddress, "OutAssetData");
		GetAllAssets_OutAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAssets_FunctionAddress, "OutAssetData");
		GetAllAssets_OutAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAssets_FunctionAddress, "OutAssetData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAssets_bIncludeOnlyOnDiskAssets_PropertyAddress, GetAllAssets_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAllAssets_bIncludeOnlyOnDiskAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAssets_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAllAssets_bIncludeOnlyOnDiskAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAssets_FunctionAddress, "bIncludeOnlyOnDiskAssets", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAssets_ReturnValue_PropertyAddress, GetAllAssets_FunctionAddress, "ReturnValue");
		GetAllAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAssets_FunctionAddress, "ReturnValue");
		GetAllAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAllAssets_IsValid = GetAllAssets_FunctionAddress != IntPtr.Zero && GetAllAssets_OutAssetData_IsValid && GetAllAssets_bIncludeOnlyOnDiskAssets_IsValid && GetAllAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetRegistry.AssetRegistry:GetAllAssets", GetAllAssets_IsValid);
	}
}
