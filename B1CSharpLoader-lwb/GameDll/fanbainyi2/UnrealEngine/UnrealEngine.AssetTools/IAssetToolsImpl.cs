using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UnrealEd;

namespace UnrealEngine.AssetTools;

public sealed class IAssetToolsImpl : IInterfaceImpl, IAssetTools, IInterface
{
	private static bool RenameReferencingSoftObjectPaths_IsValid;

	private IntPtr RenameReferencingSoftObjectPaths_InstanceFunctionAddress;

	private static IntPtr RenameReferencingSoftObjectPaths_FunctionAddress;

	private static int RenameReferencingSoftObjectPaths_ParamsSize;

	private static bool RenameReferencingSoftObjectPaths_PackagesToCheck_IsValid;

	private static FFieldAddress RenameReferencingSoftObjectPaths_PackagesToCheck_PropertyAddress;

	private static int RenameReferencingSoftObjectPaths_PackagesToCheck_Offset;

	private static bool RenameReferencingSoftObjectPaths_AssetRedirectorMap_IsValid;

	private static FFieldAddress RenameReferencingSoftObjectPaths_AssetRedirectorMap_PropertyAddress;

	private static int RenameReferencingSoftObjectPaths_AssetRedirectorMap_Offset;

	private static bool RenameAssetsWithDialog_IsValid;

	private IntPtr RenameAssetsWithDialog_InstanceFunctionAddress;

	private static IntPtr RenameAssetsWithDialog_FunctionAddress;

	private static int RenameAssetsWithDialog_ParamsSize;

	private static bool RenameAssetsWithDialog_AssetsAndNames_IsValid;

	private static FFieldAddress RenameAssetsWithDialog_AssetsAndNames_PropertyAddress;

	private static int RenameAssetsWithDialog_AssetsAndNames_Offset;

	private static bool RenameAssetsWithDialog_bAutoCheckout_IsValid;

	private static FFieldAddress RenameAssetsWithDialog_bAutoCheckout_PropertyAddress;

	private static int RenameAssetsWithDialog_bAutoCheckout_Offset;

	private static bool RenameAssetsWithDialog_ReturnValue_IsValid;

	private static FFieldAddress RenameAssetsWithDialog_ReturnValue_PropertyAddress;

	private static int RenameAssetsWithDialog_ReturnValue_Offset;

	private static bool RenameAssets_IsValid;

	private IntPtr RenameAssets_InstanceFunctionAddress;

	private static IntPtr RenameAssets_FunctionAddress;

	private static int RenameAssets_ParamsSize;

	private static bool RenameAssets_AssetsAndNames_IsValid;

	private static FFieldAddress RenameAssets_AssetsAndNames_PropertyAddress;

	private static int RenameAssets_AssetsAndNames_Offset;

	private static bool RenameAssets_ReturnValue_IsValid;

	private static FFieldAddress RenameAssets_ReturnValue_PropertyAddress;

	private static int RenameAssets_ReturnValue_Offset;

	private static bool ImportAssetTasks_IsValid;

	private IntPtr ImportAssetTasks_InstanceFunctionAddress;

	private static IntPtr ImportAssetTasks_FunctionAddress;

	private static int ImportAssetTasks_ParamsSize;

	private static bool ImportAssetTasks_ImportTasks_IsValid;

	private static FFieldAddress ImportAssetTasks_ImportTasks_PropertyAddress;

	private static int ImportAssetTasks_ImportTasks_Offset;

	private static bool ImportAssetsWithDialog_IsValid;

	private IntPtr ImportAssetsWithDialog_InstanceFunctionAddress;

	private static IntPtr ImportAssetsWithDialog_FunctionAddress;

	private static int ImportAssetsWithDialog_ParamsSize;

	private static bool ImportAssetsWithDialog_DestinationPath_IsValid;

	private static FFieldAddress ImportAssetsWithDialog_DestinationPath_PropertyAddress;

	private static int ImportAssetsWithDialog_DestinationPath_Offset;

	private static bool ImportAssetsWithDialog_ReturnValue_IsValid;

	private static FFieldAddress ImportAssetsWithDialog_ReturnValue_PropertyAddress;

	private static int ImportAssetsWithDialog_ReturnValue_Offset;

	private static bool ImportAssetsAutomated_IsValid;

	private IntPtr ImportAssetsAutomated_InstanceFunctionAddress;

	private static IntPtr ImportAssetsAutomated_FunctionAddress;

	private static int ImportAssetsAutomated_ParamsSize;

	private static bool ImportAssetsAutomated_ImportData_IsValid;

	private static FFieldAddress ImportAssetsAutomated_ImportData_PropertyAddress;

	private static int ImportAssetsAutomated_ImportData_Offset;

	private static bool ImportAssetsAutomated_ReturnValue_IsValid;

	private static FFieldAddress ImportAssetsAutomated_ReturnValue_PropertyAddress;

	private static int ImportAssetsAutomated_ReturnValue_Offset;

	private static bool FindSoftReferencesToObject_IsValid;

	private IntPtr FindSoftReferencesToObject_InstanceFunctionAddress;

	private static IntPtr FindSoftReferencesToObject_FunctionAddress;

	private static int FindSoftReferencesToObject_ParamsSize;

	private static bool FindSoftReferencesToObject_TargetObject_IsValid;

	private static FFieldAddress FindSoftReferencesToObject_TargetObject_PropertyAddress;

	private static int FindSoftReferencesToObject_TargetObject_Offset;

	private static bool FindSoftReferencesToObject_ReferencingObjects_IsValid;

	private static FFieldAddress FindSoftReferencesToObject_ReferencingObjects_PropertyAddress;

	private static int FindSoftReferencesToObject_ReferencingObjects_Offset;

	private static bool ExportAssetsWithDialog_IsValid;

	private IntPtr ExportAssetsWithDialog_InstanceFunctionAddress;

	private static IntPtr ExportAssetsWithDialog_FunctionAddress;

	private static int ExportAssetsWithDialog_ParamsSize;

	private static bool ExportAssetsWithDialog_AssetsToExport_IsValid;

	private static FFieldAddress ExportAssetsWithDialog_AssetsToExport_PropertyAddress;

	private static int ExportAssetsWithDialog_AssetsToExport_Offset;

	private static bool ExportAssetsWithDialog_bPromptForIndividualFilenames_IsValid;

	private static FFieldAddress ExportAssetsWithDialog_bPromptForIndividualFilenames_PropertyAddress;

	private static int ExportAssetsWithDialog_bPromptForIndividualFilenames_Offset;

	private static bool ExportAssets_IsValid;

	private IntPtr ExportAssets_InstanceFunctionAddress;

	private static IntPtr ExportAssets_FunctionAddress;

	private static int ExportAssets_ParamsSize;

	private static bool ExportAssets_AssetsToExport_IsValid;

	private static FFieldAddress ExportAssets_AssetsToExport_PropertyAddress;

	private static int ExportAssets_AssetsToExport_Offset;

	private static bool ExportAssets_ExportPath_IsValid;

	private static FFieldAddress ExportAssets_ExportPath_PropertyAddress;

	private static int ExportAssets_ExportPath_Offset;

	private static bool DuplicateAssetWithDialogAndTitle_IsValid;

	private IntPtr DuplicateAssetWithDialogAndTitle_InstanceFunctionAddress;

	private static IntPtr DuplicateAssetWithDialogAndTitle_FunctionAddress;

	private static int DuplicateAssetWithDialogAndTitle_ParamsSize;

	private static bool DuplicateAssetWithDialogAndTitle_AssetName_IsValid;

	private static FFieldAddress DuplicateAssetWithDialogAndTitle_AssetName_PropertyAddress;

	private static int DuplicateAssetWithDialogAndTitle_AssetName_Offset;

	private static bool DuplicateAssetWithDialogAndTitle_PackagePath_IsValid;

	private static FFieldAddress DuplicateAssetWithDialogAndTitle_PackagePath_PropertyAddress;

	private static int DuplicateAssetWithDialogAndTitle_PackagePath_Offset;

	private static bool DuplicateAssetWithDialogAndTitle_OriginalObject_IsValid;

	private static FFieldAddress DuplicateAssetWithDialogAndTitle_OriginalObject_PropertyAddress;

	private static int DuplicateAssetWithDialogAndTitle_OriginalObject_Offset;

	private static bool DuplicateAssetWithDialogAndTitle_DialogTitle_IsValid;

	private static FFieldAddress DuplicateAssetWithDialogAndTitle_DialogTitle_PropertyAddress;

	private static int DuplicateAssetWithDialogAndTitle_DialogTitle_Offset;

	private static bool DuplicateAssetWithDialogAndTitle_ReturnValue_IsValid;

	private static FFieldAddress DuplicateAssetWithDialogAndTitle_ReturnValue_PropertyAddress;

	private static int DuplicateAssetWithDialogAndTitle_ReturnValue_Offset;

	private static bool DuplicateAssetWithDialog_IsValid;

	private IntPtr DuplicateAssetWithDialog_InstanceFunctionAddress;

	private static IntPtr DuplicateAssetWithDialog_FunctionAddress;

	private static int DuplicateAssetWithDialog_ParamsSize;

	private static bool DuplicateAssetWithDialog_AssetName_IsValid;

	private static FFieldAddress DuplicateAssetWithDialog_AssetName_PropertyAddress;

	private static int DuplicateAssetWithDialog_AssetName_Offset;

	private static bool DuplicateAssetWithDialog_PackagePath_IsValid;

	private static FFieldAddress DuplicateAssetWithDialog_PackagePath_PropertyAddress;

	private static int DuplicateAssetWithDialog_PackagePath_Offset;

	private static bool DuplicateAssetWithDialog_OriginalObject_IsValid;

	private static FFieldAddress DuplicateAssetWithDialog_OriginalObject_PropertyAddress;

	private static int DuplicateAssetWithDialog_OriginalObject_Offset;

	private static bool DuplicateAssetWithDialog_ReturnValue_IsValid;

	private static FFieldAddress DuplicateAssetWithDialog_ReturnValue_PropertyAddress;

	private static int DuplicateAssetWithDialog_ReturnValue_Offset;

	private static bool DuplicateAsset_IsValid;

	private IntPtr DuplicateAsset_InstanceFunctionAddress;

	private static IntPtr DuplicateAsset_FunctionAddress;

	private static int DuplicateAsset_ParamsSize;

	private static bool DuplicateAsset_AssetName_IsValid;

	private static FFieldAddress DuplicateAsset_AssetName_PropertyAddress;

	private static int DuplicateAsset_AssetName_Offset;

	private static bool DuplicateAsset_PackagePath_IsValid;

	private static FFieldAddress DuplicateAsset_PackagePath_PropertyAddress;

	private static int DuplicateAsset_PackagePath_Offset;

	private static bool DuplicateAsset_OriginalObject_IsValid;

	private static FFieldAddress DuplicateAsset_OriginalObject_PropertyAddress;

	private static int DuplicateAsset_OriginalObject_Offset;

	private static bool DuplicateAsset_ReturnValue_IsValid;

	private static FFieldAddress DuplicateAsset_ReturnValue_PropertyAddress;

	private static int DuplicateAsset_ReturnValue_Offset;

	private static bool CreateUniqueAssetName_IsValid;

	private IntPtr CreateUniqueAssetName_InstanceFunctionAddress;

	private static IntPtr CreateUniqueAssetName_FunctionAddress;

	private static int CreateUniqueAssetName_ParamsSize;

	private static bool CreateUniqueAssetName_InBasePackageName_IsValid;

	private static FFieldAddress CreateUniqueAssetName_InBasePackageName_PropertyAddress;

	private static int CreateUniqueAssetName_InBasePackageName_Offset;

	private static bool CreateUniqueAssetName_InSuffix_IsValid;

	private static FFieldAddress CreateUniqueAssetName_InSuffix_PropertyAddress;

	private static int CreateUniqueAssetName_InSuffix_Offset;

	private static bool CreateUniqueAssetName_OutPackageName_IsValid;

	private static FFieldAddress CreateUniqueAssetName_OutPackageName_PropertyAddress;

	private static int CreateUniqueAssetName_OutPackageName_Offset;

	private static bool CreateUniqueAssetName_OutAssetName_IsValid;

	private static FFieldAddress CreateUniqueAssetName_OutAssetName_PropertyAddress;

	private static int CreateUniqueAssetName_OutAssetName_Offset;

	private static bool CreateAssetWithDialog_IsValid;

	private IntPtr CreateAssetWithDialog_InstanceFunctionAddress;

	private static IntPtr CreateAssetWithDialog_FunctionAddress;

	private static int CreateAssetWithDialog_ParamsSize;

	private static bool CreateAssetWithDialog_AssetName_IsValid;

	private static FFieldAddress CreateAssetWithDialog_AssetName_PropertyAddress;

	private static int CreateAssetWithDialog_AssetName_Offset;

	private static bool CreateAssetWithDialog_PackagePath_IsValid;

	private static FFieldAddress CreateAssetWithDialog_PackagePath_PropertyAddress;

	private static int CreateAssetWithDialog_PackagePath_Offset;

	private static bool CreateAssetWithDialog_AssetClass_IsValid;

	private static FFieldAddress CreateAssetWithDialog_AssetClass_PropertyAddress;

	private static int CreateAssetWithDialog_AssetClass_Offset;

	private static bool CreateAssetWithDialog_Factory_IsValid;

	private static FFieldAddress CreateAssetWithDialog_Factory_PropertyAddress;

	private static int CreateAssetWithDialog_Factory_Offset;

	private static bool CreateAssetWithDialog_CallingContext_IsValid;

	private static FFieldAddress CreateAssetWithDialog_CallingContext_PropertyAddress;

	private static int CreateAssetWithDialog_CallingContext_Offset;

	private static bool CreateAssetWithDialog_bCallConfigureProperties_IsValid;

	private static FFieldAddress CreateAssetWithDialog_bCallConfigureProperties_PropertyAddress;

	private static int CreateAssetWithDialog_bCallConfigureProperties_Offset;

	private static bool CreateAssetWithDialog_ReturnValue_IsValid;

	private static FFieldAddress CreateAssetWithDialog_ReturnValue_PropertyAddress;

	private static int CreateAssetWithDialog_ReturnValue_Offset;

	private static bool CreateAsset_IsValid;

	private IntPtr CreateAsset_InstanceFunctionAddress;

	private static IntPtr CreateAsset_FunctionAddress;

	private static int CreateAsset_ParamsSize;

	private static bool CreateAsset_AssetName_IsValid;

	private static FFieldAddress CreateAsset_AssetName_PropertyAddress;

	private static int CreateAsset_AssetName_Offset;

	private static bool CreateAsset_PackagePath_IsValid;

	private static FFieldAddress CreateAsset_PackagePath_PropertyAddress;

	private static int CreateAsset_PackagePath_Offset;

	private static bool CreateAsset_AssetClass_IsValid;

	private static FFieldAddress CreateAsset_AssetClass_PropertyAddress;

	private static int CreateAsset_AssetClass_Offset;

	private static bool CreateAsset_Factory_IsValid;

	private static FFieldAddress CreateAsset_Factory_PropertyAddress;

	private static int CreateAsset_Factory_Offset;

	private static bool CreateAsset_CallingContext_IsValid;

	private static FFieldAddress CreateAsset_CallingContext_PropertyAddress;

	private static int CreateAsset_CallingContext_Offset;

	private static bool CreateAsset_ReturnValue_IsValid;

	private static FFieldAddress CreateAsset_ReturnValue_PropertyAddress;

	private static int CreateAsset_ReturnValue_Offset;

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:RenameReferencingSoftObjectPaths")]
	public unsafe void RenameReferencingSoftObjectPaths(List<UPackage> PackagesToCheck, Dictionary<FSoftObjectPath, FSoftObjectPath> AssetRedirectorMap)
	{
		CheckDestroyed();
		if (!RenameReferencingSoftObjectPaths_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:RenameReferencingSoftObjectPaths");
			return;
		}
		if (RenameReferencingSoftObjectPaths_InstanceFunctionAddress == IntPtr.Zero)
		{
			RenameReferencingSoftObjectPaths_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RenameReferencingSoftObjectPaths");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameReferencingSoftObjectPaths_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameReferencingSoftObjectPaths_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UPackage>(1, RenameReferencingSoftObjectPaths_PackagesToCheck_PropertyAddress, CachedMarshalingDelegates<UPackage, UObjectMarshaler<UPackage>>.FromNative, CachedMarshalingDelegates<UPackage, UObjectMarshaler<UPackage>>.ToNative).ToNative(IntPtr.Add(intPtr, RenameReferencingSoftObjectPaths_PackagesToCheck_Offset), PackagesToCheck);
		NativeReflection.InitializeValue_InContainer(RenameReferencingSoftObjectPaths_AssetRedirectorMap_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<FSoftObjectPath, FSoftObjectPath>(1, RenameReferencingSoftObjectPaths_AssetRedirectorMap_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).ToNative(IntPtr.Add(intPtr, RenameReferencingSoftObjectPaths_AssetRedirectorMap_Offset), AssetRedirectorMap);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameReferencingSoftObjectPaths_InstanceFunctionAddress, intPtr, RenameReferencingSoftObjectPaths_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RenameReferencingSoftObjectPaths_PackagesToCheck_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RenameReferencingSoftObjectPaths_AssetRedirectorMap_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:RenameAssetsWithDialog")]
	public unsafe EAssetRenameResult RenameAssetsWithDialog(List<FAssetRenameData> AssetsAndNames, bool bAutoCheckout = false)
	{
		CheckDestroyed();
		if (!RenameAssetsWithDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:RenameAssetsWithDialog");
			return EAssetRenameResult.Failure;
		}
		if (RenameAssetsWithDialog_InstanceFunctionAddress == IntPtr.Zero)
		{
			RenameAssetsWithDialog_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RenameAssetsWithDialog");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameAssetsWithDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameAssetsWithDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAssetRenameData>(1, RenameAssetsWithDialog_AssetsAndNames_PropertyAddress, CachedMarshalingDelegates<FAssetRenameData, FAssetRenameData>.FromNative, CachedMarshalingDelegates<FAssetRenameData, FAssetRenameData>.ToNative).ToNative(IntPtr.Add(intPtr, RenameAssetsWithDialog_AssetsAndNames_Offset), AssetsAndNames);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RenameAssetsWithDialog_bAutoCheckout_Offset), 0, RenameAssetsWithDialog_bAutoCheckout_PropertyAddress.Address, bAutoCheckout);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameAssetsWithDialog_InstanceFunctionAddress, intPtr, RenameAssetsWithDialog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RenameAssetsWithDialog_AssetsAndNames_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EAssetRenameResult>.FromNative(IntPtr.Add(intPtr, RenameAssetsWithDialog_ReturnValue_Offset), 0, RenameAssetsWithDialog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:RenameAssets")]
	public unsafe bool RenameAssets(List<FAssetRenameData> AssetsAndNames)
	{
		CheckDestroyed();
		if (!RenameAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:RenameAssets");
			return false;
		}
		if (RenameAssets_InstanceFunctionAddress == IntPtr.Zero)
		{
			RenameAssets_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "RenameAssets");
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAssetRenameData>(1, RenameAssets_AssetsAndNames_PropertyAddress, CachedMarshalingDelegates<FAssetRenameData, FAssetRenameData>.FromNative, CachedMarshalingDelegates<FAssetRenameData, FAssetRenameData>.ToNative).ToNative(IntPtr.Add(intPtr, RenameAssets_AssetsAndNames_Offset), AssetsAndNames);
		NativeReflection.InvokeFunctionOptimized(base.Address, RenameAssets_InstanceFunctionAddress, intPtr, RenameAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RenameAssets_AssetsAndNames_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameAssets_ReturnValue_Offset), 0, RenameAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:ImportAssetTasks")]
	public unsafe void ImportAssetTasks(List<UAssetImportTask> ImportTasks)
	{
		CheckDestroyed();
		if (!ImportAssetTasks_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:ImportAssetTasks");
			return;
		}
		if (ImportAssetTasks_InstanceFunctionAddress == IntPtr.Zero)
		{
			ImportAssetTasks_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ImportAssetTasks");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportAssetTasks_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportAssetTasks_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UAssetImportTask>(1, ImportAssetTasks_ImportTasks_PropertyAddress, CachedMarshalingDelegates<UAssetImportTask, UObjectMarshaler<UAssetImportTask>>.FromNative, CachedMarshalingDelegates<UAssetImportTask, UObjectMarshaler<UAssetImportTask>>.ToNative).ToNative(IntPtr.Add(intPtr, ImportAssetTasks_ImportTasks_Offset), ImportTasks);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportAssetTasks_InstanceFunctionAddress, intPtr, ImportAssetTasks_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportAssetTasks_ImportTasks_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:ImportAssetsWithDialog")]
	public unsafe List<UObject> ImportAssetsWithDialog(string DestinationPath)
	{
		CheckDestroyed();
		if (!ImportAssetsWithDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:ImportAssetsWithDialog");
			return null;
		}
		if (ImportAssetsWithDialog_InstanceFunctionAddress == IntPtr.Zero)
		{
			ImportAssetsWithDialog_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ImportAssetsWithDialog");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportAssetsWithDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportAssetsWithDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ImportAssetsWithDialog_DestinationPath_Offset), 0, ImportAssetsWithDialog_DestinationPath_PropertyAddress.Address, DestinationPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportAssetsWithDialog_InstanceFunctionAddress, intPtr, ImportAssetsWithDialog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ImportAssetsWithDialog_DestinationPath_PropertyAddress.Address, intPtr);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, ImportAssetsWithDialog_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, ImportAssetsWithDialog_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ImportAssetsWithDialog_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:ImportAssetsAutomated")]
	public unsafe List<UObject> ImportAssetsAutomated(UAutomatedAssetImportData ImportData)
	{
		CheckDestroyed();
		if (!ImportAssetsAutomated_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:ImportAssetsAutomated");
			return null;
		}
		if (ImportAssetsAutomated_InstanceFunctionAddress == IntPtr.Zero)
		{
			ImportAssetsAutomated_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ImportAssetsAutomated");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ImportAssetsAutomated_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ImportAssetsAutomated_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAutomatedAssetImportData>.ToNative(IntPtr.Add(intPtr, ImportAssetsAutomated_ImportData_Offset), 0, ImportAssetsAutomated_ImportData_PropertyAddress.Address, ImportData);
		NativeReflection.InvokeFunctionOptimized(base.Address, ImportAssetsAutomated_InstanceFunctionAddress, intPtr, ImportAssetsAutomated_ParamsSize);
		List<UObject> result = new TArrayCopyMarshaler<UObject>(1, ImportAssetsAutomated_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, ImportAssetsAutomated_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ImportAssetsAutomated_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/AssetTools.AssetTools:FindSoftReferencesToObject")]
	public unsafe void FindSoftReferencesToObject(FSoftObjectPath TargetObject, out List<UObject> ReferencingObjects)
	{
		CheckDestroyed();
		if (!FindSoftReferencesToObject_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:FindSoftReferencesToObject");
			ReferencingObjects = null;
			return;
		}
		if (FindSoftReferencesToObject_InstanceFunctionAddress == IntPtr.Zero)
		{
			FindSoftReferencesToObject_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "FindSoftReferencesToObject");
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindSoftReferencesToObject_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindSoftReferencesToObject_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FSoftObjectPath.ToNative(IntPtr.Add(intPtr, FindSoftReferencesToObject_TargetObject_Offset), 0, FindSoftReferencesToObject_TargetObject_PropertyAddress.Address, TargetObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindSoftReferencesToObject_InstanceFunctionAddress, intPtr, FindSoftReferencesToObject_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindSoftReferencesToObject_TargetObject_PropertyAddress.Address, intPtr);
		ReferencingObjects = new TArrayCopyMarshaler<UObject>(1, FindSoftReferencesToObject_ReferencingObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, FindSoftReferencesToObject_ReferencingObjects_Offset));
		NativeReflection.DestroyValue_InContainer(FindSoftReferencesToObject_ReferencingObjects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:ExportAssetsWithDialog")]
	public unsafe void ExportAssetsWithDialog(List<string> AssetsToExport, bool bPromptForIndividualFilenames)
	{
		CheckDestroyed();
		if (!ExportAssetsWithDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:ExportAssetsWithDialog");
			return;
		}
		if (ExportAssetsWithDialog_InstanceFunctionAddress == IntPtr.Zero)
		{
			ExportAssetsWithDialog_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ExportAssetsWithDialog");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportAssetsWithDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportAssetsWithDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, ExportAssetsWithDialog_AssetsToExport_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ExportAssetsWithDialog_AssetsToExport_Offset), AssetsToExport);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExportAssetsWithDialog_bPromptForIndividualFilenames_Offset), 0, ExportAssetsWithDialog_bPromptForIndividualFilenames_PropertyAddress.Address, bPromptForIndividualFilenames);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExportAssetsWithDialog_InstanceFunctionAddress, intPtr, ExportAssetsWithDialog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportAssetsWithDialog_AssetsToExport_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:ExportAssets")]
	public unsafe void ExportAssets(List<string> AssetsToExport, string ExportPath)
	{
		CheckDestroyed();
		if (!ExportAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:ExportAssets");
			return;
		}
		if (ExportAssets_InstanceFunctionAddress == IntPtr.Zero)
		{
			ExportAssets_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ExportAssets");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExportAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExportAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, ExportAssets_AssetsToExport_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, ExportAssets_AssetsToExport_Offset), AssetsToExport);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExportAssets_ExportPath_Offset), 0, ExportAssets_ExportPath_PropertyAddress.Address, ExportPath);
		NativeReflection.InvokeFunctionOptimized(base.Address, ExportAssets_InstanceFunctionAddress, intPtr, ExportAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExportAssets_AssetsToExport_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExportAssets_ExportPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:DuplicateAssetWithDialogAndTitle")]
	public unsafe UObject DuplicateAssetWithDialogAndTitle(string AssetName, string PackagePath, UObject OriginalObject, FText DialogTitle)
	{
		CheckDestroyed();
		if (!DuplicateAssetWithDialogAndTitle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:DuplicateAssetWithDialogAndTitle");
			return null;
		}
		if (DuplicateAssetWithDialogAndTitle_InstanceFunctionAddress == IntPtr.Zero)
		{
			DuplicateAssetWithDialogAndTitle_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DuplicateAssetWithDialogAndTitle");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateAssetWithDialogAndTitle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateAssetWithDialogAndTitle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAssetWithDialogAndTitle_AssetName_Offset), 0, DuplicateAssetWithDialogAndTitle_AssetName_PropertyAddress.Address, AssetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAssetWithDialogAndTitle_PackagePath_Offset), 0, DuplicateAssetWithDialogAndTitle_PackagePath_PropertyAddress.Address, PackagePath);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DuplicateAssetWithDialogAndTitle_OriginalObject_Offset), 0, DuplicateAssetWithDialogAndTitle_OriginalObject_PropertyAddress.Address, OriginalObject);
		NativeReflection.InitializeValue_InContainer(DuplicateAssetWithDialogAndTitle_DialogTitle_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAssetWithDialogAndTitle_DialogTitle_Offset), 0, DuplicateAssetWithDialogAndTitle_DialogTitle_PropertyAddress.Address, DialogTitle);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateAssetWithDialogAndTitle_InstanceFunctionAddress, intPtr, DuplicateAssetWithDialogAndTitle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateAssetWithDialogAndTitle_AssetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAssetWithDialogAndTitle_PackagePath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAssetWithDialogAndTitle_DialogTitle_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, DuplicateAssetWithDialogAndTitle_ReturnValue_Offset), 0, DuplicateAssetWithDialogAndTitle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:DuplicateAssetWithDialog")]
	public unsafe UObject DuplicateAssetWithDialog(string AssetName, string PackagePath, UObject OriginalObject)
	{
		CheckDestroyed();
		if (!DuplicateAssetWithDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:DuplicateAssetWithDialog");
			return null;
		}
		if (DuplicateAssetWithDialog_InstanceFunctionAddress == IntPtr.Zero)
		{
			DuplicateAssetWithDialog_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DuplicateAssetWithDialog");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateAssetWithDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateAssetWithDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAssetWithDialog_AssetName_Offset), 0, DuplicateAssetWithDialog_AssetName_PropertyAddress.Address, AssetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAssetWithDialog_PackagePath_Offset), 0, DuplicateAssetWithDialog_PackagePath_PropertyAddress.Address, PackagePath);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DuplicateAssetWithDialog_OriginalObject_Offset), 0, DuplicateAssetWithDialog_OriginalObject_PropertyAddress.Address, OriginalObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateAssetWithDialog_InstanceFunctionAddress, intPtr, DuplicateAssetWithDialog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateAssetWithDialog_AssetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAssetWithDialog_PackagePath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, DuplicateAssetWithDialog_ReturnValue_Offset), 0, DuplicateAssetWithDialog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:DuplicateAsset")]
	public unsafe UObject DuplicateAsset(string AssetName, string PackagePath, UObject OriginalObject)
	{
		CheckDestroyed();
		if (!DuplicateAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:DuplicateAsset");
			return null;
		}
		if (DuplicateAsset_InstanceFunctionAddress == IntPtr.Zero)
		{
			DuplicateAsset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "DuplicateAsset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAsset_AssetName_Offset), 0, DuplicateAsset_AssetName_PropertyAddress.Address, AssetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAsset_PackagePath_Offset), 0, DuplicateAsset_PackagePath_PropertyAddress.Address, PackagePath);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DuplicateAsset_OriginalObject_Offset), 0, DuplicateAsset_OriginalObject_PropertyAddress.Address, OriginalObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, DuplicateAsset_InstanceFunctionAddress, intPtr, DuplicateAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateAsset_AssetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAsset_PackagePath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, DuplicateAsset_ReturnValue_Offset), 0, DuplicateAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/AssetTools.AssetTools:CreateUniqueAssetName")]
	public unsafe void CreateUniqueAssetName(string InBasePackageName, string InSuffix, out string OutPackageName, out string OutAssetName)
	{
		CheckDestroyed();
		if (!CreateUniqueAssetName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:CreateUniqueAssetName");
			OutPackageName = FStringMarshaler.DefaultString;
			OutAssetName = FStringMarshaler.DefaultString;
			return;
		}
		if (CreateUniqueAssetName_InstanceFunctionAddress == IntPtr.Zero)
		{
			CreateUniqueAssetName_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CreateUniqueAssetName");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateUniqueAssetName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateUniqueAssetName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateUniqueAssetName_InBasePackageName_Offset), 0, CreateUniqueAssetName_InBasePackageName_PropertyAddress.Address, InBasePackageName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateUniqueAssetName_InSuffix_Offset), 0, CreateUniqueAssetName_InSuffix_PropertyAddress.Address, InSuffix);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateUniqueAssetName_InstanceFunctionAddress, intPtr, CreateUniqueAssetName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateUniqueAssetName_InBasePackageName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateUniqueAssetName_InSuffix_PropertyAddress.Address, intPtr);
		OutPackageName = FStringMarshaler.FromNative(IntPtr.Add(intPtr, CreateUniqueAssetName_OutPackageName_Offset), 0, CreateUniqueAssetName_OutPackageName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateUniqueAssetName_OutPackageName_PropertyAddress.Address, intPtr);
		OutAssetName = FStringMarshaler.FromNative(IntPtr.Add(intPtr, CreateUniqueAssetName_OutAssetName_Offset), 0, CreateUniqueAssetName_OutAssetName_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CreateUniqueAssetName_OutAssetName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:CreateAssetWithDialog")]
	public unsafe UObject CreateAssetWithDialog(string AssetName, string PackagePath, TSubclassOf<UObject> AssetClass, UFactory Factory, FName CallingContext, bool bCallConfigureProperties)
	{
		CheckDestroyed();
		if (!CreateAssetWithDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:CreateAssetWithDialog");
			return null;
		}
		if (CreateAssetWithDialog_InstanceFunctionAddress == IntPtr.Zero)
		{
			CreateAssetWithDialog_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CreateAssetWithDialog");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateAssetWithDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateAssetWithDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAssetWithDialog_AssetName_Offset), 0, CreateAssetWithDialog_AssetName_PropertyAddress.Address, AssetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAssetWithDialog_PackagePath_Offset), 0, CreateAssetWithDialog_PackagePath_PropertyAddress.Address, PackagePath);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateAssetWithDialog_AssetClass_Offset), 0, CreateAssetWithDialog_AssetClass_PropertyAddress.Address, AssetClass);
		UObjectMarshaler<UFactory>.ToNative(IntPtr.Add(intPtr, CreateAssetWithDialog_Factory_Offset), 0, CreateAssetWithDialog_Factory_PropertyAddress.Address, Factory);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateAssetWithDialog_CallingContext_Offset), 0, CreateAssetWithDialog_CallingContext_PropertyAddress.Address, CallingContext);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateAssetWithDialog_bCallConfigureProperties_Offset), 0, CreateAssetWithDialog_bCallConfigureProperties_PropertyAddress.Address, bCallConfigureProperties);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateAssetWithDialog_InstanceFunctionAddress, intPtr, CreateAssetWithDialog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateAssetWithDialog_AssetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateAssetWithDialog_PackagePath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, CreateAssetWithDialog_ReturnValue_Offset), 0, CreateAssetWithDialog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/AssetTools.AssetTools:CreateAsset")]
	public unsafe UObject CreateAsset(string AssetName, string PackagePath, TSubclassOf<UObject> AssetClass, UFactory Factory, FName CallingContext)
	{
		CheckDestroyed();
		if (!CreateAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AssetTools.AssetTools:CreateAsset");
			return null;
		}
		if (CreateAsset_InstanceFunctionAddress == IntPtr.Zero)
		{
			CreateAsset_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "CreateAsset");
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAsset_AssetName_Offset), 0, CreateAsset_AssetName_PropertyAddress.Address, AssetName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateAsset_PackagePath_Offset), 0, CreateAsset_PackagePath_PropertyAddress.Address, PackagePath);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateAsset_AssetClass_Offset), 0, CreateAsset_AssetClass_PropertyAddress.Address, AssetClass);
		UObjectMarshaler<UFactory>.ToNative(IntPtr.Add(intPtr, CreateAsset_Factory_Offset), 0, CreateAsset_Factory_PropertyAddress.Address, Factory);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, CreateAsset_CallingContext_Offset), 0, CreateAsset_CallingContext_PropertyAddress.Address, CallingContext);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateAsset_InstanceFunctionAddress, intPtr, CreateAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateAsset_AssetName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateAsset_PackagePath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, CreateAsset_ReturnValue_Offset), 0, CreateAsset_ReturnValue_PropertyAddress.Address);
	}

	public override void ResetInterface()
	{
		RenameReferencingSoftObjectPaths_InstanceFunctionAddress = IntPtr.Zero;
		RenameAssetsWithDialog_InstanceFunctionAddress = IntPtr.Zero;
		RenameAssets_InstanceFunctionAddress = IntPtr.Zero;
		ImportAssetTasks_InstanceFunctionAddress = IntPtr.Zero;
		ImportAssetsWithDialog_InstanceFunctionAddress = IntPtr.Zero;
		ImportAssetsAutomated_InstanceFunctionAddress = IntPtr.Zero;
		FindSoftReferencesToObject_InstanceFunctionAddress = IntPtr.Zero;
		ExportAssetsWithDialog_InstanceFunctionAddress = IntPtr.Zero;
		ExportAssets_InstanceFunctionAddress = IntPtr.Zero;
		DuplicateAssetWithDialogAndTitle_InstanceFunctionAddress = IntPtr.Zero;
		DuplicateAssetWithDialog_InstanceFunctionAddress = IntPtr.Zero;
		DuplicateAsset_InstanceFunctionAddress = IntPtr.Zero;
		CreateUniqueAssetName_InstanceFunctionAddress = IntPtr.Zero;
		CreateAssetWithDialog_InstanceFunctionAddress = IntPtr.Zero;
		CreateAsset_InstanceFunctionAddress = IntPtr.Zero;
	}

	static IAssetToolsImpl()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(IAssetToolsImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(IAssetToolsImpl));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AssetTools.AssetTools");
		RenameReferencingSoftObjectPaths_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RenameReferencingSoftObjectPaths");
		RenameReferencingSoftObjectPaths_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameReferencingSoftObjectPaths_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameReferencingSoftObjectPaths_PackagesToCheck_PropertyAddress, RenameReferencingSoftObjectPaths_FunctionAddress, "PackagesToCheck");
		RenameReferencingSoftObjectPaths_PackagesToCheck_Offset = NativeReflectionCached.GetPropertyOffset(RenameReferencingSoftObjectPaths_FunctionAddress, "PackagesToCheck");
		RenameReferencingSoftObjectPaths_PackagesToCheck_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameReferencingSoftObjectPaths_FunctionAddress, "PackagesToCheck", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameReferencingSoftObjectPaths_AssetRedirectorMap_PropertyAddress, RenameReferencingSoftObjectPaths_FunctionAddress, "AssetRedirectorMap");
		RenameReferencingSoftObjectPaths_AssetRedirectorMap_Offset = NativeReflectionCached.GetPropertyOffset(RenameReferencingSoftObjectPaths_FunctionAddress, "AssetRedirectorMap");
		RenameReferencingSoftObjectPaths_AssetRedirectorMap_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameReferencingSoftObjectPaths_FunctionAddress, "AssetRedirectorMap", Classes.FMapProperty);
		RenameReferencingSoftObjectPaths_IsValid = RenameReferencingSoftObjectPaths_FunctionAddress != IntPtr.Zero && RenameReferencingSoftObjectPaths_PackagesToCheck_IsValid && RenameReferencingSoftObjectPaths_AssetRedirectorMap_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:RenameReferencingSoftObjectPaths", RenameReferencingSoftObjectPaths_IsValid);
		RenameAssetsWithDialog_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RenameAssetsWithDialog");
		RenameAssetsWithDialog_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameAssetsWithDialog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameAssetsWithDialog_AssetsAndNames_PropertyAddress, RenameAssetsWithDialog_FunctionAddress, "AssetsAndNames");
		RenameAssetsWithDialog_AssetsAndNames_Offset = NativeReflectionCached.GetPropertyOffset(RenameAssetsWithDialog_FunctionAddress, "AssetsAndNames");
		RenameAssetsWithDialog_AssetsAndNames_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAssetsWithDialog_FunctionAddress, "AssetsAndNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameAssetsWithDialog_bAutoCheckout_PropertyAddress, RenameAssetsWithDialog_FunctionAddress, "bAutoCheckout");
		RenameAssetsWithDialog_bAutoCheckout_Offset = NativeReflectionCached.GetPropertyOffset(RenameAssetsWithDialog_FunctionAddress, "bAutoCheckout");
		RenameAssetsWithDialog_bAutoCheckout_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAssetsWithDialog_FunctionAddress, "bAutoCheckout", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameAssetsWithDialog_ReturnValue_PropertyAddress, RenameAssetsWithDialog_FunctionAddress, "ReturnValue");
		RenameAssetsWithDialog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameAssetsWithDialog_FunctionAddress, "ReturnValue");
		RenameAssetsWithDialog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAssetsWithDialog_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		RenameAssetsWithDialog_IsValid = RenameAssetsWithDialog_FunctionAddress != IntPtr.Zero && RenameAssetsWithDialog_AssetsAndNames_IsValid && RenameAssetsWithDialog_bAutoCheckout_IsValid && RenameAssetsWithDialog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:RenameAssetsWithDialog", RenameAssetsWithDialog_IsValid);
		RenameAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RenameAssets");
		RenameAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameAssets_AssetsAndNames_PropertyAddress, RenameAssets_FunctionAddress, "AssetsAndNames");
		RenameAssets_AssetsAndNames_Offset = NativeReflectionCached.GetPropertyOffset(RenameAssets_FunctionAddress, "AssetsAndNames");
		RenameAssets_AssetsAndNames_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAssets_FunctionAddress, "AssetsAndNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameAssets_ReturnValue_PropertyAddress, RenameAssets_FunctionAddress, "ReturnValue");
		RenameAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameAssets_FunctionAddress, "ReturnValue");
		RenameAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameAssets_IsValid = RenameAssets_FunctionAddress != IntPtr.Zero && RenameAssets_AssetsAndNames_IsValid && RenameAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:RenameAssets", RenameAssets_IsValid);
		ImportAssetTasks_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ImportAssetTasks");
		ImportAssetTasks_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportAssetTasks_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportAssetTasks_ImportTasks_PropertyAddress, ImportAssetTasks_FunctionAddress, "ImportTasks");
		ImportAssetTasks_ImportTasks_Offset = NativeReflectionCached.GetPropertyOffset(ImportAssetTasks_FunctionAddress, "ImportTasks");
		ImportAssetTasks_ImportTasks_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAssetTasks_FunctionAddress, "ImportTasks", Classes.FArrayProperty);
		ImportAssetTasks_IsValid = ImportAssetTasks_FunctionAddress != IntPtr.Zero && ImportAssetTasks_ImportTasks_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:ImportAssetTasks", ImportAssetTasks_IsValid);
		ImportAssetsWithDialog_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ImportAssetsWithDialog");
		ImportAssetsWithDialog_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportAssetsWithDialog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportAssetsWithDialog_DestinationPath_PropertyAddress, ImportAssetsWithDialog_FunctionAddress, "DestinationPath");
		ImportAssetsWithDialog_DestinationPath_Offset = NativeReflectionCached.GetPropertyOffset(ImportAssetsWithDialog_FunctionAddress, "DestinationPath");
		ImportAssetsWithDialog_DestinationPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAssetsWithDialog_FunctionAddress, "DestinationPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportAssetsWithDialog_ReturnValue_PropertyAddress, ImportAssetsWithDialog_FunctionAddress, "ReturnValue");
		ImportAssetsWithDialog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportAssetsWithDialog_FunctionAddress, "ReturnValue");
		ImportAssetsWithDialog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAssetsWithDialog_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ImportAssetsWithDialog_IsValid = ImportAssetsWithDialog_FunctionAddress != IntPtr.Zero && ImportAssetsWithDialog_DestinationPath_IsValid && ImportAssetsWithDialog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:ImportAssetsWithDialog", ImportAssetsWithDialog_IsValid);
		ImportAssetsAutomated_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ImportAssetsAutomated");
		ImportAssetsAutomated_ParamsSize = NativeReflection.GetFunctionParamsSize(ImportAssetsAutomated_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ImportAssetsAutomated_ImportData_PropertyAddress, ImportAssetsAutomated_FunctionAddress, "ImportData");
		ImportAssetsAutomated_ImportData_Offset = NativeReflectionCached.GetPropertyOffset(ImportAssetsAutomated_FunctionAddress, "ImportData");
		ImportAssetsAutomated_ImportData_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAssetsAutomated_FunctionAddress, "ImportData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ImportAssetsAutomated_ReturnValue_PropertyAddress, ImportAssetsAutomated_FunctionAddress, "ReturnValue");
		ImportAssetsAutomated_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ImportAssetsAutomated_FunctionAddress, "ReturnValue");
		ImportAssetsAutomated_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ImportAssetsAutomated_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ImportAssetsAutomated_IsValid = ImportAssetsAutomated_FunctionAddress != IntPtr.Zero && ImportAssetsAutomated_ImportData_IsValid && ImportAssetsAutomated_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:ImportAssetsAutomated", ImportAssetsAutomated_IsValid);
		FindSoftReferencesToObject_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindSoftReferencesToObject");
		FindSoftReferencesToObject_ParamsSize = NativeReflection.GetFunctionParamsSize(FindSoftReferencesToObject_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindSoftReferencesToObject_TargetObject_PropertyAddress, FindSoftReferencesToObject_FunctionAddress, "TargetObject");
		FindSoftReferencesToObject_TargetObject_Offset = NativeReflectionCached.GetPropertyOffset(FindSoftReferencesToObject_FunctionAddress, "TargetObject");
		FindSoftReferencesToObject_TargetObject_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSoftReferencesToObject_FunctionAddress, "TargetObject", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSoftReferencesToObject_ReferencingObjects_PropertyAddress, FindSoftReferencesToObject_FunctionAddress, "ReferencingObjects");
		FindSoftReferencesToObject_ReferencingObjects_Offset = NativeReflectionCached.GetPropertyOffset(FindSoftReferencesToObject_FunctionAddress, "ReferencingObjects");
		FindSoftReferencesToObject_ReferencingObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSoftReferencesToObject_FunctionAddress, "ReferencingObjects", Classes.FArrayProperty);
		FindSoftReferencesToObject_IsValid = FindSoftReferencesToObject_FunctionAddress != IntPtr.Zero && FindSoftReferencesToObject_TargetObject_IsValid && FindSoftReferencesToObject_ReferencingObjects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:FindSoftReferencesToObject", FindSoftReferencesToObject_IsValid);
		ExportAssetsWithDialog_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportAssetsWithDialog");
		ExportAssetsWithDialog_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportAssetsWithDialog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportAssetsWithDialog_AssetsToExport_PropertyAddress, ExportAssetsWithDialog_FunctionAddress, "AssetsToExport");
		ExportAssetsWithDialog_AssetsToExport_Offset = NativeReflectionCached.GetPropertyOffset(ExportAssetsWithDialog_FunctionAddress, "AssetsToExport");
		ExportAssetsWithDialog_AssetsToExport_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAssetsWithDialog_FunctionAddress, "AssetsToExport", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportAssetsWithDialog_bPromptForIndividualFilenames_PropertyAddress, ExportAssetsWithDialog_FunctionAddress, "bPromptForIndividualFilenames");
		ExportAssetsWithDialog_bPromptForIndividualFilenames_Offset = NativeReflectionCached.GetPropertyOffset(ExportAssetsWithDialog_FunctionAddress, "bPromptForIndividualFilenames");
		ExportAssetsWithDialog_bPromptForIndividualFilenames_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAssetsWithDialog_FunctionAddress, "bPromptForIndividualFilenames", Classes.FBoolProperty);
		ExportAssetsWithDialog_IsValid = ExportAssetsWithDialog_FunctionAddress != IntPtr.Zero && ExportAssetsWithDialog_AssetsToExport_IsValid && ExportAssetsWithDialog_bPromptForIndividualFilenames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:ExportAssetsWithDialog", ExportAssetsWithDialog_IsValid);
		ExportAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExportAssets");
		ExportAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(ExportAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExportAssets_AssetsToExport_PropertyAddress, ExportAssets_FunctionAddress, "AssetsToExport");
		ExportAssets_AssetsToExport_Offset = NativeReflectionCached.GetPropertyOffset(ExportAssets_FunctionAddress, "AssetsToExport");
		ExportAssets_AssetsToExport_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAssets_FunctionAddress, "AssetsToExport", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ExportAssets_ExportPath_PropertyAddress, ExportAssets_FunctionAddress, "ExportPath");
		ExportAssets_ExportPath_Offset = NativeReflectionCached.GetPropertyOffset(ExportAssets_FunctionAddress, "ExportPath");
		ExportAssets_ExportPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ExportAssets_FunctionAddress, "ExportPath", Classes.FStrProperty);
		ExportAssets_IsValid = ExportAssets_FunctionAddress != IntPtr.Zero && ExportAssets_AssetsToExport_IsValid && ExportAssets_ExportPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:ExportAssets", ExportAssets_IsValid);
		DuplicateAssetWithDialogAndTitle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DuplicateAssetWithDialogAndTitle");
		DuplicateAssetWithDialogAndTitle_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateAssetWithDialogAndTitle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAssetWithDialogAndTitle_AssetName_PropertyAddress, DuplicateAssetWithDialogAndTitle_FunctionAddress, "AssetName");
		DuplicateAssetWithDialogAndTitle_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAssetWithDialogAndTitle_FunctionAddress, "AssetName");
		DuplicateAssetWithDialogAndTitle_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAssetWithDialogAndTitle_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAssetWithDialogAndTitle_PackagePath_PropertyAddress, DuplicateAssetWithDialogAndTitle_FunctionAddress, "PackagePath");
		DuplicateAssetWithDialogAndTitle_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAssetWithDialogAndTitle_FunctionAddress, "PackagePath");
		DuplicateAssetWithDialogAndTitle_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAssetWithDialogAndTitle_FunctionAddress, "PackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAssetWithDialogAndTitle_OriginalObject_PropertyAddress, DuplicateAssetWithDialogAndTitle_FunctionAddress, "OriginalObject");
		DuplicateAssetWithDialogAndTitle_OriginalObject_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAssetWithDialogAndTitle_FunctionAddress, "OriginalObject");
		DuplicateAssetWithDialogAndTitle_OriginalObject_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAssetWithDialogAndTitle_FunctionAddress, "OriginalObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAssetWithDialogAndTitle_DialogTitle_PropertyAddress, DuplicateAssetWithDialogAndTitle_FunctionAddress, "DialogTitle");
		DuplicateAssetWithDialogAndTitle_DialogTitle_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAssetWithDialogAndTitle_FunctionAddress, "DialogTitle");
		DuplicateAssetWithDialogAndTitle_DialogTitle_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAssetWithDialogAndTitle_FunctionAddress, "DialogTitle", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAssetWithDialogAndTitle_ReturnValue_PropertyAddress, DuplicateAssetWithDialogAndTitle_FunctionAddress, "ReturnValue");
		DuplicateAssetWithDialogAndTitle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAssetWithDialogAndTitle_FunctionAddress, "ReturnValue");
		DuplicateAssetWithDialogAndTitle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAssetWithDialogAndTitle_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateAssetWithDialogAndTitle_IsValid = DuplicateAssetWithDialogAndTitle_FunctionAddress != IntPtr.Zero && DuplicateAssetWithDialogAndTitle_AssetName_IsValid && DuplicateAssetWithDialogAndTitle_PackagePath_IsValid && DuplicateAssetWithDialogAndTitle_OriginalObject_IsValid && DuplicateAssetWithDialogAndTitle_DialogTitle_IsValid && DuplicateAssetWithDialogAndTitle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:DuplicateAssetWithDialogAndTitle", DuplicateAssetWithDialogAndTitle_IsValid);
		DuplicateAssetWithDialog_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DuplicateAssetWithDialog");
		DuplicateAssetWithDialog_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateAssetWithDialog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAssetWithDialog_AssetName_PropertyAddress, DuplicateAssetWithDialog_FunctionAddress, "AssetName");
		DuplicateAssetWithDialog_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAssetWithDialog_FunctionAddress, "AssetName");
		DuplicateAssetWithDialog_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAssetWithDialog_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAssetWithDialog_PackagePath_PropertyAddress, DuplicateAssetWithDialog_FunctionAddress, "PackagePath");
		DuplicateAssetWithDialog_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAssetWithDialog_FunctionAddress, "PackagePath");
		DuplicateAssetWithDialog_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAssetWithDialog_FunctionAddress, "PackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAssetWithDialog_OriginalObject_PropertyAddress, DuplicateAssetWithDialog_FunctionAddress, "OriginalObject");
		DuplicateAssetWithDialog_OriginalObject_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAssetWithDialog_FunctionAddress, "OriginalObject");
		DuplicateAssetWithDialog_OriginalObject_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAssetWithDialog_FunctionAddress, "OriginalObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAssetWithDialog_ReturnValue_PropertyAddress, DuplicateAssetWithDialog_FunctionAddress, "ReturnValue");
		DuplicateAssetWithDialog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAssetWithDialog_FunctionAddress, "ReturnValue");
		DuplicateAssetWithDialog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAssetWithDialog_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateAssetWithDialog_IsValid = DuplicateAssetWithDialog_FunctionAddress != IntPtr.Zero && DuplicateAssetWithDialog_AssetName_IsValid && DuplicateAssetWithDialog_PackagePath_IsValid && DuplicateAssetWithDialog_OriginalObject_IsValid && DuplicateAssetWithDialog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:DuplicateAssetWithDialog", DuplicateAssetWithDialog_IsValid);
		DuplicateAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DuplicateAsset");
		DuplicateAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_AssetName_PropertyAddress, DuplicateAsset_FunctionAddress, "AssetName");
		DuplicateAsset_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "AssetName");
		DuplicateAsset_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_PackagePath_PropertyAddress, DuplicateAsset_FunctionAddress, "PackagePath");
		DuplicateAsset_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "PackagePath");
		DuplicateAsset_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "PackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_OriginalObject_PropertyAddress, DuplicateAsset_FunctionAddress, "OriginalObject");
		DuplicateAsset_OriginalObject_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "OriginalObject");
		DuplicateAsset_OriginalObject_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "OriginalObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_ReturnValue_PropertyAddress, DuplicateAsset_FunctionAddress, "ReturnValue");
		DuplicateAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "ReturnValue");
		DuplicateAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateAsset_IsValid = DuplicateAsset_FunctionAddress != IntPtr.Zero && DuplicateAsset_AssetName_IsValid && DuplicateAsset_PackagePath_IsValid && DuplicateAsset_OriginalObject_IsValid && DuplicateAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:DuplicateAsset", DuplicateAsset_IsValid);
		CreateUniqueAssetName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateUniqueAssetName");
		CreateUniqueAssetName_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateUniqueAssetName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueAssetName_InBasePackageName_PropertyAddress, CreateUniqueAssetName_FunctionAddress, "InBasePackageName");
		CreateUniqueAssetName_InBasePackageName_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueAssetName_FunctionAddress, "InBasePackageName");
		CreateUniqueAssetName_InBasePackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueAssetName_FunctionAddress, "InBasePackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueAssetName_InSuffix_PropertyAddress, CreateUniqueAssetName_FunctionAddress, "InSuffix");
		CreateUniqueAssetName_InSuffix_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueAssetName_FunctionAddress, "InSuffix");
		CreateUniqueAssetName_InSuffix_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueAssetName_FunctionAddress, "InSuffix", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueAssetName_OutPackageName_PropertyAddress, CreateUniqueAssetName_FunctionAddress, "OutPackageName");
		CreateUniqueAssetName_OutPackageName_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueAssetName_FunctionAddress, "OutPackageName");
		CreateUniqueAssetName_OutPackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueAssetName_FunctionAddress, "OutPackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateUniqueAssetName_OutAssetName_PropertyAddress, CreateUniqueAssetName_FunctionAddress, "OutAssetName");
		CreateUniqueAssetName_OutAssetName_Offset = NativeReflectionCached.GetPropertyOffset(CreateUniqueAssetName_FunctionAddress, "OutAssetName");
		CreateUniqueAssetName_OutAssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateUniqueAssetName_FunctionAddress, "OutAssetName", Classes.FStrProperty);
		CreateUniqueAssetName_IsValid = CreateUniqueAssetName_FunctionAddress != IntPtr.Zero && CreateUniqueAssetName_InBasePackageName_IsValid && CreateUniqueAssetName_InSuffix_IsValid && CreateUniqueAssetName_OutPackageName_IsValid && CreateUniqueAssetName_OutAssetName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:CreateUniqueAssetName", CreateUniqueAssetName_IsValid);
		CreateAssetWithDialog_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateAssetWithDialog");
		CreateAssetWithDialog_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateAssetWithDialog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateAssetWithDialog_AssetName_PropertyAddress, CreateAssetWithDialog_FunctionAddress, "AssetName");
		CreateAssetWithDialog_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(CreateAssetWithDialog_FunctionAddress, "AssetName");
		CreateAssetWithDialog_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAssetWithDialog_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAssetWithDialog_PackagePath_PropertyAddress, CreateAssetWithDialog_FunctionAddress, "PackagePath");
		CreateAssetWithDialog_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(CreateAssetWithDialog_FunctionAddress, "PackagePath");
		CreateAssetWithDialog_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAssetWithDialog_FunctionAddress, "PackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAssetWithDialog_AssetClass_PropertyAddress, CreateAssetWithDialog_FunctionAddress, "AssetClass");
		CreateAssetWithDialog_AssetClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateAssetWithDialog_FunctionAddress, "AssetClass");
		CreateAssetWithDialog_AssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAssetWithDialog_FunctionAddress, "AssetClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAssetWithDialog_Factory_PropertyAddress, CreateAssetWithDialog_FunctionAddress, "Factory");
		CreateAssetWithDialog_Factory_Offset = NativeReflectionCached.GetPropertyOffset(CreateAssetWithDialog_FunctionAddress, "Factory");
		CreateAssetWithDialog_Factory_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAssetWithDialog_FunctionAddress, "Factory", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAssetWithDialog_CallingContext_PropertyAddress, CreateAssetWithDialog_FunctionAddress, "CallingContext");
		CreateAssetWithDialog_CallingContext_Offset = NativeReflectionCached.GetPropertyOffset(CreateAssetWithDialog_FunctionAddress, "CallingContext");
		CreateAssetWithDialog_CallingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAssetWithDialog_FunctionAddress, "CallingContext", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAssetWithDialog_bCallConfigureProperties_PropertyAddress, CreateAssetWithDialog_FunctionAddress, "bCallConfigureProperties");
		CreateAssetWithDialog_bCallConfigureProperties_Offset = NativeReflectionCached.GetPropertyOffset(CreateAssetWithDialog_FunctionAddress, "bCallConfigureProperties");
		CreateAssetWithDialog_bCallConfigureProperties_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAssetWithDialog_FunctionAddress, "bCallConfigureProperties", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAssetWithDialog_ReturnValue_PropertyAddress, CreateAssetWithDialog_FunctionAddress, "ReturnValue");
		CreateAssetWithDialog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateAssetWithDialog_FunctionAddress, "ReturnValue");
		CreateAssetWithDialog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAssetWithDialog_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateAssetWithDialog_IsValid = CreateAssetWithDialog_FunctionAddress != IntPtr.Zero && CreateAssetWithDialog_AssetName_IsValid && CreateAssetWithDialog_PackagePath_IsValid && CreateAssetWithDialog_AssetClass_IsValid && CreateAssetWithDialog_Factory_IsValid && CreateAssetWithDialog_CallingContext_IsValid && CreateAssetWithDialog_bCallConfigureProperties_IsValid && CreateAssetWithDialog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:CreateAssetWithDialog", CreateAssetWithDialog_IsValid);
		CreateAsset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateAsset");
		CreateAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_AssetName_PropertyAddress, CreateAsset_FunctionAddress, "AssetName");
		CreateAsset_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "AssetName");
		CreateAsset_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_PackagePath_PropertyAddress, CreateAsset_FunctionAddress, "PackagePath");
		CreateAsset_PackagePath_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "PackagePath");
		CreateAsset_PackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "PackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_AssetClass_PropertyAddress, CreateAsset_FunctionAddress, "AssetClass");
		CreateAsset_AssetClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "AssetClass");
		CreateAsset_AssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "AssetClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_Factory_PropertyAddress, CreateAsset_FunctionAddress, "Factory");
		CreateAsset_Factory_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "Factory");
		CreateAsset_Factory_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "Factory", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_CallingContext_PropertyAddress, CreateAsset_FunctionAddress, "CallingContext");
		CreateAsset_CallingContext_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "CallingContext");
		CreateAsset_CallingContext_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "CallingContext", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateAsset_ReturnValue_PropertyAddress, CreateAsset_FunctionAddress, "ReturnValue");
		CreateAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateAsset_FunctionAddress, "ReturnValue");
		CreateAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateAsset_IsValid = CreateAsset_FunctionAddress != IntPtr.Zero && CreateAsset_AssetName_IsValid && CreateAsset_PackagePath_IsValid && CreateAsset_AssetClass_IsValid && CreateAsset_Factory_IsValid && CreateAsset_CallingContext_IsValid && CreateAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AssetTools.AssetTools:CreateAsset", CreateAsset_IsValid);
	}
}
