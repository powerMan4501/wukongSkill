using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorAssetLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UnloadPackagesByObjects_IsValid;

	private static IntPtr UnloadPackagesByObjects_FunctionAddress;

	private static int UnloadPackagesByObjects_ParamsSize;

	private static bool UnloadPackagesByObjects_Objects_IsValid;

	private static FFieldAddress UnloadPackagesByObjects_Objects_PropertyAddress;

	private static int UnloadPackagesByObjects_Objects_Offset;

	private static bool UnloadPackagesByAssetDataList_IsValid;

	private static IntPtr UnloadPackagesByAssetDataList_FunctionAddress;

	private static int UnloadPackagesByAssetDataList_ParamsSize;

	private static bool UnloadPackagesByAssetDataList_InAssetDataList_IsValid;

	private static FFieldAddress UnloadPackagesByAssetDataList_InAssetDataList_PropertyAddress;

	private static int UnloadPackagesByAssetDataList_InAssetDataList_Offset;

	private static bool SetSceneComponentVelocity_IsValid;

	private static IntPtr SetSceneComponentVelocity_FunctionAddress;

	private static int SetSceneComponentVelocity_ParamsSize;

	private static bool SetSceneComponentVelocity_SceneComponent_IsValid;

	private static FFieldAddress SetSceneComponentVelocity_SceneComponent_PropertyAddress;

	private static int SetSceneComponentVelocity_SceneComponent_Offset;

	private static bool SetSceneComponentVelocity_NewVelocity_IsValid;

	private static FFieldAddress SetSceneComponentVelocity_NewVelocity_PropertyAddress;

	private static int SetSceneComponentVelocity_NewVelocity_Offset;

	private static bool SelectAssetsToArrayString_IsValid;

	private static IntPtr SelectAssetsToArrayString_FunctionAddress;

	private static int SelectAssetsToArrayString_ParamsSize;

	private static bool SelectAssetsToArrayString_bContainPath_IsValid;

	private static FFieldAddress SelectAssetsToArrayString_bContainPath_PropertyAddress;

	private static int SelectAssetsToArrayString_bContainPath_Offset;

	private static bool SelectAssetsToArrayString_ReturnValue_IsValid;

	private static FFieldAddress SelectAssetsToArrayString_ReturnValue_PropertyAddress;

	private static int SelectAssetsToArrayString_ReturnValue_Offset;

	private static bool SelectAssets_IsValid;

	private static IntPtr SelectAssets_FunctionAddress;

	private static int SelectAssets_ParamsSize;

	private static bool SelectAssets_ObjectsToSelect_IsValid;

	private static FFieldAddress SelectAssets_ObjectsToSelect_PropertyAddress;

	private static int SelectAssets_ObjectsToSelect_Offset;

	private static bool SearchTableKeyWord_IsValid;

	private static IntPtr SearchTableKeyWord_FunctionAddress;

	private static int SearchTableKeyWord_ParamsSize;

	private static bool SearchTableKeyWord_SearchText_IsValid;

	private static FFieldAddress SearchTableKeyWord_SearchText_PropertyAddress;

	private static int SearchTableKeyWord_SearchText_Offset;

	private static bool SearchTableKeyWord_ReturnValue_IsValid;

	private static FFieldAddress SearchTableKeyWord_ReturnValue_PropertyAddress;

	private static int SearchTableKeyWord_ReturnValue_Offset;

	private static bool SaveAssets_IsValid;

	private static IntPtr SaveAssets_FunctionAddress;

	private static int SaveAssets_ParamsSize;

	private static bool SaveAssets_InAssets_IsValid;

	private static FFieldAddress SaveAssets_InAssets_PropertyAddress;

	private static int SaveAssets_InAssets_Offset;

	private static bool SaveAsset_IsValid;

	private static IntPtr SaveAsset_FunctionAddress;

	private static int SaveAsset_ParamsSize;

	private static bool SaveAsset_InAsset_IsValid;

	private static FFieldAddress SaveAsset_InAsset_PropertyAddress;

	private static int SaveAsset_InAsset_Offset;

	private static bool ReloadAssets_IsValid;

	private static IntPtr ReloadAssets_FunctionAddress;

	private static int ReloadAssets_ParamsSize;

	private static bool ReloadAssets_AssetPaths_IsValid;

	private static FFieldAddress ReloadAssets_AssetPaths_PropertyAddress;

	private static int ReloadAssets_AssetPaths_Offset;

	private static bool RecursiveGetDependencies_IsValid;

	private static IntPtr RecursiveGetDependencies_FunctionAddress;

	private static int RecursiveGetDependencies_ParamsSize;

	private static bool RecursiveGetDependencies_PackageName_IsValid;

	private static FFieldAddress RecursiveGetDependencies_PackageName_PropertyAddress;

	private static int RecursiveGetDependencies_PackageName_Offset;

	private static bool RecursiveGetDependencies_AllDependencies_IsValid;

	private static FFieldAddress RecursiveGetDependencies_AllDependencies_PropertyAddress;

	private static int RecursiveGetDependencies_AllDependencies_Offset;

	private static bool RecursiveGetDependencies_OutExternalObjectsPaths_IsValid;

	private static FFieldAddress RecursiveGetDependencies_OutExternalObjectsPaths_PropertyAddress;

	private static int RecursiveGetDependencies_OutExternalObjectsPaths_Offset;

	private static bool PerformMigratePackages_IsValid;

	private static IntPtr PerformMigratePackages_FunctionAddress;

	private static int PerformMigratePackages_ParamsSize;

	private static bool PerformMigratePackages_PackageNamesToMigrate_IsValid;

	private static FFieldAddress PerformMigratePackages_PackageNamesToMigrate_PropertyAddress;

	private static int PerformMigratePackages_PackageNamesToMigrate_Offset;

	private static bool PerformMigratePackages_ReturnValue_IsValid;

	private static FFieldAddress PerformMigratePackages_ReturnValue_PropertyAddress;

	private static int PerformMigratePackages_ReturnValue_Offset;

	private static bool OpenAsset_IsValid;

	private static IntPtr OpenAsset_FunctionAddress;

	private static int OpenAsset_ParamsSize;

	private static bool OpenAsset_InAsset_IsValid;

	private static FFieldAddress OpenAsset_InAsset_PropertyAddress;

	private static int OpenAsset_InAsset_Offset;

	private static bool MarkDirtyObjects_IsValid;

	private static IntPtr MarkDirtyObjects_FunctionAddress;

	private static int MarkDirtyObjects_ParamsSize;

	private static bool MarkDirtyObjects_Objs_IsValid;

	private static FFieldAddress MarkDirtyObjects_Objs_PropertyAddress;

	private static int MarkDirtyObjects_Objs_Offset;

	private static bool MakeAssetWritableAndSave_IsValid;

	private static IntPtr MakeAssetWritableAndSave_FunctionAddress;

	private static int MakeAssetWritableAndSave_ParamsSize;

	private static bool MakeAssetWritableAndSave_InObject_IsValid;

	private static FFieldAddress MakeAssetWritableAndSave_InObject_PropertyAddress;

	private static int MakeAssetWritableAndSave_InObject_Offset;

	private static bool MakeAssetWritableAndSave_ReturnValue_IsValid;

	private static FFieldAddress MakeAssetWritableAndSave_ReturnValue_PropertyAddress;

	private static int MakeAssetWritableAndSave_ReturnValue_Offset;

	private static bool IsSavingPackageOrGC_IsValid;

	private static IntPtr IsSavingPackageOrGC_FunctionAddress;

	private static int IsSavingPackageOrGC_ParamsSize;

	private static bool IsSavingPackageOrGC_ReturnValue_IsValid;

	private static FFieldAddress IsSavingPackageOrGC_ReturnValue_PropertyAddress;

	private static int IsSavingPackageOrGC_ReturnValue_Offset;

	private static bool IsNiagaraSystemNeedMergeEmitter_IsValid;

	private static IntPtr IsNiagaraSystemNeedMergeEmitter_FunctionAddress;

	private static int IsNiagaraSystemNeedMergeEmitter_ParamsSize;

	private static bool IsNiagaraSystemNeedMergeEmitter_NiagaraSystem_IsValid;

	private static FFieldAddress IsNiagaraSystemNeedMergeEmitter_NiagaraSystem_PropertyAddress;

	private static int IsNiagaraSystemNeedMergeEmitter_NiagaraSystem_Offset;

	private static bool IsNiagaraSystemNeedMergeEmitter_ReturnValue_IsValid;

	private static FFieldAddress IsNiagaraSystemNeedMergeEmitter_ReturnValue_PropertyAddress;

	private static int IsNiagaraSystemNeedMergeEmitter_ReturnValue_Offset;

	private static bool IsNiagaraSystemBadVMID_IsValid;

	private static IntPtr IsNiagaraSystemBadVMID_FunctionAddress;

	private static int IsNiagaraSystemBadVMID_ParamsSize;

	private static bool IsNiagaraSystemBadVMID_NiagaraSystem_IsValid;

	private static FFieldAddress IsNiagaraSystemBadVMID_NiagaraSystem_PropertyAddress;

	private static int IsNiagaraSystemBadVMID_NiagaraSystem_Offset;

	private static bool IsNiagaraSystemBadVMID_ReturnValue_IsValid;

	private static FFieldAddress IsNiagaraSystemBadVMID_ReturnValue_PropertyAddress;

	private static int IsNiagaraSystemBadVMID_ReturnValue_Offset;

	private static bool GetBlueprintTressFXComponentMaterials_IsValid;

	private static IntPtr GetBlueprintTressFXComponentMaterials_FunctionAddress;

	private static int GetBlueprintTressFXComponentMaterials_ParamsSize;

	private static bool GetBlueprintTressFXComponentMaterials_TargetBlueprint_IsValid;

	private static FFieldAddress GetBlueprintTressFXComponentMaterials_TargetBlueprint_PropertyAddress;

	private static int GetBlueprintTressFXComponentMaterials_TargetBlueprint_Offset;

	private static bool GetBlueprintTressFXComponentMaterials_ReturnValue_IsValid;

	private static FFieldAddress GetBlueprintTressFXComponentMaterials_ReturnValue_PropertyAddress;

	private static int GetBlueprintTressFXComponentMaterials_ReturnValue_Offset;

	private static bool GetAssetsByClassInFolder_IsValid;

	private static IntPtr GetAssetsByClassInFolder_FunctionAddress;

	private static int GetAssetsByClassInFolder_ParamsSize;

	private static bool GetAssetsByClassInFolder_OutAssetData_IsValid;

	private static FFieldAddress GetAssetsByClassInFolder_OutAssetData_PropertyAddress;

	private static int GetAssetsByClassInFolder_OutAssetData_Offset;

	private static bool GetAssetsByClassInFolder_Folder_IsValid;

	private static FFieldAddress GetAssetsByClassInFolder_Folder_PropertyAddress;

	private static int GetAssetsByClassInFolder_Folder_Offset;

	private static bool GetAssetsByClassInFolder_ClassName_IsValid;

	private static FFieldAddress GetAssetsByClassInFolder_ClassName_PropertyAddress;

	private static int GetAssetsByClassInFolder_ClassName_Offset;

	private static bool GetAssetsByClassInFolder_bRecursive_IsValid;

	private static FFieldAddress GetAssetsByClassInFolder_bRecursive_PropertyAddress;

	private static int GetAssetsByClassInFolder_bRecursive_Offset;

	private static bool GetAssetsByClassInFolder_bSearchSubClasses_IsValid;

	private static FFieldAddress GetAssetsByClassInFolder_bSearchSubClasses_PropertyAddress;

	private static int GetAssetsByClassInFolder_bSearchSubClasses_Offset;

	private static bool GetAssetsByClassInFolder_bIncludeOnlyOnDiskAssets_IsValid;

	private static FFieldAddress GetAssetsByClassInFolder_bIncludeOnlyOnDiskAssets_PropertyAddress;

	private static int GetAssetsByClassInFolder_bIncludeOnlyOnDiskAssets_Offset;

	private static bool GetAllRecursiveFoldersWithKeyword_IsValid;

	private static IntPtr GetAllRecursiveFoldersWithKeyword_FunctionAddress;

	private static int GetAllRecursiveFoldersWithKeyword_ParamsSize;

	private static bool GetAllRecursiveFoldersWithKeyword_InRootFolder_IsValid;

	private static FFieldAddress GetAllRecursiveFoldersWithKeyword_InRootFolder_PropertyAddress;

	private static int GetAllRecursiveFoldersWithKeyword_InRootFolder_Offset;

	private static bool GetAllRecursiveFoldersWithKeyword_InKeyword_IsValid;

	private static FFieldAddress GetAllRecursiveFoldersWithKeyword_InKeyword_PropertyAddress;

	private static int GetAllRecursiveFoldersWithKeyword_InKeyword_Offset;

	private static bool GetAllRecursiveFoldersWithKeyword_ReturnValue_IsValid;

	private static FFieldAddress GetAllRecursiveFoldersWithKeyword_ReturnValue_PropertyAddress;

	private static int GetAllRecursiveFoldersWithKeyword_ReturnValue_Offset;

	private static bool FixSelectedNiagaraSystemMergeParent_IsValid;

	private static IntPtr FixSelectedNiagaraSystemMergeParent_FunctionAddress;

	private static int FixSelectedNiagaraSystemMergeParent_ParamsSize;

	private static bool FixSelectedNiagaraSystemBadVMID_IsValid;

	private static IntPtr FixSelectedNiagaraSystemBadVMID_FunctionAddress;

	private static int FixSelectedNiagaraSystemBadVMID_ParamsSize;

	private static bool FixNiagaraSystemMergeParent_IsValid;

	private static IntPtr FixNiagaraSystemMergeParent_FunctionAddress;

	private static int FixNiagaraSystemMergeParent_ParamsSize;

	private static bool FixNiagaraSystemMergeParent_NiagaraSystem_IsValid;

	private static FFieldAddress FixNiagaraSystemMergeParent_NiagaraSystem_PropertyAddress;

	private static int FixNiagaraSystemMergeParent_NiagaraSystem_Offset;

	private static bool FixNiagaraSystemBadVMID_IsValid;

	private static IntPtr FixNiagaraSystemBadVMID_FunctionAddress;

	private static int FixNiagaraSystemBadVMID_ParamsSize;

	private static bool FixNiagaraSystemBadVMID_NiagaraSystem_IsValid;

	private static FFieldAddress FixNiagaraSystemBadVMID_NiagaraSystem_PropertyAddress;

	private static int FixNiagaraSystemBadVMID_NiagaraSystem_Offset;

	private static bool FixAllNiagaraSystemMergeParent_IsValid;

	private static IntPtr FixAllNiagaraSystemMergeParent_FunctionAddress;

	private static int FixAllNiagaraSystemMergeParent_ParamsSize;

	private static bool FixAllNiagaraSystemMergeParent_InAssetDataList_IsValid;

	private static FFieldAddress FixAllNiagaraSystemMergeParent_InAssetDataList_PropertyAddress;

	private static int FixAllNiagaraSystemMergeParent_InAssetDataList_Offset;

	private static bool FixAllNiagaraSystemBadVMID_IsValid;

	private static IntPtr FixAllNiagaraSystemBadVMID_FunctionAddress;

	private static int FixAllNiagaraSystemBadVMID_ParamsSize;

	private static bool FixAllNiagaraSystemBadVMID_InAssetDataList_IsValid;

	private static FFieldAddress FixAllNiagaraSystemBadVMID_InAssetDataList_PropertyAddress;

	private static int FixAllNiagaraSystemBadVMID_InAssetDataList_Offset;

	private static bool CreateTFXCardMeshCompInUnitBP_IsValid;

	private static IntPtr CreateTFXCardMeshCompInUnitBP_FunctionAddress;

	private static int CreateTFXCardMeshCompInUnitBP_ParamsSize;

	private static bool CreateTFXCardMeshCompInUnitBP_TargetBlueprint_IsValid;

	private static FFieldAddress CreateTFXCardMeshCompInUnitBP_TargetBlueprint_PropertyAddress;

	private static int CreateTFXCardMeshCompInUnitBP_TargetBlueprint_Offset;

	private static bool CreateTFXCardMeshCompInUnitBP_GenCardsParameterList_IsValid;

	private static FFieldAddress CreateTFXCardMeshCompInUnitBP_GenCardsParameterList_PropertyAddress;

	private static int CreateTFXCardMeshCompInUnitBP_GenCardsParameterList_Offset;

	private static bool CreateTFXCardMeshCompInUnitBP_RecreateResource_IsValid;

	private static FFieldAddress CreateTFXCardMeshCompInUnitBP_RecreateResource_PropertyAddress;

	private static int CreateTFXCardMeshCompInUnitBP_RecreateResource_Offset;

	private static bool CreateTFXCardMeshCompInUnitBP_ReturnValue_IsValid;

	private static FFieldAddress CreateTFXCardMeshCompInUnitBP_ReturnValue_PropertyAddress;

	private static int CreateTFXCardMeshCompInUnitBP_ReturnValue_Offset;

	private static bool CreateBossRushGraphAsset_IsValid;

	private static IntPtr CreateBossRushGraphAsset_FunctionAddress;

	private static int CreateBossRushGraphAsset_ParamsSize;

	private static bool CreateBossRushGraphAsset_InPackagePath_IsValid;

	private static FFieldAddress CreateBossRushGraphAsset_InPackagePath_PropertyAddress;

	private static int CreateBossRushGraphAsset_InPackagePath_Offset;

	private static bool CreateBossRushGraphAsset_InAssetName_IsValid;

	private static FFieldAddress CreateBossRushGraphAsset_InAssetName_PropertyAddress;

	private static int CreateBossRushGraphAsset_InAssetName_Offset;

	private static bool CreateBossRushGraphAsset_InAssetClass_IsValid;

	private static FFieldAddress CreateBossRushGraphAsset_InAssetClass_PropertyAddress;

	private static int CreateBossRushGraphAsset_InAssetClass_Offset;

	private static bool CreateBossRushGraphAsset_ReturnValue_IsValid;

	private static FFieldAddress CreateBossRushGraphAsset_ReturnValue_PropertyAddress;

	private static int CreateBossRushGraphAsset_ReturnValue_Offset;

	private static bool CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_IsValid;

	private static IntPtr CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress;

	private static int CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ParamsSize;

	private static bool CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_OutputInfo_IsValid;

	private static FFieldAddress CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_OutputInfo_PropertyAddress;

	private static int CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_OutputInfo_Offset;

	private static bool CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ReturnValue_IsValid;

	private static FFieldAddress CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ReturnValue_PropertyAddress;

	private static int CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ReturnValue_Offset;

	private static bool CloseAllEditorsForAsset_IsValid;

	private static IntPtr CloseAllEditorsForAsset_FunctionAddress;

	private static int CloseAllEditorsForAsset_ParamsSize;

	private static bool CloseAllEditorsForAsset_Asset_IsValid;

	private static FFieldAddress CloseAllEditorsForAsset_Asset_PropertyAddress;

	private static int CloseAllEditorsForAsset_Asset_Offset;

	private static bool CloseAllEditorsForAsset_ReturnValue_IsValid;

	private static FFieldAddress CloseAllEditorsForAsset_ReturnValue_PropertyAddress;

	private static int CloseAllEditorsForAsset_ReturnValue_Offset;

	private static bool AddCalliopeNode_IsValid;

	private static IntPtr AddCalliopeNode_FunctionAddress;

	private static int AddCalliopeNode_ParamsSize;

	private static bool AddCalliopeNode_InAsset_IsValid;

	private static FFieldAddress AddCalliopeNode_InAsset_PropertyAddress;

	private static int AddCalliopeNode_InAsset_Offset;

	private static bool AddCalliopeNode_InNodeClass_IsValid;

	private static FFieldAddress AddCalliopeNode_InNodeClass_PropertyAddress;

	private static int AddCalliopeNode_InNodeClass_Offset;

	private static bool AddCalliopeNode_InLocation_IsValid;

	private static FFieldAddress AddCalliopeNode_InLocation_PropertyAddress;

	private static int AddCalliopeNode_InLocation_Offset;

	private static bool AddCalliopeNode_FromNode_IsValid;

	private static FFieldAddress AddCalliopeNode_FromNode_PropertyAddress;

	private static int AddCalliopeNode_FromNode_Offset;

	private static bool AddCalliopeNode_FromPinNameStr_IsValid;

	private static FFieldAddress AddCalliopeNode_FromPinNameStr_PropertyAddress;

	private static int AddCalliopeNode_FromPinNameStr_Offset;

	private static bool AddCalliopeNode_ReturnValue_IsValid;

	private static FFieldAddress AddCalliopeNode_ReturnValue_PropertyAddress;

	private static int AddCalliopeNode_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:UnloadPackagesByObjects")]
	public unsafe static void UnloadPackagesByObjects(List<UObject> Objects)
	{
		if (!UnloadPackagesByObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:UnloadPackagesByObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnloadPackagesByObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnloadPackagesByObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, UnloadPackagesByObjects_Objects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, UnloadPackagesByObjects_Objects_Offset), Objects);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnloadPackagesByObjects_FunctionAddress, intPtr, UnloadPackagesByObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UnloadPackagesByObjects_Objects_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:UnloadPackagesByAssetDataList")]
	public unsafe static void UnloadPackagesByAssetDataList(List<FAssetData> InAssetDataList)
	{
		if (!UnloadPackagesByAssetDataList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:UnloadPackagesByAssetDataList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UnloadPackagesByAssetDataList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UnloadPackagesByAssetDataList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAssetData>(1, UnloadPackagesByAssetDataList_InAssetDataList_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).ToNative(IntPtr.Add(intPtr, UnloadPackagesByAssetDataList_InAssetDataList_Offset), InAssetDataList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UnloadPackagesByAssetDataList_FunctionAddress, intPtr, UnloadPackagesByAssetDataList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UnloadPackagesByAssetDataList_InAssetDataList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:SetSceneComponentVelocity")]
	public unsafe static void SetSceneComponentVelocity(USceneComponent SceneComponent, FVector NewVelocity)
	{
		if (!SetSceneComponentVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:SetSceneComponentVelocity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSceneComponentVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSceneComponentVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SetSceneComponentVelocity_SceneComponent_Offset), 0, SetSceneComponentVelocity_SceneComponent_PropertyAddress.Address, SceneComponent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetSceneComponentVelocity_NewVelocity_Offset), 0, SetSceneComponentVelocity_NewVelocity_PropertyAddress.Address, NewVelocity);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSceneComponentVelocity_FunctionAddress, intPtr, SetSceneComponentVelocity_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:SelectAssetsToArrayString")]
	public unsafe static string SelectAssetsToArrayString(bool bContainPath)
	{
		if (!SelectAssetsToArrayString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:SelectAssetsToArrayString");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectAssetsToArrayString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectAssetsToArrayString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectAssetsToArrayString_bContainPath_Offset), 0, SelectAssetsToArrayString_bContainPath_PropertyAddress.Address, bContainPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectAssetsToArrayString_FunctionAddress, intPtr, SelectAssetsToArrayString_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, SelectAssetsToArrayString_ReturnValue_Offset), 0, SelectAssetsToArrayString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SelectAssetsToArrayString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:SelectAssets")]
	public unsafe static void SelectAssets(List<UObject> ObjectsToSelect)
	{
		if (!SelectAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:SelectAssets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SelectAssets_ObjectsToSelect_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SelectAssets_ObjectsToSelect_Offset), ObjectsToSelect);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SelectAssets_FunctionAddress, intPtr, SelectAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SelectAssets_ObjectsToSelect_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:SearchTableKeyWord")]
	public unsafe static List<string> SearchTableKeyWord(string SearchText)
	{
		if (!SearchTableKeyWord_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:SearchTableKeyWord");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SearchTableKeyWord_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SearchTableKeyWord_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SearchTableKeyWord_SearchText_Offset), 0, SearchTableKeyWord_SearchText_PropertyAddress.Address, SearchText);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SearchTableKeyWord_FunctionAddress, intPtr, SearchTableKeyWord_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SearchTableKeyWord_SearchText_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, SearchTableKeyWord_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, SearchTableKeyWord_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(SearchTableKeyWord_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:SaveAssets")]
	public unsafe static void SaveAssets(List<UObject> InAssets)
	{
		if (!SaveAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:SaveAssets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SaveAssets_InAssets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SaveAssets_InAssets_Offset), InAssets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveAssets_FunctionAddress, intPtr, SaveAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveAssets_InAssets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:SaveAsset")]
	public unsafe static void SaveAsset(UObject InAsset)
	{
		if (!SaveAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:SaveAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SaveAsset_InAsset_Offset), 0, SaveAsset_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveAsset_FunctionAddress, intPtr, SaveAsset_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:ReloadAssets")]
	public unsafe static void ReloadAssets(List<UObject> AssetPaths)
	{
		if (!ReloadAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:ReloadAssets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReloadAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReloadAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, ReloadAssets_AssetPaths_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, ReloadAssets_AssetPaths_Offset), AssetPaths);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReloadAssets_FunctionAddress, intPtr, ReloadAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReloadAssets_AssetPaths_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:RecursiveGetDependencies")]
	public unsafe static void RecursiveGetDependencies(FName PackageName, out HashSet<FName> AllDependencies, out HashSet<string> OutExternalObjectsPaths)
	{
		if (!RecursiveGetDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:RecursiveGetDependencies");
			AllDependencies = null;
			OutExternalObjectsPaths = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RecursiveGetDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RecursiveGetDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RecursiveGetDependencies_PackageName_Offset), 0, RecursiveGetDependencies_PackageName_PropertyAddress.Address, PackageName);
		NativeReflection.InitializeValue_InContainer(RecursiveGetDependencies_AllDependencies_PropertyAddress.Address, intPtr);
		NativeReflection.InitializeValue_InContainer(RecursiveGetDependencies_OutExternalObjectsPaths_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RecursiveGetDependencies_FunctionAddress, intPtr, RecursiveGetDependencies_ParamsSize);
		AllDependencies = new TSetCopyMarshaler<FName>(1, RecursiveGetDependencies_AllDependencies_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, RecursiveGetDependencies_AllDependencies_Offset));
		NativeReflection.DestroyValue_InContainer(RecursiveGetDependencies_AllDependencies_PropertyAddress.Address, intPtr);
		OutExternalObjectsPaths = new TSetCopyMarshaler<string>(1, RecursiveGetDependencies_OutExternalObjectsPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, RecursiveGetDependencies_OutExternalObjectsPaths_Offset));
		NativeReflection.DestroyValue_InContainer(RecursiveGetDependencies_OutExternalObjectsPaths_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:PerformMigratePackages")]
	public unsafe static HashSet<FName> PerformMigratePackages(List<FName> PackageNamesToMigrate)
	{
		if (!PerformMigratePackages_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:PerformMigratePackages");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PerformMigratePackages_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PerformMigratePackages_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, PerformMigratePackages_PackageNamesToMigrate_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, PerformMigratePackages_PackageNamesToMigrate_Offset), PackageNamesToMigrate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PerformMigratePackages_FunctionAddress, intPtr, PerformMigratePackages_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PerformMigratePackages_PackageNamesToMigrate_PropertyAddress.Address, intPtr);
		HashSet<FName> result = new TSetCopyMarshaler<FName>(1, PerformMigratePackages_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, PerformMigratePackages_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(PerformMigratePackages_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:OpenAsset")]
	public unsafe static void OpenAsset(UObject InAsset)
	{
		if (!OpenAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:OpenAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OpenAsset_InAsset_Offset), 0, OpenAsset_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenAsset_FunctionAddress, intPtr, OpenAsset_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:MarkDirtyObjects")]
	public unsafe static void MarkDirtyObjects(List<UObject> Objs)
	{
		if (!MarkDirtyObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:MarkDirtyObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkDirtyObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkDirtyObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, MarkDirtyObjects_Objs_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, MarkDirtyObjects_Objs_Offset), Objs);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkDirtyObjects_FunctionAddress, intPtr, MarkDirtyObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MarkDirtyObjects_Objs_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:MakeAssetWritableAndSave")]
	public unsafe static bool MakeAssetWritableAndSave(UObject InObject)
	{
		if (!MakeAssetWritableAndSave_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:MakeAssetWritableAndSave");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeAssetWritableAndSave_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeAssetWritableAndSave_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, MakeAssetWritableAndSave_InObject_Offset), 0, MakeAssetWritableAndSave_InObject_PropertyAddress.Address, InObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeAssetWritableAndSave_FunctionAddress, intPtr, MakeAssetWritableAndSave_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MakeAssetWritableAndSave_ReturnValue_Offset), 0, MakeAssetWritableAndSave_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:IsSavingPackageOrGC")]
	public unsafe static bool IsSavingPackageOrGC()
	{
		if (!IsSavingPackageOrGC_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:IsSavingPackageOrGC");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsSavingPackageOrGC_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsSavingPackageOrGC_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsSavingPackageOrGC_FunctionAddress, intPtr, IsSavingPackageOrGC_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsSavingPackageOrGC_ReturnValue_Offset), 0, IsSavingPackageOrGC_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:IsNiagaraSystemNeedMergeEmitter")]
	public unsafe static bool IsNiagaraSystemNeedMergeEmitter(UNiagaraSystem NiagaraSystem)
	{
		if (!IsNiagaraSystemNeedMergeEmitter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:IsNiagaraSystemNeedMergeEmitter");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNiagaraSystemNeedMergeEmitter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNiagaraSystemNeedMergeEmitter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, IsNiagaraSystemNeedMergeEmitter_NiagaraSystem_Offset), 0, IsNiagaraSystemNeedMergeEmitter_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsNiagaraSystemNeedMergeEmitter_FunctionAddress, intPtr, IsNiagaraSystemNeedMergeEmitter_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNiagaraSystemNeedMergeEmitter_ReturnValue_Offset), 0, IsNiagaraSystemNeedMergeEmitter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:IsNiagaraSystemBadVMID")]
	public unsafe static bool IsNiagaraSystemBadVMID(UNiagaraSystem NiagaraSystem)
	{
		if (!IsNiagaraSystemBadVMID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:IsNiagaraSystemBadVMID");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNiagaraSystemBadVMID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNiagaraSystemBadVMID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, IsNiagaraSystemBadVMID_NiagaraSystem_Offset), 0, IsNiagaraSystemBadVMID_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsNiagaraSystemBadVMID_FunctionAddress, intPtr, IsNiagaraSystemBadVMID_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNiagaraSystemBadVMID_ReturnValue_Offset), 0, IsNiagaraSystemBadVMID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:GetBlueprintTressFXComponentMaterials")]
	public unsafe static List<UMaterialInterface> GetBlueprintTressFXComponentMaterials(UBlueprint TargetBlueprint)
	{
		if (!GetBlueprintTressFXComponentMaterials_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:GetBlueprintTressFXComponentMaterials");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlueprintTressFXComponentMaterials_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlueprintTressFXComponentMaterials_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, GetBlueprintTressFXComponentMaterials_TargetBlueprint_Offset), 0, GetBlueprintTressFXComponentMaterials_TargetBlueprint_PropertyAddress.Address, TargetBlueprint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlueprintTressFXComponentMaterials_FunctionAddress, intPtr, GetBlueprintTressFXComponentMaterials_ParamsSize);
		List<UMaterialInterface> result = new TArrayCopyMarshaler<UMaterialInterface>(1, GetBlueprintTressFXComponentMaterials_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.FromNative, CachedMarshalingDelegates<UMaterialInterface, UObjectMarshaler<UMaterialInterface>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBlueprintTressFXComponentMaterials_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBlueprintTressFXComponentMaterials_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:GetAssetsByClassInFolder")]
	public unsafe static void GetAssetsByClassInFolder(out List<FAssetData> OutAssetData, string Folder, FName ClassName, bool bRecursive = false, bool bSearchSubClasses = false, bool bIncludeOnlyOnDiskAssets = true)
	{
		if (!GetAssetsByClassInFolder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:GetAssetsByClassInFolder");
			OutAssetData = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsByClassInFolder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsByClassInFolder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByClassInFolder_Folder_Offset), 0, GetAssetsByClassInFolder_Folder_PropertyAddress.Address, Folder);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAssetsByClassInFolder_ClassName_Offset), 0, GetAssetsByClassInFolder_ClassName_PropertyAddress.Address, ClassName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByClassInFolder_bRecursive_Offset), 0, GetAssetsByClassInFolder_bRecursive_PropertyAddress.Address, bRecursive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByClassInFolder_bSearchSubClasses_Offset), 0, GetAssetsByClassInFolder_bSearchSubClasses_PropertyAddress.Address, bSearchSubClasses);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetsByClassInFolder_bIncludeOnlyOnDiskAssets_Offset), 0, GetAssetsByClassInFolder_bIncludeOnlyOnDiskAssets_PropertyAddress.Address, bIncludeOnlyOnDiskAssets);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetsByClassInFolder_FunctionAddress, intPtr, GetAssetsByClassInFolder_ParamsSize);
		OutAssetData = new TArrayCopyMarshaler<FAssetData>(1, GetAssetsByClassInFolder_OutAssetData_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).FromNative(IntPtr.Add(intPtr, GetAssetsByClassInFolder_OutAssetData_Offset));
		NativeReflection.DestroyValue_InContainer(GetAssetsByClassInFolder_OutAssetData_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetAssetsByClassInFolder_Folder_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:GetAllRecursiveFoldersWithKeyword")]
	public unsafe static List<string> GetAllRecursiveFoldersWithKeyword(string InRootFolder, string InKeyword)
	{
		if (!GetAllRecursiveFoldersWithKeyword_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:GetAllRecursiveFoldersWithKeyword");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllRecursiveFoldersWithKeyword_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllRecursiveFoldersWithKeyword_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAllRecursiveFoldersWithKeyword_InRootFolder_Offset), 0, GetAllRecursiveFoldersWithKeyword_InRootFolder_PropertyAddress.Address, InRootFolder);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAllRecursiveFoldersWithKeyword_InKeyword_Offset), 0, GetAllRecursiveFoldersWithKeyword_InKeyword_PropertyAddress.Address, InKeyword);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllRecursiveFoldersWithKeyword_FunctionAddress, intPtr, GetAllRecursiveFoldersWithKeyword_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllRecursiveFoldersWithKeyword_InRootFolder_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GetAllRecursiveFoldersWithKeyword_InKeyword_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetAllRecursiveFoldersWithKeyword_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllRecursiveFoldersWithKeyword_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllRecursiveFoldersWithKeyword_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:FixSelectedNiagaraSystemMergeParent")]
	public unsafe static void FixSelectedNiagaraSystemMergeParent()
	{
		if (!FixSelectedNiagaraSystemMergeParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:FixSelectedNiagaraSystemMergeParent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixSelectedNiagaraSystemMergeParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixSelectedNiagaraSystemMergeParent_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: FixSelectedNiagaraSystemMergeParent_FunctionAddress, argsSize: FixSelectedNiagaraSystemMergeParent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:FixSelectedNiagaraSystemBadVMID")]
	public unsafe static void FixSelectedNiagaraSystemBadVMID()
	{
		if (!FixSelectedNiagaraSystemBadVMID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:FixSelectedNiagaraSystemBadVMID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixSelectedNiagaraSystemBadVMID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixSelectedNiagaraSystemBadVMID_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: FixSelectedNiagaraSystemBadVMID_FunctionAddress, argsSize: FixSelectedNiagaraSystemBadVMID_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:FixNiagaraSystemMergeParent")]
	public unsafe static void FixNiagaraSystemMergeParent(UNiagaraSystem NiagaraSystem)
	{
		if (!FixNiagaraSystemMergeParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:FixNiagaraSystemMergeParent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixNiagaraSystemMergeParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixNiagaraSystemMergeParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, FixNiagaraSystemMergeParent_NiagaraSystem_Offset), 0, FixNiagaraSystemMergeParent_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FixNiagaraSystemMergeParent_FunctionAddress, intPtr, FixNiagaraSystemMergeParent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:FixNiagaraSystemBadVMID")]
	public unsafe static void FixNiagaraSystemBadVMID(UNiagaraSystem NiagaraSystem)
	{
		if (!FixNiagaraSystemBadVMID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:FixNiagaraSystemBadVMID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixNiagaraSystemBadVMID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixNiagaraSystemBadVMID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(intPtr, FixNiagaraSystemBadVMID_NiagaraSystem_Offset), 0, FixNiagaraSystemBadVMID_NiagaraSystem_PropertyAddress.Address, NiagaraSystem);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FixNiagaraSystemBadVMID_FunctionAddress, intPtr, FixNiagaraSystemBadVMID_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:FixAllNiagaraSystemMergeParent")]
	public unsafe static void FixAllNiagaraSystemMergeParent(List<FAssetData> InAssetDataList)
	{
		if (!FixAllNiagaraSystemMergeParent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:FixAllNiagaraSystemMergeParent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixAllNiagaraSystemMergeParent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixAllNiagaraSystemMergeParent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAssetData>(1, FixAllNiagaraSystemMergeParent_InAssetDataList_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).ToNative(IntPtr.Add(intPtr, FixAllNiagaraSystemMergeParent_InAssetDataList_Offset), InAssetDataList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FixAllNiagaraSystemMergeParent_FunctionAddress, intPtr, FixAllNiagaraSystemMergeParent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FixAllNiagaraSystemMergeParent_InAssetDataList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:FixAllNiagaraSystemBadVMID")]
	public unsafe static void FixAllNiagaraSystemBadVMID(List<FAssetData> InAssetDataList)
	{
		if (!FixAllNiagaraSystemBadVMID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:FixAllNiagaraSystemBadVMID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FixAllNiagaraSystemBadVMID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FixAllNiagaraSystemBadVMID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FAssetData>(1, FixAllNiagaraSystemBadVMID_InAssetDataList_PropertyAddress, CachedMarshalingDelegates<FAssetData, FAssetData>.FromNative, CachedMarshalingDelegates<FAssetData, FAssetData>.ToNative).ToNative(IntPtr.Add(intPtr, FixAllNiagaraSystemBadVMID_InAssetDataList_Offset), InAssetDataList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FixAllNiagaraSystemBadVMID_FunctionAddress, intPtr, FixAllNiagaraSystemBadVMID_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FixAllNiagaraSystemBadVMID_InAssetDataList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:CreateTFXCardMeshCompInUnitBP")]
	public unsafe static int CreateTFXCardMeshCompInUnitBP(UBlueprint TargetBlueprint, UObject GenCardsParameterList, bool RecreateResource = false)
	{
		if (!CreateTFXCardMeshCompInUnitBP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:CreateTFXCardMeshCompInUnitBP");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateTFXCardMeshCompInUnitBP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateTFXCardMeshCompInUnitBP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UBlueprint>.ToNative(IntPtr.Add(intPtr, CreateTFXCardMeshCompInUnitBP_TargetBlueprint_Offset), 0, CreateTFXCardMeshCompInUnitBP_TargetBlueprint_PropertyAddress.Address, TargetBlueprint);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateTFXCardMeshCompInUnitBP_GenCardsParameterList_Offset), 0, CreateTFXCardMeshCompInUnitBP_GenCardsParameterList_PropertyAddress.Address, GenCardsParameterList);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateTFXCardMeshCompInUnitBP_RecreateResource_Offset), 0, CreateTFXCardMeshCompInUnitBP_RecreateResource_PropertyAddress.Address, RecreateResource);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateTFXCardMeshCompInUnitBP_FunctionAddress, intPtr, CreateTFXCardMeshCompInUnitBP_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CreateTFXCardMeshCompInUnitBP_ReturnValue_Offset), 0, CreateTFXCardMeshCompInUnitBP_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:CreateBossRushGraphAsset")]
	public unsafe static UCalliopeAsset CreateBossRushGraphAsset(string InPackagePath, string InAssetName, TSubclassOf<UObject> InAssetClass)
	{
		if (!CreateBossRushGraphAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:CreateBossRushGraphAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateBossRushGraphAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateBossRushGraphAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateBossRushGraphAsset_InPackagePath_Offset), 0, CreateBossRushGraphAsset_InPackagePath_PropertyAddress.Address, InPackagePath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateBossRushGraphAsset_InAssetName_Offset), 0, CreateBossRushGraphAsset_InAssetName_PropertyAddress.Address, InAssetName);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateBossRushGraphAsset_InAssetClass_Offset), 0, CreateBossRushGraphAsset_InAssetClass_PropertyAddress.Address, InAssetClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateBossRushGraphAsset_FunctionAddress, intPtr, CreateBossRushGraphAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateBossRushGraphAsset_InPackagePath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateBossRushGraphAsset_InAssetName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UCalliopeAsset>.FromNative(IntPtr.Add(intPtr, CreateBossRushGraphAsset_ReturnValue_Offset), 0, CreateBossRushGraphAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP")]
	public unsafe static bool CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP(out string OutputInfo)
	{
		if (!CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP");
			OutputInfo = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress, intPtr, CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ParamsSize);
		OutputInfo = FStringMarshaler.FromNative(IntPtr.Add(intPtr, CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_OutputInfo_Offset), 0, CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_OutputInfo_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_OutputInfo_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ReturnValue_Offset), 0, CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:CloseAllEditorsForAsset")]
	public unsafe static int CloseAllEditorsForAsset(UObject Asset)
	{
		if (!CloseAllEditorsForAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:CloseAllEditorsForAsset");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CloseAllEditorsForAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CloseAllEditorsForAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CloseAllEditorsForAsset_Asset_Offset), 0, CloseAllEditorsForAsset_Asset_PropertyAddress.Address, Asset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CloseAllEditorsForAsset_FunctionAddress, intPtr, CloseAllEditorsForAsset_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, CloseAllEditorsForAsset_ReturnValue_Offset), 0, CloseAllEditorsForAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorAssetLibrary:AddCalliopeNode")]
	public unsafe static UCalliopeNode AddCalliopeNode(UCalliopeAsset InAsset, TSubclassOf<UObject> InNodeClass, FVector2D InLocation, UCalliopeNode FromNode, string FromPinNameStr)
	{
		if (!AddCalliopeNode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorAssetLibrary:AddCalliopeNode");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCalliopeNode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCalliopeNode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCalliopeAsset>.ToNative(IntPtr.Add(intPtr, AddCalliopeNode_InAsset_Offset), 0, AddCalliopeNode_InAsset_PropertyAddress.Address, InAsset);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddCalliopeNode_InNodeClass_Offset), 0, AddCalliopeNode_InNodeClass_PropertyAddress.Address, InNodeClass);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, AddCalliopeNode_InLocation_Offset), 0, AddCalliopeNode_InLocation_PropertyAddress.Address, InLocation);
		UObjectMarshaler<UCalliopeNode>.ToNative(IntPtr.Add(intPtr, AddCalliopeNode_FromNode_Offset), 0, AddCalliopeNode_FromNode_PropertyAddress.Address, FromNode);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddCalliopeNode_FromPinNameStr_Offset), 0, AddCalliopeNode_FromPinNameStr_PropertyAddress.Address, FromPinNameStr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddCalliopeNode_FunctionAddress, intPtr, AddCalliopeNode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddCalliopeNode_FromPinNameStr_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UCalliopeNode>.FromNative(IntPtr.Add(intPtr, AddCalliopeNode_ReturnValue_Offset), 0, AddCalliopeNode_ReturnValue_PropertyAddress.Address);
	}

	static UGSEditorAssetLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorAssetLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorAssetLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorAssetLibrary");
		UnloadPackagesByObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnloadPackagesByObjects");
		UnloadPackagesByObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(UnloadPackagesByObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnloadPackagesByObjects_Objects_PropertyAddress, UnloadPackagesByObjects_FunctionAddress, "Objects");
		UnloadPackagesByObjects_Objects_Offset = NativeReflectionCached.GetPropertyOffset(UnloadPackagesByObjects_FunctionAddress, "Objects");
		UnloadPackagesByObjects_Objects_IsValid = NativeReflectionCached.ValidatePropertyClass(UnloadPackagesByObjects_FunctionAddress, "Objects", Classes.FArrayProperty);
		UnloadPackagesByObjects_IsValid = UnloadPackagesByObjects_FunctionAddress != IntPtr.Zero && UnloadPackagesByObjects_Objects_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:UnloadPackagesByObjects", UnloadPackagesByObjects_IsValid);
		UnloadPackagesByAssetDataList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UnloadPackagesByAssetDataList");
		UnloadPackagesByAssetDataList_ParamsSize = NativeReflection.GetFunctionParamsSize(UnloadPackagesByAssetDataList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UnloadPackagesByAssetDataList_InAssetDataList_PropertyAddress, UnloadPackagesByAssetDataList_FunctionAddress, "InAssetDataList");
		UnloadPackagesByAssetDataList_InAssetDataList_Offset = NativeReflectionCached.GetPropertyOffset(UnloadPackagesByAssetDataList_FunctionAddress, "InAssetDataList");
		UnloadPackagesByAssetDataList_InAssetDataList_IsValid = NativeReflectionCached.ValidatePropertyClass(UnloadPackagesByAssetDataList_FunctionAddress, "InAssetDataList", Classes.FArrayProperty);
		UnloadPackagesByAssetDataList_IsValid = UnloadPackagesByAssetDataList_FunctionAddress != IntPtr.Zero && UnloadPackagesByAssetDataList_InAssetDataList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:UnloadPackagesByAssetDataList", UnloadPackagesByAssetDataList_IsValid);
		SetSceneComponentVelocity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSceneComponentVelocity");
		SetSceneComponentVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSceneComponentVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSceneComponentVelocity_SceneComponent_PropertyAddress, SetSceneComponentVelocity_FunctionAddress, "SceneComponent");
		SetSceneComponentVelocity_SceneComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneComponentVelocity_FunctionAddress, "SceneComponent");
		SetSceneComponentVelocity_SceneComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneComponentVelocity_FunctionAddress, "SceneComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSceneComponentVelocity_NewVelocity_PropertyAddress, SetSceneComponentVelocity_FunctionAddress, "NewVelocity");
		SetSceneComponentVelocity_NewVelocity_Offset = NativeReflectionCached.GetPropertyOffset(SetSceneComponentVelocity_FunctionAddress, "NewVelocity");
		SetSceneComponentVelocity_NewVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSceneComponentVelocity_FunctionAddress, "NewVelocity", Classes.FStructProperty);
		SetSceneComponentVelocity_IsValid = SetSceneComponentVelocity_FunctionAddress != IntPtr.Zero && SetSceneComponentVelocity_SceneComponent_IsValid && SetSceneComponentVelocity_NewVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:SetSceneComponentVelocity", SetSceneComponentVelocity_IsValid);
		SelectAssetsToArrayString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectAssetsToArrayString");
		SelectAssetsToArrayString_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectAssetsToArrayString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectAssetsToArrayString_bContainPath_PropertyAddress, SelectAssetsToArrayString_FunctionAddress, "bContainPath");
		SelectAssetsToArrayString_bContainPath_Offset = NativeReflectionCached.GetPropertyOffset(SelectAssetsToArrayString_FunctionAddress, "bContainPath");
		SelectAssetsToArrayString_bContainPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectAssetsToArrayString_FunctionAddress, "bContainPath", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectAssetsToArrayString_ReturnValue_PropertyAddress, SelectAssetsToArrayString_FunctionAddress, "ReturnValue");
		SelectAssetsToArrayString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SelectAssetsToArrayString_FunctionAddress, "ReturnValue");
		SelectAssetsToArrayString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectAssetsToArrayString_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		SelectAssetsToArrayString_IsValid = SelectAssetsToArrayString_FunctionAddress != IntPtr.Zero && SelectAssetsToArrayString_bContainPath_IsValid && SelectAssetsToArrayString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:SelectAssetsToArrayString", SelectAssetsToArrayString_IsValid);
		SelectAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SelectAssets");
		SelectAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectAssets_ObjectsToSelect_PropertyAddress, SelectAssets_FunctionAddress, "ObjectsToSelect");
		SelectAssets_ObjectsToSelect_Offset = NativeReflectionCached.GetPropertyOffset(SelectAssets_FunctionAddress, "ObjectsToSelect");
		SelectAssets_ObjectsToSelect_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectAssets_FunctionAddress, "ObjectsToSelect", Classes.FArrayProperty);
		SelectAssets_IsValid = SelectAssets_FunctionAddress != IntPtr.Zero && SelectAssets_ObjectsToSelect_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:SelectAssets", SelectAssets_IsValid);
		SearchTableKeyWord_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SearchTableKeyWord");
		SearchTableKeyWord_ParamsSize = NativeReflection.GetFunctionParamsSize(SearchTableKeyWord_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SearchTableKeyWord_SearchText_PropertyAddress, SearchTableKeyWord_FunctionAddress, "SearchText");
		SearchTableKeyWord_SearchText_Offset = NativeReflectionCached.GetPropertyOffset(SearchTableKeyWord_FunctionAddress, "SearchText");
		SearchTableKeyWord_SearchText_IsValid = NativeReflectionCached.ValidatePropertyClass(SearchTableKeyWord_FunctionAddress, "SearchText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SearchTableKeyWord_ReturnValue_PropertyAddress, SearchTableKeyWord_FunctionAddress, "ReturnValue");
		SearchTableKeyWord_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SearchTableKeyWord_FunctionAddress, "ReturnValue");
		SearchTableKeyWord_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SearchTableKeyWord_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		SearchTableKeyWord_IsValid = SearchTableKeyWord_FunctionAddress != IntPtr.Zero && SearchTableKeyWord_SearchText_IsValid && SearchTableKeyWord_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:SearchTableKeyWord", SearchTableKeyWord_IsValid);
		SaveAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveAssets");
		SaveAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveAssets_InAssets_PropertyAddress, SaveAssets_FunctionAddress, "InAssets");
		SaveAssets_InAssets_Offset = NativeReflectionCached.GetPropertyOffset(SaveAssets_FunctionAddress, "InAssets");
		SaveAssets_InAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAssets_FunctionAddress, "InAssets", Classes.FArrayProperty);
		SaveAssets_IsValid = SaveAssets_FunctionAddress != IntPtr.Zero && SaveAssets_InAssets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:SaveAssets", SaveAssets_IsValid);
		SaveAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveAsset");
		SaveAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveAsset_InAsset_PropertyAddress, SaveAsset_FunctionAddress, "InAsset");
		SaveAsset_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(SaveAsset_FunctionAddress, "InAsset");
		SaveAsset_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAsset_FunctionAddress, "InAsset", Classes.FObjectProperty);
		SaveAsset_IsValid = SaveAsset_FunctionAddress != IntPtr.Zero && SaveAsset_InAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:SaveAsset", SaveAsset_IsValid);
		ReloadAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReloadAssets");
		ReloadAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(ReloadAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReloadAssets_AssetPaths_PropertyAddress, ReloadAssets_FunctionAddress, "AssetPaths");
		ReloadAssets_AssetPaths_Offset = NativeReflectionCached.GetPropertyOffset(ReloadAssets_FunctionAddress, "AssetPaths");
		ReloadAssets_AssetPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(ReloadAssets_FunctionAddress, "AssetPaths", Classes.FArrayProperty);
		ReloadAssets_IsValid = ReloadAssets_FunctionAddress != IntPtr.Zero && ReloadAssets_AssetPaths_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:ReloadAssets", ReloadAssets_IsValid);
		RecursiveGetDependencies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RecursiveGetDependencies");
		RecursiveGetDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(RecursiveGetDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RecursiveGetDependencies_PackageName_PropertyAddress, RecursiveGetDependencies_FunctionAddress, "PackageName");
		RecursiveGetDependencies_PackageName_Offset = NativeReflectionCached.GetPropertyOffset(RecursiveGetDependencies_FunctionAddress, "PackageName");
		RecursiveGetDependencies_PackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(RecursiveGetDependencies_FunctionAddress, "PackageName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref RecursiveGetDependencies_AllDependencies_PropertyAddress, RecursiveGetDependencies_FunctionAddress, "AllDependencies");
		RecursiveGetDependencies_AllDependencies_Offset = NativeReflectionCached.GetPropertyOffset(RecursiveGetDependencies_FunctionAddress, "AllDependencies");
		RecursiveGetDependencies_AllDependencies_IsValid = NativeReflectionCached.ValidatePropertyClass(RecursiveGetDependencies_FunctionAddress, "AllDependencies", Classes.FSetProperty);
		NativeReflectionCached.GetPropertyRef(ref RecursiveGetDependencies_OutExternalObjectsPaths_PropertyAddress, RecursiveGetDependencies_FunctionAddress, "OutExternalObjectsPaths");
		RecursiveGetDependencies_OutExternalObjectsPaths_Offset = NativeReflectionCached.GetPropertyOffset(RecursiveGetDependencies_FunctionAddress, "OutExternalObjectsPaths");
		RecursiveGetDependencies_OutExternalObjectsPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(RecursiveGetDependencies_FunctionAddress, "OutExternalObjectsPaths", Classes.FSetProperty);
		RecursiveGetDependencies_IsValid = RecursiveGetDependencies_FunctionAddress != IntPtr.Zero && RecursiveGetDependencies_PackageName_IsValid && RecursiveGetDependencies_AllDependencies_IsValid && RecursiveGetDependencies_OutExternalObjectsPaths_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:RecursiveGetDependencies", RecursiveGetDependencies_IsValid);
		PerformMigratePackages_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PerformMigratePackages");
		PerformMigratePackages_ParamsSize = NativeReflection.GetFunctionParamsSize(PerformMigratePackages_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PerformMigratePackages_PackageNamesToMigrate_PropertyAddress, PerformMigratePackages_FunctionAddress, "PackageNamesToMigrate");
		PerformMigratePackages_PackageNamesToMigrate_Offset = NativeReflectionCached.GetPropertyOffset(PerformMigratePackages_FunctionAddress, "PackageNamesToMigrate");
		PerformMigratePackages_PackageNamesToMigrate_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformMigratePackages_FunctionAddress, "PackageNamesToMigrate", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PerformMigratePackages_ReturnValue_PropertyAddress, PerformMigratePackages_FunctionAddress, "ReturnValue");
		PerformMigratePackages_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PerformMigratePackages_FunctionAddress, "ReturnValue");
		PerformMigratePackages_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PerformMigratePackages_FunctionAddress, "ReturnValue", Classes.FSetProperty);
		PerformMigratePackages_IsValid = PerformMigratePackages_FunctionAddress != IntPtr.Zero && PerformMigratePackages_PackageNamesToMigrate_IsValid && PerformMigratePackages_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:PerformMigratePackages", PerformMigratePackages_IsValid);
		OpenAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenAsset");
		OpenAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenAsset_InAsset_PropertyAddress, OpenAsset_FunctionAddress, "InAsset");
		OpenAsset_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(OpenAsset_FunctionAddress, "InAsset");
		OpenAsset_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenAsset_FunctionAddress, "InAsset", Classes.FObjectProperty);
		OpenAsset_IsValid = OpenAsset_FunctionAddress != IntPtr.Zero && OpenAsset_InAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:OpenAsset", OpenAsset_IsValid);
		MarkDirtyObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkDirtyObjects");
		MarkDirtyObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkDirtyObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkDirtyObjects_Objs_PropertyAddress, MarkDirtyObjects_FunctionAddress, "Objs");
		MarkDirtyObjects_Objs_Offset = NativeReflectionCached.GetPropertyOffset(MarkDirtyObjects_FunctionAddress, "Objs");
		MarkDirtyObjects_Objs_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkDirtyObjects_FunctionAddress, "Objs", Classes.FArrayProperty);
		MarkDirtyObjects_IsValid = MarkDirtyObjects_FunctionAddress != IntPtr.Zero && MarkDirtyObjects_Objs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:MarkDirtyObjects", MarkDirtyObjects_IsValid);
		MakeAssetWritableAndSave_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeAssetWritableAndSave");
		MakeAssetWritableAndSave_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeAssetWritableAndSave_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeAssetWritableAndSave_InObject_PropertyAddress, MakeAssetWritableAndSave_FunctionAddress, "InObject");
		MakeAssetWritableAndSave_InObject_Offset = NativeReflectionCached.GetPropertyOffset(MakeAssetWritableAndSave_FunctionAddress, "InObject");
		MakeAssetWritableAndSave_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeAssetWritableAndSave_FunctionAddress, "InObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeAssetWritableAndSave_ReturnValue_PropertyAddress, MakeAssetWritableAndSave_FunctionAddress, "ReturnValue");
		MakeAssetWritableAndSave_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeAssetWritableAndSave_FunctionAddress, "ReturnValue");
		MakeAssetWritableAndSave_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeAssetWritableAndSave_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MakeAssetWritableAndSave_IsValid = MakeAssetWritableAndSave_FunctionAddress != IntPtr.Zero && MakeAssetWritableAndSave_InObject_IsValid && MakeAssetWritableAndSave_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:MakeAssetWritableAndSave", MakeAssetWritableAndSave_IsValid);
		IsSavingPackageOrGC_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsSavingPackageOrGC");
		IsSavingPackageOrGC_ParamsSize = NativeReflection.GetFunctionParamsSize(IsSavingPackageOrGC_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsSavingPackageOrGC_ReturnValue_PropertyAddress, IsSavingPackageOrGC_FunctionAddress, "ReturnValue");
		IsSavingPackageOrGC_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsSavingPackageOrGC_FunctionAddress, "ReturnValue");
		IsSavingPackageOrGC_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsSavingPackageOrGC_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsSavingPackageOrGC_IsValid = IsSavingPackageOrGC_FunctionAddress != IntPtr.Zero && IsSavingPackageOrGC_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:IsSavingPackageOrGC", IsSavingPackageOrGC_IsValid);
		IsNiagaraSystemNeedMergeEmitter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsNiagaraSystemNeedMergeEmitter");
		IsNiagaraSystemNeedMergeEmitter_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNiagaraSystemNeedMergeEmitter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNiagaraSystemNeedMergeEmitter_NiagaraSystem_PropertyAddress, IsNiagaraSystemNeedMergeEmitter_FunctionAddress, "NiagaraSystem");
		IsNiagaraSystemNeedMergeEmitter_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(IsNiagaraSystemNeedMergeEmitter_FunctionAddress, "NiagaraSystem");
		IsNiagaraSystemNeedMergeEmitter_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNiagaraSystemNeedMergeEmitter_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNiagaraSystemNeedMergeEmitter_ReturnValue_PropertyAddress, IsNiagaraSystemNeedMergeEmitter_FunctionAddress, "ReturnValue");
		IsNiagaraSystemNeedMergeEmitter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNiagaraSystemNeedMergeEmitter_FunctionAddress, "ReturnValue");
		IsNiagaraSystemNeedMergeEmitter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNiagaraSystemNeedMergeEmitter_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNiagaraSystemNeedMergeEmitter_IsValid = IsNiagaraSystemNeedMergeEmitter_FunctionAddress != IntPtr.Zero && IsNiagaraSystemNeedMergeEmitter_NiagaraSystem_IsValid && IsNiagaraSystemNeedMergeEmitter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:IsNiagaraSystemNeedMergeEmitter", IsNiagaraSystemNeedMergeEmitter_IsValid);
		IsNiagaraSystemBadVMID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsNiagaraSystemBadVMID");
		IsNiagaraSystemBadVMID_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNiagaraSystemBadVMID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNiagaraSystemBadVMID_NiagaraSystem_PropertyAddress, IsNiagaraSystemBadVMID_FunctionAddress, "NiagaraSystem");
		IsNiagaraSystemBadVMID_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(IsNiagaraSystemBadVMID_FunctionAddress, "NiagaraSystem");
		IsNiagaraSystemBadVMID_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNiagaraSystemBadVMID_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsNiagaraSystemBadVMID_ReturnValue_PropertyAddress, IsNiagaraSystemBadVMID_FunctionAddress, "ReturnValue");
		IsNiagaraSystemBadVMID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNiagaraSystemBadVMID_FunctionAddress, "ReturnValue");
		IsNiagaraSystemBadVMID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNiagaraSystemBadVMID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNiagaraSystemBadVMID_IsValid = IsNiagaraSystemBadVMID_FunctionAddress != IntPtr.Zero && IsNiagaraSystemBadVMID_NiagaraSystem_IsValid && IsNiagaraSystemBadVMID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:IsNiagaraSystemBadVMID", IsNiagaraSystemBadVMID_IsValid);
		GetBlueprintTressFXComponentMaterials_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlueprintTressFXComponentMaterials");
		GetBlueprintTressFXComponentMaterials_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlueprintTressFXComponentMaterials_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlueprintTressFXComponentMaterials_TargetBlueprint_PropertyAddress, GetBlueprintTressFXComponentMaterials_FunctionAddress, "TargetBlueprint");
		GetBlueprintTressFXComponentMaterials_TargetBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(GetBlueprintTressFXComponentMaterials_FunctionAddress, "TargetBlueprint");
		GetBlueprintTressFXComponentMaterials_TargetBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlueprintTressFXComponentMaterials_FunctionAddress, "TargetBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlueprintTressFXComponentMaterials_ReturnValue_PropertyAddress, GetBlueprintTressFXComponentMaterials_FunctionAddress, "ReturnValue");
		GetBlueprintTressFXComponentMaterials_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlueprintTressFXComponentMaterials_FunctionAddress, "ReturnValue");
		GetBlueprintTressFXComponentMaterials_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlueprintTressFXComponentMaterials_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBlueprintTressFXComponentMaterials_IsValid = GetBlueprintTressFXComponentMaterials_FunctionAddress != IntPtr.Zero && GetBlueprintTressFXComponentMaterials_TargetBlueprint_IsValid && GetBlueprintTressFXComponentMaterials_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:GetBlueprintTressFXComponentMaterials", GetBlueprintTressFXComponentMaterials_IsValid);
		GetAssetsByClassInFolder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetsByClassInFolder");
		GetAssetsByClassInFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsByClassInFolder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClassInFolder_OutAssetData_PropertyAddress, GetAssetsByClassInFolder_FunctionAddress, "OutAssetData");
		GetAssetsByClassInFolder_OutAssetData_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClassInFolder_FunctionAddress, "OutAssetData");
		GetAssetsByClassInFolder_OutAssetData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClassInFolder_FunctionAddress, "OutAssetData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClassInFolder_Folder_PropertyAddress, GetAssetsByClassInFolder_FunctionAddress, "Folder");
		GetAssetsByClassInFolder_Folder_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClassInFolder_FunctionAddress, "Folder");
		GetAssetsByClassInFolder_Folder_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClassInFolder_FunctionAddress, "Folder", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClassInFolder_ClassName_PropertyAddress, GetAssetsByClassInFolder_FunctionAddress, "ClassName");
		GetAssetsByClassInFolder_ClassName_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClassInFolder_FunctionAddress, "ClassName");
		GetAssetsByClassInFolder_ClassName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClassInFolder_FunctionAddress, "ClassName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClassInFolder_bRecursive_PropertyAddress, GetAssetsByClassInFolder_FunctionAddress, "bRecursive");
		GetAssetsByClassInFolder_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClassInFolder_FunctionAddress, "bRecursive");
		GetAssetsByClassInFolder_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClassInFolder_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClassInFolder_bSearchSubClasses_PropertyAddress, GetAssetsByClassInFolder_FunctionAddress, "bSearchSubClasses");
		GetAssetsByClassInFolder_bSearchSubClasses_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClassInFolder_FunctionAddress, "bSearchSubClasses");
		GetAssetsByClassInFolder_bSearchSubClasses_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClassInFolder_FunctionAddress, "bSearchSubClasses", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsByClassInFolder_bIncludeOnlyOnDiskAssets_PropertyAddress, GetAssetsByClassInFolder_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsByClassInFolder_bIncludeOnlyOnDiskAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsByClassInFolder_FunctionAddress, "bIncludeOnlyOnDiskAssets");
		GetAssetsByClassInFolder_bIncludeOnlyOnDiskAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsByClassInFolder_FunctionAddress, "bIncludeOnlyOnDiskAssets", Classes.FBoolProperty);
		GetAssetsByClassInFolder_IsValid = GetAssetsByClassInFolder_FunctionAddress != IntPtr.Zero && GetAssetsByClassInFolder_OutAssetData_IsValid && GetAssetsByClassInFolder_Folder_IsValid && GetAssetsByClassInFolder_ClassName_IsValid && GetAssetsByClassInFolder_bRecursive_IsValid && GetAssetsByClassInFolder_bSearchSubClasses_IsValid && GetAssetsByClassInFolder_bIncludeOnlyOnDiskAssets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:GetAssetsByClassInFolder", GetAssetsByClassInFolder_IsValid);
		GetAllRecursiveFoldersWithKeyword_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllRecursiveFoldersWithKeyword");
		GetAllRecursiveFoldersWithKeyword_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllRecursiveFoldersWithKeyword_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllRecursiveFoldersWithKeyword_InRootFolder_PropertyAddress, GetAllRecursiveFoldersWithKeyword_FunctionAddress, "InRootFolder");
		GetAllRecursiveFoldersWithKeyword_InRootFolder_Offset = NativeReflectionCached.GetPropertyOffset(GetAllRecursiveFoldersWithKeyword_FunctionAddress, "InRootFolder");
		GetAllRecursiveFoldersWithKeyword_InRootFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllRecursiveFoldersWithKeyword_FunctionAddress, "InRootFolder", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllRecursiveFoldersWithKeyword_InKeyword_PropertyAddress, GetAllRecursiveFoldersWithKeyword_FunctionAddress, "InKeyword");
		GetAllRecursiveFoldersWithKeyword_InKeyword_Offset = NativeReflectionCached.GetPropertyOffset(GetAllRecursiveFoldersWithKeyword_FunctionAddress, "InKeyword");
		GetAllRecursiveFoldersWithKeyword_InKeyword_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllRecursiveFoldersWithKeyword_FunctionAddress, "InKeyword", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllRecursiveFoldersWithKeyword_ReturnValue_PropertyAddress, GetAllRecursiveFoldersWithKeyword_FunctionAddress, "ReturnValue");
		GetAllRecursiveFoldersWithKeyword_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllRecursiveFoldersWithKeyword_FunctionAddress, "ReturnValue");
		GetAllRecursiveFoldersWithKeyword_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllRecursiveFoldersWithKeyword_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllRecursiveFoldersWithKeyword_IsValid = GetAllRecursiveFoldersWithKeyword_FunctionAddress != IntPtr.Zero && GetAllRecursiveFoldersWithKeyword_InRootFolder_IsValid && GetAllRecursiveFoldersWithKeyword_InKeyword_IsValid && GetAllRecursiveFoldersWithKeyword_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:GetAllRecursiveFoldersWithKeyword", GetAllRecursiveFoldersWithKeyword_IsValid);
		FixSelectedNiagaraSystemMergeParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixSelectedNiagaraSystemMergeParent");
		FixSelectedNiagaraSystemMergeParent_ParamsSize = NativeReflection.GetFunctionParamsSize(FixSelectedNiagaraSystemMergeParent_FunctionAddress);
		FixSelectedNiagaraSystemMergeParent_IsValid = FixSelectedNiagaraSystemMergeParent_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:FixSelectedNiagaraSystemMergeParent", FixSelectedNiagaraSystemMergeParent_IsValid);
		FixSelectedNiagaraSystemBadVMID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixSelectedNiagaraSystemBadVMID");
		FixSelectedNiagaraSystemBadVMID_ParamsSize = NativeReflection.GetFunctionParamsSize(FixSelectedNiagaraSystemBadVMID_FunctionAddress);
		FixSelectedNiagaraSystemBadVMID_IsValid = FixSelectedNiagaraSystemBadVMID_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:FixSelectedNiagaraSystemBadVMID", FixSelectedNiagaraSystemBadVMID_IsValid);
		FixNiagaraSystemMergeParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixNiagaraSystemMergeParent");
		FixNiagaraSystemMergeParent_ParamsSize = NativeReflection.GetFunctionParamsSize(FixNiagaraSystemMergeParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FixNiagaraSystemMergeParent_NiagaraSystem_PropertyAddress, FixNiagaraSystemMergeParent_FunctionAddress, "NiagaraSystem");
		FixNiagaraSystemMergeParent_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(FixNiagaraSystemMergeParent_FunctionAddress, "NiagaraSystem");
		FixNiagaraSystemMergeParent_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(FixNiagaraSystemMergeParent_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		FixNiagaraSystemMergeParent_IsValid = FixNiagaraSystemMergeParent_FunctionAddress != IntPtr.Zero && FixNiagaraSystemMergeParent_NiagaraSystem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:FixNiagaraSystemMergeParent", FixNiagaraSystemMergeParent_IsValid);
		FixNiagaraSystemBadVMID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixNiagaraSystemBadVMID");
		FixNiagaraSystemBadVMID_ParamsSize = NativeReflection.GetFunctionParamsSize(FixNiagaraSystemBadVMID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FixNiagaraSystemBadVMID_NiagaraSystem_PropertyAddress, FixNiagaraSystemBadVMID_FunctionAddress, "NiagaraSystem");
		FixNiagaraSystemBadVMID_NiagaraSystem_Offset = NativeReflectionCached.GetPropertyOffset(FixNiagaraSystemBadVMID_FunctionAddress, "NiagaraSystem");
		FixNiagaraSystemBadVMID_NiagaraSystem_IsValid = NativeReflectionCached.ValidatePropertyClass(FixNiagaraSystemBadVMID_FunctionAddress, "NiagaraSystem", Classes.FObjectProperty);
		FixNiagaraSystemBadVMID_IsValid = FixNiagaraSystemBadVMID_FunctionAddress != IntPtr.Zero && FixNiagaraSystemBadVMID_NiagaraSystem_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:FixNiagaraSystemBadVMID", FixNiagaraSystemBadVMID_IsValid);
		FixAllNiagaraSystemMergeParent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixAllNiagaraSystemMergeParent");
		FixAllNiagaraSystemMergeParent_ParamsSize = NativeReflection.GetFunctionParamsSize(FixAllNiagaraSystemMergeParent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FixAllNiagaraSystemMergeParent_InAssetDataList_PropertyAddress, FixAllNiagaraSystemMergeParent_FunctionAddress, "InAssetDataList");
		FixAllNiagaraSystemMergeParent_InAssetDataList_Offset = NativeReflectionCached.GetPropertyOffset(FixAllNiagaraSystemMergeParent_FunctionAddress, "InAssetDataList");
		FixAllNiagaraSystemMergeParent_InAssetDataList_IsValid = NativeReflectionCached.ValidatePropertyClass(FixAllNiagaraSystemMergeParent_FunctionAddress, "InAssetDataList", Classes.FArrayProperty);
		FixAllNiagaraSystemMergeParent_IsValid = FixAllNiagaraSystemMergeParent_FunctionAddress != IntPtr.Zero && FixAllNiagaraSystemMergeParent_InAssetDataList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:FixAllNiagaraSystemMergeParent", FixAllNiagaraSystemMergeParent_IsValid);
		FixAllNiagaraSystemBadVMID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FixAllNiagaraSystemBadVMID");
		FixAllNiagaraSystemBadVMID_ParamsSize = NativeReflection.GetFunctionParamsSize(FixAllNiagaraSystemBadVMID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FixAllNiagaraSystemBadVMID_InAssetDataList_PropertyAddress, FixAllNiagaraSystemBadVMID_FunctionAddress, "InAssetDataList");
		FixAllNiagaraSystemBadVMID_InAssetDataList_Offset = NativeReflectionCached.GetPropertyOffset(FixAllNiagaraSystemBadVMID_FunctionAddress, "InAssetDataList");
		FixAllNiagaraSystemBadVMID_InAssetDataList_IsValid = NativeReflectionCached.ValidatePropertyClass(FixAllNiagaraSystemBadVMID_FunctionAddress, "InAssetDataList", Classes.FArrayProperty);
		FixAllNiagaraSystemBadVMID_IsValid = FixAllNiagaraSystemBadVMID_FunctionAddress != IntPtr.Zero && FixAllNiagaraSystemBadVMID_InAssetDataList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:FixAllNiagaraSystemBadVMID", FixAllNiagaraSystemBadVMID_IsValid);
		CreateTFXCardMeshCompInUnitBP_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateTFXCardMeshCompInUnitBP");
		CreateTFXCardMeshCompInUnitBP_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateTFXCardMeshCompInUnitBP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateTFXCardMeshCompInUnitBP_TargetBlueprint_PropertyAddress, CreateTFXCardMeshCompInUnitBP_FunctionAddress, "TargetBlueprint");
		CreateTFXCardMeshCompInUnitBP_TargetBlueprint_Offset = NativeReflectionCached.GetPropertyOffset(CreateTFXCardMeshCompInUnitBP_FunctionAddress, "TargetBlueprint");
		CreateTFXCardMeshCompInUnitBP_TargetBlueprint_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTFXCardMeshCompInUnitBP_FunctionAddress, "TargetBlueprint", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTFXCardMeshCompInUnitBP_GenCardsParameterList_PropertyAddress, CreateTFXCardMeshCompInUnitBP_FunctionAddress, "GenCardsParameterList");
		CreateTFXCardMeshCompInUnitBP_GenCardsParameterList_Offset = NativeReflectionCached.GetPropertyOffset(CreateTFXCardMeshCompInUnitBP_FunctionAddress, "GenCardsParameterList");
		CreateTFXCardMeshCompInUnitBP_GenCardsParameterList_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTFXCardMeshCompInUnitBP_FunctionAddress, "GenCardsParameterList", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTFXCardMeshCompInUnitBP_RecreateResource_PropertyAddress, CreateTFXCardMeshCompInUnitBP_FunctionAddress, "RecreateResource");
		CreateTFXCardMeshCompInUnitBP_RecreateResource_Offset = NativeReflectionCached.GetPropertyOffset(CreateTFXCardMeshCompInUnitBP_FunctionAddress, "RecreateResource");
		CreateTFXCardMeshCompInUnitBP_RecreateResource_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTFXCardMeshCompInUnitBP_FunctionAddress, "RecreateResource", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateTFXCardMeshCompInUnitBP_ReturnValue_PropertyAddress, CreateTFXCardMeshCompInUnitBP_FunctionAddress, "ReturnValue");
		CreateTFXCardMeshCompInUnitBP_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateTFXCardMeshCompInUnitBP_FunctionAddress, "ReturnValue");
		CreateTFXCardMeshCompInUnitBP_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateTFXCardMeshCompInUnitBP_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CreateTFXCardMeshCompInUnitBP_IsValid = CreateTFXCardMeshCompInUnitBP_FunctionAddress != IntPtr.Zero && CreateTFXCardMeshCompInUnitBP_TargetBlueprint_IsValid && CreateTFXCardMeshCompInUnitBP_GenCardsParameterList_IsValid && CreateTFXCardMeshCompInUnitBP_RecreateResource_IsValid && CreateTFXCardMeshCompInUnitBP_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:CreateTFXCardMeshCompInUnitBP", CreateTFXCardMeshCompInUnitBP_IsValid);
		CreateBossRushGraphAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateBossRushGraphAsset");
		CreateBossRushGraphAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateBossRushGraphAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateBossRushGraphAsset_InPackagePath_PropertyAddress, CreateBossRushGraphAsset_FunctionAddress, "InPackagePath");
		CreateBossRushGraphAsset_InPackagePath_Offset = NativeReflectionCached.GetPropertyOffset(CreateBossRushGraphAsset_FunctionAddress, "InPackagePath");
		CreateBossRushGraphAsset_InPackagePath_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBossRushGraphAsset_FunctionAddress, "InPackagePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBossRushGraphAsset_InAssetName_PropertyAddress, CreateBossRushGraphAsset_FunctionAddress, "InAssetName");
		CreateBossRushGraphAsset_InAssetName_Offset = NativeReflectionCached.GetPropertyOffset(CreateBossRushGraphAsset_FunctionAddress, "InAssetName");
		CreateBossRushGraphAsset_InAssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBossRushGraphAsset_FunctionAddress, "InAssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBossRushGraphAsset_InAssetClass_PropertyAddress, CreateBossRushGraphAsset_FunctionAddress, "InAssetClass");
		CreateBossRushGraphAsset_InAssetClass_Offset = NativeReflectionCached.GetPropertyOffset(CreateBossRushGraphAsset_FunctionAddress, "InAssetClass");
		CreateBossRushGraphAsset_InAssetClass_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBossRushGraphAsset_FunctionAddress, "InAssetClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateBossRushGraphAsset_ReturnValue_PropertyAddress, CreateBossRushGraphAsset_FunctionAddress, "ReturnValue");
		CreateBossRushGraphAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateBossRushGraphAsset_FunctionAddress, "ReturnValue");
		CreateBossRushGraphAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateBossRushGraphAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateBossRushGraphAsset_IsValid = CreateBossRushGraphAsset_FunctionAddress != IntPtr.Zero && CreateBossRushGraphAsset_InPackagePath_IsValid && CreateBossRushGraphAsset_InAssetName_IsValid && CreateBossRushGraphAsset_InAssetClass_IsValid && CreateBossRushGraphAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:CreateBossRushGraphAsset", CreateBossRushGraphAsset_IsValid);
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ParamsSize = NativeReflection.GetFunctionParamsSize(CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_OutputInfo_PropertyAddress, CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress, "OutputInfo");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_OutputInfo_Offset = NativeReflectionCached.GetPropertyOffset(CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress, "OutputInfo");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_OutputInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress, "OutputInfo", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ReturnValue_PropertyAddress, CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress, "ReturnValue");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress, "ReturnValue");
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_IsValid = CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_FunctionAddress != IntPtr.Zero && CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_OutputInfo_IsValid && CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP", CollectNiagaraAssetsFromPreloadAssetCollectionResult_CPP_IsValid);
		CloseAllEditorsForAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CloseAllEditorsForAsset");
		CloseAllEditorsForAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CloseAllEditorsForAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CloseAllEditorsForAsset_Asset_PropertyAddress, CloseAllEditorsForAsset_FunctionAddress, "Asset");
		CloseAllEditorsForAsset_Asset_Offset = NativeReflectionCached.GetPropertyOffset(CloseAllEditorsForAsset_FunctionAddress, "Asset");
		CloseAllEditorsForAsset_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseAllEditorsForAsset_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CloseAllEditorsForAsset_ReturnValue_PropertyAddress, CloseAllEditorsForAsset_FunctionAddress, "ReturnValue");
		CloseAllEditorsForAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CloseAllEditorsForAsset_FunctionAddress, "ReturnValue");
		CloseAllEditorsForAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CloseAllEditorsForAsset_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		CloseAllEditorsForAsset_IsValid = CloseAllEditorsForAsset_FunctionAddress != IntPtr.Zero && CloseAllEditorsForAsset_Asset_IsValid && CloseAllEditorsForAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:CloseAllEditorsForAsset", CloseAllEditorsForAsset_IsValid);
		AddCalliopeNode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddCalliopeNode");
		AddCalliopeNode_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCalliopeNode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCalliopeNode_InAsset_PropertyAddress, AddCalliopeNode_FunctionAddress, "InAsset");
		AddCalliopeNode_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(AddCalliopeNode_FunctionAddress, "InAsset");
		AddCalliopeNode_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCalliopeNode_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCalliopeNode_InNodeClass_PropertyAddress, AddCalliopeNode_FunctionAddress, "InNodeClass");
		AddCalliopeNode_InNodeClass_Offset = NativeReflectionCached.GetPropertyOffset(AddCalliopeNode_FunctionAddress, "InNodeClass");
		AddCalliopeNode_InNodeClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCalliopeNode_FunctionAddress, "InNodeClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCalliopeNode_InLocation_PropertyAddress, AddCalliopeNode_FunctionAddress, "InLocation");
		AddCalliopeNode_InLocation_Offset = NativeReflectionCached.GetPropertyOffset(AddCalliopeNode_FunctionAddress, "InLocation");
		AddCalliopeNode_InLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCalliopeNode_FunctionAddress, "InLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCalliopeNode_FromNode_PropertyAddress, AddCalliopeNode_FunctionAddress, "FromNode");
		AddCalliopeNode_FromNode_Offset = NativeReflectionCached.GetPropertyOffset(AddCalliopeNode_FunctionAddress, "FromNode");
		AddCalliopeNode_FromNode_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCalliopeNode_FunctionAddress, "FromNode", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCalliopeNode_FromPinNameStr_PropertyAddress, AddCalliopeNode_FunctionAddress, "FromPinNameStr");
		AddCalliopeNode_FromPinNameStr_Offset = NativeReflectionCached.GetPropertyOffset(AddCalliopeNode_FunctionAddress, "FromPinNameStr");
		AddCalliopeNode_FromPinNameStr_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCalliopeNode_FunctionAddress, "FromPinNameStr", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCalliopeNode_ReturnValue_PropertyAddress, AddCalliopeNode_FunctionAddress, "ReturnValue");
		AddCalliopeNode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddCalliopeNode_FunctionAddress, "ReturnValue");
		AddCalliopeNode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCalliopeNode_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddCalliopeNode_IsValid = AddCalliopeNode_FunctionAddress != IntPtr.Zero && AddCalliopeNode_InAsset_IsValid && AddCalliopeNode_InNodeClass_IsValid && AddCalliopeNode_InLocation_IsValid && AddCalliopeNode_FromNode_IsValid && AddCalliopeNode_FromPinNameStr_IsValid && AddCalliopeNode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorAssetLibrary:AddCalliopeNode", AddCalliopeNode_IsValid);
	}
}
