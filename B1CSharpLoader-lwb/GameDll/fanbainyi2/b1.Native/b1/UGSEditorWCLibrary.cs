using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary", "FuncLibEditor", UnrealModuleType.Game)]
public class UGSEditorWCLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UpdateTileLevelBounds_IsValid;

	private static IntPtr UpdateTileLevelBounds_FunctionAddress;

	private static int UpdateTileLevelBounds_ParamsSize;

	private static bool UpdateTileLevelBounds_RootDirectory_IsValid;

	private static FFieldAddress UpdateTileLevelBounds_RootDirectory_PropertyAddress;

	private static int UpdateTileLevelBounds_RootDirectory_Offset;

	private static bool TriggerGenerateProxyAssets_IsValid;

	private static IntPtr TriggerGenerateProxyAssets_FunctionAddress;

	private static int TriggerGenerateProxyAssets_ParamsSize;

	private static bool TriggerGenerateProxyAssets_InPersistentLevelPath_IsValid;

	private static FFieldAddress TriggerGenerateProxyAssets_InPersistentLevelPath_PropertyAddress;

	private static int TriggerGenerateProxyAssets_InPersistentLevelPath_Offset;

	private static bool TriggerGenerateProxyAssets_InTargetLevelNameList_IsValid;

	private static FFieldAddress TriggerGenerateProxyAssets_InTargetLevelNameList_PropertyAddress;

	private static int TriggerGenerateProxyAssets_InTargetLevelNameList_Offset;

	private static bool TriggerGenerateProxyAssets_InPrecisionScaleFactor_IsValid;

	private static FFieldAddress TriggerGenerateProxyAssets_InPrecisionScaleFactor_PropertyAddress;

	private static int TriggerGenerateProxyAssets_InPrecisionScaleFactor_Offset;

	private static bool TriggerGenerateProxyAssets_bForceGenProxyMesh_IsValid;

	private static FFieldAddress TriggerGenerateProxyAssets_bForceGenProxyMesh_PropertyAddress;

	private static int TriggerGenerateProxyAssets_bForceGenProxyMesh_Offset;

	private static bool TriggerGenerateProxyAssets_InTargetLODIndex_IsValid;

	private static FFieldAddress TriggerGenerateProxyAssets_InTargetLODIndex_PropertyAddress;

	private static int TriggerGenerateProxyAssets_InTargetLODIndex_Offset;

	private static bool TriggerGenerateLandscapeLods_IsValid;

	private static IntPtr TriggerGenerateLandscapeLods_FunctionAddress;

	private static int TriggerGenerateLandscapeLods_ParamsSize;

	private static bool TriggerGenerateLandscapeLods_InPersistentLevelPath_IsValid;

	private static FFieldAddress TriggerGenerateLandscapeLods_InPersistentLevelPath_PropertyAddress;

	private static int TriggerGenerateLandscapeLods_InPersistentLevelPath_Offset;

	private static bool TriggerGenerateLandscapeLods_InTargetLevelNameList_IsValid;

	private static FFieldAddress TriggerGenerateLandscapeLods_InTargetLevelNameList_PropertyAddress;

	private static int TriggerGenerateLandscapeLods_InTargetLevelNameList_Offset;

	private static bool TriggerGenerateLandscapeLods_DelayForFullLoading_IsValid;

	private static FFieldAddress TriggerGenerateLandscapeLods_DelayForFullLoading_PropertyAddress;

	private static int TriggerGenerateLandscapeLods_DelayForFullLoading_Offset;

	private static bool TriggerGenerateLandscapeLods_bGenerateFoliageImposter_IsValid;

	private static FFieldAddress TriggerGenerateLandscapeLods_bGenerateFoliageImposter_PropertyAddress;

	private static int TriggerGenerateLandscapeLods_bGenerateFoliageImposter_Offset;

	private static bool TriggerGenerateLandscapeLods_bProcessGridLevelsOnly_IsValid;

	private static FFieldAddress TriggerGenerateLandscapeLods_bProcessGridLevelsOnly_PropertyAddress;

	private static int TriggerGenerateLandscapeLods_bProcessGridLevelsOnly_Offset;

	private static bool TriggerGenerateInstancedStaticMeshLods_IsValid;

	private static IntPtr TriggerGenerateInstancedStaticMeshLods_FunctionAddress;

	private static int TriggerGenerateInstancedStaticMeshLods_ParamsSize;

	private static bool TriggerGenerateInstancedStaticMeshLods_InPersistentLevelPath_IsValid;

	private static FFieldAddress TriggerGenerateInstancedStaticMeshLods_InPersistentLevelPath_PropertyAddress;

	private static int TriggerGenerateInstancedStaticMeshLods_InPersistentLevelPath_Offset;

	private static bool TriggerGenerateInstancedStaticMeshLods_InTargetLevelNameList_IsValid;

	private static FFieldAddress TriggerGenerateInstancedStaticMeshLods_InTargetLevelNameList_PropertyAddress;

	private static int TriggerGenerateInstancedStaticMeshLods_InTargetLevelNameList_Offset;

	private static bool TriggerGenerateInstancedStaticMeshLods_bEnableLevelNameFiltering_IsValid;

	private static FFieldAddress TriggerGenerateInstancedStaticMeshLods_bEnableLevelNameFiltering_PropertyAddress;

	private static int TriggerGenerateInstancedStaticMeshLods_bEnableLevelNameFiltering_Offset;

	private static bool TriggerGenerateInstancedStaticMeshLods_ReplacedLODIndex_IsValid;

	private static FFieldAddress TriggerGenerateInstancedStaticMeshLods_ReplacedLODIndex_PropertyAddress;

	private static int TriggerGenerateInstancedStaticMeshLods_ReplacedLODIndex_Offset;

	private static bool TriggerGenerateFoliageLods_IsValid;

	private static IntPtr TriggerGenerateFoliageLods_FunctionAddress;

	private static int TriggerGenerateFoliageLods_ParamsSize;

	private static bool TriggerGenerateFoliageLods_InPersistentLevelPath_IsValid;

	private static FFieldAddress TriggerGenerateFoliageLods_InPersistentLevelPath_PropertyAddress;

	private static int TriggerGenerateFoliageLods_InPersistentLevelPath_Offset;

	private static bool TriggerGenerateFoliageLods_InTargetLevelNameList_IsValid;

	private static FFieldAddress TriggerGenerateFoliageLods_InTargetLevelNameList_PropertyAddress;

	private static int TriggerGenerateFoliageLods_InTargetLevelNameList_Offset;

	private static bool TriggerGenerateFoliageLods_bEnableLevelNameFiltering_IsValid;

	private static FFieldAddress TriggerGenerateFoliageLods_bEnableLevelNameFiltering_PropertyAddress;

	private static int TriggerGenerateFoliageLods_bEnableLevelNameFiltering_Offset;

	private static bool SetLevelsLayer_IsValid;

	private static IntPtr SetLevelsLayer_FunctionAddress;

	private static int SetLevelsLayer_ParamsSize;

	private static bool SetLevelsLayer_InRootFolderName_IsValid;

	private static FFieldAddress SetLevelsLayer_InRootFolderName_PropertyAddress;

	private static int SetLevelsLayer_InRootFolderName_Offset;

	private static bool SetLevelsLayer_TargetLevelNames_IsValid;

	private static FFieldAddress SetLevelsLayer_TargetLevelNames_PropertyAddress;

	private static int SetLevelsLayer_TargetLevelNames_Offset;

	private static bool SetLevelsLayer_TargetLayerName_IsValid;

	private static FFieldAddress SetLevelsLayer_TargetLayerName_PropertyAddress;

	private static int SetLevelsLayer_TargetLayerName_Offset;

	private static bool SaveAndDestroyLevelPackage_IsValid;

	private static IntPtr SaveAndDestroyLevelPackage_FunctionAddress;

	private static int SaveAndDestroyLevelPackage_ParamsSize;

	private static bool SaveAndDestroyLevelPackage_NewWorld_IsValid;

	private static FFieldAddress SaveAndDestroyLevelPackage_NewWorld_PropertyAddress;

	private static int SaveAndDestroyLevelPackage_NewWorld_Offset;

	private static bool MoveNaniteTreesBackToSubLevel_IsValid;

	private static IntPtr MoveNaniteTreesBackToSubLevel_FunctionAddress;

	private static int MoveNaniteTreesBackToSubLevel_ParamsSize;

	private static bool MoveNaniteTreesBackToSubLevel_InRootFolderName_IsValid;

	private static FFieldAddress MoveNaniteTreesBackToSubLevel_InRootFolderName_PropertyAddress;

	private static int MoveNaniteTreesBackToSubLevel_InRootFolderName_Offset;

	private static bool MoveNaniteTreesBackToSubLevel_TargetTileKeyword_IsValid;

	private static FFieldAddress MoveNaniteTreesBackToSubLevel_TargetTileKeyword_PropertyAddress;

	private static int MoveNaniteTreesBackToSubLevel_TargetTileKeyword_Offset;

	private static bool LoadSubLevelsIncludeWcTile_IsValid;

	private static IntPtr LoadSubLevelsIncludeWcTile_FunctionAddress;

	private static int LoadSubLevelsIncludeWcTile_ParamsSize;

	private static bool LoadSubLevelsIncludeWcTile_InTargetLevelNameList_IsValid;

	private static FFieldAddress LoadSubLevelsIncludeWcTile_InTargetLevelNameList_PropertyAddress;

	private static int LoadSubLevelsIncludeWcTile_InTargetLevelNameList_Offset;

	private static bool LoadSubLevels_IsValid;

	private static IntPtr LoadSubLevels_FunctionAddress;

	private static int LoadSubLevels_ParamsSize;

	private static bool LoadSubLevels_InTargetLevelNameList_IsValid;

	private static FFieldAddress LoadSubLevels_InTargetLevelNameList_PropertyAddress;

	private static int LoadSubLevels_InTargetLevelNameList_Offset;

	private static bool LoadISMJsonInfo_IsValid;

	private static IntPtr LoadISMJsonInfo_FunctionAddress;

	private static int LoadISMJsonInfo_ParamsSize;

	private static bool LoadISMJsonInfo_InJsonFileName_IsValid;

	private static FFieldAddress LoadISMJsonInfo_InJsonFileName_PropertyAddress;

	private static int LoadISMJsonInfo_InJsonFileName_Offset;

	private static bool LoadISMJsonInfo_OutISMBuildInfo_IsValid;

	private static FFieldAddress LoadISMJsonInfo_OutISMBuildInfo_PropertyAddress;

	private static int LoadISMJsonInfo_OutISMBuildInfo_Offset;

	private static bool GetPersistentLevelNameUnderParentFolder_IsValid;

	private static IntPtr GetPersistentLevelNameUnderParentFolder_FunctionAddress;

	private static int GetPersistentLevelNameUnderParentFolder_ParamsSize;

	private static bool GetPersistentLevelNameUnderParentFolder_SrcFolderPath_IsValid;

	private static FFieldAddress GetPersistentLevelNameUnderParentFolder_SrcFolderPath_PropertyAddress;

	private static int GetPersistentLevelNameUnderParentFolder_SrcFolderPath_Offset;

	private static bool GetPersistentLevelNameUnderParentFolder_ReturnValue_IsValid;

	private static FFieldAddress GetPersistentLevelNameUnderParentFolder_ReturnValue_PropertyAddress;

	private static int GetPersistentLevelNameUnderParentFolder_ReturnValue_Offset;

	private static bool GetPersistentLevelNameOfSelectedActor_IsValid;

	private static IntPtr GetPersistentLevelNameOfSelectedActor_FunctionAddress;

	private static int GetPersistentLevelNameOfSelectedActor_ParamsSize;

	private static bool GetPersistentLevelNameOfSelectedActor_ReturnValue_IsValid;

	private static FFieldAddress GetPersistentLevelNameOfSelectedActor_ReturnValue_PropertyAddress;

	private static int GetPersistentLevelNameOfSelectedActor_ReturnValue_Offset;

	private static bool GetLevelNameOfSelectedActor_IsValid;

	private static IntPtr GetLevelNameOfSelectedActor_FunctionAddress;

	private static int GetLevelNameOfSelectedActor_ParamsSize;

	private static bool GetLevelNameOfSelectedActor_ReturnValue_IsValid;

	private static FFieldAddress GetLevelNameOfSelectedActor_ReturnValue_PropertyAddress;

	private static int GetLevelNameOfSelectedActor_ReturnValue_Offset;

	private static bool GenActorStatFileAsync_IsValid;

	private static IntPtr GenActorStatFileAsync_FunctionAddress;

	private static int GenActorStatFileAsync_ParamsSize;

	private static bool GenActorStatFileAsync_SourceRootDirectory_IsValid;

	private static FFieldAddress GenActorStatFileAsync_SourceRootDirectory_PropertyAddress;

	private static int GenActorStatFileAsync_SourceRootDirectory_Offset;

	private static bool GenActorStatFileAsync_TargetStatFileDirectory_IsValid;

	private static FFieldAddress GenActorStatFileAsync_TargetStatFileDirectory_PropertyAddress;

	private static int GenActorStatFileAsync_TargetStatFileDirectory_Offset;

	private static bool GenActorStatFile_IsValid;

	private static IntPtr GenActorStatFile_FunctionAddress;

	private static int GenActorStatFile_ParamsSize;

	private static bool GenActorStatFile_SourceRootDirectory_IsValid;

	private static FFieldAddress GenActorStatFile_SourceRootDirectory_PropertyAddress;

	private static int GenActorStatFile_SourceRootDirectory_Offset;

	private static bool GenActorStatFile_TargetStatFilePath_IsValid;

	private static FFieldAddress GenActorStatFile_TargetStatFilePath_PropertyAddress;

	private static int GenActorStatFile_TargetStatFilePath_Offset;

	private static bool GenActorStatFile_bDescendSorting_IsValid;

	private static FFieldAddress GenActorStatFile_bDescendSorting_PropertyAddress;

	private static int GenActorStatFile_bDescendSorting_Offset;

	private static bool GenActorStatFile_StatInfoFlag_IsValid;

	private static FFieldAddress GenActorStatFile_StatInfoFlag_PropertyAddress;

	private static int GenActorStatFile_StatInfoFlag_Offset;

	private static bool FilterLevelsByLevelBoundsLength_IsValid;

	private static IntPtr FilterLevelsByLevelBoundsLength_FunctionAddress;

	private static int FilterLevelsByLevelBoundsLength_ParamsSize;

	private static bool FilterLevelsByLevelBoundsLength_SourceRootDirectory_IsValid;

	private static FFieldAddress FilterLevelsByLevelBoundsLength_SourceRootDirectory_PropertyAddress;

	private static int FilterLevelsByLevelBoundsLength_SourceRootDirectory_Offset;

	private static bool FilterLevelsByLevelBoundsLength_InThreshold_IsValid;

	private static FFieldAddress FilterLevelsByLevelBoundsLength_InThreshold_PropertyAddress;

	private static int FilterLevelsByLevelBoundsLength_InThreshold_Offset;

	private static bool FilterLevelsByLevelBoundsLength_bAscending_IsValid;

	private static FFieldAddress FilterLevelsByLevelBoundsLength_bAscending_PropertyAddress;

	private static int FilterLevelsByLevelBoundsLength_bAscending_Offset;

	private static bool FilterLevelsByLevelBoundsLength_ReturnValue_IsValid;

	private static FFieldAddress FilterLevelsByLevelBoundsLength_ReturnValue_PropertyAddress;

	private static int FilterLevelsByLevelBoundsLength_ReturnValue_Offset;

	private static bool ExtractLevelSMInfo_IsValid;

	private static IntPtr ExtractLevelSMInfo_FunctionAddress;

	private static int ExtractLevelSMInfo_ParamsSize;

	private static bool ExtractLevelSMInfo_InRootFolderName_IsValid;

	private static FFieldAddress ExtractLevelSMInfo_InRootFolderName_PropertyAddress;

	private static int ExtractLevelSMInfo_InRootFolderName_Offset;

	private static bool ExtractLevelSMInfo_InLevelName_IsValid;

	private static FFieldAddress ExtractLevelSMInfo_InLevelName_PropertyAddress;

	private static int ExtractLevelSMInfo_InLevelName_Offset;

	private static bool ExtractLevelSMInfo_bLogDebug_IsValid;

	private static FFieldAddress ExtractLevelSMInfo_bLogDebug_PropertyAddress;

	private static int ExtractLevelSMInfo_bLogDebug_Offset;

	private static bool CreateNewLevelPackageAndReturn_IsValid;

	private static IntPtr CreateNewLevelPackageAndReturn_FunctionAddress;

	private static int CreateNewLevelPackageAndReturn_ParamsSize;

	private static bool CreateNewLevelPackageAndReturn_TargetFolder_IsValid;

	private static FFieldAddress CreateNewLevelPackageAndReturn_TargetFolder_PropertyAddress;

	private static int CreateNewLevelPackageAndReturn_TargetFolder_Offset;

	private static bool CreateNewLevelPackageAndReturn_TargetMapName_IsValid;

	private static FFieldAddress CreateNewLevelPackageAndReturn_TargetMapName_PropertyAddress;

	private static int CreateNewLevelPackageAndReturn_TargetMapName_Offset;

	private static bool CreateNewLevelPackageAndReturn_ReturnValue_IsValid;

	private static FFieldAddress CreateNewLevelPackageAndReturn_ReturnValue_PropertyAddress;

	private static int CreateNewLevelPackageAndReturn_ReturnValue_Offset;

	private static bool CreateNewLevelPackage_IsValid;

	private static IntPtr CreateNewLevelPackage_FunctionAddress;

	private static int CreateNewLevelPackage_ParamsSize;

	private static bool CreateNewLevelPackage_TargetFolder_IsValid;

	private static FFieldAddress CreateNewLevelPackage_TargetFolder_PropertyAddress;

	private static int CreateNewLevelPackage_TargetFolder_Offset;

	private static bool CreateNewLevelPackage_TargetMapName_IsValid;

	private static FFieldAddress CreateNewLevelPackage_TargetMapName_PropertyAddress;

	private static int CreateNewLevelPackage_TargetMapName_Offset;

	private static bool CreateLodLevelAndSpawnLodActor_IsValid;

	private static IntPtr CreateLodLevelAndSpawnLodActor_FunctionAddress;

	private static int CreateLodLevelAndSpawnLodActor_ParamsSize;

	private static bool CreateLodLevelAndSpawnLodActor_InLODLevelPackageName_IsValid;

	private static FFieldAddress CreateLodLevelAndSpawnLodActor_InLODLevelPackageName_PropertyAddress;

	private static int CreateLodLevelAndSpawnLodActor_InLODLevelPackageName_Offset;

	private static bool CreateLodLevelAndSpawnLodActor_InLODStaticMesh_IsValid;

	private static FFieldAddress CreateLodLevelAndSpawnLodActor_InLODStaticMesh_PropertyAddress;

	private static int CreateLodLevelAndSpawnLodActor_InLODStaticMesh_Offset;

	private static bool CreateLodLevelAndSpawnLodActor_InSpawnTransform_IsValid;

	private static FFieldAddress CreateLodLevelAndSpawnLodActor_InSpawnTransform_PropertyAddress;

	private static int CreateLodLevelAndSpawnLodActor_InSpawnTransform_Offset;

	private static bool CheckActorNumMatches_IsValid;

	private static IntPtr CheckActorNumMatches_FunctionAddress;

	private static int CheckActorNumMatches_ParamsSize;

	private static bool CheckActorNumMatches_Before_IsValid;

	private static FFieldAddress CheckActorNumMatches_Before_PropertyAddress;

	private static int CheckActorNumMatches_Before_Offset;

	private static bool CheckActorNumMatches_After_IsValid;

	private static FFieldAddress CheckActorNumMatches_After_PropertyAddress;

	private static int CheckActorNumMatches_After_Offset;

	private static bool CheckActorNumMatches_TargetDiffFilePath_IsValid;

	private static FFieldAddress CheckActorNumMatches_TargetDiffFilePath_PropertyAddress;

	private static int CheckActorNumMatches_TargetDiffFilePath_Offset;

	private static bool CheckActorNumMatches_ReturnValue_IsValid;

	private static FFieldAddress CheckActorNumMatches_ReturnValue_PropertyAddress;

	private static int CheckActorNumMatches_ReturnValue_Offset;

	private static bool BuildTileLevelISMInfo_IsValid;

	private static IntPtr BuildTileLevelISMInfo_FunctionAddress;

	private static int BuildTileLevelISMInfo_ParamsSize;

	private static bool BuildTileLevelISMInfo_InRootFolderName_IsValid;

	private static FFieldAddress BuildTileLevelISMInfo_InRootFolderName_PropertyAddress;

	private static int BuildTileLevelISMInfo_InRootFolderName_Offset;

	private static bool BuildTileLevelISMInfo_InTargetLevelName_IsValid;

	private static FFieldAddress BuildTileLevelISMInfo_InTargetLevelName_PropertyAddress;

	private static int BuildTileLevelISMInfo_InTargetLevelName_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:UpdateTileLevelBounds")]
	public unsafe static void UpdateTileLevelBounds(string RootDirectory)
	{
		if (!UpdateTileLevelBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:UpdateTileLevelBounds");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateTileLevelBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateTileLevelBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UpdateTileLevelBounds_RootDirectory_Offset), 0, UpdateTileLevelBounds_RootDirectory_PropertyAddress.Address, RootDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UpdateTileLevelBounds_FunctionAddress, intPtr, UpdateTileLevelBounds_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UpdateTileLevelBounds_RootDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateProxyAssets")]
	public unsafe static void TriggerGenerateProxyAssets(string InPersistentLevelPath, List<string> InTargetLevelNameList, float InPrecisionScaleFactor = 1f, bool bForceGenProxyMesh = false, int InTargetLODIndex = -1)
	{
		if (!TriggerGenerateProxyAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateProxyAssets");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TriggerGenerateProxyAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TriggerGenerateProxyAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TriggerGenerateProxyAssets_InPersistentLevelPath_Offset), 0, TriggerGenerateProxyAssets_InPersistentLevelPath_PropertyAddress.Address, InPersistentLevelPath);
		new TArrayCopyMarshaler<string>(1, TriggerGenerateProxyAssets_InTargetLevelNameList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, TriggerGenerateProxyAssets_InTargetLevelNameList_Offset), InTargetLevelNameList);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TriggerGenerateProxyAssets_InPrecisionScaleFactor_Offset), 0, TriggerGenerateProxyAssets_InPrecisionScaleFactor_PropertyAddress.Address, InPrecisionScaleFactor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TriggerGenerateProxyAssets_bForceGenProxyMesh_Offset), 0, TriggerGenerateProxyAssets_bForceGenProxyMesh_PropertyAddress.Address, bForceGenProxyMesh);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, TriggerGenerateProxyAssets_InTargetLODIndex_Offset), 0, TriggerGenerateProxyAssets_InTargetLODIndex_PropertyAddress.Address, InTargetLODIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TriggerGenerateProxyAssets_FunctionAddress, intPtr, TriggerGenerateProxyAssets_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TriggerGenerateProxyAssets_InPersistentLevelPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(TriggerGenerateProxyAssets_InTargetLevelNameList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateLandscapeLods")]
	public unsafe static void TriggerGenerateLandscapeLods(string InPersistentLevelPath, List<string> InTargetLevelNameList, float DelayForFullLoading = 5f, bool bGenerateFoliageImposter = true, bool bProcessGridLevelsOnly = false)
	{
		if (!TriggerGenerateLandscapeLods_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateLandscapeLods");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TriggerGenerateLandscapeLods_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TriggerGenerateLandscapeLods_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TriggerGenerateLandscapeLods_InPersistentLevelPath_Offset), 0, TriggerGenerateLandscapeLods_InPersistentLevelPath_PropertyAddress.Address, InPersistentLevelPath);
		new TArrayCopyMarshaler<string>(1, TriggerGenerateLandscapeLods_InTargetLevelNameList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, TriggerGenerateLandscapeLods_InTargetLevelNameList_Offset), InTargetLevelNameList);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, TriggerGenerateLandscapeLods_DelayForFullLoading_Offset), 0, TriggerGenerateLandscapeLods_DelayForFullLoading_PropertyAddress.Address, DelayForFullLoading);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TriggerGenerateLandscapeLods_bGenerateFoliageImposter_Offset), 0, TriggerGenerateLandscapeLods_bGenerateFoliageImposter_PropertyAddress.Address, bGenerateFoliageImposter);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TriggerGenerateLandscapeLods_bProcessGridLevelsOnly_Offset), 0, TriggerGenerateLandscapeLods_bProcessGridLevelsOnly_PropertyAddress.Address, bProcessGridLevelsOnly);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TriggerGenerateLandscapeLods_FunctionAddress, intPtr, TriggerGenerateLandscapeLods_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TriggerGenerateLandscapeLods_InPersistentLevelPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(TriggerGenerateLandscapeLods_InTargetLevelNameList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateInstancedStaticMeshLods")]
	public unsafe static void TriggerGenerateInstancedStaticMeshLods(string InPersistentLevelPath, List<string> InTargetLevelNameList, bool bEnableLevelNameFiltering = true, int ReplacedLODIndex = 0)
	{
		if (!TriggerGenerateInstancedStaticMeshLods_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateInstancedStaticMeshLods");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TriggerGenerateInstancedStaticMeshLods_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TriggerGenerateInstancedStaticMeshLods_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TriggerGenerateInstancedStaticMeshLods_InPersistentLevelPath_Offset), 0, TriggerGenerateInstancedStaticMeshLods_InPersistentLevelPath_PropertyAddress.Address, InPersistentLevelPath);
		new TArrayCopyMarshaler<string>(1, TriggerGenerateInstancedStaticMeshLods_InTargetLevelNameList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, TriggerGenerateInstancedStaticMeshLods_InTargetLevelNameList_Offset), InTargetLevelNameList);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TriggerGenerateInstancedStaticMeshLods_bEnableLevelNameFiltering_Offset), 0, TriggerGenerateInstancedStaticMeshLods_bEnableLevelNameFiltering_PropertyAddress.Address, bEnableLevelNameFiltering);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, TriggerGenerateInstancedStaticMeshLods_ReplacedLODIndex_Offset), 0, TriggerGenerateInstancedStaticMeshLods_ReplacedLODIndex_PropertyAddress.Address, ReplacedLODIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TriggerGenerateInstancedStaticMeshLods_FunctionAddress, intPtr, TriggerGenerateInstancedStaticMeshLods_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TriggerGenerateInstancedStaticMeshLods_InPersistentLevelPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(TriggerGenerateInstancedStaticMeshLods_InTargetLevelNameList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateFoliageLods")]
	public unsafe static void TriggerGenerateFoliageLods(string InPersistentLevelPath, List<string> InTargetLevelNameList, bool bEnableLevelNameFiltering = true)
	{
		if (!TriggerGenerateFoliageLods_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateFoliageLods");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TriggerGenerateFoliageLods_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TriggerGenerateFoliageLods_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TriggerGenerateFoliageLods_InPersistentLevelPath_Offset), 0, TriggerGenerateFoliageLods_InPersistentLevelPath_PropertyAddress.Address, InPersistentLevelPath);
		new TArrayCopyMarshaler<string>(1, TriggerGenerateFoliageLods_InTargetLevelNameList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, TriggerGenerateFoliageLods_InTargetLevelNameList_Offset), InTargetLevelNameList);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, TriggerGenerateFoliageLods_bEnableLevelNameFiltering_Offset), 0, TriggerGenerateFoliageLods_bEnableLevelNameFiltering_PropertyAddress.Address, bEnableLevelNameFiltering);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TriggerGenerateFoliageLods_FunctionAddress, intPtr, TriggerGenerateFoliageLods_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TriggerGenerateFoliageLods_InPersistentLevelPath_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(TriggerGenerateFoliageLods_InTargetLevelNameList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:SetLevelsLayer")]
	public unsafe static void SetLevelsLayer(string InRootFolderName, List<string> TargetLevelNames, string TargetLayerName)
	{
		if (!SetLevelsLayer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:SetLevelsLayer");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelsLayer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelsLayer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLevelsLayer_InRootFolderName_Offset), 0, SetLevelsLayer_InRootFolderName_PropertyAddress.Address, InRootFolderName);
		new TArrayCopyMarshaler<string>(1, SetLevelsLayer_TargetLevelNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetLevelsLayer_TargetLevelNames_Offset), TargetLevelNames);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetLevelsLayer_TargetLayerName_Offset), 0, SetLevelsLayer_TargetLayerName_PropertyAddress.Address, TargetLayerName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLevelsLayer_FunctionAddress, intPtr, SetLevelsLayer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLevelsLayer_InRootFolderName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetLevelsLayer_TargetLevelNames_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetLevelsLayer_TargetLayerName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:SaveAndDestroyLevelPackage")]
	public unsafe static void SaveAndDestroyLevelPackage(UWorld NewWorld)
	{
		if (!SaveAndDestroyLevelPackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:SaveAndDestroyLevelPackage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveAndDestroyLevelPackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveAndDestroyLevelPackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, SaveAndDestroyLevelPackage_NewWorld_Offset), 0, SaveAndDestroyLevelPackage_NewWorld_PropertyAddress.Address, NewWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SaveAndDestroyLevelPackage_FunctionAddress, intPtr, SaveAndDestroyLevelPackage_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:MoveNaniteTreesBackToSubLevel")]
	public unsafe static void MoveNaniteTreesBackToSubLevel(string InRootFolderName, string TargetTileKeyword = "_WCTile_Instancing_")
	{
		if (!MoveNaniteTreesBackToSubLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:MoveNaniteTreesBackToSubLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveNaniteTreesBackToSubLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveNaniteTreesBackToSubLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MoveNaniteTreesBackToSubLevel_InRootFolderName_Offset), 0, MoveNaniteTreesBackToSubLevel_InRootFolderName_PropertyAddress.Address, InRootFolderName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, MoveNaniteTreesBackToSubLevel_TargetTileKeyword_Offset), 0, MoveNaniteTreesBackToSubLevel_TargetTileKeyword_PropertyAddress.Address, TargetTileKeyword);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MoveNaniteTreesBackToSubLevel_FunctionAddress, intPtr, MoveNaniteTreesBackToSubLevel_ParamsSize);
		NativeReflection.DestroyValue_InContainer(MoveNaniteTreesBackToSubLevel_InRootFolderName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(MoveNaniteTreesBackToSubLevel_TargetTileKeyword_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:LoadSubLevelsIncludeWcTile")]
	public unsafe static void LoadSubLevelsIncludeWcTile(List<string> InTargetLevelNameList)
	{
		if (!LoadSubLevelsIncludeWcTile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:LoadSubLevelsIncludeWcTile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadSubLevelsIncludeWcTile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadSubLevelsIncludeWcTile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, LoadSubLevelsIncludeWcTile_InTargetLevelNameList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, LoadSubLevelsIncludeWcTile_InTargetLevelNameList_Offset), InTargetLevelNameList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadSubLevelsIncludeWcTile_FunctionAddress, intPtr, LoadSubLevelsIncludeWcTile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadSubLevelsIncludeWcTile_InTargetLevelNameList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:LoadSubLevels")]
	public unsafe static void LoadSubLevels(List<string> InTargetLevelNameList)
	{
		if (!LoadSubLevels_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:LoadSubLevels");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadSubLevels_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadSubLevels_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, LoadSubLevels_InTargetLevelNameList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, LoadSubLevels_InTargetLevelNameList_Offset), InTargetLevelNameList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadSubLevels_FunctionAddress, intPtr, LoadSubLevels_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadSubLevels_InTargetLevelNameList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:LoadISMJsonInfo")]
	public unsafe static void LoadISMJsonInfo(string InJsonFileName, out List<FISMBuildInfo> OutISMBuildInfo)
	{
		if (!LoadISMJsonInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:LoadISMJsonInfo");
			OutISMBuildInfo = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadISMJsonInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadISMJsonInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, LoadISMJsonInfo_InJsonFileName_Offset), 0, LoadISMJsonInfo_InJsonFileName_PropertyAddress.Address, InJsonFileName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadISMJsonInfo_FunctionAddress, intPtr, LoadISMJsonInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(LoadISMJsonInfo_InJsonFileName_PropertyAddress.Address, intPtr);
		OutISMBuildInfo = new TArrayCopyMarshaler<FISMBuildInfo>(1, LoadISMJsonInfo_OutISMBuildInfo_PropertyAddress, CachedMarshalingDelegates<FISMBuildInfo, FISMBuildInfo>.FromNative, CachedMarshalingDelegates<FISMBuildInfo, FISMBuildInfo>.ToNative).FromNative(IntPtr.Add(intPtr, LoadISMJsonInfo_OutISMBuildInfo_Offset));
		NativeReflection.DestroyValue_InContainer(LoadISMJsonInfo_OutISMBuildInfo_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:GetPersistentLevelNameUnderParentFolder")]
	public unsafe static string GetPersistentLevelNameUnderParentFolder(string SrcFolderPath)
	{
		if (!GetPersistentLevelNameUnderParentFolder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:GetPersistentLevelNameUnderParentFolder");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPersistentLevelNameUnderParentFolder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPersistentLevelNameUnderParentFolder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPersistentLevelNameUnderParentFolder_SrcFolderPath_Offset), 0, GetPersistentLevelNameUnderParentFolder_SrcFolderPath_PropertyAddress.Address, SrcFolderPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPersistentLevelNameUnderParentFolder_FunctionAddress, intPtr, GetPersistentLevelNameUnderParentFolder_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPersistentLevelNameUnderParentFolder_SrcFolderPath_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPersistentLevelNameUnderParentFolder_ReturnValue_Offset), 0, GetPersistentLevelNameUnderParentFolder_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPersistentLevelNameUnderParentFolder_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:GetPersistentLevelNameOfSelectedActor")]
	public unsafe static string GetPersistentLevelNameOfSelectedActor()
	{
		if (!GetPersistentLevelNameOfSelectedActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:GetPersistentLevelNameOfSelectedActor");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPersistentLevelNameOfSelectedActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPersistentLevelNameOfSelectedActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPersistentLevelNameOfSelectedActor_FunctionAddress, intPtr, GetPersistentLevelNameOfSelectedActor_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPersistentLevelNameOfSelectedActor_ReturnValue_Offset), 0, GetPersistentLevelNameOfSelectedActor_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPersistentLevelNameOfSelectedActor_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:GetLevelNameOfSelectedActor")]
	public unsafe static string GetLevelNameOfSelectedActor()
	{
		if (!GetLevelNameOfSelectedActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:GetLevelNameOfSelectedActor");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelNameOfSelectedActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelNameOfSelectedActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelNameOfSelectedActor_FunctionAddress, intPtr, GetLevelNameOfSelectedActor_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetLevelNameOfSelectedActor_ReturnValue_Offset), 0, GetLevelNameOfSelectedActor_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetLevelNameOfSelectedActor_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:GenActorStatFileAsync")]
	public unsafe static void GenActorStatFileAsync(string SourceRootDirectory, string TargetStatFileDirectory)
	{
		if (!GenActorStatFileAsync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:GenActorStatFileAsync");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenActorStatFileAsync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenActorStatFileAsync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenActorStatFileAsync_SourceRootDirectory_Offset), 0, GenActorStatFileAsync_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenActorStatFileAsync_TargetStatFileDirectory_Offset), 0, GenActorStatFileAsync_TargetStatFileDirectory_PropertyAddress.Address, TargetStatFileDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenActorStatFileAsync_FunctionAddress, intPtr, GenActorStatFileAsync_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GenActorStatFileAsync_SourceRootDirectory_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GenActorStatFileAsync_TargetStatFileDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:GenActorStatFile")]
	public unsafe static void GenActorStatFile(string SourceRootDirectory, string TargetStatFilePath, bool bDescendSorting, int StatInfoFlag)
	{
		if (!GenActorStatFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:GenActorStatFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenActorStatFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenActorStatFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenActorStatFile_SourceRootDirectory_Offset), 0, GenActorStatFile_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GenActorStatFile_TargetStatFilePath_Offset), 0, GenActorStatFile_TargetStatFilePath_PropertyAddress.Address, TargetStatFilePath);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GenActorStatFile_bDescendSorting_Offset), 0, GenActorStatFile_bDescendSorting_PropertyAddress.Address, bDescendSorting);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GenActorStatFile_StatInfoFlag_Offset), 0, GenActorStatFile_StatInfoFlag_PropertyAddress.Address, StatInfoFlag);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GenActorStatFile_FunctionAddress, intPtr, GenActorStatFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GenActorStatFile_SourceRootDirectory_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(GenActorStatFile_TargetStatFilePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:FilterLevelsByLevelBoundsLength")]
	public unsafe static List<string> FilterLevelsByLevelBoundsLength(string SourceRootDirectory, float InThreshold = 1000f, bool bAscending = true)
	{
		if (!FilterLevelsByLevelBoundsLength_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:FilterLevelsByLevelBoundsLength");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FilterLevelsByLevelBoundsLength_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FilterLevelsByLevelBoundsLength_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FilterLevelsByLevelBoundsLength_SourceRootDirectory_Offset), 0, FilterLevelsByLevelBoundsLength_SourceRootDirectory_PropertyAddress.Address, SourceRootDirectory);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FilterLevelsByLevelBoundsLength_InThreshold_Offset), 0, FilterLevelsByLevelBoundsLength_InThreshold_PropertyAddress.Address, InThreshold);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FilterLevelsByLevelBoundsLength_bAscending_Offset), 0, FilterLevelsByLevelBoundsLength_bAscending_PropertyAddress.Address, bAscending);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FilterLevelsByLevelBoundsLength_FunctionAddress, intPtr, FilterLevelsByLevelBoundsLength_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FilterLevelsByLevelBoundsLength_SourceRootDirectory_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, FilterLevelsByLevelBoundsLength_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, FilterLevelsByLevelBoundsLength_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FilterLevelsByLevelBoundsLength_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:ExtractLevelSMInfo")]
	public unsafe static void ExtractLevelSMInfo(string InRootFolderName, string InLevelName, bool bLogDebug = false)
	{
		if (!ExtractLevelSMInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:ExtractLevelSMInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExtractLevelSMInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExtractLevelSMInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExtractLevelSMInfo_InRootFolderName_Offset), 0, ExtractLevelSMInfo_InRootFolderName_PropertyAddress.Address, InRootFolderName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ExtractLevelSMInfo_InLevelName_Offset), 0, ExtractLevelSMInfo_InLevelName_PropertyAddress.Address, InLevelName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ExtractLevelSMInfo_bLogDebug_Offset), 0, ExtractLevelSMInfo_bLogDebug_PropertyAddress.Address, bLogDebug);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ExtractLevelSMInfo_FunctionAddress, intPtr, ExtractLevelSMInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ExtractLevelSMInfo_InRootFolderName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ExtractLevelSMInfo_InLevelName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:CreateNewLevelPackageAndReturn")]
	public unsafe static UWorld CreateNewLevelPackageAndReturn(string TargetFolder, string TargetMapName)
	{
		if (!CreateNewLevelPackageAndReturn_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:CreateNewLevelPackageAndReturn");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateNewLevelPackageAndReturn_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateNewLevelPackageAndReturn_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateNewLevelPackageAndReturn_TargetFolder_Offset), 0, CreateNewLevelPackageAndReturn_TargetFolder_PropertyAddress.Address, TargetFolder);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateNewLevelPackageAndReturn_TargetMapName_Offset), 0, CreateNewLevelPackageAndReturn_TargetMapName_PropertyAddress.Address, TargetMapName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateNewLevelPackageAndReturn_FunctionAddress, intPtr, CreateNewLevelPackageAndReturn_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateNewLevelPackageAndReturn_TargetFolder_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateNewLevelPackageAndReturn_TargetMapName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(intPtr, CreateNewLevelPackageAndReturn_ReturnValue_Offset), 0, CreateNewLevelPackageAndReturn_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:CreateNewLevelPackage")]
	public unsafe static void CreateNewLevelPackage(string TargetFolder, string TargetMapName)
	{
		if (!CreateNewLevelPackage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:CreateNewLevelPackage");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateNewLevelPackage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateNewLevelPackage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateNewLevelPackage_TargetFolder_Offset), 0, CreateNewLevelPackage_TargetFolder_PropertyAddress.Address, TargetFolder);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateNewLevelPackage_TargetMapName_Offset), 0, CreateNewLevelPackage_TargetMapName_PropertyAddress.Address, TargetMapName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateNewLevelPackage_FunctionAddress, intPtr, CreateNewLevelPackage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateNewLevelPackage_TargetFolder_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateNewLevelPackage_TargetMapName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:CreateLodLevelAndSpawnLodActor")]
	public unsafe static void CreateLodLevelAndSpawnLodActor(string InLODLevelPackageName, UStaticMesh InLODStaticMesh, FTransform InSpawnTransform)
	{
		if (!CreateLodLevelAndSpawnLodActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:CreateLodLevelAndSpawnLodActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateLodLevelAndSpawnLodActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateLodLevelAndSpawnLodActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateLodLevelAndSpawnLodActor_InLODLevelPackageName_Offset), 0, CreateLodLevelAndSpawnLodActor_InLODLevelPackageName_PropertyAddress.Address, InLODLevelPackageName);
		UObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(intPtr, CreateLodLevelAndSpawnLodActor_InLODStaticMesh_Offset), 0, CreateLodLevelAndSpawnLodActor_InLODStaticMesh_PropertyAddress.Address, InLODStaticMesh);
		NativeReflection.InitializeValue_InContainer(CreateLodLevelAndSpawnLodActor_InSpawnTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, CreateLodLevelAndSpawnLodActor_InSpawnTransform_Offset), 0, CreateLodLevelAndSpawnLodActor_InSpawnTransform_PropertyAddress.Address, InSpawnTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateLodLevelAndSpawnLodActor_FunctionAddress, intPtr, CreateLodLevelAndSpawnLodActor_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateLodLevelAndSpawnLodActor_InLODLevelPackageName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:CheckActorNumMatches")]
	public unsafe static bool CheckActorNumMatches(FFlatActorStat Before, FFlatActorStat After, string TargetDiffFilePath)
	{
		if (!CheckActorNumMatches_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:CheckActorNumMatches");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckActorNumMatches_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckActorNumMatches_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(CheckActorNumMatches_Before_PropertyAddress.Address, intPtr);
		FFlatActorStat.ToNative(IntPtr.Add(intPtr, CheckActorNumMatches_Before_Offset), 0, CheckActorNumMatches_Before_PropertyAddress.Address, Before);
		NativeReflection.InitializeValue_InContainer(CheckActorNumMatches_After_PropertyAddress.Address, intPtr);
		FFlatActorStat.ToNative(IntPtr.Add(intPtr, CheckActorNumMatches_After_Offset), 0, CheckActorNumMatches_After_PropertyAddress.Address, After);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CheckActorNumMatches_TargetDiffFilePath_Offset), 0, CheckActorNumMatches_TargetDiffFilePath_PropertyAddress.Address, TargetDiffFilePath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckActorNumMatches_FunctionAddress, intPtr, CheckActorNumMatches_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CheckActorNumMatches_Before_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CheckActorNumMatches_After_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CheckActorNumMatches_TargetDiffFilePath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckActorNumMatches_ReturnValue_Offset), 0, CheckActorNumMatches_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/FuncLibEditor.GSEditorWCLibrary:BuildTileLevelISMInfo")]
	public unsafe static void BuildTileLevelISMInfo(string InRootFolderName, string InTargetLevelName)
	{
		if (!BuildTileLevelISMInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSEditorWCLibrary:BuildTileLevelISMInfo");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildTileLevelISMInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildTileLevelISMInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildTileLevelISMInfo_InRootFolderName_Offset), 0, BuildTileLevelISMInfo_InRootFolderName_PropertyAddress.Address, InRootFolderName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildTileLevelISMInfo_InTargetLevelName_Offset), 0, BuildTileLevelISMInfo_InTargetLevelName_PropertyAddress.Address, InTargetLevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BuildTileLevelISMInfo_FunctionAddress, intPtr, BuildTileLevelISMInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BuildTileLevelISMInfo_InRootFolderName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BuildTileLevelISMInfo_InTargetLevelName_PropertyAddress.Address, intPtr);
	}

	static UGSEditorWCLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSEditorWCLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSEditorWCLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/FuncLibEditor.GSEditorWCLibrary");
		UpdateTileLevelBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UpdateTileLevelBounds");
		UpdateTileLevelBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateTileLevelBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UpdateTileLevelBounds_RootDirectory_PropertyAddress, UpdateTileLevelBounds_FunctionAddress, "RootDirectory");
		UpdateTileLevelBounds_RootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(UpdateTileLevelBounds_FunctionAddress, "RootDirectory");
		UpdateTileLevelBounds_RootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(UpdateTileLevelBounds_FunctionAddress, "RootDirectory", Classes.FStrProperty);
		UpdateTileLevelBounds_IsValid = UpdateTileLevelBounds_FunctionAddress != IntPtr.Zero && UpdateTileLevelBounds_RootDirectory_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:UpdateTileLevelBounds", UpdateTileLevelBounds_IsValid);
		TriggerGenerateProxyAssets_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TriggerGenerateProxyAssets");
		TriggerGenerateProxyAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(TriggerGenerateProxyAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateProxyAssets_InPersistentLevelPath_PropertyAddress, TriggerGenerateProxyAssets_FunctionAddress, "InPersistentLevelPath");
		TriggerGenerateProxyAssets_InPersistentLevelPath_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateProxyAssets_FunctionAddress, "InPersistentLevelPath");
		TriggerGenerateProxyAssets_InPersistentLevelPath_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateProxyAssets_FunctionAddress, "InPersistentLevelPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateProxyAssets_InTargetLevelNameList_PropertyAddress, TriggerGenerateProxyAssets_FunctionAddress, "InTargetLevelNameList");
		TriggerGenerateProxyAssets_InTargetLevelNameList_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateProxyAssets_FunctionAddress, "InTargetLevelNameList");
		TriggerGenerateProxyAssets_InTargetLevelNameList_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateProxyAssets_FunctionAddress, "InTargetLevelNameList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateProxyAssets_InPrecisionScaleFactor_PropertyAddress, TriggerGenerateProxyAssets_FunctionAddress, "InPrecisionScaleFactor");
		TriggerGenerateProxyAssets_InPrecisionScaleFactor_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateProxyAssets_FunctionAddress, "InPrecisionScaleFactor");
		TriggerGenerateProxyAssets_InPrecisionScaleFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateProxyAssets_FunctionAddress, "InPrecisionScaleFactor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateProxyAssets_bForceGenProxyMesh_PropertyAddress, TriggerGenerateProxyAssets_FunctionAddress, "bForceGenProxyMesh");
		TriggerGenerateProxyAssets_bForceGenProxyMesh_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateProxyAssets_FunctionAddress, "bForceGenProxyMesh");
		TriggerGenerateProxyAssets_bForceGenProxyMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateProxyAssets_FunctionAddress, "bForceGenProxyMesh", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateProxyAssets_InTargetLODIndex_PropertyAddress, TriggerGenerateProxyAssets_FunctionAddress, "InTargetLODIndex");
		TriggerGenerateProxyAssets_InTargetLODIndex_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateProxyAssets_FunctionAddress, "InTargetLODIndex");
		TriggerGenerateProxyAssets_InTargetLODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateProxyAssets_FunctionAddress, "InTargetLODIndex", Classes.FIntProperty);
		TriggerGenerateProxyAssets_IsValid = TriggerGenerateProxyAssets_FunctionAddress != IntPtr.Zero && TriggerGenerateProxyAssets_InPersistentLevelPath_IsValid && TriggerGenerateProxyAssets_InTargetLevelNameList_IsValid && TriggerGenerateProxyAssets_InPrecisionScaleFactor_IsValid && TriggerGenerateProxyAssets_bForceGenProxyMesh_IsValid && TriggerGenerateProxyAssets_InTargetLODIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateProxyAssets", TriggerGenerateProxyAssets_IsValid);
		TriggerGenerateLandscapeLods_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TriggerGenerateLandscapeLods");
		TriggerGenerateLandscapeLods_ParamsSize = NativeReflection.GetFunctionParamsSize(TriggerGenerateLandscapeLods_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateLandscapeLods_InPersistentLevelPath_PropertyAddress, TriggerGenerateLandscapeLods_FunctionAddress, "InPersistentLevelPath");
		TriggerGenerateLandscapeLods_InPersistentLevelPath_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateLandscapeLods_FunctionAddress, "InPersistentLevelPath");
		TriggerGenerateLandscapeLods_InPersistentLevelPath_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateLandscapeLods_FunctionAddress, "InPersistentLevelPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateLandscapeLods_InTargetLevelNameList_PropertyAddress, TriggerGenerateLandscapeLods_FunctionAddress, "InTargetLevelNameList");
		TriggerGenerateLandscapeLods_InTargetLevelNameList_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateLandscapeLods_FunctionAddress, "InTargetLevelNameList");
		TriggerGenerateLandscapeLods_InTargetLevelNameList_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateLandscapeLods_FunctionAddress, "InTargetLevelNameList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateLandscapeLods_DelayForFullLoading_PropertyAddress, TriggerGenerateLandscapeLods_FunctionAddress, "DelayForFullLoading");
		TriggerGenerateLandscapeLods_DelayForFullLoading_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateLandscapeLods_FunctionAddress, "DelayForFullLoading");
		TriggerGenerateLandscapeLods_DelayForFullLoading_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateLandscapeLods_FunctionAddress, "DelayForFullLoading", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateLandscapeLods_bGenerateFoliageImposter_PropertyAddress, TriggerGenerateLandscapeLods_FunctionAddress, "bGenerateFoliageImposter");
		TriggerGenerateLandscapeLods_bGenerateFoliageImposter_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateLandscapeLods_FunctionAddress, "bGenerateFoliageImposter");
		TriggerGenerateLandscapeLods_bGenerateFoliageImposter_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateLandscapeLods_FunctionAddress, "bGenerateFoliageImposter", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateLandscapeLods_bProcessGridLevelsOnly_PropertyAddress, TriggerGenerateLandscapeLods_FunctionAddress, "bProcessGridLevelsOnly");
		TriggerGenerateLandscapeLods_bProcessGridLevelsOnly_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateLandscapeLods_FunctionAddress, "bProcessGridLevelsOnly");
		TriggerGenerateLandscapeLods_bProcessGridLevelsOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateLandscapeLods_FunctionAddress, "bProcessGridLevelsOnly", Classes.FBoolProperty);
		TriggerGenerateLandscapeLods_IsValid = TriggerGenerateLandscapeLods_FunctionAddress != IntPtr.Zero && TriggerGenerateLandscapeLods_InPersistentLevelPath_IsValid && TriggerGenerateLandscapeLods_InTargetLevelNameList_IsValid && TriggerGenerateLandscapeLods_DelayForFullLoading_IsValid && TriggerGenerateLandscapeLods_bGenerateFoliageImposter_IsValid && TriggerGenerateLandscapeLods_bProcessGridLevelsOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateLandscapeLods", TriggerGenerateLandscapeLods_IsValid);
		TriggerGenerateInstancedStaticMeshLods_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TriggerGenerateInstancedStaticMeshLods");
		TriggerGenerateInstancedStaticMeshLods_ParamsSize = NativeReflection.GetFunctionParamsSize(TriggerGenerateInstancedStaticMeshLods_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateInstancedStaticMeshLods_InPersistentLevelPath_PropertyAddress, TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "InPersistentLevelPath");
		TriggerGenerateInstancedStaticMeshLods_InPersistentLevelPath_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "InPersistentLevelPath");
		TriggerGenerateInstancedStaticMeshLods_InPersistentLevelPath_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "InPersistentLevelPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateInstancedStaticMeshLods_InTargetLevelNameList_PropertyAddress, TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "InTargetLevelNameList");
		TriggerGenerateInstancedStaticMeshLods_InTargetLevelNameList_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "InTargetLevelNameList");
		TriggerGenerateInstancedStaticMeshLods_InTargetLevelNameList_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "InTargetLevelNameList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateInstancedStaticMeshLods_bEnableLevelNameFiltering_PropertyAddress, TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "bEnableLevelNameFiltering");
		TriggerGenerateInstancedStaticMeshLods_bEnableLevelNameFiltering_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "bEnableLevelNameFiltering");
		TriggerGenerateInstancedStaticMeshLods_bEnableLevelNameFiltering_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "bEnableLevelNameFiltering", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateInstancedStaticMeshLods_ReplacedLODIndex_PropertyAddress, TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "ReplacedLODIndex");
		TriggerGenerateInstancedStaticMeshLods_ReplacedLODIndex_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "ReplacedLODIndex");
		TriggerGenerateInstancedStaticMeshLods_ReplacedLODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateInstancedStaticMeshLods_FunctionAddress, "ReplacedLODIndex", Classes.FIntProperty);
		TriggerGenerateInstancedStaticMeshLods_IsValid = TriggerGenerateInstancedStaticMeshLods_FunctionAddress != IntPtr.Zero && TriggerGenerateInstancedStaticMeshLods_InPersistentLevelPath_IsValid && TriggerGenerateInstancedStaticMeshLods_InTargetLevelNameList_IsValid && TriggerGenerateInstancedStaticMeshLods_bEnableLevelNameFiltering_IsValid && TriggerGenerateInstancedStaticMeshLods_ReplacedLODIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateInstancedStaticMeshLods", TriggerGenerateInstancedStaticMeshLods_IsValid);
		TriggerGenerateFoliageLods_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TriggerGenerateFoliageLods");
		TriggerGenerateFoliageLods_ParamsSize = NativeReflection.GetFunctionParamsSize(TriggerGenerateFoliageLods_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateFoliageLods_InPersistentLevelPath_PropertyAddress, TriggerGenerateFoliageLods_FunctionAddress, "InPersistentLevelPath");
		TriggerGenerateFoliageLods_InPersistentLevelPath_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateFoliageLods_FunctionAddress, "InPersistentLevelPath");
		TriggerGenerateFoliageLods_InPersistentLevelPath_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateFoliageLods_FunctionAddress, "InPersistentLevelPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateFoliageLods_InTargetLevelNameList_PropertyAddress, TriggerGenerateFoliageLods_FunctionAddress, "InTargetLevelNameList");
		TriggerGenerateFoliageLods_InTargetLevelNameList_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateFoliageLods_FunctionAddress, "InTargetLevelNameList");
		TriggerGenerateFoliageLods_InTargetLevelNameList_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateFoliageLods_FunctionAddress, "InTargetLevelNameList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerGenerateFoliageLods_bEnableLevelNameFiltering_PropertyAddress, TriggerGenerateFoliageLods_FunctionAddress, "bEnableLevelNameFiltering");
		TriggerGenerateFoliageLods_bEnableLevelNameFiltering_Offset = NativeReflectionCached.GetPropertyOffset(TriggerGenerateFoliageLods_FunctionAddress, "bEnableLevelNameFiltering");
		TriggerGenerateFoliageLods_bEnableLevelNameFiltering_IsValid = NativeReflectionCached.ValidatePropertyClass(TriggerGenerateFoliageLods_FunctionAddress, "bEnableLevelNameFiltering", Classes.FBoolProperty);
		TriggerGenerateFoliageLods_IsValid = TriggerGenerateFoliageLods_FunctionAddress != IntPtr.Zero && TriggerGenerateFoliageLods_InPersistentLevelPath_IsValid && TriggerGenerateFoliageLods_InTargetLevelNameList_IsValid && TriggerGenerateFoliageLods_bEnableLevelNameFiltering_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:TriggerGenerateFoliageLods", TriggerGenerateFoliageLods_IsValid);
		SetLevelsLayer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLevelsLayer");
		SetLevelsLayer_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelsLayer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsLayer_InRootFolderName_PropertyAddress, SetLevelsLayer_FunctionAddress, "InRootFolderName");
		SetLevelsLayer_InRootFolderName_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsLayer_FunctionAddress, "InRootFolderName");
		SetLevelsLayer_InRootFolderName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsLayer_FunctionAddress, "InRootFolderName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsLayer_TargetLevelNames_PropertyAddress, SetLevelsLayer_FunctionAddress, "TargetLevelNames");
		SetLevelsLayer_TargetLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsLayer_FunctionAddress, "TargetLevelNames");
		SetLevelsLayer_TargetLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsLayer_FunctionAddress, "TargetLevelNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLevelsLayer_TargetLayerName_PropertyAddress, SetLevelsLayer_FunctionAddress, "TargetLayerName");
		SetLevelsLayer_TargetLayerName_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelsLayer_FunctionAddress, "TargetLayerName");
		SetLevelsLayer_TargetLayerName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelsLayer_FunctionAddress, "TargetLayerName", Classes.FStrProperty);
		SetLevelsLayer_IsValid = SetLevelsLayer_FunctionAddress != IntPtr.Zero && SetLevelsLayer_InRootFolderName_IsValid && SetLevelsLayer_TargetLevelNames_IsValid && SetLevelsLayer_TargetLayerName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:SetLevelsLayer", SetLevelsLayer_IsValid);
		SaveAndDestroyLevelPackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveAndDestroyLevelPackage");
		SaveAndDestroyLevelPackage_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveAndDestroyLevelPackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SaveAndDestroyLevelPackage_NewWorld_PropertyAddress, SaveAndDestroyLevelPackage_FunctionAddress, "NewWorld");
		SaveAndDestroyLevelPackage_NewWorld_Offset = NativeReflectionCached.GetPropertyOffset(SaveAndDestroyLevelPackage_FunctionAddress, "NewWorld");
		SaveAndDestroyLevelPackage_NewWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(SaveAndDestroyLevelPackage_FunctionAddress, "NewWorld", Classes.FObjectProperty);
		SaveAndDestroyLevelPackage_IsValid = SaveAndDestroyLevelPackage_FunctionAddress != IntPtr.Zero && SaveAndDestroyLevelPackage_NewWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:SaveAndDestroyLevelPackage", SaveAndDestroyLevelPackage_IsValid);
		MoveNaniteTreesBackToSubLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MoveNaniteTreesBackToSubLevel");
		MoveNaniteTreesBackToSubLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveNaniteTreesBackToSubLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveNaniteTreesBackToSubLevel_InRootFolderName_PropertyAddress, MoveNaniteTreesBackToSubLevel_FunctionAddress, "InRootFolderName");
		MoveNaniteTreesBackToSubLevel_InRootFolderName_Offset = NativeReflectionCached.GetPropertyOffset(MoveNaniteTreesBackToSubLevel_FunctionAddress, "InRootFolderName");
		MoveNaniteTreesBackToSubLevel_InRootFolderName_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveNaniteTreesBackToSubLevel_FunctionAddress, "InRootFolderName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveNaniteTreesBackToSubLevel_TargetTileKeyword_PropertyAddress, MoveNaniteTreesBackToSubLevel_FunctionAddress, "TargetTileKeyword");
		MoveNaniteTreesBackToSubLevel_TargetTileKeyword_Offset = NativeReflectionCached.GetPropertyOffset(MoveNaniteTreesBackToSubLevel_FunctionAddress, "TargetTileKeyword");
		MoveNaniteTreesBackToSubLevel_TargetTileKeyword_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveNaniteTreesBackToSubLevel_FunctionAddress, "TargetTileKeyword", Classes.FStrProperty);
		MoveNaniteTreesBackToSubLevel_IsValid = MoveNaniteTreesBackToSubLevel_FunctionAddress != IntPtr.Zero && MoveNaniteTreesBackToSubLevel_InRootFolderName_IsValid && MoveNaniteTreesBackToSubLevel_TargetTileKeyword_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:MoveNaniteTreesBackToSubLevel", MoveNaniteTreesBackToSubLevel_IsValid);
		LoadSubLevelsIncludeWcTile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadSubLevelsIncludeWcTile");
		LoadSubLevelsIncludeWcTile_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadSubLevelsIncludeWcTile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadSubLevelsIncludeWcTile_InTargetLevelNameList_PropertyAddress, LoadSubLevelsIncludeWcTile_FunctionAddress, "InTargetLevelNameList");
		LoadSubLevelsIncludeWcTile_InTargetLevelNameList_Offset = NativeReflectionCached.GetPropertyOffset(LoadSubLevelsIncludeWcTile_FunctionAddress, "InTargetLevelNameList");
		LoadSubLevelsIncludeWcTile_InTargetLevelNameList_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadSubLevelsIncludeWcTile_FunctionAddress, "InTargetLevelNameList", Classes.FArrayProperty);
		LoadSubLevelsIncludeWcTile_IsValid = LoadSubLevelsIncludeWcTile_FunctionAddress != IntPtr.Zero && LoadSubLevelsIncludeWcTile_InTargetLevelNameList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:LoadSubLevelsIncludeWcTile", LoadSubLevelsIncludeWcTile_IsValid);
		LoadSubLevels_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadSubLevels");
		LoadSubLevels_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadSubLevels_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadSubLevels_InTargetLevelNameList_PropertyAddress, LoadSubLevels_FunctionAddress, "InTargetLevelNameList");
		LoadSubLevels_InTargetLevelNameList_Offset = NativeReflectionCached.GetPropertyOffset(LoadSubLevels_FunctionAddress, "InTargetLevelNameList");
		LoadSubLevels_InTargetLevelNameList_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadSubLevels_FunctionAddress, "InTargetLevelNameList", Classes.FArrayProperty);
		LoadSubLevels_IsValid = LoadSubLevels_FunctionAddress != IntPtr.Zero && LoadSubLevels_InTargetLevelNameList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:LoadSubLevels", LoadSubLevels_IsValid);
		LoadISMJsonInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadISMJsonInfo");
		LoadISMJsonInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadISMJsonInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadISMJsonInfo_InJsonFileName_PropertyAddress, LoadISMJsonInfo_FunctionAddress, "InJsonFileName");
		LoadISMJsonInfo_InJsonFileName_Offset = NativeReflectionCached.GetPropertyOffset(LoadISMJsonInfo_FunctionAddress, "InJsonFileName");
		LoadISMJsonInfo_InJsonFileName_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadISMJsonInfo_FunctionAddress, "InJsonFileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref LoadISMJsonInfo_OutISMBuildInfo_PropertyAddress, LoadISMJsonInfo_FunctionAddress, "OutISMBuildInfo");
		LoadISMJsonInfo_OutISMBuildInfo_Offset = NativeReflectionCached.GetPropertyOffset(LoadISMJsonInfo_FunctionAddress, "OutISMBuildInfo");
		LoadISMJsonInfo_OutISMBuildInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadISMJsonInfo_FunctionAddress, "OutISMBuildInfo", Classes.FArrayProperty);
		LoadISMJsonInfo_IsValid = LoadISMJsonInfo_FunctionAddress != IntPtr.Zero && LoadISMJsonInfo_InJsonFileName_IsValid && LoadISMJsonInfo_OutISMBuildInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:LoadISMJsonInfo", LoadISMJsonInfo_IsValid);
		GetPersistentLevelNameUnderParentFolder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPersistentLevelNameUnderParentFolder");
		GetPersistentLevelNameUnderParentFolder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPersistentLevelNameUnderParentFolder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPersistentLevelNameUnderParentFolder_SrcFolderPath_PropertyAddress, GetPersistentLevelNameUnderParentFolder_FunctionAddress, "SrcFolderPath");
		GetPersistentLevelNameUnderParentFolder_SrcFolderPath_Offset = NativeReflectionCached.GetPropertyOffset(GetPersistentLevelNameUnderParentFolder_FunctionAddress, "SrcFolderPath");
		GetPersistentLevelNameUnderParentFolder_SrcFolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPersistentLevelNameUnderParentFolder_FunctionAddress, "SrcFolderPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPersistentLevelNameUnderParentFolder_ReturnValue_PropertyAddress, GetPersistentLevelNameUnderParentFolder_FunctionAddress, "ReturnValue");
		GetPersistentLevelNameUnderParentFolder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPersistentLevelNameUnderParentFolder_FunctionAddress, "ReturnValue");
		GetPersistentLevelNameUnderParentFolder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPersistentLevelNameUnderParentFolder_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPersistentLevelNameUnderParentFolder_IsValid = GetPersistentLevelNameUnderParentFolder_FunctionAddress != IntPtr.Zero && GetPersistentLevelNameUnderParentFolder_SrcFolderPath_IsValid && GetPersistentLevelNameUnderParentFolder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:GetPersistentLevelNameUnderParentFolder", GetPersistentLevelNameUnderParentFolder_IsValid);
		GetPersistentLevelNameOfSelectedActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPersistentLevelNameOfSelectedActor");
		GetPersistentLevelNameOfSelectedActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPersistentLevelNameOfSelectedActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPersistentLevelNameOfSelectedActor_ReturnValue_PropertyAddress, GetPersistentLevelNameOfSelectedActor_FunctionAddress, "ReturnValue");
		GetPersistentLevelNameOfSelectedActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPersistentLevelNameOfSelectedActor_FunctionAddress, "ReturnValue");
		GetPersistentLevelNameOfSelectedActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPersistentLevelNameOfSelectedActor_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPersistentLevelNameOfSelectedActor_IsValid = GetPersistentLevelNameOfSelectedActor_FunctionAddress != IntPtr.Zero && GetPersistentLevelNameOfSelectedActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:GetPersistentLevelNameOfSelectedActor", GetPersistentLevelNameOfSelectedActor_IsValid);
		GetLevelNameOfSelectedActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelNameOfSelectedActor");
		GetLevelNameOfSelectedActor_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelNameOfSelectedActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelNameOfSelectedActor_ReturnValue_PropertyAddress, GetLevelNameOfSelectedActor_FunctionAddress, "ReturnValue");
		GetLevelNameOfSelectedActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelNameOfSelectedActor_FunctionAddress, "ReturnValue");
		GetLevelNameOfSelectedActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelNameOfSelectedActor_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetLevelNameOfSelectedActor_IsValid = GetLevelNameOfSelectedActor_FunctionAddress != IntPtr.Zero && GetLevelNameOfSelectedActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:GetLevelNameOfSelectedActor", GetLevelNameOfSelectedActor_IsValid);
		GenActorStatFileAsync_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenActorStatFileAsync");
		GenActorStatFileAsync_ParamsSize = NativeReflection.GetFunctionParamsSize(GenActorStatFileAsync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenActorStatFileAsync_SourceRootDirectory_PropertyAddress, GenActorStatFileAsync_FunctionAddress, "SourceRootDirectory");
		GenActorStatFileAsync_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(GenActorStatFileAsync_FunctionAddress, "SourceRootDirectory");
		GenActorStatFileAsync_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(GenActorStatFileAsync_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenActorStatFileAsync_TargetStatFileDirectory_PropertyAddress, GenActorStatFileAsync_FunctionAddress, "TargetStatFileDirectory");
		GenActorStatFileAsync_TargetStatFileDirectory_Offset = NativeReflectionCached.GetPropertyOffset(GenActorStatFileAsync_FunctionAddress, "TargetStatFileDirectory");
		GenActorStatFileAsync_TargetStatFileDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(GenActorStatFileAsync_FunctionAddress, "TargetStatFileDirectory", Classes.FStrProperty);
		GenActorStatFileAsync_IsValid = GenActorStatFileAsync_FunctionAddress != IntPtr.Zero && GenActorStatFileAsync_SourceRootDirectory_IsValid && GenActorStatFileAsync_TargetStatFileDirectory_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:GenActorStatFileAsync", GenActorStatFileAsync_IsValid);
		GenActorStatFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GenActorStatFile");
		GenActorStatFile_ParamsSize = NativeReflection.GetFunctionParamsSize(GenActorStatFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenActorStatFile_SourceRootDirectory_PropertyAddress, GenActorStatFile_FunctionAddress, "SourceRootDirectory");
		GenActorStatFile_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(GenActorStatFile_FunctionAddress, "SourceRootDirectory");
		GenActorStatFile_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(GenActorStatFile_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenActorStatFile_TargetStatFilePath_PropertyAddress, GenActorStatFile_FunctionAddress, "TargetStatFilePath");
		GenActorStatFile_TargetStatFilePath_Offset = NativeReflectionCached.GetPropertyOffset(GenActorStatFile_FunctionAddress, "TargetStatFilePath");
		GenActorStatFile_TargetStatFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(GenActorStatFile_FunctionAddress, "TargetStatFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GenActorStatFile_bDescendSorting_PropertyAddress, GenActorStatFile_FunctionAddress, "bDescendSorting");
		GenActorStatFile_bDescendSorting_Offset = NativeReflectionCached.GetPropertyOffset(GenActorStatFile_FunctionAddress, "bDescendSorting");
		GenActorStatFile_bDescendSorting_IsValid = NativeReflectionCached.ValidatePropertyClass(GenActorStatFile_FunctionAddress, "bDescendSorting", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenActorStatFile_StatInfoFlag_PropertyAddress, GenActorStatFile_FunctionAddress, "StatInfoFlag");
		GenActorStatFile_StatInfoFlag_Offset = NativeReflectionCached.GetPropertyOffset(GenActorStatFile_FunctionAddress, "StatInfoFlag");
		GenActorStatFile_StatInfoFlag_IsValid = NativeReflectionCached.ValidatePropertyClass(GenActorStatFile_FunctionAddress, "StatInfoFlag", Classes.FIntProperty);
		GenActorStatFile_IsValid = GenActorStatFile_FunctionAddress != IntPtr.Zero && GenActorStatFile_SourceRootDirectory_IsValid && GenActorStatFile_TargetStatFilePath_IsValid && GenActorStatFile_bDescendSorting_IsValid && GenActorStatFile_StatInfoFlag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:GenActorStatFile", GenActorStatFile_IsValid);
		FilterLevelsByLevelBoundsLength_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FilterLevelsByLevelBoundsLength");
		FilterLevelsByLevelBoundsLength_ParamsSize = NativeReflection.GetFunctionParamsSize(FilterLevelsByLevelBoundsLength_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FilterLevelsByLevelBoundsLength_SourceRootDirectory_PropertyAddress, FilterLevelsByLevelBoundsLength_FunctionAddress, "SourceRootDirectory");
		FilterLevelsByLevelBoundsLength_SourceRootDirectory_Offset = NativeReflectionCached.GetPropertyOffset(FilterLevelsByLevelBoundsLength_FunctionAddress, "SourceRootDirectory");
		FilterLevelsByLevelBoundsLength_SourceRootDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterLevelsByLevelBoundsLength_FunctionAddress, "SourceRootDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterLevelsByLevelBoundsLength_InThreshold_PropertyAddress, FilterLevelsByLevelBoundsLength_FunctionAddress, "InThreshold");
		FilterLevelsByLevelBoundsLength_InThreshold_Offset = NativeReflectionCached.GetPropertyOffset(FilterLevelsByLevelBoundsLength_FunctionAddress, "InThreshold");
		FilterLevelsByLevelBoundsLength_InThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterLevelsByLevelBoundsLength_FunctionAddress, "InThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterLevelsByLevelBoundsLength_bAscending_PropertyAddress, FilterLevelsByLevelBoundsLength_FunctionAddress, "bAscending");
		FilterLevelsByLevelBoundsLength_bAscending_Offset = NativeReflectionCached.GetPropertyOffset(FilterLevelsByLevelBoundsLength_FunctionAddress, "bAscending");
		FilterLevelsByLevelBoundsLength_bAscending_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterLevelsByLevelBoundsLength_FunctionAddress, "bAscending", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FilterLevelsByLevelBoundsLength_ReturnValue_PropertyAddress, FilterLevelsByLevelBoundsLength_FunctionAddress, "ReturnValue");
		FilterLevelsByLevelBoundsLength_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FilterLevelsByLevelBoundsLength_FunctionAddress, "ReturnValue");
		FilterLevelsByLevelBoundsLength_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FilterLevelsByLevelBoundsLength_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FilterLevelsByLevelBoundsLength_IsValid = FilterLevelsByLevelBoundsLength_FunctionAddress != IntPtr.Zero && FilterLevelsByLevelBoundsLength_SourceRootDirectory_IsValid && FilterLevelsByLevelBoundsLength_InThreshold_IsValid && FilterLevelsByLevelBoundsLength_bAscending_IsValid && FilterLevelsByLevelBoundsLength_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:FilterLevelsByLevelBoundsLength", FilterLevelsByLevelBoundsLength_IsValid);
		ExtractLevelSMInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ExtractLevelSMInfo");
		ExtractLevelSMInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(ExtractLevelSMInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ExtractLevelSMInfo_InRootFolderName_PropertyAddress, ExtractLevelSMInfo_FunctionAddress, "InRootFolderName");
		ExtractLevelSMInfo_InRootFolderName_Offset = NativeReflectionCached.GetPropertyOffset(ExtractLevelSMInfo_FunctionAddress, "InRootFolderName");
		ExtractLevelSMInfo_InRootFolderName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractLevelSMInfo_FunctionAddress, "InRootFolderName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractLevelSMInfo_InLevelName_PropertyAddress, ExtractLevelSMInfo_FunctionAddress, "InLevelName");
		ExtractLevelSMInfo_InLevelName_Offset = NativeReflectionCached.GetPropertyOffset(ExtractLevelSMInfo_FunctionAddress, "InLevelName");
		ExtractLevelSMInfo_InLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractLevelSMInfo_FunctionAddress, "InLevelName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ExtractLevelSMInfo_bLogDebug_PropertyAddress, ExtractLevelSMInfo_FunctionAddress, "bLogDebug");
		ExtractLevelSMInfo_bLogDebug_Offset = NativeReflectionCached.GetPropertyOffset(ExtractLevelSMInfo_FunctionAddress, "bLogDebug");
		ExtractLevelSMInfo_bLogDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(ExtractLevelSMInfo_FunctionAddress, "bLogDebug", Classes.FBoolProperty);
		ExtractLevelSMInfo_IsValid = ExtractLevelSMInfo_FunctionAddress != IntPtr.Zero && ExtractLevelSMInfo_InRootFolderName_IsValid && ExtractLevelSMInfo_InLevelName_IsValid && ExtractLevelSMInfo_bLogDebug_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:ExtractLevelSMInfo", ExtractLevelSMInfo_IsValid);
		CreateNewLevelPackageAndReturn_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateNewLevelPackageAndReturn");
		CreateNewLevelPackageAndReturn_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateNewLevelPackageAndReturn_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateNewLevelPackageAndReturn_TargetFolder_PropertyAddress, CreateNewLevelPackageAndReturn_FunctionAddress, "TargetFolder");
		CreateNewLevelPackageAndReturn_TargetFolder_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewLevelPackageAndReturn_FunctionAddress, "TargetFolder");
		CreateNewLevelPackageAndReturn_TargetFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewLevelPackageAndReturn_FunctionAddress, "TargetFolder", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewLevelPackageAndReturn_TargetMapName_PropertyAddress, CreateNewLevelPackageAndReturn_FunctionAddress, "TargetMapName");
		CreateNewLevelPackageAndReturn_TargetMapName_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewLevelPackageAndReturn_FunctionAddress, "TargetMapName");
		CreateNewLevelPackageAndReturn_TargetMapName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewLevelPackageAndReturn_FunctionAddress, "TargetMapName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewLevelPackageAndReturn_ReturnValue_PropertyAddress, CreateNewLevelPackageAndReturn_FunctionAddress, "ReturnValue");
		CreateNewLevelPackageAndReturn_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewLevelPackageAndReturn_FunctionAddress, "ReturnValue");
		CreateNewLevelPackageAndReturn_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewLevelPackageAndReturn_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateNewLevelPackageAndReturn_IsValid = CreateNewLevelPackageAndReturn_FunctionAddress != IntPtr.Zero && CreateNewLevelPackageAndReturn_TargetFolder_IsValid && CreateNewLevelPackageAndReturn_TargetMapName_IsValid && CreateNewLevelPackageAndReturn_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:CreateNewLevelPackageAndReturn", CreateNewLevelPackageAndReturn_IsValid);
		CreateNewLevelPackage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateNewLevelPackage");
		CreateNewLevelPackage_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateNewLevelPackage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateNewLevelPackage_TargetFolder_PropertyAddress, CreateNewLevelPackage_FunctionAddress, "TargetFolder");
		CreateNewLevelPackage_TargetFolder_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewLevelPackage_FunctionAddress, "TargetFolder");
		CreateNewLevelPackage_TargetFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewLevelPackage_FunctionAddress, "TargetFolder", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateNewLevelPackage_TargetMapName_PropertyAddress, CreateNewLevelPackage_FunctionAddress, "TargetMapName");
		CreateNewLevelPackage_TargetMapName_Offset = NativeReflectionCached.GetPropertyOffset(CreateNewLevelPackage_FunctionAddress, "TargetMapName");
		CreateNewLevelPackage_TargetMapName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateNewLevelPackage_FunctionAddress, "TargetMapName", Classes.FStrProperty);
		CreateNewLevelPackage_IsValid = CreateNewLevelPackage_FunctionAddress != IntPtr.Zero && CreateNewLevelPackage_TargetFolder_IsValid && CreateNewLevelPackage_TargetMapName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:CreateNewLevelPackage", CreateNewLevelPackage_IsValid);
		CreateLodLevelAndSpawnLodActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateLodLevelAndSpawnLodActor");
		CreateLodLevelAndSpawnLodActor_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateLodLevelAndSpawnLodActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateLodLevelAndSpawnLodActor_InLODLevelPackageName_PropertyAddress, CreateLodLevelAndSpawnLodActor_FunctionAddress, "InLODLevelPackageName");
		CreateLodLevelAndSpawnLodActor_InLODLevelPackageName_Offset = NativeReflectionCached.GetPropertyOffset(CreateLodLevelAndSpawnLodActor_FunctionAddress, "InLODLevelPackageName");
		CreateLodLevelAndSpawnLodActor_InLODLevelPackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLodLevelAndSpawnLodActor_FunctionAddress, "InLODLevelPackageName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateLodLevelAndSpawnLodActor_InLODStaticMesh_PropertyAddress, CreateLodLevelAndSpawnLodActor_FunctionAddress, "InLODStaticMesh");
		CreateLodLevelAndSpawnLodActor_InLODStaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(CreateLodLevelAndSpawnLodActor_FunctionAddress, "InLODStaticMesh");
		CreateLodLevelAndSpawnLodActor_InLODStaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLodLevelAndSpawnLodActor_FunctionAddress, "InLODStaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateLodLevelAndSpawnLodActor_InSpawnTransform_PropertyAddress, CreateLodLevelAndSpawnLodActor_FunctionAddress, "InSpawnTransform");
		CreateLodLevelAndSpawnLodActor_InSpawnTransform_Offset = NativeReflectionCached.GetPropertyOffset(CreateLodLevelAndSpawnLodActor_FunctionAddress, "InSpawnTransform");
		CreateLodLevelAndSpawnLodActor_InSpawnTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateLodLevelAndSpawnLodActor_FunctionAddress, "InSpawnTransform", Classes.FStructProperty);
		CreateLodLevelAndSpawnLodActor_IsValid = CreateLodLevelAndSpawnLodActor_FunctionAddress != IntPtr.Zero && CreateLodLevelAndSpawnLodActor_InLODLevelPackageName_IsValid && CreateLodLevelAndSpawnLodActor_InLODStaticMesh_IsValid && CreateLodLevelAndSpawnLodActor_InSpawnTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:CreateLodLevelAndSpawnLodActor", CreateLodLevelAndSpawnLodActor_IsValid);
		CheckActorNumMatches_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckActorNumMatches");
		CheckActorNumMatches_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckActorNumMatches_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckActorNumMatches_Before_PropertyAddress, CheckActorNumMatches_FunctionAddress, "Before");
		CheckActorNumMatches_Before_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorNumMatches_FunctionAddress, "Before");
		CheckActorNumMatches_Before_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorNumMatches_FunctionAddress, "Before", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckActorNumMatches_After_PropertyAddress, CheckActorNumMatches_FunctionAddress, "After");
		CheckActorNumMatches_After_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorNumMatches_FunctionAddress, "After");
		CheckActorNumMatches_After_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorNumMatches_FunctionAddress, "After", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckActorNumMatches_TargetDiffFilePath_PropertyAddress, CheckActorNumMatches_FunctionAddress, "TargetDiffFilePath");
		CheckActorNumMatches_TargetDiffFilePath_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorNumMatches_FunctionAddress, "TargetDiffFilePath");
		CheckActorNumMatches_TargetDiffFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorNumMatches_FunctionAddress, "TargetDiffFilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckActorNumMatches_ReturnValue_PropertyAddress, CheckActorNumMatches_FunctionAddress, "ReturnValue");
		CheckActorNumMatches_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckActorNumMatches_FunctionAddress, "ReturnValue");
		CheckActorNumMatches_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckActorNumMatches_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckActorNumMatches_IsValid = CheckActorNumMatches_FunctionAddress != IntPtr.Zero && CheckActorNumMatches_Before_IsValid && CheckActorNumMatches_After_IsValid && CheckActorNumMatches_TargetDiffFilePath_IsValid && CheckActorNumMatches_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:CheckActorNumMatches", CheckActorNumMatches_IsValid);
		BuildTileLevelISMInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BuildTileLevelISMInfo");
		BuildTileLevelISMInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildTileLevelISMInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildTileLevelISMInfo_InRootFolderName_PropertyAddress, BuildTileLevelISMInfo_FunctionAddress, "InRootFolderName");
		BuildTileLevelISMInfo_InRootFolderName_Offset = NativeReflectionCached.GetPropertyOffset(BuildTileLevelISMInfo_FunctionAddress, "InRootFolderName");
		BuildTileLevelISMInfo_InRootFolderName_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildTileLevelISMInfo_FunctionAddress, "InRootFolderName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildTileLevelISMInfo_InTargetLevelName_PropertyAddress, BuildTileLevelISMInfo_FunctionAddress, "InTargetLevelName");
		BuildTileLevelISMInfo_InTargetLevelName_Offset = NativeReflectionCached.GetPropertyOffset(BuildTileLevelISMInfo_FunctionAddress, "InTargetLevelName");
		BuildTileLevelISMInfo_InTargetLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildTileLevelISMInfo_FunctionAddress, "InTargetLevelName", Classes.FStrProperty);
		BuildTileLevelISMInfo_IsValid = BuildTileLevelISMInfo_FunctionAddress != IntPtr.Zero && BuildTileLevelISMInfo_InRootFolderName_IsValid && BuildTileLevelISMInfo_InTargetLevelName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSEditorWCLibrary:BuildTileLevelISMInfo", BuildTileLevelISMInfo_IsValid);
	}
}
