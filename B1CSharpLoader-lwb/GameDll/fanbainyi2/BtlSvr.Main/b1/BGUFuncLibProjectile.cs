using System;
using System.Collections.Generic;
using System.Linq;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile")]
public class BGUFuncLibProjectile : UBlueprintFunctionLibrary
{
	private static bool GetProjectileType_IsValid;

	private static IntPtr GetProjectileType_FunctionAddress;

	private static int GetProjectileType_ParamsSize;

	private static bool GetProjectileType_ProjectileID_IsValid;

	private static int GetProjectileType_ProjectileID_Offset;

	private static bool GetProjectileType_ReturnValue_IsValid;

	private static int GetProjectileType_ReturnValue_Offset;

	private static bool GetBuffEffectTypes_IsValid;

	private static IntPtr GetBuffEffectTypes_FunctionAddress;

	private static int GetBuffEffectTypes_ParamsSize;

	private static bool GetBuffEffectTypes_BuffID_IsValid;

	private static int GetBuffEffectTypes_BuffID_Offset;

	private static bool GetBuffEffectTypes_ReturnValue_IsValid;

	private static int GetBuffEffectTypes_ReturnValue_Offset;

	private static FFieldAddress GetBuffEffectTypes_ReturnValue_PropertyAddress;

	private static bool GetCtrProjectileByID_IsValid;

	private static IntPtr GetCtrProjectileByID_FunctionAddress;

	private static int GetCtrProjectileByID_ParamsSize;

	private static bool GetCtrProjectileByID_CurCharacter_IsValid;

	private static int GetCtrProjectileByID_CurCharacter_Offset;

	private static bool GetCtrProjectileByID_ProjectileID_IsValid;

	private static int GetCtrProjectileByID_ProjectileID_Offset;

	private static bool GetCtrProjectileByID_ReturnValue_IsValid;

	private static int GetCtrProjectileByID_ReturnValue_Offset;

	private static bool CheckCompHasChildComp_IsValid;

	private static IntPtr CheckCompHasChildComp_FunctionAddress;

	private static int CheckCompHasChildComp_ParamsSize;

	private static bool CheckCompHasChildComp_ErrorBPPathList_IsValid;

	private static int CheckCompHasChildComp_ErrorBPPathList_Offset;

	private static FFieldAddress CheckCompHasChildComp_ErrorBPPathList_PropertyAddress;

	private static bool CheckBuffUsedInBullet_IsValid;

	private static IntPtr CheckBuffUsedInBullet_FunctionAddress;

	private static int CheckBuffUsedInBullet_ParamsSize;

	private static bool CheckBuffUsedInBullet_ReturnValue_IsValid;

	private static int CheckBuffUsedInBullet_ReturnValue_Offset;

	private static FFieldAddress CheckBuffUsedInBullet_ReturnValue_PropertyAddress;

	private static bool CheckOutAllProjectileBP_IsValid;

	private static IntPtr CheckOutAllProjectileBP_FunctionAddress;

	private static int CheckOutAllProjectileBP_ParamsSize;

	private static bool CheckOutAllProjectileBP_CheckOutMap_IsValid;

	private static int CheckOutAllProjectileBP_CheckOutMap_Offset;

	private static FFieldAddress CheckOutAllProjectileBP_CheckOutMap_PropertyAddress;

	private static bool CheckOutAllProjectileBP_ReturnValue_IsValid;

	private static int CheckOutAllProjectileBP_ReturnValue_Offset;

	private static FFieldAddress CheckOutAllProjectileBP_ReturnValue_PropertyAddress;

	private static bool FindProjectileAboutFlame_IsValid;

	private static IntPtr FindProjectileAboutFlame_FunctionAddress;

	private static int FindProjectileAboutFlame_ParamsSize;

	private static bool FindProjectileAboutFlame_ErrorLog_IsValid;

	private static int FindProjectileAboutFlame_ErrorLog_Offset;

	private static FFieldAddress FindProjectileAboutFlame_ErrorLog_PropertyAddress;

	private static bool FindProjectileAboutFlame_ReturnValue_IsValid;

	private static int FindProjectileAboutFlame_ReturnValue_Offset;

	private static FFieldAddress FindProjectileAboutFlame_ReturnValue_PropertyAddress;

	private static bool CheckBuffDispUsedInBullet_IsValid;

	private static IntPtr CheckBuffDispUsedInBullet_FunctionAddress;

	private static int CheckBuffDispUsedInBullet_ParamsSize;

	private static bool CheckBuffDispUsedInBullet_ReturnValue_IsValid;

	private static int CheckBuffDispUsedInBullet_ReturnValue_Offset;

	private static FFieldAddress CheckBuffDispUsedInBullet_ReturnValue_PropertyAddress;

	private static bool ProjectileAssetCheck_Full_IsValid;

	private static IntPtr ProjectileAssetCheck_Full_FunctionAddress;

	private static int ProjectileAssetCheck_Full_ParamsSize;

	private static bool ProjectileAssetCheck_Full_ErrorLog_IsValid;

	private static int ProjectileAssetCheck_Full_ErrorLog_Offset;

	private static FFieldAddress ProjectileAssetCheck_Full_ErrorLog_PropertyAddress;

	private static bool ProjectileAssetCheck_Full_MarkDirtyList_IsValid;

	private static int ProjectileAssetCheck_Full_MarkDirtyList_Offset;

	private static FFieldAddress ProjectileAssetCheck_Full_MarkDirtyList_PropertyAddress;

	private static bool ProjectileAssetCheck_Full_ReturnValue_IsValid;

	private static int ProjectileAssetCheck_Full_ReturnValue_Offset;

	private static FFieldAddress ProjectileAssetCheck_Full_ReturnValue_PropertyAddress;

	private static bool ProjectileAssetCheck_Single_IsValid;

	private static IntPtr ProjectileAssetCheck_Single_FunctionAddress;

	private static int ProjectileAssetCheck_Single_ParamsSize;

	private static bool ProjectileAssetCheck_Single_ProjectileBaseActor_CDO_IsValid;

	private static int ProjectileAssetCheck_Single_ProjectileBaseActor_CDO_Offset;

	private static bool ProjectileAssetCheck_Single_ErrorLog_IsValid;

	private static int ProjectileAssetCheck_Single_ErrorLog_Offset;

	private static FFieldAddress ProjectileAssetCheck_Single_ErrorLog_PropertyAddress;

	private static bool ProjectileAssetCheck_Single_bNeedLoadData_IsValid;

	private static int ProjectileAssetCheck_Single_bNeedLoadData_Offset;

	private static FFieldAddress ProjectileAssetCheck_Single_bNeedLoadData_PropertyAddress;

	private static bool ProjectileAssetCheck_Single_ReturnValue_IsValid;

	private static int ProjectileAssetCheck_Single_ReturnValue_Offset;

	private static FFieldAddress ProjectileAssetCheck_Single_ReturnValue_PropertyAddress;

	private static bool CreateCheckCompForProjectile_IsValid;

	private static IntPtr CreateCheckCompForProjectile_FunctionAddress;

	private static int CreateCheckCompForProjectile_ParamsSize;

	private static bool CreateCheckCompForProjectile_ProjectileBaseActor_CDO_IsValid;

	private static int CreateCheckCompForProjectile_ProjectileBaseActor_CDO_Offset;

	private static bool CreateCheckCompForProjectile_BP_IsValid;

	private static int CreateCheckCompForProjectile_BP_Offset;

	private static bool CreateCheckCompForProjectile_CheckShape_IsValid;

	private static int CreateCheckCompForProjectile_CheckShape_Offset;

	private static FFieldAddress CreateCheckCompForProjectile_CheckShape_PropertyAddress;

	private static bool CreateCheckCompForProjectile_ErrorLog_IsValid;

	private static int CreateCheckCompForProjectile_ErrorLog_Offset;

	private static FFieldAddress CreateCheckCompForProjectile_ErrorLog_PropertyAddress;

	private static bool CreateCheckCompForProjectile_bNeedLoadData_IsValid;

	private static int CreateCheckCompForProjectile_bNeedLoadData_Offset;

	private static FFieldAddress CreateCheckCompForProjectile_bNeedLoadData_PropertyAddress;

	private static bool CreateCheckCompForProjectile_ReturnValue_IsValid;

	private static int CreateCheckCompForProjectile_ReturnValue_Offset;

	private static FFieldAddress CreateCheckCompForProjectile_ReturnValue_PropertyAddress;

	private static bool ModifyProjectileCheckShapeType_IsValid;

	private static IntPtr ModifyProjectileCheckShapeType_FunctionAddress;

	private static int ModifyProjectileCheckShapeType_ParamsSize;

	private static bool ModifyProjectileCheckShapeType_ProjectileBaseActor_CDO_IsValid;

	private static int ModifyProjectileCheckShapeType_ProjectileBaseActor_CDO_Offset;

	private static bool ModifyProjectileCheckShapeType_BP_IsValid;

	private static int ModifyProjectileCheckShapeType_BP_Offset;

	private static bool ModifyProjectileCheckShapeType_CheckShape_IsValid;

	private static int ModifyProjectileCheckShapeType_CheckShape_Offset;

	private static FFieldAddress ModifyProjectileCheckShapeType_CheckShape_PropertyAddress;

	private static bool ModifyProjectileCheckShapeType_ErrorLog_IsValid;

	private static int ModifyProjectileCheckShapeType_ErrorLog_Offset;

	private static FFieldAddress ModifyProjectileCheckShapeType_ErrorLog_PropertyAddress;

	private static bool ModifyProjectileCheckShapeType_ReturnValue_IsValid;

	private static int ModifyProjectileCheckShapeType_ReturnValue_Offset;

	private static FFieldAddress ModifyProjectileCheckShapeType_ReturnValue_PropertyAddress;

	private static bool CheckEffectsUsedInBulletExpand_IsValid;

	private static IntPtr CheckEffectsUsedInBulletExpand_FunctionAddress;

	private static int CheckEffectsUsedInBulletExpand_ParamsSize;

	private static bool CheckEffectsUsedInBulletExpand_ReturnValue_IsValid;

	private static int CheckEffectsUsedInBulletExpand_ReturnValue_Offset;

	private static FFieldAddress CheckEffectsUsedInBulletExpand_ReturnValue_PropertyAddress;

	private static bool CreateInteractCompForProjectile_IsValid;

	private static IntPtr CreateInteractCompForProjectile_FunctionAddress;

	private static int CreateInteractCompForProjectile_ParamsSize;

	private static bool CreateInteractCompForProjectile_ProjectileBaseActor_CDO_IsValid;

	private static int CreateInteractCompForProjectile_ProjectileBaseActor_CDO_Offset;

	private static bool CreateInteractCompForProjectile_BP_IsValid;

	private static int CreateInteractCompForProjectile_BP_Offset;

	private static bool CreateInteractCompForProjectile_ErrorLog_IsValid;

	private static int CreateInteractCompForProjectile_ErrorLog_Offset;

	private static FFieldAddress CreateInteractCompForProjectile_ErrorLog_PropertyAddress;

	private static bool CreateInteractCompForProjectile_ReturnValue_IsValid;

	private static int CreateInteractCompForProjectile_ReturnValue_Offset;

	private static FFieldAddress CreateInteractCompForProjectile_ReturnValue_PropertyAddress;

	private static bool ProjectileAssetMoveCompToBP_Full_IsValid;

	private static IntPtr ProjectileAssetMoveCompToBP_Full_FunctionAddress;

	private static int ProjectileAssetMoveCompToBP_Full_ParamsSize;

	private static bool ProjectileAssetMoveCompToBP_Full_ErrorLog_IsValid;

	private static int ProjectileAssetMoveCompToBP_Full_ErrorLog_Offset;

	private static FFieldAddress ProjectileAssetMoveCompToBP_Full_ErrorLog_PropertyAddress;

	private static bool ProjectileAssetMoveCompToBP_Single_IsValid;

	private static IntPtr ProjectileAssetMoveCompToBP_Single_FunctionAddress;

	private static int ProjectileAssetMoveCompToBP_Single_ParamsSize;

	private static bool ProjectileAssetMoveCompToBP_Single_ProjectileBaseActor_CDO_IsValid;

	private static int ProjectileAssetMoveCompToBP_Single_ProjectileBaseActor_CDO_Offset;

	private static bool ProjectileAssetMoveCompToBP_Single_BP_IsValid;

	private static int ProjectileAssetMoveCompToBP_Single_BP_Offset;

	private static bool ProjectileAssetMoveCompToBP_Single_ErrorLog_IsValid;

	private static int ProjectileAssetMoveCompToBP_Single_ErrorLog_Offset;

	private static FFieldAddress ProjectileAssetMoveCompToBP_Single_ErrorLog_PropertyAddress;

	private static bool ProjectileAssetMoveCompToBP_Single_bNeedLoadData_IsValid;

	private static int ProjectileAssetMoveCompToBP_Single_bNeedLoadData_Offset;

	private static FFieldAddress ProjectileAssetMoveCompToBP_Single_bNeedLoadData_PropertyAddress;

	private static bool GetAllProjectileBPPathFromDesc_with_C_IsValid;

	private static IntPtr GetAllProjectileBPPathFromDesc_with_C_FunctionAddress;

	private static int GetAllProjectileBPPathFromDesc_with_C_ParamsSize;

	private static bool GetAllProjectileBPPathFromDesc_with_C_CurrentUsedBPPath_IsValid;

	private static int GetAllProjectileBPPathFromDesc_with_C_CurrentUsedBPPath_Offset;

	private static FFieldAddress GetAllProjectileBPPathFromDesc_with_C_CurrentUsedBPPath_PropertyAddress;

	private static bool GetAllProjectileBPPathFromDesc_without_C_IsValid;

	private static IntPtr GetAllProjectileBPPathFromDesc_without_C_FunctionAddress;

	private static int GetAllProjectileBPPathFromDesc_without_C_ParamsSize;

	private static bool GetAllProjectileBPPathFromDesc_without_C_CurrentUsedBPPath_IsValid;

	private static int GetAllProjectileBPPathFromDesc_without_C_CurrentUsedBPPath_Offset;

	private static FFieldAddress GetAllProjectileBPPathFromDesc_without_C_CurrentUsedBPPath_PropertyAddress;

	public static void PrepareSpawnPositions(AActor ProjectileOwner, ref ProjectileBaseStruct BaseInfo)
	{
		BaseInfo.BasePoints = null;
		BaseInfo.SocketOwnerComp = null;
		switch (BaseInfo.BaseType)
		{
		case ProjectileBaseType.UsePointSetCached:
			BaseInfo.BasePoints = BGUFunctionLibraryCS.BGUGetCachedPointSet(ProjectileOwner, BaseInfo.PointSetCachedReqID);
			break;
		case ProjectileBaseType.ProjectileSpawner:
		case ProjectileBaseType.EffectCaster:
		case ProjectileBaseType.EffectTarget:
		case ProjectileBaseType.UseSkillBaseTarget:
		case ProjectileBaseType.EffectRootCaster:
		{
			FTransform socketOrCompTransform2 = BGU_ObjActorUtil.GetSocketOrCompTransform(BaseInfo.UseSocket, BaseInfo.BaseActor.Get(), BaseInfo.SocketName, out BaseInfo.SocketOwnerComp);
			BaseInfo.BasePoints = new List<FVector> { socketOrCompTransform2.GetLocation() };
			break;
		}
		case ProjectileBaseType.CurTarget_ProjectileSpawner:
			if (BaseInfo.BaseActor.IsValid())
			{
				USceneComponent SocketOwnerComp;
				FTransform socketOrCompTransform = BGU_ObjActorUtil.GetSocketOrCompTransform(BaseInfo.UseSocket, BaseInfo.BaseActor.Get(), BaseInfo.SocketName, out SocketOwnerComp);
				BaseInfo.BasePoints = new List<FVector> { socketOrCompTransform.GetLocation() };
				BaseInfo.SocketOwnerComp = SocketOwnerComp;
			}
			else if (BGU_DataUtil.GetActorType(ProjectileOwner) != BGU_ActorType.CharacterPlayer)
			{
				AIData_Memory aIData_Memory = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(ProjectileOwner)?.Memory;
				if (aIData_Memory != null)
				{
					BaseInfo.BasePoints = new List<FVector> { aIData_Memory.TargetPosCache.GetLocation() };
				}
			}
			else
			{
				FTransform t = BGUFuncLibActorTransformCS.BGUGetActorTransform(ProjectileOwner);
				BaseInfo.BasePoints = new List<FVector> { t.TransformLocation(FVector.ForwardVector * 2000.0) };
			}
			break;
		case ProjectileBaseType.UseEffectPosition:
			BaseInfo.BasePoints = new List<FVector> { BaseInfo.EffectInstReq.HitLocation };
			break;
		case ProjectileBaseType.SceneItemCached:
		{
			BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(ProjectileOwner);
			if (readOnlyData != null && readOnlyData.SceneItemCatch != null)
			{
				BUC_SceneItemCommData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(readOnlyData.SceneItemCatch);
				if (readOnlyData2 != null)
				{
					BaseInfo.BasePoints = new List<FVector> { readOnlyData2.TeleportTransform.GetLocation() };
				}
			}
			else
			{
				BaseInfo.BasePoints = new List<FVector> { BGUFuncLibActorTransformCS.BGUGetActorLocation(ProjectileOwner) };
			}
			break;
		}
		case ProjectileBaseType.UseEQSPoint:
		{
			BGS_EventCollectionCS.Get(ProjectileOwner).Evt_BGS_EQSObjRunInstant.Invoke(BaseInfo.EQSTemplate, ProjectileOwner, out var Locations, out var Scores);
			int num = -1;
			float num2 = float.MinValue;
			for (int i = 0; i < Scores.Count; i++)
			{
				if (num2 < Scores[i])
				{
					num2 = Scores[i];
					num = i;
				}
			}
			if (num > -1)
			{
				FVector value = Locations[0];
				Locations[0] = Locations[num];
				Locations[num] = value;
			}
			BaseInfo.BasePoints = Locations;
			if (GSGameplayCVar.CVar_ShowDebugBulletEQG.GetValueInGameThread() == 1)
			{
				USystemLibrary.DrawDebugSphere(ProjectileOwner, Locations[0], 20f, 12, FLinearColor.Green, 0.5f, 4f);
			}
			break;
		}
		}
	}

	public static FVector GetOffset(FGSTargetOffsetInfo OffsetInfo, ref List<FVector> RangeOffsetList)
	{
		FVector fVector = FVector.ZeroVector;
		switch (OffsetInfo.PosOffsetType)
		{
		case ProjectilePosOffsetType.Normal:
			fVector = OffsetInfo.PosOffset;
			break;
		case ProjectilePosOffsetType.RandomOffset:
			fVector.X = MathLib.RandomFloatInRange(0f - OffsetInfo.PosOffset.X, OffsetInfo.PosOffset.X);
			fVector.Y = MathLib.RandomFloatInRange(0f - OffsetInfo.PosOffset.Y, OffsetInfo.PosOffset.Y);
			fVector.Z = MathLib.RandomFloatInRange(0f - OffsetInfo.PosOffset.Z, OffsetInfo.PosOffset.Z);
			break;
		case ProjectilePosOffsetType.RangeOffset:
		{
			if (OffsetInfo.HasCachedRangeOffset)
			{
				fVector = OffsetInfo.CachedRangeOffset;
				break;
			}
			List<FVector> list = new List<FVector>();
			if (RangeOffsetList == null)
			{
				RangeOffsetList = new List<FVector>();
			}
			list = ((RangeOffsetList.Count >= 1) ? RangeOffsetList : b1.BGUProjectileFuncLib.GetPointsInRangeArea(OffsetInfo.RangeOffsetInfo, FVector.ZeroVector));
			if (list.Count > 0)
			{
				int index = MathLib.RandomIntInRange(0, list.Count - 1);
				fVector = list[index];
				OffsetInfo.HasCachedRangeOffset = true;
				OffsetInfo.CachedRangeOffset = fVector;
				list.RemoveAt(index);
				RangeOffsetList = list;
			}
			break;
		}
		}
		FVector result = fVector;
		AActor aActor = OffsetInfo.BaseActor.Get();
		switch (OffsetInfo.OffsetSpace)
		{
		case ProjectilePosOffsetSpace.BaseActorLocalSpace:
			if (!aActor.IsNullOrDestroyed())
			{
				FTransform fTransform = BGUFuncLibActorTransformCS.BGUGetActorTransform(aActor);
				result = fTransform.TransformPositionNoScale(fVector) - fTransform.GetLocation();
			}
			else
			{
				result = FVector.ZeroVector;
			}
			break;
		case ProjectilePosOffsetSpace.SocketLocalSpace:
			if (!aActor.IsNullOrDestroyed())
			{
				USceneComponent SocketOwnerComp;
				FTransform socketOrCompTransform = BGU_ObjActorUtil.GetSocketOrCompTransform(OffsetInfo.UseSocket, aActor, OffsetInfo.SocketName, out SocketOwnerComp);
				result = socketOrCompTransform.TransformPositionNoScale(fVector) - socketOrCompTransform.GetLocation();
			}
			else
			{
				result = FVector.ZeroVector;
			}
			break;
		}
		result.Z += OffsetInfo.VerticalOffset_World;
		return result;
	}

	public static FVector GetBasePos(ProjectileBaseStruct BaseInfo, FGSTargetOffsetInfo OffsetInfo, out USceneComponent SocketOwnerComp, ref List<FVector> RangeOffsetList, int Index = 0)
	{
		SocketOwnerComp = BaseInfo.SocketOwnerComp;
		FVector fVector = FVector.ZeroVector;
		List<FVector> basePoints = BaseInfo.BasePoints;
		if (basePoints != null && basePoints.Count > 0)
		{
			fVector = ((basePoints.Count > Index) ? basePoints[Index] : basePoints[basePoints.Count - 1]);
		}
		return fVector + GetOffset(OffsetInfo, ref RangeOffsetList);
	}

	public static FVector GetBasePos(ProjectileBaseStruct BaseInfo, ProjectilePosOffsetStruct OffsetInfo, out USceneComponent SocketOwnerComp, ref List<FVector> RangeOffsetList, out FGSTargetOffsetInfo OffsetInfoCache, int CurNoInOneWave, int SpawnWaveCounter, int SpawnNumPerWave)
	{
		int num = 0;
		num = ((!BaseInfo.DontUpdateBornIndexPerWave) ? CurNoInOneWave : (CurNoInOneWave + SpawnWaveCounter * SpawnNumPerWave));
		OffsetInfoCache = new FGSTargetOffsetInfo(OffsetInfo);
		return GetBasePos(BaseInfo, OffsetInfoCache, out SocketOwnerComp, ref RangeOffsetList, num);
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:GetCtrProjectileByID")]
	public static AActor GetCtrProjectileByID(BGUCharacterCS CurCharacter, int ProjectileID)
	{
		b1.BUC_ProjectileCtrData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.BUC_ProjectileCtrData>(CurCharacter);
		if (readOnlyData == null)
		{
			return null;
		}
		if (readOnlyData.ProjectileList != null)
		{
			foreach (BGUProjectileBaseActor projectile in readOnlyData.ProjectileList)
			{
				if (ProjectileID != 0 && projectile.GetProjectileID() == ProjectileID)
				{
					return projectile;
				}
			}
		}
		return null;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:CheckCompHasChildComp")]
	public static void CheckCompHasChildComp(out List<string> ErrorBPPathList)
	{
		ErrorBPPathList = new List<string>();
		GetAllProjectileBPPathFromDesc_without_C(out var CurrentUsedBPPath);
		foreach (string item in CurrentUsedBPPath)
		{
			UBlueprint Blueprint;
			BGUProjectileBaseActor bGUProjectileBaseActor = UGSE_EditorFuncLib.AssetPath_GetCDO(null, item, out Blueprint) as BGUProjectileBaseActor;
			if (!(bGUProjectileBaseActor == null))
			{
				bGUProjectileBaseActor.GetSphereCollisionComp().GetChildrenComponents(bIncludeAllDescendants: true, out var _);
				if (bGUProjectileBaseActor.GetSphereCollisionComp().GetNumChildrenComponents() > 0)
				{
					ErrorBPPathList.Add(item);
				}
				else if (bGUProjectileBaseActor.GetBoxCollisionComp().GetNumChildrenComponents() > 0)
				{
					ErrorBPPathList.Add(item);
				}
				else if (bGUProjectileBaseActor.GetCapsuleCollisionComp().GetNumChildrenComponents() > 0)
				{
					ErrorBPPathList.Add(item);
				}
				else if (bGUProjectileBaseActor.GetCustomCollisionComp().GetNumChildrenComponents() > 0)
				{
					ErrorBPPathList.Add(item);
				}
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:GetAllProjectileBPPathFromDesc_with_C")]
	public static void GetAllProjectileBPPathFromDesc_with_C(out List<string> CurrentUsedBPPath)
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStProjectileCommDesc>();
		BGUFuncLibNonRuntime.LoadProtobufData<FUStBulletExpandDesc>();
		Dictionary<int, FUStProjectileCommDesc> allProjectileCommDesc = BGW_GameDB.GetAllProjectileCommDesc();
		CurrentUsedBPPath = new List<string>();
		foreach (KeyValuePair<int, FUStProjectileCommDesc> item in allProjectileCommDesc)
		{
			if (!string.IsNullOrEmpty(item.Value.ProjectileBPTemplatePath) && !CurrentUsedBPPath.Contains(item.Value.ProjectileBPTemplatePath))
			{
				CurrentUsedBPPath.Add(item.Value.ProjectileBPTemplatePath);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:GetAllProjectileBPPathFromDesc_without_C")]
	public static void GetAllProjectileBPPathFromDesc_without_C(out List<string> CurrentUsedBPPath)
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStProjectileCommDesc>();
		BGUFuncLibNonRuntime.LoadProtobufData<FUStBulletExpandDesc>();
		Dictionary<int, FUStProjectileCommDesc> allProjectileCommDesc = BGW_GameDB.GetAllProjectileCommDesc();
		CurrentUsedBPPath = new List<string>();
		foreach (KeyValuePair<int, FUStProjectileCommDesc> item2 in allProjectileCommDesc)
		{
			string projectileBPTemplatePath = item2.Value.ProjectileBPTemplatePath;
			if (!string.IsNullOrEmpty(item2.Value.ProjectileBPTemplatePath))
			{
				string item = projectileBPTemplatePath.Substring(0, projectileBPTemplatePath.Length - 2);
				if (!CurrentUsedBPPath.Contains(item))
				{
					CurrentUsedBPPath.Add(item);
				}
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:CheckOutAllProjectileBP")]
	public static bool CheckOutAllProjectileBP(out string CheckOutMap)
	{
		CheckOutMap = "";
		Dictionary<int, FUStProjectileCommDesc> allProjectileCommDesc = BGW_GameDB.GetAllProjectileCommDesc();
		Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
		foreach (KeyValuePair<int, FUStProjectileCommDesc> item in allProjectileCommDesc)
		{
			if (!string.IsNullOrEmpty(item.Value.ProjectileBPTemplatePath))
			{
				if (!dictionary.ContainsKey(item.Value.ProjectileBPTemplatePath))
				{
					List<int> list = new List<int>();
					list.Add(item.Key);
					dictionary.Add(item.Value.ProjectileBPTemplatePath, list);
				}
				else
				{
					dictionary[item.Value.ProjectileBPTemplatePath].Add(item.Key);
				}
			}
		}
		List<string> list2 = new List<string>();
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		foreach (string key in dictionary.Keys)
		{
			try
			{
				string text = key.Substring(0, key.Length - 2);
				string assetName = "";
				string[] array = text.Split('.');
				if (array.Length > 1)
				{
					assetName = array[1];
				}
				string oriFilePathByAssetPath = BGUFuncLibNonRuntime.GetOriFilePathByAssetPath(text, assetName);
				UGSFunclibPerforceSourceControlModule.QueryFileState(out var inState, oriFilePathByAssetPath);
				string checkedOutOther = inState.CheckedOutOther;
				if (checkedOutOther != "")
				{
					dictionary2.Add(key, checkedOutOther);
					CheckOutMap = CheckOutMap + checkedOutOther + "    " + key + "\n";
				}
			}
			catch
			{
				list2.Add(key);
			}
		}
		return dictionary2.Count > 0;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetMoveCompToBP_Full")]
	public static void ProjectileAssetMoveCompToBP_Full(out string ErrorLog)
	{
		ErrorLog = "";
		BGUFuncLibNonRuntime.LoadProtobufData<FUStProjectileCommDesc>();
		BGUFuncLibNonRuntime.LoadProtobufData<FUStBulletExpandDesc>();
		Dictionary<int, FUStProjectileCommDesc> allProjectileCommDesc = BGW_GameDB.GetAllProjectileCommDesc();
		Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
		foreach (KeyValuePair<int, FUStProjectileCommDesc> item in allProjectileCommDesc)
		{
			if (!string.IsNullOrEmpty(item.Value.ProjectileBPTemplatePath))
			{
				if (!dictionary.ContainsKey(item.Value.ProjectileBPTemplatePath))
				{
					List<int> list = new List<int>();
					list.Add(item.Key);
					dictionary.Add(item.Value.ProjectileBPTemplatePath, list);
				}
				else
				{
					dictionary[item.Value.ProjectileBPTemplatePath].Add(item.Key);
				}
			}
		}
		List<string> list2 = new List<string>();
		foreach (string key in dictionary.Keys)
		{
			try
			{
				string path = key.Substring(0, key.Length - 2);
				ProjectileAssetMoveCompToBP_Single(UGSE_EditorFuncLib.AssetPath_GetCDO(null, path, out var Blueprint) as BGUProjectileBaseActor, Blueprint, out var ErrorLog2, bNeedLoadData: false);
				ErrorLog += ErrorLog2;
			}
			catch
			{
				list2.Add(key);
			}
		}
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetMoveCompToBP_Single")]
	public static void ProjectileAssetMoveCompToBP_Single(BGUProjectileBaseActor ProjectileBaseActor_CDO, UBlueprint BP, out string ErrorLog, bool bNeedLoadData = true)
	{
		ErrorLog = "";
		if (ProjectileBaseActor_CDO == null || BP == null)
		{
			return;
		}
		if (bNeedLoadData)
		{
			BGUFuncLibNonRuntime.LoadProtobufData<FUStProjectileCommDesc>();
			BGUFuncLibNonRuntime.LoadProtobufData<FUStBulletExpandDesc>();
		}
		Dictionary<int, FUStProjectileCommDesc> allProjectileCommDesc = BGW_GameDB.GetAllProjectileCommDesc();
		string text = ProjectileBaseActor_CDO.GetPathName().Split('.')[0];
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, FUStProjectileCommDesc> item in allProjectileCommDesc)
		{
			if (!string.IsNullOrEmpty(item.Value.ProjectileBPTemplatePath))
			{
				string text2 = item.Value.ProjectileBPTemplatePath.Split('.')[0];
				if (text == text2)
				{
					list.Add(item.Value.ID);
				}
			}
		}
		if (list.Count < 1)
		{
			ErrorLog = ErrorLog + "ProjectileComm表中未配置该蓝图模板：" + text + "\n";
			return;
		}
		List<string> list2 = new List<string>();
		EProjectileCheckShapeType eProjectileCheckShapeType = EProjectileCheckShapeType.DefaultShape;
		if (list2.Contains(text))
		{
			ErrorLog = ErrorLog + "一个蓝图被指定了多个CheckShapeType：" + text + "\n";
			return;
		}
		FName inCollisionProfileName = ((ProjectileBaseActor_CDO is BGUBulletBaseCS) ? B1GlobalFNames.NormalBullet : B1GlobalFNames.NormalMagicField);
		switch (eProjectileCheckShapeType)
		{
		case EProjectileCheckShapeType.BoxShape:
		{
			FName outNewVariableName2;
			UActorComponent uActorComponent2 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.CheckComp_Box, UClass.GetClass<UBoxComponent>(), out outNewVariableName2, FName.None, FName.None);
			UBoxComponent uBoxComponent = uActorComponent2 as UBoxComponent;
			if (uBoxComponent == null)
			{
				ErrorLog = ErrorLog + "未成功添加新Comp：" + text + "\n";
				return;
			}
			uActorComponent2.ComponentTags.Add(B1GlobalFNames.CheckComp_Box);
			uBoxComponent.SetRelativeTransform(ProjectileBaseActor_CDO.GetBoxCollisionComp().GetRelativeTransform(), bSweep: false, out var _, bTeleport: false);
			uBoxComponent.SetBoxExtent(ProjectileBaseActor_CDO.GetBoxCollisionComp().GetUnscaledBoxExtent());
			uBoxComponent.SetCollisionProfileName(inCollisionProfileName);
			uBoxComponent.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
			uBoxComponent.HiddenInGame = true;
			break;
		}
		case EProjectileCheckShapeType.SphereShape:
		{
			FName outNewVariableName5;
			UActorComponent uActorComponent5 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.CheckComp_Sphere, UClass.GetClass<USphereComponent>(), out outNewVariableName5, FName.None, FName.None);
			USphereComponent uSphereComponent = uActorComponent5 as USphereComponent;
			if (uSphereComponent == null)
			{
				ErrorLog = ErrorLog + "未成功添加新Comp：" + text + "\n";
				return;
			}
			uActorComponent5.ComponentTags.Add(B1GlobalFNames.CheckComp_Sphere);
			uSphereComponent.SetRelativeTransform(ProjectileBaseActor_CDO.GetSphereCollisionComp().GetRelativeTransform(), bSweep: false, out var _, bTeleport: false);
			uSphereComponent.SetSphereRadius(ProjectileBaseActor_CDO.GetSphereCollisionComp().GetUnscaledSphereRadius());
			uSphereComponent.SetCollisionProfileName(inCollisionProfileName);
			uSphereComponent.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
			uSphereComponent.HiddenInGame = true;
			break;
		}
		case EProjectileCheckShapeType.CapsuleShape:
		{
			FName outNewVariableName3;
			UActorComponent uActorComponent3 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.CheckComp_Capsule, UClass.GetClass<UCapsuleComponent>(), out outNewVariableName3, FName.None, FName.None);
			UCapsuleComponent uCapsuleComponent = uActorComponent3 as UCapsuleComponent;
			if (uCapsuleComponent == null)
			{
				ErrorLog = ErrorLog + "未成功添加新Comp：" + text + "\n";
				return;
			}
			uActorComponent3.ComponentTags.Add(B1GlobalFNames.CheckComp_Capsule);
			uCapsuleComponent.SetRelativeTransform(ProjectileBaseActor_CDO.GetCapsuleCollisionComp().GetRelativeTransform(), bSweep: false, out var _, bTeleport: false);
			uCapsuleComponent.SetCapsuleRadius(ProjectileBaseActor_CDO.GetCapsuleCollisionComp().GetUnscaledCapsuleRadius());
			uCapsuleComponent.SetCapsuleHalfHeight(ProjectileBaseActor_CDO.GetCapsuleCollisionComp().GetUnscaledCapsuleHalfHeight());
			uCapsuleComponent.SetCollisionProfileName(inCollisionProfileName);
			uCapsuleComponent.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
			uCapsuleComponent.HiddenInGame = true;
			break;
		}
		case EProjectileCheckShapeType.CustomShape:
		{
			FName outNewVariableName4;
			UActorComponent uActorComponent4 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.CheckComp_Custom, UClass.GetClass<UStaticMeshComponent>(), out outNewVariableName4, FName.None, FName.None);
			UStaticMeshComponent uStaticMeshComponent = uActorComponent4 as UStaticMeshComponent;
			if (uStaticMeshComponent == null)
			{
				ErrorLog = ErrorLog + "未成功添加新Comp：" + text + "\n";
				return;
			}
			uActorComponent4.ComponentTags.Add(B1GlobalFNames.CheckComp_Custom);
			uStaticMeshComponent.SetRelativeTransform(ProjectileBaseActor_CDO.GetCustomCollisionComp().GetRelativeTransform(), bSweep: false, out var _, bTeleport: false);
			uStaticMeshComponent.SetStaticMesh(ProjectileBaseActor_CDO.GetCustomCollisionComp().StaticMesh);
			uStaticMeshComponent.SetCollisionProfileName(inCollisionProfileName);
			uStaticMeshComponent.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
			uStaticMeshComponent.HiddenInGame = true;
			break;
		}
		case EProjectileCheckShapeType.LineTrace:
		{
			FName outNewVariableName;
			UActorComponent uActorComponent = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.LineTracePoint, UClass.GetClass<USceneComponent>(), out outNewVariableName, FName.None, FName.None);
			USceneComponent uSceneComponent = uActorComponent as USceneComponent;
			if (uSceneComponent == null)
			{
				ErrorLog = ErrorLog + "未成功添加新Comp：" + text + "\n";
				return;
			}
			uActorComponent.ComponentTags.Add(B1GlobalFNames.LineTracePoint);
			uSceneComponent.SetRelativeTransform(ProjectileBaseActor_CDO.GetCustomCollisionComp().GetRelativeTransform(), bSweep: false, out var _, bTeleport: false);
			uSceneComponent.HiddenInGame = true;
			break;
		}
		}
		if (ProjectileBaseActor_CDO.ProjectileConfigInfoComp.Interact_Start_SphereRadius > 0f && ProjectileBaseActor_CDO.ProjectileConfigInfoComp.Interact_End_SphereRadius > 0f)
		{
			FName outNewVariableName6;
			UActorComponent uActorComponent6 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.Interact_1, UClass.GetClass<USphereComponent>(), out outNewVariableName6, FName.None, FName.None);
			USphereComponent uSphereComponent2 = uActorComponent6 as USphereComponent;
			if (uSphereComponent2 == null)
			{
				ErrorLog = ErrorLog + "未成功添加新交互Comp：" + text + "\n";
				return;
			}
			uActorComponent6.ComponentTags.Add(B1GlobalFNames.Interact_1);
			uSphereComponent2.SetRelativeTransform(ProjectileBaseActor_CDO.ProjectileConfigInfoComp.Interact_Start_LocalTransform, bSweep: false, out var _, bTeleport: false);
			uSphereComponent2.SetSphereRadius(ProjectileBaseActor_CDO.ProjectileConfigInfoComp.Interact_Start_SphereRadius);
			uSphereComponent2.SetCollisionProfileName(B1GlobalFNames.NoCollision);
			uSphereComponent2.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
			uSphereComponent2.HiddenInGame = true;
			uSphereComponent2.IsEditorOnly = true;
			UActorComponent uActorComponent7 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.Interact_2, UClass.GetClass<USphereComponent>(), out outNewVariableName6, FName.None, FName.None);
			USphereComponent uSphereComponent3 = uActorComponent7 as USphereComponent;
			if (uSphereComponent3 == null)
			{
				ErrorLog = ErrorLog + "未成功添加新交互Comp：" + text + "\n";
				return;
			}
			uActorComponent7.ComponentTags.Add(B1GlobalFNames.Interact_2);
			uSphereComponent3.SetRelativeTransform(ProjectileBaseActor_CDO.ProjectileConfigInfoComp.Interact_End_LocalTransform, bSweep: false, out var _, bTeleport: false);
			uSphereComponent3.SetSphereRadius(ProjectileBaseActor_CDO.ProjectileConfigInfoComp.Interact_End_SphereRadius);
			uSphereComponent3.SetCollisionProfileName(B1GlobalFNames.NoCollision);
			uSphereComponent3.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
			uSphereComponent3.HiddenInGame = true;
			uSphereComponent3.IsEditorOnly = true;
		}
		if (ProjectileBaseActor_CDO.GetStaticMesh().StaticMesh == null)
		{
			ProjectileBaseActor_CDO.GetStaticMesh().SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
		}
		ProjectileBaseActor_CDO.GetStaticMesh().SetSimulatePhysics(bSimulate: false);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetCheck_Full")]
	public static bool ProjectileAssetCheck_Full(out string ErrorLog, out List<string> MarkDirtyList)
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStProjectileCommDesc>();
		BGUFuncLibNonRuntime.LoadProtobufData<FUStBulletExpandDesc>();
		Dictionary<int, FUStProjectileCommDesc> allProjectileCommDesc = BGW_GameDB.GetAllProjectileCommDesc();
		Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
		foreach (KeyValuePair<int, FUStProjectileCommDesc> item in allProjectileCommDesc)
		{
			if (!string.IsNullOrEmpty(item.Value.ProjectileBPTemplatePath))
			{
				if (!dictionary.ContainsKey(item.Value.ProjectileBPTemplatePath))
				{
					List<int> list = new List<int>();
					list.Add(item.Key);
					dictionary.Add(item.Value.ProjectileBPTemplatePath, list);
				}
				else
				{
					dictionary[item.Value.ProjectileBPTemplatePath].Add(item.Key);
				}
			}
		}
		List<BGUProjectileBaseActor> list2 = new List<BGUProjectileBaseActor>();
		ErrorLog = "";
		MarkDirtyList = new List<string>();
		List<string> list3 = new List<string>();
		foreach (string key in dictionary.Keys)
		{
			try
			{
				string text = key.Substring(0, key.Length - 2);
				UBlueprint Blueprint;
				BGUProjectileBaseActor bGUProjectileBaseActor = UGSE_EditorFuncLib.AssetPath_GetCDO(null, text, out Blueprint) as BGUProjectileBaseActor;
				string ErrorLog2;
				int num = 0 | (ProjectileAssetCheck_Single(bGUProjectileBaseActor, out ErrorLog2, bNeedLoadData: false) ? 1 : 0);
				if (!string.IsNullOrEmpty(ErrorLog2))
				{
					ErrorLog += ErrorLog2;
					ErrorLog += "\n";
				}
				if (num != 0)
				{
					MarkDirtyList.Add(text);
					UGSE_AnimFuncLib.MarkDirty(Blueprint);
					list2.Add(bGUProjectileBaseActor);
				}
			}
			catch
			{
				list3.Add(key);
			}
		}
		return true;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetCheck_Single")]
	public static bool ProjectileAssetCheck_Single(BGUProjectileBaseActor ProjectileBaseActor_CDO, out string ErrorLog, bool bNeedLoadData = true)
	{
		bool flag = false;
		ErrorLog = "";
		if (ProjectileBaseActor_CDO == null)
		{
			return flag;
		}
		if (bNeedLoadData)
		{
			BGUFuncLibNonRuntime.LoadProtobufData<FUStProjectileCommDesc>();
			BGUFuncLibNonRuntime.LoadProtobufData<FUStBulletExpandDesc>();
		}
		Dictionary<int, FUStProjectileCommDesc> allProjectileCommDesc = BGW_GameDB.GetAllProjectileCommDesc();
		string text = ProjectileBaseActor_CDO.GetPathName().Split('.')[0];
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, FUStProjectileCommDesc> item in allProjectileCommDesc)
		{
			if (!string.IsNullOrEmpty(item.Value.ProjectileBPTemplatePath))
			{
				string text2 = item.Value.ProjectileBPTemplatePath.Split('.')[0];
				if (text == text2)
				{
					list.Add(item.Value.ID);
				}
			}
		}
		if (list.Count < 1)
		{
			ErrorLog = ErrorLog + "ProjectileComm表中未配置该蓝图模板：" + text + "\n";
			return false;
		}
		flag |= ProjectileBaseActor_CDO.ProjectileAbilityCheck_ByBPConfig();
		bool flag2 = false;
		foreach (int item2 in list)
		{
			FUStBulletExpandDesc bulletExpandDesc = BGW_GameDB.GetBulletExpandDesc(item2);
			if (bulletExpandDesc != null)
			{
				flag2 |= bulletExpandDesc.IsLaserType == EGSYesNo.Yes;
			}
		}
		flag |= ProjectileBaseActor_CDO.ProjectileAbilityCheck_LaserBullet(flag2);
		bool flag3 = false;
		foreach (int item3 in list)
		{
			FUStProjectileCommDesc originalProjectileCommDesc = BGW_GameDB.GetOriginalProjectileCommDesc(item3);
			flag3 |= !string.IsNullOrEmpty(originalProjectileCommDesc.ProjectileScaleCurvePath);
		}
		return flag | ProjectileBaseActor_CDO.ProjectileAbilityCheck_DynamicScale(flag3);
	}

	[Tooltip("为抛射物蓝图资源添加对应的检测Comp")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:CreateCheckCompForProjectile")]
	public static bool CreateCheckCompForProjectile(BGUProjectileBaseActor ProjectileBaseActor_CDO, UBlueprint BP, EProjectileCheckShapeType CheckShape, out string ErrorLog, bool bNeedLoadData = true)
	{
		ErrorLog = "";
		FName inCollisionProfileName = ((ProjectileBaseActor_CDO is BGUBulletBaseCS) ? B1GlobalFNames.NormalBullet : B1GlobalFNames.NormalMagicField);
		switch (CheckShape)
		{
		case EProjectileCheckShapeType.BoxShape:
		{
			FName outNewVariableName2;
			UActorComponent uActorComponent2 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.CheckComp_Box, UClass.GetClass<UBoxComponent>(), out outNewVariableName2, FName.None, FName.None);
			UBoxComponent uBoxComponent = uActorComponent2 as UBoxComponent;
			if (uBoxComponent == null)
			{
				ErrorLog += "未成功添加新Comp\n";
				return false;
			}
			uActorComponent2.ComponentTags.Add(B1GlobalFNames.CheckComp_Box);
			uBoxComponent.SetCollisionProfileName(inCollisionProfileName);
			uBoxComponent.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
			uBoxComponent.HiddenInGame = true;
			uBoxComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
			break;
		}
		case EProjectileCheckShapeType.SphereShape:
		{
			FName outNewVariableName5;
			UActorComponent uActorComponent5 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.CheckComp_Sphere, UClass.GetClass<USphereComponent>(), out outNewVariableName5, FName.None, FName.None);
			USphereComponent uSphereComponent = uActorComponent5 as USphereComponent;
			if (uSphereComponent == null)
			{
				ErrorLog += "未成功添加新Comp：\n";
				return false;
			}
			uActorComponent5.ComponentTags.Add(B1GlobalFNames.CheckComp_Sphere);
			uSphereComponent.SetCollisionProfileName(inCollisionProfileName);
			uSphereComponent.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
			uSphereComponent.HiddenInGame = true;
			uSphereComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
			break;
		}
		case EProjectileCheckShapeType.CapsuleShape:
		{
			FName outNewVariableName3;
			UActorComponent uActorComponent3 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.CheckComp_Capsule, UClass.GetClass<UCapsuleComponent>(), out outNewVariableName3, FName.None, FName.None);
			UCapsuleComponent uCapsuleComponent = uActorComponent3 as UCapsuleComponent;
			if (uCapsuleComponent == null)
			{
				ErrorLog += "未成功添加新Comp：\n";
				return false;
			}
			uActorComponent3.ComponentTags.Add(B1GlobalFNames.CheckComp_Capsule);
			uCapsuleComponent.SetCollisionProfileName(inCollisionProfileName);
			uCapsuleComponent.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
			uCapsuleComponent.HiddenInGame = true;
			uCapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
			break;
		}
		case EProjectileCheckShapeType.CustomShape:
		{
			FName outNewVariableName4;
			UActorComponent uActorComponent4 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.CheckComp_Custom, UClass.GetClass<UStaticMeshComponent>(), out outNewVariableName4, FName.None, FName.None);
			UStaticMeshComponent uStaticMeshComponent = uActorComponent4 as UStaticMeshComponent;
			if (uStaticMeshComponent == null)
			{
				ErrorLog += "未成功添加新Comp：\n";
				return false;
			}
			uActorComponent4.ComponentTags.Add(B1GlobalFNames.CheckComp_Custom);
			uStaticMeshComponent.SetCollisionProfileName(inCollisionProfileName);
			uStaticMeshComponent.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
			uStaticMeshComponent.HiddenInGame = true;
			uStaticMeshComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
			break;
		}
		case EProjectileCheckShapeType.LineTrace:
		{
			FName outNewVariableName;
			UActorComponent uActorComponent = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.LineTracePoint, UClass.GetClass<USceneComponent>(), out outNewVariableName, FName.None, FName.None);
			USceneComponent uSceneComponent = uActorComponent as USceneComponent;
			if (uSceneComponent == null)
			{
				ErrorLog += "未成功添加新Comp：\n";
				return false;
			}
			uActorComponent.ComponentTags.Add(B1GlobalFNames.LineTracePoint);
			uSceneComponent.HiddenInGame = true;
			break;
		}
		}
		return true;
	}

	[Tooltip("为抛射物蓝图资源添加对应的交互Comp")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:CreateInteractCompForProjectile")]
	public static bool CreateInteractCompForProjectile(BGUProjectileBaseActor ProjectileBaseActor_CDO, UBlueprint BP, out string ErrorLog)
	{
		ErrorLog = "";
		if (ProjectileBaseActor_CDO == null || BP == null)
		{
			ErrorLog += "蓝图资源类型不对";
			return false;
		}
		FName outNewVariableName;
		UActorComponent uActorComponent = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.Interact_1, UClass.GetClass<USphereComponent>(), out outNewVariableName, FName.None, FName.None);
		USphereComponent uSphereComponent = uActorComponent as USphereComponent;
		if (uSphereComponent == null)
		{
			ErrorLog += "未成功添加新交互Comp：\n";
			return false;
		}
		uActorComponent.ComponentTags.Add(B1GlobalFNames.Interact_1);
		uSphereComponent.SetRelativeTransform(ProjectileBaseActor_CDO.ProjectileConfigInfoComp.Interact_Start_LocalTransform, bSweep: false, out var _, bTeleport: false);
		uSphereComponent.SetSphereRadius(ProjectileBaseActor_CDO.ProjectileConfigInfoComp.Interact_Start_SphereRadius);
		uSphereComponent.SetCollisionProfileName(B1GlobalFNames.NoCollision);
		uSphereComponent.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
		uSphereComponent.HiddenInGame = true;
		uSphereComponent.IsEditorOnly = true;
		UActorComponent uActorComponent2 = UGSFuncLibForEditor.AddCompToBPAsset(BP, B1GlobalFNames.Interact_2, UClass.GetClass<USphereComponent>(), out outNewVariableName, FName.None, FName.None);
		USphereComponent uSphereComponent2 = uActorComponent2 as USphereComponent;
		if (uSphereComponent2 == null)
		{
			ErrorLog += "未成功添加新交互Comp：\n";
			return false;
		}
		uActorComponent2.ComponentTags.Add(B1GlobalFNames.Interact_2);
		uSphereComponent2.SetRelativeTransform(ProjectileBaseActor_CDO.ProjectileConfigInfoComp.Interact_End_LocalTransform, bSweep: false, out var _, bTeleport: false);
		uSphereComponent2.SetSphereRadius(ProjectileBaseActor_CDO.ProjectileConfigInfoComp.Interact_End_SphereRadius);
		uSphereComponent2.SetCollisionProfileName(B1GlobalFNames.NoCollision);
		uSphereComponent2.CanCharacterStepUpOn = ECanBeCharacterBase.ECB_No;
		uSphereComponent2.HiddenInGame = true;
		uSphereComponent2.IsEditorOnly = true;
		return true;
	}

	[Tooltip("更改抛射物的ShapeType")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:ModifyProjectileCheckShapeType")]
	public static bool ModifyProjectileCheckShapeType(BGUProjectileBaseActor ProjectileBaseActor_CDO, UBlueprint BP, EProjectileCheckShapeType CheckShape, out string ErrorLog)
	{
		ErrorLog = "";
		ProjectileBaseActor_CDO.ProjectileConfigInfoComp.CheckShapeType = CheckShape;
		UGSE_AnimFuncLib.MarkDirty(ProjectileBaseActor_CDO);
		return true;
	}

	[BlueprintCallable]
	[UFunction]
	[Tooltip("校验子弹用到了哪些Effect类型")]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:CheckEffectsUsedInBulletExpand")]
	public static string CheckEffectsUsedInBulletExpand()
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStBulletExpandDesc>();
		Dictionary<int, FUStBulletExpandDesc> allBulletExpandDesc = BGW_GameDB.GetAllBulletExpandDesc();
		Dictionary<EBuffAndSkillEffectType, List<int>> EffectDic = new Dictionary<EBuffAndSkillEffectType, List<int>>();
		new List<int>();
		foreach (KeyValuePair<int, FUStBulletExpandDesc> item in allBulletExpandDesc)
		{
			CheckEffect(item.Value.LifeOverEffectID.ToList(), ref EffectDic);
			CheckEffect(item.Value.HitChrEffectsforSelf.ToList(), ref EffectDic);
			CheckEffect(item.Value.HitItemEffectsforSelf.ToList(), ref EffectDic);
			CheckEffect(item.Value.HitEffectsforChr.ToList(), ref EffectDic);
			CheckEffect(item.Value.HitProjectileEffectsforSelf.ToList(), ref EffectDic);
			CheckEffect(item.Value.HitEffectsforProjectile.ToList(), ref EffectDic);
			CheckEffect(item.Value.HitDestructibleEffectsforSelf.ToList(), ref EffectDic);
		}
		string text = "";
		foreach (KeyValuePair<EBuffAndSkillEffectType, List<int>> item2 in EffectDic)
		{
			text += item2.Key;
			text += "    ";
			foreach (int item3 in item2.Value)
			{
				text += item3;
				text += ", ";
			}
			text += "\n";
		}
		return text;
		static void CheckEffect(List<int> EffectIDList, ref Dictionary<EBuffAndSkillEffectType, List<int>> reference)
		{
			foreach (int EffectID in EffectIDList)
			{
				GetSkillEffectType_ByEffectID(EffectID, out var EffectType);
				if (reference.ContainsKey(EffectType))
				{
					if (!reference[EffectType].Contains(EffectID))
					{
						reference[EffectType].Add(EffectID);
					}
				}
				else
				{
					reference.Add(EffectType, new List<int>());
					reference[EffectType].Add(EffectID);
				}
			}
		}
		static bool GetSkillEffectType_ByEffectID(int EffectID, out EBuffAndSkillEffectType EffectType)
		{
			EffectType = EBuffAndSkillEffectType.None;
			FUStSkillEffectDesc originalSkillEffectDesc = BGW_GameDB.GetOriginalSkillEffectDesc(EffectID);
			if (originalSkillEffectDesc == null)
			{
				return false;
			}
			EffectType = originalSkillEffectDesc.EffectType;
			return true;
		}
	}

	[Tooltip("获取Buff中配置的效果类型")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:GetBuffEffectTypes")]
	public static List<EBuffAndSkillEffectType> GetBuffEffectTypes(int BuffID)
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStBulletExpandDesc>();
		List<EBuffAndSkillEffectType> list = new List<EBuffAndSkillEffectType>();
		FUStBuffDesc originalBuffDesc = BGW_GameDB.GetOriginalBuffDesc(BuffID);
		if (originalBuffDesc != null)
		{
			foreach (FUStBuffEffectAttr buffEffect in originalBuffDesc.BuffEffects)
			{
				if (!list.Contains(buffEffect.EffectType))
				{
					list.Add(buffEffect.EffectType);
				}
			}
		}
		return list;
	}

	[Tooltip("校验子弹用到了哪些Buff")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:CheckBuffUsedInBullet")]
	public static List<int> CheckBuffUsedInBullet()
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStBuffDesc>();
		Dictionary<int, FUStBuffDesc> allBuffDesc = BGW_GameDB.GetAllBuffDesc();
		List<int> list = new List<int>();
		foreach (KeyValuePair<int, FUStBuffDesc> item in allBuffDesc)
		{
			if ((item.Value.TargetTypeFilter & 4) != 0)
			{
				list.Add(item.Key);
			}
		}
		return list;
	}

	[Tooltip("校验子弹用到了哪些BuffDisp")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:CheckBuffDispUsedInBullet")]
	public static List<int> CheckBuffDispUsedInBullet()
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStBuffDispDesc>();
		new List<int>();
		List<int> list = CheckBuffUsedInBullet();
		List<int> list2 = new List<int>();
		foreach (int item in list)
		{
			if (BGW_GameDB.GetBuffDispDesc(0, item, 0) != null)
			{
				list2.Add(item);
			}
		}
		return list2;
	}

	[Tooltip("校验抛射物类型, 0:错误， 1：子弹， 2：法术场")]
	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:GetProjectileType")]
	public static int GetProjectileType(int ProjectileID)
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStProjectileCommDesc>();
		FUStProjectileCommDesc projectileCommDesc = BGW_GameDB.GetProjectileCommDesc(ProjectileID, null);
		if (projectileCommDesc == null)
		{
			return 0;
		}
		string projectileBPTemplatePath = projectileCommDesc.ProjectileBPTemplatePath;
		string path = projectileBPTemplatePath.Substring(0, projectileBPTemplatePath.Length - 2);
		UBlueprint Blueprint;
		UObject uObject = UGSE_EditorFuncLib.AssetPath_GetCDO(null, path, out Blueprint);
		if (uObject as BGUBulletBaseCS != null)
		{
			return 1;
		}
		if (uObject as BGUMagicFieldBaseCS != null)
		{
			return 2;
		}
		return 0;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibProjectile:FindProjectileAboutFlame")]
	public static bool FindProjectileAboutFlame(out string ErrorLog)
	{
		BGUFuncLibNonRuntime.LoadProtobufData<FUStProjectileCommDesc>();
		Dictionary<int, FUStProjectileCommDesc> allProjectileCommDesc = BGW_GameDB.GetAllProjectileCommDesc();
		List<string> KeyWords = new List<string> { "fire", "boom", "lava", "explode", "huo", "flame", "bao" };
		List<string> list = new List<string>();
		Dictionary<string, List<int>> dictionary = new Dictionary<string, List<int>>();
		foreach (KeyValuePair<int, FUStProjectileCommDesc> item in allProjectileCommDesc)
		{
			string projectileBPTemplatePath = item.Value.ProjectileBPTemplatePath;
			if (string.IsNullOrEmpty(projectileBPTemplatePath))
			{
				continue;
			}
			if (!dictionary.ContainsKey(projectileBPTemplatePath))
			{
				List<int> list2 = new List<int>();
				list2.Add(item.Key);
				dictionary.Add(projectileBPTemplatePath, list2);
				if (MayBeFire(projectileBPTemplatePath))
				{
					list.Add(projectileBPTemplatePath);
				}
			}
			else
			{
				dictionary[projectileBPTemplatePath].Add(item.Key);
			}
		}
		ErrorLog = "";
		List<string> list3 = new List<string>();
		foreach (string key in dictionary.Keys)
		{
			try
			{
				if (list.Contains(key))
				{
					continue;
				}
				string path = key.Substring(0, key.Length - 2);
				UBlueprint Blueprint;
				BGUProjectileBaseActor bGUProjectileBaseActor = UGSE_EditorFuncLib.AssetPath_GetCDO(null, path, out Blueprint) as BGUProjectileBaseActor;
				if (!(bGUProjectileBaseActor != null))
				{
					continue;
				}
				foreach (UActorComponent cDONodeComponent in UGSFuncLibForEditor.GetCDONodeComponents(bGUProjectileBaseActor))
				{
					if (!(cDONodeComponent.GetClass() == UClass.GetClass<UNiagaraComponent>()))
					{
						continue;
					}
					UNiagaraComponent uNiagaraComponent = cDONodeComponent as UNiagaraComponent;
					if (!(uNiagaraComponent == null))
					{
						UNiagaraSystem asset = uNiagaraComponent.GetAsset();
						if (!(asset == null) && MayBeFire(asset.GetFName().ToString()))
						{
							list.Add(key);
							break;
						}
					}
				}
			}
			catch
			{
				list3.Add(key);
			}
		}
		return true;
		bool MayBeFire(string Path)
		{
			string text = Path.ToLower();
			foreach (string item2 in KeyWords)
			{
				if (text.Contains(item2))
				{
					return true;
				}
			}
			return false;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:GetProjectileType")]
	private static void GetProjectileType__Invoker(IntPtr buffer, IntPtr obj)
	{
		int projectileID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, GetProjectileType_ProjectileID_Offset));
		int projectileType = GetProjectileType(projectileID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(buffer, GetProjectileType_ReturnValue_Offset), projectileType);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:GetBuffEffectTypes")]
	private static void GetBuffEffectTypes__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<EBuffAndSkillEffectType> tArrayCopyMarshaler = new TArrayCopyMarshaler<EBuffAndSkillEffectType>(1, GetBuffEffectTypes_ReturnValue_PropertyAddress, CachedMarshalingDelegates<EBuffAndSkillEffectType, EnumMarshaler<EBuffAndSkillEffectType>>.FromNative, CachedMarshalingDelegates<EBuffAndSkillEffectType, EnumMarshaler<EBuffAndSkillEffectType>>.ToNative);
		int buffID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, GetBuffEffectTypes_BuffID_Offset));
		List<EBuffAndSkillEffectType> buffEffectTypes = GetBuffEffectTypes(buffID);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetBuffEffectTypes_ReturnValue_Offset), buffEffectTypes);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:GetCtrProjectileByID")]
	private static void GetCtrProjectileByID__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUCharacterCS curCharacter = UObjectMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(buffer, GetCtrProjectileByID_CurCharacter_Offset));
		int projectileID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, GetCtrProjectileByID_ProjectileID_Offset));
		AActor ctrProjectileByID = GetCtrProjectileByID(curCharacter, projectileID);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, GetCtrProjectileByID_ReturnValue_Offset), ctrProjectileByID);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:CheckCompHasChildComp")]
	private static void CheckCompHasChildComp__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, CheckCompHasChildComp_ErrorBPPathList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> ErrorBPPathList = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, CheckCompHasChildComp_ErrorBPPathList_Offset));
		CheckCompHasChildComp(out ErrorBPPathList);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, CheckCompHasChildComp_ErrorBPPathList_Offset), ErrorBPPathList);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:CheckBuffUsedInBullet")]
	private static void CheckBuffUsedInBullet__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<int> tArrayCopyMarshaler = new TArrayCopyMarshaler<int>(1, CheckBuffUsedInBullet_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
		List<int> value = CheckBuffUsedInBullet();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, CheckBuffUsedInBullet_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:CheckOutAllProjectileBP")]
	private static void CheckOutAllProjectileBP__Invoker(IntPtr buffer, IntPtr obj)
	{
		string CheckOutMap;
		bool value = CheckOutAllProjectileBP(out CheckOutMap);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CheckOutAllProjectileBP_ReturnValue_Offset), 0, CheckOutAllProjectileBP_ReturnValue_PropertyAddress.Address, value);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, CheckOutAllProjectileBP_CheckOutMap_Offset), CheckOutMap);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:FindProjectileAboutFlame")]
	private static void FindProjectileAboutFlame__Invoker(IntPtr buffer, IntPtr obj)
	{
		string ErrorLog;
		bool value = FindProjectileAboutFlame(out ErrorLog);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, FindProjectileAboutFlame_ReturnValue_Offset), 0, FindProjectileAboutFlame_ReturnValue_PropertyAddress.Address, value);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, FindProjectileAboutFlame_ErrorLog_Offset), ErrorLog);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:CheckBuffDispUsedInBullet")]
	private static void CheckBuffDispUsedInBullet__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<int> tArrayCopyMarshaler = new TArrayCopyMarshaler<int>(1, CheckBuffDispUsedInBullet_ReturnValue_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
		List<int> value = CheckBuffDispUsedInBullet();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, CheckBuffDispUsedInBullet_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetCheck_Full")]
	private static void ProjectileAssetCheck_Full__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, ProjectileAssetCheck_Full_MarkDirtyList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> MarkDirtyList = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, ProjectileAssetCheck_Full_MarkDirtyList_Offset));
		string ErrorLog;
		bool value = ProjectileAssetCheck_Full(out ErrorLog, out MarkDirtyList);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ProjectileAssetCheck_Full_ReturnValue_Offset), 0, ProjectileAssetCheck_Full_ReturnValue_PropertyAddress.Address, value);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, ProjectileAssetCheck_Full_ErrorLog_Offset), ErrorLog);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, ProjectileAssetCheck_Full_MarkDirtyList_Offset), MarkDirtyList);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetCheck_Single")]
	private static void ProjectileAssetCheck_Single__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor projectileBaseActor_CDO = UObjectMarshaler<BGUProjectileBaseActor>.FromNative(IntPtr.Add(buffer, ProjectileAssetCheck_Single_ProjectileBaseActor_CDO_Offset));
		bool bNeedLoadData = BoolMarshaler.FromNative(IntPtr.Add(buffer, ProjectileAssetCheck_Single_bNeedLoadData_Offset), 0, ProjectileAssetCheck_Single_bNeedLoadData_PropertyAddress.Address);
		string ErrorLog;
		bool value = ProjectileAssetCheck_Single(projectileBaseActor_CDO, out ErrorLog, bNeedLoadData);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ProjectileAssetCheck_Single_ReturnValue_Offset), 0, ProjectileAssetCheck_Single_ReturnValue_PropertyAddress.Address, value);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, ProjectileAssetCheck_Single_ErrorLog_Offset), ErrorLog);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:CreateCheckCompForProjectile")]
	private static void CreateCheckCompForProjectile__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor projectileBaseActor_CDO = UObjectMarshaler<BGUProjectileBaseActor>.FromNative(IntPtr.Add(buffer, CreateCheckCompForProjectile_ProjectileBaseActor_CDO_Offset));
		UBlueprint bP = UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(buffer, CreateCheckCompForProjectile_BP_Offset));
		EProjectileCheckShapeType checkShape = EnumMarshaler<EProjectileCheckShapeType>.FromNative(IntPtr.Add(buffer, CreateCheckCompForProjectile_CheckShape_Offset), 0, CreateCheckCompForProjectile_CheckShape_PropertyAddress.Address);
		bool bNeedLoadData = BoolMarshaler.FromNative(IntPtr.Add(buffer, CreateCheckCompForProjectile_bNeedLoadData_Offset), 0, CreateCheckCompForProjectile_bNeedLoadData_PropertyAddress.Address);
		string ErrorLog;
		bool value = CreateCheckCompForProjectile(projectileBaseActor_CDO, bP, checkShape, out ErrorLog, bNeedLoadData);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CreateCheckCompForProjectile_ReturnValue_Offset), 0, CreateCheckCompForProjectile_ReturnValue_PropertyAddress.Address, value);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, CreateCheckCompForProjectile_ErrorLog_Offset), ErrorLog);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:ModifyProjectileCheckShapeType")]
	private static void ModifyProjectileCheckShapeType__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor projectileBaseActor_CDO = UObjectMarshaler<BGUProjectileBaseActor>.FromNative(IntPtr.Add(buffer, ModifyProjectileCheckShapeType_ProjectileBaseActor_CDO_Offset));
		UBlueprint bP = UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(buffer, ModifyProjectileCheckShapeType_BP_Offset));
		EProjectileCheckShapeType checkShape = EnumMarshaler<EProjectileCheckShapeType>.FromNative(IntPtr.Add(buffer, ModifyProjectileCheckShapeType_CheckShape_Offset), 0, ModifyProjectileCheckShapeType_CheckShape_PropertyAddress.Address);
		string ErrorLog;
		bool value = ModifyProjectileCheckShapeType(projectileBaseActor_CDO, bP, checkShape, out ErrorLog);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ModifyProjectileCheckShapeType_ReturnValue_Offset), 0, ModifyProjectileCheckShapeType_ReturnValue_PropertyAddress.Address, value);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, ModifyProjectileCheckShapeType_ErrorLog_Offset), ErrorLog);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:CheckEffectsUsedInBulletExpand")]
	private static void CheckEffectsUsedInBulletExpand__Invoker(IntPtr buffer, IntPtr obj)
	{
		string value = CheckEffectsUsedInBulletExpand();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, CheckEffectsUsedInBulletExpand_ReturnValue_Offset), value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:CreateInteractCompForProjectile")]
	private static void CreateInteractCompForProjectile__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor projectileBaseActor_CDO = UObjectMarshaler<BGUProjectileBaseActor>.FromNative(IntPtr.Add(buffer, CreateInteractCompForProjectile_ProjectileBaseActor_CDO_Offset));
		UBlueprint bP = UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(buffer, CreateInteractCompForProjectile_BP_Offset));
		string ErrorLog;
		bool value = CreateInteractCompForProjectile(projectileBaseActor_CDO, bP, out ErrorLog);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, CreateInteractCompForProjectile_ReturnValue_Offset), 0, CreateInteractCompForProjectile_ReturnValue_PropertyAddress.Address, value);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, CreateInteractCompForProjectile_ErrorLog_Offset), ErrorLog);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetMoveCompToBP_Full")]
	private static void ProjectileAssetMoveCompToBP_Full__Invoker(IntPtr buffer, IntPtr obj)
	{
		ProjectileAssetMoveCompToBP_Full(out var ErrorLog);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, ProjectileAssetMoveCompToBP_Full_ErrorLog_Offset), ErrorLog);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetMoveCompToBP_Single")]
	private static void ProjectileAssetMoveCompToBP_Single__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUProjectileBaseActor projectileBaseActor_CDO = UObjectMarshaler<BGUProjectileBaseActor>.FromNative(IntPtr.Add(buffer, ProjectileAssetMoveCompToBP_Single_ProjectileBaseActor_CDO_Offset));
		UBlueprint bP = UObjectMarshaler<UBlueprint>.FromNative(IntPtr.Add(buffer, ProjectileAssetMoveCompToBP_Single_BP_Offset));
		bool bNeedLoadData = BoolMarshaler.FromNative(IntPtr.Add(buffer, ProjectileAssetMoveCompToBP_Single_bNeedLoadData_Offset), 0, ProjectileAssetMoveCompToBP_Single_bNeedLoadData_PropertyAddress.Address);
		ProjectileAssetMoveCompToBP_Single(projectileBaseActor_CDO, bP, out var ErrorLog, bNeedLoadData);
		FStringMarshaler.ToNative(IntPtr.Add(buffer, ProjectileAssetMoveCompToBP_Single_ErrorLog_Offset), ErrorLog);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:GetAllProjectileBPPathFromDesc_with_C")]
	private static void GetAllProjectileBPPathFromDesc_with_C__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, GetAllProjectileBPPathFromDesc_with_C_CurrentUsedBPPath_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> CurrentUsedBPPath = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetAllProjectileBPPathFromDesc_with_C_CurrentUsedBPPath_Offset));
		GetAllProjectileBPPathFromDesc_with_C(out CurrentUsedBPPath);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetAllProjectileBPPathFromDesc_with_C_CurrentUsedBPPath_Offset), CurrentUsedBPPath);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibProjectile:GetAllProjectileBPPathFromDesc_without_C")]
	private static void GetAllProjectileBPPathFromDesc_without_C__Invoker(IntPtr buffer, IntPtr obj)
	{
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, GetAllProjectileBPPathFromDesc_without_C_CurrentUsedBPPath_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		List<string> CurrentUsedBPPath = tArrayCopyMarshaler.FromNative(IntPtr.Add(buffer, GetAllProjectileBPPathFromDesc_without_C_CurrentUsedBPPath_Offset));
		GetAllProjectileBPPathFromDesc_without_C(out CurrentUsedBPPath);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetAllProjectileBPPathFromDesc_without_C_CurrentUsedBPPath_Offset), CurrentUsedBPPath);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibProjectile");
		GetProjectileType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetProjectileType");
		GetProjectileType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProjectileType_FunctionAddress);
		GetProjectileType_ProjectileID_Offset = NativeReflection.GetPropertyOffset(GetProjectileType_FunctionAddress, "ProjectileID");
		GetProjectileType_ProjectileID_IsValid = NativeReflection.ValidatePropertyClass(GetProjectileType_FunctionAddress, "ProjectileID", Classes.FIntProperty);
		GetProjectileType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetProjectileType_FunctionAddress, "ReturnValue");
		GetProjectileType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetProjectileType_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetProjectileType_IsValid = GetProjectileType_FunctionAddress != IntPtr.Zero && GetProjectileType_ProjectileID_IsValid && GetProjectileType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:GetProjectileType", GetProjectileType_IsValid);
		GetBuffEffectTypes_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBuffEffectTypes");
		GetBuffEffectTypes_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBuffEffectTypes_FunctionAddress);
		GetBuffEffectTypes_BuffID_Offset = NativeReflection.GetPropertyOffset(GetBuffEffectTypes_FunctionAddress, "BuffID");
		GetBuffEffectTypes_BuffID_IsValid = NativeReflection.ValidatePropertyClass(GetBuffEffectTypes_FunctionAddress, "BuffID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref GetBuffEffectTypes_ReturnValue_PropertyAddress, GetBuffEffectTypes_FunctionAddress, "ReturnValue");
		GetBuffEffectTypes_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetBuffEffectTypes_FunctionAddress, "ReturnValue");
		GetBuffEffectTypes_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetBuffEffectTypes_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBuffEffectTypes_IsValid = GetBuffEffectTypes_FunctionAddress != IntPtr.Zero && GetBuffEffectTypes_BuffID_IsValid && GetBuffEffectTypes_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:GetBuffEffectTypes", GetBuffEffectTypes_IsValid);
		GetCtrProjectileByID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetCtrProjectileByID");
		GetCtrProjectileByID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCtrProjectileByID_FunctionAddress);
		GetCtrProjectileByID_CurCharacter_Offset = NativeReflection.GetPropertyOffset(GetCtrProjectileByID_FunctionAddress, "CurCharacter");
		GetCtrProjectileByID_CurCharacter_IsValid = NativeReflection.ValidatePropertyClass(GetCtrProjectileByID_FunctionAddress, "CurCharacter", Classes.FObjectProperty);
		GetCtrProjectileByID_ProjectileID_Offset = NativeReflection.GetPropertyOffset(GetCtrProjectileByID_FunctionAddress, "ProjectileID");
		GetCtrProjectileByID_ProjectileID_IsValid = NativeReflection.ValidatePropertyClass(GetCtrProjectileByID_FunctionAddress, "ProjectileID", Classes.FIntProperty);
		GetCtrProjectileByID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetCtrProjectileByID_FunctionAddress, "ReturnValue");
		GetCtrProjectileByID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetCtrProjectileByID_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCtrProjectileByID_IsValid = GetCtrProjectileByID_FunctionAddress != IntPtr.Zero && GetCtrProjectileByID_CurCharacter_IsValid && GetCtrProjectileByID_ProjectileID_IsValid && GetCtrProjectileByID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:GetCtrProjectileByID", GetCtrProjectileByID_IsValid);
		CheckCompHasChildComp_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckCompHasChildComp");
		CheckCompHasChildComp_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckCompHasChildComp_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckCompHasChildComp_ErrorBPPathList_PropertyAddress, CheckCompHasChildComp_FunctionAddress, "ErrorBPPathList");
		CheckCompHasChildComp_ErrorBPPathList_Offset = NativeReflection.GetPropertyOffset(CheckCompHasChildComp_FunctionAddress, "ErrorBPPathList");
		CheckCompHasChildComp_ErrorBPPathList_IsValid = NativeReflection.ValidatePropertyClass(CheckCompHasChildComp_FunctionAddress, "ErrorBPPathList", Classes.FArrayProperty);
		CheckCompHasChildComp_IsValid = CheckCompHasChildComp_FunctionAddress != IntPtr.Zero && CheckCompHasChildComp_ErrorBPPathList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:CheckCompHasChildComp", CheckCompHasChildComp_IsValid);
		CheckBuffUsedInBullet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckBuffUsedInBullet");
		CheckBuffUsedInBullet_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBuffUsedInBullet_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBuffUsedInBullet_ReturnValue_PropertyAddress, CheckBuffUsedInBullet_FunctionAddress, "ReturnValue");
		CheckBuffUsedInBullet_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckBuffUsedInBullet_FunctionAddress, "ReturnValue");
		CheckBuffUsedInBullet_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckBuffUsedInBullet_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CheckBuffUsedInBullet_IsValid = CheckBuffUsedInBullet_FunctionAddress != IntPtr.Zero && CheckBuffUsedInBullet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:CheckBuffUsedInBullet", CheckBuffUsedInBullet_IsValid);
		CheckOutAllProjectileBP_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckOutAllProjectileBP");
		CheckOutAllProjectileBP_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckOutAllProjectileBP_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckOutAllProjectileBP_CheckOutMap_PropertyAddress, CheckOutAllProjectileBP_FunctionAddress, "CheckOutMap");
		CheckOutAllProjectileBP_CheckOutMap_Offset = NativeReflection.GetPropertyOffset(CheckOutAllProjectileBP_FunctionAddress, "CheckOutMap");
		CheckOutAllProjectileBP_CheckOutMap_IsValid = NativeReflection.ValidatePropertyClass(CheckOutAllProjectileBP_FunctionAddress, "CheckOutMap", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref CheckOutAllProjectileBP_ReturnValue_PropertyAddress, CheckOutAllProjectileBP_FunctionAddress, "ReturnValue");
		CheckOutAllProjectileBP_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckOutAllProjectileBP_FunctionAddress, "ReturnValue");
		CheckOutAllProjectileBP_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckOutAllProjectileBP_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckOutAllProjectileBP_IsValid = CheckOutAllProjectileBP_FunctionAddress != IntPtr.Zero && CheckOutAllProjectileBP_CheckOutMap_IsValid && CheckOutAllProjectileBP_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:CheckOutAllProjectileBP", CheckOutAllProjectileBP_IsValid);
		FindProjectileAboutFlame_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindProjectileAboutFlame");
		FindProjectileAboutFlame_ParamsSize = NativeReflection.GetFunctionParamsSize(FindProjectileAboutFlame_FunctionAddress);
		NativeReflection.GetPropertyRef(ref FindProjectileAboutFlame_ErrorLog_PropertyAddress, FindProjectileAboutFlame_FunctionAddress, "ErrorLog");
		FindProjectileAboutFlame_ErrorLog_Offset = NativeReflection.GetPropertyOffset(FindProjectileAboutFlame_FunctionAddress, "ErrorLog");
		FindProjectileAboutFlame_ErrorLog_IsValid = NativeReflection.ValidatePropertyClass(FindProjectileAboutFlame_FunctionAddress, "ErrorLog", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref FindProjectileAboutFlame_ReturnValue_PropertyAddress, FindProjectileAboutFlame_FunctionAddress, "ReturnValue");
		FindProjectileAboutFlame_ReturnValue_Offset = NativeReflection.GetPropertyOffset(FindProjectileAboutFlame_FunctionAddress, "ReturnValue");
		FindProjectileAboutFlame_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(FindProjectileAboutFlame_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FindProjectileAboutFlame_IsValid = FindProjectileAboutFlame_FunctionAddress != IntPtr.Zero && FindProjectileAboutFlame_ErrorLog_IsValid && FindProjectileAboutFlame_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:FindProjectileAboutFlame", FindProjectileAboutFlame_IsValid);
		CheckBuffDispUsedInBullet_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckBuffDispUsedInBullet");
		CheckBuffDispUsedInBullet_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckBuffDispUsedInBullet_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckBuffDispUsedInBullet_ReturnValue_PropertyAddress, CheckBuffDispUsedInBullet_FunctionAddress, "ReturnValue");
		CheckBuffDispUsedInBullet_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckBuffDispUsedInBullet_FunctionAddress, "ReturnValue");
		CheckBuffDispUsedInBullet_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckBuffDispUsedInBullet_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		CheckBuffDispUsedInBullet_IsValid = CheckBuffDispUsedInBullet_FunctionAddress != IntPtr.Zero && CheckBuffDispUsedInBullet_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:CheckBuffDispUsedInBullet", CheckBuffDispUsedInBullet_IsValid);
		ProjectileAssetCheck_Full_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProjectileAssetCheck_Full");
		ProjectileAssetCheck_Full_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectileAssetCheck_Full_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ProjectileAssetCheck_Full_ErrorLog_PropertyAddress, ProjectileAssetCheck_Full_FunctionAddress, "ErrorLog");
		ProjectileAssetCheck_Full_ErrorLog_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetCheck_Full_FunctionAddress, "ErrorLog");
		ProjectileAssetCheck_Full_ErrorLog_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetCheck_Full_FunctionAddress, "ErrorLog", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ProjectileAssetCheck_Full_MarkDirtyList_PropertyAddress, ProjectileAssetCheck_Full_FunctionAddress, "MarkDirtyList");
		ProjectileAssetCheck_Full_MarkDirtyList_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetCheck_Full_FunctionAddress, "MarkDirtyList");
		ProjectileAssetCheck_Full_MarkDirtyList_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetCheck_Full_FunctionAddress, "MarkDirtyList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref ProjectileAssetCheck_Full_ReturnValue_PropertyAddress, ProjectileAssetCheck_Full_FunctionAddress, "ReturnValue");
		ProjectileAssetCheck_Full_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetCheck_Full_FunctionAddress, "ReturnValue");
		ProjectileAssetCheck_Full_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetCheck_Full_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProjectileAssetCheck_Full_IsValid = ProjectileAssetCheck_Full_FunctionAddress != IntPtr.Zero && ProjectileAssetCheck_Full_ErrorLog_IsValid && ProjectileAssetCheck_Full_MarkDirtyList_IsValid && ProjectileAssetCheck_Full_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetCheck_Full", ProjectileAssetCheck_Full_IsValid);
		ProjectileAssetCheck_Single_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProjectileAssetCheck_Single");
		ProjectileAssetCheck_Single_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectileAssetCheck_Single_FunctionAddress);
		ProjectileAssetCheck_Single_ProjectileBaseActor_CDO_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetCheck_Single_FunctionAddress, "ProjectileBaseActor_CDO");
		ProjectileAssetCheck_Single_ProjectileBaseActor_CDO_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetCheck_Single_FunctionAddress, "ProjectileBaseActor_CDO", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ProjectileAssetCheck_Single_ErrorLog_PropertyAddress, ProjectileAssetCheck_Single_FunctionAddress, "ErrorLog");
		ProjectileAssetCheck_Single_ErrorLog_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetCheck_Single_FunctionAddress, "ErrorLog");
		ProjectileAssetCheck_Single_ErrorLog_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetCheck_Single_FunctionAddress, "ErrorLog", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ProjectileAssetCheck_Single_bNeedLoadData_PropertyAddress, ProjectileAssetCheck_Single_FunctionAddress, "bNeedLoadData");
		ProjectileAssetCheck_Single_bNeedLoadData_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetCheck_Single_FunctionAddress, "bNeedLoadData");
		ProjectileAssetCheck_Single_bNeedLoadData_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetCheck_Single_FunctionAddress, "bNeedLoadData", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ProjectileAssetCheck_Single_ReturnValue_PropertyAddress, ProjectileAssetCheck_Single_FunctionAddress, "ReturnValue");
		ProjectileAssetCheck_Single_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetCheck_Single_FunctionAddress, "ReturnValue");
		ProjectileAssetCheck_Single_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetCheck_Single_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProjectileAssetCheck_Single_IsValid = ProjectileAssetCheck_Single_FunctionAddress != IntPtr.Zero && ProjectileAssetCheck_Single_ProjectileBaseActor_CDO_IsValid && ProjectileAssetCheck_Single_ErrorLog_IsValid && ProjectileAssetCheck_Single_bNeedLoadData_IsValid && ProjectileAssetCheck_Single_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetCheck_Single", ProjectileAssetCheck_Single_IsValid);
		CreateCheckCompForProjectile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateCheckCompForProjectile");
		CreateCheckCompForProjectile_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateCheckCompForProjectile_FunctionAddress);
		CreateCheckCompForProjectile_ProjectileBaseActor_CDO_Offset = NativeReflection.GetPropertyOffset(CreateCheckCompForProjectile_FunctionAddress, "ProjectileBaseActor_CDO");
		CreateCheckCompForProjectile_ProjectileBaseActor_CDO_IsValid = NativeReflection.ValidatePropertyClass(CreateCheckCompForProjectile_FunctionAddress, "ProjectileBaseActor_CDO", Classes.FObjectProperty);
		CreateCheckCompForProjectile_BP_Offset = NativeReflection.GetPropertyOffset(CreateCheckCompForProjectile_FunctionAddress, "BP");
		CreateCheckCompForProjectile_BP_IsValid = NativeReflection.ValidatePropertyClass(CreateCheckCompForProjectile_FunctionAddress, "BP", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CreateCheckCompForProjectile_CheckShape_PropertyAddress, CreateCheckCompForProjectile_FunctionAddress, "CheckShape");
		CreateCheckCompForProjectile_CheckShape_Offset = NativeReflection.GetPropertyOffset(CreateCheckCompForProjectile_FunctionAddress, "CheckShape");
		CreateCheckCompForProjectile_CheckShape_IsValid = NativeReflection.ValidatePropertyClass(CreateCheckCompForProjectile_FunctionAddress, "CheckShape", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref CreateCheckCompForProjectile_ErrorLog_PropertyAddress, CreateCheckCompForProjectile_FunctionAddress, "ErrorLog");
		CreateCheckCompForProjectile_ErrorLog_Offset = NativeReflection.GetPropertyOffset(CreateCheckCompForProjectile_FunctionAddress, "ErrorLog");
		CreateCheckCompForProjectile_ErrorLog_IsValid = NativeReflection.ValidatePropertyClass(CreateCheckCompForProjectile_FunctionAddress, "ErrorLog", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref CreateCheckCompForProjectile_bNeedLoadData_PropertyAddress, CreateCheckCompForProjectile_FunctionAddress, "bNeedLoadData");
		CreateCheckCompForProjectile_bNeedLoadData_Offset = NativeReflection.GetPropertyOffset(CreateCheckCompForProjectile_FunctionAddress, "bNeedLoadData");
		CreateCheckCompForProjectile_bNeedLoadData_IsValid = NativeReflection.ValidatePropertyClass(CreateCheckCompForProjectile_FunctionAddress, "bNeedLoadData", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref CreateCheckCompForProjectile_ReturnValue_PropertyAddress, CreateCheckCompForProjectile_FunctionAddress, "ReturnValue");
		CreateCheckCompForProjectile_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CreateCheckCompForProjectile_FunctionAddress, "ReturnValue");
		CreateCheckCompForProjectile_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CreateCheckCompForProjectile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CreateCheckCompForProjectile_IsValid = CreateCheckCompForProjectile_FunctionAddress != IntPtr.Zero && CreateCheckCompForProjectile_ProjectileBaseActor_CDO_IsValid && CreateCheckCompForProjectile_BP_IsValid && CreateCheckCompForProjectile_CheckShape_IsValid && CreateCheckCompForProjectile_ErrorLog_IsValid && CreateCheckCompForProjectile_bNeedLoadData_IsValid && CreateCheckCompForProjectile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:CreateCheckCompForProjectile", CreateCheckCompForProjectile_IsValid);
		ModifyProjectileCheckShapeType_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ModifyProjectileCheckShapeType");
		ModifyProjectileCheckShapeType_ParamsSize = NativeReflection.GetFunctionParamsSize(ModifyProjectileCheckShapeType_FunctionAddress);
		ModifyProjectileCheckShapeType_ProjectileBaseActor_CDO_Offset = NativeReflection.GetPropertyOffset(ModifyProjectileCheckShapeType_FunctionAddress, "ProjectileBaseActor_CDO");
		ModifyProjectileCheckShapeType_ProjectileBaseActor_CDO_IsValid = NativeReflection.ValidatePropertyClass(ModifyProjectileCheckShapeType_FunctionAddress, "ProjectileBaseActor_CDO", Classes.FObjectProperty);
		ModifyProjectileCheckShapeType_BP_Offset = NativeReflection.GetPropertyOffset(ModifyProjectileCheckShapeType_FunctionAddress, "BP");
		ModifyProjectileCheckShapeType_BP_IsValid = NativeReflection.ValidatePropertyClass(ModifyProjectileCheckShapeType_FunctionAddress, "BP", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ModifyProjectileCheckShapeType_CheckShape_PropertyAddress, ModifyProjectileCheckShapeType_FunctionAddress, "CheckShape");
		ModifyProjectileCheckShapeType_CheckShape_Offset = NativeReflection.GetPropertyOffset(ModifyProjectileCheckShapeType_FunctionAddress, "CheckShape");
		ModifyProjectileCheckShapeType_CheckShape_IsValid = NativeReflection.ValidatePropertyClass(ModifyProjectileCheckShapeType_FunctionAddress, "CheckShape", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref ModifyProjectileCheckShapeType_ErrorLog_PropertyAddress, ModifyProjectileCheckShapeType_FunctionAddress, "ErrorLog");
		ModifyProjectileCheckShapeType_ErrorLog_Offset = NativeReflection.GetPropertyOffset(ModifyProjectileCheckShapeType_FunctionAddress, "ErrorLog");
		ModifyProjectileCheckShapeType_ErrorLog_IsValid = NativeReflection.ValidatePropertyClass(ModifyProjectileCheckShapeType_FunctionAddress, "ErrorLog", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ModifyProjectileCheckShapeType_ReturnValue_PropertyAddress, ModifyProjectileCheckShapeType_FunctionAddress, "ReturnValue");
		ModifyProjectileCheckShapeType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ModifyProjectileCheckShapeType_FunctionAddress, "ReturnValue");
		ModifyProjectileCheckShapeType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ModifyProjectileCheckShapeType_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ModifyProjectileCheckShapeType_IsValid = ModifyProjectileCheckShapeType_FunctionAddress != IntPtr.Zero && ModifyProjectileCheckShapeType_ProjectileBaseActor_CDO_IsValid && ModifyProjectileCheckShapeType_BP_IsValid && ModifyProjectileCheckShapeType_CheckShape_IsValid && ModifyProjectileCheckShapeType_ErrorLog_IsValid && ModifyProjectileCheckShapeType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:ModifyProjectileCheckShapeType", ModifyProjectileCheckShapeType_IsValid);
		CheckEffectsUsedInBulletExpand_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CheckEffectsUsedInBulletExpand");
		CheckEffectsUsedInBulletExpand_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckEffectsUsedInBulletExpand_FunctionAddress);
		NativeReflection.GetPropertyRef(ref CheckEffectsUsedInBulletExpand_ReturnValue_PropertyAddress, CheckEffectsUsedInBulletExpand_FunctionAddress, "ReturnValue");
		CheckEffectsUsedInBulletExpand_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CheckEffectsUsedInBulletExpand_FunctionAddress, "ReturnValue");
		CheckEffectsUsedInBulletExpand_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CheckEffectsUsedInBulletExpand_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		CheckEffectsUsedInBulletExpand_IsValid = CheckEffectsUsedInBulletExpand_FunctionAddress != IntPtr.Zero && CheckEffectsUsedInBulletExpand_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:CheckEffectsUsedInBulletExpand", CheckEffectsUsedInBulletExpand_IsValid);
		CreateInteractCompForProjectile_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateInteractCompForProjectile");
		CreateInteractCompForProjectile_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateInteractCompForProjectile_FunctionAddress);
		CreateInteractCompForProjectile_ProjectileBaseActor_CDO_Offset = NativeReflection.GetPropertyOffset(CreateInteractCompForProjectile_FunctionAddress, "ProjectileBaseActor_CDO");
		CreateInteractCompForProjectile_ProjectileBaseActor_CDO_IsValid = NativeReflection.ValidatePropertyClass(CreateInteractCompForProjectile_FunctionAddress, "ProjectileBaseActor_CDO", Classes.FObjectProperty);
		CreateInteractCompForProjectile_BP_Offset = NativeReflection.GetPropertyOffset(CreateInteractCompForProjectile_FunctionAddress, "BP");
		CreateInteractCompForProjectile_BP_IsValid = NativeReflection.ValidatePropertyClass(CreateInteractCompForProjectile_FunctionAddress, "BP", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref CreateInteractCompForProjectile_ErrorLog_PropertyAddress, CreateInteractCompForProjectile_FunctionAddress, "ErrorLog");
		CreateInteractCompForProjectile_ErrorLog_Offset = NativeReflection.GetPropertyOffset(CreateInteractCompForProjectile_FunctionAddress, "ErrorLog");
		CreateInteractCompForProjectile_ErrorLog_IsValid = NativeReflection.ValidatePropertyClass(CreateInteractCompForProjectile_FunctionAddress, "ErrorLog", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref CreateInteractCompForProjectile_ReturnValue_PropertyAddress, CreateInteractCompForProjectile_FunctionAddress, "ReturnValue");
		CreateInteractCompForProjectile_ReturnValue_Offset = NativeReflection.GetPropertyOffset(CreateInteractCompForProjectile_FunctionAddress, "ReturnValue");
		CreateInteractCompForProjectile_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(CreateInteractCompForProjectile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CreateInteractCompForProjectile_IsValid = CreateInteractCompForProjectile_FunctionAddress != IntPtr.Zero && CreateInteractCompForProjectile_ProjectileBaseActor_CDO_IsValid && CreateInteractCompForProjectile_BP_IsValid && CreateInteractCompForProjectile_ErrorLog_IsValid && CreateInteractCompForProjectile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:CreateInteractCompForProjectile", CreateInteractCompForProjectile_IsValid);
		ProjectileAssetMoveCompToBP_Full_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProjectileAssetMoveCompToBP_Full");
		ProjectileAssetMoveCompToBP_Full_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectileAssetMoveCompToBP_Full_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ProjectileAssetMoveCompToBP_Full_ErrorLog_PropertyAddress, ProjectileAssetMoveCompToBP_Full_FunctionAddress, "ErrorLog");
		ProjectileAssetMoveCompToBP_Full_ErrorLog_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetMoveCompToBP_Full_FunctionAddress, "ErrorLog");
		ProjectileAssetMoveCompToBP_Full_ErrorLog_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetMoveCompToBP_Full_FunctionAddress, "ErrorLog", Classes.FStrProperty);
		ProjectileAssetMoveCompToBP_Full_IsValid = ProjectileAssetMoveCompToBP_Full_FunctionAddress != IntPtr.Zero && ProjectileAssetMoveCompToBP_Full_ErrorLog_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetMoveCompToBP_Full", ProjectileAssetMoveCompToBP_Full_IsValid);
		ProjectileAssetMoveCompToBP_Single_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProjectileAssetMoveCompToBP_Single");
		ProjectileAssetMoveCompToBP_Single_ParamsSize = NativeReflection.GetFunctionParamsSize(ProjectileAssetMoveCompToBP_Single_FunctionAddress);
		ProjectileAssetMoveCompToBP_Single_ProjectileBaseActor_CDO_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetMoveCompToBP_Single_FunctionAddress, "ProjectileBaseActor_CDO");
		ProjectileAssetMoveCompToBP_Single_ProjectileBaseActor_CDO_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetMoveCompToBP_Single_FunctionAddress, "ProjectileBaseActor_CDO", Classes.FObjectProperty);
		ProjectileAssetMoveCompToBP_Single_BP_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetMoveCompToBP_Single_FunctionAddress, "BP");
		ProjectileAssetMoveCompToBP_Single_BP_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetMoveCompToBP_Single_FunctionAddress, "BP", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ProjectileAssetMoveCompToBP_Single_ErrorLog_PropertyAddress, ProjectileAssetMoveCompToBP_Single_FunctionAddress, "ErrorLog");
		ProjectileAssetMoveCompToBP_Single_ErrorLog_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetMoveCompToBP_Single_FunctionAddress, "ErrorLog");
		ProjectileAssetMoveCompToBP_Single_ErrorLog_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetMoveCompToBP_Single_FunctionAddress, "ErrorLog", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref ProjectileAssetMoveCompToBP_Single_bNeedLoadData_PropertyAddress, ProjectileAssetMoveCompToBP_Single_FunctionAddress, "bNeedLoadData");
		ProjectileAssetMoveCompToBP_Single_bNeedLoadData_Offset = NativeReflection.GetPropertyOffset(ProjectileAssetMoveCompToBP_Single_FunctionAddress, "bNeedLoadData");
		ProjectileAssetMoveCompToBP_Single_bNeedLoadData_IsValid = NativeReflection.ValidatePropertyClass(ProjectileAssetMoveCompToBP_Single_FunctionAddress, "bNeedLoadData", Classes.FBoolProperty);
		ProjectileAssetMoveCompToBP_Single_IsValid = ProjectileAssetMoveCompToBP_Single_FunctionAddress != IntPtr.Zero && ProjectileAssetMoveCompToBP_Single_ProjectileBaseActor_CDO_IsValid && ProjectileAssetMoveCompToBP_Single_BP_IsValid && ProjectileAssetMoveCompToBP_Single_ErrorLog_IsValid && ProjectileAssetMoveCompToBP_Single_bNeedLoadData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:ProjectileAssetMoveCompToBP_Single", ProjectileAssetMoveCompToBP_Single_IsValid);
		GetAllProjectileBPPathFromDesc_with_C_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllProjectileBPPathFromDesc_with_C");
		GetAllProjectileBPPathFromDesc_with_C_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllProjectileBPPathFromDesc_with_C_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAllProjectileBPPathFromDesc_with_C_CurrentUsedBPPath_PropertyAddress, GetAllProjectileBPPathFromDesc_with_C_FunctionAddress, "CurrentUsedBPPath");
		GetAllProjectileBPPathFromDesc_with_C_CurrentUsedBPPath_Offset = NativeReflection.GetPropertyOffset(GetAllProjectileBPPathFromDesc_with_C_FunctionAddress, "CurrentUsedBPPath");
		GetAllProjectileBPPathFromDesc_with_C_CurrentUsedBPPath_IsValid = NativeReflection.ValidatePropertyClass(GetAllProjectileBPPathFromDesc_with_C_FunctionAddress, "CurrentUsedBPPath", Classes.FArrayProperty);
		GetAllProjectileBPPathFromDesc_with_C_IsValid = GetAllProjectileBPPathFromDesc_with_C_FunctionAddress != IntPtr.Zero && GetAllProjectileBPPathFromDesc_with_C_CurrentUsedBPPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:GetAllProjectileBPPathFromDesc_with_C", GetAllProjectileBPPathFromDesc_with_C_IsValid);
		GetAllProjectileBPPathFromDesc_without_C_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllProjectileBPPathFromDesc_without_C");
		GetAllProjectileBPPathFromDesc_without_C_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllProjectileBPPathFromDesc_without_C_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAllProjectileBPPathFromDesc_without_C_CurrentUsedBPPath_PropertyAddress, GetAllProjectileBPPathFromDesc_without_C_FunctionAddress, "CurrentUsedBPPath");
		GetAllProjectileBPPathFromDesc_without_C_CurrentUsedBPPath_Offset = NativeReflection.GetPropertyOffset(GetAllProjectileBPPathFromDesc_without_C_FunctionAddress, "CurrentUsedBPPath");
		GetAllProjectileBPPathFromDesc_without_C_CurrentUsedBPPath_IsValid = NativeReflection.ValidatePropertyClass(GetAllProjectileBPPathFromDesc_without_C_FunctionAddress, "CurrentUsedBPPath", Classes.FArrayProperty);
		GetAllProjectileBPPathFromDesc_without_C_IsValid = GetAllProjectileBPPathFromDesc_without_C_FunctionAddress != IntPtr.Zero && GetAllProjectileBPPathFromDesc_without_C_CurrentUsedBPPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibProjectile:GetAllProjectileBPPathFromDesc_without_C", GetAllProjectileBPPathFromDesc_without_C_IsValid);
	}

	static BGUFuncLibProjectile()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibProjectile)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibProjectile));
	}
}
