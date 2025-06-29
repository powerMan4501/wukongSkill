using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public class UEditorAssetLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SyncBrowserToObjects_IsValid;

	private static IntPtr SyncBrowserToObjects_FunctionAddress;

	private static int SyncBrowserToObjects_ParamsSize;

	private static bool SyncBrowserToObjects_AssetPaths_IsValid;

	private static FFieldAddress SyncBrowserToObjects_AssetPaths_PropertyAddress;

	private static int SyncBrowserToObjects_AssetPaths_Offset;

	private static bool SetMetadataTag_IsValid;

	private static IntPtr SetMetadataTag_FunctionAddress;

	private static int SetMetadataTag_ParamsSize;

	private static bool SetMetadataTag_Object_IsValid;

	private static FFieldAddress SetMetadataTag_Object_PropertyAddress;

	private static int SetMetadataTag_Object_Offset;

	private static bool SetMetadataTag_Tag_IsValid;

	private static FFieldAddress SetMetadataTag_Tag_PropertyAddress;

	private static int SetMetadataTag_Tag_Offset;

	private static bool SetMetadataTag_Value_IsValid;

	private static FFieldAddress SetMetadataTag_Value_PropertyAddress;

	private static int SetMetadataTag_Value_Offset;

	private static bool SaveLoadedAssets_IsValid;

	private static IntPtr SaveLoadedAssets_FunctionAddress;

	private static int SaveLoadedAssets_ParamsSize;

	private static bool SaveLoadedAssets_AssetsToSave_IsValid;

	private static FFieldAddress SaveLoadedAssets_AssetsToSave_PropertyAddress;

	private static int SaveLoadedAssets_AssetsToSave_Offset;

	private static bool SaveLoadedAssets_bOnlyIfIsDirty_IsValid;

	private static FFieldAddress SaveLoadedAssets_bOnlyIfIsDirty_PropertyAddress;

	private static int SaveLoadedAssets_bOnlyIfIsDirty_Offset;

	private static bool SaveLoadedAssets_ReturnValue_IsValid;

	private static FFieldAddress SaveLoadedAssets_ReturnValue_PropertyAddress;

	private static int SaveLoadedAssets_ReturnValue_Offset;

	private static bool SaveLoadedAsset_IsValid;

	private static IntPtr SaveLoadedAsset_FunctionAddress;

	private static int SaveLoadedAsset_ParamsSize;

	private static bool SaveLoadedAsset_AssetToSave_IsValid;

	private static FFieldAddress SaveLoadedAsset_AssetToSave_PropertyAddress;

	private static int SaveLoadedAsset_AssetToSave_Offset;

	private static bool SaveLoadedAsset_bOnlyIfIsDirty_IsValid;

	private static FFieldAddress SaveLoadedAsset_bOnlyIfIsDirty_PropertyAddress;

	private static int SaveLoadedAsset_bOnlyIfIsDirty_Offset;

	private static bool SaveLoadedAsset_ReturnValue_IsValid;

	private static FFieldAddress SaveLoadedAsset_ReturnValue_PropertyAddress;

	private static int SaveLoadedAsset_ReturnValue_Offset;

	private static bool SaveDirectory_IsValid;

	private static IntPtr SaveDirectory_FunctionAddress;

	private static int SaveDirectory_ParamsSize;

	private static bool SaveDirectory_DirectoryPath_IsValid;

	private static FFieldAddress SaveDirectory_DirectoryPath_PropertyAddress;

	private static int SaveDirectory_DirectoryPath_Offset;

	private static bool SaveDirectory_bOnlyIfIsDirty_IsValid;

	private static FFieldAddress SaveDirectory_bOnlyIfIsDirty_PropertyAddress;

	private static int SaveDirectory_bOnlyIfIsDirty_Offset;

	private static bool SaveDirectory_bRecursive_IsValid;

	private static FFieldAddress SaveDirectory_bRecursive_PropertyAddress;

	private static int SaveDirectory_bRecursive_Offset;

	private static bool SaveDirectory_ReturnValue_IsValid;

	private static FFieldAddress SaveDirectory_ReturnValue_PropertyAddress;

	private static int SaveDirectory_ReturnValue_Offset;

	private static bool SaveAsset_IsValid;

	private static IntPtr SaveAsset_FunctionAddress;

	private static int SaveAsset_ParamsSize;

	private static bool SaveAsset_AssetToSave_IsValid;

	private static FFieldAddress SaveAsset_AssetToSave_PropertyAddress;

	private static int SaveAsset_AssetToSave_Offset;

	private static bool SaveAsset_bOnlyIfIsDirty_IsValid;

	private static FFieldAddress SaveAsset_bOnlyIfIsDirty_PropertyAddress;

	private static int SaveAsset_bOnlyIfIsDirty_Offset;

	private static bool SaveAsset_ReturnValue_IsValid;

	private static FFieldAddress SaveAsset_ReturnValue_PropertyAddress;

	private static int SaveAsset_ReturnValue_Offset;

	private static bool RenameLoadedAsset_IsValid;

	private static IntPtr RenameLoadedAsset_FunctionAddress;

	private static int RenameLoadedAsset_ParamsSize;

	private static bool RenameLoadedAsset_SourceAsset_IsValid;

	private static FFieldAddress RenameLoadedAsset_SourceAsset_PropertyAddress;

	private static int RenameLoadedAsset_SourceAsset_Offset;

	private static bool RenameLoadedAsset_DestinationAssetPath_IsValid;

	private static FFieldAddress RenameLoadedAsset_DestinationAssetPath_PropertyAddress;

	private static int RenameLoadedAsset_DestinationAssetPath_Offset;

	private static bool RenameLoadedAsset_ReturnValue_IsValid;

	private static FFieldAddress RenameLoadedAsset_ReturnValue_PropertyAddress;

	private static int RenameLoadedAsset_ReturnValue_Offset;

	private static bool RenameDirectory_IsValid;

	private static IntPtr RenameDirectory_FunctionAddress;

	private static int RenameDirectory_ParamsSize;

	private static bool RenameDirectory_SourceDirectoryPath_IsValid;

	private static FFieldAddress RenameDirectory_SourceDirectoryPath_PropertyAddress;

	private static int RenameDirectory_SourceDirectoryPath_Offset;

	private static bool RenameDirectory_DestinationDirectoryPath_IsValid;

	private static FFieldAddress RenameDirectory_DestinationDirectoryPath_PropertyAddress;

	private static int RenameDirectory_DestinationDirectoryPath_Offset;

	private static bool RenameDirectory_ReturnValue_IsValid;

	private static FFieldAddress RenameDirectory_ReturnValue_PropertyAddress;

	private static int RenameDirectory_ReturnValue_Offset;

	private static bool RenameAsset_IsValid;

	private static IntPtr RenameAsset_FunctionAddress;

	private static int RenameAsset_ParamsSize;

	private static bool RenameAsset_SourceAssetPath_IsValid;

	private static FFieldAddress RenameAsset_SourceAssetPath_PropertyAddress;

	private static int RenameAsset_SourceAssetPath_Offset;

	private static bool RenameAsset_DestinationAssetPath_IsValid;

	private static FFieldAddress RenameAsset_DestinationAssetPath_PropertyAddress;

	private static int RenameAsset_DestinationAssetPath_Offset;

	private static bool RenameAsset_ReturnValue_IsValid;

	private static FFieldAddress RenameAsset_ReturnValue_PropertyAddress;

	private static int RenameAsset_ReturnValue_Offset;

	private static bool RemoveMetadataTag_IsValid;

	private static IntPtr RemoveMetadataTag_FunctionAddress;

	private static int RemoveMetadataTag_ParamsSize;

	private static bool RemoveMetadataTag_Object_IsValid;

	private static FFieldAddress RemoveMetadataTag_Object_PropertyAddress;

	private static int RemoveMetadataTag_Object_Offset;

	private static bool RemoveMetadataTag_Tag_IsValid;

	private static FFieldAddress RemoveMetadataTag_Tag_PropertyAddress;

	private static int RemoveMetadataTag_Tag_Offset;

	private static bool MakeDirectory_IsValid;

	private static IntPtr MakeDirectory_FunctionAddress;

	private static int MakeDirectory_ParamsSize;

	private static bool MakeDirectory_DirectoryPath_IsValid;

	private static FFieldAddress MakeDirectory_DirectoryPath_PropertyAddress;

	private static int MakeDirectory_DirectoryPath_Offset;

	private static bool MakeDirectory_ReturnValue_IsValid;

	private static FFieldAddress MakeDirectory_ReturnValue_PropertyAddress;

	private static int MakeDirectory_ReturnValue_Offset;

	private static bool LoadBlueprintClass_IsValid;

	private static IntPtr LoadBlueprintClass_FunctionAddress;

	private static int LoadBlueprintClass_ParamsSize;

	private static bool LoadBlueprintClass_AssetPath_IsValid;

	private static FFieldAddress LoadBlueprintClass_AssetPath_PropertyAddress;

	private static int LoadBlueprintClass_AssetPath_Offset;

	private static bool LoadBlueprintClass_ReturnValue_IsValid;

	private static FFieldAddress LoadBlueprintClass_ReturnValue_PropertyAddress;

	private static int LoadBlueprintClass_ReturnValue_Offset;

	private static bool LoadAsset_IsValid;

	private static IntPtr LoadAsset_FunctionAddress;

	private static int LoadAsset_ParamsSize;

	private static bool LoadAsset_AssetPath_IsValid;

	private static FFieldAddress LoadAsset_AssetPath_PropertyAddress;

	private static int LoadAsset_AssetPath_Offset;

	private static bool LoadAsset_ReturnValue_IsValid;

	private static FFieldAddress LoadAsset_ReturnValue_PropertyAddress;

	private static int LoadAsset_ReturnValue_Offset;

	private static bool ListAssets_IsValid;

	private static IntPtr ListAssets_FunctionAddress;

	private static int ListAssets_ParamsSize;

	private static bool ListAssets_DirectoryPath_IsValid;

	private static FFieldAddress ListAssets_DirectoryPath_PropertyAddress;

	private static int ListAssets_DirectoryPath_Offset;

	private static bool ListAssets_bRecursive_IsValid;

	private static FFieldAddress ListAssets_bRecursive_PropertyAddress;

	private static int ListAssets_bRecursive_Offset;

	private static bool ListAssets_bIncludeFolder_IsValid;

	private static FFieldAddress ListAssets_bIncludeFolder_PropertyAddress;

	private static int ListAssets_bIncludeFolder_Offset;

	private static bool ListAssets_ReturnValue_IsValid;

	private static FFieldAddress ListAssets_ReturnValue_PropertyAddress;

	private static int ListAssets_ReturnValue_Offset;

	private static bool ListAssetByTagValue_IsValid;

	private static IntPtr ListAssetByTagValue_FunctionAddress;

	private static int ListAssetByTagValue_ParamsSize;

	private static bool ListAssetByTagValue_TagName_IsValid;

	private static FFieldAddress ListAssetByTagValue_TagName_PropertyAddress;

	private static int ListAssetByTagValue_TagName_Offset;

	private static bool ListAssetByTagValue_TagValue_IsValid;

	private static FFieldAddress ListAssetByTagValue_TagValue_PropertyAddress;

	private static int ListAssetByTagValue_TagValue_Offset;

	private static bool ListAssetByTagValue_ReturnValue_IsValid;

	private static FFieldAddress ListAssetByTagValue_ReturnValue_PropertyAddress;

	private static int ListAssetByTagValue_ReturnValue_Offset;

	private static bool GetTagValues_IsValid;

	private static IntPtr GetTagValues_FunctionAddress;

	private static int GetTagValues_ParamsSize;

	private static bool GetTagValues_AssetPath_IsValid;

	private static FFieldAddress GetTagValues_AssetPath_PropertyAddress;

	private static int GetTagValues_AssetPath_Offset;

	private static bool GetTagValues_ReturnValue_IsValid;

	private static FFieldAddress GetTagValues_ReturnValue_PropertyAddress;

	private static int GetTagValues_ReturnValue_Offset;

	private static bool GetPathNameForLoadedAsset_IsValid;

	private static IntPtr GetPathNameForLoadedAsset_FunctionAddress;

	private static int GetPathNameForLoadedAsset_ParamsSize;

	private static bool GetPathNameForLoadedAsset_LoadedAsset_IsValid;

	private static FFieldAddress GetPathNameForLoadedAsset_LoadedAsset_PropertyAddress;

	private static int GetPathNameForLoadedAsset_LoadedAsset_Offset;

	private static bool GetPathNameForLoadedAsset_ReturnValue_IsValid;

	private static FFieldAddress GetPathNameForLoadedAsset_ReturnValue_PropertyAddress;

	private static int GetPathNameForLoadedAsset_ReturnValue_Offset;

	private static bool GetMetadataTagValues_IsValid;

	private static IntPtr GetMetadataTagValues_FunctionAddress;

	private static int GetMetadataTagValues_ParamsSize;

	private static bool GetMetadataTagValues_Object_IsValid;

	private static FFieldAddress GetMetadataTagValues_Object_PropertyAddress;

	private static int GetMetadataTagValues_Object_Offset;

	private static bool GetMetadataTagValues_ReturnValue_IsValid;

	private static FFieldAddress GetMetadataTagValues_ReturnValue_PropertyAddress;

	private static int GetMetadataTagValues_ReturnValue_Offset;

	private static bool GetMetadataTag_IsValid;

	private static IntPtr GetMetadataTag_FunctionAddress;

	private static int GetMetadataTag_ParamsSize;

	private static bool GetMetadataTag_Object_IsValid;

	private static FFieldAddress GetMetadataTag_Object_PropertyAddress;

	private static int GetMetadataTag_Object_Offset;

	private static bool GetMetadataTag_Tag_IsValid;

	private static FFieldAddress GetMetadataTag_Tag_PropertyAddress;

	private static int GetMetadataTag_Tag_Offset;

	private static bool GetMetadataTag_ReturnValue_IsValid;

	private static FFieldAddress GetMetadataTag_ReturnValue_PropertyAddress;

	private static int GetMetadataTag_ReturnValue_Offset;

	private static bool FindPackageReferencersForAsset_IsValid;

	private static IntPtr FindPackageReferencersForAsset_FunctionAddress;

	private static int FindPackageReferencersForAsset_ParamsSize;

	private static bool FindPackageReferencersForAsset_AssetPath_IsValid;

	private static FFieldAddress FindPackageReferencersForAsset_AssetPath_PropertyAddress;

	private static int FindPackageReferencersForAsset_AssetPath_Offset;

	private static bool FindPackageReferencersForAsset_bLoadAssetsToConfirm_IsValid;

	private static FFieldAddress FindPackageReferencersForAsset_bLoadAssetsToConfirm_PropertyAddress;

	private static int FindPackageReferencersForAsset_bLoadAssetsToConfirm_Offset;

	private static bool FindPackageReferencersForAsset_ReturnValue_IsValid;

	private static FFieldAddress FindPackageReferencersForAsset_ReturnValue_PropertyAddress;

	private static int FindPackageReferencersForAsset_ReturnValue_Offset;

	private static bool FindAssetData_IsValid;

	private static IntPtr FindAssetData_FunctionAddress;

	private static int FindAssetData_ParamsSize;

	private static bool FindAssetData_AssetPath_IsValid;

	private static FFieldAddress FindAssetData_AssetPath_PropertyAddress;

	private static int FindAssetData_AssetPath_Offset;

	private static bool FindAssetData_ReturnValue_IsValid;

	private static FFieldAddress FindAssetData_ReturnValue_PropertyAddress;

	private static int FindAssetData_ReturnValue_Offset;

	private static bool DuplicateLoadedAsset_IsValid;

	private static IntPtr DuplicateLoadedAsset_FunctionAddress;

	private static int DuplicateLoadedAsset_ParamsSize;

	private static bool DuplicateLoadedAsset_SourceAsset_IsValid;

	private static FFieldAddress DuplicateLoadedAsset_SourceAsset_PropertyAddress;

	private static int DuplicateLoadedAsset_SourceAsset_Offset;

	private static bool DuplicateLoadedAsset_DestinationAssetPath_IsValid;

	private static FFieldAddress DuplicateLoadedAsset_DestinationAssetPath_PropertyAddress;

	private static int DuplicateLoadedAsset_DestinationAssetPath_Offset;

	private static bool DuplicateLoadedAsset_ReturnValue_IsValid;

	private static FFieldAddress DuplicateLoadedAsset_ReturnValue_PropertyAddress;

	private static int DuplicateLoadedAsset_ReturnValue_Offset;

	private static bool DuplicateDirectory_IsValid;

	private static IntPtr DuplicateDirectory_FunctionAddress;

	private static int DuplicateDirectory_ParamsSize;

	private static bool DuplicateDirectory_SourceDirectoryPath_IsValid;

	private static FFieldAddress DuplicateDirectory_SourceDirectoryPath_PropertyAddress;

	private static int DuplicateDirectory_SourceDirectoryPath_Offset;

	private static bool DuplicateDirectory_DestinationDirectoryPath_IsValid;

	private static FFieldAddress DuplicateDirectory_DestinationDirectoryPath_PropertyAddress;

	private static int DuplicateDirectory_DestinationDirectoryPath_Offset;

	private static bool DuplicateDirectory_ReturnValue_IsValid;

	private static FFieldAddress DuplicateDirectory_ReturnValue_PropertyAddress;

	private static int DuplicateDirectory_ReturnValue_Offset;

	private static bool DuplicateAsset_IsValid;

	private static IntPtr DuplicateAsset_FunctionAddress;

	private static int DuplicateAsset_ParamsSize;

	private static bool DuplicateAsset_SourceAssetPath_IsValid;

	private static FFieldAddress DuplicateAsset_SourceAssetPath_PropertyAddress;

	private static int DuplicateAsset_SourceAssetPath_Offset;

	private static bool DuplicateAsset_DestinationAssetPath_IsValid;

	private static FFieldAddress DuplicateAsset_DestinationAssetPath_PropertyAddress;

	private static int DuplicateAsset_DestinationAssetPath_Offset;

	private static bool DuplicateAsset_ReturnValue_IsValid;

	private static FFieldAddress DuplicateAsset_ReturnValue_PropertyAddress;

	private static int DuplicateAsset_ReturnValue_Offset;

	private static bool DoesDirectoryHaveAssets_IsValid;

	private static IntPtr DoesDirectoryHaveAssets_FunctionAddress;

	private static int DoesDirectoryHaveAssets_ParamsSize;

	private static bool DoesDirectoryHaveAssets_DirectoryPath_IsValid;

	private static FFieldAddress DoesDirectoryHaveAssets_DirectoryPath_PropertyAddress;

	private static int DoesDirectoryHaveAssets_DirectoryPath_Offset;

	private static bool DoesDirectoryHaveAssets_bRecursive_IsValid;

	private static FFieldAddress DoesDirectoryHaveAssets_bRecursive_PropertyAddress;

	private static int DoesDirectoryHaveAssets_bRecursive_Offset;

	private static bool DoesDirectoryHaveAssets_ReturnValue_IsValid;

	private static FFieldAddress DoesDirectoryHaveAssets_ReturnValue_PropertyAddress;

	private static int DoesDirectoryHaveAssets_ReturnValue_Offset;

	private static bool DoesDirectoryExist_IsValid;

	private static IntPtr DoesDirectoryExist_FunctionAddress;

	private static int DoesDirectoryExist_ParamsSize;

	private static bool DoesDirectoryExist_DirectoryPath_IsValid;

	private static FFieldAddress DoesDirectoryExist_DirectoryPath_PropertyAddress;

	private static int DoesDirectoryExist_DirectoryPath_Offset;

	private static bool DoesDirectoryExist_ReturnValue_IsValid;

	private static FFieldAddress DoesDirectoryExist_ReturnValue_PropertyAddress;

	private static int DoesDirectoryExist_ReturnValue_Offset;

	private static bool DoesAssetExist_IsValid;

	private static IntPtr DoesAssetExist_FunctionAddress;

	private static int DoesAssetExist_ParamsSize;

	private static bool DoesAssetExist_AssetPath_IsValid;

	private static FFieldAddress DoesAssetExist_AssetPath_PropertyAddress;

	private static int DoesAssetExist_AssetPath_Offset;

	private static bool DoesAssetExist_ReturnValue_IsValid;

	private static FFieldAddress DoesAssetExist_ReturnValue_PropertyAddress;

	private static int DoesAssetExist_ReturnValue_Offset;

	private static bool DoAssetsExist_IsValid;

	private static IntPtr DoAssetsExist_FunctionAddress;

	private static int DoAssetsExist_ParamsSize;

	private static bool DoAssetsExist_AssetPaths_IsValid;

	private static FFieldAddress DoAssetsExist_AssetPaths_PropertyAddress;

	private static int DoAssetsExist_AssetPaths_Offset;

	private static bool DoAssetsExist_ReturnValue_IsValid;

	private static FFieldAddress DoAssetsExist_ReturnValue_PropertyAddress;

	private static int DoAssetsExist_ReturnValue_Offset;

	private static bool DeleteLoadedAssets_IsValid;

	private static IntPtr DeleteLoadedAssets_FunctionAddress;

	private static int DeleteLoadedAssets_ParamsSize;

	private static bool DeleteLoadedAssets_AssetsToDelete_IsValid;

	private static FFieldAddress DeleteLoadedAssets_AssetsToDelete_PropertyAddress;

	private static int DeleteLoadedAssets_AssetsToDelete_Offset;

	private static bool DeleteLoadedAssets_ReturnValue_IsValid;

	private static FFieldAddress DeleteLoadedAssets_ReturnValue_PropertyAddress;

	private static int DeleteLoadedAssets_ReturnValue_Offset;

	private static bool DeleteLoadedAsset_IsValid;

	private static IntPtr DeleteLoadedAsset_FunctionAddress;

	private static int DeleteLoadedAsset_ParamsSize;

	private static bool DeleteLoadedAsset_AssetToDelete_IsValid;

	private static FFieldAddress DeleteLoadedAsset_AssetToDelete_PropertyAddress;

	private static int DeleteLoadedAsset_AssetToDelete_Offset;

	private static bool DeleteLoadedAsset_ReturnValue_IsValid;

	private static FFieldAddress DeleteLoadedAsset_ReturnValue_PropertyAddress;

	private static int DeleteLoadedAsset_ReturnValue_Offset;

	private static bool DeleteDirectory_IsValid;

	private static IntPtr DeleteDirectory_FunctionAddress;

	private static int DeleteDirectory_ParamsSize;

	private static bool DeleteDirectory_DirectoryPath_IsValid;

	private static FFieldAddress DeleteDirectory_DirectoryPath_PropertyAddress;

	private static int DeleteDirectory_DirectoryPath_Offset;

	private static bool DeleteDirectory_ReturnValue_IsValid;

	private static FFieldAddress DeleteDirectory_ReturnValue_PropertyAddress;

	private static int DeleteDirectory_ReturnValue_Offset;

	private static bool DeleteAsset_IsValid;

	private static IntPtr DeleteAsset_FunctionAddress;

	private static int DeleteAsset_ParamsSize;

	private static bool DeleteAsset_AssetPathToDelete_IsValid;

	private static FFieldAddress DeleteAsset_AssetPathToDelete_PropertyAddress;

	private static int DeleteAsset_AssetPathToDelete_Offset;

	private static bool DeleteAsset_ReturnValue_IsValid;

	private static FFieldAddress DeleteAsset_ReturnValue_PropertyAddress;

	private static int DeleteAsset_ReturnValue_Offset;

	private static bool ConsolidateAssets_IsValid;

	private static IntPtr ConsolidateAssets_FunctionAddress;

	private static int ConsolidateAssets_ParamsSize;

	private static bool ConsolidateAssets_AssetToConsolidateTo_IsValid;

	private static FFieldAddress ConsolidateAssets_AssetToConsolidateTo_PropertyAddress;

	private static int ConsolidateAssets_AssetToConsolidateTo_Offset;

	private static bool ConsolidateAssets_AssetsToConsolidate_IsValid;

	private static FFieldAddress ConsolidateAssets_AssetsToConsolidate_PropertyAddress;

	private static int ConsolidateAssets_AssetsToConsolidate_Offset;

	private static bool ConsolidateAssets_ReturnValue_IsValid;

	private static FFieldAddress ConsolidateAssets_ReturnValue_PropertyAddress;

	private static int ConsolidateAssets_ReturnValue_Offset;

	private static bool CheckoutLoadedAssets_IsValid;

	private static IntPtr CheckoutLoadedAssets_FunctionAddress;

	private static int CheckoutLoadedAssets_ParamsSize;

	private static bool CheckoutLoadedAssets_AssetsToCheckout_IsValid;

	private static FFieldAddress CheckoutLoadedAssets_AssetsToCheckout_PropertyAddress;

	private static int CheckoutLoadedAssets_AssetsToCheckout_Offset;

	private static bool CheckoutLoadedAssets_ReturnValue_IsValid;

	private static FFieldAddress CheckoutLoadedAssets_ReturnValue_PropertyAddress;

	private static int CheckoutLoadedAssets_ReturnValue_Offset;

	private static bool CheckoutLoadedAsset_IsValid;

	private static IntPtr CheckoutLoadedAsset_FunctionAddress;

	private static int CheckoutLoadedAsset_ParamsSize;

	private static bool CheckoutLoadedAsset_AssetToCheckout_IsValid;

	private static FFieldAddress CheckoutLoadedAsset_AssetToCheckout_PropertyAddress;

	private static int CheckoutLoadedAsset_AssetToCheckout_Offset;

	private static bool CheckoutLoadedAsset_ReturnValue_IsValid;

	private static FFieldAddress CheckoutLoadedAsset_ReturnValue_PropertyAddress;

	private static int CheckoutLoadedAsset_ReturnValue_Offset;

	private static bool CheckoutDirectory_IsValid;

	private static IntPtr CheckoutDirectory_FunctionAddress;

	private static int CheckoutDirectory_ParamsSize;

	private static bool CheckoutDirectory_DirectoryPath_IsValid;

	private static FFieldAddress CheckoutDirectory_DirectoryPath_PropertyAddress;

	private static int CheckoutDirectory_DirectoryPath_Offset;

	private static bool CheckoutDirectory_bRecursive_IsValid;

	private static FFieldAddress CheckoutDirectory_bRecursive_PropertyAddress;

	private static int CheckoutDirectory_bRecursive_Offset;

	private static bool CheckoutDirectory_ReturnValue_IsValid;

	private static FFieldAddress CheckoutDirectory_ReturnValue_PropertyAddress;

	private static int CheckoutDirectory_ReturnValue_Offset;

	private static bool CheckoutAsset_IsValid;

	private static IntPtr CheckoutAsset_FunctionAddress;

	private static int CheckoutAsset_ParamsSize;

	private static bool CheckoutAsset_AssetToCheckout_IsValid;

	private static FFieldAddress CheckoutAsset_AssetToCheckout_PropertyAddress;

	private static int CheckoutAsset_AssetToCheckout_Offset;

	private static bool CheckoutAsset_ReturnValue_IsValid;

	private static FFieldAddress CheckoutAsset_ReturnValue_PropertyAddress;

	private static int CheckoutAsset_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:SyncBrowserToObjects")]
	public unsafe static void SyncBrowserToObjects(List<string> AssetPaths)
	{
		if (!SyncBrowserToObjects_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:SyncBrowserToObjects");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SyncBrowserToObjects_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SyncBrowserToObjects_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, SyncBrowserToObjects_AssetPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SyncBrowserToObjects_AssetPaths_Offset), AssetPaths);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SyncBrowserToObjects_FunctionAddress, intPtr, SyncBrowserToObjects_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SyncBrowserToObjects_AssetPaths_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:SetMetadataTag")]
	public unsafe static void SetMetadataTag(UObject Object, FName Tag, string Value)
	{
		if (!SetMetadataTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:SetMetadataTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMetadataTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMetadataTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetMetadataTag_Object_Offset), 0, SetMetadataTag_Object_PropertyAddress.Address, Object);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetMetadataTag_Tag_Offset), 0, SetMetadataTag_Tag_PropertyAddress.Address, Tag);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetMetadataTag_Value_Offset), 0, SetMetadataTag_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMetadataTag_FunctionAddress, intPtr, SetMetadataTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMetadataTag_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveLoadedAssets")]
	public unsafe static bool SaveLoadedAssets(List<UObject> AssetsToSave, bool bOnlyIfIsDirty = true)
	{
		if (!SaveLoadedAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveLoadedAssets");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveLoadedAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveLoadedAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, SaveLoadedAssets_AssetsToSave_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, SaveLoadedAssets_AssetsToSave_Offset), AssetsToSave);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SaveLoadedAssets_bOnlyIfIsDirty_Offset), 0, SaveLoadedAssets_bOnlyIfIsDirty_PropertyAddress.Address, bOnlyIfIsDirty);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveLoadedAssets_FunctionAddress, intPtr, SaveLoadedAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveLoadedAssets_AssetsToSave_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SaveLoadedAssets_ReturnValue_Offset), 0, SaveLoadedAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveLoadedAsset")]
	public unsafe static bool SaveLoadedAsset(UObject AssetToSave, bool bOnlyIfIsDirty = true)
	{
		if (!SaveLoadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveLoadedAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveLoadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveLoadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SaveLoadedAsset_AssetToSave_Offset), 0, SaveLoadedAsset_AssetToSave_PropertyAddress.Address, AssetToSave);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SaveLoadedAsset_bOnlyIfIsDirty_Offset), 0, SaveLoadedAsset_bOnlyIfIsDirty_PropertyAddress.Address, bOnlyIfIsDirty);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveLoadedAsset_FunctionAddress, intPtr, SaveLoadedAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SaveLoadedAsset_ReturnValue_Offset), 0, SaveLoadedAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveDirectory")]
	public unsafe static bool SaveDirectory(string DirectoryPath, bool bOnlyIfIsDirty = true, bool bRecursive = true)
	{
		if (!SaveDirectory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveDirectory");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveDirectory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveDirectory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveDirectory_DirectoryPath_Offset), 0, SaveDirectory_DirectoryPath_PropertyAddress.Address, DirectoryPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SaveDirectory_bOnlyIfIsDirty_Offset), 0, SaveDirectory_bOnlyIfIsDirty_PropertyAddress.Address, bOnlyIfIsDirty);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SaveDirectory_bRecursive_Offset), 0, SaveDirectory_bRecursive_PropertyAddress.Address, bRecursive);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveDirectory_FunctionAddress, intPtr, SaveDirectory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveDirectory_DirectoryPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SaveDirectory_ReturnValue_Offset), 0, SaveDirectory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveAsset")]
	public unsafe static bool SaveAsset(string AssetToSave, bool bOnlyIfIsDirty = true)
	{
		if (!SaveAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SaveAsset_AssetToSave_Offset), 0, SaveAsset_AssetToSave_PropertyAddress.Address, AssetToSave);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SaveAsset_bOnlyIfIsDirty_Offset), 0, SaveAsset_bOnlyIfIsDirty_PropertyAddress.Address, bOnlyIfIsDirty);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveAsset_FunctionAddress, intPtr, SaveAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SaveAsset_AssetToSave_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SaveAsset_ReturnValue_Offset), 0, SaveAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:RenameLoadedAsset")]
	public unsafe static bool RenameLoadedAsset(UObject SourceAsset, string DestinationAssetPath)
	{
		if (!RenameLoadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:RenameLoadedAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameLoadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameLoadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RenameLoadedAsset_SourceAsset_Offset), 0, RenameLoadedAsset_SourceAsset_PropertyAddress.Address, SourceAsset);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RenameLoadedAsset_DestinationAssetPath_Offset), 0, RenameLoadedAsset_DestinationAssetPath_PropertyAddress.Address, DestinationAssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenameLoadedAsset_FunctionAddress, intPtr, RenameLoadedAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RenameLoadedAsset_DestinationAssetPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameLoadedAsset_ReturnValue_Offset), 0, RenameLoadedAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:RenameDirectory")]
	public unsafe static bool RenameDirectory(string SourceDirectoryPath, string DestinationDirectoryPath)
	{
		if (!RenameDirectory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:RenameDirectory");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameDirectory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameDirectory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RenameDirectory_SourceDirectoryPath_Offset), 0, RenameDirectory_SourceDirectoryPath_PropertyAddress.Address, SourceDirectoryPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RenameDirectory_DestinationDirectoryPath_Offset), 0, RenameDirectory_DestinationDirectoryPath_PropertyAddress.Address, DestinationDirectoryPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenameDirectory_FunctionAddress, intPtr, RenameDirectory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RenameDirectory_SourceDirectoryPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RenameDirectory_DestinationDirectoryPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameDirectory_ReturnValue_Offset), 0, RenameDirectory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:RenameAsset")]
	public unsafe static bool RenameAsset(string SourceAssetPath, string DestinationAssetPath)
	{
		if (!RenameAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:RenameAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RenameAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RenameAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RenameAsset_SourceAssetPath_Offset), 0, RenameAsset_SourceAssetPath_PropertyAddress.Address, SourceAssetPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RenameAsset_DestinationAssetPath_Offset), 0, RenameAsset_DestinationAssetPath_PropertyAddress.Address, DestinationAssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RenameAsset_FunctionAddress, intPtr, RenameAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RenameAsset_SourceAssetPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RenameAsset_DestinationAssetPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RenameAsset_ReturnValue_Offset), 0, RenameAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:RemoveMetadataTag")]
	public unsafe static void RemoveMetadataTag(UObject Object, FName Tag)
	{
		if (!RemoveMetadataTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:RemoveMetadataTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveMetadataTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveMetadataTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveMetadataTag_Object_Offset), 0, RemoveMetadataTag_Object_PropertyAddress.Address, Object);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveMetadataTag_Tag_Offset), 0, RemoveMetadataTag_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveMetadataTag_FunctionAddress, intPtr, RemoveMetadataTag_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:MakeDirectory")]
	public unsafe static bool MakeDirectory(string DirectoryPath)
	{
		if (!MakeDirectory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:MakeDirectory");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeDirectory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeDirectory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MakeDirectory_DirectoryPath_Offset), 0, MakeDirectory_DirectoryPath_PropertyAddress.Address, DirectoryPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MakeDirectory_FunctionAddress, intPtr, MakeDirectory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MakeDirectory_DirectoryPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MakeDirectory_ReturnValue_Offset), 0, MakeDirectory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:LoadBlueprintClass")]
	public unsafe static TSubclassOf<UObject> LoadBlueprintClass(string AssetPath)
	{
		if (!LoadBlueprintClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:LoadBlueprintClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadBlueprintClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadBlueprintClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadBlueprintClass_AssetPath_Offset), 0, LoadBlueprintClass_AssetPath_PropertyAddress.Address, AssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadBlueprintClass_FunctionAddress, intPtr, LoadBlueprintClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadBlueprintClass_AssetPath_PropertyAddress.Address, intPtr);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, LoadBlueprintClass_ReturnValue_Offset), 0, LoadBlueprintClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:LoadAsset")]
	public unsafe static UObject LoadAsset(string AssetPath)
	{
		if (!LoadAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:LoadAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadAsset_AssetPath_Offset), 0, LoadAsset_AssetPath_PropertyAddress.Address, AssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadAsset_FunctionAddress, intPtr, LoadAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadAsset_AssetPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, LoadAsset_ReturnValue_Offset), 0, LoadAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:ListAssets")]
	public unsafe static List<string> ListAssets(string DirectoryPath, bool bRecursive = true, bool bIncludeFolder = false)
	{
		if (!ListAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:ListAssets");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ListAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ListAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ListAssets_DirectoryPath_Offset), 0, ListAssets_DirectoryPath_PropertyAddress.Address, DirectoryPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ListAssets_bRecursive_Offset), 0, ListAssets_bRecursive_PropertyAddress.Address, bRecursive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ListAssets_bIncludeFolder_Offset), 0, ListAssets_bIncludeFolder_PropertyAddress.Address, bIncludeFolder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ListAssets_FunctionAddress, intPtr, ListAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ListAssets_DirectoryPath_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, ListAssets_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, ListAssets_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ListAssets_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:ListAssetByTagValue")]
	public unsafe static List<string> ListAssetByTagValue(FName TagName, string TagValue)
	{
		if (!ListAssetByTagValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:ListAssetByTagValue");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ListAssetByTagValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ListAssetByTagValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ListAssetByTagValue_TagName_Offset), 0, ListAssetByTagValue_TagName_PropertyAddress.Address, TagName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ListAssetByTagValue_TagValue_Offset), 0, ListAssetByTagValue_TagValue_PropertyAddress.Address, TagValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ListAssetByTagValue_FunctionAddress, intPtr, ListAssetByTagValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ListAssetByTagValue_TagValue_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, ListAssetByTagValue_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, ListAssetByTagValue_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(ListAssetByTagValue_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetTagValues")]
	public unsafe static Dictionary<FName, string> GetTagValues(string AssetPath)
	{
		if (!GetTagValues_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetTagValues");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTagValues_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTagValues_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetTagValues_AssetPath_Offset), 0, GetTagValues_AssetPath_PropertyAddress.Address, AssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTagValues_FunctionAddress, intPtr, GetTagValues_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetTagValues_AssetPath_PropertyAddress.Address, intPtr);
		Dictionary<FName, string> result = new TMapCopyMarshaler<FName, string>(1, GetTagValues_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetTagValues_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetTagValues_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetPathNameForLoadedAsset")]
	public unsafe static string GetPathNameForLoadedAsset(UObject LoadedAsset)
	{
		if (!GetPathNameForLoadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetPathNameForLoadedAsset");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPathNameForLoadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPathNameForLoadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetPathNameForLoadedAsset_LoadedAsset_Offset), 0, GetPathNameForLoadedAsset_LoadedAsset_PropertyAddress.Address, LoadedAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPathNameForLoadedAsset_FunctionAddress, intPtr, GetPathNameForLoadedAsset_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPathNameForLoadedAsset_ReturnValue_Offset), 0, GetPathNameForLoadedAsset_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPathNameForLoadedAsset_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetMetadataTagValues")]
	public unsafe static Dictionary<FName, string> GetMetadataTagValues(UObject Object)
	{
		if (!GetMetadataTagValues_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetMetadataTagValues");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMetadataTagValues_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMetadataTagValues_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetMetadataTagValues_Object_Offset), 0, GetMetadataTagValues_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMetadataTagValues_FunctionAddress, intPtr, GetMetadataTagValues_ParamsSize);
		Dictionary<FName, string> result = new TMapCopyMarshaler<FName, string>(1, GetMetadataTagValues_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetMetadataTagValues_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMetadataTagValues_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetMetadataTag")]
	public unsafe static string GetMetadataTag(UObject Object, FName Tag)
	{
		if (!GetMetadataTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetMetadataTag");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMetadataTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMetadataTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetMetadataTag_Object_Offset), 0, GetMetadataTag_Object_PropertyAddress.Address, Object);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetMetadataTag_Tag_Offset), 0, GetMetadataTag_Tag_PropertyAddress.Address, Tag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMetadataTag_FunctionAddress, intPtr, GetMetadataTag_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetMetadataTag_ReturnValue_Offset), 0, GetMetadataTag_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMetadataTag_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:FindPackageReferencersForAsset")]
	public unsafe static List<string> FindPackageReferencersForAsset(string AssetPath, bool bLoadAssetsToConfirm = false)
	{
		if (!FindPackageReferencersForAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:FindPackageReferencersForAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPackageReferencersForAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPackageReferencersForAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindPackageReferencersForAsset_AssetPath_Offset), 0, FindPackageReferencersForAsset_AssetPath_PropertyAddress.Address, AssetPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindPackageReferencersForAsset_bLoadAssetsToConfirm_Offset), 0, FindPackageReferencersForAsset_bLoadAssetsToConfirm_PropertyAddress.Address, bLoadAssetsToConfirm);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindPackageReferencersForAsset_FunctionAddress, intPtr, FindPackageReferencersForAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindPackageReferencersForAsset_AssetPath_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, FindPackageReferencersForAsset_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, FindPackageReferencersForAsset_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindPackageReferencersForAsset_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:FindAssetData")]
	public unsafe static FAssetData FindAssetData(string AssetPath)
	{
		if (!FindAssetData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:FindAssetData");
			return default(FAssetData);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindAssetData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindAssetData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FindAssetData_AssetPath_Offset), 0, FindAssetData_AssetPath_PropertyAddress.Address, AssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindAssetData_FunctionAddress, intPtr, FindAssetData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindAssetData_AssetPath_PropertyAddress.Address, intPtr);
		FAssetData result = FAssetData.FromNative(IntPtr.Add(intPtr, FindAssetData_ReturnValue_Offset), 0, FindAssetData_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FindAssetData_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DuplicateLoadedAsset")]
	public unsafe static UObject DuplicateLoadedAsset(UObject SourceAsset, string DestinationAssetPath)
	{
		if (!DuplicateLoadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DuplicateLoadedAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateLoadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateLoadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DuplicateLoadedAsset_SourceAsset_Offset), 0, DuplicateLoadedAsset_SourceAsset_PropertyAddress.Address, SourceAsset);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateLoadedAsset_DestinationAssetPath_Offset), 0, DuplicateLoadedAsset_DestinationAssetPath_PropertyAddress.Address, DestinationAssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateLoadedAsset_FunctionAddress, intPtr, DuplicateLoadedAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateLoadedAsset_DestinationAssetPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, DuplicateLoadedAsset_ReturnValue_Offset), 0, DuplicateLoadedAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DuplicateDirectory")]
	public unsafe static bool DuplicateDirectory(string SourceDirectoryPath, string DestinationDirectoryPath)
	{
		if (!DuplicateDirectory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DuplicateDirectory");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateDirectory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateDirectory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateDirectory_SourceDirectoryPath_Offset), 0, DuplicateDirectory_SourceDirectoryPath_PropertyAddress.Address, SourceDirectoryPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateDirectory_DestinationDirectoryPath_Offset), 0, DuplicateDirectory_DestinationDirectoryPath_PropertyAddress.Address, DestinationDirectoryPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateDirectory_FunctionAddress, intPtr, DuplicateDirectory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateDirectory_SourceDirectoryPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateDirectory_DestinationDirectoryPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DuplicateDirectory_ReturnValue_Offset), 0, DuplicateDirectory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DuplicateAsset")]
	public unsafe static UObject DuplicateAsset(string SourceAssetPath, string DestinationAssetPath)
	{
		if (!DuplicateAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DuplicateAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DuplicateAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DuplicateAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAsset_SourceAssetPath_Offset), 0, DuplicateAsset_SourceAssetPath_PropertyAddress.Address, SourceAssetPath);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DuplicateAsset_DestinationAssetPath_Offset), 0, DuplicateAsset_DestinationAssetPath_PropertyAddress.Address, DestinationAssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DuplicateAsset_FunctionAddress, intPtr, DuplicateAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DuplicateAsset_SourceAssetPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(DuplicateAsset_DestinationAssetPath_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, DuplicateAsset_ReturnValue_Offset), 0, DuplicateAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoesDirectoryHaveAssets")]
	public unsafe static bool DoesDirectoryHaveAssets(string DirectoryPath, bool bRecursive = true)
	{
		if (!DoesDirectoryHaveAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoesDirectoryHaveAssets");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesDirectoryHaveAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesDirectoryHaveAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DoesDirectoryHaveAssets_DirectoryPath_Offset), 0, DoesDirectoryHaveAssets_DirectoryPath_PropertyAddress.Address, DirectoryPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, DoesDirectoryHaveAssets_bRecursive_Offset), 0, DoesDirectoryHaveAssets_bRecursive_PropertyAddress.Address, bRecursive);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DoesDirectoryHaveAssets_FunctionAddress, intPtr, DoesDirectoryHaveAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoesDirectoryHaveAssets_DirectoryPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesDirectoryHaveAssets_ReturnValue_Offset), 0, DoesDirectoryHaveAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoesDirectoryExist")]
	public unsafe static bool DoesDirectoryExist(string DirectoryPath)
	{
		if (!DoesDirectoryExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoesDirectoryExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesDirectoryExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesDirectoryExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DoesDirectoryExist_DirectoryPath_Offset), 0, DoesDirectoryExist_DirectoryPath_PropertyAddress.Address, DirectoryPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DoesDirectoryExist_FunctionAddress, intPtr, DoesDirectoryExist_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoesDirectoryExist_DirectoryPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesDirectoryExist_ReturnValue_Offset), 0, DoesDirectoryExist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoesAssetExist")]
	public unsafe static bool DoesAssetExist(string AssetPath)
	{
		if (!DoesAssetExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoesAssetExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesAssetExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesAssetExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DoesAssetExist_AssetPath_Offset), 0, DoesAssetExist_AssetPath_PropertyAddress.Address, AssetPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DoesAssetExist_FunctionAddress, intPtr, DoesAssetExist_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoesAssetExist_AssetPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesAssetExist_ReturnValue_Offset), 0, DoesAssetExist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoAssetsExist")]
	public unsafe static bool DoAssetsExist(List<string> AssetPaths)
	{
		if (!DoAssetsExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoAssetsExist");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoAssetsExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoAssetsExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, DoAssetsExist_AssetPaths_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, DoAssetsExist_AssetPaths_Offset), AssetPaths);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DoAssetsExist_FunctionAddress, intPtr, DoAssetsExist_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DoAssetsExist_AssetPaths_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoAssetsExist_ReturnValue_Offset), 0, DoAssetsExist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteLoadedAssets")]
	public unsafe static bool DeleteLoadedAssets(List<UObject> AssetsToDelete)
	{
		if (!DeleteLoadedAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteLoadedAssets");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteLoadedAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteLoadedAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, DeleteLoadedAssets_AssetsToDelete_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, DeleteLoadedAssets_AssetsToDelete_Offset), AssetsToDelete);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteLoadedAssets_FunctionAddress, intPtr, DeleteLoadedAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteLoadedAssets_AssetsToDelete_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeleteLoadedAssets_ReturnValue_Offset), 0, DeleteLoadedAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteLoadedAsset")]
	public unsafe static bool DeleteLoadedAsset(UObject AssetToDelete)
	{
		if (!DeleteLoadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteLoadedAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteLoadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteLoadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DeleteLoadedAsset_AssetToDelete_Offset), 0, DeleteLoadedAsset_AssetToDelete_PropertyAddress.Address, AssetToDelete);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteLoadedAsset_FunctionAddress, intPtr, DeleteLoadedAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeleteLoadedAsset_ReturnValue_Offset), 0, DeleteLoadedAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteDirectory")]
	public unsafe static bool DeleteDirectory(string DirectoryPath)
	{
		if (!DeleteDirectory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteDirectory");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteDirectory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteDirectory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DeleteDirectory_DirectoryPath_Offset), 0, DeleteDirectory_DirectoryPath_PropertyAddress.Address, DirectoryPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteDirectory_FunctionAddress, intPtr, DeleteDirectory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteDirectory_DirectoryPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeleteDirectory_ReturnValue_Offset), 0, DeleteDirectory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteAsset")]
	public unsafe static bool DeleteAsset(string AssetPathToDelete)
	{
		if (!DeleteAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DeleteAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DeleteAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DeleteAsset_AssetPathToDelete_Offset), 0, DeleteAsset_AssetPathToDelete_PropertyAddress.Address, AssetPathToDelete);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DeleteAsset_FunctionAddress, intPtr, DeleteAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DeleteAsset_AssetPathToDelete_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DeleteAsset_ReturnValue_Offset), 0, DeleteAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:ConsolidateAssets")]
	public unsafe static bool ConsolidateAssets(UObject AssetToConsolidateTo, List<UObject> AssetsToConsolidate)
	{
		if (!ConsolidateAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:ConsolidateAssets");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConsolidateAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConsolidateAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ConsolidateAssets_AssetToConsolidateTo_Offset), 0, ConsolidateAssets_AssetToConsolidateTo_PropertyAddress.Address, AssetToConsolidateTo);
		new TArrayCopyMarshaler<UObject>(1, ConsolidateAssets_AssetsToConsolidate_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, ConsolidateAssets_AssetsToConsolidate_Offset), AssetsToConsolidate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConsolidateAssets_FunctionAddress, intPtr, ConsolidateAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConsolidateAssets_AssetsToConsolidate_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ConsolidateAssets_ReturnValue_Offset), 0, ConsolidateAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutLoadedAssets")]
	public unsafe static bool CheckoutLoadedAssets(List<UObject> AssetsToCheckout)
	{
		if (!CheckoutLoadedAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutLoadedAssets");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckoutLoadedAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckoutLoadedAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UObject>(1, CheckoutLoadedAssets_AssetsToCheckout_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, CheckoutLoadedAssets_AssetsToCheckout_Offset), AssetsToCheckout);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckoutLoadedAssets_FunctionAddress, intPtr, CheckoutLoadedAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckoutLoadedAssets_AssetsToCheckout_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckoutLoadedAssets_ReturnValue_Offset), 0, CheckoutLoadedAssets_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutLoadedAsset")]
	public unsafe static bool CheckoutLoadedAsset(UObject AssetToCheckout)
	{
		if (!CheckoutLoadedAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutLoadedAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckoutLoadedAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckoutLoadedAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CheckoutLoadedAsset_AssetToCheckout_Offset), 0, CheckoutLoadedAsset_AssetToCheckout_PropertyAddress.Address, AssetToCheckout);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckoutLoadedAsset_FunctionAddress, intPtr, CheckoutLoadedAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckoutLoadedAsset_ReturnValue_Offset), 0, CheckoutLoadedAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutDirectory")]
	public unsafe static bool CheckoutDirectory(string DirectoryPath, bool bRecursive = true)
	{
		if (!CheckoutDirectory_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutDirectory");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckoutDirectory_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckoutDirectory_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckoutDirectory_DirectoryPath_Offset), 0, CheckoutDirectory_DirectoryPath_PropertyAddress.Address, DirectoryPath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CheckoutDirectory_bRecursive_Offset), 0, CheckoutDirectory_bRecursive_PropertyAddress.Address, bRecursive);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckoutDirectory_FunctionAddress, intPtr, CheckoutDirectory_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckoutDirectory_DirectoryPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckoutDirectory_ReturnValue_Offset), 0, CheckoutDirectory_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutAsset")]
	public unsafe static bool CheckoutAsset(string AssetToCheckout)
	{
		if (!CheckoutAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckoutAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckoutAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckoutAsset_AssetToCheckout_Offset), 0, CheckoutAsset_AssetToCheckout_PropertyAddress.Address, AssetToCheckout);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckoutAsset_FunctionAddress, intPtr, CheckoutAsset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckoutAsset_AssetToCheckout_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckoutAsset_ReturnValue_Offset), 0, CheckoutAsset_ReturnValue_PropertyAddress.Address);
	}

	static UEditorAssetLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorAssetLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorAssetLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/EditorScriptingUtilities.EditorAssetLibrary");
		SyncBrowserToObjects_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SyncBrowserToObjects");
		SyncBrowserToObjects_ParamsSize = NativeReflection.GetFunctionParamsSize(SyncBrowserToObjects_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SyncBrowserToObjects_AssetPaths_PropertyAddress, SyncBrowserToObjects_FunctionAddress, "AssetPaths");
		SyncBrowserToObjects_AssetPaths_Offset = NativeReflectionCached.GetPropertyOffset(SyncBrowserToObjects_FunctionAddress, "AssetPaths");
		SyncBrowserToObjects_AssetPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(SyncBrowserToObjects_FunctionAddress, "AssetPaths", Classes.FArrayProperty);
		SyncBrowserToObjects_IsValid = SyncBrowserToObjects_FunctionAddress != IntPtr.Zero && SyncBrowserToObjects_AssetPaths_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:SyncBrowserToObjects", SyncBrowserToObjects_IsValid);
		SetMetadataTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMetadataTag");
		SetMetadataTag_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMetadataTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMetadataTag_Object_PropertyAddress, SetMetadataTag_FunctionAddress, "Object");
		SetMetadataTag_Object_Offset = NativeReflectionCached.GetPropertyOffset(SetMetadataTag_FunctionAddress, "Object");
		SetMetadataTag_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetadataTag_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMetadataTag_Tag_PropertyAddress, SetMetadataTag_FunctionAddress, "Tag");
		SetMetadataTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(SetMetadataTag_FunctionAddress, "Tag");
		SetMetadataTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetadataTag_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetMetadataTag_Value_PropertyAddress, SetMetadataTag_FunctionAddress, "Value");
		SetMetadataTag_Value_Offset = NativeReflectionCached.GetPropertyOffset(SetMetadataTag_FunctionAddress, "Value");
		SetMetadataTag_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMetadataTag_FunctionAddress, "Value", Classes.FStrProperty);
		SetMetadataTag_IsValid = SetMetadataTag_FunctionAddress != IntPtr.Zero && SetMetadataTag_Object_IsValid && SetMetadataTag_Tag_IsValid && SetMetadataTag_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:SetMetadataTag", SetMetadataTag_IsValid);
		SaveLoadedAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveLoadedAssets");
		SaveLoadedAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveLoadedAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveLoadedAssets_AssetsToSave_PropertyAddress, SaveLoadedAssets_FunctionAddress, "AssetsToSave");
		SaveLoadedAssets_AssetsToSave_Offset = NativeReflectionCached.GetPropertyOffset(SaveLoadedAssets_FunctionAddress, "AssetsToSave");
		SaveLoadedAssets_AssetsToSave_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLoadedAssets_FunctionAddress, "AssetsToSave", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLoadedAssets_bOnlyIfIsDirty_PropertyAddress, SaveLoadedAssets_FunctionAddress, "bOnlyIfIsDirty");
		SaveLoadedAssets_bOnlyIfIsDirty_Offset = NativeReflectionCached.GetPropertyOffset(SaveLoadedAssets_FunctionAddress, "bOnlyIfIsDirty");
		SaveLoadedAssets_bOnlyIfIsDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLoadedAssets_FunctionAddress, "bOnlyIfIsDirty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLoadedAssets_ReturnValue_PropertyAddress, SaveLoadedAssets_FunctionAddress, "ReturnValue");
		SaveLoadedAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveLoadedAssets_FunctionAddress, "ReturnValue");
		SaveLoadedAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLoadedAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SaveLoadedAssets_IsValid = SaveLoadedAssets_FunctionAddress != IntPtr.Zero && SaveLoadedAssets_AssetsToSave_IsValid && SaveLoadedAssets_bOnlyIfIsDirty_IsValid && SaveLoadedAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveLoadedAssets", SaveLoadedAssets_IsValid);
		SaveLoadedAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveLoadedAsset");
		SaveLoadedAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveLoadedAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveLoadedAsset_AssetToSave_PropertyAddress, SaveLoadedAsset_FunctionAddress, "AssetToSave");
		SaveLoadedAsset_AssetToSave_Offset = NativeReflectionCached.GetPropertyOffset(SaveLoadedAsset_FunctionAddress, "AssetToSave");
		SaveLoadedAsset_AssetToSave_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLoadedAsset_FunctionAddress, "AssetToSave", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLoadedAsset_bOnlyIfIsDirty_PropertyAddress, SaveLoadedAsset_FunctionAddress, "bOnlyIfIsDirty");
		SaveLoadedAsset_bOnlyIfIsDirty_Offset = NativeReflectionCached.GetPropertyOffset(SaveLoadedAsset_FunctionAddress, "bOnlyIfIsDirty");
		SaveLoadedAsset_bOnlyIfIsDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLoadedAsset_FunctionAddress, "bOnlyIfIsDirty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveLoadedAsset_ReturnValue_PropertyAddress, SaveLoadedAsset_FunctionAddress, "ReturnValue");
		SaveLoadedAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveLoadedAsset_FunctionAddress, "ReturnValue");
		SaveLoadedAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveLoadedAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SaveLoadedAsset_IsValid = SaveLoadedAsset_FunctionAddress != IntPtr.Zero && SaveLoadedAsset_AssetToSave_IsValid && SaveLoadedAsset_bOnlyIfIsDirty_IsValid && SaveLoadedAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveLoadedAsset", SaveLoadedAsset_IsValid);
		SaveDirectory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveDirectory");
		SaveDirectory_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveDirectory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveDirectory_DirectoryPath_PropertyAddress, SaveDirectory_FunctionAddress, "DirectoryPath");
		SaveDirectory_DirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(SaveDirectory_FunctionAddress, "DirectoryPath");
		SaveDirectory_DirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveDirectory_FunctionAddress, "DirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveDirectory_bOnlyIfIsDirty_PropertyAddress, SaveDirectory_FunctionAddress, "bOnlyIfIsDirty");
		SaveDirectory_bOnlyIfIsDirty_Offset = NativeReflectionCached.GetPropertyOffset(SaveDirectory_FunctionAddress, "bOnlyIfIsDirty");
		SaveDirectory_bOnlyIfIsDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveDirectory_FunctionAddress, "bOnlyIfIsDirty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveDirectory_bRecursive_PropertyAddress, SaveDirectory_FunctionAddress, "bRecursive");
		SaveDirectory_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(SaveDirectory_FunctionAddress, "bRecursive");
		SaveDirectory_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveDirectory_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveDirectory_ReturnValue_PropertyAddress, SaveDirectory_FunctionAddress, "ReturnValue");
		SaveDirectory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveDirectory_FunctionAddress, "ReturnValue");
		SaveDirectory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveDirectory_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SaveDirectory_IsValid = SaveDirectory_FunctionAddress != IntPtr.Zero && SaveDirectory_DirectoryPath_IsValid && SaveDirectory_bOnlyIfIsDirty_IsValid && SaveDirectory_bRecursive_IsValid && SaveDirectory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveDirectory", SaveDirectory_IsValid);
		SaveAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveAsset");
		SaveAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveAsset_AssetToSave_PropertyAddress, SaveAsset_FunctionAddress, "AssetToSave");
		SaveAsset_AssetToSave_Offset = NativeReflectionCached.GetPropertyOffset(SaveAsset_FunctionAddress, "AssetToSave");
		SaveAsset_AssetToSave_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAsset_FunctionAddress, "AssetToSave", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveAsset_bOnlyIfIsDirty_PropertyAddress, SaveAsset_FunctionAddress, "bOnlyIfIsDirty");
		SaveAsset_bOnlyIfIsDirty_Offset = NativeReflectionCached.GetPropertyOffset(SaveAsset_FunctionAddress, "bOnlyIfIsDirty");
		SaveAsset_bOnlyIfIsDirty_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAsset_FunctionAddress, "bOnlyIfIsDirty", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SaveAsset_ReturnValue_PropertyAddress, SaveAsset_FunctionAddress, "ReturnValue");
		SaveAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SaveAsset_FunctionAddress, "ReturnValue");
		SaveAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SaveAsset_IsValid = SaveAsset_FunctionAddress != IntPtr.Zero && SaveAsset_AssetToSave_IsValid && SaveAsset_bOnlyIfIsDirty_IsValid && SaveAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:SaveAsset", SaveAsset_IsValid);
		RenameLoadedAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenameLoadedAsset");
		RenameLoadedAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameLoadedAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameLoadedAsset_SourceAsset_PropertyAddress, RenameLoadedAsset_FunctionAddress, "SourceAsset");
		RenameLoadedAsset_SourceAsset_Offset = NativeReflectionCached.GetPropertyOffset(RenameLoadedAsset_FunctionAddress, "SourceAsset");
		RenameLoadedAsset_SourceAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameLoadedAsset_FunctionAddress, "SourceAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameLoadedAsset_DestinationAssetPath_PropertyAddress, RenameLoadedAsset_FunctionAddress, "DestinationAssetPath");
		RenameLoadedAsset_DestinationAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(RenameLoadedAsset_FunctionAddress, "DestinationAssetPath");
		RenameLoadedAsset_DestinationAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameLoadedAsset_FunctionAddress, "DestinationAssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameLoadedAsset_ReturnValue_PropertyAddress, RenameLoadedAsset_FunctionAddress, "ReturnValue");
		RenameLoadedAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameLoadedAsset_FunctionAddress, "ReturnValue");
		RenameLoadedAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameLoadedAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameLoadedAsset_IsValid = RenameLoadedAsset_FunctionAddress != IntPtr.Zero && RenameLoadedAsset_SourceAsset_IsValid && RenameLoadedAsset_DestinationAssetPath_IsValid && RenameLoadedAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:RenameLoadedAsset", RenameLoadedAsset_IsValid);
		RenameDirectory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenameDirectory");
		RenameDirectory_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameDirectory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameDirectory_SourceDirectoryPath_PropertyAddress, RenameDirectory_FunctionAddress, "SourceDirectoryPath");
		RenameDirectory_SourceDirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(RenameDirectory_FunctionAddress, "SourceDirectoryPath");
		RenameDirectory_SourceDirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameDirectory_FunctionAddress, "SourceDirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameDirectory_DestinationDirectoryPath_PropertyAddress, RenameDirectory_FunctionAddress, "DestinationDirectoryPath");
		RenameDirectory_DestinationDirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(RenameDirectory_FunctionAddress, "DestinationDirectoryPath");
		RenameDirectory_DestinationDirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameDirectory_FunctionAddress, "DestinationDirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameDirectory_ReturnValue_PropertyAddress, RenameDirectory_FunctionAddress, "ReturnValue");
		RenameDirectory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameDirectory_FunctionAddress, "ReturnValue");
		RenameDirectory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameDirectory_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameDirectory_IsValid = RenameDirectory_FunctionAddress != IntPtr.Zero && RenameDirectory_SourceDirectoryPath_IsValid && RenameDirectory_DestinationDirectoryPath_IsValid && RenameDirectory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:RenameDirectory", RenameDirectory_IsValid);
		RenameAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RenameAsset");
		RenameAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(RenameAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RenameAsset_SourceAssetPath_PropertyAddress, RenameAsset_FunctionAddress, "SourceAssetPath");
		RenameAsset_SourceAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(RenameAsset_FunctionAddress, "SourceAssetPath");
		RenameAsset_SourceAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAsset_FunctionAddress, "SourceAssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameAsset_DestinationAssetPath_PropertyAddress, RenameAsset_FunctionAddress, "DestinationAssetPath");
		RenameAsset_DestinationAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(RenameAsset_FunctionAddress, "DestinationAssetPath");
		RenameAsset_DestinationAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAsset_FunctionAddress, "DestinationAssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameAsset_ReturnValue_PropertyAddress, RenameAsset_FunctionAddress, "ReturnValue");
		RenameAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RenameAsset_FunctionAddress, "ReturnValue");
		RenameAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RenameAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RenameAsset_IsValid = RenameAsset_FunctionAddress != IntPtr.Zero && RenameAsset_SourceAssetPath_IsValid && RenameAsset_DestinationAssetPath_IsValid && RenameAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:RenameAsset", RenameAsset_IsValid);
		RemoveMetadataTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveMetadataTag");
		RemoveMetadataTag_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveMetadataTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveMetadataTag_Object_PropertyAddress, RemoveMetadataTag_FunctionAddress, "Object");
		RemoveMetadataTag_Object_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMetadataTag_FunctionAddress, "Object");
		RemoveMetadataTag_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMetadataTag_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveMetadataTag_Tag_PropertyAddress, RemoveMetadataTag_FunctionAddress, "Tag");
		RemoveMetadataTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(RemoveMetadataTag_FunctionAddress, "Tag");
		RemoveMetadataTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveMetadataTag_FunctionAddress, "Tag", Classes.FNameProperty);
		RemoveMetadataTag_IsValid = RemoveMetadataTag_FunctionAddress != IntPtr.Zero && RemoveMetadataTag_Object_IsValid && RemoveMetadataTag_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:RemoveMetadataTag", RemoveMetadataTag_IsValid);
		MakeDirectory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeDirectory");
		MakeDirectory_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeDirectory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeDirectory_DirectoryPath_PropertyAddress, MakeDirectory_FunctionAddress, "DirectoryPath");
		MakeDirectory_DirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(MakeDirectory_FunctionAddress, "DirectoryPath");
		MakeDirectory_DirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeDirectory_FunctionAddress, "DirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeDirectory_ReturnValue_PropertyAddress, MakeDirectory_FunctionAddress, "ReturnValue");
		MakeDirectory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeDirectory_FunctionAddress, "ReturnValue");
		MakeDirectory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeDirectory_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MakeDirectory_IsValid = MakeDirectory_FunctionAddress != IntPtr.Zero && MakeDirectory_DirectoryPath_IsValid && MakeDirectory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:MakeDirectory", MakeDirectory_IsValid);
		LoadBlueprintClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadBlueprintClass");
		LoadBlueprintClass_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadBlueprintClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadBlueprintClass_AssetPath_PropertyAddress, LoadBlueprintClass_FunctionAddress, "AssetPath");
		LoadBlueprintClass_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(LoadBlueprintClass_FunctionAddress, "AssetPath");
		LoadBlueprintClass_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadBlueprintClass_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadBlueprintClass_ReturnValue_PropertyAddress, LoadBlueprintClass_FunctionAddress, "ReturnValue");
		LoadBlueprintClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadBlueprintClass_FunctionAddress, "ReturnValue");
		LoadBlueprintClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadBlueprintClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		LoadBlueprintClass_IsValid = LoadBlueprintClass_FunctionAddress != IntPtr.Zero && LoadBlueprintClass_AssetPath_IsValid && LoadBlueprintClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:LoadBlueprintClass", LoadBlueprintClass_IsValid);
		LoadAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadAsset");
		LoadAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadAsset_AssetPath_PropertyAddress, LoadAsset_FunctionAddress, "AssetPath");
		LoadAsset_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(LoadAsset_FunctionAddress, "AssetPath");
		LoadAsset_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadAsset_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadAsset_ReturnValue_PropertyAddress, LoadAsset_FunctionAddress, "ReturnValue");
		LoadAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LoadAsset_FunctionAddress, "ReturnValue");
		LoadAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		LoadAsset_IsValid = LoadAsset_FunctionAddress != IntPtr.Zero && LoadAsset_AssetPath_IsValid && LoadAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:LoadAsset", LoadAsset_IsValid);
		ListAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ListAssets");
		ListAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(ListAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ListAssets_DirectoryPath_PropertyAddress, ListAssets_FunctionAddress, "DirectoryPath");
		ListAssets_DirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(ListAssets_FunctionAddress, "DirectoryPath");
		ListAssets_DirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(ListAssets_FunctionAddress, "DirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ListAssets_bRecursive_PropertyAddress, ListAssets_FunctionAddress, "bRecursive");
		ListAssets_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(ListAssets_FunctionAddress, "bRecursive");
		ListAssets_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(ListAssets_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ListAssets_bIncludeFolder_PropertyAddress, ListAssets_FunctionAddress, "bIncludeFolder");
		ListAssets_bIncludeFolder_Offset = NativeReflectionCached.GetPropertyOffset(ListAssets_FunctionAddress, "bIncludeFolder");
		ListAssets_bIncludeFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(ListAssets_FunctionAddress, "bIncludeFolder", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ListAssets_ReturnValue_PropertyAddress, ListAssets_FunctionAddress, "ReturnValue");
		ListAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ListAssets_FunctionAddress, "ReturnValue");
		ListAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ListAssets_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ListAssets_IsValid = ListAssets_FunctionAddress != IntPtr.Zero && ListAssets_DirectoryPath_IsValid && ListAssets_bRecursive_IsValid && ListAssets_bIncludeFolder_IsValid && ListAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:ListAssets", ListAssets_IsValid);
		ListAssetByTagValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ListAssetByTagValue");
		ListAssetByTagValue_ParamsSize = NativeReflection.GetFunctionParamsSize(ListAssetByTagValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ListAssetByTagValue_TagName_PropertyAddress, ListAssetByTagValue_FunctionAddress, "TagName");
		ListAssetByTagValue_TagName_Offset = NativeReflectionCached.GetPropertyOffset(ListAssetByTagValue_FunctionAddress, "TagName");
		ListAssetByTagValue_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(ListAssetByTagValue_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ListAssetByTagValue_TagValue_PropertyAddress, ListAssetByTagValue_FunctionAddress, "TagValue");
		ListAssetByTagValue_TagValue_Offset = NativeReflectionCached.GetPropertyOffset(ListAssetByTagValue_FunctionAddress, "TagValue");
		ListAssetByTagValue_TagValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ListAssetByTagValue_FunctionAddress, "TagValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ListAssetByTagValue_ReturnValue_PropertyAddress, ListAssetByTagValue_FunctionAddress, "ReturnValue");
		ListAssetByTagValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ListAssetByTagValue_FunctionAddress, "ReturnValue");
		ListAssetByTagValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ListAssetByTagValue_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		ListAssetByTagValue_IsValid = ListAssetByTagValue_FunctionAddress != IntPtr.Zero && ListAssetByTagValue_TagName_IsValid && ListAssetByTagValue_TagValue_IsValid && ListAssetByTagValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:ListAssetByTagValue", ListAssetByTagValue_IsValid);
		GetTagValues_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTagValues");
		GetTagValues_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTagValues_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTagValues_AssetPath_PropertyAddress, GetTagValues_FunctionAddress, "AssetPath");
		GetTagValues_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(GetTagValues_FunctionAddress, "AssetPath");
		GetTagValues_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagValues_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTagValues_ReturnValue_PropertyAddress, GetTagValues_FunctionAddress, "ReturnValue");
		GetTagValues_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTagValues_FunctionAddress, "ReturnValue");
		GetTagValues_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTagValues_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetTagValues_IsValid = GetTagValues_FunctionAddress != IntPtr.Zero && GetTagValues_AssetPath_IsValid && GetTagValues_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetTagValues", GetTagValues_IsValid);
		GetPathNameForLoadedAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPathNameForLoadedAsset");
		GetPathNameForLoadedAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPathNameForLoadedAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPathNameForLoadedAsset_LoadedAsset_PropertyAddress, GetPathNameForLoadedAsset_FunctionAddress, "LoadedAsset");
		GetPathNameForLoadedAsset_LoadedAsset_Offset = NativeReflectionCached.GetPropertyOffset(GetPathNameForLoadedAsset_FunctionAddress, "LoadedAsset");
		GetPathNameForLoadedAsset_LoadedAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathNameForLoadedAsset_FunctionAddress, "LoadedAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPathNameForLoadedAsset_ReturnValue_PropertyAddress, GetPathNameForLoadedAsset_FunctionAddress, "ReturnValue");
		GetPathNameForLoadedAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPathNameForLoadedAsset_FunctionAddress, "ReturnValue");
		GetPathNameForLoadedAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPathNameForLoadedAsset_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPathNameForLoadedAsset_IsValid = GetPathNameForLoadedAsset_FunctionAddress != IntPtr.Zero && GetPathNameForLoadedAsset_LoadedAsset_IsValid && GetPathNameForLoadedAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetPathNameForLoadedAsset", GetPathNameForLoadedAsset_IsValid);
		GetMetadataTagValues_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMetadataTagValues");
		GetMetadataTagValues_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMetadataTagValues_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMetadataTagValues_Object_PropertyAddress, GetMetadataTagValues_FunctionAddress, "Object");
		GetMetadataTagValues_Object_Offset = NativeReflectionCached.GetPropertyOffset(GetMetadataTagValues_FunctionAddress, "Object");
		GetMetadataTagValues_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetadataTagValues_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMetadataTagValues_ReturnValue_PropertyAddress, GetMetadataTagValues_FunctionAddress, "ReturnValue");
		GetMetadataTagValues_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMetadataTagValues_FunctionAddress, "ReturnValue");
		GetMetadataTagValues_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetadataTagValues_FunctionAddress, "ReturnValue", Classes.FMapProperty);
		GetMetadataTagValues_IsValid = GetMetadataTagValues_FunctionAddress != IntPtr.Zero && GetMetadataTagValues_Object_IsValid && GetMetadataTagValues_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetMetadataTagValues", GetMetadataTagValues_IsValid);
		GetMetadataTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMetadataTag");
		GetMetadataTag_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMetadataTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMetadataTag_Object_PropertyAddress, GetMetadataTag_FunctionAddress, "Object");
		GetMetadataTag_Object_Offset = NativeReflectionCached.GetPropertyOffset(GetMetadataTag_FunctionAddress, "Object");
		GetMetadataTag_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetadataTag_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMetadataTag_Tag_PropertyAddress, GetMetadataTag_FunctionAddress, "Tag");
		GetMetadataTag_Tag_Offset = NativeReflectionCached.GetPropertyOffset(GetMetadataTag_FunctionAddress, "Tag");
		GetMetadataTag_Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetadataTag_FunctionAddress, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMetadataTag_ReturnValue_PropertyAddress, GetMetadataTag_FunctionAddress, "ReturnValue");
		GetMetadataTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMetadataTag_FunctionAddress, "ReturnValue");
		GetMetadataTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMetadataTag_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetMetadataTag_IsValid = GetMetadataTag_FunctionAddress != IntPtr.Zero && GetMetadataTag_Object_IsValid && GetMetadataTag_Tag_IsValid && GetMetadataTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:GetMetadataTag", GetMetadataTag_IsValid);
		FindPackageReferencersForAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindPackageReferencersForAsset");
		FindPackageReferencersForAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPackageReferencersForAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPackageReferencersForAsset_AssetPath_PropertyAddress, FindPackageReferencersForAsset_FunctionAddress, "AssetPath");
		FindPackageReferencersForAsset_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(FindPackageReferencersForAsset_FunctionAddress, "AssetPath");
		FindPackageReferencersForAsset_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPackageReferencersForAsset_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPackageReferencersForAsset_bLoadAssetsToConfirm_PropertyAddress, FindPackageReferencersForAsset_FunctionAddress, "bLoadAssetsToConfirm");
		FindPackageReferencersForAsset_bLoadAssetsToConfirm_Offset = NativeReflectionCached.GetPropertyOffset(FindPackageReferencersForAsset_FunctionAddress, "bLoadAssetsToConfirm");
		FindPackageReferencersForAsset_bLoadAssetsToConfirm_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPackageReferencersForAsset_FunctionAddress, "bLoadAssetsToConfirm", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPackageReferencersForAsset_ReturnValue_PropertyAddress, FindPackageReferencersForAsset_FunctionAddress, "ReturnValue");
		FindPackageReferencersForAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPackageReferencersForAsset_FunctionAddress, "ReturnValue");
		FindPackageReferencersForAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPackageReferencersForAsset_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindPackageReferencersForAsset_IsValid = FindPackageReferencersForAsset_FunctionAddress != IntPtr.Zero && FindPackageReferencersForAsset_AssetPath_IsValid && FindPackageReferencersForAsset_bLoadAssetsToConfirm_IsValid && FindPackageReferencersForAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:FindPackageReferencersForAsset", FindPackageReferencersForAsset_IsValid);
		FindAssetData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindAssetData");
		FindAssetData_ParamsSize = NativeReflection.GetFunctionParamsSize(FindAssetData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindAssetData_AssetPath_PropertyAddress, FindAssetData_FunctionAddress, "AssetPath");
		FindAssetData_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(FindAssetData_FunctionAddress, "AssetPath");
		FindAssetData_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAssetData_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FindAssetData_ReturnValue_PropertyAddress, FindAssetData_FunctionAddress, "ReturnValue");
		FindAssetData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindAssetData_FunctionAddress, "ReturnValue");
		FindAssetData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindAssetData_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindAssetData_IsValid = FindAssetData_FunctionAddress != IntPtr.Zero && FindAssetData_AssetPath_IsValid && FindAssetData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:FindAssetData", FindAssetData_IsValid);
		DuplicateLoadedAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateLoadedAsset");
		DuplicateLoadedAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateLoadedAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateLoadedAsset_SourceAsset_PropertyAddress, DuplicateLoadedAsset_FunctionAddress, "SourceAsset");
		DuplicateLoadedAsset_SourceAsset_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateLoadedAsset_FunctionAddress, "SourceAsset");
		DuplicateLoadedAsset_SourceAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateLoadedAsset_FunctionAddress, "SourceAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateLoadedAsset_DestinationAssetPath_PropertyAddress, DuplicateLoadedAsset_FunctionAddress, "DestinationAssetPath");
		DuplicateLoadedAsset_DestinationAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateLoadedAsset_FunctionAddress, "DestinationAssetPath");
		DuplicateLoadedAsset_DestinationAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateLoadedAsset_FunctionAddress, "DestinationAssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateLoadedAsset_ReturnValue_PropertyAddress, DuplicateLoadedAsset_FunctionAddress, "ReturnValue");
		DuplicateLoadedAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateLoadedAsset_FunctionAddress, "ReturnValue");
		DuplicateLoadedAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateLoadedAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateLoadedAsset_IsValid = DuplicateLoadedAsset_FunctionAddress != IntPtr.Zero && DuplicateLoadedAsset_SourceAsset_IsValid && DuplicateLoadedAsset_DestinationAssetPath_IsValid && DuplicateLoadedAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DuplicateLoadedAsset", DuplicateLoadedAsset_IsValid);
		DuplicateDirectory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateDirectory");
		DuplicateDirectory_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateDirectory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateDirectory_SourceDirectoryPath_PropertyAddress, DuplicateDirectory_FunctionAddress, "SourceDirectoryPath");
		DuplicateDirectory_SourceDirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateDirectory_FunctionAddress, "SourceDirectoryPath");
		DuplicateDirectory_SourceDirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateDirectory_FunctionAddress, "SourceDirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateDirectory_DestinationDirectoryPath_PropertyAddress, DuplicateDirectory_FunctionAddress, "DestinationDirectoryPath");
		DuplicateDirectory_DestinationDirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateDirectory_FunctionAddress, "DestinationDirectoryPath");
		DuplicateDirectory_DestinationDirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateDirectory_FunctionAddress, "DestinationDirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateDirectory_ReturnValue_PropertyAddress, DuplicateDirectory_FunctionAddress, "ReturnValue");
		DuplicateDirectory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateDirectory_FunctionAddress, "ReturnValue");
		DuplicateDirectory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateDirectory_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DuplicateDirectory_IsValid = DuplicateDirectory_FunctionAddress != IntPtr.Zero && DuplicateDirectory_SourceDirectoryPath_IsValid && DuplicateDirectory_DestinationDirectoryPath_IsValid && DuplicateDirectory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DuplicateDirectory", DuplicateDirectory_IsValid);
		DuplicateAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DuplicateAsset");
		DuplicateAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(DuplicateAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_SourceAssetPath_PropertyAddress, DuplicateAsset_FunctionAddress, "SourceAssetPath");
		DuplicateAsset_SourceAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "SourceAssetPath");
		DuplicateAsset_SourceAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "SourceAssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_DestinationAssetPath_PropertyAddress, DuplicateAsset_FunctionAddress, "DestinationAssetPath");
		DuplicateAsset_DestinationAssetPath_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "DestinationAssetPath");
		DuplicateAsset_DestinationAssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "DestinationAssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DuplicateAsset_ReturnValue_PropertyAddress, DuplicateAsset_FunctionAddress, "ReturnValue");
		DuplicateAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DuplicateAsset_FunctionAddress, "ReturnValue");
		DuplicateAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DuplicateAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		DuplicateAsset_IsValid = DuplicateAsset_FunctionAddress != IntPtr.Zero && DuplicateAsset_SourceAssetPath_IsValid && DuplicateAsset_DestinationAssetPath_IsValid && DuplicateAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DuplicateAsset", DuplicateAsset_IsValid);
		DoesDirectoryHaveAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DoesDirectoryHaveAssets");
		DoesDirectoryHaveAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesDirectoryHaveAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesDirectoryHaveAssets_DirectoryPath_PropertyAddress, DoesDirectoryHaveAssets_FunctionAddress, "DirectoryPath");
		DoesDirectoryHaveAssets_DirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(DoesDirectoryHaveAssets_FunctionAddress, "DirectoryPath");
		DoesDirectoryHaveAssets_DirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesDirectoryHaveAssets_FunctionAddress, "DirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesDirectoryHaveAssets_bRecursive_PropertyAddress, DoesDirectoryHaveAssets_FunctionAddress, "bRecursive");
		DoesDirectoryHaveAssets_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(DoesDirectoryHaveAssets_FunctionAddress, "bRecursive");
		DoesDirectoryHaveAssets_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesDirectoryHaveAssets_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesDirectoryHaveAssets_ReturnValue_PropertyAddress, DoesDirectoryHaveAssets_FunctionAddress, "ReturnValue");
		DoesDirectoryHaveAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesDirectoryHaveAssets_FunctionAddress, "ReturnValue");
		DoesDirectoryHaveAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesDirectoryHaveAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesDirectoryHaveAssets_IsValid = DoesDirectoryHaveAssets_FunctionAddress != IntPtr.Zero && DoesDirectoryHaveAssets_DirectoryPath_IsValid && DoesDirectoryHaveAssets_bRecursive_IsValid && DoesDirectoryHaveAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoesDirectoryHaveAssets", DoesDirectoryHaveAssets_IsValid);
		DoesDirectoryExist_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DoesDirectoryExist");
		DoesDirectoryExist_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesDirectoryExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesDirectoryExist_DirectoryPath_PropertyAddress, DoesDirectoryExist_FunctionAddress, "DirectoryPath");
		DoesDirectoryExist_DirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(DoesDirectoryExist_FunctionAddress, "DirectoryPath");
		DoesDirectoryExist_DirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesDirectoryExist_FunctionAddress, "DirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesDirectoryExist_ReturnValue_PropertyAddress, DoesDirectoryExist_FunctionAddress, "ReturnValue");
		DoesDirectoryExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesDirectoryExist_FunctionAddress, "ReturnValue");
		DoesDirectoryExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesDirectoryExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesDirectoryExist_IsValid = DoesDirectoryExist_FunctionAddress != IntPtr.Zero && DoesDirectoryExist_DirectoryPath_IsValid && DoesDirectoryExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoesDirectoryExist", DoesDirectoryExist_IsValid);
		DoesAssetExist_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DoesAssetExist");
		DoesAssetExist_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesAssetExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesAssetExist_AssetPath_PropertyAddress, DoesAssetExist_FunctionAddress, "AssetPath");
		DoesAssetExist_AssetPath_Offset = NativeReflectionCached.GetPropertyOffset(DoesAssetExist_FunctionAddress, "AssetPath");
		DoesAssetExist_AssetPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesAssetExist_FunctionAddress, "AssetPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesAssetExist_ReturnValue_PropertyAddress, DoesAssetExist_FunctionAddress, "ReturnValue");
		DoesAssetExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesAssetExist_FunctionAddress, "ReturnValue");
		DoesAssetExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesAssetExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesAssetExist_IsValid = DoesAssetExist_FunctionAddress != IntPtr.Zero && DoesAssetExist_AssetPath_IsValid && DoesAssetExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoesAssetExist", DoesAssetExist_IsValid);
		DoAssetsExist_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DoAssetsExist");
		DoAssetsExist_ParamsSize = NativeReflection.GetFunctionParamsSize(DoAssetsExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoAssetsExist_AssetPaths_PropertyAddress, DoAssetsExist_FunctionAddress, "AssetPaths");
		DoAssetsExist_AssetPaths_Offset = NativeReflectionCached.GetPropertyOffset(DoAssetsExist_FunctionAddress, "AssetPaths");
		DoAssetsExist_AssetPaths_IsValid = NativeReflectionCached.ValidatePropertyClass(DoAssetsExist_FunctionAddress, "AssetPaths", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DoAssetsExist_ReturnValue_PropertyAddress, DoAssetsExist_FunctionAddress, "ReturnValue");
		DoAssetsExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoAssetsExist_FunctionAddress, "ReturnValue");
		DoAssetsExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoAssetsExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoAssetsExist_IsValid = DoAssetsExist_FunctionAddress != IntPtr.Zero && DoAssetsExist_AssetPaths_IsValid && DoAssetsExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DoAssetsExist", DoAssetsExist_IsValid);
		DeleteLoadedAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteLoadedAssets");
		DeleteLoadedAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteLoadedAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteLoadedAssets_AssetsToDelete_PropertyAddress, DeleteLoadedAssets_FunctionAddress, "AssetsToDelete");
		DeleteLoadedAssets_AssetsToDelete_Offset = NativeReflectionCached.GetPropertyOffset(DeleteLoadedAssets_FunctionAddress, "AssetsToDelete");
		DeleteLoadedAssets_AssetsToDelete_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteLoadedAssets_FunctionAddress, "AssetsToDelete", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteLoadedAssets_ReturnValue_PropertyAddress, DeleteLoadedAssets_FunctionAddress, "ReturnValue");
		DeleteLoadedAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteLoadedAssets_FunctionAddress, "ReturnValue");
		DeleteLoadedAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteLoadedAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeleteLoadedAssets_IsValid = DeleteLoadedAssets_FunctionAddress != IntPtr.Zero && DeleteLoadedAssets_AssetsToDelete_IsValid && DeleteLoadedAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteLoadedAssets", DeleteLoadedAssets_IsValid);
		DeleteLoadedAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteLoadedAsset");
		DeleteLoadedAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteLoadedAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteLoadedAsset_AssetToDelete_PropertyAddress, DeleteLoadedAsset_FunctionAddress, "AssetToDelete");
		DeleteLoadedAsset_AssetToDelete_Offset = NativeReflectionCached.GetPropertyOffset(DeleteLoadedAsset_FunctionAddress, "AssetToDelete");
		DeleteLoadedAsset_AssetToDelete_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteLoadedAsset_FunctionAddress, "AssetToDelete", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteLoadedAsset_ReturnValue_PropertyAddress, DeleteLoadedAsset_FunctionAddress, "ReturnValue");
		DeleteLoadedAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteLoadedAsset_FunctionAddress, "ReturnValue");
		DeleteLoadedAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteLoadedAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeleteLoadedAsset_IsValid = DeleteLoadedAsset_FunctionAddress != IntPtr.Zero && DeleteLoadedAsset_AssetToDelete_IsValid && DeleteLoadedAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteLoadedAsset", DeleteLoadedAsset_IsValid);
		DeleteDirectory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteDirectory");
		DeleteDirectory_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteDirectory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteDirectory_DirectoryPath_PropertyAddress, DeleteDirectory_FunctionAddress, "DirectoryPath");
		DeleteDirectory_DirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(DeleteDirectory_FunctionAddress, "DirectoryPath");
		DeleteDirectory_DirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteDirectory_FunctionAddress, "DirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteDirectory_ReturnValue_PropertyAddress, DeleteDirectory_FunctionAddress, "ReturnValue");
		DeleteDirectory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteDirectory_FunctionAddress, "ReturnValue");
		DeleteDirectory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteDirectory_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeleteDirectory_IsValid = DeleteDirectory_FunctionAddress != IntPtr.Zero && DeleteDirectory_DirectoryPath_IsValid && DeleteDirectory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteDirectory", DeleteDirectory_IsValid);
		DeleteAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DeleteAsset");
		DeleteAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(DeleteAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DeleteAsset_AssetPathToDelete_PropertyAddress, DeleteAsset_FunctionAddress, "AssetPathToDelete");
		DeleteAsset_AssetPathToDelete_Offset = NativeReflectionCached.GetPropertyOffset(DeleteAsset_FunctionAddress, "AssetPathToDelete");
		DeleteAsset_AssetPathToDelete_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteAsset_FunctionAddress, "AssetPathToDelete", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DeleteAsset_ReturnValue_PropertyAddress, DeleteAsset_FunctionAddress, "ReturnValue");
		DeleteAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DeleteAsset_FunctionAddress, "ReturnValue");
		DeleteAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DeleteAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DeleteAsset_IsValid = DeleteAsset_FunctionAddress != IntPtr.Zero && DeleteAsset_AssetPathToDelete_IsValid && DeleteAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:DeleteAsset", DeleteAsset_IsValid);
		ConsolidateAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConsolidateAssets");
		ConsolidateAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(ConsolidateAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConsolidateAssets_AssetToConsolidateTo_PropertyAddress, ConsolidateAssets_FunctionAddress, "AssetToConsolidateTo");
		ConsolidateAssets_AssetToConsolidateTo_Offset = NativeReflectionCached.GetPropertyOffset(ConsolidateAssets_FunctionAddress, "AssetToConsolidateTo");
		ConsolidateAssets_AssetToConsolidateTo_IsValid = NativeReflectionCached.ValidatePropertyClass(ConsolidateAssets_FunctionAddress, "AssetToConsolidateTo", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ConsolidateAssets_AssetsToConsolidate_PropertyAddress, ConsolidateAssets_FunctionAddress, "AssetsToConsolidate");
		ConsolidateAssets_AssetsToConsolidate_Offset = NativeReflectionCached.GetPropertyOffset(ConsolidateAssets_FunctionAddress, "AssetsToConsolidate");
		ConsolidateAssets_AssetsToConsolidate_IsValid = NativeReflectionCached.ValidatePropertyClass(ConsolidateAssets_FunctionAddress, "AssetsToConsolidate", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ConsolidateAssets_ReturnValue_PropertyAddress, ConsolidateAssets_FunctionAddress, "ReturnValue");
		ConsolidateAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConsolidateAssets_FunctionAddress, "ReturnValue");
		ConsolidateAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConsolidateAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ConsolidateAssets_IsValid = ConsolidateAssets_FunctionAddress != IntPtr.Zero && ConsolidateAssets_AssetToConsolidateTo_IsValid && ConsolidateAssets_AssetsToConsolidate_IsValid && ConsolidateAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:ConsolidateAssets", ConsolidateAssets_IsValid);
		CheckoutLoadedAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckoutLoadedAssets");
		CheckoutLoadedAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckoutLoadedAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckoutLoadedAssets_AssetsToCheckout_PropertyAddress, CheckoutLoadedAssets_FunctionAddress, "AssetsToCheckout");
		CheckoutLoadedAssets_AssetsToCheckout_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutLoadedAssets_FunctionAddress, "AssetsToCheckout");
		CheckoutLoadedAssets_AssetsToCheckout_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutLoadedAssets_FunctionAddress, "AssetsToCheckout", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutLoadedAssets_ReturnValue_PropertyAddress, CheckoutLoadedAssets_FunctionAddress, "ReturnValue");
		CheckoutLoadedAssets_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutLoadedAssets_FunctionAddress, "ReturnValue");
		CheckoutLoadedAssets_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutLoadedAssets_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckoutLoadedAssets_IsValid = CheckoutLoadedAssets_FunctionAddress != IntPtr.Zero && CheckoutLoadedAssets_AssetsToCheckout_IsValid && CheckoutLoadedAssets_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutLoadedAssets", CheckoutLoadedAssets_IsValid);
		CheckoutLoadedAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckoutLoadedAsset");
		CheckoutLoadedAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckoutLoadedAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckoutLoadedAsset_AssetToCheckout_PropertyAddress, CheckoutLoadedAsset_FunctionAddress, "AssetToCheckout");
		CheckoutLoadedAsset_AssetToCheckout_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutLoadedAsset_FunctionAddress, "AssetToCheckout");
		CheckoutLoadedAsset_AssetToCheckout_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutLoadedAsset_FunctionAddress, "AssetToCheckout", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutLoadedAsset_ReturnValue_PropertyAddress, CheckoutLoadedAsset_FunctionAddress, "ReturnValue");
		CheckoutLoadedAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutLoadedAsset_FunctionAddress, "ReturnValue");
		CheckoutLoadedAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutLoadedAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckoutLoadedAsset_IsValid = CheckoutLoadedAsset_FunctionAddress != IntPtr.Zero && CheckoutLoadedAsset_AssetToCheckout_IsValid && CheckoutLoadedAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutLoadedAsset", CheckoutLoadedAsset_IsValid);
		CheckoutDirectory_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckoutDirectory");
		CheckoutDirectory_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckoutDirectory_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckoutDirectory_DirectoryPath_PropertyAddress, CheckoutDirectory_FunctionAddress, "DirectoryPath");
		CheckoutDirectory_DirectoryPath_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutDirectory_FunctionAddress, "DirectoryPath");
		CheckoutDirectory_DirectoryPath_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutDirectory_FunctionAddress, "DirectoryPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutDirectory_bRecursive_PropertyAddress, CheckoutDirectory_FunctionAddress, "bRecursive");
		CheckoutDirectory_bRecursive_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutDirectory_FunctionAddress, "bRecursive");
		CheckoutDirectory_bRecursive_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutDirectory_FunctionAddress, "bRecursive", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutDirectory_ReturnValue_PropertyAddress, CheckoutDirectory_FunctionAddress, "ReturnValue");
		CheckoutDirectory_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutDirectory_FunctionAddress, "ReturnValue");
		CheckoutDirectory_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutDirectory_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckoutDirectory_IsValid = CheckoutDirectory_FunctionAddress != IntPtr.Zero && CheckoutDirectory_DirectoryPath_IsValid && CheckoutDirectory_bRecursive_IsValid && CheckoutDirectory_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutDirectory", CheckoutDirectory_IsValid);
		CheckoutAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckoutAsset");
		CheckoutAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckoutAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckoutAsset_AssetToCheckout_PropertyAddress, CheckoutAsset_FunctionAddress, "AssetToCheckout");
		CheckoutAsset_AssetToCheckout_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutAsset_FunctionAddress, "AssetToCheckout");
		CheckoutAsset_AssetToCheckout_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutAsset_FunctionAddress, "AssetToCheckout", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckoutAsset_ReturnValue_PropertyAddress, CheckoutAsset_FunctionAddress, "ReturnValue");
		CheckoutAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckoutAsset_FunctionAddress, "ReturnValue");
		CheckoutAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckoutAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckoutAsset_IsValid = CheckoutAsset_FunctionAddress != IntPtr.Zero && CheckoutAsset_AssetToCheckout_IsValid && CheckoutAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorAssetLibrary:CheckoutAsset", CheckoutAsset_IsValid);
	}
}
