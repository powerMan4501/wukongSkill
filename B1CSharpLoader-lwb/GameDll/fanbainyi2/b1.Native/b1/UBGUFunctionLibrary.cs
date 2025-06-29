using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using b1.Plugins.TressFX;
using UnrealEngine.Engine;
using UnrealEngine.GeometryCollectionEngine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGUFunctionLibrary", "b1", UnrealModuleType.Game)]
public class UBGUFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool WrapHitResult_IsValid;

	private static IntPtr WrapHitResult_FunctionAddress;

	private static int WrapHitResult_ParamsSize;

	private static bool WrapHitResult_HitResult_IsValid;

	private static FFieldAddress WrapHitResult_HitResult_PropertyAddress;

	private static int WrapHitResult_HitResult_Offset;

	private static bool WrapHitResult_ReturnValue_IsValid;

	private static FFieldAddress WrapHitResult_ReturnValue_PropertyAddress;

	private static int WrapHitResult_ReturnValue_Offset;

	private static bool VolumeEncompassPoint_IsValid;

	private static IntPtr VolumeEncompassPoint_FunctionAddress;

	private static int VolumeEncompassPoint_ParamsSize;

	private static bool VolumeEncompassPoint_Volume_IsValid;

	private static FFieldAddress VolumeEncompassPoint_Volume_PropertyAddress;

	private static int VolumeEncompassPoint_Volume_Offset;

	private static bool VolumeEncompassPoint_Point_IsValid;

	private static FFieldAddress VolumeEncompassPoint_Point_PropertyAddress;

	private static int VolumeEncompassPoint_Point_Offset;

	private static bool VolumeEncompassPoint_SphereRadius_IsValid;

	private static FFieldAddress VolumeEncompassPoint_SphereRadius_PropertyAddress;

	private static int VolumeEncompassPoint_SphereRadius_Offset;

	private static bool VolumeEncompassPoint_OutDistanceToPoint_IsValid;

	private static FFieldAddress VolumeEncompassPoint_OutDistanceToPoint_PropertyAddress;

	private static int VolumeEncompassPoint_OutDistanceToPoint_Offset;

	private static bool VolumeEncompassPoint_ReturnValue_IsValid;

	private static FFieldAddress VolumeEncompassPoint_ReturnValue_PropertyAddress;

	private static int VolumeEncompassPoint_ReturnValue_Offset;

	private static bool SphereComponentInitRadius_IsValid;

	private static IntPtr SphereComponentInitRadius_FunctionAddress;

	private static int SphereComponentInitRadius_ParamsSize;

	private static bool SphereComponentInitRadius_SphereComp_IsValid;

	private static FFieldAddress SphereComponentInitRadius_SphereComp_PropertyAddress;

	private static int SphereComponentInitRadius_SphereComp_Offset;

	private static bool SphereComponentInitRadius_Radius_IsValid;

	private static FFieldAddress SphereComponentInitRadius_Radius_PropertyAddress;

	private static int SphereComponentInitRadius_Radius_Offset;

	private static bool SetLocalKinematics_IsValid;

	private static IntPtr SetLocalKinematics_FunctionAddress;

	private static int SetLocalKinematics_ParamsSize;

	private static bool SetLocalKinematics_TargetMesh_IsValid;

	private static FFieldAddress SetLocalKinematics_TargetMesh_PropertyAddress;

	private static int SetLocalKinematics_TargetMesh_Offset;

	private static bool SetLocalKinematics_NewBool_IsValid;

	private static FFieldAddress SetLocalKinematics_NewBool_PropertyAddress;

	private static int SetLocalKinematics_NewBool_Offset;

	private static bool SetIKValid_IsValid;

	private static IntPtr SetIKValid_FunctionAddress;

	private static int SetIKValid_ParamsSize;

	private static bool SetIKValid_Character_IsValid;

	private static FFieldAddress SetIKValid_Character_PropertyAddress;

	private static int SetIKValid_Character_Offset;

	private static bool SetIKValid_NewValid_IsValid;

	private static FFieldAddress SetIKValid_NewValid_PropertyAddress;

	private static int SetIKValid_NewValid_Offset;

	private static bool SetBodyBonePhysic_IsValid;

	private static IntPtr SetBodyBonePhysic_FunctionAddress;

	private static int SetBodyBonePhysic_ParamsSize;

	private static bool SetBodyBonePhysic_TargetMesh_IsValid;

	private static FFieldAddress SetBodyBonePhysic_TargetMesh_PropertyAddress;

	private static int SetBodyBonePhysic_TargetMesh_Offset;

	private static bool SetBodyBonePhysic_BoneName_IsValid;

	private static FFieldAddress SetBodyBonePhysic_BoneName_PropertyAddress;

	private static int SetBodyBonePhysic_BoneName_Offset;

	private static bool SetBodyBonePhysic_NewBool_IsValid;

	private static FFieldAddress SetBodyBonePhysic_NewBool_PropertyAddress;

	private static int SetBodyBonePhysic_NewBool_Offset;

	private static bool SetAllBodiesBelowSimulatePhysics_IsValid;

	private static IntPtr SetAllBodiesBelowSimulatePhysics_FunctionAddress;

	private static int SetAllBodiesBelowSimulatePhysics_ParamsSize;

	private static bool SetAllBodiesBelowSimulatePhysics_TargetMesh_IsValid;

	private static FFieldAddress SetAllBodiesBelowSimulatePhysics_TargetMesh_PropertyAddress;

	private static int SetAllBodiesBelowSimulatePhysics_TargetMesh_Offset;

	private static bool SetAllBodiesBelowSimulatePhysics_InBoneName_IsValid;

	private static FFieldAddress SetAllBodiesBelowSimulatePhysics_InBoneName_PropertyAddress;

	private static int SetAllBodiesBelowSimulatePhysics_InBoneName_Offset;

	private static bool SetAllBodiesBelowSimulatePhysics_bNewSimulate_IsValid;

	private static FFieldAddress SetAllBodiesBelowSimulatePhysics_bNewSimulate_PropertyAddress;

	private static int SetAllBodiesBelowSimulatePhysics_bNewSimulate_Offset;

	private static bool SetAllBodiesBelowSimulatePhysics_bIncludeSelf_IsValid;

	private static FFieldAddress SetAllBodiesBelowSimulatePhysics_bIncludeSelf_PropertyAddress;

	private static int SetAllBodiesBelowSimulatePhysics_bIncludeSelf_Offset;

	private static bool SetAllBodiesBelowSimulatePhysics_bSkipCustomPhysicsType_IsValid;

	private static FFieldAddress SetAllBodiesBelowSimulatePhysics_bSkipCustomPhysicsType_PropertyAddress;

	private static int SetAllBodiesBelowSimulatePhysics_bSkipCustomPhysicsType_Offset;

	private static bool SerializeActorComponentToLevelActor_IsValid;

	private static IntPtr SerializeActorComponentToLevelActor_FunctionAddress;

	private static int SerializeActorComponentToLevelActor_ParamsSize;

	private static bool SerializeActorComponentToLevelActor_TargetLevelActor_IsValid;

	private static FFieldAddress SerializeActorComponentToLevelActor_TargetLevelActor_PropertyAddress;

	private static int SerializeActorComponentToLevelActor_TargetLevelActor_Offset;

	private static bool SerializeActorComponentToLevelActor_InActorComponent_IsValid;

	private static FFieldAddress SerializeActorComponentToLevelActor_InActorComponent_PropertyAddress;

	private static int SerializeActorComponentToLevelActor_InActorComponent_Offset;

	private static bool ReplaceAllAnimNotifyStates_IsValid;

	private static IntPtr ReplaceAllAnimNotifyStates_FunctionAddress;

	private static int ReplaceAllAnimNotifyStates_ParamsSize;

	private static bool ReplaceAllAnimNotifyStates_ResourcePath_IsValid;

	private static FFieldAddress ReplaceAllAnimNotifyStates_ResourcePath_PropertyAddress;

	private static int ReplaceAllAnimNotifyStates_ResourcePath_Offset;

	private static bool ReplaceAllAnimNotifyStates_OldNotifyStateClass_IsValid;

	private static FFieldAddress ReplaceAllAnimNotifyStates_OldNotifyStateClass_PropertyAddress;

	private static int ReplaceAllAnimNotifyStates_OldNotifyStateClass_Offset;

	private static bool ReplaceAllAnimNotifyStates_NewNotifyStateClass_IsValid;

	private static FFieldAddress ReplaceAllAnimNotifyStates_NewNotifyStateClass_PropertyAddress;

	private static int ReplaceAllAnimNotifyStates_NewNotifyStateClass_Offset;

	private static bool RemoveLevelStreaming_IsValid;

	private static IntPtr RemoveLevelStreaming_FunctionAddress;

	private static int RemoveLevelStreaming_ParamsSize;

	private static bool RemoveLevelStreaming_WorldContextObject_IsValid;

	private static FFieldAddress RemoveLevelStreaming_WorldContextObject_PropertyAddress;

	private static int RemoveLevelStreaming_WorldContextObject_Offset;

	private static bool RemoveLevelStreaming_LevelName_IsValid;

	private static FFieldAddress RemoveLevelStreaming_LevelName_PropertyAddress;

	private static int RemoveLevelStreaming_LevelName_Offset;

	private static bool RemoveActorComponentFromLevelActor_IsValid;

	private static IntPtr RemoveActorComponentFromLevelActor_FunctionAddress;

	private static int RemoveActorComponentFromLevelActor_ParamsSize;

	private static bool RemoveActorComponentFromLevelActor_TargetLevelActor_IsValid;

	private static FFieldAddress RemoveActorComponentFromLevelActor_TargetLevelActor_PropertyAddress;

	private static int RemoveActorComponentFromLevelActor_TargetLevelActor_Offset;

	private static bool RemoveActorComponentFromLevelActor_InActorComponent_IsValid;

	private static FFieldAddress RemoveActorComponentFromLevelActor_InActorComponent_PropertyAddress;

	private static int RemoveActorComponentFromLevelActor_InActorComponent_Offset;

	private static bool MoveLevel_IsValid;

	private static IntPtr MoveLevel_FunctionAddress;

	private static int MoveLevel_ParamsSize;

	private static bool MoveLevel_WorldContextObject_IsValid;

	private static FFieldAddress MoveLevel_WorldContextObject_PropertyAddress;

	private static int MoveLevel_WorldContextObject_Offset;

	private static bool MoveLevel_LevelName_IsValid;

	private static FFieldAddress MoveLevel_LevelName_PropertyAddress;

	private static int MoveLevel_LevelName_Offset;

	private static bool MoveLevel_InWorldOffset_IsValid;

	private static FFieldAddress MoveLevel_InWorldOffset_PropertyAddress;

	private static int MoveLevel_InWorldOffset_Offset;

	private static bool MoveLevel_bActorOnly_IsValid;

	private static FFieldAddress MoveLevel_bActorOnly_PropertyAddress;

	private static int MoveLevel_bActorOnly_Offset;

	private static bool MakeUniqueTamerMonsterName_IsValid;

	private static IntPtr MakeUniqueTamerMonsterName_FunctionAddress;

	private static int MakeUniqueTamerMonsterName_ParamsSize;

	private static bool MakeUniqueTamerMonsterName_SpawnLevel_IsValid;

	private static FFieldAddress MakeUniqueTamerMonsterName_SpawnLevel_PropertyAddress;

	private static int MakeUniqueTamerMonsterName_SpawnLevel_Offset;

	private static bool MakeUniqueTamerMonsterName_InBaseName_IsValid;

	private static FFieldAddress MakeUniqueTamerMonsterName_InBaseName_PropertyAddress;

	private static int MakeUniqueTamerMonsterName_InBaseName_Offset;

	private static bool MakeUniqueTamerMonsterName_ReturnValue_IsValid;

	private static FFieldAddress MakeUniqueTamerMonsterName_ReturnValue_PropertyAddress;

	private static int MakeUniqueTamerMonsterName_ReturnValue_Offset;

	private static bool GetStreamingVolumeBounds_IsValid;

	private static IntPtr GetStreamingVolumeBounds_FunctionAddress;

	private static int GetStreamingVolumeBounds_ParamsSize;

	private static bool GetStreamingVolumeBounds_LevelStreaming_IsValid;

	private static FFieldAddress GetStreamingVolumeBounds_LevelStreaming_PropertyAddress;

	private static int GetStreamingVolumeBounds_LevelStreaming_Offset;

	private static bool GetStreamingVolumeBounds_ReturnValue_IsValid;

	private static FFieldAddress GetStreamingVolumeBounds_ReturnValue_PropertyAddress;

	private static int GetStreamingVolumeBounds_ReturnValue_Offset;

	private static bool GetScalarParameterValueByInfo_IsValid;

	private static IntPtr GetScalarParameterValueByInfo_FunctionAddress;

	private static int GetScalarParameterValueByInfo_ParamsSize;

	private static bool GetScalarParameterValueByInfo_Mat_IsValid;

	private static FFieldAddress GetScalarParameterValueByInfo_Mat_PropertyAddress;

	private static int GetScalarParameterValueByInfo_Mat_Offset;

	private static bool GetScalarParameterValueByInfo_ParameterInfo_IsValid;

	private static FFieldAddress GetScalarParameterValueByInfo_ParameterInfo_PropertyAddress;

	private static int GetScalarParameterValueByInfo_ParameterInfo_Offset;

	private static bool GetScalarParameterValueByInfo_ReturnValue_IsValid;

	private static FFieldAddress GetScalarParameterValueByInfo_ReturnValue_PropertyAddress;

	private static int GetScalarParameterValueByInfo_ReturnValue_Offset;

	private static bool GetPreviewMesh_IsValid;

	private static IntPtr GetPreviewMesh_FunctionAddress;

	private static int GetPreviewMesh_ParamsSize;

	private static bool GetPreviewMesh_Skeleton_IsValid;

	private static FFieldAddress GetPreviewMesh_Skeleton_PropertyAddress;

	private static int GetPreviewMesh_Skeleton_Offset;

	private static bool GetPreviewMesh_bFindIfNotSet_IsValid;

	private static FFieldAddress GetPreviewMesh_bFindIfNotSet_PropertyAddress;

	private static int GetPreviewMesh_bFindIfNotSet_Offset;

	private static bool GetPreviewMesh_ReturnValue_IsValid;

	private static FFieldAddress GetPreviewMesh_ReturnValue_PropertyAddress;

	private static int GetPreviewMesh_ReturnValue_Offset;

	private static bool GetPlayerCharacter_IsValid;

	private static IntPtr GetPlayerCharacter_FunctionAddress;

	private static int GetPlayerCharacter_ParamsSize;

	private static bool GetPlayerCharacter_WorldContextObject_IsValid;

	private static FFieldAddress GetPlayerCharacter_WorldContextObject_PropertyAddress;

	private static int GetPlayerCharacter_WorldContextObject_Offset;

	private static bool GetPlayerCharacter_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerCharacter_ReturnValue_PropertyAddress;

	private static int GetPlayerCharacter_ReturnValue_Offset;

	private static bool GetNearestBoneName_IsValid;

	private static IntPtr GetNearestBoneName_FunctionAddress;

	private static int GetNearestBoneName_ParamsSize;

	private static bool GetNearestBoneName_TargetSkeletalMesh_IsValid;

	private static FFieldAddress GetNearestBoneName_TargetSkeletalMesh_PropertyAddress;

	private static int GetNearestBoneName_TargetSkeletalMesh_Offset;

	private static bool GetNearestBoneName_WorldPosition_IsValid;

	private static FFieldAddress GetNearestBoneName_WorldPosition_PropertyAddress;

	private static int GetNearestBoneName_WorldPosition_Offset;

	private static bool GetNearestBoneName_OptionalWhiteList_IsValid;

	private static FFieldAddress GetNearestBoneName_OptionalWhiteList_PropertyAddress;

	private static int GetNearestBoneName_OptionalWhiteList_Offset;

	private static bool GetNearestBoneName_ReturnValue_IsValid;

	private static FFieldAddress GetNearestBoneName_ReturnValue_PropertyAddress;

	private static int GetNearestBoneName_ReturnValue_Offset;

	private static bool GetLinearColorParameterValueByInfo_IsValid;

	private static IntPtr GetLinearColorParameterValueByInfo_FunctionAddress;

	private static int GetLinearColorParameterValueByInfo_ParamsSize;

	private static bool GetLinearColorParameterValueByInfo_Mat_IsValid;

	private static FFieldAddress GetLinearColorParameterValueByInfo_Mat_PropertyAddress;

	private static int GetLinearColorParameterValueByInfo_Mat_Offset;

	private static bool GetLinearColorParameterValueByInfo_ParameterInfo_IsValid;

	private static FFieldAddress GetLinearColorParameterValueByInfo_ParameterInfo_PropertyAddress;

	private static int GetLinearColorParameterValueByInfo_ParameterInfo_Offset;

	private static bool GetLinearColorParameterValueByInfo_OutValue_IsValid;

	private static FFieldAddress GetLinearColorParameterValueByInfo_OutValue_PropertyAddress;

	private static int GetLinearColorParameterValueByInfo_OutValue_Offset;

	private static bool GetLinearColorParameterValueByInfo_bOveriddenOnly_IsValid;

	private static FFieldAddress GetLinearColorParameterValueByInfo_bOveriddenOnly_PropertyAddress;

	private static int GetLinearColorParameterValueByInfo_bOveriddenOnly_Offset;

	private static bool GetLinearColorParameterValueByInfo_ReturnValue_IsValid;

	private static FFieldAddress GetLinearColorParameterValueByInfo_ReturnValue_PropertyAddress;

	private static int GetLinearColorParameterValueByInfo_ReturnValue_Offset;

	private static bool GetLevelStreamingState_IsValid;

	private static IntPtr GetLevelStreamingState_FunctionAddress;

	private static int GetLevelStreamingState_ParamsSize;

	private static bool GetLevelStreamingState_WorldContextObject_IsValid;

	private static FFieldAddress GetLevelStreamingState_WorldContextObject_PropertyAddress;

	private static int GetLevelStreamingState_WorldContextObject_Offset;

	private static bool GetLevelStreamingState_LevelName_IsValid;

	private static FFieldAddress GetLevelStreamingState_LevelName_PropertyAddress;

	private static int GetLevelStreamingState_LevelName_Offset;

	private static bool GetLevelStreamingState_ReturnValue_IsValid;

	private static FFieldAddress GetLevelStreamingState_ReturnValue_PropertyAddress;

	private static int GetLevelStreamingState_ReturnValue_Offset;

	private static bool GetLevelStreamingLevelTransformByName_IsValid;

	private static IntPtr GetLevelStreamingLevelTransformByName_FunctionAddress;

	private static int GetLevelStreamingLevelTransformByName_ParamsSize;

	private static bool GetLevelStreamingLevelTransformByName_WorldContextObject_IsValid;

	private static FFieldAddress GetLevelStreamingLevelTransformByName_WorldContextObject_PropertyAddress;

	private static int GetLevelStreamingLevelTransformByName_WorldContextObject_Offset;

	private static bool GetLevelStreamingLevelTransformByName_LevelName_IsValid;

	private static FFieldAddress GetLevelStreamingLevelTransformByName_LevelName_PropertyAddress;

	private static int GetLevelStreamingLevelTransformByName_LevelName_Offset;

	private static bool GetLevelStreamingLevelTransformByName_ReturnValue_IsValid;

	private static FFieldAddress GetLevelStreamingLevelTransformByName_ReturnValue_PropertyAddress;

	private static int GetLevelStreamingLevelTransformByName_ReturnValue_Offset;

	private static bool GetLevelStreamingFromWorld_IsValid;

	private static IntPtr GetLevelStreamingFromWorld_FunctionAddress;

	private static int GetLevelStreamingFromWorld_ParamsSize;

	private static bool GetLevelStreamingFromWorld_World_IsValid;

	private static FFieldAddress GetLevelStreamingFromWorld_World_PropertyAddress;

	private static int GetLevelStreamingFromWorld_World_Offset;

	private static bool GetLevelStreamingFromWorld_ReturnValue_IsValid;

	private static FFieldAddress GetLevelStreamingFromWorld_ReturnValue_PropertyAddress;

	private static int GetLevelStreamingFromWorld_ReturnValue_Offset;

	private static bool GetLevelStreaming_IsValid;

	private static IntPtr GetLevelStreaming_FunctionAddress;

	private static int GetLevelStreaming_ParamsSize;

	private static bool GetLevelStreaming_WorldContextObject_IsValid;

	private static FFieldAddress GetLevelStreaming_WorldContextObject_PropertyAddress;

	private static int GetLevelStreaming_WorldContextObject_Offset;

	private static bool GetLevelStreaming_ReturnValue_IsValid;

	private static FFieldAddress GetLevelStreaming_ReturnValue_PropertyAddress;

	private static int GetLevelStreaming_ReturnValue_Offset;

	private static bool GetAssetLongPackageName_IsValid;

	private static IntPtr GetAssetLongPackageName_FunctionAddress;

	private static int GetAssetLongPackageName_ParamsSize;

	private static bool GetAssetLongPackageName_ClassName_IsValid;

	private static FFieldAddress GetAssetLongPackageName_ClassName_PropertyAddress;

	private static int GetAssetLongPackageName_ClassName_Offset;

	private static bool GetAssetLongPackageName_AssetName_IsValid;

	private static FFieldAddress GetAssetLongPackageName_AssetName_PropertyAddress;

	private static int GetAssetLongPackageName_AssetName_Offset;

	private static bool GetAssetLongPackageName_ReturnValue_IsValid;

	private static FFieldAddress GetAssetLongPackageName_ReturnValue_PropertyAddress;

	private static int GetAssetLongPackageName_ReturnValue_Offset;

	private static bool GetAllAssetReference_IsValid;

	private static IntPtr GetAllAssetReference_FunctionAddress;

	private static int GetAllAssetReference_ParamsSize;

	private static bool GetAllAssetReference_SelectedPackageName_IsValid;

	private static FFieldAddress GetAllAssetReference_SelectedPackageName_PropertyAddress;

	private static int GetAllAssetReference_SelectedPackageName_Offset;

	private static bool GetAllAssetReference_ReturnValue_IsValid;

	private static FFieldAddress GetAllAssetReference_ReturnValue_PropertyAddress;

	private static int GetAllAssetReference_ReturnValue_Offset;

	private static bool GetAllAssetDependencies_IsValid;

	private static IntPtr GetAllAssetDependencies_FunctionAddress;

	private static int GetAllAssetDependencies_ParamsSize;

	private static bool GetAllAssetDependencies_SelectedPackageName_IsValid;

	private static FFieldAddress GetAllAssetDependencies_SelectedPackageName_PropertyAddress;

	private static int GetAllAssetDependencies_SelectedPackageName_Offset;

	private static bool GetAllAssetDependencies_ReturnValue_IsValid;

	private static FFieldAddress GetAllAssetDependencies_ReturnValue_PropertyAddress;

	private static int GetAllAssetDependencies_ReturnValue_Offset;

	private static bool GetAllActorsInWorld_IsValid;

	private static IntPtr GetAllActorsInWorld_FunctionAddress;

	private static int GetAllActorsInWorld_ParamsSize;

	private static bool GetAllActorsInWorld_World_IsValid;

	private static FFieldAddress GetAllActorsInWorld_World_PropertyAddress;

	private static int GetAllActorsInWorld_World_Offset;

	private static bool GetAllActorsInWorld_ReturnValue_IsValid;

	private static FFieldAddress GetAllActorsInWorld_ReturnValue_PropertyAddress;

	private static int GetAllActorsInWorld_ReturnValue_Offset;

	private static bool GetAllActorsInLevel_IsValid;

	private static IntPtr GetAllActorsInLevel_FunctionAddress;

	private static int GetAllActorsInLevel_ParamsSize;

	private static bool GetAllActorsInLevel_Level_IsValid;

	private static FFieldAddress GetAllActorsInLevel_Level_PropertyAddress;

	private static int GetAllActorsInLevel_Level_Offset;

	private static bool GetAllActorsInLevel_ReturnValue_IsValid;

	private static FFieldAddress GetAllActorsInLevel_ReturnValue_PropertyAddress;

	private static int GetAllActorsInLevel_ReturnValue_Offset;

	private static bool ForceLoadTileLOD_IsValid;

	private static IntPtr ForceLoadTileLOD_FunctionAddress;

	private static int ForceLoadTileLOD_ParamsSize;

	private static bool ForceLoadTileLOD_WorldContext_IsValid;

	private static FFieldAddress ForceLoadTileLOD_WorldContext_PropertyAddress;

	private static int ForceLoadTileLOD_WorldContext_Offset;

	private static bool ForceLoadTileLOD_TileName_IsValid;

	private static FFieldAddress ForceLoadTileLOD_TileName_PropertyAddress;

	private static int ForceLoadTileLOD_TileName_Offset;

	private static bool ForceLoadTileLOD_SwitchOn_IsValid;

	private static FFieldAddress ForceLoadTileLOD_SwitchOn_PropertyAddress;

	private static int ForceLoadTileLOD_SwitchOn_Offset;

	private static bool DrawDebugString_IsValid;

	private static IntPtr DrawDebugString_FunctionAddress;

	private static int DrawDebugString_ParamsSize;

	private static bool DrawDebugString_WorldContextObject_IsValid;

	private static FFieldAddress DrawDebugString_WorldContextObject_PropertyAddress;

	private static int DrawDebugString_WorldContextObject_Offset;

	private static bool DrawDebugString_TextLocation_IsValid;

	private static FFieldAddress DrawDebugString_TextLocation_PropertyAddress;

	private static int DrawDebugString_TextLocation_Offset;

	private static bool DrawDebugString_Text_IsValid;

	private static FFieldAddress DrawDebugString_Text_PropertyAddress;

	private static int DrawDebugString_Text_Offset;

	private static bool DrawDebugString_TestBaseActor_IsValid;

	private static FFieldAddress DrawDebugString_TestBaseActor_PropertyAddress;

	private static int DrawDebugString_TestBaseActor_Offset;

	private static bool DrawDebugString_TextColor_IsValid;

	private static FFieldAddress DrawDebugString_TextColor_PropertyAddress;

	private static int DrawDebugString_TextColor_Offset;

	private static bool DrawDebugString_Duration_IsValid;

	private static FFieldAddress DrawDebugString_Duration_PropertyAddress;

	private static int DrawDebugString_Duration_Offset;

	private static bool CalculateMontageCostValue_IsValid;

	private static IntPtr CalculateMontageCostValue_FunctionAddress;

	private static int CalculateMontageCostValue_ParamsSize;

	private static bool CalculateMontageCostValue_MontageList_IsValid;

	private static FFieldAddress CalculateMontageCostValue_MontageList_PropertyAddress;

	private static int CalculateMontageCostValue_MontageList_Offset;

	private static bool CalculateMontageCostValue_BoneNameList_IsValid;

	private static FFieldAddress CalculateMontageCostValue_BoneNameList_PropertyAddress;

	private static int CalculateMontageCostValue_BoneNameList_Offset;

	private static bool BonesSphereMask_IsValid;

	private static IntPtr BonesSphereMask_FunctionAddress;

	private static int BonesSphereMask_ParamsSize;

	private static bool BonesSphereMask_TargetSkeletalMesh_IsValid;

	private static FFieldAddress BonesSphereMask_TargetSkeletalMesh_PropertyAddress;

	private static int BonesSphereMask_TargetSkeletalMesh_Offset;

	private static bool BonesSphereMask_Radius_IsValid;

	private static FFieldAddress BonesSphereMask_Radius_PropertyAddress;

	private static int BonesSphereMask_Radius_Offset;

	private static bool BonesSphereMask_WorldPosition_IsValid;

	private static FFieldAddress BonesSphereMask_WorldPosition_PropertyAddress;

	private static int BonesSphereMask_WorldPosition_Offset;

	private static bool BonesSphereMask_ReturnValue_IsValid;

	private static FFieldAddress BonesSphereMask_ReturnValue_PropertyAddress;

	private static int BonesSphereMask_ReturnValue_Offset;

	private static bool BGUWoodTestCharacter_IsValid;

	private static IntPtr BGUWoodTestCharacter_FunctionAddress;

	private static int BGUWoodTestCharacter_ParamsSize;

	private static bool BGUWoodTestCharacter_Character_IsValid;

	private static FFieldAddress BGUWoodTestCharacter_Character_PropertyAddress;

	private static int BGUWoodTestCharacter_Character_Offset;

	private static bool BGUWoodTestCharacter_Montage_IsValid;

	private static FFieldAddress BGUWoodTestCharacter_Montage_PropertyAddress;

	private static int BGUWoodTestCharacter_Montage_Offset;

	private static bool BGUWoodTestCharacter_ScaleRate_IsValid;

	private static FFieldAddress BGUWoodTestCharacter_ScaleRate_PropertyAddress;

	private static int BGUWoodTestCharacter_ScaleRate_Offset;

	private static bool BGUUpdateLevelStreaming_IsValid;

	private static IntPtr BGUUpdateLevelStreaming_FunctionAddress;

	private static int BGUUpdateLevelStreaming_ParamsSize;

	private static bool BGUUpdateLevelStreaming_CurWorld_IsValid;

	private static FFieldAddress BGUUpdateLevelStreaming_CurWorld_PropertyAddress;

	private static int BGUUpdateLevelStreaming_CurWorld_Offset;

	private static bool BGUUnloadStreamLevel_IsValid;

	private static IntPtr BGUUnloadStreamLevel_FunctionAddress;

	private static int BGUUnloadStreamLevel_ParamsSize;

	private static bool BGUUnloadStreamLevel_WorldContextObject_IsValid;

	private static FFieldAddress BGUUnloadStreamLevel_WorldContextObject_PropertyAddress;

	private static int BGUUnloadStreamLevel_WorldContextObject_Offset;

	private static bool BGUUnloadStreamLevel_LevelName_IsValid;

	private static FFieldAddress BGUUnloadStreamLevel_LevelName_PropertyAddress;

	private static int BGUUnloadStreamLevel_LevelName_Offset;

	private static bool BGUUnloadStreamLevel_bShouldBlockOnUnload_IsValid;

	private static FFieldAddress BGUUnloadStreamLevel_bShouldBlockOnUnload_PropertyAddress;

	private static int BGUUnloadStreamLevel_bShouldBlockOnUnload_Offset;

	private static bool BGUUnloadStreamLevel_CallbackTarget_IsValid;

	private static FFieldAddress BGUUnloadStreamLevel_CallbackTarget_PropertyAddress;

	private static int BGUUnloadStreamLevel_CallbackTarget_Offset;

	private static bool BGUUnloadStreamLevel_CallbackFunc_IsValid;

	private static FFieldAddress BGUUnloadStreamLevel_CallbackFunc_PropertyAddress;

	private static int BGUUnloadStreamLevel_CallbackFunc_Offset;

	private static bool BGUUnloadStreamLevel_ActionID_IsValid;

	private static FFieldAddress BGUUnloadStreamLevel_ActionID_PropertyAddress;

	private static int BGUUnloadStreamLevel_ActionID_Offset;

	private static bool BGUUnloadStreamLevel_Linkage_IsValid;

	private static FFieldAddress BGUUnloadStreamLevel_Linkage_PropertyAddress;

	private static int BGUUnloadStreamLevel_Linkage_Offset;

	private static bool BGUSKMeshContainSocket_IsValid;

	private static IntPtr BGUSKMeshContainSocket_FunctionAddress;

	private static int BGUSKMeshContainSocket_ParamsSize;

	private static bool BGUSKMeshContainSocket_SkMeshComp_IsValid;

	private static FFieldAddress BGUSKMeshContainSocket_SkMeshComp_PropertyAddress;

	private static int BGUSKMeshContainSocket_SkMeshComp_Offset;

	private static bool BGUSKMeshContainSocket_SocketName_IsValid;

	private static FFieldAddress BGUSKMeshContainSocket_SocketName_PropertyAddress;

	private static int BGUSKMeshContainSocket_SocketName_Offset;

	private static bool BGUSKMeshContainSocket_ReturnValue_IsValid;

	private static FFieldAddress BGUSKMeshContainSocket_ReturnValue_PropertyAddress;

	private static int BGUSKMeshContainSocket_ReturnValue_Offset;

	private static bool BGUShapeSweepMultiByObjectType_IsValid;

	private static IntPtr BGUShapeSweepMultiByObjectType_FunctionAddress;

	private static int BGUShapeSweepMultiByObjectType_ParamsSize;

	private static bool BGUShapeSweepMultiByObjectType_ShapeComp_IsValid;

	private static FFieldAddress BGUShapeSweepMultiByObjectType_ShapeComp_PropertyAddress;

	private static int BGUShapeSweepMultiByObjectType_ShapeComp_Offset;

	private static bool BGUShapeSweepMultiByObjectType_Start_IsValid;

	private static FFieldAddress BGUShapeSweepMultiByObjectType_Start_PropertyAddress;

	private static int BGUShapeSweepMultiByObjectType_Start_Offset;

	private static bool BGUShapeSweepMultiByObjectType_End_IsValid;

	private static FFieldAddress BGUShapeSweepMultiByObjectType_End_PropertyAddress;

	private static int BGUShapeSweepMultiByObjectType_End_Offset;

	private static bool BGUShapeSweepMultiByObjectType_ObjectTypes_IsValid;

	private static FFieldAddress BGUShapeSweepMultiByObjectType_ObjectTypes_PropertyAddress;

	private static int BGUShapeSweepMultiByObjectType_ObjectTypes_Offset;

	private static bool BGUShapeSweepMultiByObjectType_bTraceComplex_IsValid;

	private static FFieldAddress BGUShapeSweepMultiByObjectType_bTraceComplex_PropertyAddress;

	private static int BGUShapeSweepMultiByObjectType_bTraceComplex_Offset;

	private static bool BGUShapeSweepMultiByObjectType_OutHits_IsValid;

	private static FFieldAddress BGUShapeSweepMultiByObjectType_OutHits_PropertyAddress;

	private static int BGUShapeSweepMultiByObjectType_OutHits_Offset;

	private static bool BGUShapeSweepMultiByObjectType_bIgnoreSelf_IsValid;

	private static FFieldAddress BGUShapeSweepMultiByObjectType_bIgnoreSelf_PropertyAddress;

	private static int BGUShapeSweepMultiByObjectType_bIgnoreSelf_Offset;

	private static bool BGUShapeSweepMultiByObjectType_ReturnValue_IsValid;

	private static FFieldAddress BGUShapeSweepMultiByObjectType_ReturnValue_PropertyAddress;

	private static int BGUShapeSweepMultiByObjectType_ReturnValue_Offset;

	private static bool BGUSetValueToCurveVector_IsValid;

	private static IntPtr BGUSetValueToCurveVector_FunctionAddress;

	private static int BGUSetValueToCurveVector_ParamsSize;

	private static bool BGUSetValueToCurveVector_CurveVector_IsValid;

	private static FFieldAddress BGUSetValueToCurveVector_CurveVector_PropertyAddress;

	private static int BGUSetValueToCurveVector_CurveVector_Offset;

	private static bool BGUSetValueToCurveVector_Key_IsValid;

	private static FFieldAddress BGUSetValueToCurveVector_Key_PropertyAddress;

	private static int BGUSetValueToCurveVector_Key_Offset;

	private static bool BGUSetValueToCurveVector_Value_IsValid;

	private static FFieldAddress BGUSetValueToCurveVector_Value_PropertyAddress;

	private static int BGUSetValueToCurveVector_Value_Offset;

	private static bool BGUSetValueToCurveVector_InterpMode_IsValid;

	private static FFieldAddress BGUSetValueToCurveVector_InterpMode_PropertyAddress;

	private static int BGUSetValueToCurveVector_InterpMode_Offset;

	private static bool BGUSetValueToCurveFloat_IsValid;

	private static IntPtr BGUSetValueToCurveFloat_FunctionAddress;

	private static int BGUSetValueToCurveFloat_ParamsSize;

	private static bool BGUSetValueToCurveFloat_CurveFloat_IsValid;

	private static FFieldAddress BGUSetValueToCurveFloat_CurveFloat_PropertyAddress;

	private static int BGUSetValueToCurveFloat_CurveFloat_Offset;

	private static bool BGUSetValueToCurveFloat_Key_IsValid;

	private static FFieldAddress BGUSetValueToCurveFloat_Key_PropertyAddress;

	private static int BGUSetValueToCurveFloat_Key_Offset;

	private static bool BGUSetValueToCurveFloat_Value_IsValid;

	private static FFieldAddress BGUSetValueToCurveFloat_Value_PropertyAddress;

	private static int BGUSetValueToCurveFloat_Value_Offset;

	private static bool BGUSetValueToCurveFloat_InterpMode_IsValid;

	private static FFieldAddress BGUSetValueToCurveFloat_InterpMode_PropertyAddress;

	private static int BGUSetValueToCurveFloat_InterpMode_Offset;

	private static bool BGUSetTressFXAssetAndMaterial_IsValid;

	private static IntPtr BGUSetTressFXAssetAndMaterial_FunctionAddress;

	private static int BGUSetTressFXAssetAndMaterial_ParamsSize;

	private static bool BGUSetTressFXAssetAndMaterial_TFXComp_IsValid;

	private static FFieldAddress BGUSetTressFXAssetAndMaterial_TFXComp_PropertyAddress;

	private static int BGUSetTressFXAssetAndMaterial_TFXComp_Offset;

	private static bool BGUSetTressFXAssetAndMaterial_Asset_IsValid;

	private static FFieldAddress BGUSetTressFXAssetAndMaterial_Asset_PropertyAddress;

	private static int BGUSetTressFXAssetAndMaterial_Asset_Offset;

	private static bool BGUSetTressFXAssetAndMaterial_Material_IsValid;

	private static FFieldAddress BGUSetTressFXAssetAndMaterial_Material_PropertyAddress;

	private static int BGUSetTressFXAssetAndMaterial_Material_Offset;

	private static bool BGUSetLinearColorParameterValueToMesh_IsValid;

	private static IntPtr BGUSetLinearColorParameterValueToMesh_FunctionAddress;

	private static int BGUSetLinearColorParameterValueToMesh_ParamsSize;

	private static bool BGUSetLinearColorParameterValueToMesh_MeshInst_IsValid;

	private static FFieldAddress BGUSetLinearColorParameterValueToMesh_MeshInst_PropertyAddress;

	private static int BGUSetLinearColorParameterValueToMesh_MeshInst_Offset;

	private static bool BGUSetLinearColorParameterValueToMesh_ParameterName_IsValid;

	private static FFieldAddress BGUSetLinearColorParameterValueToMesh_ParameterName_PropertyAddress;

	private static int BGUSetLinearColorParameterValueToMesh_ParameterName_Offset;

	private static bool BGUSetLinearColorParameterValueToMesh_LinearColorParameterValue_IsValid;

	private static FFieldAddress BGUSetLinearColorParameterValueToMesh_LinearColorParameterValue_PropertyAddress;

	private static int BGUSetLinearColorParameterValueToMesh_LinearColorParameterValue_Offset;

	private static bool BGUSetEnableGravity_IsValid;

	private static IntPtr BGUSetEnableGravity_FunctionAddress;

	private static int BGUSetEnableGravity_ParamsSize;

	private static bool BGUSetEnableGravity_TargetMesh_IsValid;

	private static FFieldAddress BGUSetEnableGravity_TargetMesh_PropertyAddress;

	private static int BGUSetEnableGravity_TargetMesh_Offset;

	private static bool BGUSetEnableGravity_bEnableGravity_IsValid;

	private static FFieldAddress BGUSetEnableGravity_bEnableGravity_PropertyAddress;

	private static int BGUSetEnableGravity_bEnableGravity_Offset;

	private static bool BGUSetActiveMontagePosition_IsValid;

	private static IntPtr BGUSetActiveMontagePosition_FunctionAddress;

	private static int BGUSetActiveMontagePosition_ParamsSize;

	private static bool BGUSetActiveMontagePosition_Character_IsValid;

	private static FFieldAddress BGUSetActiveMontagePosition_Character_PropertyAddress;

	private static int BGUSetActiveMontagePosition_Character_Offset;

	private static bool BGUSetActiveMontagePosition_Montage_IsValid;

	private static FFieldAddress BGUSetActiveMontagePosition_Montage_PropertyAddress;

	private static int BGUSetActiveMontagePosition_Montage_Offset;

	private static bool BGUSetActiveMontagePosition_Position_IsValid;

	private static FFieldAddress BGUSetActiveMontagePosition_Position_PropertyAddress;

	private static int BGUSetActiveMontagePosition_Position_Offset;

	private static bool BGUSetActiveMontagePosition_ReturnValue_IsValid;

	private static FFieldAddress BGUSetActiveMontagePosition_ReturnValue_PropertyAddress;

	private static int BGUSetActiveMontagePosition_ReturnValue_Offset;

	private static bool BGUSeparatingAxisPointCheck_IsValid;

	private static IntPtr BGUSeparatingAxisPointCheck_FunctionAddress;

	private static int BGUSeparatingAxisPointCheck_ParamsSize;

	private static bool BGUSeparatingAxisPointCheck_InPolyVertices_IsValid;

	private static FFieldAddress BGUSeparatingAxisPointCheck_InPolyVertices_PropertyAddress;

	private static int BGUSeparatingAxisPointCheck_InPolyVertices_Offset;

	private static bool BGUSeparatingAxisPointCheck_InBoxCenter_IsValid;

	private static FFieldAddress BGUSeparatingAxisPointCheck_InBoxCenter_PropertyAddress;

	private static int BGUSeparatingAxisPointCheck_InBoxCenter_Offset;

	private static bool BGUSeparatingAxisPointCheck_InBoxExtent_IsValid;

	private static FFieldAddress BGUSeparatingAxisPointCheck_InBoxExtent_PropertyAddress;

	private static int BGUSeparatingAxisPointCheck_InBoxExtent_Offset;

	private static bool BGUSeparatingAxisPointCheck_bInCalcLeastPenetration_IsValid;

	private static FFieldAddress BGUSeparatingAxisPointCheck_bInCalcLeastPenetration_PropertyAddress;

	private static int BGUSeparatingAxisPointCheck_bInCalcLeastPenetration_Offset;

	private static bool BGUSeparatingAxisPointCheck_ReturnValue_IsValid;

	private static FFieldAddress BGUSeparatingAxisPointCheck_ReturnValue_PropertyAddress;

	private static int BGUSeparatingAxisPointCheck_ReturnValue_Offset;

	private static bool BGUSaveUnitAttrToFile_IsValid;

	private static IntPtr BGUSaveUnitAttrToFile_FunctionAddress;

	private static int BGUSaveUnitAttrToFile_ParamsSize;

	private static bool BGUSaveUnitAttrToFile_Name_IsValid;

	private static FFieldAddress BGUSaveUnitAttrToFile_Name_PropertyAddress;

	private static int BGUSaveUnitAttrToFile_Name_Offset;

	private static bool BGUSaveUnitAttrToFile_Text_IsValid;

	private static FFieldAddress BGUSaveUnitAttrToFile_Text_PropertyAddress;

	private static int BGUSaveUnitAttrToFile_Text_Offset;

	private static bool BGUSaveUnitAttrToFile_Overwrite_IsValid;

	private static FFieldAddress BGUSaveUnitAttrToFile_Overwrite_PropertyAddress;

	private static int BGUSaveUnitAttrToFile_Overwrite_Offset;

	private static bool BGUResetToDefaultBoomCameraLagSpeed_IsValid;

	private static IntPtr BGUResetToDefaultBoomCameraLagSpeed_FunctionAddress;

	private static int BGUResetToDefaultBoomCameraLagSpeed_ParamsSize;

	private static bool BGUResetToDefaultBoomCameraLagSpeed_PlayerCharacter_IsValid;

	private static FFieldAddress BGUResetToDefaultBoomCameraLagSpeed_PlayerCharacter_PropertyAddress;

	private static int BGUResetToDefaultBoomCameraLagSpeed_PlayerCharacter_Offset;

	private static bool BGUResetGeometryCollectionComponent_IsValid;

	private static IntPtr BGUResetGeometryCollectionComponent_FunctionAddress;

	private static int BGUResetGeometryCollectionComponent_ParamsSize;

	private static bool BGUResetGeometryCollectionComponent_GeometryCollectionComponent_IsValid;

	private static FFieldAddress BGUResetGeometryCollectionComponent_GeometryCollectionComponent_PropertyAddress;

	private static int BGUResetGeometryCollectionComponent_GeometryCollectionComponent_Offset;

	private static bool BGUResetActorVelocity_IsValid;

	private static IntPtr BGUResetActorVelocity_FunctionAddress;

	private static int BGUResetActorVelocity_ParamsSize;

	private static bool BGUResetActorVelocity_Actor_IsValid;

	private static FFieldAddress BGUResetActorVelocity_Actor_PropertyAddress;

	private static int BGUResetActorVelocity_Actor_Offset;

	private static bool BGURenameActorComponent_IsValid;

	private static IntPtr BGURenameActorComponent_FunctionAddress;

	private static int BGURenameActorComponent_ParamsSize;

	private static bool BGURenameActorComponent_Comp_IsValid;

	private static FFieldAddress BGURenameActorComponent_Comp_PropertyAddress;

	private static int BGURenameActorComponent_Comp_Offset;

	private static bool BGURenameActorComponent_NewName_IsValid;

	private static FFieldAddress BGURenameActorComponent_NewName_PropertyAddress;

	private static int BGURenameActorComponent_NewName_Offset;

	private static bool BGUProjectPointToNavigation_IsValid;

	private static IntPtr BGUProjectPointToNavigation_FunctionAddress;

	private static int BGUProjectPointToNavigation_ParamsSize;

	private static bool BGUProjectPointToNavigation_WorldContextObject_IsValid;

	private static FFieldAddress BGUProjectPointToNavigation_WorldContextObject_PropertyAddress;

	private static int BGUProjectPointToNavigation_WorldContextObject_Offset;

	private static bool BGUProjectPointToNavigation_Point_IsValid;

	private static FFieldAddress BGUProjectPointToNavigation_Point_PropertyAddress;

	private static int BGUProjectPointToNavigation_Point_Offset;

	private static bool BGUProjectPointToNavigation_ProjectedLocation_IsValid;

	private static FFieldAddress BGUProjectPointToNavigation_ProjectedLocation_PropertyAddress;

	private static int BGUProjectPointToNavigation_ProjectedLocation_Offset;

	private static bool BGUProjectPointToNavigation_NavData_IsValid;

	private static FFieldAddress BGUProjectPointToNavigation_NavData_PropertyAddress;

	private static int BGUProjectPointToNavigation_NavData_Offset;

	private static bool BGUProjectPointToNavigation_FilterClass_IsValid;

	private static FFieldAddress BGUProjectPointToNavigation_FilterClass_PropertyAddress;

	private static int BGUProjectPointToNavigation_FilterClass_Offset;

	private static bool BGUProjectPointToNavigation_QueryExtent_IsValid;

	private static FFieldAddress BGUProjectPointToNavigation_QueryExtent_PropertyAddress;

	private static int BGUProjectPointToNavigation_QueryExtent_Offset;

	private static bool BGUProjectPointToNavigation_ReturnValue_IsValid;

	private static FFieldAddress BGUProjectPointToNavigation_ReturnValue_PropertyAddress;

	private static int BGUProjectPointToNavigation_ReturnValue_Offset;

	private static bool BGUProcessLatentActions_IsValid;

	private static IntPtr BGUProcessLatentActions_FunctionAddress;

	private static int BGUProcessLatentActions_ParamsSize;

	private static bool BGUProcessLatentActions_WorldContextObject_IsValid;

	private static FFieldAddress BGUProcessLatentActions_WorldContextObject_PropertyAddress;

	private static int BGUProcessLatentActions_WorldContextObject_Offset;

	private static bool BGUProcessLatentActions_InObject_IsValid;

	private static FFieldAddress BGUProcessLatentActions_InObject_PropertyAddress;

	private static int BGUProcessLatentActions_InObject_Offset;

	private static bool BGUProcessLatentActions_DeltaTime_IsValid;

	private static FFieldAddress BGUProcessLatentActions_DeltaTime_PropertyAddress;

	private static int BGUProcessLatentActions_DeltaTime_Offset;

	private static bool BGUPlayerCtrlerGetViewPoint_IsValid;

	private static IntPtr BGUPlayerCtrlerGetViewPoint_FunctionAddress;

	private static int BGUPlayerCtrlerGetViewPoint_ParamsSize;

	private static bool BGUPlayerCtrlerGetViewPoint_PlayerCtrler_IsValid;

	private static FFieldAddress BGUPlayerCtrlerGetViewPoint_PlayerCtrler_PropertyAddress;

	private static int BGUPlayerCtrlerGetViewPoint_PlayerCtrler_Offset;

	private static bool BGUPlayerCtrlerGetViewPoint_out_Location_IsValid;

	private static FFieldAddress BGUPlayerCtrlerGetViewPoint_out_Location_PropertyAddress;

	private static int BGUPlayerCtrlerGetViewPoint_out_Location_Offset;

	private static bool BGUPlayerCtrlerGetViewPoint_out_Rotation_IsValid;

	private static FFieldAddress BGUPlayerCtrlerGetViewPoint_out_Rotation_PropertyAddress;

	private static int BGUPlayerCtrlerGetViewPoint_out_Rotation_Offset;

	private static bool BGUPerlinNoise1D_IsValid;

	private static IntPtr BGUPerlinNoise1D_FunctionAddress;

	private static int BGUPerlinNoise1D_ParamsSize;

	private static bool BGUPerlinNoise1D_Value_IsValid;

	private static FFieldAddress BGUPerlinNoise1D_Value_PropertyAddress;

	private static int BGUPerlinNoise1D_Value_Offset;

	private static bool BGUPerlinNoise1D_ReturnValue_IsValid;

	private static FFieldAddress BGUPerlinNoise1D_ReturnValue_PropertyAddress;

	private static int BGUPerlinNoise1D_ReturnValue_Offset;

	private static bool BGUNavigationRaycast_IsValid;

	private static IntPtr BGUNavigationRaycast_FunctionAddress;

	private static int BGUNavigationRaycast_ParamsSize;

	private static bool BGUNavigationRaycast_WorldContextObject_IsValid;

	private static FFieldAddress BGUNavigationRaycast_WorldContextObject_PropertyAddress;

	private static int BGUNavigationRaycast_WorldContextObject_Offset;

	private static bool BGUNavigationRaycast_RayStart_IsValid;

	private static FFieldAddress BGUNavigationRaycast_RayStart_PropertyAddress;

	private static int BGUNavigationRaycast_RayStart_Offset;

	private static bool BGUNavigationRaycast_RayEnd_IsValid;

	private static FFieldAddress BGUNavigationRaycast_RayEnd_PropertyAddress;

	private static int BGUNavigationRaycast_RayEnd_Offset;

	private static bool BGUNavigationRaycast_HitLocation_IsValid;

	private static FFieldAddress BGUNavigationRaycast_HitLocation_PropertyAddress;

	private static int BGUNavigationRaycast_HitLocation_Offset;

	private static bool BGUNavigationRaycast_FilterClass_IsValid;

	private static FFieldAddress BGUNavigationRaycast_FilterClass_PropertyAddress;

	private static int BGUNavigationRaycast_FilterClass_Offset;

	private static bool BGUNavigationRaycast_Querier_IsValid;

	private static FFieldAddress BGUNavigationRaycast_Querier_PropertyAddress;

	private static int BGUNavigationRaycast_Querier_Offset;

	private static bool BGUNavigationRaycast_ReturnValue_IsValid;

	private static FFieldAddress BGUNavigationRaycast_ReturnValue_PropertyAddress;

	private static int BGUNavigationRaycast_ReturnValue_Offset;

	private static bool BGUNavigationCalPathCost_IsValid;

	private static IntPtr BGUNavigationCalPathCost_FunctionAddress;

	private static int BGUNavigationCalPathCost_ParamsSize;

	private static bool BGUNavigationCalPathCost_WorldContextObject_IsValid;

	private static FFieldAddress BGUNavigationCalPathCost_WorldContextObject_PropertyAddress;

	private static int BGUNavigationCalPathCost_WorldContextObject_Offset;

	private static bool BGUNavigationCalPathCost_PathStart_IsValid;

	private static FFieldAddress BGUNavigationCalPathCost_PathStart_PropertyAddress;

	private static int BGUNavigationCalPathCost_PathStart_Offset;

	private static bool BGUNavigationCalPathCost_PathEnd_IsValid;

	private static FFieldAddress BGUNavigationCalPathCost_PathEnd_PropertyAddress;

	private static int BGUNavigationCalPathCost_PathEnd_Offset;

	private static bool BGUNavigationCalPathCost_PathCost_IsValid;

	private static FFieldAddress BGUNavigationCalPathCost_PathCost_PropertyAddress;

	private static int BGUNavigationCalPathCost_PathCost_Offset;

	private static bool BGUNavigationCalPathCost_Querier_IsValid;

	private static FFieldAddress BGUNavigationCalPathCost_Querier_PropertyAddress;

	private static int BGUNavigationCalPathCost_Querier_Offset;

	private static bool BGUMergeSkeletalMesh_IsValid;

	private static IntPtr BGUMergeSkeletalMesh_FunctionAddress;

	private static int BGUMergeSkeletalMesh_ParamsSize;

	private static bool BGUMergeSkeletalMesh_InMergeMesh_IsValid;

	private static FFieldAddress BGUMergeSkeletalMesh_InMergeMesh_PropertyAddress;

	private static int BGUMergeSkeletalMesh_InMergeMesh_Offset;

	private static bool BGUMergeSkeletalMesh_InSrcMeshList_IsValid;

	private static FFieldAddress BGUMergeSkeletalMesh_InSrcMeshList_PropertyAddress;

	private static int BGUMergeSkeletalMesh_InSrcMeshList_Offset;

	private static bool BGUMergeSkeletalMesh_StripTopLODs_IsValid;

	private static FFieldAddress BGUMergeSkeletalMesh_StripTopLODs_PropertyAddress;

	private static int BGUMergeSkeletalMesh_StripTopLODs_Offset;

	private static bool BGUMergeSkeletalMesh_MeshBufferAccess_IsValid;

	private static FFieldAddress BGUMergeSkeletalMesh_MeshBufferAccess_PropertyAddress;

	private static int BGUMergeSkeletalMesh_MeshBufferAccess_Offset;

	private static bool BGUMergeSkeletalMesh_ReturnValue_IsValid;

	private static FFieldAddress BGUMergeSkeletalMesh_ReturnValue_PropertyAddress;

	private static int BGUMergeSkeletalMesh_ReturnValue_Offset;

	private static bool BGULoadStreamLevel_IsValid;

	private static IntPtr BGULoadStreamLevel_FunctionAddress;

	private static int BGULoadStreamLevel_ParamsSize;

	private static bool BGULoadStreamLevel_WorldContextObject_IsValid;

	private static FFieldAddress BGULoadStreamLevel_WorldContextObject_PropertyAddress;

	private static int BGULoadStreamLevel_WorldContextObject_Offset;

	private static bool BGULoadStreamLevel_LevelName_IsValid;

	private static FFieldAddress BGULoadStreamLevel_LevelName_PropertyAddress;

	private static int BGULoadStreamLevel_LevelName_Offset;

	private static bool BGULoadStreamLevel_bMakeVisibleAfterLoad_IsValid;

	private static FFieldAddress BGULoadStreamLevel_bMakeVisibleAfterLoad_PropertyAddress;

	private static int BGULoadStreamLevel_bMakeVisibleAfterLoad_Offset;

	private static bool BGULoadStreamLevel_bShouldBlockOnLoad_IsValid;

	private static FFieldAddress BGULoadStreamLevel_bShouldBlockOnLoad_PropertyAddress;

	private static int BGULoadStreamLevel_bShouldBlockOnLoad_Offset;

	private static bool BGULoadStreamLevel_CallbackTarget_IsValid;

	private static FFieldAddress BGULoadStreamLevel_CallbackTarget_PropertyAddress;

	private static int BGULoadStreamLevel_CallbackTarget_Offset;

	private static bool BGULoadStreamLevel_CallbackFunc_IsValid;

	private static FFieldAddress BGULoadStreamLevel_CallbackFunc_PropertyAddress;

	private static int BGULoadStreamLevel_CallbackFunc_Offset;

	private static bool BGULoadStreamLevel_ActionID_IsValid;

	private static FFieldAddress BGULoadStreamLevel_ActionID_PropertyAddress;

	private static int BGULoadStreamLevel_ActionID_Offset;

	private static bool BGULoadStreamLevel_Linkage_IsValid;

	private static FFieldAddress BGULoadStreamLevel_Linkage_PropertyAddress;

	private static int BGULoadStreamLevel_Linkage_Offset;

	private static bool BGUIsExistFile_IsValid;

	private static IntPtr BGUIsExistFile_FunctionAddress;

	private static int BGUIsExistFile_ParamsSize;

	private static bool BGUIsExistFile_path_IsValid;

	private static FFieldAddress BGUIsExistFile_path_PropertyAddress;

	private static int BGUIsExistFile_path_Offset;

	private static bool BGUIsExistFile_ReturnValue_IsValid;

	private static FFieldAddress BGUIsExistFile_ReturnValue_PropertyAddress;

	private static int BGUIsExistFile_ReturnValue_Offset;

	private static bool BGUHasFuncName_IsValid;

	private static IntPtr BGUHasFuncName_FunctionAddress;

	private static int BGUHasFuncName_ParamsSize;

	private static bool BGUHasFuncName_FuncName_IsValid;

	private static FFieldAddress BGUHasFuncName_FuncName_PropertyAddress;

	private static int BGUHasFuncName_FuncName_Offset;

	private static bool BGUHasFuncName_Object_IsValid;

	private static FFieldAddress BGUHasFuncName_Object_PropertyAddress;

	private static int BGUHasFuncName_Object_Offset;

	private static bool BGUHasFuncName_StopAtClass_IsValid;

	private static FFieldAddress BGUHasFuncName_StopAtClass_PropertyAddress;

	private static int BGUHasFuncName_StopAtClass_Offset;

	private static bool BGUHasFuncName_ReturnValue_IsValid;

	private static FFieldAddress BGUHasFuncName_ReturnValue_PropertyAddress;

	private static int BGUHasFuncName_ReturnValue_Offset;

	private static bool BGUGetWindParameters_GameThread_IsValid;

	private static IntPtr BGUGetWindParameters_GameThread_FunctionAddress;

	private static int BGUGetWindParameters_GameThread_ParamsSize;

	private static bool BGUGetWindParameters_GameThread_WorldContext_IsValid;

	private static FFieldAddress BGUGetWindParameters_GameThread_WorldContext_PropertyAddress;

	private static int BGUGetWindParameters_GameThread_WorldContext_Offset;

	private static bool BGUGetWindParameters_GameThread_Position_IsValid;

	private static FFieldAddress BGUGetWindParameters_GameThread_Position_PropertyAddress;

	private static int BGUGetWindParameters_GameThread_Position_Offset;

	private static bool BGUGetWindParameters_GameThread_OutDirection_IsValid;

	private static FFieldAddress BGUGetWindParameters_GameThread_OutDirection_PropertyAddress;

	private static int BGUGetWindParameters_GameThread_OutDirection_Offset;

	private static bool BGUGetWindParameters_GameThread_OutSpeed_IsValid;

	private static FFieldAddress BGUGetWindParameters_GameThread_OutSpeed_PropertyAddress;

	private static int BGUGetWindParameters_GameThread_OutSpeed_Offset;

	private static bool BGUGetWindParameters_GameThread_OutMinGustAmt_IsValid;

	private static FFieldAddress BGUGetWindParameters_GameThread_OutMinGustAmt_PropertyAddress;

	private static int BGUGetWindParameters_GameThread_OutMinGustAmt_Offset;

	private static bool BGUGetWindParameters_GameThread_OutMaxGustAmt_IsValid;

	private static FFieldAddress BGUGetWindParameters_GameThread_OutMaxGustAmt_PropertyAddress;

	private static int BGUGetWindParameters_GameThread_OutMaxGustAmt_Offset;

	private static bool BGUGetTeamID_IsValid;

	private static IntPtr BGUGetTeamID_FunctionAddress;

	private static int BGUGetTeamID_ParamsSize;

	private static bool BGUGetTeamID_Unit_IsValid;

	private static FFieldAddress BGUGetTeamID_Unit_PropertyAddress;

	private static int BGUGetTeamID_Unit_Offset;

	private static bool BGUGetTeamID_ReturnValue_IsValid;

	private static FFieldAddress BGUGetTeamID_ReturnValue_PropertyAddress;

	private static int BGUGetTeamID_ReturnValue_Offset;

	private static bool BGUGetSkeletalMeshSimulatedBodiesBelowNum_IsValid;

	private static IntPtr BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress;

	private static int BGUGetSkeletalMeshSimulatedBodiesBelowNum_ParamsSize;

	private static bool BGUGetSkeletalMeshSimulatedBodiesBelowNum_SkeletalMesh_IsValid;

	private static FFieldAddress BGUGetSkeletalMeshSimulatedBodiesBelowNum_SkeletalMesh_PropertyAddress;

	private static int BGUGetSkeletalMeshSimulatedBodiesBelowNum_SkeletalMesh_Offset;

	private static bool BGUGetSkeletalMeshSimulatedBodiesBelowNum_BoneName_IsValid;

	private static FFieldAddress BGUGetSkeletalMeshSimulatedBodiesBelowNum_BoneName_PropertyAddress;

	private static int BGUGetSkeletalMeshSimulatedBodiesBelowNum_BoneName_Offset;

	private static bool BGUGetSkeletalMeshSimulatedBodiesBelowNum_bIncludeSelf_IsValid;

	private static FFieldAddress BGUGetSkeletalMeshSimulatedBodiesBelowNum_bIncludeSelf_PropertyAddress;

	private static int BGUGetSkeletalMeshSimulatedBodiesBelowNum_bIncludeSelf_Offset;

	private static bool BGUGetSkeletalMeshSimulatedBodiesBelowNum_ReturnValue_IsValid;

	private static FFieldAddress BGUGetSkeletalMeshSimulatedBodiesBelowNum_ReturnValue_PropertyAddress;

	private static int BGUGetSkeletalMeshSimulatedBodiesBelowNum_ReturnValue_Offset;

	private static bool BGUGetMontageSectionTimeLeftFromPos_IsValid;

	private static IntPtr BGUGetMontageSectionTimeLeftFromPos_FunctionAddress;

	private static int BGUGetMontageSectionTimeLeftFromPos_ParamsSize;

	private static bool BGUGetMontageSectionTimeLeftFromPos_Unit_IsValid;

	private static FFieldAddress BGUGetMontageSectionTimeLeftFromPos_Unit_PropertyAddress;

	private static int BGUGetMontageSectionTimeLeftFromPos_Unit_Offset;

	private static bool BGUGetMontageSectionTimeLeftFromPos_AnimMontage_IsValid;

	private static FFieldAddress BGUGetMontageSectionTimeLeftFromPos_AnimMontage_PropertyAddress;

	private static int BGUGetMontageSectionTimeLeftFromPos_AnimMontage_Offset;

	private static bool BGUGetMontageSectionTimeLeftFromPos_Position_IsValid;

	private static FFieldAddress BGUGetMontageSectionTimeLeftFromPos_Position_PropertyAddress;

	private static int BGUGetMontageSectionTimeLeftFromPos_Position_Offset;

	private static bool BGUGetMontageSectionTimeLeftFromPos_ReturnValue_IsValid;

	private static FFieldAddress BGUGetMontageSectionTimeLeftFromPos_ReturnValue_PropertyAddress;

	private static int BGUGetMontageSectionTimeLeftFromPos_ReturnValue_Offset;

	private static bool BGUGetMontageSectionStartAndEndTime_IsValid;

	private static IntPtr BGUGetMontageSectionStartAndEndTime_FunctionAddress;

	private static int BGUGetMontageSectionStartAndEndTime_ParamsSize;

	private static bool BGUGetMontageSectionStartAndEndTime_AnimMontage_IsValid;

	private static FFieldAddress BGUGetMontageSectionStartAndEndTime_AnimMontage_PropertyAddress;

	private static int BGUGetMontageSectionStartAndEndTime_AnimMontage_Offset;

	private static bool BGUGetMontageSectionStartAndEndTime_SectionName_IsValid;

	private static FFieldAddress BGUGetMontageSectionStartAndEndTime_SectionName_PropertyAddress;

	private static int BGUGetMontageSectionStartAndEndTime_SectionName_Offset;

	private static bool BGUGetMontageSectionStartAndEndTime_OutStartTime_IsValid;

	private static FFieldAddress BGUGetMontageSectionStartAndEndTime_OutStartTime_PropertyAddress;

	private static int BGUGetMontageSectionStartAndEndTime_OutStartTime_Offset;

	private static bool BGUGetMontageSectionStartAndEndTime_OutEndTime_IsValid;

	private static FFieldAddress BGUGetMontageSectionStartAndEndTime_OutEndTime_PropertyAddress;

	private static int BGUGetMontageSectionStartAndEndTime_OutEndTime_Offset;

	private static bool BGUGetMontageSectionStartAndEndTime_ReturnValue_IsValid;

	private static FFieldAddress BGUGetMontageSectionStartAndEndTime_ReturnValue_PropertyAddress;

	private static int BGUGetMontageSectionStartAndEndTime_ReturnValue_Offset;

	private static bool BGUGetMontageSectionLengthByName_IsValid;

	private static IntPtr BGUGetMontageSectionLengthByName_FunctionAddress;

	private static int BGUGetMontageSectionLengthByName_ParamsSize;

	private static bool BGUGetMontageSectionLengthByName_Unit_IsValid;

	private static FFieldAddress BGUGetMontageSectionLengthByName_Unit_PropertyAddress;

	private static int BGUGetMontageSectionLengthByName_Unit_Offset;

	private static bool BGUGetMontageSectionLengthByName_AnimMontage_IsValid;

	private static FFieldAddress BGUGetMontageSectionLengthByName_AnimMontage_PropertyAddress;

	private static int BGUGetMontageSectionLengthByName_AnimMontage_Offset;

	private static bool BGUGetMontageSectionLengthByName_SectionName_IsValid;

	private static FFieldAddress BGUGetMontageSectionLengthByName_SectionName_PropertyAddress;

	private static int BGUGetMontageSectionLengthByName_SectionName_Offset;

	private static bool BGUGetMontageSectionLengthByName_ReturnValue_IsValid;

	private static FFieldAddress BGUGetMontageSectionLengthByName_ReturnValue_PropertyAddress;

	private static int BGUGetMontageSectionLengthByName_ReturnValue_Offset;

	private static bool BGUGetMontageSectionLengthByIndex_IsValid;

	private static IntPtr BGUGetMontageSectionLengthByIndex_FunctionAddress;

	private static int BGUGetMontageSectionLengthByIndex_ParamsSize;

	private static bool BGUGetMontageSectionLengthByIndex_Unit_IsValid;

	private static FFieldAddress BGUGetMontageSectionLengthByIndex_Unit_PropertyAddress;

	private static int BGUGetMontageSectionLengthByIndex_Unit_Offset;

	private static bool BGUGetMontageSectionLengthByIndex_AnimMontage_IsValid;

	private static FFieldAddress BGUGetMontageSectionLengthByIndex_AnimMontage_PropertyAddress;

	private static int BGUGetMontageSectionLengthByIndex_AnimMontage_Offset;

	private static bool BGUGetMontageSectionLengthByIndex_index_IsValid;

	private static FFieldAddress BGUGetMontageSectionLengthByIndex_index_PropertyAddress;

	private static int BGUGetMontageSectionLengthByIndex_index_Offset;

	private static bool BGUGetMontageSectionLengthByIndex_ReturnValue_IsValid;

	private static FFieldAddress BGUGetMontageSectionLengthByIndex_ReturnValue_PropertyAddress;

	private static int BGUGetMontageSectionLengthByIndex_ReturnValue_Offset;

	private static bool BGUGetHitResultActor_IsValid;

	private static IntPtr BGUGetHitResultActor_FunctionAddress;

	private static int BGUGetHitResultActor_ParamsSize;

	private static bool BGUGetHitResultActor_ActorInstanceHandle_IsValid;

	private static FFieldAddress BGUGetHitResultActor_ActorInstanceHandle_PropertyAddress;

	private static int BGUGetHitResultActor_ActorInstanceHandle_Offset;

	private static bool BGUGetHitResultActor_ReturnValue_IsValid;

	private static FFieldAddress BGUGetHitResultActor_ReturnValue_PropertyAddress;

	private static int BGUGetHitResultActor_ReturnValue_Offset;

	private static bool BGUGetAllActorsWithTagInRangeSorted_IsValid;

	private static IntPtr BGUGetAllActorsWithTagInRangeSorted_FunctionAddress;

	private static int BGUGetAllActorsWithTagInRangeSorted_ParamsSize;

	private static bool BGUGetAllActorsWithTagInRangeSorted_CenterActor_IsValid;

	private static FFieldAddress BGUGetAllActorsWithTagInRangeSorted_CenterActor_PropertyAddress;

	private static int BGUGetAllActorsWithTagInRangeSorted_CenterActor_Offset;

	private static bool BGUGetAllActorsWithTagInRangeSorted_TagName_IsValid;

	private static FFieldAddress BGUGetAllActorsWithTagInRangeSorted_TagName_PropertyAddress;

	private static int BGUGetAllActorsWithTagInRangeSorted_TagName_Offset;

	private static bool BGUGetAllActorsWithTagInRangeSorted_Range_IsValid;

	private static FFieldAddress BGUGetAllActorsWithTagInRangeSorted_Range_PropertyAddress;

	private static int BGUGetAllActorsWithTagInRangeSorted_Range_Offset;

	private static bool BGUGetAllActorsWithTagInRangeSorted_OutActors_IsValid;

	private static FFieldAddress BGUGetAllActorsWithTagInRangeSorted_OutActors_PropertyAddress;

	private static int BGUGetAllActorsWithTagInRangeSorted_OutActors_Offset;

	private static bool BGUGetAllActorsWithTagInRangeSorted_ReturnValue_IsValid;

	private static FFieldAddress BGUGetAllActorsWithTagInRangeSorted_ReturnValue_PropertyAddress;

	private static int BGUGetAllActorsWithTagInRangeSorted_ReturnValue_Offset;

	private static bool BGUGetActiveMontagePosition_IsValid;

	private static IntPtr BGUGetActiveMontagePosition_FunctionAddress;

	private static int BGUGetActiveMontagePosition_ParamsSize;

	private static bool BGUGetActiveMontagePosition_Actor_IsValid;

	private static FFieldAddress BGUGetActiveMontagePosition_Actor_PropertyAddress;

	private static int BGUGetActiveMontagePosition_Actor_Offset;

	private static bool BGUGetActiveMontagePosition_Montage_IsValid;

	private static FFieldAddress BGUGetActiveMontagePosition_Montage_PropertyAddress;

	private static int BGUGetActiveMontagePosition_Montage_Offset;

	private static bool BGUGetActiveMontagePosition_ReturnValue_IsValid;

	private static FFieldAddress BGUGetActiveMontagePosition_ReturnValue_PropertyAddress;

	private static int BGUGetActiveMontagePosition_ReturnValue_Offset;

	private static bool BGUGenProceduralLevel_IsValid;

	private static IntPtr BGUGenProceduralLevel_FunctionAddress;

	private static int BGUGenProceduralLevel_ParamsSize;

	private static bool BGUGenProceduralLevel_WorldContextObject_IsValid;

	private static FFieldAddress BGUGenProceduralLevel_WorldContextObject_PropertyAddress;

	private static int BGUGenProceduralLevel_WorldContextObject_Offset;

	private static bool BGUGenProceduralLevel_WorldAssetName_IsValid;

	private static FFieldAddress BGUGenProceduralLevel_WorldAssetName_PropertyAddress;

	private static int BGUGenProceduralLevel_WorldAssetName_Offset;

	private static bool BGUGenProceduralLevel_InLevelName_IsValid;

	private static FFieldAddress BGUGenProceduralLevel_InLevelName_PropertyAddress;

	private static int BGUGenProceduralLevel_InLevelName_Offset;

	private static bool BGUGenProceduralLevel_InLevelTransform_IsValid;

	private static FFieldAddress BGUGenProceduralLevel_InLevelTransform_PropertyAddress;

	private static int BGUGenProceduralLevel_InLevelTransform_Offset;

	private static bool BGUGenProceduralLevel_ReturnValue_IsValid;

	private static FFieldAddress BGUGenProceduralLevel_ReturnValue_PropertyAddress;

	private static int BGUGenProceduralLevel_ReturnValue_Offset;

	private static bool BGUGenComponentAndAdd_IsValid;

	private static IntPtr BGUGenComponentAndAdd_FunctionAddress;

	private static int BGUGenComponentAndAdd_ParamsSize;

	private static bool BGUGenComponentAndAdd_Actor_IsValid;

	private static FFieldAddress BGUGenComponentAndAdd_Actor_PropertyAddress;

	private static int BGUGenComponentAndAdd_Actor_Offset;

	private static bool BGUGenComponentAndAdd_ActorComponentClass_IsValid;

	private static FFieldAddress BGUGenComponentAndAdd_ActorComponentClass_PropertyAddress;

	private static int BGUGenComponentAndAdd_ActorComponentClass_Offset;

	private static bool BGUGenComponentAndAdd_ReturnValue_IsValid;

	private static FFieldAddress BGUGenComponentAndAdd_ReturnValue_PropertyAddress;

	private static int BGUGenComponentAndAdd_ReturnValue_Offset;

	private static bool BGUGenComponent_IsValid;

	private static IntPtr BGUGenComponent_FunctionAddress;

	private static int BGUGenComponent_ParamsSize;

	private static bool BGUGenComponent_Actor_IsValid;

	private static FFieldAddress BGUGenComponent_Actor_PropertyAddress;

	private static int BGUGenComponent_Actor_Offset;

	private static bool BGUGenComponent_ActorComponentClass_IsValid;

	private static FFieldAddress BGUGenComponent_ActorComponentClass_PropertyAddress;

	private static int BGUGenComponent_ActorComponentClass_Offset;

	private static bool BGUGenComponent_ReturnValue_IsValid;

	private static FFieldAddress BGUGenComponent_ReturnValue_PropertyAddress;

	private static int BGUGenComponent_ReturnValue_Offset;

	private static bool BGUFlushLevelStreamingOnlyVisibility_IsValid;

	private static IntPtr BGUFlushLevelStreamingOnlyVisibility_FunctionAddress;

	private static int BGUFlushLevelStreamingOnlyVisibility_ParamsSize;

	private static bool BGUFlushLevelStreamingOnlyVisibility_WorldContextObject_IsValid;

	private static FFieldAddress BGUFlushLevelStreamingOnlyVisibility_WorldContextObject_PropertyAddress;

	private static int BGUFlushLevelStreamingOnlyVisibility_WorldContextObject_Offset;

	private static bool BGUFinishSpawningActor_IsValid;

	private static IntPtr BGUFinishSpawningActor_FunctionAddress;

	private static int BGUFinishSpawningActor_ParamsSize;

	private static bool BGUFinishSpawningActor_Actor_IsValid;

	private static FFieldAddress BGUFinishSpawningActor_Actor_PropertyAddress;

	private static int BGUFinishSpawningActor_Actor_Offset;

	private static bool BGUFinishSpawningActor_SpawnTransform_IsValid;

	private static FFieldAddress BGUFinishSpawningActor_SpawnTransform_PropertyAddress;

	private static int BGUFinishSpawningActor_SpawnTransform_Offset;

	private static bool BGUFinishSpawningActor_ReturnValue_IsValid;

	private static FFieldAddress BGUFinishSpawningActor_ReturnValue_PropertyAddress;

	private static int BGUFinishSpawningActor_ReturnValue_Offset;

	private static bool BGUFindFirstActorWithTag_IsValid;

	private static IntPtr BGUFindFirstActorWithTag_FunctionAddress;

	private static int BGUFindFirstActorWithTag_ParamsSize;

	private static bool BGUFindFirstActorWithTag_WorldContextObject_IsValid;

	private static FFieldAddress BGUFindFirstActorWithTag_WorldContextObject_PropertyAddress;

	private static int BGUFindFirstActorWithTag_WorldContextObject_Offset;

	private static bool BGUFindFirstActorWithTag_TagName_IsValid;

	private static FFieldAddress BGUFindFirstActorWithTag_TagName_PropertyAddress;

	private static int BGUFindFirstActorWithTag_TagName_Offset;

	private static bool BGUFindFirstActorWithTag_ReturnValue_IsValid;

	private static FFieldAddress BGUFindFirstActorWithTag_ReturnValue_PropertyAddress;

	private static int BGUFindFirstActorWithTag_ReturnValue_Offset;

	private static bool BGUCalcBounds_IsValid;

	private static IntPtr BGUCalcBounds_FunctionAddress;

	private static int BGUCalcBounds_ParamsSize;

	private static bool BGUCalcBounds_StaticMesh_IsValid;

	private static FFieldAddress BGUCalcBounds_StaticMesh_PropertyAddress;

	private static int BGUCalcBounds_StaticMesh_Offset;

	private static bool BGUCalcBounds_Origin_IsValid;

	private static FFieldAddress BGUCalcBounds_Origin_PropertyAddress;

	private static int BGUCalcBounds_Origin_Offset;

	private static bool BGUCalcBounds_BoxExtent_IsValid;

	private static FFieldAddress BGUCalcBounds_BoxExtent_PropertyAddress;

	private static int BGUCalcBounds_BoxExtent_Offset;

	private static bool BGUCalcBounds_SphereRadius_IsValid;

	private static FFieldAddress BGUCalcBounds_SphereRadius_PropertyAddress;

	private static int BGUCalcBounds_SphereRadius_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClassWithName_IsValid;

	private static IntPtr BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress;

	private static int BGUBeginDeferredActorSpawnFromClassWithName_ParamsSize;

	private static bool BGUBeginDeferredActorSpawnFromClassWithName_WorldContextObject_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClassWithName_WorldContextObject_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClassWithName_WorldContextObject_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClassWithName_ActorClass_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClassWithName_ActorClass_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClassWithName_ActorClass_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClassWithName_SpawnTransform_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClassWithName_SpawnTransform_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClassWithName_SpawnTransform_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClassWithName_CollisionHandlingOverride_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClassWithName_CollisionHandlingOverride_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClassWithName_CollisionHandlingOverride_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClassWithName_Owner_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClassWithName_Owner_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClassWithName_Owner_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClassWithName_ActorName_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClassWithName_ActorName_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClassWithName_ActorName_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClassWithName_OverrideLevel_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClassWithName_OverrideLevel_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClassWithName_OverrideLevel_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClassWithName_ReturnValue_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClassWithName_ReturnValue_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClassWithName_ReturnValue_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClass_IsValid;

	private static IntPtr BGUBeginDeferredActorSpawnFromClass_FunctionAddress;

	private static int BGUBeginDeferredActorSpawnFromClass_ParamsSize;

	private static bool BGUBeginDeferredActorSpawnFromClass_WorldContextObject_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClass_WorldContextObject_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClass_WorldContextObject_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClass_ActorClass_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClass_ActorClass_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClass_ActorClass_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClass_SpawnTransform_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClass_SpawnTransform_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClass_SpawnTransform_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClass_CollisionHandlingOverride_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClass_CollisionHandlingOverride_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClass_CollisionHandlingOverride_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClass_Owner_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClass_Owner_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClass_Owner_Offset;

	private static bool BGUBeginDeferredActorSpawnFromClass_ReturnValue_IsValid;

	private static FFieldAddress BGUBeginDeferredActorSpawnFromClass_ReturnValue_PropertyAddress;

	private static int BGUBeginDeferredActorSpawnFromClass_ReturnValue_Offset;

	private static bool BGUActorUpdateAllTFXComp_IsValid;

	private static IntPtr BGUActorUpdateAllTFXComp_FunctionAddress;

	private static int BGUActorUpdateAllTFXComp_ParamsSize;

	private static bool BGUActorUpdateAllTFXComp_Actor_IsValid;

	private static FFieldAddress BGUActorUpdateAllTFXComp_Actor_PropertyAddress;

	private static int BGUActorUpdateAllTFXComp_Actor_Offset;

	private static bool ApplyLevelTransform_IsValid;

	private static IntPtr ApplyLevelTransform_FunctionAddress;

	private static int ApplyLevelTransform_ParamsSize;

	private static bool ApplyLevelTransform_WorldContextObject_IsValid;

	private static FFieldAddress ApplyLevelTransform_WorldContextObject_PropertyAddress;

	private static int ApplyLevelTransform_WorldContextObject_Offset;

	private static bool ApplyLevelTransform_LevelName_IsValid;

	private static FFieldAddress ApplyLevelTransform_LevelName_PropertyAddress;

	private static int ApplyLevelTransform_LevelName_Offset;

	private static bool ApplyLevelTransform_LevelTransform_IsValid;

	private static FFieldAddress ApplyLevelTransform_LevelTransform_PropertyAddress;

	private static int ApplyLevelTransform_LevelTransform_Offset;

	private static bool AddLevelStreaming_IsValid;

	private static IntPtr AddLevelStreaming_FunctionAddress;

	private static int AddLevelStreaming_ParamsSize;

	private static bool AddLevelStreaming_WorldContextObject_IsValid;

	private static FFieldAddress AddLevelStreaming_WorldContextObject_PropertyAddress;

	private static int AddLevelStreaming_WorldContextObject_Offset;

	private static bool AddLevelStreaming_LevelName_IsValid;

	private static FFieldAddress AddLevelStreaming_LevelName_PropertyAddress;

	private static int AddLevelStreaming_LevelName_Offset;

	private static bool AddLevelStreaming_Location_IsValid;

	private static FFieldAddress AddLevelStreaming_Location_PropertyAddress;

	private static int AddLevelStreaming_Location_Offset;

	private static bool AddLevelStreaming_Rotation_IsValid;

	private static FFieldAddress AddLevelStreaming_Rotation_PropertyAddress;

	private static int AddLevelStreaming_Rotation_Offset;

	private static bool AddLevelStreaming_bShouldBlockOnLoad_IsValid;

	private static FFieldAddress AddLevelStreaming_bShouldBlockOnLoad_PropertyAddress;

	private static int AddLevelStreaming_bShouldBlockOnLoad_Offset;

	private static bool AddLevelStreaming_ReturnValue_IsValid;

	private static FFieldAddress AddLevelStreaming_ReturnValue_PropertyAddress;

	private static int AddLevelStreaming_ReturnValue_Offset;

	private static bool AddBuffNotifyStates_IsValid;

	private static IntPtr AddBuffNotifyStates_FunctionAddress;

	private static int AddBuffNotifyStates_ParamsSize;

	private static bool AddBuffNotifyStates_MontageObj_IsValid;

	private static FFieldAddress AddBuffNotifyStates_MontageObj_PropertyAddress;

	private static int AddBuffNotifyStates_MontageObj_Offset;

	private static bool AddBuffNotifyStates_NewNotifyStateClass_IsValid;

	private static FFieldAddress AddBuffNotifyStates_NewNotifyStateClass_PropertyAddress;

	private static int AddBuffNotifyStates_NewNotifyStateClass_Offset;

	private static bool AddBuffNotifyStates_BuffID_IsValid;

	private static FFieldAddress AddBuffNotifyStates_BuffID_PropertyAddress;

	private static int AddBuffNotifyStates_BuffID_Offset;

	private static bool AddBuffNotifyStates_NotifyStateInfos_IsValid;

	private static FFieldAddress AddBuffNotifyStates_NotifyStateInfos_PropertyAddress;

	private static int AddBuffNotifyStates_NotifyStateInfos_Offset;

	private static bool AddAllAnimNotifyStatesAccordingToReference_IsValid;

	private static IntPtr AddAllAnimNotifyStatesAccordingToReference_FunctionAddress;

	private static int AddAllAnimNotifyStatesAccordingToReference_ParamsSize;

	private static bool AddAllAnimNotifyStatesAccordingToReference_ResourcePath_IsValid;

	private static FFieldAddress AddAllAnimNotifyStatesAccordingToReference_ResourcePath_PropertyAddress;

	private static int AddAllAnimNotifyStatesAccordingToReference_ResourcePath_Offset;

	private static bool AddAllAnimNotifyStatesAccordingToReference_RefNotifyStateClass_IsValid;

	private static FFieldAddress AddAllAnimNotifyStatesAccordingToReference_RefNotifyStateClass_PropertyAddress;

	private static int AddAllAnimNotifyStatesAccordingToReference_RefNotifyStateClass_Offset;

	private static bool AddAllAnimNotifyStatesAccordingToReference_NewNotifyStateClass_IsValid;

	private static FFieldAddress AddAllAnimNotifyStatesAccordingToReference_NewNotifyStateClass_PropertyAddress;

	private static int AddAllAnimNotifyStatesAccordingToReference_NewNotifyStateClass_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:WrapHitResult")]
	public unsafe static FUStGSHitResult WrapHitResult(FHitResult HitResult)
	{
		if (!WrapHitResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:WrapHitResult");
			return default(FUStGSHitResult);
		}
		byte* ptr = stackalloc byte[(int)(uint)(WrapHitResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WrapHitResult_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(WrapHitResult_HitResult_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, WrapHitResult_HitResult_Offset), 0, WrapHitResult_HitResult_PropertyAddress.Address, HitResult);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, WrapHitResult_FunctionAddress, intPtr, WrapHitResult_ParamsSize);
		return FUStGSHitResult.FromNative(IntPtr.Add(intPtr, WrapHitResult_ReturnValue_Offset), 0, WrapHitResult_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:VolumeEncompassPoint")]
	public unsafe static bool VolumeEncompassPoint(AVolume Volume, FVector Point, float SphereRadius, out float OutDistanceToPoint)
	{
		if (!VolumeEncompassPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:VolumeEncompassPoint");
			OutDistanceToPoint = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VolumeEncompassPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VolumeEncompassPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AVolume>.ToNative(IntPtr.Add(intPtr, VolumeEncompassPoint_Volume_Offset), 0, VolumeEncompassPoint_Volume_PropertyAddress.Address, Volume);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VolumeEncompassPoint_Point_Offset), 0, VolumeEncompassPoint_Point_PropertyAddress.Address, Point);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, VolumeEncompassPoint_SphereRadius_Offset), 0, VolumeEncompassPoint_SphereRadius_PropertyAddress.Address, SphereRadius);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, VolumeEncompassPoint_FunctionAddress, intPtr, VolumeEncompassPoint_ParamsSize);
		OutDistanceToPoint = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, VolumeEncompassPoint_OutDistanceToPoint_Offset), 0, VolumeEncompassPoint_OutDistanceToPoint_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, VolumeEncompassPoint_ReturnValue_Offset), 0, VolumeEncompassPoint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:SphereComponentInitRadius")]
	public unsafe static void SphereComponentInitRadius(USphereComponent SphereComp, float Radius)
	{
		if (!SphereComponentInitRadius_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:SphereComponentInitRadius");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SphereComponentInitRadius_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SphereComponentInitRadius_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(intPtr, SphereComponentInitRadius_SphereComp_Offset), 0, SphereComponentInitRadius_SphereComp_PropertyAddress.Address, SphereComp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SphereComponentInitRadius_Radius_Offset), 0, SphereComponentInitRadius_Radius_PropertyAddress.Address, Radius);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SphereComponentInitRadius_FunctionAddress, intPtr, SphereComponentInitRadius_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:SetLocalKinematics")]
	public unsafe static void SetLocalKinematics(USkeletalMeshComponent TargetMesh, bool NewBool)
	{
		if (!SetLocalKinematics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:SetLocalKinematics");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLocalKinematics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLocalKinematics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetLocalKinematics_TargetMesh_Offset), 0, SetLocalKinematics_TargetMesh_PropertyAddress.Address, TargetMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetLocalKinematics_NewBool_Offset), 0, SetLocalKinematics_NewBool_PropertyAddress.Address, NewBool);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetLocalKinematics_FunctionAddress, intPtr, SetLocalKinematics_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:SetIKValid")]
	public unsafe static void SetIKValid(ACharacter Character, bool NewValid)
	{
		if (!SetIKValid_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:SetIKValid");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetIKValid_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetIKValid_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(intPtr, SetIKValid_Character_Offset), 0, SetIKValid_Character_PropertyAddress.Address, Character);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetIKValid_NewValid_Offset), 0, SetIKValid_NewValid_PropertyAddress.Address, NewValid);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetIKValid_FunctionAddress, intPtr, SetIKValid_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:SetBodyBonePhysic")]
	public unsafe static void SetBodyBonePhysic(USkeletalMeshComponent TargetMesh, FName BoneName, bool NewBool)
	{
		if (!SetBodyBonePhysic_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:SetBodyBonePhysic");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBodyBonePhysic_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBodyBonePhysic_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetBodyBonePhysic_TargetMesh_Offset), 0, SetBodyBonePhysic_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetBodyBonePhysic_BoneName_Offset), 0, SetBodyBonePhysic_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBodyBonePhysic_NewBool_Offset), 0, SetBodyBonePhysic_NewBool_PropertyAddress.Address, NewBool);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBodyBonePhysic_FunctionAddress, intPtr, SetBodyBonePhysic_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:SetAllBodiesBelowSimulatePhysics")]
	public unsafe static void SetAllBodiesBelowSimulatePhysics(USkeletalMeshComponent TargetMesh, FName InBoneName, bool bNewSimulate, bool bIncludeSelf = true, bool bSkipCustomPhysicsType = false)
	{
		if (!SetAllBodiesBelowSimulatePhysics_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:SetAllBodiesBelowSimulatePhysics");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAllBodiesBelowSimulatePhysics_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAllBodiesBelowSimulatePhysics_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, SetAllBodiesBelowSimulatePhysics_TargetMesh_Offset), 0, SetAllBodiesBelowSimulatePhysics_TargetMesh_PropertyAddress.Address, TargetMesh);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetAllBodiesBelowSimulatePhysics_InBoneName_Offset), 0, SetAllBodiesBelowSimulatePhysics_InBoneName_PropertyAddress.Address, InBoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllBodiesBelowSimulatePhysics_bNewSimulate_Offset), 0, SetAllBodiesBelowSimulatePhysics_bNewSimulate_PropertyAddress.Address, bNewSimulate);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllBodiesBelowSimulatePhysics_bIncludeSelf_Offset), 0, SetAllBodiesBelowSimulatePhysics_bIncludeSelf_PropertyAddress.Address, bIncludeSelf);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetAllBodiesBelowSimulatePhysics_bSkipCustomPhysicsType_Offset), 0, SetAllBodiesBelowSimulatePhysics_bSkipCustomPhysicsType_PropertyAddress.Address, bSkipCustomPhysicsType);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAllBodiesBelowSimulatePhysics_FunctionAddress, intPtr, SetAllBodiesBelowSimulatePhysics_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:SerializeActorComponentToLevelActor")]
	public unsafe static void SerializeActorComponentToLevelActor(AActor TargetLevelActor, UActorComponent InActorComponent)
	{
		if (!SerializeActorComponentToLevelActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:SerializeActorComponentToLevelActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SerializeActorComponentToLevelActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SerializeActorComponentToLevelActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SerializeActorComponentToLevelActor_TargetLevelActor_Offset), 0, SerializeActorComponentToLevelActor_TargetLevelActor_PropertyAddress.Address, TargetLevelActor);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, SerializeActorComponentToLevelActor_InActorComponent_Offset), 0, SerializeActorComponentToLevelActor_InActorComponent_PropertyAddress.Address, InActorComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SerializeActorComponentToLevelActor_FunctionAddress, intPtr, SerializeActorComponentToLevelActor_ParamsSize);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:ReplaceAllAnimNotifyStates")]
	public unsafe static void ReplaceAllAnimNotifyStates(string ResourcePath, TSubclassOf<UAnimNotifyState> OldNotifyStateClass, TSubclassOf<UAnimNotifyState> NewNotifyStateClass)
	{
		if (!ReplaceAllAnimNotifyStates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:ReplaceAllAnimNotifyStates");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceAllAnimNotifyStates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceAllAnimNotifyStates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ReplaceAllAnimNotifyStates_ResourcePath_Offset), 0, ReplaceAllAnimNotifyStates_ResourcePath_PropertyAddress.Address, ResourcePath);
		TSubclassOfMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, ReplaceAllAnimNotifyStates_OldNotifyStateClass_Offset), 0, ReplaceAllAnimNotifyStates_OldNotifyStateClass_PropertyAddress.Address, OldNotifyStateClass);
		TSubclassOfMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, ReplaceAllAnimNotifyStates_NewNotifyStateClass_Offset), 0, ReplaceAllAnimNotifyStates_NewNotifyStateClass_PropertyAddress.Address, NewNotifyStateClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReplaceAllAnimNotifyStates_FunctionAddress, intPtr, ReplaceAllAnimNotifyStates_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ReplaceAllAnimNotifyStates_ResourcePath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:RemoveLevelStreaming")]
	public unsafe static void RemoveLevelStreaming(UObject WorldContextObject, FName LevelName)
	{
		if (!RemoveLevelStreaming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:RemoveLevelStreaming");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveLevelStreaming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveLevelStreaming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, RemoveLevelStreaming_WorldContextObject_Offset), 0, RemoveLevelStreaming_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, RemoveLevelStreaming_LevelName_Offset), 0, RemoveLevelStreaming_LevelName_PropertyAddress.Address, LevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveLevelStreaming_FunctionAddress, intPtr, RemoveLevelStreaming_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:RemoveActorComponentFromLevelActor")]
	public unsafe static void RemoveActorComponentFromLevelActor(AActor TargetLevelActor, UActorComponent InActorComponent)
	{
		if (!RemoveActorComponentFromLevelActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:RemoveActorComponentFromLevelActor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveActorComponentFromLevelActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveActorComponentFromLevelActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, RemoveActorComponentFromLevelActor_TargetLevelActor_Offset), 0, RemoveActorComponentFromLevelActor_TargetLevelActor_PropertyAddress.Address, TargetLevelActor);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, RemoveActorComponentFromLevelActor_InActorComponent_Offset), 0, RemoveActorComponentFromLevelActor_InActorComponent_PropertyAddress.Address, InActorComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveActorComponentFromLevelActor_FunctionAddress, intPtr, RemoveActorComponentFromLevelActor_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:MoveLevel")]
	public unsafe static void MoveLevel(UObject WorldContextObject, FName LevelName, FVector InWorldOffset, bool bActorOnly)
	{
		if (!MoveLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:MoveLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, MoveLevel_WorldContextObject_Offset), 0, MoveLevel_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, MoveLevel_LevelName_Offset), 0, MoveLevel_LevelName_PropertyAddress.Address, LevelName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MoveLevel_InWorldOffset_Offset), 0, MoveLevel_InWorldOffset_PropertyAddress.Address, InWorldOffset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveLevel_bActorOnly_Offset), 0, MoveLevel_bActorOnly_PropertyAddress.Address, bActorOnly);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MoveLevel_FunctionAddress, intPtr, MoveLevel_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:MakeUniqueTamerMonsterName")]
	public unsafe FName MakeUniqueTamerMonsterName(ULevel SpawnLevel, FName InBaseName)
	{
		CheckDestroyed();
		if (!MakeUniqueTamerMonsterName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:MakeUniqueTamerMonsterName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(MakeUniqueTamerMonsterName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MakeUniqueTamerMonsterName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, MakeUniqueTamerMonsterName_SpawnLevel_Offset), 0, MakeUniqueTamerMonsterName_SpawnLevel_PropertyAddress.Address, SpawnLevel);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, MakeUniqueTamerMonsterName_InBaseName_Offset), 0, MakeUniqueTamerMonsterName_InBaseName_PropertyAddress.Address, InBaseName);
		NativeReflection.InvokeFunctionOptimized(base.Address, MakeUniqueTamerMonsterName_FunctionAddress, intPtr, MakeUniqueTamerMonsterName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, MakeUniqueTamerMonsterName_ReturnValue_Offset), 0, MakeUniqueTamerMonsterName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetStreamingVolumeBounds")]
	public unsafe static FBox GetStreamingVolumeBounds(ULevelStreaming LevelStreaming)
	{
		if (!GetStreamingVolumeBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetStreamingVolumeBounds");
			return default(FBox);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStreamingVolumeBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStreamingVolumeBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelStreaming>.ToNative(IntPtr.Add(intPtr, GetStreamingVolumeBounds_LevelStreaming_Offset), 0, GetStreamingVolumeBounds_LevelStreaming_PropertyAddress.Address, LevelStreaming);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStreamingVolumeBounds_FunctionAddress, intPtr, GetStreamingVolumeBounds_ParamsSize);
		return BlittableTypeMarshaler<FBox>.FromNative(IntPtr.Add(intPtr, GetStreamingVolumeBounds_ReturnValue_Offset), 0, GetStreamingVolumeBounds_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 608314369u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetScalarParameterValueByInfo")]
	public unsafe static float GetScalarParameterValueByInfo(UMaterialInterface Mat, FMaterialParameterInfo ParameterInfo)
	{
		if (!GetScalarParameterValueByInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetScalarParameterValueByInfo");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetScalarParameterValueByInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetScalarParameterValueByInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, GetScalarParameterValueByInfo_Mat_Offset), 0, GetScalarParameterValueByInfo_Mat_PropertyAddress.Address, Mat);
		NativeReflection.InitializeValue_InContainer(GetScalarParameterValueByInfo_ParameterInfo_PropertyAddress.Address, intPtr);
		FMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, GetScalarParameterValueByInfo_ParameterInfo_Offset), 0, GetScalarParameterValueByInfo_ParameterInfo_PropertyAddress.Address, ParameterInfo);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetScalarParameterValueByInfo_FunctionAddress, intPtr, GetScalarParameterValueByInfo_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetScalarParameterValueByInfo_ReturnValue_Offset), 0, GetScalarParameterValueByInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetPreviewMesh")]
	public unsafe static USkeletalMesh GetPreviewMesh(USkeleton Skeleton, bool bFindIfNotSet = false)
	{
		if (!GetPreviewMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetPreviewMesh");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPreviewMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPreviewMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeleton>.ToNative(IntPtr.Add(intPtr, GetPreviewMesh_Skeleton_Offset), 0, GetPreviewMesh_Skeleton_PropertyAddress.Address, Skeleton);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetPreviewMesh_bFindIfNotSet_Offset), 0, GetPreviewMesh_bFindIfNotSet_PropertyAddress.Address, bFindIfNotSet);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPreviewMesh_FunctionAddress, intPtr, GetPreviewMesh_ParamsSize);
		return UObjectMarshaler<USkeletalMesh>.FromNative(IntPtr.Add(intPtr, GetPreviewMesh_ReturnValue_Offset), 0, GetPreviewMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetPlayerCharacter")]
	public unsafe static ACharacter GetPlayerCharacter(UObject WorldContextObject)
	{
		if (!GetPlayerCharacter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetPlayerCharacter");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerCharacter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerCharacter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetPlayerCharacter_WorldContextObject_Offset), 0, GetPlayerCharacter_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPlayerCharacter_FunctionAddress, intPtr, GetPlayerCharacter_ParamsSize);
		return UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(intPtr, GetPlayerCharacter_ReturnValue_Offset), 0, GetPlayerCharacter_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetNearestBoneName")]
	public unsafe static FName GetNearestBoneName(USkeletalMeshComponent TargetSkeletalMesh, FVector WorldPosition, List<string> OptionalWhiteList)
	{
		if (!GetNearestBoneName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetNearestBoneName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNearestBoneName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNearestBoneName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, GetNearestBoneName_TargetSkeletalMesh_Offset), 0, GetNearestBoneName_TargetSkeletalMesh_PropertyAddress.Address, TargetSkeletalMesh);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, GetNearestBoneName_WorldPosition_Offset), 0, GetNearestBoneName_WorldPosition_PropertyAddress.Address, WorldPosition);
		new TArrayCopyMarshaler<string>(1, GetNearestBoneName_OptionalWhiteList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, GetNearestBoneName_OptionalWhiteList_Offset), OptionalWhiteList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNearestBoneName_FunctionAddress, intPtr, GetNearestBoneName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetNearestBoneName_OptionalWhiteList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetNearestBoneName_ReturnValue_Offset), 0, GetNearestBoneName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 616702977u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetLinearColorParameterValueByInfo")]
	public unsafe static bool GetLinearColorParameterValueByInfo(UMaterialInterface Mat, FMaterialParameterInfo ParameterInfo, out FLinearColor OutValue, bool bOveriddenOnly = false)
	{
		if (!GetLinearColorParameterValueByInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetLinearColorParameterValueByInfo");
			OutValue = default(FLinearColor);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLinearColorParameterValueByInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLinearColorParameterValueByInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(intPtr, GetLinearColorParameterValueByInfo_Mat_Offset), 0, GetLinearColorParameterValueByInfo_Mat_PropertyAddress.Address, Mat);
		NativeReflection.InitializeValue_InContainer(GetLinearColorParameterValueByInfo_ParameterInfo_PropertyAddress.Address, intPtr);
		FMaterialParameterInfo.ToNative(IntPtr.Add(intPtr, GetLinearColorParameterValueByInfo_ParameterInfo_Offset), 0, GetLinearColorParameterValueByInfo_ParameterInfo_PropertyAddress.Address, ParameterInfo);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetLinearColorParameterValueByInfo_bOveriddenOnly_Offset), 0, GetLinearColorParameterValueByInfo_bOveriddenOnly_PropertyAddress.Address, bOveriddenOnly);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLinearColorParameterValueByInfo_FunctionAddress, intPtr, GetLinearColorParameterValueByInfo_ParamsSize);
		OutValue = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(intPtr, GetLinearColorParameterValueByInfo_OutValue_Offset), 0, GetLinearColorParameterValueByInfo_OutValue_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetLinearColorParameterValueByInfo_ReturnValue_Offset), 0, GetLinearColorParameterValueByInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetLevelStreamingState")]
	public unsafe static byte GetLevelStreamingState(UObject WorldContextObject, FName LevelName)
	{
		if (!GetLevelStreamingState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetLevelStreamingState");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelStreamingState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelStreamingState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLevelStreamingState_WorldContextObject_Offset), 0, GetLevelStreamingState_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetLevelStreamingState_LevelName_Offset), 0, GetLevelStreamingState_LevelName_PropertyAddress.Address, LevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelStreamingState_FunctionAddress, intPtr, GetLevelStreamingState_ParamsSize);
		return BlittableTypeMarshaler<byte>.FromNative(IntPtr.Add(intPtr, GetLevelStreamingState_ReturnValue_Offset), 0, GetLevelStreamingState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetLevelStreamingLevelTransformByName")]
	public unsafe static FTransform GetLevelStreamingLevelTransformByName(UObject WorldContextObject, FName LevelName)
	{
		if (!GetLevelStreamingLevelTransformByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetLevelStreamingLevelTransformByName");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelStreamingLevelTransformByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelStreamingLevelTransformByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLevelStreamingLevelTransformByName_WorldContextObject_Offset), 0, GetLevelStreamingLevelTransformByName_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetLevelStreamingLevelTransformByName_LevelName_Offset), 0, GetLevelStreamingLevelTransformByName_LevelName_PropertyAddress.Address, LevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelStreamingLevelTransformByName_FunctionAddress, intPtr, GetLevelStreamingLevelTransformByName_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, GetLevelStreamingLevelTransformByName_ReturnValue_Offset), 0, GetLevelStreamingLevelTransformByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetLevelStreamingFromWorld")]
	public unsafe static List<ULevelStreaming> GetLevelStreamingFromWorld(UWorld World)
	{
		if (!GetLevelStreamingFromWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetLevelStreamingFromWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelStreamingFromWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelStreamingFromWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetLevelStreamingFromWorld_World_Offset), 0, GetLevelStreamingFromWorld_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelStreamingFromWorld_FunctionAddress, intPtr, GetLevelStreamingFromWorld_ParamsSize);
		List<ULevelStreaming> result = new TArrayCopyMarshaler<ULevelStreaming>(1, GetLevelStreamingFromWorld_ReturnValue_PropertyAddress, CachedMarshalingDelegates<ULevelStreaming, UObjectMarshaler<ULevelStreaming>>.FromNative, CachedMarshalingDelegates<ULevelStreaming, UObjectMarshaler<ULevelStreaming>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelStreamingFromWorld_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelStreamingFromWorld_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetLevelStreaming")]
	public unsafe static List<ULevelStreaming> GetLevelStreaming(UObject WorldContextObject)
	{
		if (!GetLevelStreaming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetLevelStreaming");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelStreaming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelStreaming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, GetLevelStreaming_WorldContextObject_Offset), 0, GetLevelStreaming_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetLevelStreaming_FunctionAddress, intPtr, GetLevelStreaming_ParamsSize);
		List<ULevelStreaming> result = new TArrayCopyMarshaler<ULevelStreaming>(1, GetLevelStreaming_ReturnValue_PropertyAddress, CachedMarshalingDelegates<ULevelStreaming, UObjectMarshaler<ULevelStreaming>>.FromNative, CachedMarshalingDelegates<ULevelStreaming, UObjectMarshaler<ULevelStreaming>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelStreaming_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelStreaming_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetAssetLongPackageName")]
	public unsafe static FName GetAssetLongPackageName(FName ClassName, string AssetName)
	{
		if (!GetAssetLongPackageName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetAssetLongPackageName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetLongPackageName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetLongPackageName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAssetLongPackageName_ClassName_Offset), 0, GetAssetLongPackageName_ClassName_PropertyAddress.Address, ClassName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetLongPackageName_AssetName_Offset), 0, GetAssetLongPackageName_AssetName_PropertyAddress.Address, AssetName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetLongPackageName_FunctionAddress, intPtr, GetAssetLongPackageName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetLongPackageName_AssetName_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetAssetLongPackageName_ReturnValue_Offset), 0, GetAssetLongPackageName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetAllAssetReference")]
	public unsafe static List<FName> GetAllAssetReference(FName SelectedPackageName)
	{
		if (!GetAllAssetReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetAllAssetReference");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllAssetReference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllAssetReference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAllAssetReference_SelectedPackageName_Offset), 0, GetAllAssetReference_SelectedPackageName_PropertyAddress.Address, SelectedPackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllAssetReference_FunctionAddress, intPtr, GetAllAssetReference_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetAllAssetReference_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAssetReference_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAssetReference_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetAllAssetDependencies")]
	public unsafe static List<FName> GetAllAssetDependencies(FName SelectedPackageName)
	{
		if (!GetAllAssetDependencies_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetAllAssetDependencies");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllAssetDependencies_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllAssetDependencies_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, GetAllAssetDependencies_SelectedPackageName_Offset), 0, GetAllAssetDependencies_SelectedPackageName_PropertyAddress.Address, SelectedPackageName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllAssetDependencies_FunctionAddress, intPtr, GetAllAssetDependencies_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetAllAssetDependencies_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAssetDependencies_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAssetDependencies_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetAllActorsInWorld")]
	public unsafe static List<AActor> GetAllActorsInWorld(UWorld World)
	{
		if (!GetAllActorsInWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetAllActorsInWorld");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllActorsInWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllActorsInWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, GetAllActorsInWorld_World_Offset), 0, GetAllActorsInWorld_World_PropertyAddress.Address, World);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllActorsInWorld_FunctionAddress, intPtr, GetAllActorsInWorld_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetAllActorsInWorld_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllActorsInWorld_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllActorsInWorld_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:GetAllActorsInLevel")]
	public unsafe static List<AActor> GetAllActorsInLevel(ULevel Level)
	{
		if (!GetAllActorsInLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:GetAllActorsInLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllActorsInLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllActorsInLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, GetAllActorsInLevel_Level_Offset), 0, GetAllActorsInLevel_Level_PropertyAddress.Address, Level);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllActorsInLevel_FunctionAddress, intPtr, GetAllActorsInLevel_ParamsSize);
		List<AActor> result = new TArrayCopyMarshaler<AActor>(1, GetAllActorsInLevel_ReturnValue_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllActorsInLevel_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllActorsInLevel_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:ForceLoadTileLOD")]
	public unsafe static void ForceLoadTileLOD(UObject WorldContext, string TileName, int SwitchOn)
	{
		if (!ForceLoadTileLOD_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:ForceLoadTileLOD");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceLoadTileLOD_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceLoadTileLOD_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ForceLoadTileLOD_WorldContext_Offset), 0, ForceLoadTileLOD_WorldContext_PropertyAddress.Address, WorldContext);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ForceLoadTileLOD_TileName_Offset), 0, ForceLoadTileLOD_TileName_PropertyAddress.Address, TileName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ForceLoadTileLOD_SwitchOn_Offset), 0, ForceLoadTileLOD_SwitchOn_PropertyAddress.Address, SwitchOn);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ForceLoadTileLOD_FunctionAddress, intPtr, ForceLoadTileLOD_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ForceLoadTileLOD_TileName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:DrawDebugString")]
	public unsafe static void DrawDebugString(UObject WorldContextObject, FVector TextLocation, string Text, AActor TestBaseActor, FLinearColor TextColor, float Duration)
	{
		if (!DrawDebugString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:DrawDebugString");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DrawDebugString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DrawDebugString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, DrawDebugString_WorldContextObject_Offset), 0, DrawDebugString_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, DrawDebugString_TextLocation_Offset), 0, DrawDebugString_TextLocation_PropertyAddress.Address, TextLocation);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, DrawDebugString_Text_Offset), 0, DrawDebugString_Text_PropertyAddress.Address, Text);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, DrawDebugString_TestBaseActor_Offset), 0, DrawDebugString_TestBaseActor_PropertyAddress.Address, TestBaseActor);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, DrawDebugString_TextColor_Offset), 0, DrawDebugString_TextColor_PropertyAddress.Address, TextColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, DrawDebugString_Duration_Offset), 0, DrawDebugString_Duration_PropertyAddress.Address, Duration);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, DrawDebugString_FunctionAddress, intPtr, DrawDebugString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(DrawDebugString_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:CalculateMontageCostValue")]
	public unsafe static void CalculateMontageCostValue(List<UAnimMontage> MontageList, List<FName> BoneNameList)
	{
		if (!CalculateMontageCostValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:CalculateMontageCostValue");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CalculateMontageCostValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CalculateMontageCostValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<UAnimMontage>(1, CalculateMontageCostValue_MontageList_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).ToNative(IntPtr.Add(intPtr, CalculateMontageCostValue_MontageList_Offset), MontageList);
		new TArrayCopyMarshaler<FName>(1, CalculateMontageCostValue_BoneNameList_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, CalculateMontageCostValue_BoneNameList_Offset), BoneNameList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CalculateMontageCostValue_FunctionAddress, intPtr, CalculateMontageCostValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CalculateMontageCostValue_MontageList_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CalculateMontageCostValue_BoneNameList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BonesSphereMask")]
	public unsafe static List<FName> BonesSphereMask(USkeletalMeshComponent TargetSkeletalMesh, float Radius, FVector WorldPosition)
	{
		if (!BonesSphereMask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BonesSphereMask");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BonesSphereMask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BonesSphereMask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, BonesSphereMask_TargetSkeletalMesh_Offset), 0, BonesSphereMask_TargetSkeletalMesh_PropertyAddress.Address, TargetSkeletalMesh);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BonesSphereMask_Radius_Offset), 0, BonesSphereMask_Radius_PropertyAddress.Address, Radius);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BonesSphereMask_WorldPosition_Offset), 0, BonesSphereMask_WorldPosition_PropertyAddress.Address, WorldPosition);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BonesSphereMask_FunctionAddress, intPtr, BonesSphereMask_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, BonesSphereMask_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, BonesSphereMask_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(BonesSphereMask_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUWoodTestCharacter")]
	public unsafe static void BGUWoodTestCharacter(AActor Character, UAnimMontage Montage, float ScaleRate)
	{
		if (!BGUWoodTestCharacter_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUWoodTestCharacter");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUWoodTestCharacter_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUWoodTestCharacter_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUWoodTestCharacter_Character_Offset), 0, BGUWoodTestCharacter_Character_PropertyAddress.Address, Character);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUWoodTestCharacter_Montage_Offset), 0, BGUWoodTestCharacter_Montage_PropertyAddress.Address, Montage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUWoodTestCharacter_ScaleRate_Offset), 0, BGUWoodTestCharacter_ScaleRate_PropertyAddress.Address, ScaleRate);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUWoodTestCharacter_FunctionAddress, intPtr, BGUWoodTestCharacter_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUUpdateLevelStreaming")]
	public unsafe static void BGUUpdateLevelStreaming(UWorld CurWorld)
	{
		if (!BGUUpdateLevelStreaming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUUpdateLevelStreaming");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUUpdateLevelStreaming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUUpdateLevelStreaming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UWorld>.ToNative(IntPtr.Add(intPtr, BGUUpdateLevelStreaming_CurWorld_Offset), 0, BGUUpdateLevelStreaming_CurWorld_PropertyAddress.Address, CurWorld);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUUpdateLevelStreaming_FunctionAddress, intPtr, BGUUpdateLevelStreaming_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUUnloadStreamLevel")]
	public unsafe static void BGUUnloadStreamLevel(UObject WorldContextObject, FName LevelName, bool bShouldBlockOnUnload, UObject CallbackTarget, FName CallbackFunc, int ActionID = 0, int Linkage = 0)
	{
		if (!BGUUnloadStreamLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUUnloadStreamLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUUnloadStreamLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUUnloadStreamLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUUnloadStreamLevel_WorldContextObject_Offset), 0, BGUUnloadStreamLevel_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUUnloadStreamLevel_LevelName_Offset), 0, BGUUnloadStreamLevel_LevelName_PropertyAddress.Address, LevelName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUUnloadStreamLevel_bShouldBlockOnUnload_Offset), 0, BGUUnloadStreamLevel_bShouldBlockOnUnload_PropertyAddress.Address, bShouldBlockOnUnload);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUUnloadStreamLevel_CallbackTarget_Offset), 0, BGUUnloadStreamLevel_CallbackTarget_PropertyAddress.Address, CallbackTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUUnloadStreamLevel_CallbackFunc_Offset), 0, BGUUnloadStreamLevel_CallbackFunc_PropertyAddress.Address, CallbackFunc);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUUnloadStreamLevel_ActionID_Offset), 0, BGUUnloadStreamLevel_ActionID_PropertyAddress.Address, ActionID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUUnloadStreamLevel_Linkage_Offset), 0, BGUUnloadStreamLevel_Linkage_PropertyAddress.Address, Linkage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUUnloadStreamLevel_FunctionAddress, intPtr, BGUUnloadStreamLevel_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUSKMeshContainSocket")]
	public unsafe static bool BGUSKMeshContainSocket(USkeletalMeshComponent SkMeshComp, FName SocketName)
	{
		if (!BGUSKMeshContainSocket_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUSKMeshContainSocket");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSKMeshContainSocket_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSKMeshContainSocket_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, BGUSKMeshContainSocket_SkMeshComp_Offset), 0, BGUSKMeshContainSocket_SkMeshComp_PropertyAddress.Address, SkMeshComp);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUSKMeshContainSocket_SocketName_Offset), 0, BGUSKMeshContainSocket_SocketName_PropertyAddress.Address, SocketName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSKMeshContainSocket_FunctionAddress, intPtr, BGUSKMeshContainSocket_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUSKMeshContainSocket_ReturnValue_Offset), 0, BGUSKMeshContainSocket_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUShapeSweepMultiByObjectType")]
	public unsafe static bool BGUShapeSweepMultiByObjectType(UShapeComponent ShapeComp, FVector Start, FVector End, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, out List<FHitResult> OutHits, bool bIgnoreSelf)
	{
		if (!BGUShapeSweepMultiByObjectType_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUShapeSweepMultiByObjectType");
			OutHits = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUShapeSweepMultiByObjectType_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUShapeSweepMultiByObjectType_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UShapeComponent>.ToNative(IntPtr.Add(intPtr, BGUShapeSweepMultiByObjectType_ShapeComp_Offset), 0, BGUShapeSweepMultiByObjectType_ShapeComp_PropertyAddress.Address, ShapeComp);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUShapeSweepMultiByObjectType_Start_Offset), 0, BGUShapeSweepMultiByObjectType_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUShapeSweepMultiByObjectType_End_Offset), 0, BGUShapeSweepMultiByObjectType_End_PropertyAddress.Address, End);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, BGUShapeSweepMultiByObjectType_ObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(intPtr, BGUShapeSweepMultiByObjectType_ObjectTypes_Offset), ObjectTypes);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUShapeSweepMultiByObjectType_bTraceComplex_Offset), 0, BGUShapeSweepMultiByObjectType_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUShapeSweepMultiByObjectType_bIgnoreSelf_Offset), 0, BGUShapeSweepMultiByObjectType_bIgnoreSelf_PropertyAddress.Address, bIgnoreSelf);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUShapeSweepMultiByObjectType_FunctionAddress, intPtr, BGUShapeSweepMultiByObjectType_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUShapeSweepMultiByObjectType_ObjectTypes_PropertyAddress.Address, intPtr);
		OutHits = new TArrayCopyMarshaler<FHitResult>(1, BGUShapeSweepMultiByObjectType_OutHits_PropertyAddress, CachedMarshalingDelegates<FHitResult, FHitResult>.FromNative, CachedMarshalingDelegates<FHitResult, FHitResult>.ToNative).FromNative(IntPtr.Add(intPtr, BGUShapeSweepMultiByObjectType_OutHits_Offset));
		NativeReflection.DestroyValue_InContainer(BGUShapeSweepMultiByObjectType_OutHits_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUShapeSweepMultiByObjectType_ReturnValue_Offset), 0, BGUShapeSweepMultiByObjectType_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUSetValueToCurveVector")]
	public unsafe static void BGUSetValueToCurveVector(UCurveVector CurveVector, float Key, FVector Value, ERichCurveInterpMode InterpMode)
	{
		if (!BGUSetValueToCurveVector_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUSetValueToCurveVector");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetValueToCurveVector_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetValueToCurveVector_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(intPtr, BGUSetValueToCurveVector_CurveVector_Offset), 0, BGUSetValueToCurveVector_CurveVector_PropertyAddress.Address, CurveVector);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUSetValueToCurveVector_Key_Offset), 0, BGUSetValueToCurveVector_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUSetValueToCurveVector_Value_Offset), 0, BGUSetValueToCurveVector_Value_PropertyAddress.Address, Value);
		EnumMarshaler<ERichCurveInterpMode>.ToNative(IntPtr.Add(intPtr, BGUSetValueToCurveVector_InterpMode_Offset), 0, BGUSetValueToCurveVector_InterpMode_PropertyAddress.Address, InterpMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetValueToCurveVector_FunctionAddress, intPtr, BGUSetValueToCurveVector_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUSetValueToCurveFloat")]
	public unsafe static void BGUSetValueToCurveFloat(UCurveFloat CurveFloat, float Key, float Value, ERichCurveInterpMode InterpMode)
	{
		if (!BGUSetValueToCurveFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUSetValueToCurveFloat");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetValueToCurveFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetValueToCurveFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(intPtr, BGUSetValueToCurveFloat_CurveFloat_Offset), 0, BGUSetValueToCurveFloat_CurveFloat_PropertyAddress.Address, CurveFloat);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUSetValueToCurveFloat_Key_Offset), 0, BGUSetValueToCurveFloat_Key_PropertyAddress.Address, Key);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUSetValueToCurveFloat_Value_Offset), 0, BGUSetValueToCurveFloat_Value_PropertyAddress.Address, Value);
		EnumMarshaler<ERichCurveInterpMode>.ToNative(IntPtr.Add(intPtr, BGUSetValueToCurveFloat_InterpMode_Offset), 0, BGUSetValueToCurveFloat_InterpMode_PropertyAddress.Address, InterpMode);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetValueToCurveFloat_FunctionAddress, intPtr, BGUSetValueToCurveFloat_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUSetTressFXAssetAndMaterial")]
	public unsafe static void BGUSetTressFXAssetAndMaterial(UTressFXComponent TFXComp, UTressFXAsset Asset, UMaterialInstance Material)
	{
		if (!BGUSetTressFXAssetAndMaterial_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUSetTressFXAssetAndMaterial");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetTressFXAssetAndMaterial_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetTressFXAssetAndMaterial_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UTressFXComponent>.ToNative(IntPtr.Add(intPtr, BGUSetTressFXAssetAndMaterial_TFXComp_Offset), 0, BGUSetTressFXAssetAndMaterial_TFXComp_PropertyAddress.Address, TFXComp);
		UObjectMarshaler<UTressFXAsset>.ToNative(IntPtr.Add(intPtr, BGUSetTressFXAssetAndMaterial_Asset_Offset), 0, BGUSetTressFXAssetAndMaterial_Asset_PropertyAddress.Address, Asset);
		UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(intPtr, BGUSetTressFXAssetAndMaterial_Material_Offset), 0, BGUSetTressFXAssetAndMaterial_Material_PropertyAddress.Address, Material);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetTressFXAssetAndMaterial_FunctionAddress, intPtr, BGUSetTressFXAssetAndMaterial_ParamsSize);
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUSetLinearColorParameterValueToMesh")]
	public unsafe static void BGUSetLinearColorParameterValueToMesh(UMeshComponent MeshInst, FName ParameterName, FLinearColor LinearColorParameterValue)
	{
		if (!BGUSetLinearColorParameterValueToMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUSetLinearColorParameterValueToMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetLinearColorParameterValueToMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetLinearColorParameterValueToMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMeshComponent>.ToNative(IntPtr.Add(intPtr, BGUSetLinearColorParameterValueToMesh_MeshInst_Offset), 0, BGUSetLinearColorParameterValueToMesh_MeshInst_PropertyAddress.Address, MeshInst);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUSetLinearColorParameterValueToMesh_ParameterName_Offset), 0, BGUSetLinearColorParameterValueToMesh_ParameterName_PropertyAddress.Address, ParameterName);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(intPtr, BGUSetLinearColorParameterValueToMesh_LinearColorParameterValue_Offset), 0, BGUSetLinearColorParameterValueToMesh_LinearColorParameterValue_PropertyAddress.Address, LinearColorParameterValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetLinearColorParameterValueToMesh_FunctionAddress, intPtr, BGUSetLinearColorParameterValueToMesh_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUSetEnableGravity")]
	public unsafe static void BGUSetEnableGravity(USkeletalMeshComponent TargetMesh, bool bEnableGravity)
	{
		if (!BGUSetEnableGravity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUSetEnableGravity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetEnableGravity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetEnableGravity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, BGUSetEnableGravity_TargetMesh_Offset), 0, BGUSetEnableGravity_TargetMesh_PropertyAddress.Address, TargetMesh);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUSetEnableGravity_bEnableGravity_Offset), 0, BGUSetEnableGravity_bEnableGravity_PropertyAddress.Address, bEnableGravity);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetEnableGravity_FunctionAddress, intPtr, BGUSetEnableGravity_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUSetActiveMontagePosition")]
	public unsafe static bool BGUSetActiveMontagePosition(ABGUCharacter Character, UAnimMontage Montage, float Position)
	{
		if (!BGUSetActiveMontagePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUSetActiveMontagePosition");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSetActiveMontagePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSetActiveMontagePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(intPtr, BGUSetActiveMontagePosition_Character_Offset), 0, BGUSetActiveMontagePosition_Character_PropertyAddress.Address, Character);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUSetActiveMontagePosition_Montage_Offset), 0, BGUSetActiveMontagePosition_Montage_PropertyAddress.Address, Montage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUSetActiveMontagePosition_Position_Offset), 0, BGUSetActiveMontagePosition_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSetActiveMontagePosition_FunctionAddress, intPtr, BGUSetActiveMontagePosition_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUSetActiveMontagePosition_ReturnValue_Offset), 0, BGUSetActiveMontagePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUSeparatingAxisPointCheck")]
	public unsafe static bool BGUSeparatingAxisPointCheck(List<FVector> InPolyVertices, FVector InBoxCenter, FVector InBoxExtent, bool bInCalcLeastPenetration = true)
	{
		if (!BGUSeparatingAxisPointCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUSeparatingAxisPointCheck");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSeparatingAxisPointCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSeparatingAxisPointCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, BGUSeparatingAxisPointCheck_InPolyVertices_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, BGUSeparatingAxisPointCheck_InPolyVertices_Offset), InPolyVertices);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUSeparatingAxisPointCheck_InBoxCenter_Offset), 0, BGUSeparatingAxisPointCheck_InBoxCenter_PropertyAddress.Address, InBoxCenter);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUSeparatingAxisPointCheck_InBoxExtent_Offset), 0, BGUSeparatingAxisPointCheck_InBoxExtent_PropertyAddress.Address, InBoxExtent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUSeparatingAxisPointCheck_bInCalcLeastPenetration_Offset), 0, BGUSeparatingAxisPointCheck_bInCalcLeastPenetration_PropertyAddress.Address, bInCalcLeastPenetration);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSeparatingAxisPointCheck_FunctionAddress, intPtr, BGUSeparatingAxisPointCheck_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUSeparatingAxisPointCheck_InPolyVertices_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUSeparatingAxisPointCheck_ReturnValue_Offset), 0, BGUSeparatingAxisPointCheck_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUSaveUnitAttrToFile")]
	public unsafe static void BGUSaveUnitAttrToFile(string Name, string Text, bool Overwrite)
	{
		if (!BGUSaveUnitAttrToFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUSaveUnitAttrToFile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUSaveUnitAttrToFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUSaveUnitAttrToFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BGUSaveUnitAttrToFile_Name_Offset), 0, BGUSaveUnitAttrToFile_Name_PropertyAddress.Address, Name);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BGUSaveUnitAttrToFile_Text_Offset), 0, BGUSaveUnitAttrToFile_Text_PropertyAddress.Address, Text);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUSaveUnitAttrToFile_Overwrite_Offset), 0, BGUSaveUnitAttrToFile_Overwrite_PropertyAddress.Address, Overwrite);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUSaveUnitAttrToFile_FunctionAddress, intPtr, BGUSaveUnitAttrToFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUSaveUnitAttrToFile_Name_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(BGUSaveUnitAttrToFile_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUResetToDefaultBoomCameraLagSpeed")]
	public unsafe static void BGUResetToDefaultBoomCameraLagSpeed(AActor PlayerCharacter)
	{
		if (!BGUResetToDefaultBoomCameraLagSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUResetToDefaultBoomCameraLagSpeed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUResetToDefaultBoomCameraLagSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUResetToDefaultBoomCameraLagSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUResetToDefaultBoomCameraLagSpeed_PlayerCharacter_Offset), 0, BGUResetToDefaultBoomCameraLagSpeed_PlayerCharacter_PropertyAddress.Address, PlayerCharacter);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUResetToDefaultBoomCameraLagSpeed_FunctionAddress, intPtr, BGUResetToDefaultBoomCameraLagSpeed_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUResetGeometryCollectionComponent")]
	public unsafe static void BGUResetGeometryCollectionComponent(UGeometryCollectionComponent GeometryCollectionComponent)
	{
		if (!BGUResetGeometryCollectionComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUResetGeometryCollectionComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUResetGeometryCollectionComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUResetGeometryCollectionComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UGeometryCollectionComponent>.ToNative(IntPtr.Add(intPtr, BGUResetGeometryCollectionComponent_GeometryCollectionComponent_Offset), 0, BGUResetGeometryCollectionComponent_GeometryCollectionComponent_PropertyAddress.Address, GeometryCollectionComponent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUResetGeometryCollectionComponent_FunctionAddress, intPtr, BGUResetGeometryCollectionComponent_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUResetActorVelocity")]
	public unsafe static void BGUResetActorVelocity(AActor Actor)
	{
		if (!BGUResetActorVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUResetActorVelocity");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUResetActorVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUResetActorVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUResetActorVelocity_Actor_Offset), 0, BGUResetActorVelocity_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUResetActorVelocity_FunctionAddress, intPtr, BGUResetActorVelocity_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGURenameActorComponent")]
	public unsafe static void BGURenameActorComponent(UActorComponent Comp, string NewName)
	{
		if (!BGURenameActorComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGURenameActorComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGURenameActorComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGURenameActorComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, BGURenameActorComponent_Comp_Offset), 0, BGURenameActorComponent_Comp_PropertyAddress.Address, Comp);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BGURenameActorComponent_NewName_Offset), 0, BGURenameActorComponent_NewName_PropertyAddress.Address, NewName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGURenameActorComponent_FunctionAddress, intPtr, BGURenameActorComponent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGURenameActorComponent_NewName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUProjectPointToNavigation")]
	public unsafe static bool BGUProjectPointToNavigation(UObject WorldContextObject, FVector Point, out FVector ProjectedLocation, ANavigationData NavData, TSubclassOf<UNavigationQueryFilter> FilterClass, FVector QueryExtent)
	{
		if (!BGUProjectPointToNavigation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUProjectPointToNavigation");
			ProjectedLocation = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUProjectPointToNavigation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUProjectPointToNavigation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUProjectPointToNavigation_WorldContextObject_Offset), 0, BGUProjectPointToNavigation_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUProjectPointToNavigation_Point_Offset), 0, BGUProjectPointToNavigation_Point_PropertyAddress.Address, Point);
		UObjectMarshaler<ANavigationData>.ToNative(IntPtr.Add(intPtr, BGUProjectPointToNavigation_NavData_Offset), 0, BGUProjectPointToNavigation_NavData_PropertyAddress.Address, NavData);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, BGUProjectPointToNavigation_FilterClass_Offset), 0, BGUProjectPointToNavigation_FilterClass_PropertyAddress.Address, FilterClass);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUProjectPointToNavigation_QueryExtent_Offset), 0, BGUProjectPointToNavigation_QueryExtent_PropertyAddress.Address, QueryExtent);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUProjectPointToNavigation_FunctionAddress, intPtr, BGUProjectPointToNavigation_ParamsSize);
		ProjectedLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUProjectPointToNavigation_ProjectedLocation_Offset), 0, BGUProjectPointToNavigation_ProjectedLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUProjectPointToNavigation_ReturnValue_Offset), 0, BGUProjectPointToNavigation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUProcessLatentActions")]
	public unsafe static void BGUProcessLatentActions(UObject WorldContextObject, UObject InObject, float DeltaTime = -1f)
	{
		if (!BGUProcessLatentActions_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUProcessLatentActions");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUProcessLatentActions_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUProcessLatentActions_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUProcessLatentActions_WorldContextObject_Offset), 0, BGUProcessLatentActions_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUProcessLatentActions_InObject_Offset), 0, BGUProcessLatentActions_InObject_PropertyAddress.Address, InObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUProcessLatentActions_DeltaTime_Offset), 0, BGUProcessLatentActions_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUProcessLatentActions_FunctionAddress, intPtr, BGUProcessLatentActions_ParamsSize);
	}

	[UFunction(Flags = 348267521u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUPlayerCtrlerGetViewPoint")]
	public unsafe static void BGUPlayerCtrlerGetViewPoint(APlayerController PlayerCtrler, out FVector out_Location, out FRotator out_Rotation)
	{
		if (!BGUPlayerCtrlerGetViewPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUPlayerCtrlerGetViewPoint");
			out_Location = default(FVector);
			out_Rotation = default(FRotator);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUPlayerCtrlerGetViewPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUPlayerCtrlerGetViewPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<APlayerController>.ToNative(IntPtr.Add(intPtr, BGUPlayerCtrlerGetViewPoint_PlayerCtrler_Offset), 0, BGUPlayerCtrlerGetViewPoint_PlayerCtrler_PropertyAddress.Address, PlayerCtrler);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUPlayerCtrlerGetViewPoint_FunctionAddress, intPtr, BGUPlayerCtrlerGetViewPoint_ParamsSize);
		out_Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUPlayerCtrlerGetViewPoint_out_Location_Offset), 0, BGUPlayerCtrlerGetViewPoint_out_Location_PropertyAddress.Address);
		out_Rotation = BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(intPtr, BGUPlayerCtrlerGetViewPoint_out_Rotation_Offset), 0, BGUPlayerCtrlerGetViewPoint_out_Rotation_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUPerlinNoise1D")]
	public unsafe static float BGUPerlinNoise1D(float Value)
	{
		if (!BGUPerlinNoise1D_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUPerlinNoise1D");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUPerlinNoise1D_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUPerlinNoise1D_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUPerlinNoise1D_Value_Offset), 0, BGUPerlinNoise1D_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUPerlinNoise1D_FunctionAddress, intPtr, BGUPerlinNoise1D_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUPerlinNoise1D_ReturnValue_Offset), 0, BGUPerlinNoise1D_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUNavigationRaycast")]
	public unsafe static bool BGUNavigationRaycast(UObject WorldContextObject, FVector RayStart, FVector RayEnd, out FVector HitLocation, TSubclassOf<UNavigationQueryFilter> FilterClass, AController Querier)
	{
		if (!BGUNavigationRaycast_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUNavigationRaycast");
			HitLocation = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUNavigationRaycast_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUNavigationRaycast_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUNavigationRaycast_WorldContextObject_Offset), 0, BGUNavigationRaycast_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUNavigationRaycast_RayStart_Offset), 0, BGUNavigationRaycast_RayStart_PropertyAddress.Address, RayStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUNavigationRaycast_RayEnd_Offset), 0, BGUNavigationRaycast_RayEnd_PropertyAddress.Address, RayEnd);
		TSubclassOfMarshaler<UNavigationQueryFilter>.ToNative(IntPtr.Add(intPtr, BGUNavigationRaycast_FilterClass_Offset), 0, BGUNavigationRaycast_FilterClass_PropertyAddress.Address, FilterClass);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, BGUNavigationRaycast_Querier_Offset), 0, BGUNavigationRaycast_Querier_PropertyAddress.Address, Querier);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUNavigationRaycast_FunctionAddress, intPtr, BGUNavigationRaycast_ParamsSize);
		HitLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUNavigationRaycast_HitLocation_Offset), 0, BGUNavigationRaycast_HitLocation_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUNavigationRaycast_ReturnValue_Offset), 0, BGUNavigationRaycast_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUNavigationCalPathCost")]
	public unsafe static void BGUNavigationCalPathCost(UObject WorldContextObject, FVector PathStart, FVector PathEnd, out float PathCost, AController Querier)
	{
		if (!BGUNavigationCalPathCost_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUNavigationCalPathCost");
			PathCost = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUNavigationCalPathCost_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUNavigationCalPathCost_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUNavigationCalPathCost_WorldContextObject_Offset), 0, BGUNavigationCalPathCost_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUNavigationCalPathCost_PathStart_Offset), 0, BGUNavigationCalPathCost_PathStart_PropertyAddress.Address, PathStart);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, BGUNavigationCalPathCost_PathEnd_Offset), 0, BGUNavigationCalPathCost_PathEnd_PropertyAddress.Address, PathEnd);
		UObjectMarshaler<AController>.ToNative(IntPtr.Add(intPtr, BGUNavigationCalPathCost_Querier_Offset), 0, BGUNavigationCalPathCost_Querier_PropertyAddress.Address, Querier);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUNavigationCalPathCost_FunctionAddress, intPtr, BGUNavigationCalPathCost_ParamsSize);
		PathCost = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUNavigationCalPathCost_PathCost_Offset), 0, BGUNavigationCalPathCost_PathCost_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUMergeSkeletalMesh")]
	public unsafe static bool BGUMergeSkeletalMesh(USkeletalMesh InMergeMesh, List<USkeletalMesh> InSrcMeshList, int StripTopLODs, EMeshBufferAccess MeshBufferAccess = EMeshBufferAccess.Default)
	{
		if (!BGUMergeSkeletalMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUMergeSkeletalMesh");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUMergeSkeletalMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUMergeSkeletalMesh_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMesh>.ToNative(IntPtr.Add(intPtr, BGUMergeSkeletalMesh_InMergeMesh_Offset), 0, BGUMergeSkeletalMesh_InMergeMesh_PropertyAddress.Address, InMergeMesh);
		new TArrayCopyMarshaler<USkeletalMesh>(1, BGUMergeSkeletalMesh_InSrcMeshList_PropertyAddress, CachedMarshalingDelegates<USkeletalMesh, UObjectMarshaler<USkeletalMesh>>.FromNative, CachedMarshalingDelegates<USkeletalMesh, UObjectMarshaler<USkeletalMesh>>.ToNative).ToNative(IntPtr.Add(intPtr, BGUMergeSkeletalMesh_InSrcMeshList_Offset), InSrcMeshList);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUMergeSkeletalMesh_StripTopLODs_Offset), 0, BGUMergeSkeletalMesh_StripTopLODs_PropertyAddress.Address, StripTopLODs);
		EnumMarshaler<EMeshBufferAccess>.ToNative(IntPtr.Add(intPtr, BGUMergeSkeletalMesh_MeshBufferAccess_Offset), 0, BGUMergeSkeletalMesh_MeshBufferAccess_PropertyAddress.Address, MeshBufferAccess);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUMergeSkeletalMesh_FunctionAddress, intPtr, BGUMergeSkeletalMesh_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUMergeSkeletalMesh_InSrcMeshList_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUMergeSkeletalMesh_ReturnValue_Offset), 0, BGUMergeSkeletalMesh_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGULoadStreamLevel")]
	public unsafe static void BGULoadStreamLevel(UObject WorldContextObject, FName LevelName, bool bMakeVisibleAfterLoad, bool bShouldBlockOnLoad, UObject CallbackTarget, FName CallbackFunc, int ActionID = 0, int Linkage = 0)
	{
		if (!BGULoadStreamLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGULoadStreamLevel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGULoadStreamLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGULoadStreamLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGULoadStreamLevel_WorldContextObject_Offset), 0, BGULoadStreamLevel_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGULoadStreamLevel_LevelName_Offset), 0, BGULoadStreamLevel_LevelName_PropertyAddress.Address, LevelName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGULoadStreamLevel_bMakeVisibleAfterLoad_Offset), 0, BGULoadStreamLevel_bMakeVisibleAfterLoad_PropertyAddress.Address, bMakeVisibleAfterLoad);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGULoadStreamLevel_bShouldBlockOnLoad_Offset), 0, BGULoadStreamLevel_bShouldBlockOnLoad_PropertyAddress.Address, bShouldBlockOnLoad);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGULoadStreamLevel_CallbackTarget_Offset), 0, BGULoadStreamLevel_CallbackTarget_PropertyAddress.Address, CallbackTarget);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGULoadStreamLevel_CallbackFunc_Offset), 0, BGULoadStreamLevel_CallbackFunc_PropertyAddress.Address, CallbackFunc);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGULoadStreamLevel_ActionID_Offset), 0, BGULoadStreamLevel_ActionID_PropertyAddress.Address, ActionID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGULoadStreamLevel_Linkage_Offset), 0, BGULoadStreamLevel_Linkage_PropertyAddress.Address, Linkage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGULoadStreamLevel_FunctionAddress, intPtr, BGULoadStreamLevel_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUIsExistFile")]
	public unsafe static bool BGUIsExistFile(string path)
	{
		if (!BGUIsExistFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUIsExistFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUIsExistFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUIsExistFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BGUIsExistFile_path_Offset), 0, BGUIsExistFile_path_PropertyAddress.Address, path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUIsExistFile_FunctionAddress, intPtr, BGUIsExistFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(BGUIsExistFile_path_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUIsExistFile_ReturnValue_Offset), 0, BGUIsExistFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUHasFuncName")]
	public unsafe static bool BGUHasFuncName(FName FuncName, UObject Object, TSubclassOf<UObject> StopAtClass)
	{
		if (!BGUHasFuncName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUHasFuncName");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUHasFuncName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUHasFuncName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUHasFuncName_FuncName_Offset), 0, BGUHasFuncName_FuncName_PropertyAddress.Address, FuncName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUHasFuncName_Object_Offset), 0, BGUHasFuncName_Object_PropertyAddress.Address, Object);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUHasFuncName_StopAtClass_Offset), 0, BGUHasFuncName_StopAtClass_PropertyAddress.Address, StopAtClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUHasFuncName_FunctionAddress, intPtr, BGUHasFuncName_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUHasFuncName_ReturnValue_Offset), 0, BGUHasFuncName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGetWindParameters_GameThread")]
	public unsafe static void BGUGetWindParameters_GameThread(AActor WorldContext, out FVector Position, out FVector OutDirection, out float OutSpeed, out float OutMinGustAmt, out float OutMaxGustAmt)
	{
		if (!BGUGetWindParameters_GameThread_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGetWindParameters_GameThread");
			Position = default(FVector);
			OutDirection = default(FVector);
			OutSpeed = 0f;
			OutMinGustAmt = 0f;
			OutMaxGustAmt = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetWindParameters_GameThread_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetWindParameters_GameThread_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetWindParameters_GameThread_WorldContext_Offset), 0, BGUGetWindParameters_GameThread_WorldContext_PropertyAddress.Address, WorldContext);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetWindParameters_GameThread_FunctionAddress, intPtr, BGUGetWindParameters_GameThread_ParamsSize);
		Position = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUGetWindParameters_GameThread_Position_Offset), 0, BGUGetWindParameters_GameThread_Position_PropertyAddress.Address);
		OutDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUGetWindParameters_GameThread_OutDirection_Offset), 0, BGUGetWindParameters_GameThread_OutDirection_PropertyAddress.Address);
		OutSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetWindParameters_GameThread_OutSpeed_Offset), 0, BGUGetWindParameters_GameThread_OutSpeed_PropertyAddress.Address);
		OutMinGustAmt = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetWindParameters_GameThread_OutMinGustAmt_Offset), 0, BGUGetWindParameters_GameThread_OutMinGustAmt_PropertyAddress.Address);
		OutMaxGustAmt = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetWindParameters_GameThread_OutMaxGustAmt_Offset), 0, BGUGetWindParameters_GameThread_OutMaxGustAmt_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGetTeamID")]
	public unsafe static int BGUGetTeamID(AActor Unit)
	{
		if (!BGUGetTeamID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGetTeamID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetTeamID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetTeamID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetTeamID_Unit_Offset), 0, BGUGetTeamID_Unit_PropertyAddress.Address, Unit);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetTeamID_FunctionAddress, intPtr, BGUGetTeamID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetTeamID_ReturnValue_Offset), 0, BGUGetTeamID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGetSkeletalMeshSimulatedBodiesBelowNum")]
	public unsafe static int BGUGetSkeletalMeshSimulatedBodiesBelowNum(USkeletalMeshComponent SkeletalMesh, FName BoneName, bool bIncludeSelf)
	{
		if (!BGUGetSkeletalMeshSimulatedBodiesBelowNum_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGetSkeletalMeshSimulatedBodiesBelowNum");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetSkeletalMeshSimulatedBodiesBelowNum_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetSkeletalMeshSimulatedBodiesBelowNum_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(intPtr, BGUGetSkeletalMeshSimulatedBodiesBelowNum_SkeletalMesh_Offset), 0, BGUGetSkeletalMeshSimulatedBodiesBelowNum_SkeletalMesh_PropertyAddress.Address, SkeletalMesh);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGetSkeletalMeshSimulatedBodiesBelowNum_BoneName_Offset), 0, BGUGetSkeletalMeshSimulatedBodiesBelowNum_BoneName_PropertyAddress.Address, BoneName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGUGetSkeletalMeshSimulatedBodiesBelowNum_bIncludeSelf_Offset), 0, BGUGetSkeletalMeshSimulatedBodiesBelowNum_bIncludeSelf_PropertyAddress.Address, bIncludeSelf);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, intPtr, BGUGetSkeletalMeshSimulatedBodiesBelowNum_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, BGUGetSkeletalMeshSimulatedBodiesBelowNum_ReturnValue_Offset), 0, BGUGetSkeletalMeshSimulatedBodiesBelowNum_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionTimeLeftFromPos")]
	public unsafe static float BGUGetMontageSectionTimeLeftFromPos(AActor Unit, UAnimMontage AnimMontage, float Position)
	{
		if (!BGUGetMontageSectionTimeLeftFromPos_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionTimeLeftFromPos");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetMontageSectionTimeLeftFromPos_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetMontageSectionTimeLeftFromPos_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionTimeLeftFromPos_Unit_Offset), 0, BGUGetMontageSectionTimeLeftFromPos_Unit_PropertyAddress.Address, Unit);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionTimeLeftFromPos_AnimMontage_Offset), 0, BGUGetMontageSectionTimeLeftFromPos_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionTimeLeftFromPos_Position_Offset), 0, BGUGetMontageSectionTimeLeftFromPos_Position_PropertyAddress.Address, Position);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, intPtr, BGUGetMontageSectionTimeLeftFromPos_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetMontageSectionTimeLeftFromPos_ReturnValue_Offset), 0, BGUGetMontageSectionTimeLeftFromPos_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionStartAndEndTime")]
	public unsafe static bool BGUGetMontageSectionStartAndEndTime(UAnimMontage AnimMontage, FName SectionName, out float OutStartTime, out float OutEndTime)
	{
		if (!BGUGetMontageSectionStartAndEndTime_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionStartAndEndTime");
			OutStartTime = 0f;
			OutEndTime = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetMontageSectionStartAndEndTime_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetMontageSectionStartAndEndTime_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionStartAndEndTime_AnimMontage_Offset), 0, BGUGetMontageSectionStartAndEndTime_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionStartAndEndTime_SectionName_Offset), 0, BGUGetMontageSectionStartAndEndTime_SectionName_PropertyAddress.Address, SectionName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetMontageSectionStartAndEndTime_FunctionAddress, intPtr, BGUGetMontageSectionStartAndEndTime_ParamsSize);
		OutStartTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetMontageSectionStartAndEndTime_OutStartTime_Offset), 0, BGUGetMontageSectionStartAndEndTime_OutStartTime_PropertyAddress.Address);
		OutEndTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetMontageSectionStartAndEndTime_OutEndTime_Offset), 0, BGUGetMontageSectionStartAndEndTime_OutEndTime_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetMontageSectionStartAndEndTime_ReturnValue_Offset), 0, BGUGetMontageSectionStartAndEndTime_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionLengthByName")]
	public unsafe static float BGUGetMontageSectionLengthByName(AActor Unit, UAnimMontage AnimMontage, FName SectionName)
	{
		if (!BGUGetMontageSectionLengthByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionLengthByName");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetMontageSectionLengthByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetMontageSectionLengthByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionLengthByName_Unit_Offset), 0, BGUGetMontageSectionLengthByName_Unit_PropertyAddress.Address, Unit);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionLengthByName_AnimMontage_Offset), 0, BGUGetMontageSectionLengthByName_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionLengthByName_SectionName_Offset), 0, BGUGetMontageSectionLengthByName_SectionName_PropertyAddress.Address, SectionName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetMontageSectionLengthByName_FunctionAddress, intPtr, BGUGetMontageSectionLengthByName_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetMontageSectionLengthByName_ReturnValue_Offset), 0, BGUGetMontageSectionLengthByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionLengthByIndex")]
	public unsafe static float BGUGetMontageSectionLengthByIndex(AActor Unit, UAnimMontage AnimMontage, int index)
	{
		if (!BGUGetMontageSectionLengthByIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionLengthByIndex");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetMontageSectionLengthByIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetMontageSectionLengthByIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionLengthByIndex_Unit_Offset), 0, BGUGetMontageSectionLengthByIndex_Unit_PropertyAddress.Address, Unit);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionLengthByIndex_AnimMontage_Offset), 0, BGUGetMontageSectionLengthByIndex_AnimMontage_PropertyAddress.Address, AnimMontage);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUGetMontageSectionLengthByIndex_index_Offset), 0, BGUGetMontageSectionLengthByIndex_index_PropertyAddress.Address, index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetMontageSectionLengthByIndex_FunctionAddress, intPtr, BGUGetMontageSectionLengthByIndex_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetMontageSectionLengthByIndex_ReturnValue_Offset), 0, BGUGetMontageSectionLengthByIndex_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGetHitResultActor")]
	public unsafe static AActor BGUGetHitResultActor(FActorInstanceHandle ActorInstanceHandle)
	{
		if (!BGUGetHitResultActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGetHitResultActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetHitResultActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetHitResultActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(BGUGetHitResultActor_ActorInstanceHandle_PropertyAddress.Address, intPtr);
		FActorInstanceHandle.ToNative(IntPtr.Add(intPtr, BGUGetHitResultActor_ActorInstanceHandle_Offset), 0, BGUGetHitResultActor_ActorInstanceHandle_PropertyAddress.Address, ActorInstanceHandle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetHitResultActor_FunctionAddress, intPtr, BGUGetHitResultActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, BGUGetHitResultActor_ReturnValue_Offset), 0, BGUGetHitResultActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGetAllActorsWithTagInRangeSorted")]
	public unsafe static bool BGUGetAllActorsWithTagInRangeSorted(AActor CenterActor, FName TagName, int Range, out List<AActor> OutActors)
	{
		if (!BGUGetAllActorsWithTagInRangeSorted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGetAllActorsWithTagInRangeSorted");
			OutActors = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetAllActorsWithTagInRangeSorted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetAllActorsWithTagInRangeSorted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGetAllActorsWithTagInRangeSorted_CenterActor_Offset), 0, BGUGetAllActorsWithTagInRangeSorted_CenterActor_PropertyAddress.Address, CenterActor);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGetAllActorsWithTagInRangeSorted_TagName_Offset), 0, BGUGetAllActorsWithTagInRangeSorted_TagName_PropertyAddress.Address, TagName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUGetAllActorsWithTagInRangeSorted_Range_Offset), 0, BGUGetAllActorsWithTagInRangeSorted_Range_PropertyAddress.Address, Range);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, intPtr, BGUGetAllActorsWithTagInRangeSorted_ParamsSize);
		OutActors = new TArrayCopyMarshaler<AActor>(1, BGUGetAllActorsWithTagInRangeSorted_OutActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).FromNative(IntPtr.Add(intPtr, BGUGetAllActorsWithTagInRangeSorted_OutActors_Offset));
		NativeReflection.DestroyValue_InContainer(BGUGetAllActorsWithTagInRangeSorted_OutActors_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGUGetAllActorsWithTagInRangeSorted_ReturnValue_Offset), 0, BGUGetAllActorsWithTagInRangeSorted_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGetActiveMontagePosition")]
	public unsafe static float BGUGetActiveMontagePosition(ABGUCharacter Actor, UAnimMontage Montage)
	{
		if (!BGUGetActiveMontagePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGetActiveMontagePosition");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGetActiveMontagePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGetActiveMontagePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(intPtr, BGUGetActiveMontagePosition_Actor_Offset), 0, BGUGetActiveMontagePosition_Actor_PropertyAddress.Address, Actor);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUGetActiveMontagePosition_Montage_Offset), 0, BGUGetActiveMontagePosition_Montage_PropertyAddress.Address, Montage);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGetActiveMontagePosition_FunctionAddress, intPtr, BGUGetActiveMontagePosition_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUGetActiveMontagePosition_ReturnValue_Offset), 0, BGUGetActiveMontagePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGenProceduralLevel")]
	public unsafe static ULevelStreaming BGUGenProceduralLevel(UObject WorldContextObject, FName WorldAssetName, FName InLevelName, FTransform InLevelTransform)
	{
		if (!BGUGenProceduralLevel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGenProceduralLevel");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGenProceduralLevel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGenProceduralLevel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUGenProceduralLevel_WorldContextObject_Offset), 0, BGUGenProceduralLevel_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGenProceduralLevel_WorldAssetName_Offset), 0, BGUGenProceduralLevel_WorldAssetName_PropertyAddress.Address, WorldAssetName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUGenProceduralLevel_InLevelName_Offset), 0, BGUGenProceduralLevel_InLevelName_PropertyAddress.Address, InLevelName);
		NativeReflection.InitializeValue_InContainer(BGUGenProceduralLevel_InLevelTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, BGUGenProceduralLevel_InLevelTransform_Offset), 0, BGUGenProceduralLevel_InLevelTransform_PropertyAddress.Address, InLevelTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGenProceduralLevel_FunctionAddress, intPtr, BGUGenProceduralLevel_ParamsSize);
		return UObjectMarshaler<ULevelStreaming>.FromNative(IntPtr.Add(intPtr, BGUGenProceduralLevel_ReturnValue_Offset), 0, BGUGenProceduralLevel_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGenComponentAndAdd")]
	public unsafe static UActorComponent BGUGenComponentAndAdd(AActor Actor, TSubclassOf<UActorComponent> ActorComponentClass)
	{
		if (!BGUGenComponentAndAdd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGenComponentAndAdd");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGenComponentAndAdd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGenComponentAndAdd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGenComponentAndAdd_Actor_Offset), 0, BGUGenComponentAndAdd_Actor_PropertyAddress.Address, Actor);
		TSubclassOfMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, BGUGenComponentAndAdd_ActorComponentClass_Offset), 0, BGUGenComponentAndAdd_ActorComponentClass_PropertyAddress.Address, ActorComponentClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGenComponentAndAdd_FunctionAddress, intPtr, BGUGenComponentAndAdd_ParamsSize);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, BGUGenComponentAndAdd_ReturnValue_Offset), 0, BGUGenComponentAndAdd_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUGenComponent")]
	public unsafe static UActorComponent BGUGenComponent(AActor Actor, TSubclassOf<UActorComponent> ActorComponentClass)
	{
		if (!BGUGenComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUGenComponent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUGenComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUGenComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUGenComponent_Actor_Offset), 0, BGUGenComponent_Actor_PropertyAddress.Address, Actor);
		TSubclassOfMarshaler<UActorComponent>.ToNative(IntPtr.Add(intPtr, BGUGenComponent_ActorComponentClass_Offset), 0, BGUGenComponent_ActorComponentClass_PropertyAddress.Address, ActorComponentClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUGenComponent_FunctionAddress, intPtr, BGUGenComponent_ParamsSize);
		return UObjectMarshaler<UActorComponent>.FromNative(IntPtr.Add(intPtr, BGUGenComponent_ReturnValue_Offset), 0, BGUGenComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUFlushLevelStreamingOnlyVisibility")]
	public unsafe static void BGUFlushLevelStreamingOnlyVisibility(UObject WorldContextObject)
	{
		if (!BGUFlushLevelStreamingOnlyVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUFlushLevelStreamingOnlyVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUFlushLevelStreamingOnlyVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUFlushLevelStreamingOnlyVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUFlushLevelStreamingOnlyVisibility_WorldContextObject_Offset), 0, BGUFlushLevelStreamingOnlyVisibility_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUFlushLevelStreamingOnlyVisibility_FunctionAddress, intPtr, BGUFlushLevelStreamingOnlyVisibility_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUFinishSpawningActor")]
	public unsafe static AActor BGUFinishSpawningActor(AActor Actor, FTransform SpawnTransform)
	{
		if (!BGUFinishSpawningActor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUFinishSpawningActor");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUFinishSpawningActor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUFinishSpawningActor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUFinishSpawningActor_Actor_Offset), 0, BGUFinishSpawningActor_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InitializeValue_InContainer(BGUFinishSpawningActor_SpawnTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, BGUFinishSpawningActor_SpawnTransform_Offset), 0, BGUFinishSpawningActor_SpawnTransform_PropertyAddress.Address, SpawnTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUFinishSpawningActor_FunctionAddress, intPtr, BGUFinishSpawningActor_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, BGUFinishSpawningActor_ReturnValue_Offset), 0, BGUFinishSpawningActor_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUFindFirstActorWithTag")]
	public unsafe static AActor BGUFindFirstActorWithTag(UObject WorldContextObject, FName TagName)
	{
		if (!BGUFindFirstActorWithTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUFindFirstActorWithTag");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUFindFirstActorWithTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUFindFirstActorWithTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUFindFirstActorWithTag_WorldContextObject_Offset), 0, BGUFindFirstActorWithTag_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUFindFirstActorWithTag_TagName_Offset), 0, BGUFindFirstActorWithTag_TagName_PropertyAddress.Address, TagName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUFindFirstActorWithTag_FunctionAddress, intPtr, BGUFindFirstActorWithTag_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, BGUFindFirstActorWithTag_ReturnValue_Offset), 0, BGUFindFirstActorWithTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUCalcBounds")]
	public unsafe static void BGUCalcBounds(UPrimitiveComponent StaticMesh, out FVector Origin, out FVector BoxExtent, out float SphereRadius)
	{
		if (!BGUCalcBounds_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUCalcBounds");
			Origin = default(FVector);
			BoxExtent = default(FVector);
			SphereRadius = 0f;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUCalcBounds_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUCalcBounds_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, BGUCalcBounds_StaticMesh_Offset), 0, BGUCalcBounds_StaticMesh_PropertyAddress.Address, StaticMesh);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUCalcBounds_FunctionAddress, intPtr, BGUCalcBounds_ParamsSize);
		Origin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUCalcBounds_Origin_Offset), 0, BGUCalcBounds_Origin_PropertyAddress.Address);
		BoxExtent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGUCalcBounds_BoxExtent_Offset), 0, BGUCalcBounds_BoxExtent_PropertyAddress.Address);
		SphereRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, BGUCalcBounds_SphereRadius_Offset), 0, BGUCalcBounds_SphereRadius_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUBeginDeferredActorSpawnFromClassWithName")]
	public unsafe static AActor BGUBeginDeferredActorSpawnFromClassWithName(UObject WorldContextObject, TSubclassOf<AActor> ActorClass, FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, AActor Owner, FName ActorName, ULevel OverrideLevel)
	{
		if (!BGUBeginDeferredActorSpawnFromClassWithName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUBeginDeferredActorSpawnFromClassWithName");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBeginDeferredActorSpawnFromClassWithName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBeginDeferredActorSpawnFromClassWithName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClassWithName_WorldContextObject_Offset), 0, BGUBeginDeferredActorSpawnFromClassWithName_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClassWithName_ActorClass_Offset), 0, BGUBeginDeferredActorSpawnFromClassWithName_ActorClass_PropertyAddress.Address, ActorClass);
		NativeReflection.InitializeValue_InContainer(BGUBeginDeferredActorSpawnFromClassWithName_SpawnTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClassWithName_SpawnTransform_Offset), 0, BGUBeginDeferredActorSpawnFromClassWithName_SpawnTransform_PropertyAddress.Address, SpawnTransform);
		EnumMarshaler<ESpawnActorCollisionHandlingMethod>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClassWithName_CollisionHandlingOverride_Offset), 0, BGUBeginDeferredActorSpawnFromClassWithName_CollisionHandlingOverride_PropertyAddress.Address, CollisionHandlingOverride);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClassWithName_Owner_Offset), 0, BGUBeginDeferredActorSpawnFromClassWithName_Owner_PropertyAddress.Address, Owner);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClassWithName_ActorName_Offset), 0, BGUBeginDeferredActorSpawnFromClassWithName_ActorName_PropertyAddress.Address, ActorName);
		UObjectMarshaler<ULevel>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClassWithName_OverrideLevel_Offset), 0, BGUBeginDeferredActorSpawnFromClassWithName_OverrideLevel_PropertyAddress.Address, OverrideLevel);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, intPtr, BGUBeginDeferredActorSpawnFromClassWithName_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClassWithName_ReturnValue_Offset), 0, BGUBeginDeferredActorSpawnFromClassWithName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUBeginDeferredActorSpawnFromClass")]
	public unsafe static AActor BGUBeginDeferredActorSpawnFromClass(UObject WorldContextObject, TSubclassOf<AActor> ActorClass, FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod CollisionHandlingOverride, AActor Owner)
	{
		if (!BGUBeginDeferredActorSpawnFromClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUBeginDeferredActorSpawnFromClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUBeginDeferredActorSpawnFromClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUBeginDeferredActorSpawnFromClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClass_WorldContextObject_Offset), 0, BGUBeginDeferredActorSpawnFromClass_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		TSubclassOfMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClass_ActorClass_Offset), 0, BGUBeginDeferredActorSpawnFromClass_ActorClass_PropertyAddress.Address, ActorClass);
		NativeReflection.InitializeValue_InContainer(BGUBeginDeferredActorSpawnFromClass_SpawnTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClass_SpawnTransform_Offset), 0, BGUBeginDeferredActorSpawnFromClass_SpawnTransform_PropertyAddress.Address, SpawnTransform);
		EnumMarshaler<ESpawnActorCollisionHandlingMethod>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClass_CollisionHandlingOverride_Offset), 0, BGUBeginDeferredActorSpawnFromClass_CollisionHandlingOverride_PropertyAddress.Address, CollisionHandlingOverride);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClass_Owner_Offset), 0, BGUBeginDeferredActorSpawnFromClass_Owner_PropertyAddress.Address, Owner);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUBeginDeferredActorSpawnFromClass_FunctionAddress, intPtr, BGUBeginDeferredActorSpawnFromClass_ParamsSize);
		return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(intPtr, BGUBeginDeferredActorSpawnFromClass_ReturnValue_Offset), 0, BGUBeginDeferredActorSpawnFromClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:BGUActorUpdateAllTFXComp")]
	public unsafe static void BGUActorUpdateAllTFXComp(AActor Actor)
	{
		if (!BGUActorUpdateAllTFXComp_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:BGUActorUpdateAllTFXComp");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGUActorUpdateAllTFXComp_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUActorUpdateAllTFXComp_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, BGUActorUpdateAllTFXComp_Actor_Offset), 0, BGUActorUpdateAllTFXComp_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, BGUActorUpdateAllTFXComp_FunctionAddress, intPtr, BGUActorUpdateAllTFXComp_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:ApplyLevelTransform")]
	public unsafe static void ApplyLevelTransform(UObject WorldContextObject, FName LevelName, FTransform LevelTransform)
	{
		if (!ApplyLevelTransform_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:ApplyLevelTransform");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyLevelTransform_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyLevelTransform_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ApplyLevelTransform_WorldContextObject_Offset), 0, ApplyLevelTransform_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ApplyLevelTransform_LevelName_Offset), 0, ApplyLevelTransform_LevelName_PropertyAddress.Address, LevelName);
		NativeReflection.InitializeValue_InContainer(ApplyLevelTransform_LevelTransform_PropertyAddress.Address, intPtr);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(intPtr, ApplyLevelTransform_LevelTransform_Offset), 0, ApplyLevelTransform_LevelTransform_PropertyAddress.Address, LevelTransform);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ApplyLevelTransform_FunctionAddress, intPtr, ApplyLevelTransform_ParamsSize);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:AddLevelStreaming")]
	public unsafe static FName AddLevelStreaming(UObject WorldContextObject, FName LevelName, FVector Location, FRotator Rotation, bool bShouldBlockOnLoad = false)
	{
		if (!AddLevelStreaming_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:AddLevelStreaming");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddLevelStreaming_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddLevelStreaming_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddLevelStreaming_WorldContextObject_Offset), 0, AddLevelStreaming_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, AddLevelStreaming_LevelName_Offset), 0, AddLevelStreaming_LevelName_PropertyAddress.Address, LevelName);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, AddLevelStreaming_Location_Offset), 0, AddLevelStreaming_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, AddLevelStreaming_Rotation_Offset), 0, AddLevelStreaming_Rotation_PropertyAddress.Address, Rotation);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddLevelStreaming_bShouldBlockOnLoad_Offset), 0, AddLevelStreaming_bShouldBlockOnLoad_PropertyAddress.Address, bShouldBlockOnLoad);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddLevelStreaming_FunctionAddress, intPtr, AddLevelStreaming_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, AddLevelStreaming_ReturnValue_Offset), 0, AddLevelStreaming_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:AddBuffNotifyStates")]
	public unsafe static void AddBuffNotifyStates(UAnimMontage MontageObj, UObject NewNotifyStateClass, int BuffID, Dictionary<float, float> NotifyStateInfos)
	{
		if (!AddBuffNotifyStates_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:AddBuffNotifyStates");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBuffNotifyStates_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBuffNotifyStates_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, AddBuffNotifyStates_MontageObj_Offset), 0, AddBuffNotifyStates_MontageObj_PropertyAddress.Address, MontageObj);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, AddBuffNotifyStates_NewNotifyStateClass_Offset), 0, AddBuffNotifyStates_NewNotifyStateClass_PropertyAddress.Address, NewNotifyStateClass);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddBuffNotifyStates_BuffID_Offset), 0, AddBuffNotifyStates_BuffID_PropertyAddress.Address, BuffID);
		NativeReflection.InitializeValue_InContainer(AddBuffNotifyStates_NotifyStateInfos_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<float, float>(1, AddBuffNotifyStates_NotifyStateInfos_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, AddBuffNotifyStates_NotifyStateInfos_Offset), NotifyStateInfos);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddBuffNotifyStates_FunctionAddress, intPtr, AddBuffNotifyStates_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddBuffNotifyStates_NotifyStateInfos_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 604120065u)]
	[UMetaPath("/Script/b1.BGUFunctionLibrary:AddAllAnimNotifyStatesAccordingToReference")]
	public unsafe static void AddAllAnimNotifyStatesAccordingToReference(string ResourcePath, TSubclassOf<UAnimNotifyState> RefNotifyStateClass, TSubclassOf<UAnimNotifyState> NewNotifyStateClass)
	{
		if (!AddAllAnimNotifyStatesAccordingToReference_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUFunctionLibrary:AddAllAnimNotifyStatesAccordingToReference");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAllAnimNotifyStatesAccordingToReference_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAllAnimNotifyStatesAccordingToReference_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddAllAnimNotifyStatesAccordingToReference_ResourcePath_Offset), 0, AddAllAnimNotifyStatesAccordingToReference_ResourcePath_PropertyAddress.Address, ResourcePath);
		TSubclassOfMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, AddAllAnimNotifyStatesAccordingToReference_RefNotifyStateClass_Offset), 0, AddAllAnimNotifyStatesAccordingToReference_RefNotifyStateClass_PropertyAddress.Address, RefNotifyStateClass);
		TSubclassOfMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(intPtr, AddAllAnimNotifyStatesAccordingToReference_NewNotifyStateClass_Offset), 0, AddAllAnimNotifyStatesAccordingToReference_NewNotifyStateClass_PropertyAddress.Address, NewNotifyStateClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAllAnimNotifyStatesAccordingToReference_FunctionAddress, intPtr, AddAllAnimNotifyStatesAccordingToReference_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddAllAnimNotifyStatesAccordingToReference_ResourcePath_PropertyAddress.Address, intPtr);
	}

	static UBGUFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGUFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGUFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.BGUFunctionLibrary");
		WrapHitResult_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "WrapHitResult");
		WrapHitResult_ParamsSize = NativeReflection.GetFunctionParamsSize(WrapHitResult_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WrapHitResult_HitResult_PropertyAddress, WrapHitResult_FunctionAddress, "HitResult");
		WrapHitResult_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(WrapHitResult_FunctionAddress, "HitResult");
		WrapHitResult_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(WrapHitResult_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref WrapHitResult_ReturnValue_PropertyAddress, WrapHitResult_FunctionAddress, "ReturnValue");
		WrapHitResult_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WrapHitResult_FunctionAddress, "ReturnValue");
		WrapHitResult_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WrapHitResult_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		WrapHitResult_IsValid = WrapHitResult_FunctionAddress != IntPtr.Zero && WrapHitResult_HitResult_IsValid && WrapHitResult_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:WrapHitResult", WrapHitResult_IsValid);
		VolumeEncompassPoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "VolumeEncompassPoint");
		VolumeEncompassPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(VolumeEncompassPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VolumeEncompassPoint_Volume_PropertyAddress, VolumeEncompassPoint_FunctionAddress, "Volume");
		VolumeEncompassPoint_Volume_Offset = NativeReflectionCached.GetPropertyOffset(VolumeEncompassPoint_FunctionAddress, "Volume");
		VolumeEncompassPoint_Volume_IsValid = NativeReflectionCached.ValidatePropertyClass(VolumeEncompassPoint_FunctionAddress, "Volume", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref VolumeEncompassPoint_Point_PropertyAddress, VolumeEncompassPoint_FunctionAddress, "Point");
		VolumeEncompassPoint_Point_Offset = NativeReflectionCached.GetPropertyOffset(VolumeEncompassPoint_FunctionAddress, "Point");
		VolumeEncompassPoint_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(VolumeEncompassPoint_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VolumeEncompassPoint_SphereRadius_PropertyAddress, VolumeEncompassPoint_FunctionAddress, "SphereRadius");
		VolumeEncompassPoint_SphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(VolumeEncompassPoint_FunctionAddress, "SphereRadius");
		VolumeEncompassPoint_SphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(VolumeEncompassPoint_FunctionAddress, "SphereRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VolumeEncompassPoint_OutDistanceToPoint_PropertyAddress, VolumeEncompassPoint_FunctionAddress, "OutDistanceToPoint");
		VolumeEncompassPoint_OutDistanceToPoint_Offset = NativeReflectionCached.GetPropertyOffset(VolumeEncompassPoint_FunctionAddress, "OutDistanceToPoint");
		VolumeEncompassPoint_OutDistanceToPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(VolumeEncompassPoint_FunctionAddress, "OutDistanceToPoint", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref VolumeEncompassPoint_ReturnValue_PropertyAddress, VolumeEncompassPoint_FunctionAddress, "ReturnValue");
		VolumeEncompassPoint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(VolumeEncompassPoint_FunctionAddress, "ReturnValue");
		VolumeEncompassPoint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(VolumeEncompassPoint_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		VolumeEncompassPoint_IsValid = VolumeEncompassPoint_FunctionAddress != IntPtr.Zero && VolumeEncompassPoint_Volume_IsValid && VolumeEncompassPoint_Point_IsValid && VolumeEncompassPoint_SphereRadius_IsValid && VolumeEncompassPoint_OutDistanceToPoint_IsValid && VolumeEncompassPoint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:VolumeEncompassPoint", VolumeEncompassPoint_IsValid);
		SphereComponentInitRadius_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SphereComponentInitRadius");
		SphereComponentInitRadius_ParamsSize = NativeReflection.GetFunctionParamsSize(SphereComponentInitRadius_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SphereComponentInitRadius_SphereComp_PropertyAddress, SphereComponentInitRadius_FunctionAddress, "SphereComp");
		SphereComponentInitRadius_SphereComp_Offset = NativeReflectionCached.GetPropertyOffset(SphereComponentInitRadius_FunctionAddress, "SphereComp");
		SphereComponentInitRadius_SphereComp_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereComponentInitRadius_FunctionAddress, "SphereComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SphereComponentInitRadius_Radius_PropertyAddress, SphereComponentInitRadius_FunctionAddress, "Radius");
		SphereComponentInitRadius_Radius_Offset = NativeReflectionCached.GetPropertyOffset(SphereComponentInitRadius_FunctionAddress, "Radius");
		SphereComponentInitRadius_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(SphereComponentInitRadius_FunctionAddress, "Radius", Classes.FFloatProperty);
		SphereComponentInitRadius_IsValid = SphereComponentInitRadius_FunctionAddress != IntPtr.Zero && SphereComponentInitRadius_SphereComp_IsValid && SphereComponentInitRadius_Radius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:SphereComponentInitRadius", SphereComponentInitRadius_IsValid);
		SetLocalKinematics_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetLocalKinematics");
		SetLocalKinematics_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLocalKinematics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLocalKinematics_TargetMesh_PropertyAddress, SetLocalKinematics_FunctionAddress, "TargetMesh");
		SetLocalKinematics_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalKinematics_FunctionAddress, "TargetMesh");
		SetLocalKinematics_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalKinematics_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetLocalKinematics_NewBool_PropertyAddress, SetLocalKinematics_FunctionAddress, "NewBool");
		SetLocalKinematics_NewBool_Offset = NativeReflectionCached.GetPropertyOffset(SetLocalKinematics_FunctionAddress, "NewBool");
		SetLocalKinematics_NewBool_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLocalKinematics_FunctionAddress, "NewBool", Classes.FBoolProperty);
		SetLocalKinematics_IsValid = SetLocalKinematics_FunctionAddress != IntPtr.Zero && SetLocalKinematics_TargetMesh_IsValid && SetLocalKinematics_NewBool_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:SetLocalKinematics", SetLocalKinematics_IsValid);
		SetIKValid_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetIKValid");
		SetIKValid_ParamsSize = NativeReflection.GetFunctionParamsSize(SetIKValid_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetIKValid_Character_PropertyAddress, SetIKValid_FunctionAddress, "Character");
		SetIKValid_Character_Offset = NativeReflectionCached.GetPropertyOffset(SetIKValid_FunctionAddress, "Character");
		SetIKValid_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKValid_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetIKValid_NewValid_PropertyAddress, SetIKValid_FunctionAddress, "NewValid");
		SetIKValid_NewValid_Offset = NativeReflectionCached.GetPropertyOffset(SetIKValid_FunctionAddress, "NewValid");
		SetIKValid_NewValid_IsValid = NativeReflectionCached.ValidatePropertyClass(SetIKValid_FunctionAddress, "NewValid", Classes.FBoolProperty);
		SetIKValid_IsValid = SetIKValid_FunctionAddress != IntPtr.Zero && SetIKValid_Character_IsValid && SetIKValid_NewValid_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:SetIKValid", SetIKValid_IsValid);
		SetBodyBonePhysic_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBodyBonePhysic");
		SetBodyBonePhysic_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBodyBonePhysic_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBodyBonePhysic_TargetMesh_PropertyAddress, SetBodyBonePhysic_FunctionAddress, "TargetMesh");
		SetBodyBonePhysic_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyBonePhysic_FunctionAddress, "TargetMesh");
		SetBodyBonePhysic_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyBonePhysic_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyBonePhysic_BoneName_PropertyAddress, SetBodyBonePhysic_FunctionAddress, "BoneName");
		SetBodyBonePhysic_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyBonePhysic_FunctionAddress, "BoneName");
		SetBodyBonePhysic_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyBonePhysic_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBodyBonePhysic_NewBool_PropertyAddress, SetBodyBonePhysic_FunctionAddress, "NewBool");
		SetBodyBonePhysic_NewBool_Offset = NativeReflectionCached.GetPropertyOffset(SetBodyBonePhysic_FunctionAddress, "NewBool");
		SetBodyBonePhysic_NewBool_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBodyBonePhysic_FunctionAddress, "NewBool", Classes.FBoolProperty);
		SetBodyBonePhysic_IsValid = SetBodyBonePhysic_FunctionAddress != IntPtr.Zero && SetBodyBonePhysic_TargetMesh_IsValid && SetBodyBonePhysic_BoneName_IsValid && SetBodyBonePhysic_NewBool_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:SetBodyBonePhysic", SetBodyBonePhysic_IsValid);
		SetAllBodiesBelowSimulatePhysics_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAllBodiesBelowSimulatePhysics");
		SetAllBodiesBelowSimulatePhysics_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAllBodiesBelowSimulatePhysics_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAllBodiesBelowSimulatePhysics_TargetMesh_PropertyAddress, SetAllBodiesBelowSimulatePhysics_FunctionAddress, "TargetMesh");
		SetAllBodiesBelowSimulatePhysics_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetAllBodiesBelowSimulatePhysics_FunctionAddress, "TargetMesh");
		SetAllBodiesBelowSimulatePhysics_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllBodiesBelowSimulatePhysics_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllBodiesBelowSimulatePhysics_InBoneName_PropertyAddress, SetAllBodiesBelowSimulatePhysics_FunctionAddress, "InBoneName");
		SetAllBodiesBelowSimulatePhysics_InBoneName_Offset = NativeReflectionCached.GetPropertyOffset(SetAllBodiesBelowSimulatePhysics_FunctionAddress, "InBoneName");
		SetAllBodiesBelowSimulatePhysics_InBoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllBodiesBelowSimulatePhysics_FunctionAddress, "InBoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllBodiesBelowSimulatePhysics_bNewSimulate_PropertyAddress, SetAllBodiesBelowSimulatePhysics_FunctionAddress, "bNewSimulate");
		SetAllBodiesBelowSimulatePhysics_bNewSimulate_Offset = NativeReflectionCached.GetPropertyOffset(SetAllBodiesBelowSimulatePhysics_FunctionAddress, "bNewSimulate");
		SetAllBodiesBelowSimulatePhysics_bNewSimulate_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllBodiesBelowSimulatePhysics_FunctionAddress, "bNewSimulate", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllBodiesBelowSimulatePhysics_bIncludeSelf_PropertyAddress, SetAllBodiesBelowSimulatePhysics_FunctionAddress, "bIncludeSelf");
		SetAllBodiesBelowSimulatePhysics_bIncludeSelf_Offset = NativeReflectionCached.GetPropertyOffset(SetAllBodiesBelowSimulatePhysics_FunctionAddress, "bIncludeSelf");
		SetAllBodiesBelowSimulatePhysics_bIncludeSelf_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllBodiesBelowSimulatePhysics_FunctionAddress, "bIncludeSelf", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetAllBodiesBelowSimulatePhysics_bSkipCustomPhysicsType_PropertyAddress, SetAllBodiesBelowSimulatePhysics_FunctionAddress, "bSkipCustomPhysicsType");
		SetAllBodiesBelowSimulatePhysics_bSkipCustomPhysicsType_Offset = NativeReflectionCached.GetPropertyOffset(SetAllBodiesBelowSimulatePhysics_FunctionAddress, "bSkipCustomPhysicsType");
		SetAllBodiesBelowSimulatePhysics_bSkipCustomPhysicsType_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAllBodiesBelowSimulatePhysics_FunctionAddress, "bSkipCustomPhysicsType", Classes.FBoolProperty);
		SetAllBodiesBelowSimulatePhysics_IsValid = SetAllBodiesBelowSimulatePhysics_FunctionAddress != IntPtr.Zero && SetAllBodiesBelowSimulatePhysics_TargetMesh_IsValid && SetAllBodiesBelowSimulatePhysics_InBoneName_IsValid && SetAllBodiesBelowSimulatePhysics_bNewSimulate_IsValid && SetAllBodiesBelowSimulatePhysics_bIncludeSelf_IsValid && SetAllBodiesBelowSimulatePhysics_bSkipCustomPhysicsType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:SetAllBodiesBelowSimulatePhysics", SetAllBodiesBelowSimulatePhysics_IsValid);
		SerializeActorComponentToLevelActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SerializeActorComponentToLevelActor");
		SerializeActorComponentToLevelActor_ParamsSize = NativeReflection.GetFunctionParamsSize(SerializeActorComponentToLevelActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SerializeActorComponentToLevelActor_TargetLevelActor_PropertyAddress, SerializeActorComponentToLevelActor_FunctionAddress, "TargetLevelActor");
		SerializeActorComponentToLevelActor_TargetLevelActor_Offset = NativeReflectionCached.GetPropertyOffset(SerializeActorComponentToLevelActor_FunctionAddress, "TargetLevelActor");
		SerializeActorComponentToLevelActor_TargetLevelActor_IsValid = NativeReflectionCached.ValidatePropertyClass(SerializeActorComponentToLevelActor_FunctionAddress, "TargetLevelActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SerializeActorComponentToLevelActor_InActorComponent_PropertyAddress, SerializeActorComponentToLevelActor_FunctionAddress, "InActorComponent");
		SerializeActorComponentToLevelActor_InActorComponent_Offset = NativeReflectionCached.GetPropertyOffset(SerializeActorComponentToLevelActor_FunctionAddress, "InActorComponent");
		SerializeActorComponentToLevelActor_InActorComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SerializeActorComponentToLevelActor_FunctionAddress, "InActorComponent", Classes.FObjectProperty);
		SerializeActorComponentToLevelActor_IsValid = SerializeActorComponentToLevelActor_FunctionAddress != IntPtr.Zero && SerializeActorComponentToLevelActor_TargetLevelActor_IsValid && SerializeActorComponentToLevelActor_InActorComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:SerializeActorComponentToLevelActor", SerializeActorComponentToLevelActor_IsValid);
		ReplaceAllAnimNotifyStates_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReplaceAllAnimNotifyStates");
		ReplaceAllAnimNotifyStates_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceAllAnimNotifyStates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAllAnimNotifyStates_ResourcePath_PropertyAddress, ReplaceAllAnimNotifyStates_FunctionAddress, "ResourcePath");
		ReplaceAllAnimNotifyStates_ResourcePath_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAllAnimNotifyStates_FunctionAddress, "ResourcePath");
		ReplaceAllAnimNotifyStates_ResourcePath_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAllAnimNotifyStates_FunctionAddress, "ResourcePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAllAnimNotifyStates_OldNotifyStateClass_PropertyAddress, ReplaceAllAnimNotifyStates_FunctionAddress, "OldNotifyStateClass");
		ReplaceAllAnimNotifyStates_OldNotifyStateClass_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAllAnimNotifyStates_FunctionAddress, "OldNotifyStateClass");
		ReplaceAllAnimNotifyStates_OldNotifyStateClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAllAnimNotifyStates_FunctionAddress, "OldNotifyStateClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceAllAnimNotifyStates_NewNotifyStateClass_PropertyAddress, ReplaceAllAnimNotifyStates_FunctionAddress, "NewNotifyStateClass");
		ReplaceAllAnimNotifyStates_NewNotifyStateClass_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceAllAnimNotifyStates_FunctionAddress, "NewNotifyStateClass");
		ReplaceAllAnimNotifyStates_NewNotifyStateClass_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceAllAnimNotifyStates_FunctionAddress, "NewNotifyStateClass", Classes.FClassProperty);
		ReplaceAllAnimNotifyStates_IsValid = ReplaceAllAnimNotifyStates_FunctionAddress != IntPtr.Zero && ReplaceAllAnimNotifyStates_ResourcePath_IsValid && ReplaceAllAnimNotifyStates_OldNotifyStateClass_IsValid && ReplaceAllAnimNotifyStates_NewNotifyStateClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:ReplaceAllAnimNotifyStates", ReplaceAllAnimNotifyStates_IsValid);
		RemoveLevelStreaming_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveLevelStreaming");
		RemoveLevelStreaming_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveLevelStreaming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveLevelStreaming_WorldContextObject_PropertyAddress, RemoveLevelStreaming_FunctionAddress, "WorldContextObject");
		RemoveLevelStreaming_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLevelStreaming_FunctionAddress, "WorldContextObject");
		RemoveLevelStreaming_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLevelStreaming_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveLevelStreaming_LevelName_PropertyAddress, RemoveLevelStreaming_FunctionAddress, "LevelName");
		RemoveLevelStreaming_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(RemoveLevelStreaming_FunctionAddress, "LevelName");
		RemoveLevelStreaming_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveLevelStreaming_FunctionAddress, "LevelName", Classes.FNameProperty);
		RemoveLevelStreaming_IsValid = RemoveLevelStreaming_FunctionAddress != IntPtr.Zero && RemoveLevelStreaming_WorldContextObject_IsValid && RemoveLevelStreaming_LevelName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:RemoveLevelStreaming", RemoveLevelStreaming_IsValid);
		RemoveActorComponentFromLevelActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveActorComponentFromLevelActor");
		RemoveActorComponentFromLevelActor_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveActorComponentFromLevelActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveActorComponentFromLevelActor_TargetLevelActor_PropertyAddress, RemoveActorComponentFromLevelActor_FunctionAddress, "TargetLevelActor");
		RemoveActorComponentFromLevelActor_TargetLevelActor_Offset = NativeReflectionCached.GetPropertyOffset(RemoveActorComponentFromLevelActor_FunctionAddress, "TargetLevelActor");
		RemoveActorComponentFromLevelActor_TargetLevelActor_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveActorComponentFromLevelActor_FunctionAddress, "TargetLevelActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveActorComponentFromLevelActor_InActorComponent_PropertyAddress, RemoveActorComponentFromLevelActor_FunctionAddress, "InActorComponent");
		RemoveActorComponentFromLevelActor_InActorComponent_Offset = NativeReflectionCached.GetPropertyOffset(RemoveActorComponentFromLevelActor_FunctionAddress, "InActorComponent");
		RemoveActorComponentFromLevelActor_InActorComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveActorComponentFromLevelActor_FunctionAddress, "InActorComponent", Classes.FObjectProperty);
		RemoveActorComponentFromLevelActor_IsValid = RemoveActorComponentFromLevelActor_FunctionAddress != IntPtr.Zero && RemoveActorComponentFromLevelActor_TargetLevelActor_IsValid && RemoveActorComponentFromLevelActor_InActorComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:RemoveActorComponentFromLevelActor", RemoveActorComponentFromLevelActor_IsValid);
		MoveLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MoveLevel");
		MoveLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveLevel_WorldContextObject_PropertyAddress, MoveLevel_FunctionAddress, "WorldContextObject");
		MoveLevel_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(MoveLevel_FunctionAddress, "WorldContextObject");
		MoveLevel_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveLevel_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveLevel_LevelName_PropertyAddress, MoveLevel_FunctionAddress, "LevelName");
		MoveLevel_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(MoveLevel_FunctionAddress, "LevelName");
		MoveLevel_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveLevel_FunctionAddress, "LevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveLevel_InWorldOffset_PropertyAddress, MoveLevel_FunctionAddress, "InWorldOffset");
		MoveLevel_InWorldOffset_Offset = NativeReflectionCached.GetPropertyOffset(MoveLevel_FunctionAddress, "InWorldOffset");
		MoveLevel_InWorldOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveLevel_FunctionAddress, "InWorldOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveLevel_bActorOnly_PropertyAddress, MoveLevel_FunctionAddress, "bActorOnly");
		MoveLevel_bActorOnly_Offset = NativeReflectionCached.GetPropertyOffset(MoveLevel_FunctionAddress, "bActorOnly");
		MoveLevel_bActorOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveLevel_FunctionAddress, "bActorOnly", Classes.FBoolProperty);
		MoveLevel_IsValid = MoveLevel_FunctionAddress != IntPtr.Zero && MoveLevel_WorldContextObject_IsValid && MoveLevel_LevelName_IsValid && MoveLevel_InWorldOffset_IsValid && MoveLevel_bActorOnly_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:MoveLevel", MoveLevel_IsValid);
		MakeUniqueTamerMonsterName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MakeUniqueTamerMonsterName");
		MakeUniqueTamerMonsterName_ParamsSize = NativeReflection.GetFunctionParamsSize(MakeUniqueTamerMonsterName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MakeUniqueTamerMonsterName_SpawnLevel_PropertyAddress, MakeUniqueTamerMonsterName_FunctionAddress, "SpawnLevel");
		MakeUniqueTamerMonsterName_SpawnLevel_Offset = NativeReflectionCached.GetPropertyOffset(MakeUniqueTamerMonsterName_FunctionAddress, "SpawnLevel");
		MakeUniqueTamerMonsterName_SpawnLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeUniqueTamerMonsterName_FunctionAddress, "SpawnLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeUniqueTamerMonsterName_InBaseName_PropertyAddress, MakeUniqueTamerMonsterName_FunctionAddress, "InBaseName");
		MakeUniqueTamerMonsterName_InBaseName_Offset = NativeReflectionCached.GetPropertyOffset(MakeUniqueTamerMonsterName_FunctionAddress, "InBaseName");
		MakeUniqueTamerMonsterName_InBaseName_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeUniqueTamerMonsterName_FunctionAddress, "InBaseName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref MakeUniqueTamerMonsterName_ReturnValue_PropertyAddress, MakeUniqueTamerMonsterName_FunctionAddress, "ReturnValue");
		MakeUniqueTamerMonsterName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MakeUniqueTamerMonsterName_FunctionAddress, "ReturnValue");
		MakeUniqueTamerMonsterName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MakeUniqueTamerMonsterName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		MakeUniqueTamerMonsterName_IsValid = MakeUniqueTamerMonsterName_FunctionAddress != IntPtr.Zero && MakeUniqueTamerMonsterName_SpawnLevel_IsValid && MakeUniqueTamerMonsterName_InBaseName_IsValid && MakeUniqueTamerMonsterName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:MakeUniqueTamerMonsterName", MakeUniqueTamerMonsterName_IsValid);
		GetStreamingVolumeBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStreamingVolumeBounds");
		GetStreamingVolumeBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStreamingVolumeBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStreamingVolumeBounds_LevelStreaming_PropertyAddress, GetStreamingVolumeBounds_FunctionAddress, "LevelStreaming");
		GetStreamingVolumeBounds_LevelStreaming_Offset = NativeReflectionCached.GetPropertyOffset(GetStreamingVolumeBounds_FunctionAddress, "LevelStreaming");
		GetStreamingVolumeBounds_LevelStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStreamingVolumeBounds_FunctionAddress, "LevelStreaming", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStreamingVolumeBounds_ReturnValue_PropertyAddress, GetStreamingVolumeBounds_FunctionAddress, "ReturnValue");
		GetStreamingVolumeBounds_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStreamingVolumeBounds_FunctionAddress, "ReturnValue");
		GetStreamingVolumeBounds_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStreamingVolumeBounds_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetStreamingVolumeBounds_IsValid = GetStreamingVolumeBounds_FunctionAddress != IntPtr.Zero && GetStreamingVolumeBounds_LevelStreaming_IsValid && GetStreamingVolumeBounds_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetStreamingVolumeBounds", GetStreamingVolumeBounds_IsValid);
		GetScalarParameterValueByInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetScalarParameterValueByInfo");
		GetScalarParameterValueByInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetScalarParameterValueByInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValueByInfo_Mat_PropertyAddress, GetScalarParameterValueByInfo_FunctionAddress, "Mat");
		GetScalarParameterValueByInfo_Mat_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValueByInfo_FunctionAddress, "Mat");
		GetScalarParameterValueByInfo_Mat_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValueByInfo_FunctionAddress, "Mat", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValueByInfo_ParameterInfo_PropertyAddress, GetScalarParameterValueByInfo_FunctionAddress, "ParameterInfo");
		GetScalarParameterValueByInfo_ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValueByInfo_FunctionAddress, "ParameterInfo");
		GetScalarParameterValueByInfo_ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValueByInfo_FunctionAddress, "ParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetScalarParameterValueByInfo_ReturnValue_PropertyAddress, GetScalarParameterValueByInfo_FunctionAddress, "ReturnValue");
		GetScalarParameterValueByInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetScalarParameterValueByInfo_FunctionAddress, "ReturnValue");
		GetScalarParameterValueByInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetScalarParameterValueByInfo_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetScalarParameterValueByInfo_IsValid = GetScalarParameterValueByInfo_FunctionAddress != IntPtr.Zero && GetScalarParameterValueByInfo_Mat_IsValid && GetScalarParameterValueByInfo_ParameterInfo_IsValid && GetScalarParameterValueByInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetScalarParameterValueByInfo", GetScalarParameterValueByInfo_IsValid);
		GetPreviewMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPreviewMesh");
		GetPreviewMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPreviewMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewMesh_Skeleton_PropertyAddress, GetPreviewMesh_FunctionAddress, "Skeleton");
		GetPreviewMesh_Skeleton_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewMesh_FunctionAddress, "Skeleton");
		GetPreviewMesh_Skeleton_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewMesh_FunctionAddress, "Skeleton", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewMesh_bFindIfNotSet_PropertyAddress, GetPreviewMesh_FunctionAddress, "bFindIfNotSet");
		GetPreviewMesh_bFindIfNotSet_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewMesh_FunctionAddress, "bFindIfNotSet");
		GetPreviewMesh_bFindIfNotSet_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewMesh_FunctionAddress, "bFindIfNotSet", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPreviewMesh_ReturnValue_PropertyAddress, GetPreviewMesh_FunctionAddress, "ReturnValue");
		GetPreviewMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPreviewMesh_FunctionAddress, "ReturnValue");
		GetPreviewMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPreviewMesh_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPreviewMesh_IsValid = GetPreviewMesh_FunctionAddress != IntPtr.Zero && GetPreviewMesh_Skeleton_IsValid && GetPreviewMesh_bFindIfNotSet_IsValid && GetPreviewMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetPreviewMesh", GetPreviewMesh_IsValid);
		GetPlayerCharacter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPlayerCharacter");
		GetPlayerCharacter_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerCharacter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerCharacter_WorldContextObject_PropertyAddress, GetPlayerCharacter_FunctionAddress, "WorldContextObject");
		GetPlayerCharacter_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerCharacter_FunctionAddress, "WorldContextObject");
		GetPlayerCharacter_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerCharacter_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerCharacter_ReturnValue_PropertyAddress, GetPlayerCharacter_FunctionAddress, "ReturnValue");
		GetPlayerCharacter_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerCharacter_FunctionAddress, "ReturnValue");
		GetPlayerCharacter_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerCharacter_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPlayerCharacter_IsValid = GetPlayerCharacter_FunctionAddress != IntPtr.Zero && GetPlayerCharacter_WorldContextObject_IsValid && GetPlayerCharacter_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetPlayerCharacter", GetPlayerCharacter_IsValid);
		GetNearestBoneName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNearestBoneName");
		GetNearestBoneName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNearestBoneName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNearestBoneName_TargetSkeletalMesh_PropertyAddress, GetNearestBoneName_FunctionAddress, "TargetSkeletalMesh");
		GetNearestBoneName_TargetSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(GetNearestBoneName_FunctionAddress, "TargetSkeletalMesh");
		GetNearestBoneName_TargetSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNearestBoneName_FunctionAddress, "TargetSkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNearestBoneName_WorldPosition_PropertyAddress, GetNearestBoneName_FunctionAddress, "WorldPosition");
		GetNearestBoneName_WorldPosition_Offset = NativeReflectionCached.GetPropertyOffset(GetNearestBoneName_FunctionAddress, "WorldPosition");
		GetNearestBoneName_WorldPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNearestBoneName_FunctionAddress, "WorldPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNearestBoneName_OptionalWhiteList_PropertyAddress, GetNearestBoneName_FunctionAddress, "OptionalWhiteList");
		GetNearestBoneName_OptionalWhiteList_Offset = NativeReflectionCached.GetPropertyOffset(GetNearestBoneName_FunctionAddress, "OptionalWhiteList");
		GetNearestBoneName_OptionalWhiteList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNearestBoneName_FunctionAddress, "OptionalWhiteList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNearestBoneName_ReturnValue_PropertyAddress, GetNearestBoneName_FunctionAddress, "ReturnValue");
		GetNearestBoneName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNearestBoneName_FunctionAddress, "ReturnValue");
		GetNearestBoneName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNearestBoneName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetNearestBoneName_IsValid = GetNearestBoneName_FunctionAddress != IntPtr.Zero && GetNearestBoneName_TargetSkeletalMesh_IsValid && GetNearestBoneName_WorldPosition_IsValid && GetNearestBoneName_OptionalWhiteList_IsValid && GetNearestBoneName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetNearestBoneName", GetNearestBoneName_IsValid);
		GetLinearColorParameterValueByInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLinearColorParameterValueByInfo");
		GetLinearColorParameterValueByInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLinearColorParameterValueByInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLinearColorParameterValueByInfo_Mat_PropertyAddress, GetLinearColorParameterValueByInfo_FunctionAddress, "Mat");
		GetLinearColorParameterValueByInfo_Mat_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearColorParameterValueByInfo_FunctionAddress, "Mat");
		GetLinearColorParameterValueByInfo_Mat_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearColorParameterValueByInfo_FunctionAddress, "Mat", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearColorParameterValueByInfo_ParameterInfo_PropertyAddress, GetLinearColorParameterValueByInfo_FunctionAddress, "ParameterInfo");
		GetLinearColorParameterValueByInfo_ParameterInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearColorParameterValueByInfo_FunctionAddress, "ParameterInfo");
		GetLinearColorParameterValueByInfo_ParameterInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearColorParameterValueByInfo_FunctionAddress, "ParameterInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearColorParameterValueByInfo_OutValue_PropertyAddress, GetLinearColorParameterValueByInfo_FunctionAddress, "OutValue");
		GetLinearColorParameterValueByInfo_OutValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearColorParameterValueByInfo_FunctionAddress, "OutValue");
		GetLinearColorParameterValueByInfo_OutValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearColorParameterValueByInfo_FunctionAddress, "OutValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearColorParameterValueByInfo_bOveriddenOnly_PropertyAddress, GetLinearColorParameterValueByInfo_FunctionAddress, "bOveriddenOnly");
		GetLinearColorParameterValueByInfo_bOveriddenOnly_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearColorParameterValueByInfo_FunctionAddress, "bOveriddenOnly");
		GetLinearColorParameterValueByInfo_bOveriddenOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearColorParameterValueByInfo_FunctionAddress, "bOveriddenOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLinearColorParameterValueByInfo_ReturnValue_PropertyAddress, GetLinearColorParameterValueByInfo_FunctionAddress, "ReturnValue");
		GetLinearColorParameterValueByInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLinearColorParameterValueByInfo_FunctionAddress, "ReturnValue");
		GetLinearColorParameterValueByInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLinearColorParameterValueByInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetLinearColorParameterValueByInfo_IsValid = GetLinearColorParameterValueByInfo_FunctionAddress != IntPtr.Zero && GetLinearColorParameterValueByInfo_Mat_IsValid && GetLinearColorParameterValueByInfo_ParameterInfo_IsValid && GetLinearColorParameterValueByInfo_OutValue_IsValid && GetLinearColorParameterValueByInfo_bOveriddenOnly_IsValid && GetLinearColorParameterValueByInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetLinearColorParameterValueByInfo", GetLinearColorParameterValueByInfo_IsValid);
		GetLevelStreamingState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelStreamingState");
		GetLevelStreamingState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelStreamingState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingState_WorldContextObject_PropertyAddress, GetLevelStreamingState_FunctionAddress, "WorldContextObject");
		GetLevelStreamingState_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingState_FunctionAddress, "WorldContextObject");
		GetLevelStreamingState_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingState_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingState_LevelName_PropertyAddress, GetLevelStreamingState_FunctionAddress, "LevelName");
		GetLevelStreamingState_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingState_FunctionAddress, "LevelName");
		GetLevelStreamingState_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingState_FunctionAddress, "LevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingState_ReturnValue_PropertyAddress, GetLevelStreamingState_FunctionAddress, "ReturnValue");
		GetLevelStreamingState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingState_FunctionAddress, "ReturnValue");
		GetLevelStreamingState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingState_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetLevelStreamingState_IsValid = GetLevelStreamingState_FunctionAddress != IntPtr.Zero && GetLevelStreamingState_WorldContextObject_IsValid && GetLevelStreamingState_LevelName_IsValid && GetLevelStreamingState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetLevelStreamingState", GetLevelStreamingState_IsValid);
		GetLevelStreamingLevelTransformByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelStreamingLevelTransformByName");
		GetLevelStreamingLevelTransformByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelStreamingLevelTransformByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingLevelTransformByName_WorldContextObject_PropertyAddress, GetLevelStreamingLevelTransformByName_FunctionAddress, "WorldContextObject");
		GetLevelStreamingLevelTransformByName_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingLevelTransformByName_FunctionAddress, "WorldContextObject");
		GetLevelStreamingLevelTransformByName_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingLevelTransformByName_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingLevelTransformByName_LevelName_PropertyAddress, GetLevelStreamingLevelTransformByName_FunctionAddress, "LevelName");
		GetLevelStreamingLevelTransformByName_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingLevelTransformByName_FunctionAddress, "LevelName");
		GetLevelStreamingLevelTransformByName_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingLevelTransformByName_FunctionAddress, "LevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingLevelTransformByName_ReturnValue_PropertyAddress, GetLevelStreamingLevelTransformByName_FunctionAddress, "ReturnValue");
		GetLevelStreamingLevelTransformByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingLevelTransformByName_FunctionAddress, "ReturnValue");
		GetLevelStreamingLevelTransformByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingLevelTransformByName_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetLevelStreamingLevelTransformByName_IsValid = GetLevelStreamingLevelTransformByName_FunctionAddress != IntPtr.Zero && GetLevelStreamingLevelTransformByName_WorldContextObject_IsValid && GetLevelStreamingLevelTransformByName_LevelName_IsValid && GetLevelStreamingLevelTransformByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetLevelStreamingLevelTransformByName", GetLevelStreamingLevelTransformByName_IsValid);
		GetLevelStreamingFromWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelStreamingFromWorld");
		GetLevelStreamingFromWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelStreamingFromWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingFromWorld_World_PropertyAddress, GetLevelStreamingFromWorld_FunctionAddress, "World");
		GetLevelStreamingFromWorld_World_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingFromWorld_FunctionAddress, "World");
		GetLevelStreamingFromWorld_World_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingFromWorld_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingFromWorld_ReturnValue_PropertyAddress, GetLevelStreamingFromWorld_FunctionAddress, "ReturnValue");
		GetLevelStreamingFromWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingFromWorld_FunctionAddress, "ReturnValue");
		GetLevelStreamingFromWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingFromWorld_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLevelStreamingFromWorld_IsValid = GetLevelStreamingFromWorld_FunctionAddress != IntPtr.Zero && GetLevelStreamingFromWorld_World_IsValid && GetLevelStreamingFromWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetLevelStreamingFromWorld", GetLevelStreamingFromWorld_IsValid);
		GetLevelStreaming_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetLevelStreaming");
		GetLevelStreaming_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelStreaming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreaming_WorldContextObject_PropertyAddress, GetLevelStreaming_FunctionAddress, "WorldContextObject");
		GetLevelStreaming_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreaming_FunctionAddress, "WorldContextObject");
		GetLevelStreaming_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreaming_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreaming_ReturnValue_PropertyAddress, GetLevelStreaming_FunctionAddress, "ReturnValue");
		GetLevelStreaming_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreaming_FunctionAddress, "ReturnValue");
		GetLevelStreaming_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreaming_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLevelStreaming_IsValid = GetLevelStreaming_FunctionAddress != IntPtr.Zero && GetLevelStreaming_WorldContextObject_IsValid && GetLevelStreaming_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetLevelStreaming", GetLevelStreaming_IsValid);
		GetAssetLongPackageName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetLongPackageName");
		GetAssetLongPackageName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetLongPackageName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetLongPackageName_ClassName_PropertyAddress, GetAssetLongPackageName_FunctionAddress, "ClassName");
		GetAssetLongPackageName_ClassName_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetLongPackageName_FunctionAddress, "ClassName");
		GetAssetLongPackageName_ClassName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetLongPackageName_FunctionAddress, "ClassName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetLongPackageName_AssetName_PropertyAddress, GetAssetLongPackageName_FunctionAddress, "AssetName");
		GetAssetLongPackageName_AssetName_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetLongPackageName_FunctionAddress, "AssetName");
		GetAssetLongPackageName_AssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetLongPackageName_FunctionAddress, "AssetName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetLongPackageName_ReturnValue_PropertyAddress, GetAssetLongPackageName_FunctionAddress, "ReturnValue");
		GetAssetLongPackageName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetLongPackageName_FunctionAddress, "ReturnValue");
		GetAssetLongPackageName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetLongPackageName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetAssetLongPackageName_IsValid = GetAssetLongPackageName_FunctionAddress != IntPtr.Zero && GetAssetLongPackageName_ClassName_IsValid && GetAssetLongPackageName_AssetName_IsValid && GetAssetLongPackageName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetAssetLongPackageName", GetAssetLongPackageName_IsValid);
		GetAllAssetReference_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllAssetReference");
		GetAllAssetReference_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllAssetReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllAssetReference_SelectedPackageName_PropertyAddress, GetAllAssetReference_FunctionAddress, "SelectedPackageName");
		GetAllAssetReference_SelectedPackageName_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAssetReference_FunctionAddress, "SelectedPackageName");
		GetAllAssetReference_SelectedPackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAssetReference_FunctionAddress, "SelectedPackageName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAssetReference_ReturnValue_PropertyAddress, GetAllAssetReference_FunctionAddress, "ReturnValue");
		GetAllAssetReference_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAssetReference_FunctionAddress, "ReturnValue");
		GetAllAssetReference_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAssetReference_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllAssetReference_IsValid = GetAllAssetReference_FunctionAddress != IntPtr.Zero && GetAllAssetReference_SelectedPackageName_IsValid && GetAllAssetReference_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetAllAssetReference", GetAllAssetReference_IsValid);
		GetAllAssetDependencies_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllAssetDependencies");
		GetAllAssetDependencies_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllAssetDependencies_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllAssetDependencies_SelectedPackageName_PropertyAddress, GetAllAssetDependencies_FunctionAddress, "SelectedPackageName");
		GetAllAssetDependencies_SelectedPackageName_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAssetDependencies_FunctionAddress, "SelectedPackageName");
		GetAllAssetDependencies_SelectedPackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAssetDependencies_FunctionAddress, "SelectedPackageName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAssetDependencies_ReturnValue_PropertyAddress, GetAllAssetDependencies_FunctionAddress, "ReturnValue");
		GetAllAssetDependencies_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAssetDependencies_FunctionAddress, "ReturnValue");
		GetAllAssetDependencies_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAssetDependencies_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllAssetDependencies_IsValid = GetAllAssetDependencies_FunctionAddress != IntPtr.Zero && GetAllAssetDependencies_SelectedPackageName_IsValid && GetAllAssetDependencies_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetAllAssetDependencies", GetAllAssetDependencies_IsValid);
		GetAllActorsInWorld_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllActorsInWorld");
		GetAllActorsInWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllActorsInWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInWorld_World_PropertyAddress, GetAllActorsInWorld_FunctionAddress, "World");
		GetAllActorsInWorld_World_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInWorld_FunctionAddress, "World");
		GetAllActorsInWorld_World_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInWorld_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInWorld_ReturnValue_PropertyAddress, GetAllActorsInWorld_FunctionAddress, "ReturnValue");
		GetAllActorsInWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInWorld_FunctionAddress, "ReturnValue");
		GetAllActorsInWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInWorld_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllActorsInWorld_IsValid = GetAllActorsInWorld_FunctionAddress != IntPtr.Zero && GetAllActorsInWorld_World_IsValid && GetAllActorsInWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetAllActorsInWorld", GetAllActorsInWorld_IsValid);
		GetAllActorsInLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllActorsInLevel");
		GetAllActorsInLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllActorsInLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInLevel_Level_PropertyAddress, GetAllActorsInLevel_FunctionAddress, "Level");
		GetAllActorsInLevel_Level_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInLevel_FunctionAddress, "Level");
		GetAllActorsInLevel_Level_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInLevel_FunctionAddress, "Level", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllActorsInLevel_ReturnValue_PropertyAddress, GetAllActorsInLevel_FunctionAddress, "ReturnValue");
		GetAllActorsInLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllActorsInLevel_FunctionAddress, "ReturnValue");
		GetAllActorsInLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllActorsInLevel_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllActorsInLevel_IsValid = GetAllActorsInLevel_FunctionAddress != IntPtr.Zero && GetAllActorsInLevel_Level_IsValid && GetAllActorsInLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:GetAllActorsInLevel", GetAllActorsInLevel_IsValid);
		ForceLoadTileLOD_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ForceLoadTileLOD");
		ForceLoadTileLOD_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceLoadTileLOD_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ForceLoadTileLOD_WorldContext_PropertyAddress, ForceLoadTileLOD_FunctionAddress, "WorldContext");
		ForceLoadTileLOD_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(ForceLoadTileLOD_FunctionAddress, "WorldContext");
		ForceLoadTileLOD_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceLoadTileLOD_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceLoadTileLOD_TileName_PropertyAddress, ForceLoadTileLOD_FunctionAddress, "TileName");
		ForceLoadTileLOD_TileName_Offset = NativeReflectionCached.GetPropertyOffset(ForceLoadTileLOD_FunctionAddress, "TileName");
		ForceLoadTileLOD_TileName_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceLoadTileLOD_FunctionAddress, "TileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceLoadTileLOD_SwitchOn_PropertyAddress, ForceLoadTileLOD_FunctionAddress, "SwitchOn");
		ForceLoadTileLOD_SwitchOn_Offset = NativeReflectionCached.GetPropertyOffset(ForceLoadTileLOD_FunctionAddress, "SwitchOn");
		ForceLoadTileLOD_SwitchOn_IsValid = NativeReflectionCached.ValidatePropertyClass(ForceLoadTileLOD_FunctionAddress, "SwitchOn", Classes.FIntProperty);
		ForceLoadTileLOD_IsValid = ForceLoadTileLOD_FunctionAddress != IntPtr.Zero && ForceLoadTileLOD_WorldContext_IsValid && ForceLoadTileLOD_TileName_IsValid && ForceLoadTileLOD_SwitchOn_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:ForceLoadTileLOD", ForceLoadTileLOD_IsValid);
		DrawDebugString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DrawDebugString");
		DrawDebugString_ParamsSize = NativeReflection.GetFunctionParamsSize(DrawDebugString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugString_WorldContextObject_PropertyAddress, DrawDebugString_FunctionAddress, "WorldContextObject");
		DrawDebugString_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugString_FunctionAddress, "WorldContextObject");
		DrawDebugString_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugString_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugString_TextLocation_PropertyAddress, DrawDebugString_FunctionAddress, "TextLocation");
		DrawDebugString_TextLocation_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugString_FunctionAddress, "TextLocation");
		DrawDebugString_TextLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugString_FunctionAddress, "TextLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugString_Text_PropertyAddress, DrawDebugString_FunctionAddress, "Text");
		DrawDebugString_Text_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugString_FunctionAddress, "Text");
		DrawDebugString_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugString_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugString_TestBaseActor_PropertyAddress, DrawDebugString_FunctionAddress, "TestBaseActor");
		DrawDebugString_TestBaseActor_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugString_FunctionAddress, "TestBaseActor");
		DrawDebugString_TestBaseActor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugString_FunctionAddress, "TestBaseActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugString_TextColor_PropertyAddress, DrawDebugString_FunctionAddress, "TextColor");
		DrawDebugString_TextColor_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugString_FunctionAddress, "TextColor");
		DrawDebugString_TextColor_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugString_FunctionAddress, "TextColor", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref DrawDebugString_Duration_PropertyAddress, DrawDebugString_FunctionAddress, "Duration");
		DrawDebugString_Duration_Offset = NativeReflectionCached.GetPropertyOffset(DrawDebugString_FunctionAddress, "Duration");
		DrawDebugString_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(DrawDebugString_FunctionAddress, "Duration", Classes.FFloatProperty);
		DrawDebugString_IsValid = DrawDebugString_FunctionAddress != IntPtr.Zero && DrawDebugString_WorldContextObject_IsValid && DrawDebugString_TextLocation_IsValid && DrawDebugString_Text_IsValid && DrawDebugString_TestBaseActor_IsValid && DrawDebugString_TextColor_IsValid && DrawDebugString_Duration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:DrawDebugString", DrawDebugString_IsValid);
		CalculateMontageCostValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CalculateMontageCostValue");
		CalculateMontageCostValue_ParamsSize = NativeReflection.GetFunctionParamsSize(CalculateMontageCostValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CalculateMontageCostValue_MontageList_PropertyAddress, CalculateMontageCostValue_FunctionAddress, "MontageList");
		CalculateMontageCostValue_MontageList_Offset = NativeReflectionCached.GetPropertyOffset(CalculateMontageCostValue_FunctionAddress, "MontageList");
		CalculateMontageCostValue_MontageList_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateMontageCostValue_FunctionAddress, "MontageList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CalculateMontageCostValue_BoneNameList_PropertyAddress, CalculateMontageCostValue_FunctionAddress, "BoneNameList");
		CalculateMontageCostValue_BoneNameList_Offset = NativeReflectionCached.GetPropertyOffset(CalculateMontageCostValue_FunctionAddress, "BoneNameList");
		CalculateMontageCostValue_BoneNameList_IsValid = NativeReflectionCached.ValidatePropertyClass(CalculateMontageCostValue_FunctionAddress, "BoneNameList", Classes.FArrayProperty);
		CalculateMontageCostValue_IsValid = CalculateMontageCostValue_FunctionAddress != IntPtr.Zero && CalculateMontageCostValue_MontageList_IsValid && CalculateMontageCostValue_BoneNameList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:CalculateMontageCostValue", CalculateMontageCostValue_IsValid);
		BonesSphereMask_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BonesSphereMask");
		BonesSphereMask_ParamsSize = NativeReflection.GetFunctionParamsSize(BonesSphereMask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BonesSphereMask_TargetSkeletalMesh_PropertyAddress, BonesSphereMask_FunctionAddress, "TargetSkeletalMesh");
		BonesSphereMask_TargetSkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(BonesSphereMask_FunctionAddress, "TargetSkeletalMesh");
		BonesSphereMask_TargetSkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(BonesSphereMask_FunctionAddress, "TargetSkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BonesSphereMask_Radius_PropertyAddress, BonesSphereMask_FunctionAddress, "Radius");
		BonesSphereMask_Radius_Offset = NativeReflectionCached.GetPropertyOffset(BonesSphereMask_FunctionAddress, "Radius");
		BonesSphereMask_Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(BonesSphereMask_FunctionAddress, "Radius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BonesSphereMask_WorldPosition_PropertyAddress, BonesSphereMask_FunctionAddress, "WorldPosition");
		BonesSphereMask_WorldPosition_Offset = NativeReflectionCached.GetPropertyOffset(BonesSphereMask_FunctionAddress, "WorldPosition");
		BonesSphereMask_WorldPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(BonesSphereMask_FunctionAddress, "WorldPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BonesSphereMask_ReturnValue_PropertyAddress, BonesSphereMask_FunctionAddress, "ReturnValue");
		BonesSphereMask_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BonesSphereMask_FunctionAddress, "ReturnValue");
		BonesSphereMask_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BonesSphereMask_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		BonesSphereMask_IsValid = BonesSphereMask_FunctionAddress != IntPtr.Zero && BonesSphereMask_TargetSkeletalMesh_IsValid && BonesSphereMask_Radius_IsValid && BonesSphereMask_WorldPosition_IsValid && BonesSphereMask_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BonesSphereMask", BonesSphereMask_IsValid);
		BGUWoodTestCharacter_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUWoodTestCharacter");
		BGUWoodTestCharacter_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUWoodTestCharacter_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUWoodTestCharacter_Character_PropertyAddress, BGUWoodTestCharacter_FunctionAddress, "Character");
		BGUWoodTestCharacter_Character_Offset = NativeReflectionCached.GetPropertyOffset(BGUWoodTestCharacter_FunctionAddress, "Character");
		BGUWoodTestCharacter_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUWoodTestCharacter_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUWoodTestCharacter_Montage_PropertyAddress, BGUWoodTestCharacter_FunctionAddress, "Montage");
		BGUWoodTestCharacter_Montage_Offset = NativeReflectionCached.GetPropertyOffset(BGUWoodTestCharacter_FunctionAddress, "Montage");
		BGUWoodTestCharacter_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUWoodTestCharacter_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUWoodTestCharacter_ScaleRate_PropertyAddress, BGUWoodTestCharacter_FunctionAddress, "ScaleRate");
		BGUWoodTestCharacter_ScaleRate_Offset = NativeReflectionCached.GetPropertyOffset(BGUWoodTestCharacter_FunctionAddress, "ScaleRate");
		BGUWoodTestCharacter_ScaleRate_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUWoodTestCharacter_FunctionAddress, "ScaleRate", Classes.FFloatProperty);
		BGUWoodTestCharacter_IsValid = BGUWoodTestCharacter_FunctionAddress != IntPtr.Zero && BGUWoodTestCharacter_Character_IsValid && BGUWoodTestCharacter_Montage_IsValid && BGUWoodTestCharacter_ScaleRate_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUWoodTestCharacter", BGUWoodTestCharacter_IsValid);
		BGUUpdateLevelStreaming_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUUpdateLevelStreaming");
		BGUUpdateLevelStreaming_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUpdateLevelStreaming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUUpdateLevelStreaming_CurWorld_PropertyAddress, BGUUpdateLevelStreaming_FunctionAddress, "CurWorld");
		BGUUpdateLevelStreaming_CurWorld_Offset = NativeReflectionCached.GetPropertyOffset(BGUUpdateLevelStreaming_FunctionAddress, "CurWorld");
		BGUUpdateLevelStreaming_CurWorld_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUpdateLevelStreaming_FunctionAddress, "CurWorld", Classes.FObjectProperty);
		BGUUpdateLevelStreaming_IsValid = BGUUpdateLevelStreaming_FunctionAddress != IntPtr.Zero && BGUUpdateLevelStreaming_CurWorld_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUUpdateLevelStreaming", BGUUpdateLevelStreaming_IsValid);
		BGUUnloadStreamLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUUnloadStreamLevel");
		BGUUnloadStreamLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUUnloadStreamLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUUnloadStreamLevel_WorldContextObject_PropertyAddress, BGUUnloadStreamLevel_FunctionAddress, "WorldContextObject");
		BGUUnloadStreamLevel_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnloadStreamLevel_FunctionAddress, "WorldContextObject");
		BGUUnloadStreamLevel_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnloadStreamLevel_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnloadStreamLevel_LevelName_PropertyAddress, BGUUnloadStreamLevel_FunctionAddress, "LevelName");
		BGUUnloadStreamLevel_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnloadStreamLevel_FunctionAddress, "LevelName");
		BGUUnloadStreamLevel_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnloadStreamLevel_FunctionAddress, "LevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnloadStreamLevel_bShouldBlockOnUnload_PropertyAddress, BGUUnloadStreamLevel_FunctionAddress, "bShouldBlockOnUnload");
		BGUUnloadStreamLevel_bShouldBlockOnUnload_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnloadStreamLevel_FunctionAddress, "bShouldBlockOnUnload");
		BGUUnloadStreamLevel_bShouldBlockOnUnload_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnloadStreamLevel_FunctionAddress, "bShouldBlockOnUnload", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnloadStreamLevel_CallbackTarget_PropertyAddress, BGUUnloadStreamLevel_FunctionAddress, "CallbackTarget");
		BGUUnloadStreamLevel_CallbackTarget_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnloadStreamLevel_FunctionAddress, "CallbackTarget");
		BGUUnloadStreamLevel_CallbackTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnloadStreamLevel_FunctionAddress, "CallbackTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnloadStreamLevel_CallbackFunc_PropertyAddress, BGUUnloadStreamLevel_FunctionAddress, "CallbackFunc");
		BGUUnloadStreamLevel_CallbackFunc_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnloadStreamLevel_FunctionAddress, "CallbackFunc");
		BGUUnloadStreamLevel_CallbackFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnloadStreamLevel_FunctionAddress, "CallbackFunc", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnloadStreamLevel_ActionID_PropertyAddress, BGUUnloadStreamLevel_FunctionAddress, "ActionID");
		BGUUnloadStreamLevel_ActionID_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnloadStreamLevel_FunctionAddress, "ActionID");
		BGUUnloadStreamLevel_ActionID_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnloadStreamLevel_FunctionAddress, "ActionID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUUnloadStreamLevel_Linkage_PropertyAddress, BGUUnloadStreamLevel_FunctionAddress, "Linkage");
		BGUUnloadStreamLevel_Linkage_Offset = NativeReflectionCached.GetPropertyOffset(BGUUnloadStreamLevel_FunctionAddress, "Linkage");
		BGUUnloadStreamLevel_Linkage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUUnloadStreamLevel_FunctionAddress, "Linkage", Classes.FIntProperty);
		BGUUnloadStreamLevel_IsValid = BGUUnloadStreamLevel_FunctionAddress != IntPtr.Zero && BGUUnloadStreamLevel_WorldContextObject_IsValid && BGUUnloadStreamLevel_LevelName_IsValid && BGUUnloadStreamLevel_bShouldBlockOnUnload_IsValid && BGUUnloadStreamLevel_CallbackTarget_IsValid && BGUUnloadStreamLevel_CallbackFunc_IsValid && BGUUnloadStreamLevel_ActionID_IsValid && BGUUnloadStreamLevel_Linkage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUUnloadStreamLevel", BGUUnloadStreamLevel_IsValid);
		BGUSKMeshContainSocket_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSKMeshContainSocket");
		BGUSKMeshContainSocket_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSKMeshContainSocket_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSKMeshContainSocket_SkMeshComp_PropertyAddress, BGUSKMeshContainSocket_FunctionAddress, "SkMeshComp");
		BGUSKMeshContainSocket_SkMeshComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUSKMeshContainSocket_FunctionAddress, "SkMeshComp");
		BGUSKMeshContainSocket_SkMeshComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSKMeshContainSocket_FunctionAddress, "SkMeshComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSKMeshContainSocket_SocketName_PropertyAddress, BGUSKMeshContainSocket_FunctionAddress, "SocketName");
		BGUSKMeshContainSocket_SocketName_Offset = NativeReflectionCached.GetPropertyOffset(BGUSKMeshContainSocket_FunctionAddress, "SocketName");
		BGUSKMeshContainSocket_SocketName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSKMeshContainSocket_FunctionAddress, "SocketName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSKMeshContainSocket_ReturnValue_PropertyAddress, BGUSKMeshContainSocket_FunctionAddress, "ReturnValue");
		BGUSKMeshContainSocket_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUSKMeshContainSocket_FunctionAddress, "ReturnValue");
		BGUSKMeshContainSocket_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSKMeshContainSocket_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUSKMeshContainSocket_IsValid = BGUSKMeshContainSocket_FunctionAddress != IntPtr.Zero && BGUSKMeshContainSocket_SkMeshComp_IsValid && BGUSKMeshContainSocket_SocketName_IsValid && BGUSKMeshContainSocket_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUSKMeshContainSocket", BGUSKMeshContainSocket_IsValid);
		BGUShapeSweepMultiByObjectType_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUShapeSweepMultiByObjectType");
		BGUShapeSweepMultiByObjectType_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUShapeSweepMultiByObjectType_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUShapeSweepMultiByObjectType_ShapeComp_PropertyAddress, BGUShapeSweepMultiByObjectType_FunctionAddress, "ShapeComp");
		BGUShapeSweepMultiByObjectType_ShapeComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUShapeSweepMultiByObjectType_FunctionAddress, "ShapeComp");
		BGUShapeSweepMultiByObjectType_ShapeComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUShapeSweepMultiByObjectType_FunctionAddress, "ShapeComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUShapeSweepMultiByObjectType_Start_PropertyAddress, BGUShapeSweepMultiByObjectType_FunctionAddress, "Start");
		BGUShapeSweepMultiByObjectType_Start_Offset = NativeReflectionCached.GetPropertyOffset(BGUShapeSweepMultiByObjectType_FunctionAddress, "Start");
		BGUShapeSweepMultiByObjectType_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUShapeSweepMultiByObjectType_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUShapeSweepMultiByObjectType_End_PropertyAddress, BGUShapeSweepMultiByObjectType_FunctionAddress, "End");
		BGUShapeSweepMultiByObjectType_End_Offset = NativeReflectionCached.GetPropertyOffset(BGUShapeSweepMultiByObjectType_FunctionAddress, "End");
		BGUShapeSweepMultiByObjectType_End_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUShapeSweepMultiByObjectType_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUShapeSweepMultiByObjectType_ObjectTypes_PropertyAddress, BGUShapeSweepMultiByObjectType_FunctionAddress, "ObjectTypes");
		BGUShapeSweepMultiByObjectType_ObjectTypes_Offset = NativeReflectionCached.GetPropertyOffset(BGUShapeSweepMultiByObjectType_FunctionAddress, "ObjectTypes");
		BGUShapeSweepMultiByObjectType_ObjectTypes_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUShapeSweepMultiByObjectType_FunctionAddress, "ObjectTypes", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUShapeSweepMultiByObjectType_bTraceComplex_PropertyAddress, BGUShapeSweepMultiByObjectType_FunctionAddress, "bTraceComplex");
		BGUShapeSweepMultiByObjectType_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(BGUShapeSweepMultiByObjectType_FunctionAddress, "bTraceComplex");
		BGUShapeSweepMultiByObjectType_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUShapeSweepMultiByObjectType_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUShapeSweepMultiByObjectType_OutHits_PropertyAddress, BGUShapeSweepMultiByObjectType_FunctionAddress, "OutHits");
		BGUShapeSweepMultiByObjectType_OutHits_Offset = NativeReflectionCached.GetPropertyOffset(BGUShapeSweepMultiByObjectType_FunctionAddress, "OutHits");
		BGUShapeSweepMultiByObjectType_OutHits_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUShapeSweepMultiByObjectType_FunctionAddress, "OutHits", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUShapeSweepMultiByObjectType_bIgnoreSelf_PropertyAddress, BGUShapeSweepMultiByObjectType_FunctionAddress, "bIgnoreSelf");
		BGUShapeSweepMultiByObjectType_bIgnoreSelf_Offset = NativeReflectionCached.GetPropertyOffset(BGUShapeSweepMultiByObjectType_FunctionAddress, "bIgnoreSelf");
		BGUShapeSweepMultiByObjectType_bIgnoreSelf_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUShapeSweepMultiByObjectType_FunctionAddress, "bIgnoreSelf", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUShapeSweepMultiByObjectType_ReturnValue_PropertyAddress, BGUShapeSweepMultiByObjectType_FunctionAddress, "ReturnValue");
		BGUShapeSweepMultiByObjectType_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUShapeSweepMultiByObjectType_FunctionAddress, "ReturnValue");
		BGUShapeSweepMultiByObjectType_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUShapeSweepMultiByObjectType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUShapeSweepMultiByObjectType_IsValid = BGUShapeSweepMultiByObjectType_FunctionAddress != IntPtr.Zero && BGUShapeSweepMultiByObjectType_ShapeComp_IsValid && BGUShapeSweepMultiByObjectType_Start_IsValid && BGUShapeSweepMultiByObjectType_End_IsValid && BGUShapeSweepMultiByObjectType_ObjectTypes_IsValid && BGUShapeSweepMultiByObjectType_bTraceComplex_IsValid && BGUShapeSweepMultiByObjectType_OutHits_IsValid && BGUShapeSweepMultiByObjectType_bIgnoreSelf_IsValid && BGUShapeSweepMultiByObjectType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUShapeSweepMultiByObjectType", BGUShapeSweepMultiByObjectType_IsValid);
		BGUSetValueToCurveVector_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetValueToCurveVector");
		BGUSetValueToCurveVector_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetValueToCurveVector_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetValueToCurveVector_CurveVector_PropertyAddress, BGUSetValueToCurveVector_FunctionAddress, "CurveVector");
		BGUSetValueToCurveVector_CurveVector_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetValueToCurveVector_FunctionAddress, "CurveVector");
		BGUSetValueToCurveVector_CurveVector_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetValueToCurveVector_FunctionAddress, "CurveVector", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetValueToCurveVector_Key_PropertyAddress, BGUSetValueToCurveVector_FunctionAddress, "Key");
		BGUSetValueToCurveVector_Key_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetValueToCurveVector_FunctionAddress, "Key");
		BGUSetValueToCurveVector_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetValueToCurveVector_FunctionAddress, "Key", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetValueToCurveVector_Value_PropertyAddress, BGUSetValueToCurveVector_FunctionAddress, "Value");
		BGUSetValueToCurveVector_Value_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetValueToCurveVector_FunctionAddress, "Value");
		BGUSetValueToCurveVector_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetValueToCurveVector_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetValueToCurveVector_InterpMode_PropertyAddress, BGUSetValueToCurveVector_FunctionAddress, "InterpMode");
		BGUSetValueToCurveVector_InterpMode_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetValueToCurveVector_FunctionAddress, "InterpMode");
		BGUSetValueToCurveVector_InterpMode_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetValueToCurveVector_FunctionAddress, "InterpMode", Classes.FByteProperty);
		BGUSetValueToCurveVector_IsValid = BGUSetValueToCurveVector_FunctionAddress != IntPtr.Zero && BGUSetValueToCurveVector_CurveVector_IsValid && BGUSetValueToCurveVector_Key_IsValid && BGUSetValueToCurveVector_Value_IsValid && BGUSetValueToCurveVector_InterpMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUSetValueToCurveVector", BGUSetValueToCurveVector_IsValid);
		BGUSetValueToCurveFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetValueToCurveFloat");
		BGUSetValueToCurveFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetValueToCurveFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetValueToCurveFloat_CurveFloat_PropertyAddress, BGUSetValueToCurveFloat_FunctionAddress, "CurveFloat");
		BGUSetValueToCurveFloat_CurveFloat_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetValueToCurveFloat_FunctionAddress, "CurveFloat");
		BGUSetValueToCurveFloat_CurveFloat_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetValueToCurveFloat_FunctionAddress, "CurveFloat", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetValueToCurveFloat_Key_PropertyAddress, BGUSetValueToCurveFloat_FunctionAddress, "Key");
		BGUSetValueToCurveFloat_Key_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetValueToCurveFloat_FunctionAddress, "Key");
		BGUSetValueToCurveFloat_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetValueToCurveFloat_FunctionAddress, "Key", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetValueToCurveFloat_Value_PropertyAddress, BGUSetValueToCurveFloat_FunctionAddress, "Value");
		BGUSetValueToCurveFloat_Value_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetValueToCurveFloat_FunctionAddress, "Value");
		BGUSetValueToCurveFloat_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetValueToCurveFloat_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetValueToCurveFloat_InterpMode_PropertyAddress, BGUSetValueToCurveFloat_FunctionAddress, "InterpMode");
		BGUSetValueToCurveFloat_InterpMode_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetValueToCurveFloat_FunctionAddress, "InterpMode");
		BGUSetValueToCurveFloat_InterpMode_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetValueToCurveFloat_FunctionAddress, "InterpMode", Classes.FByteProperty);
		BGUSetValueToCurveFloat_IsValid = BGUSetValueToCurveFloat_FunctionAddress != IntPtr.Zero && BGUSetValueToCurveFloat_CurveFloat_IsValid && BGUSetValueToCurveFloat_Key_IsValid && BGUSetValueToCurveFloat_Value_IsValid && BGUSetValueToCurveFloat_InterpMode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUSetValueToCurveFloat", BGUSetValueToCurveFloat_IsValid);
		BGUSetTressFXAssetAndMaterial_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetTressFXAssetAndMaterial");
		BGUSetTressFXAssetAndMaterial_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetTressFXAssetAndMaterial_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTressFXAssetAndMaterial_TFXComp_PropertyAddress, BGUSetTressFXAssetAndMaterial_FunctionAddress, "TFXComp");
		BGUSetTressFXAssetAndMaterial_TFXComp_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTressFXAssetAndMaterial_FunctionAddress, "TFXComp");
		BGUSetTressFXAssetAndMaterial_TFXComp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTressFXAssetAndMaterial_FunctionAddress, "TFXComp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTressFXAssetAndMaterial_Asset_PropertyAddress, BGUSetTressFXAssetAndMaterial_FunctionAddress, "Asset");
		BGUSetTressFXAssetAndMaterial_Asset_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTressFXAssetAndMaterial_FunctionAddress, "Asset");
		BGUSetTressFXAssetAndMaterial_Asset_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTressFXAssetAndMaterial_FunctionAddress, "Asset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetTressFXAssetAndMaterial_Material_PropertyAddress, BGUSetTressFXAssetAndMaterial_FunctionAddress, "Material");
		BGUSetTressFXAssetAndMaterial_Material_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetTressFXAssetAndMaterial_FunctionAddress, "Material");
		BGUSetTressFXAssetAndMaterial_Material_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetTressFXAssetAndMaterial_FunctionAddress, "Material", Classes.FObjectProperty);
		BGUSetTressFXAssetAndMaterial_IsValid = BGUSetTressFXAssetAndMaterial_FunctionAddress != IntPtr.Zero && BGUSetTressFXAssetAndMaterial_TFXComp_IsValid && BGUSetTressFXAssetAndMaterial_Asset_IsValid && BGUSetTressFXAssetAndMaterial_Material_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUSetTressFXAssetAndMaterial", BGUSetTressFXAssetAndMaterial_IsValid);
		BGUSetLinearColorParameterValueToMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetLinearColorParameterValueToMesh");
		BGUSetLinearColorParameterValueToMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetLinearColorParameterValueToMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetLinearColorParameterValueToMesh_MeshInst_PropertyAddress, BGUSetLinearColorParameterValueToMesh_FunctionAddress, "MeshInst");
		BGUSetLinearColorParameterValueToMesh_MeshInst_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetLinearColorParameterValueToMesh_FunctionAddress, "MeshInst");
		BGUSetLinearColorParameterValueToMesh_MeshInst_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetLinearColorParameterValueToMesh_FunctionAddress, "MeshInst", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetLinearColorParameterValueToMesh_ParameterName_PropertyAddress, BGUSetLinearColorParameterValueToMesh_FunctionAddress, "ParameterName");
		BGUSetLinearColorParameterValueToMesh_ParameterName_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetLinearColorParameterValueToMesh_FunctionAddress, "ParameterName");
		BGUSetLinearColorParameterValueToMesh_ParameterName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetLinearColorParameterValueToMesh_FunctionAddress, "ParameterName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetLinearColorParameterValueToMesh_LinearColorParameterValue_PropertyAddress, BGUSetLinearColorParameterValueToMesh_FunctionAddress, "LinearColorParameterValue");
		BGUSetLinearColorParameterValueToMesh_LinearColorParameterValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetLinearColorParameterValueToMesh_FunctionAddress, "LinearColorParameterValue");
		BGUSetLinearColorParameterValueToMesh_LinearColorParameterValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetLinearColorParameterValueToMesh_FunctionAddress, "LinearColorParameterValue", Classes.FStructProperty);
		BGUSetLinearColorParameterValueToMesh_IsValid = BGUSetLinearColorParameterValueToMesh_FunctionAddress != IntPtr.Zero && BGUSetLinearColorParameterValueToMesh_MeshInst_IsValid && BGUSetLinearColorParameterValueToMesh_ParameterName_IsValid && BGUSetLinearColorParameterValueToMesh_LinearColorParameterValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUSetLinearColorParameterValueToMesh", BGUSetLinearColorParameterValueToMesh_IsValid);
		BGUSetEnableGravity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetEnableGravity");
		BGUSetEnableGravity_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetEnableGravity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetEnableGravity_TargetMesh_PropertyAddress, BGUSetEnableGravity_FunctionAddress, "TargetMesh");
		BGUSetEnableGravity_TargetMesh_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetEnableGravity_FunctionAddress, "TargetMesh");
		BGUSetEnableGravity_TargetMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetEnableGravity_FunctionAddress, "TargetMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetEnableGravity_bEnableGravity_PropertyAddress, BGUSetEnableGravity_FunctionAddress, "bEnableGravity");
		BGUSetEnableGravity_bEnableGravity_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetEnableGravity_FunctionAddress, "bEnableGravity");
		BGUSetEnableGravity_bEnableGravity_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetEnableGravity_FunctionAddress, "bEnableGravity", Classes.FBoolProperty);
		BGUSetEnableGravity_IsValid = BGUSetEnableGravity_FunctionAddress != IntPtr.Zero && BGUSetEnableGravity_TargetMesh_IsValid && BGUSetEnableGravity_bEnableGravity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUSetEnableGravity", BGUSetEnableGravity_IsValid);
		BGUSetActiveMontagePosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSetActiveMontagePosition");
		BGUSetActiveMontagePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSetActiveMontagePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSetActiveMontagePosition_Character_PropertyAddress, BGUSetActiveMontagePosition_FunctionAddress, "Character");
		BGUSetActiveMontagePosition_Character_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetActiveMontagePosition_FunctionAddress, "Character");
		BGUSetActiveMontagePosition_Character_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetActiveMontagePosition_FunctionAddress, "Character", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetActiveMontagePosition_Montage_PropertyAddress, BGUSetActiveMontagePosition_FunctionAddress, "Montage");
		BGUSetActiveMontagePosition_Montage_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetActiveMontagePosition_FunctionAddress, "Montage");
		BGUSetActiveMontagePosition_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetActiveMontagePosition_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetActiveMontagePosition_Position_PropertyAddress, BGUSetActiveMontagePosition_FunctionAddress, "Position");
		BGUSetActiveMontagePosition_Position_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetActiveMontagePosition_FunctionAddress, "Position");
		BGUSetActiveMontagePosition_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetActiveMontagePosition_FunctionAddress, "Position", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSetActiveMontagePosition_ReturnValue_PropertyAddress, BGUSetActiveMontagePosition_FunctionAddress, "ReturnValue");
		BGUSetActiveMontagePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUSetActiveMontagePosition_FunctionAddress, "ReturnValue");
		BGUSetActiveMontagePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSetActiveMontagePosition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUSetActiveMontagePosition_IsValid = BGUSetActiveMontagePosition_FunctionAddress != IntPtr.Zero && BGUSetActiveMontagePosition_Character_IsValid && BGUSetActiveMontagePosition_Montage_IsValid && BGUSetActiveMontagePosition_Position_IsValid && BGUSetActiveMontagePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUSetActiveMontagePosition", BGUSetActiveMontagePosition_IsValid);
		BGUSeparatingAxisPointCheck_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSeparatingAxisPointCheck");
		BGUSeparatingAxisPointCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSeparatingAxisPointCheck_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSeparatingAxisPointCheck_InPolyVertices_PropertyAddress, BGUSeparatingAxisPointCheck_FunctionAddress, "InPolyVertices");
		BGUSeparatingAxisPointCheck_InPolyVertices_Offset = NativeReflectionCached.GetPropertyOffset(BGUSeparatingAxisPointCheck_FunctionAddress, "InPolyVertices");
		BGUSeparatingAxisPointCheck_InPolyVertices_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSeparatingAxisPointCheck_FunctionAddress, "InPolyVertices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSeparatingAxisPointCheck_InBoxCenter_PropertyAddress, BGUSeparatingAxisPointCheck_FunctionAddress, "InBoxCenter");
		BGUSeparatingAxisPointCheck_InBoxCenter_Offset = NativeReflectionCached.GetPropertyOffset(BGUSeparatingAxisPointCheck_FunctionAddress, "InBoxCenter");
		BGUSeparatingAxisPointCheck_InBoxCenter_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSeparatingAxisPointCheck_FunctionAddress, "InBoxCenter", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSeparatingAxisPointCheck_InBoxExtent_PropertyAddress, BGUSeparatingAxisPointCheck_FunctionAddress, "InBoxExtent");
		BGUSeparatingAxisPointCheck_InBoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(BGUSeparatingAxisPointCheck_FunctionAddress, "InBoxExtent");
		BGUSeparatingAxisPointCheck_InBoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSeparatingAxisPointCheck_FunctionAddress, "InBoxExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSeparatingAxisPointCheck_bInCalcLeastPenetration_PropertyAddress, BGUSeparatingAxisPointCheck_FunctionAddress, "bInCalcLeastPenetration");
		BGUSeparatingAxisPointCheck_bInCalcLeastPenetration_Offset = NativeReflectionCached.GetPropertyOffset(BGUSeparatingAxisPointCheck_FunctionAddress, "bInCalcLeastPenetration");
		BGUSeparatingAxisPointCheck_bInCalcLeastPenetration_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSeparatingAxisPointCheck_FunctionAddress, "bInCalcLeastPenetration", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSeparatingAxisPointCheck_ReturnValue_PropertyAddress, BGUSeparatingAxisPointCheck_FunctionAddress, "ReturnValue");
		BGUSeparatingAxisPointCheck_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUSeparatingAxisPointCheck_FunctionAddress, "ReturnValue");
		BGUSeparatingAxisPointCheck_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSeparatingAxisPointCheck_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUSeparatingAxisPointCheck_IsValid = BGUSeparatingAxisPointCheck_FunctionAddress != IntPtr.Zero && BGUSeparatingAxisPointCheck_InPolyVertices_IsValid && BGUSeparatingAxisPointCheck_InBoxCenter_IsValid && BGUSeparatingAxisPointCheck_InBoxExtent_IsValid && BGUSeparatingAxisPointCheck_bInCalcLeastPenetration_IsValid && BGUSeparatingAxisPointCheck_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUSeparatingAxisPointCheck", BGUSeparatingAxisPointCheck_IsValid);
		BGUSaveUnitAttrToFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUSaveUnitAttrToFile");
		BGUSaveUnitAttrToFile_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUSaveUnitAttrToFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUSaveUnitAttrToFile_Name_PropertyAddress, BGUSaveUnitAttrToFile_FunctionAddress, "Name");
		BGUSaveUnitAttrToFile_Name_Offset = NativeReflectionCached.GetPropertyOffset(BGUSaveUnitAttrToFile_FunctionAddress, "Name");
		BGUSaveUnitAttrToFile_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSaveUnitAttrToFile_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSaveUnitAttrToFile_Text_PropertyAddress, BGUSaveUnitAttrToFile_FunctionAddress, "Text");
		BGUSaveUnitAttrToFile_Text_Offset = NativeReflectionCached.GetPropertyOffset(BGUSaveUnitAttrToFile_FunctionAddress, "Text");
		BGUSaveUnitAttrToFile_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSaveUnitAttrToFile_FunctionAddress, "Text", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUSaveUnitAttrToFile_Overwrite_PropertyAddress, BGUSaveUnitAttrToFile_FunctionAddress, "Overwrite");
		BGUSaveUnitAttrToFile_Overwrite_Offset = NativeReflectionCached.GetPropertyOffset(BGUSaveUnitAttrToFile_FunctionAddress, "Overwrite");
		BGUSaveUnitAttrToFile_Overwrite_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUSaveUnitAttrToFile_FunctionAddress, "Overwrite", Classes.FBoolProperty);
		BGUSaveUnitAttrToFile_IsValid = BGUSaveUnitAttrToFile_FunctionAddress != IntPtr.Zero && BGUSaveUnitAttrToFile_Name_IsValid && BGUSaveUnitAttrToFile_Text_IsValid && BGUSaveUnitAttrToFile_Overwrite_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUSaveUnitAttrToFile", BGUSaveUnitAttrToFile_IsValid);
		BGUResetToDefaultBoomCameraLagSpeed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUResetToDefaultBoomCameraLagSpeed");
		BGUResetToDefaultBoomCameraLagSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUResetToDefaultBoomCameraLagSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUResetToDefaultBoomCameraLagSpeed_PlayerCharacter_PropertyAddress, BGUResetToDefaultBoomCameraLagSpeed_FunctionAddress, "PlayerCharacter");
		BGUResetToDefaultBoomCameraLagSpeed_PlayerCharacter_Offset = NativeReflectionCached.GetPropertyOffset(BGUResetToDefaultBoomCameraLagSpeed_FunctionAddress, "PlayerCharacter");
		BGUResetToDefaultBoomCameraLagSpeed_PlayerCharacter_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUResetToDefaultBoomCameraLagSpeed_FunctionAddress, "PlayerCharacter", Classes.FObjectProperty);
		BGUResetToDefaultBoomCameraLagSpeed_IsValid = BGUResetToDefaultBoomCameraLagSpeed_FunctionAddress != IntPtr.Zero && BGUResetToDefaultBoomCameraLagSpeed_PlayerCharacter_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUResetToDefaultBoomCameraLagSpeed", BGUResetToDefaultBoomCameraLagSpeed_IsValid);
		BGUResetGeometryCollectionComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUResetGeometryCollectionComponent");
		BGUResetGeometryCollectionComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUResetGeometryCollectionComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUResetGeometryCollectionComponent_GeometryCollectionComponent_PropertyAddress, BGUResetGeometryCollectionComponent_FunctionAddress, "GeometryCollectionComponent");
		BGUResetGeometryCollectionComponent_GeometryCollectionComponent_Offset = NativeReflectionCached.GetPropertyOffset(BGUResetGeometryCollectionComponent_FunctionAddress, "GeometryCollectionComponent");
		BGUResetGeometryCollectionComponent_GeometryCollectionComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUResetGeometryCollectionComponent_FunctionAddress, "GeometryCollectionComponent", Classes.FObjectProperty);
		BGUResetGeometryCollectionComponent_IsValid = BGUResetGeometryCollectionComponent_FunctionAddress != IntPtr.Zero && BGUResetGeometryCollectionComponent_GeometryCollectionComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUResetGeometryCollectionComponent", BGUResetGeometryCollectionComponent_IsValid);
		BGUResetActorVelocity_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUResetActorVelocity");
		BGUResetActorVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUResetActorVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUResetActorVelocity_Actor_PropertyAddress, BGUResetActorVelocity_FunctionAddress, "Actor");
		BGUResetActorVelocity_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BGUResetActorVelocity_FunctionAddress, "Actor");
		BGUResetActorVelocity_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUResetActorVelocity_FunctionAddress, "Actor", Classes.FObjectProperty);
		BGUResetActorVelocity_IsValid = BGUResetActorVelocity_FunctionAddress != IntPtr.Zero && BGUResetActorVelocity_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUResetActorVelocity", BGUResetActorVelocity_IsValid);
		BGURenameActorComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGURenameActorComponent");
		BGURenameActorComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGURenameActorComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGURenameActorComponent_Comp_PropertyAddress, BGURenameActorComponent_FunctionAddress, "Comp");
		BGURenameActorComponent_Comp_Offset = NativeReflectionCached.GetPropertyOffset(BGURenameActorComponent_FunctionAddress, "Comp");
		BGURenameActorComponent_Comp_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURenameActorComponent_FunctionAddress, "Comp", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGURenameActorComponent_NewName_PropertyAddress, BGURenameActorComponent_FunctionAddress, "NewName");
		BGURenameActorComponent_NewName_Offset = NativeReflectionCached.GetPropertyOffset(BGURenameActorComponent_FunctionAddress, "NewName");
		BGURenameActorComponent_NewName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGURenameActorComponent_FunctionAddress, "NewName", Classes.FStrProperty);
		BGURenameActorComponent_IsValid = BGURenameActorComponent_FunctionAddress != IntPtr.Zero && BGURenameActorComponent_Comp_IsValid && BGURenameActorComponent_NewName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGURenameActorComponent", BGURenameActorComponent_IsValid);
		BGUProjectPointToNavigation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUProjectPointToNavigation");
		BGUProjectPointToNavigation_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUProjectPointToNavigation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUProjectPointToNavigation_WorldContextObject_PropertyAddress, BGUProjectPointToNavigation_FunctionAddress, "WorldContextObject");
		BGUProjectPointToNavigation_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUProjectPointToNavigation_FunctionAddress, "WorldContextObject");
		BGUProjectPointToNavigation_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUProjectPointToNavigation_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUProjectPointToNavigation_Point_PropertyAddress, BGUProjectPointToNavigation_FunctionAddress, "Point");
		BGUProjectPointToNavigation_Point_Offset = NativeReflectionCached.GetPropertyOffset(BGUProjectPointToNavigation_FunctionAddress, "Point");
		BGUProjectPointToNavigation_Point_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUProjectPointToNavigation_FunctionAddress, "Point", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUProjectPointToNavigation_ProjectedLocation_PropertyAddress, BGUProjectPointToNavigation_FunctionAddress, "ProjectedLocation");
		BGUProjectPointToNavigation_ProjectedLocation_Offset = NativeReflectionCached.GetPropertyOffset(BGUProjectPointToNavigation_FunctionAddress, "ProjectedLocation");
		BGUProjectPointToNavigation_ProjectedLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUProjectPointToNavigation_FunctionAddress, "ProjectedLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUProjectPointToNavigation_NavData_PropertyAddress, BGUProjectPointToNavigation_FunctionAddress, "NavData");
		BGUProjectPointToNavigation_NavData_Offset = NativeReflectionCached.GetPropertyOffset(BGUProjectPointToNavigation_FunctionAddress, "NavData");
		BGUProjectPointToNavigation_NavData_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUProjectPointToNavigation_FunctionAddress, "NavData", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUProjectPointToNavigation_FilterClass_PropertyAddress, BGUProjectPointToNavigation_FunctionAddress, "FilterClass");
		BGUProjectPointToNavigation_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(BGUProjectPointToNavigation_FunctionAddress, "FilterClass");
		BGUProjectPointToNavigation_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUProjectPointToNavigation_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUProjectPointToNavigation_QueryExtent_PropertyAddress, BGUProjectPointToNavigation_FunctionAddress, "QueryExtent");
		BGUProjectPointToNavigation_QueryExtent_Offset = NativeReflectionCached.GetPropertyOffset(BGUProjectPointToNavigation_FunctionAddress, "QueryExtent");
		BGUProjectPointToNavigation_QueryExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUProjectPointToNavigation_FunctionAddress, "QueryExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUProjectPointToNavigation_ReturnValue_PropertyAddress, BGUProjectPointToNavigation_FunctionAddress, "ReturnValue");
		BGUProjectPointToNavigation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUProjectPointToNavigation_FunctionAddress, "ReturnValue");
		BGUProjectPointToNavigation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUProjectPointToNavigation_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUProjectPointToNavigation_IsValid = BGUProjectPointToNavigation_FunctionAddress != IntPtr.Zero && BGUProjectPointToNavigation_WorldContextObject_IsValid && BGUProjectPointToNavigation_Point_IsValid && BGUProjectPointToNavigation_ProjectedLocation_IsValid && BGUProjectPointToNavigation_NavData_IsValid && BGUProjectPointToNavigation_FilterClass_IsValid && BGUProjectPointToNavigation_QueryExtent_IsValid && BGUProjectPointToNavigation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUProjectPointToNavigation", BGUProjectPointToNavigation_IsValid);
		BGUProcessLatentActions_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUProcessLatentActions");
		BGUProcessLatentActions_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUProcessLatentActions_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUProcessLatentActions_WorldContextObject_PropertyAddress, BGUProcessLatentActions_FunctionAddress, "WorldContextObject");
		BGUProcessLatentActions_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUProcessLatentActions_FunctionAddress, "WorldContextObject");
		BGUProcessLatentActions_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUProcessLatentActions_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUProcessLatentActions_InObject_PropertyAddress, BGUProcessLatentActions_FunctionAddress, "InObject");
		BGUProcessLatentActions_InObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUProcessLatentActions_FunctionAddress, "InObject");
		BGUProcessLatentActions_InObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUProcessLatentActions_FunctionAddress, "InObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUProcessLatentActions_DeltaTime_PropertyAddress, BGUProcessLatentActions_FunctionAddress, "DeltaTime");
		BGUProcessLatentActions_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(BGUProcessLatentActions_FunctionAddress, "DeltaTime");
		BGUProcessLatentActions_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUProcessLatentActions_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		BGUProcessLatentActions_IsValid = BGUProcessLatentActions_FunctionAddress != IntPtr.Zero && BGUProcessLatentActions_WorldContextObject_IsValid && BGUProcessLatentActions_InObject_IsValid && BGUProcessLatentActions_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUProcessLatentActions", BGUProcessLatentActions_IsValid);
		BGUPlayerCtrlerGetViewPoint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUPlayerCtrlerGetViewPoint");
		BGUPlayerCtrlerGetViewPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUPlayerCtrlerGetViewPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUPlayerCtrlerGetViewPoint_PlayerCtrler_PropertyAddress, BGUPlayerCtrlerGetViewPoint_FunctionAddress, "PlayerCtrler");
		BGUPlayerCtrlerGetViewPoint_PlayerCtrler_Offset = NativeReflectionCached.GetPropertyOffset(BGUPlayerCtrlerGetViewPoint_FunctionAddress, "PlayerCtrler");
		BGUPlayerCtrlerGetViewPoint_PlayerCtrler_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUPlayerCtrlerGetViewPoint_FunctionAddress, "PlayerCtrler", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUPlayerCtrlerGetViewPoint_out_Location_PropertyAddress, BGUPlayerCtrlerGetViewPoint_FunctionAddress, "out_Location");
		BGUPlayerCtrlerGetViewPoint_out_Location_Offset = NativeReflectionCached.GetPropertyOffset(BGUPlayerCtrlerGetViewPoint_FunctionAddress, "out_Location");
		BGUPlayerCtrlerGetViewPoint_out_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUPlayerCtrlerGetViewPoint_FunctionAddress, "out_Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUPlayerCtrlerGetViewPoint_out_Rotation_PropertyAddress, BGUPlayerCtrlerGetViewPoint_FunctionAddress, "out_Rotation");
		BGUPlayerCtrlerGetViewPoint_out_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(BGUPlayerCtrlerGetViewPoint_FunctionAddress, "out_Rotation");
		BGUPlayerCtrlerGetViewPoint_out_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUPlayerCtrlerGetViewPoint_FunctionAddress, "out_Rotation", Classes.FStructProperty);
		BGUPlayerCtrlerGetViewPoint_IsValid = BGUPlayerCtrlerGetViewPoint_FunctionAddress != IntPtr.Zero && BGUPlayerCtrlerGetViewPoint_PlayerCtrler_IsValid && BGUPlayerCtrlerGetViewPoint_out_Location_IsValid && BGUPlayerCtrlerGetViewPoint_out_Rotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUPlayerCtrlerGetViewPoint", BGUPlayerCtrlerGetViewPoint_IsValid);
		BGUPerlinNoise1D_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUPerlinNoise1D");
		BGUPerlinNoise1D_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUPerlinNoise1D_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUPerlinNoise1D_Value_PropertyAddress, BGUPerlinNoise1D_FunctionAddress, "Value");
		BGUPerlinNoise1D_Value_Offset = NativeReflectionCached.GetPropertyOffset(BGUPerlinNoise1D_FunctionAddress, "Value");
		BGUPerlinNoise1D_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUPerlinNoise1D_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUPerlinNoise1D_ReturnValue_PropertyAddress, BGUPerlinNoise1D_FunctionAddress, "ReturnValue");
		BGUPerlinNoise1D_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUPerlinNoise1D_FunctionAddress, "ReturnValue");
		BGUPerlinNoise1D_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUPerlinNoise1D_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUPerlinNoise1D_IsValid = BGUPerlinNoise1D_FunctionAddress != IntPtr.Zero && BGUPerlinNoise1D_Value_IsValid && BGUPerlinNoise1D_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUPerlinNoise1D", BGUPerlinNoise1D_IsValid);
		BGUNavigationRaycast_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUNavigationRaycast");
		BGUNavigationRaycast_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUNavigationRaycast_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationRaycast_WorldContextObject_PropertyAddress, BGUNavigationRaycast_FunctionAddress, "WorldContextObject");
		BGUNavigationRaycast_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationRaycast_FunctionAddress, "WorldContextObject");
		BGUNavigationRaycast_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationRaycast_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationRaycast_RayStart_PropertyAddress, BGUNavigationRaycast_FunctionAddress, "RayStart");
		BGUNavigationRaycast_RayStart_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationRaycast_FunctionAddress, "RayStart");
		BGUNavigationRaycast_RayStart_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationRaycast_FunctionAddress, "RayStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationRaycast_RayEnd_PropertyAddress, BGUNavigationRaycast_FunctionAddress, "RayEnd");
		BGUNavigationRaycast_RayEnd_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationRaycast_FunctionAddress, "RayEnd");
		BGUNavigationRaycast_RayEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationRaycast_FunctionAddress, "RayEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationRaycast_HitLocation_PropertyAddress, BGUNavigationRaycast_FunctionAddress, "HitLocation");
		BGUNavigationRaycast_HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationRaycast_FunctionAddress, "HitLocation");
		BGUNavigationRaycast_HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationRaycast_FunctionAddress, "HitLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationRaycast_FilterClass_PropertyAddress, BGUNavigationRaycast_FunctionAddress, "FilterClass");
		BGUNavigationRaycast_FilterClass_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationRaycast_FunctionAddress, "FilterClass");
		BGUNavigationRaycast_FilterClass_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationRaycast_FunctionAddress, "FilterClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationRaycast_Querier_PropertyAddress, BGUNavigationRaycast_FunctionAddress, "Querier");
		BGUNavigationRaycast_Querier_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationRaycast_FunctionAddress, "Querier");
		BGUNavigationRaycast_Querier_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationRaycast_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationRaycast_ReturnValue_PropertyAddress, BGUNavigationRaycast_FunctionAddress, "ReturnValue");
		BGUNavigationRaycast_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationRaycast_FunctionAddress, "ReturnValue");
		BGUNavigationRaycast_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationRaycast_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUNavigationRaycast_IsValid = BGUNavigationRaycast_FunctionAddress != IntPtr.Zero && BGUNavigationRaycast_WorldContextObject_IsValid && BGUNavigationRaycast_RayStart_IsValid && BGUNavigationRaycast_RayEnd_IsValid && BGUNavigationRaycast_HitLocation_IsValid && BGUNavigationRaycast_FilterClass_IsValid && BGUNavigationRaycast_Querier_IsValid && BGUNavigationRaycast_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUNavigationRaycast", BGUNavigationRaycast_IsValid);
		BGUNavigationCalPathCost_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUNavigationCalPathCost");
		BGUNavigationCalPathCost_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUNavigationCalPathCost_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationCalPathCost_WorldContextObject_PropertyAddress, BGUNavigationCalPathCost_FunctionAddress, "WorldContextObject");
		BGUNavigationCalPathCost_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationCalPathCost_FunctionAddress, "WorldContextObject");
		BGUNavigationCalPathCost_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationCalPathCost_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationCalPathCost_PathStart_PropertyAddress, BGUNavigationCalPathCost_FunctionAddress, "PathStart");
		BGUNavigationCalPathCost_PathStart_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationCalPathCost_FunctionAddress, "PathStart");
		BGUNavigationCalPathCost_PathStart_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationCalPathCost_FunctionAddress, "PathStart", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationCalPathCost_PathEnd_PropertyAddress, BGUNavigationCalPathCost_FunctionAddress, "PathEnd");
		BGUNavigationCalPathCost_PathEnd_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationCalPathCost_FunctionAddress, "PathEnd");
		BGUNavigationCalPathCost_PathEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationCalPathCost_FunctionAddress, "PathEnd", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationCalPathCost_PathCost_PropertyAddress, BGUNavigationCalPathCost_FunctionAddress, "PathCost");
		BGUNavigationCalPathCost_PathCost_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationCalPathCost_FunctionAddress, "PathCost");
		BGUNavigationCalPathCost_PathCost_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationCalPathCost_FunctionAddress, "PathCost", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUNavigationCalPathCost_Querier_PropertyAddress, BGUNavigationCalPathCost_FunctionAddress, "Querier");
		BGUNavigationCalPathCost_Querier_Offset = NativeReflectionCached.GetPropertyOffset(BGUNavigationCalPathCost_FunctionAddress, "Querier");
		BGUNavigationCalPathCost_Querier_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUNavigationCalPathCost_FunctionAddress, "Querier", Classes.FObjectProperty);
		BGUNavigationCalPathCost_IsValid = BGUNavigationCalPathCost_FunctionAddress != IntPtr.Zero && BGUNavigationCalPathCost_WorldContextObject_IsValid && BGUNavigationCalPathCost_PathStart_IsValid && BGUNavigationCalPathCost_PathEnd_IsValid && BGUNavigationCalPathCost_PathCost_IsValid && BGUNavigationCalPathCost_Querier_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUNavigationCalPathCost", BGUNavigationCalPathCost_IsValid);
		BGUMergeSkeletalMesh_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUMergeSkeletalMesh");
		BGUMergeSkeletalMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUMergeSkeletalMesh_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUMergeSkeletalMesh_InMergeMesh_PropertyAddress, BGUMergeSkeletalMesh_FunctionAddress, "InMergeMesh");
		BGUMergeSkeletalMesh_InMergeMesh_Offset = NativeReflectionCached.GetPropertyOffset(BGUMergeSkeletalMesh_FunctionAddress, "InMergeMesh");
		BGUMergeSkeletalMesh_InMergeMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMergeSkeletalMesh_FunctionAddress, "InMergeMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMergeSkeletalMesh_InSrcMeshList_PropertyAddress, BGUMergeSkeletalMesh_FunctionAddress, "InSrcMeshList");
		BGUMergeSkeletalMesh_InSrcMeshList_Offset = NativeReflectionCached.GetPropertyOffset(BGUMergeSkeletalMesh_FunctionAddress, "InSrcMeshList");
		BGUMergeSkeletalMesh_InSrcMeshList_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMergeSkeletalMesh_FunctionAddress, "InSrcMeshList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMergeSkeletalMesh_StripTopLODs_PropertyAddress, BGUMergeSkeletalMesh_FunctionAddress, "StripTopLODs");
		BGUMergeSkeletalMesh_StripTopLODs_Offset = NativeReflectionCached.GetPropertyOffset(BGUMergeSkeletalMesh_FunctionAddress, "StripTopLODs");
		BGUMergeSkeletalMesh_StripTopLODs_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMergeSkeletalMesh_FunctionAddress, "StripTopLODs", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMergeSkeletalMesh_MeshBufferAccess_PropertyAddress, BGUMergeSkeletalMesh_FunctionAddress, "MeshBufferAccess");
		BGUMergeSkeletalMesh_MeshBufferAccess_Offset = NativeReflectionCached.GetPropertyOffset(BGUMergeSkeletalMesh_FunctionAddress, "MeshBufferAccess");
		BGUMergeSkeletalMesh_MeshBufferAccess_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMergeSkeletalMesh_FunctionAddress, "MeshBufferAccess", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUMergeSkeletalMesh_ReturnValue_PropertyAddress, BGUMergeSkeletalMesh_FunctionAddress, "ReturnValue");
		BGUMergeSkeletalMesh_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUMergeSkeletalMesh_FunctionAddress, "ReturnValue");
		BGUMergeSkeletalMesh_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUMergeSkeletalMesh_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUMergeSkeletalMesh_IsValid = BGUMergeSkeletalMesh_FunctionAddress != IntPtr.Zero && BGUMergeSkeletalMesh_InMergeMesh_IsValid && BGUMergeSkeletalMesh_InSrcMeshList_IsValid && BGUMergeSkeletalMesh_StripTopLODs_IsValid && BGUMergeSkeletalMesh_MeshBufferAccess_IsValid && BGUMergeSkeletalMesh_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUMergeSkeletalMesh", BGUMergeSkeletalMesh_IsValid);
		BGULoadStreamLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGULoadStreamLevel");
		BGULoadStreamLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(BGULoadStreamLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGULoadStreamLevel_WorldContextObject_PropertyAddress, BGULoadStreamLevel_FunctionAddress, "WorldContextObject");
		BGULoadStreamLevel_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGULoadStreamLevel_FunctionAddress, "WorldContextObject");
		BGULoadStreamLevel_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULoadStreamLevel_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULoadStreamLevel_LevelName_PropertyAddress, BGULoadStreamLevel_FunctionAddress, "LevelName");
		BGULoadStreamLevel_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(BGULoadStreamLevel_FunctionAddress, "LevelName");
		BGULoadStreamLevel_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULoadStreamLevel_FunctionAddress, "LevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULoadStreamLevel_bMakeVisibleAfterLoad_PropertyAddress, BGULoadStreamLevel_FunctionAddress, "bMakeVisibleAfterLoad");
		BGULoadStreamLevel_bMakeVisibleAfterLoad_Offset = NativeReflectionCached.GetPropertyOffset(BGULoadStreamLevel_FunctionAddress, "bMakeVisibleAfterLoad");
		BGULoadStreamLevel_bMakeVisibleAfterLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULoadStreamLevel_FunctionAddress, "bMakeVisibleAfterLoad", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULoadStreamLevel_bShouldBlockOnLoad_PropertyAddress, BGULoadStreamLevel_FunctionAddress, "bShouldBlockOnLoad");
		BGULoadStreamLevel_bShouldBlockOnLoad_Offset = NativeReflectionCached.GetPropertyOffset(BGULoadStreamLevel_FunctionAddress, "bShouldBlockOnLoad");
		BGULoadStreamLevel_bShouldBlockOnLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULoadStreamLevel_FunctionAddress, "bShouldBlockOnLoad", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULoadStreamLevel_CallbackTarget_PropertyAddress, BGULoadStreamLevel_FunctionAddress, "CallbackTarget");
		BGULoadStreamLevel_CallbackTarget_Offset = NativeReflectionCached.GetPropertyOffset(BGULoadStreamLevel_FunctionAddress, "CallbackTarget");
		BGULoadStreamLevel_CallbackTarget_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULoadStreamLevel_FunctionAddress, "CallbackTarget", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULoadStreamLevel_CallbackFunc_PropertyAddress, BGULoadStreamLevel_FunctionAddress, "CallbackFunc");
		BGULoadStreamLevel_CallbackFunc_Offset = NativeReflectionCached.GetPropertyOffset(BGULoadStreamLevel_FunctionAddress, "CallbackFunc");
		BGULoadStreamLevel_CallbackFunc_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULoadStreamLevel_FunctionAddress, "CallbackFunc", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULoadStreamLevel_ActionID_PropertyAddress, BGULoadStreamLevel_FunctionAddress, "ActionID");
		BGULoadStreamLevel_ActionID_Offset = NativeReflectionCached.GetPropertyOffset(BGULoadStreamLevel_FunctionAddress, "ActionID");
		BGULoadStreamLevel_ActionID_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULoadStreamLevel_FunctionAddress, "ActionID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGULoadStreamLevel_Linkage_PropertyAddress, BGULoadStreamLevel_FunctionAddress, "Linkage");
		BGULoadStreamLevel_Linkage_Offset = NativeReflectionCached.GetPropertyOffset(BGULoadStreamLevel_FunctionAddress, "Linkage");
		BGULoadStreamLevel_Linkage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGULoadStreamLevel_FunctionAddress, "Linkage", Classes.FIntProperty);
		BGULoadStreamLevel_IsValid = BGULoadStreamLevel_FunctionAddress != IntPtr.Zero && BGULoadStreamLevel_WorldContextObject_IsValid && BGULoadStreamLevel_LevelName_IsValid && BGULoadStreamLevel_bMakeVisibleAfterLoad_IsValid && BGULoadStreamLevel_bShouldBlockOnLoad_IsValid && BGULoadStreamLevel_CallbackTarget_IsValid && BGULoadStreamLevel_CallbackFunc_IsValid && BGULoadStreamLevel_ActionID_IsValid && BGULoadStreamLevel_Linkage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGULoadStreamLevel", BGULoadStreamLevel_IsValid);
		BGUIsExistFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUIsExistFile");
		BGUIsExistFile_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUIsExistFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUIsExistFile_path_PropertyAddress, BGUIsExistFile_FunctionAddress, "path");
		BGUIsExistFile_path_Offset = NativeReflectionCached.GetPropertyOffset(BGUIsExistFile_FunctionAddress, "path");
		BGUIsExistFile_path_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUIsExistFile_FunctionAddress, "path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUIsExistFile_ReturnValue_PropertyAddress, BGUIsExistFile_FunctionAddress, "ReturnValue");
		BGUIsExistFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUIsExistFile_FunctionAddress, "ReturnValue");
		BGUIsExistFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUIsExistFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUIsExistFile_IsValid = BGUIsExistFile_FunctionAddress != IntPtr.Zero && BGUIsExistFile_path_IsValid && BGUIsExistFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUIsExistFile", BGUIsExistFile_IsValid);
		BGUHasFuncName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUHasFuncName");
		BGUHasFuncName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUHasFuncName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUHasFuncName_FuncName_PropertyAddress, BGUHasFuncName_FunctionAddress, "FuncName");
		BGUHasFuncName_FuncName_Offset = NativeReflectionCached.GetPropertyOffset(BGUHasFuncName_FunctionAddress, "FuncName");
		BGUHasFuncName_FuncName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUHasFuncName_FunctionAddress, "FuncName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUHasFuncName_Object_PropertyAddress, BGUHasFuncName_FunctionAddress, "Object");
		BGUHasFuncName_Object_Offset = NativeReflectionCached.GetPropertyOffset(BGUHasFuncName_FunctionAddress, "Object");
		BGUHasFuncName_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUHasFuncName_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUHasFuncName_StopAtClass_PropertyAddress, BGUHasFuncName_FunctionAddress, "StopAtClass");
		BGUHasFuncName_StopAtClass_Offset = NativeReflectionCached.GetPropertyOffset(BGUHasFuncName_FunctionAddress, "StopAtClass");
		BGUHasFuncName_StopAtClass_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUHasFuncName_FunctionAddress, "StopAtClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUHasFuncName_ReturnValue_PropertyAddress, BGUHasFuncName_FunctionAddress, "ReturnValue");
		BGUHasFuncName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUHasFuncName_FunctionAddress, "ReturnValue");
		BGUHasFuncName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUHasFuncName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUHasFuncName_IsValid = BGUHasFuncName_FunctionAddress != IntPtr.Zero && BGUHasFuncName_FuncName_IsValid && BGUHasFuncName_Object_IsValid && BGUHasFuncName_StopAtClass_IsValid && BGUHasFuncName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUHasFuncName", BGUHasFuncName_IsValid);
		BGUGetWindParameters_GameThread_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetWindParameters_GameThread");
		BGUGetWindParameters_GameThread_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetWindParameters_GameThread_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetWindParameters_GameThread_WorldContext_PropertyAddress, BGUGetWindParameters_GameThread_FunctionAddress, "WorldContext");
		BGUGetWindParameters_GameThread_WorldContext_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetWindParameters_GameThread_FunctionAddress, "WorldContext");
		BGUGetWindParameters_GameThread_WorldContext_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetWindParameters_GameThread_FunctionAddress, "WorldContext", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetWindParameters_GameThread_Position_PropertyAddress, BGUGetWindParameters_GameThread_FunctionAddress, "Position");
		BGUGetWindParameters_GameThread_Position_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetWindParameters_GameThread_FunctionAddress, "Position");
		BGUGetWindParameters_GameThread_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetWindParameters_GameThread_FunctionAddress, "Position", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetWindParameters_GameThread_OutDirection_PropertyAddress, BGUGetWindParameters_GameThread_FunctionAddress, "OutDirection");
		BGUGetWindParameters_GameThread_OutDirection_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetWindParameters_GameThread_FunctionAddress, "OutDirection");
		BGUGetWindParameters_GameThread_OutDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetWindParameters_GameThread_FunctionAddress, "OutDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetWindParameters_GameThread_OutSpeed_PropertyAddress, BGUGetWindParameters_GameThread_FunctionAddress, "OutSpeed");
		BGUGetWindParameters_GameThread_OutSpeed_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetWindParameters_GameThread_FunctionAddress, "OutSpeed");
		BGUGetWindParameters_GameThread_OutSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetWindParameters_GameThread_FunctionAddress, "OutSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetWindParameters_GameThread_OutMinGustAmt_PropertyAddress, BGUGetWindParameters_GameThread_FunctionAddress, "OutMinGustAmt");
		BGUGetWindParameters_GameThread_OutMinGustAmt_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetWindParameters_GameThread_FunctionAddress, "OutMinGustAmt");
		BGUGetWindParameters_GameThread_OutMinGustAmt_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetWindParameters_GameThread_FunctionAddress, "OutMinGustAmt", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetWindParameters_GameThread_OutMaxGustAmt_PropertyAddress, BGUGetWindParameters_GameThread_FunctionAddress, "OutMaxGustAmt");
		BGUGetWindParameters_GameThread_OutMaxGustAmt_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetWindParameters_GameThread_FunctionAddress, "OutMaxGustAmt");
		BGUGetWindParameters_GameThread_OutMaxGustAmt_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetWindParameters_GameThread_FunctionAddress, "OutMaxGustAmt", Classes.FFloatProperty);
		BGUGetWindParameters_GameThread_IsValid = BGUGetWindParameters_GameThread_FunctionAddress != IntPtr.Zero && BGUGetWindParameters_GameThread_WorldContext_IsValid && BGUGetWindParameters_GameThread_Position_IsValid && BGUGetWindParameters_GameThread_OutDirection_IsValid && BGUGetWindParameters_GameThread_OutSpeed_IsValid && BGUGetWindParameters_GameThread_OutMinGustAmt_IsValid && BGUGetWindParameters_GameThread_OutMaxGustAmt_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGetWindParameters_GameThread", BGUGetWindParameters_GameThread_IsValid);
		BGUGetTeamID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetTeamID");
		BGUGetTeamID_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetTeamID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTeamID_Unit_PropertyAddress, BGUGetTeamID_FunctionAddress, "Unit");
		BGUGetTeamID_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTeamID_FunctionAddress, "Unit");
		BGUGetTeamID_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTeamID_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetTeamID_ReturnValue_PropertyAddress, BGUGetTeamID_FunctionAddress, "ReturnValue");
		BGUGetTeamID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetTeamID_FunctionAddress, "ReturnValue");
		BGUGetTeamID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetTeamID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetTeamID_IsValid = BGUGetTeamID_FunctionAddress != IntPtr.Zero && BGUGetTeamID_Unit_IsValid && BGUGetTeamID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGetTeamID", BGUGetTeamID_IsValid);
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetSkeletalMeshSimulatedBodiesBelowNum");
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSkeletalMeshSimulatedBodiesBelowNum_SkeletalMesh_PropertyAddress, BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "SkeletalMesh");
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_SkeletalMesh_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "SkeletalMesh");
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_SkeletalMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "SkeletalMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSkeletalMeshSimulatedBodiesBelowNum_BoneName_PropertyAddress, BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "BoneName");
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_BoneName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "BoneName");
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "BoneName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSkeletalMeshSimulatedBodiesBelowNum_bIncludeSelf_PropertyAddress, BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "bIncludeSelf");
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_bIncludeSelf_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "bIncludeSelf");
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_bIncludeSelf_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "bIncludeSelf", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetSkeletalMeshSimulatedBodiesBelowNum_ReturnValue_PropertyAddress, BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "ReturnValue");
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "ReturnValue");
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		BGUGetSkeletalMeshSimulatedBodiesBelowNum_IsValid = BGUGetSkeletalMeshSimulatedBodiesBelowNum_FunctionAddress != IntPtr.Zero && BGUGetSkeletalMeshSimulatedBodiesBelowNum_SkeletalMesh_IsValid && BGUGetSkeletalMeshSimulatedBodiesBelowNum_BoneName_IsValid && BGUGetSkeletalMeshSimulatedBodiesBelowNum_bIncludeSelf_IsValid && BGUGetSkeletalMeshSimulatedBodiesBelowNum_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGetSkeletalMeshSimulatedBodiesBelowNum", BGUGetSkeletalMeshSimulatedBodiesBelowNum_IsValid);
		BGUGetMontageSectionTimeLeftFromPos_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetMontageSectionTimeLeftFromPos");
		BGUGetMontageSectionTimeLeftFromPos_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetMontageSectionTimeLeftFromPos_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionTimeLeftFromPos_Unit_PropertyAddress, BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "Unit");
		BGUGetMontageSectionTimeLeftFromPos_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "Unit");
		BGUGetMontageSectionTimeLeftFromPos_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionTimeLeftFromPos_AnimMontage_PropertyAddress, BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "AnimMontage");
		BGUGetMontageSectionTimeLeftFromPos_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "AnimMontage");
		BGUGetMontageSectionTimeLeftFromPos_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionTimeLeftFromPos_Position_PropertyAddress, BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "Position");
		BGUGetMontageSectionTimeLeftFromPos_Position_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "Position");
		BGUGetMontageSectionTimeLeftFromPos_Position_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "Position", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionTimeLeftFromPos_ReturnValue_PropertyAddress, BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "ReturnValue");
		BGUGetMontageSectionTimeLeftFromPos_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "ReturnValue");
		BGUGetMontageSectionTimeLeftFromPos_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionTimeLeftFromPos_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetMontageSectionTimeLeftFromPos_IsValid = BGUGetMontageSectionTimeLeftFromPos_FunctionAddress != IntPtr.Zero && BGUGetMontageSectionTimeLeftFromPos_Unit_IsValid && BGUGetMontageSectionTimeLeftFromPos_AnimMontage_IsValid && BGUGetMontageSectionTimeLeftFromPos_Position_IsValid && BGUGetMontageSectionTimeLeftFromPos_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionTimeLeftFromPos", BGUGetMontageSectionTimeLeftFromPos_IsValid);
		BGUGetMontageSectionStartAndEndTime_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetMontageSectionStartAndEndTime");
		BGUGetMontageSectionStartAndEndTime_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetMontageSectionStartAndEndTime_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionStartAndEndTime_AnimMontage_PropertyAddress, BGUGetMontageSectionStartAndEndTime_FunctionAddress, "AnimMontage");
		BGUGetMontageSectionStartAndEndTime_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionStartAndEndTime_FunctionAddress, "AnimMontage");
		BGUGetMontageSectionStartAndEndTime_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionStartAndEndTime_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionStartAndEndTime_SectionName_PropertyAddress, BGUGetMontageSectionStartAndEndTime_FunctionAddress, "SectionName");
		BGUGetMontageSectionStartAndEndTime_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionStartAndEndTime_FunctionAddress, "SectionName");
		BGUGetMontageSectionStartAndEndTime_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionStartAndEndTime_FunctionAddress, "SectionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionStartAndEndTime_OutStartTime_PropertyAddress, BGUGetMontageSectionStartAndEndTime_FunctionAddress, "OutStartTime");
		BGUGetMontageSectionStartAndEndTime_OutStartTime_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionStartAndEndTime_FunctionAddress, "OutStartTime");
		BGUGetMontageSectionStartAndEndTime_OutStartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionStartAndEndTime_FunctionAddress, "OutStartTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionStartAndEndTime_OutEndTime_PropertyAddress, BGUGetMontageSectionStartAndEndTime_FunctionAddress, "OutEndTime");
		BGUGetMontageSectionStartAndEndTime_OutEndTime_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionStartAndEndTime_FunctionAddress, "OutEndTime");
		BGUGetMontageSectionStartAndEndTime_OutEndTime_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionStartAndEndTime_FunctionAddress, "OutEndTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionStartAndEndTime_ReturnValue_PropertyAddress, BGUGetMontageSectionStartAndEndTime_FunctionAddress, "ReturnValue");
		BGUGetMontageSectionStartAndEndTime_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionStartAndEndTime_FunctionAddress, "ReturnValue");
		BGUGetMontageSectionStartAndEndTime_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionStartAndEndTime_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetMontageSectionStartAndEndTime_IsValid = BGUGetMontageSectionStartAndEndTime_FunctionAddress != IntPtr.Zero && BGUGetMontageSectionStartAndEndTime_AnimMontage_IsValid && BGUGetMontageSectionStartAndEndTime_SectionName_IsValid && BGUGetMontageSectionStartAndEndTime_OutStartTime_IsValid && BGUGetMontageSectionStartAndEndTime_OutEndTime_IsValid && BGUGetMontageSectionStartAndEndTime_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionStartAndEndTime", BGUGetMontageSectionStartAndEndTime_IsValid);
		BGUGetMontageSectionLengthByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetMontageSectionLengthByName");
		BGUGetMontageSectionLengthByName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetMontageSectionLengthByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionLengthByName_Unit_PropertyAddress, BGUGetMontageSectionLengthByName_FunctionAddress, "Unit");
		BGUGetMontageSectionLengthByName_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionLengthByName_FunctionAddress, "Unit");
		BGUGetMontageSectionLengthByName_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionLengthByName_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionLengthByName_AnimMontage_PropertyAddress, BGUGetMontageSectionLengthByName_FunctionAddress, "AnimMontage");
		BGUGetMontageSectionLengthByName_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionLengthByName_FunctionAddress, "AnimMontage");
		BGUGetMontageSectionLengthByName_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionLengthByName_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionLengthByName_SectionName_PropertyAddress, BGUGetMontageSectionLengthByName_FunctionAddress, "SectionName");
		BGUGetMontageSectionLengthByName_SectionName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionLengthByName_FunctionAddress, "SectionName");
		BGUGetMontageSectionLengthByName_SectionName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionLengthByName_FunctionAddress, "SectionName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionLengthByName_ReturnValue_PropertyAddress, BGUGetMontageSectionLengthByName_FunctionAddress, "ReturnValue");
		BGUGetMontageSectionLengthByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionLengthByName_FunctionAddress, "ReturnValue");
		BGUGetMontageSectionLengthByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionLengthByName_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetMontageSectionLengthByName_IsValid = BGUGetMontageSectionLengthByName_FunctionAddress != IntPtr.Zero && BGUGetMontageSectionLengthByName_Unit_IsValid && BGUGetMontageSectionLengthByName_AnimMontage_IsValid && BGUGetMontageSectionLengthByName_SectionName_IsValid && BGUGetMontageSectionLengthByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionLengthByName", BGUGetMontageSectionLengthByName_IsValid);
		BGUGetMontageSectionLengthByIndex_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetMontageSectionLengthByIndex");
		BGUGetMontageSectionLengthByIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetMontageSectionLengthByIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionLengthByIndex_Unit_PropertyAddress, BGUGetMontageSectionLengthByIndex_FunctionAddress, "Unit");
		BGUGetMontageSectionLengthByIndex_Unit_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionLengthByIndex_FunctionAddress, "Unit");
		BGUGetMontageSectionLengthByIndex_Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionLengthByIndex_FunctionAddress, "Unit", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionLengthByIndex_AnimMontage_PropertyAddress, BGUGetMontageSectionLengthByIndex_FunctionAddress, "AnimMontage");
		BGUGetMontageSectionLengthByIndex_AnimMontage_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionLengthByIndex_FunctionAddress, "AnimMontage");
		BGUGetMontageSectionLengthByIndex_AnimMontage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionLengthByIndex_FunctionAddress, "AnimMontage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionLengthByIndex_index_PropertyAddress, BGUGetMontageSectionLengthByIndex_FunctionAddress, "index");
		BGUGetMontageSectionLengthByIndex_index_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionLengthByIndex_FunctionAddress, "index");
		BGUGetMontageSectionLengthByIndex_index_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionLengthByIndex_FunctionAddress, "index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetMontageSectionLengthByIndex_ReturnValue_PropertyAddress, BGUGetMontageSectionLengthByIndex_FunctionAddress, "ReturnValue");
		BGUGetMontageSectionLengthByIndex_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetMontageSectionLengthByIndex_FunctionAddress, "ReturnValue");
		BGUGetMontageSectionLengthByIndex_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetMontageSectionLengthByIndex_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetMontageSectionLengthByIndex_IsValid = BGUGetMontageSectionLengthByIndex_FunctionAddress != IntPtr.Zero && BGUGetMontageSectionLengthByIndex_Unit_IsValid && BGUGetMontageSectionLengthByIndex_AnimMontage_IsValid && BGUGetMontageSectionLengthByIndex_index_IsValid && BGUGetMontageSectionLengthByIndex_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGetMontageSectionLengthByIndex", BGUGetMontageSectionLengthByIndex_IsValid);
		BGUGetHitResultActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetHitResultActor");
		BGUGetHitResultActor_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetHitResultActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetHitResultActor_ActorInstanceHandle_PropertyAddress, BGUGetHitResultActor_FunctionAddress, "ActorInstanceHandle");
		BGUGetHitResultActor_ActorInstanceHandle_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetHitResultActor_FunctionAddress, "ActorInstanceHandle");
		BGUGetHitResultActor_ActorInstanceHandle_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetHitResultActor_FunctionAddress, "ActorInstanceHandle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetHitResultActor_ReturnValue_PropertyAddress, BGUGetHitResultActor_FunctionAddress, "ReturnValue");
		BGUGetHitResultActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetHitResultActor_FunctionAddress, "ReturnValue");
		BGUGetHitResultActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetHitResultActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGetHitResultActor_IsValid = BGUGetHitResultActor_FunctionAddress != IntPtr.Zero && BGUGetHitResultActor_ActorInstanceHandle_IsValid && BGUGetHitResultActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGetHitResultActor", BGUGetHitResultActor_IsValid);
		BGUGetAllActorsWithTagInRangeSorted_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetAllActorsWithTagInRangeSorted");
		BGUGetAllActorsWithTagInRangeSorted_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetAllActorsWithTagInRangeSorted_CenterActor_PropertyAddress, BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "CenterActor");
		BGUGetAllActorsWithTagInRangeSorted_CenterActor_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "CenterActor");
		BGUGetAllActorsWithTagInRangeSorted_CenterActor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "CenterActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetAllActorsWithTagInRangeSorted_TagName_PropertyAddress, BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "TagName");
		BGUGetAllActorsWithTagInRangeSorted_TagName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "TagName");
		BGUGetAllActorsWithTagInRangeSorted_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetAllActorsWithTagInRangeSorted_Range_PropertyAddress, BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "Range");
		BGUGetAllActorsWithTagInRangeSorted_Range_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "Range");
		BGUGetAllActorsWithTagInRangeSorted_Range_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "Range", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetAllActorsWithTagInRangeSorted_OutActors_PropertyAddress, BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "OutActors");
		BGUGetAllActorsWithTagInRangeSorted_OutActors_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "OutActors");
		BGUGetAllActorsWithTagInRangeSorted_OutActors_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "OutActors", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetAllActorsWithTagInRangeSorted_ReturnValue_PropertyAddress, BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "ReturnValue");
		BGUGetAllActorsWithTagInRangeSorted_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "ReturnValue");
		BGUGetAllActorsWithTagInRangeSorted_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetAllActorsWithTagInRangeSorted_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGUGetAllActorsWithTagInRangeSorted_IsValid = BGUGetAllActorsWithTagInRangeSorted_FunctionAddress != IntPtr.Zero && BGUGetAllActorsWithTagInRangeSorted_CenterActor_IsValid && BGUGetAllActorsWithTagInRangeSorted_TagName_IsValid && BGUGetAllActorsWithTagInRangeSorted_Range_IsValid && BGUGetAllActorsWithTagInRangeSorted_OutActors_IsValid && BGUGetAllActorsWithTagInRangeSorted_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGetAllActorsWithTagInRangeSorted", BGUGetAllActorsWithTagInRangeSorted_IsValid);
		BGUGetActiveMontagePosition_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGetActiveMontagePosition");
		BGUGetActiveMontagePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGetActiveMontagePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGetActiveMontagePosition_Actor_PropertyAddress, BGUGetActiveMontagePosition_FunctionAddress, "Actor");
		BGUGetActiveMontagePosition_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetActiveMontagePosition_FunctionAddress, "Actor");
		BGUGetActiveMontagePosition_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetActiveMontagePosition_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetActiveMontagePosition_Montage_PropertyAddress, BGUGetActiveMontagePosition_FunctionAddress, "Montage");
		BGUGetActiveMontagePosition_Montage_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetActiveMontagePosition_FunctionAddress, "Montage");
		BGUGetActiveMontagePosition_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetActiveMontagePosition_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGetActiveMontagePosition_ReturnValue_PropertyAddress, BGUGetActiveMontagePosition_FunctionAddress, "ReturnValue");
		BGUGetActiveMontagePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGetActiveMontagePosition_FunctionAddress, "ReturnValue");
		BGUGetActiveMontagePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGetActiveMontagePosition_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		BGUGetActiveMontagePosition_IsValid = BGUGetActiveMontagePosition_FunctionAddress != IntPtr.Zero && BGUGetActiveMontagePosition_Actor_IsValid && BGUGetActiveMontagePosition_Montage_IsValid && BGUGetActiveMontagePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGetActiveMontagePosition", BGUGetActiveMontagePosition_IsValid);
		BGUGenProceduralLevel_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGenProceduralLevel");
		BGUGenProceduralLevel_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGenProceduralLevel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGenProceduralLevel_WorldContextObject_PropertyAddress, BGUGenProceduralLevel_FunctionAddress, "WorldContextObject");
		BGUGenProceduralLevel_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenProceduralLevel_FunctionAddress, "WorldContextObject");
		BGUGenProceduralLevel_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenProceduralLevel_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenProceduralLevel_WorldAssetName_PropertyAddress, BGUGenProceduralLevel_FunctionAddress, "WorldAssetName");
		BGUGenProceduralLevel_WorldAssetName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenProceduralLevel_FunctionAddress, "WorldAssetName");
		BGUGenProceduralLevel_WorldAssetName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenProceduralLevel_FunctionAddress, "WorldAssetName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenProceduralLevel_InLevelName_PropertyAddress, BGUGenProceduralLevel_FunctionAddress, "InLevelName");
		BGUGenProceduralLevel_InLevelName_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenProceduralLevel_FunctionAddress, "InLevelName");
		BGUGenProceduralLevel_InLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenProceduralLevel_FunctionAddress, "InLevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenProceduralLevel_InLevelTransform_PropertyAddress, BGUGenProceduralLevel_FunctionAddress, "InLevelTransform");
		BGUGenProceduralLevel_InLevelTransform_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenProceduralLevel_FunctionAddress, "InLevelTransform");
		BGUGenProceduralLevel_InLevelTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenProceduralLevel_FunctionAddress, "InLevelTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenProceduralLevel_ReturnValue_PropertyAddress, BGUGenProceduralLevel_FunctionAddress, "ReturnValue");
		BGUGenProceduralLevel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenProceduralLevel_FunctionAddress, "ReturnValue");
		BGUGenProceduralLevel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenProceduralLevel_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGenProceduralLevel_IsValid = BGUGenProceduralLevel_FunctionAddress != IntPtr.Zero && BGUGenProceduralLevel_WorldContextObject_IsValid && BGUGenProceduralLevel_WorldAssetName_IsValid && BGUGenProceduralLevel_InLevelName_IsValid && BGUGenProceduralLevel_InLevelTransform_IsValid && BGUGenProceduralLevel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGenProceduralLevel", BGUGenProceduralLevel_IsValid);
		BGUGenComponentAndAdd_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGenComponentAndAdd");
		BGUGenComponentAndAdd_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGenComponentAndAdd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGenComponentAndAdd_Actor_PropertyAddress, BGUGenComponentAndAdd_FunctionAddress, "Actor");
		BGUGenComponentAndAdd_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenComponentAndAdd_FunctionAddress, "Actor");
		BGUGenComponentAndAdd_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenComponentAndAdd_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenComponentAndAdd_ActorComponentClass_PropertyAddress, BGUGenComponentAndAdd_FunctionAddress, "ActorComponentClass");
		BGUGenComponentAndAdd_ActorComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenComponentAndAdd_FunctionAddress, "ActorComponentClass");
		BGUGenComponentAndAdd_ActorComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenComponentAndAdd_FunctionAddress, "ActorComponentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenComponentAndAdd_ReturnValue_PropertyAddress, BGUGenComponentAndAdd_FunctionAddress, "ReturnValue");
		BGUGenComponentAndAdd_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenComponentAndAdd_FunctionAddress, "ReturnValue");
		BGUGenComponentAndAdd_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenComponentAndAdd_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGenComponentAndAdd_IsValid = BGUGenComponentAndAdd_FunctionAddress != IntPtr.Zero && BGUGenComponentAndAdd_Actor_IsValid && BGUGenComponentAndAdd_ActorComponentClass_IsValid && BGUGenComponentAndAdd_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGenComponentAndAdd", BGUGenComponentAndAdd_IsValid);
		BGUGenComponent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUGenComponent");
		BGUGenComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUGenComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUGenComponent_Actor_PropertyAddress, BGUGenComponent_FunctionAddress, "Actor");
		BGUGenComponent_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenComponent_FunctionAddress, "Actor");
		BGUGenComponent_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenComponent_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenComponent_ActorComponentClass_PropertyAddress, BGUGenComponent_FunctionAddress, "ActorComponentClass");
		BGUGenComponent_ActorComponentClass_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenComponent_FunctionAddress, "ActorComponentClass");
		BGUGenComponent_ActorComponentClass_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenComponent_FunctionAddress, "ActorComponentClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUGenComponent_ReturnValue_PropertyAddress, BGUGenComponent_FunctionAddress, "ReturnValue");
		BGUGenComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUGenComponent_FunctionAddress, "ReturnValue");
		BGUGenComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUGenComponent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUGenComponent_IsValid = BGUGenComponent_FunctionAddress != IntPtr.Zero && BGUGenComponent_Actor_IsValid && BGUGenComponent_ActorComponentClass_IsValid && BGUGenComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUGenComponent", BGUGenComponent_IsValid);
		BGUFlushLevelStreamingOnlyVisibility_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUFlushLevelStreamingOnlyVisibility");
		BGUFlushLevelStreamingOnlyVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUFlushLevelStreamingOnlyVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUFlushLevelStreamingOnlyVisibility_WorldContextObject_PropertyAddress, BGUFlushLevelStreamingOnlyVisibility_FunctionAddress, "WorldContextObject");
		BGUFlushLevelStreamingOnlyVisibility_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUFlushLevelStreamingOnlyVisibility_FunctionAddress, "WorldContextObject");
		BGUFlushLevelStreamingOnlyVisibility_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUFlushLevelStreamingOnlyVisibility_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		BGUFlushLevelStreamingOnlyVisibility_IsValid = BGUFlushLevelStreamingOnlyVisibility_FunctionAddress != IntPtr.Zero && BGUFlushLevelStreamingOnlyVisibility_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUFlushLevelStreamingOnlyVisibility", BGUFlushLevelStreamingOnlyVisibility_IsValid);
		BGUFinishSpawningActor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUFinishSpawningActor");
		BGUFinishSpawningActor_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUFinishSpawningActor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUFinishSpawningActor_Actor_PropertyAddress, BGUFinishSpawningActor_FunctionAddress, "Actor");
		BGUFinishSpawningActor_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BGUFinishSpawningActor_FunctionAddress, "Actor");
		BGUFinishSpawningActor_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUFinishSpawningActor_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUFinishSpawningActor_SpawnTransform_PropertyAddress, BGUFinishSpawningActor_FunctionAddress, "SpawnTransform");
		BGUFinishSpawningActor_SpawnTransform_Offset = NativeReflectionCached.GetPropertyOffset(BGUFinishSpawningActor_FunctionAddress, "SpawnTransform");
		BGUFinishSpawningActor_SpawnTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUFinishSpawningActor_FunctionAddress, "SpawnTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUFinishSpawningActor_ReturnValue_PropertyAddress, BGUFinishSpawningActor_FunctionAddress, "ReturnValue");
		BGUFinishSpawningActor_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUFinishSpawningActor_FunctionAddress, "ReturnValue");
		BGUFinishSpawningActor_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUFinishSpawningActor_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUFinishSpawningActor_IsValid = BGUFinishSpawningActor_FunctionAddress != IntPtr.Zero && BGUFinishSpawningActor_Actor_IsValid && BGUFinishSpawningActor_SpawnTransform_IsValid && BGUFinishSpawningActor_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUFinishSpawningActor", BGUFinishSpawningActor_IsValid);
		BGUFindFirstActorWithTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUFindFirstActorWithTag");
		BGUFindFirstActorWithTag_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUFindFirstActorWithTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUFindFirstActorWithTag_WorldContextObject_PropertyAddress, BGUFindFirstActorWithTag_FunctionAddress, "WorldContextObject");
		BGUFindFirstActorWithTag_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUFindFirstActorWithTag_FunctionAddress, "WorldContextObject");
		BGUFindFirstActorWithTag_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUFindFirstActorWithTag_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUFindFirstActorWithTag_TagName_PropertyAddress, BGUFindFirstActorWithTag_FunctionAddress, "TagName");
		BGUFindFirstActorWithTag_TagName_Offset = NativeReflectionCached.GetPropertyOffset(BGUFindFirstActorWithTag_FunctionAddress, "TagName");
		BGUFindFirstActorWithTag_TagName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUFindFirstActorWithTag_FunctionAddress, "TagName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUFindFirstActorWithTag_ReturnValue_PropertyAddress, BGUFindFirstActorWithTag_FunctionAddress, "ReturnValue");
		BGUFindFirstActorWithTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUFindFirstActorWithTag_FunctionAddress, "ReturnValue");
		BGUFindFirstActorWithTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUFindFirstActorWithTag_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUFindFirstActorWithTag_IsValid = BGUFindFirstActorWithTag_FunctionAddress != IntPtr.Zero && BGUFindFirstActorWithTag_WorldContextObject_IsValid && BGUFindFirstActorWithTag_TagName_IsValid && BGUFindFirstActorWithTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUFindFirstActorWithTag", BGUFindFirstActorWithTag_IsValid);
		BGUCalcBounds_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUCalcBounds");
		BGUCalcBounds_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUCalcBounds_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcBounds_StaticMesh_PropertyAddress, BGUCalcBounds_FunctionAddress, "StaticMesh");
		BGUCalcBounds_StaticMesh_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcBounds_FunctionAddress, "StaticMesh");
		BGUCalcBounds_StaticMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcBounds_FunctionAddress, "StaticMesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcBounds_Origin_PropertyAddress, BGUCalcBounds_FunctionAddress, "Origin");
		BGUCalcBounds_Origin_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcBounds_FunctionAddress, "Origin");
		BGUCalcBounds_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcBounds_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcBounds_BoxExtent_PropertyAddress, BGUCalcBounds_FunctionAddress, "BoxExtent");
		BGUCalcBounds_BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcBounds_FunctionAddress, "BoxExtent");
		BGUCalcBounds_BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcBounds_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUCalcBounds_SphereRadius_PropertyAddress, BGUCalcBounds_FunctionAddress, "SphereRadius");
		BGUCalcBounds_SphereRadius_Offset = NativeReflectionCached.GetPropertyOffset(BGUCalcBounds_FunctionAddress, "SphereRadius");
		BGUCalcBounds_SphereRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUCalcBounds_FunctionAddress, "SphereRadius", Classes.FFloatProperty);
		BGUCalcBounds_IsValid = BGUCalcBounds_FunctionAddress != IntPtr.Zero && BGUCalcBounds_StaticMesh_IsValid && BGUCalcBounds_Origin_IsValid && BGUCalcBounds_BoxExtent_IsValid && BGUCalcBounds_SphereRadius_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUCalcBounds", BGUCalcBounds_IsValid);
		BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBeginDeferredActorSpawnFromClassWithName");
		BGUBeginDeferredActorSpawnFromClassWithName_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClassWithName_WorldContextObject_PropertyAddress, BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "WorldContextObject");
		BGUBeginDeferredActorSpawnFromClassWithName_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "WorldContextObject");
		BGUBeginDeferredActorSpawnFromClassWithName_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClassWithName_ActorClass_PropertyAddress, BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "ActorClass");
		BGUBeginDeferredActorSpawnFromClassWithName_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "ActorClass");
		BGUBeginDeferredActorSpawnFromClassWithName_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClassWithName_SpawnTransform_PropertyAddress, BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "SpawnTransform");
		BGUBeginDeferredActorSpawnFromClassWithName_SpawnTransform_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "SpawnTransform");
		BGUBeginDeferredActorSpawnFromClassWithName_SpawnTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "SpawnTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClassWithName_CollisionHandlingOverride_PropertyAddress, BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "CollisionHandlingOverride");
		BGUBeginDeferredActorSpawnFromClassWithName_CollisionHandlingOverride_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "CollisionHandlingOverride");
		BGUBeginDeferredActorSpawnFromClassWithName_CollisionHandlingOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "CollisionHandlingOverride", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClassWithName_Owner_PropertyAddress, BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "Owner");
		BGUBeginDeferredActorSpawnFromClassWithName_Owner_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "Owner");
		BGUBeginDeferredActorSpawnFromClassWithName_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClassWithName_ActorName_PropertyAddress, BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "ActorName");
		BGUBeginDeferredActorSpawnFromClassWithName_ActorName_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "ActorName");
		BGUBeginDeferredActorSpawnFromClassWithName_ActorName_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "ActorName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClassWithName_OverrideLevel_PropertyAddress, BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "OverrideLevel");
		BGUBeginDeferredActorSpawnFromClassWithName_OverrideLevel_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "OverrideLevel");
		BGUBeginDeferredActorSpawnFromClassWithName_OverrideLevel_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "OverrideLevel", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClassWithName_ReturnValue_PropertyAddress, BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "ReturnValue");
		BGUBeginDeferredActorSpawnFromClassWithName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "ReturnValue");
		BGUBeginDeferredActorSpawnFromClassWithName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUBeginDeferredActorSpawnFromClassWithName_IsValid = BGUBeginDeferredActorSpawnFromClassWithName_FunctionAddress != IntPtr.Zero && BGUBeginDeferredActorSpawnFromClassWithName_WorldContextObject_IsValid && BGUBeginDeferredActorSpawnFromClassWithName_ActorClass_IsValid && BGUBeginDeferredActorSpawnFromClassWithName_SpawnTransform_IsValid && BGUBeginDeferredActorSpawnFromClassWithName_CollisionHandlingOverride_IsValid && BGUBeginDeferredActorSpawnFromClassWithName_Owner_IsValid && BGUBeginDeferredActorSpawnFromClassWithName_ActorName_IsValid && BGUBeginDeferredActorSpawnFromClassWithName_OverrideLevel_IsValid && BGUBeginDeferredActorSpawnFromClassWithName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUBeginDeferredActorSpawnFromClassWithName", BGUBeginDeferredActorSpawnFromClassWithName_IsValid);
		BGUBeginDeferredActorSpawnFromClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUBeginDeferredActorSpawnFromClass");
		BGUBeginDeferredActorSpawnFromClass_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUBeginDeferredActorSpawnFromClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClass_WorldContextObject_PropertyAddress, BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "WorldContextObject");
		BGUBeginDeferredActorSpawnFromClass_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "WorldContextObject");
		BGUBeginDeferredActorSpawnFromClass_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClass_ActorClass_PropertyAddress, BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "ActorClass");
		BGUBeginDeferredActorSpawnFromClass_ActorClass_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "ActorClass");
		BGUBeginDeferredActorSpawnFromClass_ActorClass_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "ActorClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClass_SpawnTransform_PropertyAddress, BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "SpawnTransform");
		BGUBeginDeferredActorSpawnFromClass_SpawnTransform_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "SpawnTransform");
		BGUBeginDeferredActorSpawnFromClass_SpawnTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "SpawnTransform", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClass_CollisionHandlingOverride_PropertyAddress, BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "CollisionHandlingOverride");
		BGUBeginDeferredActorSpawnFromClass_CollisionHandlingOverride_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "CollisionHandlingOverride");
		BGUBeginDeferredActorSpawnFromClass_CollisionHandlingOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "CollisionHandlingOverride", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClass_Owner_PropertyAddress, BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "Owner");
		BGUBeginDeferredActorSpawnFromClass_Owner_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "Owner");
		BGUBeginDeferredActorSpawnFromClass_Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "Owner", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUBeginDeferredActorSpawnFromClass_ReturnValue_PropertyAddress, BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "ReturnValue");
		BGUBeginDeferredActorSpawnFromClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "ReturnValue");
		BGUBeginDeferredActorSpawnFromClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUBeginDeferredActorSpawnFromClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		BGUBeginDeferredActorSpawnFromClass_IsValid = BGUBeginDeferredActorSpawnFromClass_FunctionAddress != IntPtr.Zero && BGUBeginDeferredActorSpawnFromClass_WorldContextObject_IsValid && BGUBeginDeferredActorSpawnFromClass_ActorClass_IsValid && BGUBeginDeferredActorSpawnFromClass_SpawnTransform_IsValid && BGUBeginDeferredActorSpawnFromClass_CollisionHandlingOverride_IsValid && BGUBeginDeferredActorSpawnFromClass_Owner_IsValid && BGUBeginDeferredActorSpawnFromClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUBeginDeferredActorSpawnFromClass", BGUBeginDeferredActorSpawnFromClass_IsValid);
		BGUActorUpdateAllTFXComp_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "BGUActorUpdateAllTFXComp");
		BGUActorUpdateAllTFXComp_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUActorUpdateAllTFXComp_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUActorUpdateAllTFXComp_Actor_PropertyAddress, BGUActorUpdateAllTFXComp_FunctionAddress, "Actor");
		BGUActorUpdateAllTFXComp_Actor_Offset = NativeReflectionCached.GetPropertyOffset(BGUActorUpdateAllTFXComp_FunctionAddress, "Actor");
		BGUActorUpdateAllTFXComp_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUActorUpdateAllTFXComp_FunctionAddress, "Actor", Classes.FObjectProperty);
		BGUActorUpdateAllTFXComp_IsValid = BGUActorUpdateAllTFXComp_FunctionAddress != IntPtr.Zero && BGUActorUpdateAllTFXComp_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:BGUActorUpdateAllTFXComp", BGUActorUpdateAllTFXComp_IsValid);
		ApplyLevelTransform_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ApplyLevelTransform");
		ApplyLevelTransform_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyLevelTransform_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyLevelTransform_WorldContextObject_PropertyAddress, ApplyLevelTransform_FunctionAddress, "WorldContextObject");
		ApplyLevelTransform_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(ApplyLevelTransform_FunctionAddress, "WorldContextObject");
		ApplyLevelTransform_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyLevelTransform_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyLevelTransform_LevelName_PropertyAddress, ApplyLevelTransform_FunctionAddress, "LevelName");
		ApplyLevelTransform_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(ApplyLevelTransform_FunctionAddress, "LevelName");
		ApplyLevelTransform_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyLevelTransform_FunctionAddress, "LevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyLevelTransform_LevelTransform_PropertyAddress, ApplyLevelTransform_FunctionAddress, "LevelTransform");
		ApplyLevelTransform_LevelTransform_Offset = NativeReflectionCached.GetPropertyOffset(ApplyLevelTransform_FunctionAddress, "LevelTransform");
		ApplyLevelTransform_LevelTransform_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyLevelTransform_FunctionAddress, "LevelTransform", Classes.FStructProperty);
		ApplyLevelTransform_IsValid = ApplyLevelTransform_FunctionAddress != IntPtr.Zero && ApplyLevelTransform_WorldContextObject_IsValid && ApplyLevelTransform_LevelName_IsValid && ApplyLevelTransform_LevelTransform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:ApplyLevelTransform", ApplyLevelTransform_IsValid);
		AddLevelStreaming_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddLevelStreaming");
		AddLevelStreaming_ParamsSize = NativeReflection.GetFunctionParamsSize(AddLevelStreaming_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddLevelStreaming_WorldContextObject_PropertyAddress, AddLevelStreaming_FunctionAddress, "WorldContextObject");
		AddLevelStreaming_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(AddLevelStreaming_FunctionAddress, "WorldContextObject");
		AddLevelStreaming_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLevelStreaming_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLevelStreaming_LevelName_PropertyAddress, AddLevelStreaming_FunctionAddress, "LevelName");
		AddLevelStreaming_LevelName_Offset = NativeReflectionCached.GetPropertyOffset(AddLevelStreaming_FunctionAddress, "LevelName");
		AddLevelStreaming_LevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLevelStreaming_FunctionAddress, "LevelName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLevelStreaming_Location_PropertyAddress, AddLevelStreaming_FunctionAddress, "Location");
		AddLevelStreaming_Location_Offset = NativeReflectionCached.GetPropertyOffset(AddLevelStreaming_FunctionAddress, "Location");
		AddLevelStreaming_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLevelStreaming_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLevelStreaming_Rotation_PropertyAddress, AddLevelStreaming_FunctionAddress, "Rotation");
		AddLevelStreaming_Rotation_Offset = NativeReflectionCached.GetPropertyOffset(AddLevelStreaming_FunctionAddress, "Rotation");
		AddLevelStreaming_Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLevelStreaming_FunctionAddress, "Rotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLevelStreaming_bShouldBlockOnLoad_PropertyAddress, AddLevelStreaming_FunctionAddress, "bShouldBlockOnLoad");
		AddLevelStreaming_bShouldBlockOnLoad_Offset = NativeReflectionCached.GetPropertyOffset(AddLevelStreaming_FunctionAddress, "bShouldBlockOnLoad");
		AddLevelStreaming_bShouldBlockOnLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLevelStreaming_FunctionAddress, "bShouldBlockOnLoad", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddLevelStreaming_ReturnValue_PropertyAddress, AddLevelStreaming_FunctionAddress, "ReturnValue");
		AddLevelStreaming_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddLevelStreaming_FunctionAddress, "ReturnValue");
		AddLevelStreaming_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddLevelStreaming_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		AddLevelStreaming_IsValid = AddLevelStreaming_FunctionAddress != IntPtr.Zero && AddLevelStreaming_WorldContextObject_IsValid && AddLevelStreaming_LevelName_IsValid && AddLevelStreaming_Location_IsValid && AddLevelStreaming_Rotation_IsValid && AddLevelStreaming_bShouldBlockOnLoad_IsValid && AddLevelStreaming_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:AddLevelStreaming", AddLevelStreaming_IsValid);
		AddBuffNotifyStates_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddBuffNotifyStates");
		AddBuffNotifyStates_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBuffNotifyStates_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBuffNotifyStates_MontageObj_PropertyAddress, AddBuffNotifyStates_FunctionAddress, "MontageObj");
		AddBuffNotifyStates_MontageObj_Offset = NativeReflectionCached.GetPropertyOffset(AddBuffNotifyStates_FunctionAddress, "MontageObj");
		AddBuffNotifyStates_MontageObj_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBuffNotifyStates_FunctionAddress, "MontageObj", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBuffNotifyStates_NewNotifyStateClass_PropertyAddress, AddBuffNotifyStates_FunctionAddress, "NewNotifyStateClass");
		AddBuffNotifyStates_NewNotifyStateClass_Offset = NativeReflectionCached.GetPropertyOffset(AddBuffNotifyStates_FunctionAddress, "NewNotifyStateClass");
		AddBuffNotifyStates_NewNotifyStateClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBuffNotifyStates_FunctionAddress, "NewNotifyStateClass", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBuffNotifyStates_BuffID_PropertyAddress, AddBuffNotifyStates_FunctionAddress, "BuffID");
		AddBuffNotifyStates_BuffID_Offset = NativeReflectionCached.GetPropertyOffset(AddBuffNotifyStates_FunctionAddress, "BuffID");
		AddBuffNotifyStates_BuffID_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBuffNotifyStates_FunctionAddress, "BuffID", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBuffNotifyStates_NotifyStateInfos_PropertyAddress, AddBuffNotifyStates_FunctionAddress, "NotifyStateInfos");
		AddBuffNotifyStates_NotifyStateInfos_Offset = NativeReflectionCached.GetPropertyOffset(AddBuffNotifyStates_FunctionAddress, "NotifyStateInfos");
		AddBuffNotifyStates_NotifyStateInfos_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBuffNotifyStates_FunctionAddress, "NotifyStateInfos", Classes.FMapProperty);
		AddBuffNotifyStates_IsValid = AddBuffNotifyStates_FunctionAddress != IntPtr.Zero && AddBuffNotifyStates_MontageObj_IsValid && AddBuffNotifyStates_NewNotifyStateClass_IsValid && AddBuffNotifyStates_BuffID_IsValid && AddBuffNotifyStates_NotifyStateInfos_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:AddBuffNotifyStates", AddBuffNotifyStates_IsValid);
		AddAllAnimNotifyStatesAccordingToReference_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAllAnimNotifyStatesAccordingToReference");
		AddAllAnimNotifyStatesAccordingToReference_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAllAnimNotifyStatesAccordingToReference_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAllAnimNotifyStatesAccordingToReference_ResourcePath_PropertyAddress, AddAllAnimNotifyStatesAccordingToReference_FunctionAddress, "ResourcePath");
		AddAllAnimNotifyStatesAccordingToReference_ResourcePath_Offset = NativeReflectionCached.GetPropertyOffset(AddAllAnimNotifyStatesAccordingToReference_FunctionAddress, "ResourcePath");
		AddAllAnimNotifyStatesAccordingToReference_ResourcePath_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAllAnimNotifyStatesAccordingToReference_FunctionAddress, "ResourcePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAllAnimNotifyStatesAccordingToReference_RefNotifyStateClass_PropertyAddress, AddAllAnimNotifyStatesAccordingToReference_FunctionAddress, "RefNotifyStateClass");
		AddAllAnimNotifyStatesAccordingToReference_RefNotifyStateClass_Offset = NativeReflectionCached.GetPropertyOffset(AddAllAnimNotifyStatesAccordingToReference_FunctionAddress, "RefNotifyStateClass");
		AddAllAnimNotifyStatesAccordingToReference_RefNotifyStateClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAllAnimNotifyStatesAccordingToReference_FunctionAddress, "RefNotifyStateClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAllAnimNotifyStatesAccordingToReference_NewNotifyStateClass_PropertyAddress, AddAllAnimNotifyStatesAccordingToReference_FunctionAddress, "NewNotifyStateClass");
		AddAllAnimNotifyStatesAccordingToReference_NewNotifyStateClass_Offset = NativeReflectionCached.GetPropertyOffset(AddAllAnimNotifyStatesAccordingToReference_FunctionAddress, "NewNotifyStateClass");
		AddAllAnimNotifyStatesAccordingToReference_NewNotifyStateClass_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAllAnimNotifyStatesAccordingToReference_FunctionAddress, "NewNotifyStateClass", Classes.FClassProperty);
		AddAllAnimNotifyStatesAccordingToReference_IsValid = AddAllAnimNotifyStatesAccordingToReference_FunctionAddress != IntPtr.Zero && AddAllAnimNotifyStatesAccordingToReference_ResourcePath_IsValid && AddAllAnimNotifyStatesAccordingToReference_RefNotifyStateClass_IsValid && AddAllAnimNotifyStatesAccordingToReference_NewNotifyStateClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUFunctionLibrary:AddAllAnimNotifyStatesAccordingToReference", AddAllAnimNotifyStatesAccordingToReference_IsValid);
	}
}
