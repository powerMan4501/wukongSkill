using System;
using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_MatMgrComp : UActorCompBaseCS
{
	private b1.BUC_MatMgrData MatMgrData;

	private IBUC_RenderTargetMgrData RenderTargetMgrData;

	public override void OnAttach()
	{
		MatMgrData = RequireWritableData<b1.BUC_MatMgrData>();
		RenderTargetMgrData = RequireReadOnlyData<IBUC_RenderTargetMgrData, BUC_RenderTargetMgrData>();
		base.BUSEventCollection.Evt_SetMatsParam += new Del_SetMatsParam(OnUpdateOneParam_DBC);
		base.BUSEventCollection.Evt_SetMatsLayerParam += new Del_SetMatsLayerParam(OnUpdateOneParamForLayer_DBC);
		base.BUSEventCollection.Evt_ResetMatsParam += new Del_ResetMatsParam(OnResetOneParam_DBC);
		base.BUSEventCollection.Evt_ResetMatsLayerParam += new Del_ResetMatsLayerParam(OnResetOneParamForLayer_DBC);
		base.BUSEventCollection.Evt_PrintWukongMatQualityInfo += new Del_Void(OnPrintWukongMatQualityInfo_DBC);
		base.BUSEventCollection.Evt_TriggerMPCScalarParamTick += new Del_TriggerMPCScalarParamTick(OnTriggerMPCScalarParamTick_DBC);
		base.BUSEventCollection.Evt_TriggerMPCScalarParamTickWithObj += new Del_TriggerMPCScalarParamTickWithObj(OnTriggerMPCScalarParamTickWithObj_DBC);
		base.BUSEventCollection.Evt_BeginForSetCurveValueToMesh += new Del_BeginForSetCurveValueToMesh(OnBeginForSetCurveValueToMesh_DBC);
		base.BUSEventCollection.Evt_OverForSetCurveValueToMesh += new Del_OverForSetCurveValueToMesh(OnOverForSetCurveValueToMesh_DBC);
	}

	public override void PreBeginPlay()
	{
	}

	private void OnPrintWukongMatQualityInfo_DBC()
	{
		BUS_DispLibEventCollection.Get(Owner)?.Evt_LogActorMaterialQualityInfo();
	}

	private BUC_DispLibDBC_ModifyMaterialParameterCollection OnUpdateOneParamEventConverDBCModMPCEvent(string MPCAssetPath, string ParamName, UCurveFloat CurveFloat, float TotalTime, float OriValue)
	{
		BUC_DispLibUtil_DBCAdvProcessScalar processValue = default(BUC_DispLibUtil_DBCAdvProcessScalar).SetCustomData(DispLibDBCAdvProcessScalarMode.UCurve, 0f, FVector2D.ZeroVector, _Loop: false, 0f, TotalTime, 0f, OriValue, DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd, 1f, CurveFloat);
		BUC_DispLibUtil_DBCAdvProcessScalarParam item = default(BUC_DispLibUtil_DBCAdvProcessScalarParam).SetCustomData(new FName(ParamName), processValue);
		List<BUC_DispLibUtil_DBCAdvProcessScalarParam> setScalarParam = new List<BUC_DispLibUtil_DBCAdvProcessScalarParam> { item };
		return default(BUC_DispLibDBC_ModifyMaterialParameterCollection).SetCustomData(MPCAssetPath, 0f, DispLibDBCEndMode.FixDuration, TotalTime, 0f, setScalarParam, null, null, null, 0, 0, 0, 0);
	}

	private void OnTriggerMPCScalarParamTick_DBC(string MPCAssetPath, string ParamName, string CurveFloatPath, float TotalTime, float OriValue, bool CoverLastTrigger = true)
	{
		int GamePlayDispReqID = 0;
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (bUS_DispLibEventCollection == null)
		{
			return;
		}
		UCurveFloat uCurveFloat = BGW_PreloadAssetMgr.Get(GetOwner()).TryGetCachedResourceObj<UCurveFloat>(CurveFloatPath, ELoadResourceType.AsyncLoadAndCache);
		if (uCurveFloat == null)
		{
			return;
		}
		bUS_DispLibEventCollection.Evt_RequestApply_One_ModMPC(OnUpdateOneParamEventConverDBCModMPCEvent(MPCAssetPath, ParamName, uCurveFloat, TotalTime, OriValue), out GamePlayDispReqID);
		if (GamePlayDispReqID == 0)
		{
			BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] BUS_MatMgrComp 转发给 DBC 的 ModMPC 事件返回 GamePlayDispReqID = 0; ParamName = " + ParamName + "; MPCAssetPath = " + MPCAssetPath + "; CurveFloatPath = " + CurveFloatPath + "; Owner = " + Owner.GetActorLabel());
		}
		else
		{
			if (!MatMgrData.MPCAssetPathToParamNameToGamePlayDispReqID.TryGetValue(MPCAssetPath, out var _))
			{
				MatMgrData.MPCAssetPathToParamNameToGamePlayDispReqID.Add(MPCAssetPath, new Dictionary<FName, int>());
			}
			if (MatMgrData.MPCAssetPathToParamNameToGamePlayDispReqID[MPCAssetPath].TryGetValue(new FName(ParamName), out var value2))
			{
				bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(value2, OnlyEndFX: false, OnlyEndProcedureEndMode: false, int.MaxValue);
			}
			else
			{
				MatMgrData.MPCAssetPathToParamNameToGamePlayDispReqID[MPCAssetPath].Add(new FName(ParamName), GamePlayDispReqID);
			}
			MatMgrData.MPCAssetPathToParamNameToGamePlayDispReqID[MPCAssetPath][new FName(ParamName)] = GamePlayDispReqID;
		}
	}

	private void OnTriggerMPCScalarParamTickWithObj_DBC(UMaterialParameterCollection MPC, string ParamName, UCurveFloat CurveFloat, float TotalTime, float OriValue, bool CoverLastTrigger = true)
	{
		OnTriggerMPCScalarParamTick_DBC(MPC.GetPathName(), ParamName, CurveFloat.GetPathName(), TotalTime, OriValue, CoverLastTrigger);
	}

	private List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> SetCurveValueEvent_FGSFloatCurveToParamList_ConverTo_DBCAdvProcessScalarMatLayerParamList(TArrayReadWrite<FGSFloatCurveToParam> FloatCurveParamList, float TotalDuration, bool bFitRealTime)
	{
		List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> list = new List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam>();
		foreach (FGSFloatCurveToParam FloatCurveParam in FloatCurveParamList)
		{
			BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam item = default(BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam);
			if (FloatCurveParam.NotUseCurve)
			{
				if (FloatCurveParam.Association != EMaterialParameterAssociation.GlobalParameter && FloatCurveParam.LayerFunction.IsNullOrDestroyed())
				{
					continue;
				}
				BUC_DispLibUtil_DBCAdvProcessScalar processValue = default(BUC_DispLibUtil_DBCAdvProcessScalar).SetCustomData(FloatCurveParam.TargetFloatValue, 0f);
				item.SetCustomData(FloatCurveParam.Association, FloatCurveParam.LayerFunction, FloatCurveParam.ParamName, processValue);
			}
			else
			{
				if (FloatCurveParam.CurveFloat.IsNullOrDestroyed())
				{
					continue;
				}
				BUC_DispLibUtil_DBCAdvProcessScalar processValue2 = default(BUC_DispLibUtil_DBCAdvProcessScalar).SetCustomData(DispLibDBCAdvProcessScalarMode.UCurve, 0f, FVector2D.ZeroVector, _Loop: false, bFitRealTime ? 0f : TotalDuration, 0f, 0f, 0f, DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd, 1f, FloatCurveParam.CurveFloat);
				item.SetCustomData(FloatCurveParam.Association, FloatCurveParam.LayerFunction, FloatCurveParam.ParamName, processValue2);
			}
			list.Add(item);
		}
		return list;
	}

	private List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> SetCurveValueEvent_FGSLinearColorCurveToParam_ConverTo_DBCAdvProcessFLinearColorMatLayerParamList(TArrayReadWrite<FGSLinearColorCurveToParam> LinearColorCurveParamList, float TotalDuration, bool bFitRealTime)
	{
		List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> list = new List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam>();
		foreach (FGSLinearColorCurveToParam LinearColorCurveParam in LinearColorCurveParamList)
		{
			BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam item = default(BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam);
			if (LinearColorCurveParam.NotUseCurve)
			{
				if (LinearColorCurveParam.Association != EMaterialParameterAssociation.GlobalParameter && LinearColorCurveParam.LayerFunction.IsNullOrDestroyed())
				{
					continue;
				}
				BUC_DispLibUtil_DBCAdvProcessFLinearColor processValue = default(BUC_DispLibUtil_DBCAdvProcessFLinearColor).SetCustomData(LinearColorCurveParam.TargetLinearColorValue, 0f);
				item.SetCustomData(LinearColorCurveParam.Association, LinearColorCurveParam.LayerFunction, LinearColorCurveParam.ParamName, processValue);
			}
			else
			{
				if (LinearColorCurveParam.CurveLinearColor.IsNullOrDestroyed())
				{
					continue;
				}
				BUC_DispLibUtil_DBCAdvProcessFLinearColor processValue2 = default(BUC_DispLibUtil_DBCAdvProcessFLinearColor).SetCustomData(DispLibDBCAdvProcessFLinearColorMode.UCurve, FLinearColor.Black, FVector2D.ZeroVector, _Loop: false, bFitRealTime ? 0f : TotalDuration, 0f, 0f, FLinearColor.White, DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd, 1f, LinearColorCurveParam.CurveLinearColor);
				item.SetCustomData(LinearColorCurveParam.Association, LinearColorCurveParam.LayerFunction, LinearColorCurveParam.ParamName, processValue2);
			}
			list.Add(item);
		}
		return list;
	}

	private bool CharacterMainMesh_SetCurveValueEvent_ConverTo_DBCModMatEvent(ref BUC_DispLibDBC_ModifyMaterial DBCModMatEvent, List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> DBCAdvProcessScalarMatLayerParamList, List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> DBCAdvProcessFLinearColorMatLayerParam, TArrayReadWrite<int> MatIndexList)
	{
		DispLibDBCCompsFilterMode compsFilterMode = DispLibDBCCompsFilterMode.ByTags;
		List<FName> compTags = new List<FName> { B1GlobalFNames.master };
		DispLibDBCMaterialsFilterMode matsFilterMode = ((MatIndexList.Count >= 1) ? DispLibDBCMaterialsFilterMode.ByIndexes : DispLibDBCMaterialsFilterMode.AllMats);
		List<FName> matSlotNames = new List<FName>();
		List<int> matIndexes = MatIndexList.ToList();
		List<UMaterial> matShaders = new List<UMaterial>();
		BUC_DispLibDBC_MaterialEffectTargetInfo filterMode = new BUC_DispLibDBC_MaterialEffectTargetInfo(compsFilterMode, compTags, matsFilterMode, matSlotNames, matIndexes, matShaders);
		DBCModMatEvent.SetCustomData(filterMode, 0f, DispLibDBCEndMode.ProcedureNotity, 0f, 0f, DBCAdvProcessScalarMatLayerParamList, DBCAdvProcessFLinearColorMatLayerParam, null, null, null, 0, 0, 0, 0);
		return true;
	}

	private bool WeaponMesh_SetCurveValueEvent_ConverTo_DBCModMatEvent(ref BUC_DispLibDBC_ModifyMaterial DBCModMatEvent, BGUCharacterCS OwnerChr, List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> DBCAdvProcessScalarMatLayerParamList, List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> DBCAdvProcessFLinearColorMatLayerParam, TArrayReadWrite<int> WeaponIndexList, TArrayReadWrite<int> WeaponMatIndexList)
	{
		DispLibDBCCompsFilterMode compsFilterMode = DispLibDBCCompsFilterMode.ByTags;
		List<FName> list = new List<FName>();
		DispLibDBCMaterialsFilterMode matsFilterMode = ((WeaponIndexList.Count >= 1) ? DispLibDBCMaterialsFilterMode.ByIndexes : DispLibDBCMaterialsFilterMode.AllMats);
		List<FName> matSlotNames = new List<FName>();
		List<int> matIndexes = WeaponMatIndexList.ToList();
		List<UMaterial> matShaders = new List<UMaterial>();
		if (WeaponIndexList.Count < 1)
		{
			int num = BGUFunctionLibraryCS.BGUGetWeaponNum(OwnerChr);
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					BGUWeaponBase bGUWeaponBase = BGUFunctionLibraryCS.BGUGetWeaponByIndex(OwnerChr, i) as BGUWeaponBase;
					if (bGUWeaponBase != null && !bGUWeaponBase.SkeletalMeshComp.IsNullOrDestroyed() && bGUWeaponBase.SkeletalMeshComp.ComponentTags != null && bGUWeaponBase.SkeletalMeshComp.ComponentTags.Count > 0)
					{
						list.Add(bGUWeaponBase.SkeletalMeshComp.ComponentTags[0]);
					}
				}
			}
		}
		else
		{
			foreach (int WeaponIndex in WeaponIndexList)
			{
				BGUWeaponBase bGUWeaponBase2 = BGUFunctionLibraryCS.BGUGetWeaponByIndex(OwnerChr, WeaponIndex) as BGUWeaponBase;
				if (bGUWeaponBase2 != null && !bGUWeaponBase2.SkeletalMeshComp.IsNullOrDestroyed() && bGUWeaponBase2.SkeletalMeshComp.ComponentTags != null && bGUWeaponBase2.SkeletalMeshComp.ComponentTags.Count > 0)
				{
					list.Add(bGUWeaponBase2.SkeletalMeshComp.ComponentTags[0]);
				}
			}
		}
		if (list.Count == 0)
		{
			return false;
		}
		BUC_DispLibDBC_MaterialEffectTargetInfo filterMode = new BUC_DispLibDBC_MaterialEffectTargetInfo(compsFilterMode, list, matsFilterMode, matSlotNames, matIndexes, matShaders);
		DBCModMatEvent.SetCustomData(filterMode, 0f, DispLibDBCEndMode.ProcedureNotity, 0f, 0f, DBCAdvProcessScalarMatLayerParamList, DBCAdvProcessFLinearColorMatLayerParam, null, null, null, 0, 0, 0, 0);
		return true;
	}

	private bool CharacterSubMeshes_SetCurveValueEvent_ConverTo_DBCModMatEvent(ref BUC_DispLibDBC_ModifyMaterial DBCModMatEvent, BGUCharacterCS OwnerChr, List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> DBCAdvProcessScalarMatLayerParamList, List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> DBCAdvProcessFLinearColorMatLayerParam, TArrayReadWrite<FName> ChildSKMeshTagList, TArrayReadWrite<int> ChildSKMatIndexList)
	{
		DispLibDBCCompsFilterMode compsFilterMode = DispLibDBCCompsFilterMode.ByTags;
		List<FName> list = new List<FName>();
		DispLibDBCMaterialsFilterMode matsFilterMode = ((ChildSKMatIndexList.Count >= 1) ? DispLibDBCMaterialsFilterMode.ByIndexes : DispLibDBCMaterialsFilterMode.AllMats);
		List<FName> matSlotNames = new List<FName>();
		List<int> matIndexes = ChildSKMatIndexList.ToList();
		List<UMaterial> matShaders = new List<UMaterial>();
		foreach (FName ChildSKMeshTag in ChildSKMeshTagList)
		{
			foreach (UActorComponent item in OwnerChr.GetComponentsByTag(UClass.GetClass<UMeshComponent>(), ChildSKMeshTag))
			{
				if (!(item == OwnerChr.Mesh))
				{
					list.Add(ChildSKMeshTag);
					break;
				}
			}
		}
		if (list.Count == 0)
		{
			return false;
		}
		BUC_DispLibDBC_MaterialEffectTargetInfo filterMode = new BUC_DispLibDBC_MaterialEffectTargetInfo(compsFilterMode, list, matsFilterMode, matSlotNames, matIndexes, matShaders);
		DBCModMatEvent.SetCustomData(filterMode, 0f, DispLibDBCEndMode.ProcedureNotity, 0f, 0f, DBCAdvProcessScalarMatLayerParamList, DBCAdvProcessFLinearColorMatLayerParam, null, null, null, 0, 0, 0, 0);
		return true;
	}

	private bool ChildActorMeshes_SetCurveValueEvent_ConverTo_DBCModMatEvent(ref BUC_DispLibDBC_ModifyMaterial DBCModMatEvent, BGUCharacterCS OwnerChr, List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> DBCAdvProcessScalarMatLayerParamList, List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> DBCAdvProcessFLinearColorMatLayerParam, TArrayReadWrite<int> ChildActorMeshMatIndexList)
	{
		DispLibDBCCompsFilterMode compsFilterMode = DispLibDBCCompsFilterMode.ByTags;
		List<FName> list = new List<FName>();
		DispLibDBCMaterialsFilterMode matsFilterMode = ((ChildActorMeshMatIndexList.Count >= 1) ? DispLibDBCMaterialsFilterMode.ByIndexes : DispLibDBCMaterialsFilterMode.AllMats);
		List<FName> matSlotNames = new List<FName>();
		List<int> matIndexes = ChildActorMeshMatIndexList.ToList();
		List<UMaterial> matShaders = new List<UMaterial>();
		OwnerChr.GetAllChildActors(out var ChildActors, bIncludeDescendants: false);
		foreach (AActor item in ChildActors)
		{
			foreach (UActorComponent item2 in item.GetComponentsByClass(UClass.GetClass<UMeshComponent>()))
			{
				if (item2.ComponentTags == null || item2.ComponentTags.Count <= 0)
				{
					continue;
				}
				foreach (FName componentTag in item2.ComponentTags)
				{
					if (!(componentTag == B1GlobalFNames.master))
					{
						if (!list.Contains(componentTag))
						{
							list.Add(componentTag);
						}
						break;
					}
				}
			}
		}
		if (list.Count == 0)
		{
			return false;
		}
		BUC_DispLibDBC_MaterialEffectTargetInfo filterMode = new BUC_DispLibDBC_MaterialEffectTargetInfo(compsFilterMode, list, matsFilterMode, matSlotNames, matIndexes, matShaders);
		DBCModMatEvent.SetCustomData(filterMode, 0f, DispLibDBCEndMode.ProcedureNotity, 0f, 0f, DBCAdvProcessScalarMatLayerParamList, DBCAdvProcessFLinearColorMatLayerParam, null, null, null, 0, 0, 0, 0);
		return true;
	}

	private void OnBeginForSetCurveValueToMesh_DBC(int SetCurveValueEventID, TArrayReadWrite<FGSFloatCurveToParam> FloatCurveParamList, TArrayReadWrite<FGSLinearColorCurveToParam> LinearColorCurveParamList, bool NotApplyToChrMesh, TArrayReadWrite<int> MatIndexList, bool BothWeapons, TArrayReadWrite<int> WeaponIndexList, TArrayReadWrite<int> WeaponMatIndexList, bool BothChildSkeltalMeshes, TArrayReadWrite<FName> ChildSKMeshTagList, TArrayReadWrite<int> ChildSKMatIndexList, bool BothChildActor, TArrayReadWrite<int> ChildMeshMatIndexList, float TotalDuration, bool bFitRealTime)
	{
		if (MatMgrData.SetCurveValueEventIDToGamePlayDispReqIDList.ContainsKey(SetCurveValueEventID))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS == null && bGUCharacterCS.IsPendingKill)
		{
			return;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (bUS_DispLibEventCollection == null)
		{
			BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] OnBeginForSetCurveValueToMesh can not get BUS_DispLibEventCollection. Owner = " + GetOwner().GetActorLabel() + ";");
		}
		else
		{
			if (FloatCurveParamList.Count == 0 && LinearColorCurveParamList.Count == 0)
			{
				return;
			}
			List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> list = SetCurveValueEvent_FGSFloatCurveToParamList_ConverTo_DBCAdvProcessScalarMatLayerParamList(FloatCurveParamList, TotalDuration, bFitRealTime);
			List<BUC_DispLibUtil_DBCAdvProcessFLinearColorMatLayerParam> list2 = SetCurveValueEvent_FGSLinearColorCurveToParam_ConverTo_DBCAdvProcessFLinearColorMatLayerParamList(LinearColorCurveParamList, TotalDuration, bFitRealTime);
			if (list.Count == 0 && list2.Count == 0)
			{
				BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] OnBeginForSetCurveValueToMesh param events can not conver to any DBC param events. Owner = " + GetOwner().GetActorLabel() + ";");
				return;
			}
			int GamePlayDispReqID = 0;
			int GamePlayDispReqID2 = 0;
			int GamePlayDispReqID3 = 0;
			int GamePlayDispReqID4 = 0;
			MatMgrData.SetCurveValueEventIDToGamePlayDispReqIDList.Add(SetCurveValueEventID, new List<int>());
			if (!NotApplyToChrMesh)
			{
				if (bGUCharacterCS.Mesh.IsNullOrDestroyed())
				{
					BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] OnBeginForSetCurveValueToMesh OwnerChr.Mesh == null. Owner = " + GetOwner().GetActorLabel() + ";");
				}
				else
				{
					BUC_DispLibDBC_ModifyMaterial DBCModMatEvent = default(BUC_DispLibDBC_ModifyMaterial);
					if (CharacterMainMesh_SetCurveValueEvent_ConverTo_DBCModMatEvent(ref DBCModMatEvent, list, list2, MatIndexList))
					{
						bUS_DispLibEventCollection.Evt_RequestApply_One_ModMat(DBCModMatEvent, out GamePlayDispReqID);
						if (GamePlayDispReqID != 0)
						{
							MatMgrData.SetCurveValueEventIDToGamePlayDispReqIDList[SetCurveValueEventID].Add(GamePlayDispReqID);
						}
						else
						{
							BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] BUS_MatMgrComp 转发给 DBC 的材质事件返回的 DBC_IdentityID = 0; Owner = " + Owner.GetActorLabel());
						}
					}
					else
					{
						BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] OnBeginForSetCurveValueToMesh can not conver to DBCModMatEvent. Owner = " + GetOwner().GetActorLabel() + ";");
					}
				}
			}
			if (BothWeapons)
			{
				BUC_DispLibDBC_ModifyMaterial DBCModMatEvent2 = default(BUC_DispLibDBC_ModifyMaterial);
				if (WeaponMesh_SetCurveValueEvent_ConverTo_DBCModMatEvent(ref DBCModMatEvent2, bGUCharacterCS, list, list2, WeaponIndexList, WeaponMatIndexList))
				{
					bUS_DispLibEventCollection.Evt_RequestApply_One_ModMat(DBCModMatEvent2, out GamePlayDispReqID2);
					if (GamePlayDispReqID2 != 0)
					{
						MatMgrData.SetCurveValueEventIDToGamePlayDispReqIDList[SetCurveValueEventID].Add(GamePlayDispReqID2);
					}
					else
					{
						BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] BUS_MatMgrComp 转发给 DBC 的材质事件返回的 DBC_IdentityID = 0; Owner = " + Owner.GetActorLabel());
					}
				}
				else
				{
					BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] OnBeginForSetCurveValueToMesh can not conver to DBCModMatEvent. Owner = " + GetOwner().GetActorLabel() + ";");
				}
			}
			if (BothChildSkeltalMeshes)
			{
				BUC_DispLibDBC_ModifyMaterial DBCModMatEvent3 = default(BUC_DispLibDBC_ModifyMaterial);
				if (CharacterSubMeshes_SetCurveValueEvent_ConverTo_DBCModMatEvent(ref DBCModMatEvent3, bGUCharacterCS, list, list2, ChildSKMeshTagList, ChildSKMatIndexList))
				{
					bUS_DispLibEventCollection.Evt_RequestApply_One_ModMat(DBCModMatEvent3, out GamePlayDispReqID3);
					if (GamePlayDispReqID3 != 0)
					{
						MatMgrData.SetCurveValueEventIDToGamePlayDispReqIDList[SetCurveValueEventID].Add(GamePlayDispReqID3);
					}
					else
					{
						BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] BUS_MatMgrComp 转发给 DBC 的材质事件返回的 DBC_IdentityID = 0; Owner = " + Owner.GetActorLabel());
					}
				}
				else
				{
					BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] OnBeginForSetCurveValueToMesh can not conver to DBCModMatEvent. Owner = " + GetOwner().GetActorLabel() + ";");
				}
			}
			if (BothChildActor)
			{
				BUC_DispLibDBC_ModifyMaterial DBCModMatEvent4 = default(BUC_DispLibDBC_ModifyMaterial);
				if (ChildActorMeshes_SetCurveValueEvent_ConverTo_DBCModMatEvent(ref DBCModMatEvent4, bGUCharacterCS, list, list2, ChildMeshMatIndexList))
				{
					bUS_DispLibEventCollection.Evt_RequestApply_One_ModMat(DBCModMatEvent4, out GamePlayDispReqID4);
					if (GamePlayDispReqID4 != 0)
					{
						MatMgrData.SetCurveValueEventIDToGamePlayDispReqIDList[SetCurveValueEventID].Add(GamePlayDispReqID4);
					}
					else
					{
						BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] BUS_MatMgrComp 转发给 DBC 的材质事件返回的 DBC_IdentityID = 0; Owner = " + Owner.GetActorLabel());
					}
				}
				else
				{
					BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] OnBeginForSetCurveValueToMesh can not conver to DBCModMatEvent. Owner = " + GetOwner().GetActorLabel() + ";");
				}
			}
			if (MatMgrData.SetCurveValueEventIDToGamePlayDispReqIDList[SetCurveValueEventID].Count == 0)
			{
				MatMgrData.SetCurveValueEventIDToGamePlayDispReqIDList.Remove(SetCurveValueEventID);
			}
		}
	}

	private void OnOverForSetCurveValueToMesh_DBC(int SetCurveValueEventID, bool NeedRecovery)
	{
		if (!MatMgrData.SetCurveValueEventIDToGamePlayDispReqIDList.TryGetValue(SetCurveValueEventID, out var value))
		{
			return;
		}
		MatMgrData.SetCurveValueEventIDToGamePlayDispReqIDList.Remove(SetCurveValueEventID);
		BGUCharacterCS bGUCharacterCS = GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed() && bGUCharacterCS.IsPendingKill)
		{
			return;
		}
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (bUS_DispLibEventCollection == null)
		{
			BGW_LogUtil.LogError("[DBC][MatMgr][DBCModMat] OnOverForSetCurveValueToMesh can not get BUS_DispLibEventCollection. Owner = " + GetOwner().GetActorLabel() + ";");
			return;
		}
		foreach (int item in value)
		{
			bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(item);
		}
	}

	private BUC_DispLibDBC_ModifyMaterial OnUpdateOneParamEvent_ConverTo_DBCModMatEvent(FName ParamName, in MaterialParamInfo _NewMPI)
	{
		switch (_NewMPI.MaterialParamType)
		{
		case EMaterialParamType.Scalar:
		{
			float durationToPrePoint3 = Math.Max(0f, _NewMPI.ScalarValueBlendInTime);
			float scalarValue_Target = _NewMPI.ScalarValue_Target;
			float durationToPrePoint4 = Math.Max(0f, _NewMPI.ScalarValueBlendOutTime);
			OnePCurveScalarPoint item6 = default(OnePCurveScalarPoint).SetCustomData(DispLibDBCPCurvePointScalarMode.CacheCurValue, 0f, 0f);
			OnePCurveScalarPoint item7 = default(OnePCurveScalarPoint).SetCustomData(DispLibDBCPCurvePointScalarMode.DirectSet, scalarValue_Target, durationToPrePoint3);
			List<OnePCurveScalarPoint> pointsList2 = new List<OnePCurveScalarPoint> { item6, item7 };
			OnePCurveScalarPoint endToPoint2 = default(OnePCurveScalarPoint).SetCustomData(DispLibDBCPCurvePointScalarMode.ParamInitialValue, 0f, durationToPrePoint4);
			BUC_DispLibUtil_DBCPCurveScalar pCurve2 = default(BUC_DispLibUtil_DBCPCurveScalar).SetCustomData(pointsList2, _Loop: false, 0f, endToPoint2, DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd);
			BUC_DispLibUtil_DBCPCurveScalarMatLayerParam item8 = default(BUC_DispLibUtil_DBCPCurveScalarMatLayerParam).SetCustomData(EMaterialParameterAssociation.GlobalParameter, null, ParamName, pCurve2);
			List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> setPCurveScalarParam = new List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> { item8 };
			return default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.ProcedureNotity, -1f, 0f, null, null, null, setPCurveScalarParam, null, 0, 0, 0, 0);
		}
		case EMaterialParamType.NormalVector:
		{
			float durationToPrePoint = Math.Max(0f, _NewMPI.ScalarValueBlendInTime);
			FLinearColor normalVectorValue = _NewMPI.NormalVectorValue;
			float durationToPrePoint2 = Math.Max(0f, _NewMPI.ScalarValueBlendOutTime);
			OnePCurveColorPoint item3 = default(OnePCurveColorPoint).SetCustomData(DispLibDBCPCurvePointColorMode.CacheCurValue, FLinearColor.White, 0f);
			OnePCurveColorPoint item4 = default(OnePCurveColorPoint).SetCustomData(DispLibDBCPCurvePointColorMode.DirectSet, normalVectorValue, durationToPrePoint);
			List<OnePCurveColorPoint> pointsList = new List<OnePCurveColorPoint> { item3, item4 };
			OnePCurveColorPoint endToPoint = default(OnePCurveColorPoint).SetCustomData(DispLibDBCPCurvePointColorMode.ParamInitialValue, FLinearColor.White, durationToPrePoint2);
			BUC_DispLibUtil_DBCPCurveColor pCurve = default(BUC_DispLibUtil_DBCPCurveColor).SetCustomData(pointsList, _Loop: false, 0f, endToPoint, DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd);
			BUC_DispLibUtil_DBCPCurveColorMatLayerParam item5 = default(BUC_DispLibUtil_DBCPCurveColorMatLayerParam).SetCustomData(EMaterialParameterAssociation.GlobalParameter, null, ParamName, pCurve);
			List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> setPCurveFLinearColorParam = new List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> { item5 };
			return default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.ProcedureNotity, -1f, 0f, null, null, null, null, setPCurveFLinearColorParam, 0, 0, 0, 0);
		}
		case EMaterialParamType.Texture2DType:
		{
			Math.Max(0f, _NewMPI.ScalarValueBlendInTime);
			UTextureRenderTarget2D textureRenderTarget = RenderTargetMgrData.GetTextureRenderTarget(_NewMPI.Texture2DType);
			BUC_DispLibUtil_DBCTexture textureValue2 = default(BUC_DispLibUtil_DBCTexture).SetCustomData(textureRenderTarget, 0f);
			BUC_DispLibUtil_DBCTextureMatLayerParam item2 = default(BUC_DispLibUtil_DBCTextureMatLayerParam).SetCustomData(EMaterialParameterAssociation.GlobalParameter, null, ParamName, textureValue2);
			List<BUC_DispLibUtil_DBCTextureMatLayerParam> setTextureParam2 = new List<BUC_DispLibUtil_DBCTextureMatLayerParam> { item2 };
			return default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.ProcedureNotity, -1f, 0f, null, null, setTextureParam2, null, null, 0, 0, 0, 0);
		}
		case EMaterialParamType.Texture2D:
		{
			Math.Max(0f, _NewMPI.ScalarValueBlendInTime);
			UTextureRenderTarget2D rT2D = _NewMPI.RT2D;
			BUC_DispLibUtil_DBCTexture textureValue = default(BUC_DispLibUtil_DBCTexture).SetCustomData(rT2D, 0f);
			BUC_DispLibUtil_DBCTextureMatLayerParam item = default(BUC_DispLibUtil_DBCTextureMatLayerParam).SetCustomData(EMaterialParameterAssociation.GlobalParameter, null, ParamName, textureValue);
			List<BUC_DispLibUtil_DBCTextureMatLayerParam> setTextureParam = new List<BUC_DispLibUtil_DBCTextureMatLayerParam> { item };
			return default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.ProcedureNotity, -1f, 0f, null, null, setTextureParam, null, null, 0, 0, 0, 0);
		}
		default:
			return default(BUC_DispLibDBC_ModifyMaterial).GetDefault();
		}
	}

	private void OnUpdateOneParam_DBC(FName ParamName, in MaterialParamInfo _NewMPI, bool ForceUpdateDefault)
	{
		int GamePlayDispReqID = 0;
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (bUS_DispLibEventCollection != null)
		{
			if (MatMgrData.MatParamNameToGamePlayDispReqID.TryGetValue(ParamName, out var value) && value > 0)
			{
				bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(value, OnlyEndFX: false, OnlyEndProcedureEndMode: false, int.MaxValue);
			}
			bUS_DispLibEventCollection.Evt_RequestApply_One_ModMat(OnUpdateOneParamEvent_ConverTo_DBCModMatEvent(ParamName, in _NewMPI), out GamePlayDispReqID);
			if (GamePlayDispReqID == 0)
			{
				BGW_LogUtil.LogError($"[DBC][MatMgr][DBCModMat] BUS_MatMgrComp 转发给 DBC 的材质事件返回 GamePlayDispReqID = 0; ParamName = {ParamName}; TargetValue = {_NewMPI.ScalarValue_Target} and {_NewMPI.NormalVectorValue} and {_NewMPI.Texture2DType}; Owner = {Owner.GetActorLabel()}");
			}
			else if (MatMgrData.MatParamNameToGamePlayDispReqID.ContainsKey(ParamName))
			{
				MatMgrData.MatParamNameToGamePlayDispReqID[ParamName] = GamePlayDispReqID;
			}
			else
			{
				MatMgrData.MatParamNameToGamePlayDispReqID.Add(ParamName, GamePlayDispReqID);
			}
		}
	}

	private BUC_DispLibDBC_ModifyMaterial OnUpdateOneParamForLayerEvent_ConverTo_DBCModMatEvent(EMaterialParameterAssociation Association, UMaterialFunctionInterface LayerFunction, FName ParamName, in MaterialParamInfo _NewMPIForLayer)
	{
		switch (_NewMPIForLayer.MaterialParamType)
		{
		case EMaterialParamType.Scalar:
		{
			float durationToPrePoint3 = Math.Max(0f, _NewMPIForLayer.ScalarValueBlendInTime);
			float scalarValue_Target = _NewMPIForLayer.ScalarValue_Target;
			float durationToPrePoint4 = Math.Max(0f, _NewMPIForLayer.ScalarValueBlendOutTime);
			OnePCurveScalarPoint item6 = default(OnePCurveScalarPoint).SetCustomData(DispLibDBCPCurvePointScalarMode.CacheCurValue, 0f, 0f);
			OnePCurveScalarPoint item7 = default(OnePCurveScalarPoint).SetCustomData(DispLibDBCPCurvePointScalarMode.DirectSet, scalarValue_Target, durationToPrePoint3);
			List<OnePCurveScalarPoint> pointsList2 = new List<OnePCurveScalarPoint> { item6, item7 };
			OnePCurveScalarPoint endToPoint2 = default(OnePCurveScalarPoint).SetCustomData(DispLibDBCPCurvePointScalarMode.ParamInitialValue, 0f, durationToPrePoint4);
			BUC_DispLibUtil_DBCPCurveScalar pCurve2 = default(BUC_DispLibUtil_DBCPCurveScalar).SetCustomData(pointsList2, _Loop: false, 0f, endToPoint2, DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd);
			BUC_DispLibUtil_DBCPCurveScalarMatLayerParam item8 = default(BUC_DispLibUtil_DBCPCurveScalarMatLayerParam).SetCustomData(Association, LayerFunction, ParamName, pCurve2);
			List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> setPCurveScalarParam = new List<BUC_DispLibUtil_DBCPCurveScalarMatLayerParam> { item8 };
			return default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.ProcedureNotity, -1f, 0f, null, null, null, setPCurveScalarParam, null, 0, 0, 0, 0);
		}
		case EMaterialParamType.NormalVector:
		{
			float durationToPrePoint = Math.Max(0f, _NewMPIForLayer.ScalarValueBlendInTime);
			FLinearColor normalVectorValue = _NewMPIForLayer.NormalVectorValue;
			float durationToPrePoint2 = Math.Max(0f, _NewMPIForLayer.ScalarValueBlendOutTime);
			OnePCurveColorPoint item3 = default(OnePCurveColorPoint).SetCustomData(DispLibDBCPCurvePointColorMode.CacheCurValue, FLinearColor.White, 0f);
			OnePCurveColorPoint item4 = default(OnePCurveColorPoint).SetCustomData(DispLibDBCPCurvePointColorMode.DirectSet, normalVectorValue, durationToPrePoint);
			List<OnePCurveColorPoint> pointsList = new List<OnePCurveColorPoint> { item3, item4 };
			OnePCurveColorPoint endToPoint = default(OnePCurveColorPoint).SetCustomData(DispLibDBCPCurvePointColorMode.ParamInitialValue, FLinearColor.White, durationToPrePoint2);
			BUC_DispLibUtil_DBCPCurveColor pCurve = default(BUC_DispLibUtil_DBCPCurveColor).SetCustomData(pointsList, _Loop: false, 0f, endToPoint, DispLibDBCAdvProcessReleaseParameterControlMode.OnEventRealEnd);
			BUC_DispLibUtil_DBCPCurveColorMatLayerParam item5 = default(BUC_DispLibUtil_DBCPCurveColorMatLayerParam).SetCustomData(Association, LayerFunction, ParamName, pCurve);
			List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> setPCurveFLinearColorParam = new List<BUC_DispLibUtil_DBCPCurveColorMatLayerParam> { item5 };
			return default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.ProcedureNotity, -1f, 0f, null, null, null, null, setPCurveFLinearColorParam, 0, 0, 0, 0);
		}
		case EMaterialParamType.Texture2DType:
		{
			Math.Max(0f, _NewMPIForLayer.ScalarValueBlendInTime);
			UTextureRenderTarget2D textureRenderTarget = RenderTargetMgrData.GetTextureRenderTarget(_NewMPIForLayer.Texture2DType);
			BUC_DispLibUtil_DBCTexture textureValue2 = default(BUC_DispLibUtil_DBCTexture).SetCustomData(textureRenderTarget, 0f);
			BUC_DispLibUtil_DBCTextureMatLayerParam item2 = default(BUC_DispLibUtil_DBCTextureMatLayerParam).SetCustomData(Association, LayerFunction, ParamName, textureValue2);
			List<BUC_DispLibUtil_DBCTextureMatLayerParam> setTextureParam2 = new List<BUC_DispLibUtil_DBCTextureMatLayerParam> { item2 };
			return default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.ProcedureNotity, -1f, 0f, null, null, setTextureParam2, null, null, 0, 0, 0, 0);
		}
		case EMaterialParamType.Texture2D:
		{
			Math.Max(0f, _NewMPIForLayer.ScalarValueBlendInTime);
			UTextureRenderTarget2D rT2D = _NewMPIForLayer.RT2D;
			BUC_DispLibUtil_DBCTexture textureValue = default(BUC_DispLibUtil_DBCTexture).SetCustomData(rT2D, 0f);
			BUC_DispLibUtil_DBCTextureMatLayerParam item = default(BUC_DispLibUtil_DBCTextureMatLayerParam).SetCustomData(Association, LayerFunction, ParamName, textureValue);
			List<BUC_DispLibUtil_DBCTextureMatLayerParam> setTextureParam = new List<BUC_DispLibUtil_DBCTextureMatLayerParam> { item };
			return default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats, 0f, DispLibDBCEndMode.ProcedureNotity, -1f, 0f, null, null, setTextureParam, null, null, 0, 0, 0, 0);
		}
		default:
			return default(BUC_DispLibDBC_ModifyMaterial).GetDefault();
		}
	}

	private void OnUpdateOneParamForLayer_DBC(int LayerMappingIdx, FName LayerMappingName, FName ParamName, in MaterialParamInfo _NewMPIForLayer, bool ForceUpdateDefault)
	{
		int GamePlayDispReqID = 0;
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (bUS_DispLibEventCollection == null)
		{
			return;
		}
		bool flag = false;
		FMatLayerFunctionInfo value = default(FMatLayerFunctionInfo);
		if (BGW_PreloadAssetMgr.Get(this).MatLayerFunctionMappingConfigMap.TryGetValue(LayerMappingIdx, out var value2))
		{
			flag = value2.MatLayerFunctionInfoMap.TryGetValue(LayerMappingName, out value);
		}
		if (!flag)
		{
			return;
		}
		int value3 = 0;
		switch (value.Association)
		{
		case EMaterialParameterAssociation.GlobalParameter:
			if (MatMgrData.LayerMat_GlobalParamNameToGamePlayDispReqID.TryGetValue(ParamName, out value3) && value3 > 0)
			{
				bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(value3, OnlyEndFX: false, OnlyEndProcedureEndMode: false, int.MaxValue);
			}
			break;
		case EMaterialParameterAssociation.LayerParameter:
		{
			if (MatMgrData.LayerMat_LayerParamNameToGamePlayDispReqID.TryGetValue(value.LayerFunction, out var value5))
			{
				if (value5.TryGetValue(ParamName, out value3) && value3 > 0)
				{
					bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(value3, OnlyEndFX: false, OnlyEndProcedureEndMode: false, int.MaxValue);
				}
				else
				{
					value5.Add(ParamName, GamePlayDispReqID);
				}
			}
			break;
		}
		case EMaterialParameterAssociation.BlendParameter:
		{
			if (MatMgrData.LayerMat_BlendParamNameToGamePlayDispReqID.TryGetValue(value.LayerFunction, out var value4))
			{
				if (value4.TryGetValue(ParamName, out value3) && value3 > 0)
				{
					bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(value3, OnlyEndFX: false, OnlyEndProcedureEndMode: false, int.MaxValue);
				}
				else
				{
					value4.Add(ParamName, GamePlayDispReqID);
				}
			}
			else
			{
				MatMgrData.LayerMat_BlendParamNameToGamePlayDispReqID.Add(value.LayerFunction, new Dictionary<FName, int> { { ParamName, GamePlayDispReqID } });
			}
			break;
		}
		}
		bUS_DispLibEventCollection.Evt_RequestApply_One_ModMat(OnUpdateOneParamForLayerEvent_ConverTo_DBCModMatEvent(value.Association, value.LayerFunction, ParamName, in _NewMPIForLayer), out GamePlayDispReqID);
		int value6 = GamePlayDispReqID;
		if (GamePlayDispReqID == 0)
		{
			BGW_LogUtil.LogError($"[DBC][MatMgr][DBCModMat][DBCModMat] BUS_MatMgrComp 转发给 DBC 的材质事件返回 GamePlayDispReqID = 0; LayerMappingName = {LayerMappingName}; ParamName = {ParamName}; TargetValue = {_NewMPIForLayer.ScalarValue_Target} and {_NewMPIForLayer.NormalVectorValue} and {_NewMPIForLayer.Texture2DType}; Owner = {Owner.GetActorLabel()}");
			return;
		}
		switch (value.Association)
		{
		case EMaterialParameterAssociation.GlobalParameter:
			if (MatMgrData.LayerMat_GlobalParamNameToGamePlayDispReqID.ContainsKey(ParamName))
			{
				MatMgrData.LayerMat_GlobalParamNameToGamePlayDispReqID[ParamName] = value6;
			}
			else
			{
				MatMgrData.LayerMat_GlobalParamNameToGamePlayDispReqID.Add(ParamName, value6);
			}
			break;
		case EMaterialParameterAssociation.LayerParameter:
		{
			if (MatMgrData.LayerMat_LayerParamNameToGamePlayDispReqID.TryGetValue(value.LayerFunction, out var value9))
			{
				if (value9.TryGetValue(ParamName, out var _))
				{
					value9[ParamName] = value6;
				}
				else
				{
					value9.Add(ParamName, value6);
				}
			}
			else
			{
				MatMgrData.LayerMat_LayerParamNameToGamePlayDispReqID.Add(value.LayerFunction, new Dictionary<FName, int> { { ParamName, value6 } });
			}
			break;
		}
		case EMaterialParameterAssociation.BlendParameter:
		{
			if (MatMgrData.LayerMat_BlendParamNameToGamePlayDispReqID.TryGetValue(value.LayerFunction, out var value7))
			{
				if (value7.TryGetValue(ParamName, out var _))
				{
					value7[ParamName] = value6;
				}
				else
				{
					value7.Add(ParamName, value6);
				}
			}
			else
			{
				MatMgrData.LayerMat_LayerParamNameToGamePlayDispReqID.Add(value.LayerFunction, new Dictionary<FName, int> { { ParamName, value6 } });
			}
			break;
		}
		}
	}

	private void OnResetOneParam_DBC(FName ParamName)
	{
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (bUS_DispLibEventCollection == null)
		{
			return;
		}
		if (MatMgrData.MatParamNameToGamePlayDispReqID.TryGetValue(ParamName, out var value))
		{
			if (value <= 0)
			{
				BGW_LogUtil.LogError($"[DBC][MatMgr][DBCModMat] OnResetOneParam_DBC 缓存DBCID错误; ParamName = {ParamName}");
			}
			else
			{
				bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(value, OnlyEndFX: false, OnlyEndProcedureEndMode: false);
			}
		}
		else
		{
			BGW_LogUtil.LogError($"[DBC][MatMgr][DBCModMat] OnResetOneParam_DBC 传入了无效的参数名; ParamName = {ParamName}");
		}
	}

	private void OnResetOneParamForLayer_DBC(int LayerMappingIdx, FName LayerMappingName, FName ParamName)
	{
		BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (bUS_DispLibEventCollection == null)
		{
			return;
		}
		bool flag = false;
		FMatLayerFunctionInfo value = default(FMatLayerFunctionInfo);
		if (BGW_PreloadAssetMgr.Get(this).MatLayerFunctionMappingConfigMap.TryGetValue(LayerMappingIdx, out var value2))
		{
			flag = value2.MatLayerFunctionInfoMap.TryGetValue(LayerMappingName, out value);
		}
		if (!flag)
		{
			BGW_LogUtil.LogError($"[DBC][MatMgr][DBCModMat] OnResetOneParamForLayer_DBC 传入了无效的参数名; LayerMappingIdx = {LayerMappingIdx}; LayerMappingName = {LayerMappingName}; ParamName = {ParamName}");
			return;
		}
		int value3 = 0;
		switch (value.Association)
		{
		case EMaterialParameterAssociation.GlobalParameter:
			MatMgrData.LayerMat_GlobalParamNameToGamePlayDispReqID.TryGetValue(ParamName, out value3);
			break;
		case EMaterialParameterAssociation.LayerParameter:
		{
			if (MatMgrData.LayerMat_LayerParamNameToGamePlayDispReqID.TryGetValue(value.LayerFunction, out var value5))
			{
				value5?.TryGetValue(ParamName, out value3);
			}
			break;
		}
		case EMaterialParameterAssociation.BlendParameter:
		{
			if (MatMgrData.LayerMat_BlendParamNameToGamePlayDispReqID.TryGetValue(value.LayerFunction, out var value4))
			{
				value4?.TryGetValue(ParamName, out value3);
			}
			break;
		}
		}
		if (value3 <= 0)
		{
			BGW_LogUtil.LogError($"[DBC][MatMgr][DBCModMat] OnResetOneParamForLayer_DBC 缓存DBCID错误; LayerMappingIdx = {LayerMappingIdx}; LayerMappingName = {LayerMappingName}; ParamName = {ParamName}");
		}
		else
		{
			bUS_DispLibEventCollection.Evt_RequestEndDBCEffects(value3, OnlyEndFX: false, OnlyEndProcedureEndMode: false);
		}
	}
}
