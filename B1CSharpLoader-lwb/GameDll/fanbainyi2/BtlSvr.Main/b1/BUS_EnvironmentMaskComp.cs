using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_EnvironmentMaskComp : UActorCompBaseCS
{
	private BUC_EnvironmentMaskData EnvironmentMaskData;

	private BUS_DispLibEventCollection DBCEventCollection;

	private IBUC_EnvironmentInteractionMgrData EnvironmentInteractionMgrData;

	private IBUC_MagicallyChangeData MagicallyChangeData;

	private IBGC_EnvMgrData EnvMgrData;

	public override void OnAttach()
	{
		EnvironmentMaskData = RequireWritableData<BUC_EnvironmentMaskData>();
		EnvironmentInteractionMgrData = RequireReadOnlyData<IBUC_EnvironmentInteractionMgrData, BUC_EnvironmentInteractionMgrData>();
		MagicallyChangeData = RequireReadOnlyData<IBUC_MagicallyChangeData, BUC_MagicallyChangeData>();
		EnvMgrData = RequireReadOnlyGameStateData<IBGC_EnvMgrData, BGC_EnvMgrData>();
		base.BUSEventCollection.Evt_ApplyEnvironmentMask += new Del_ApplyEnvironmentMask(OnApplyEnvironmentMask);
		DBCEventCollection = BUS_DispLibEventCollection.Get(Owner);
		if (DBCEventCollection != null)
		{
			BUS_DispLibEventCollection dBCEventCollection = DBCEventCollection;
			dBCEventCollection.Evt_OnSkeletalMeshAssetChanged = (BUS_DispLibEventCollection.Del_OnSkeletalMeshAssetChanged)Delegate.Combine(dBCEventCollection.Evt_OnSkeletalMeshAssetChanged, new BUS_DispLibEventCollection.Del_OnSkeletalMeshAssetChanged(OnSkeletalMeshAssetChanged));
		}
		base.BGSEventCollection.Evt_NotifyMovieBegin += new Del_Void_IntInt(OnMovieBegin);
		base.BGSEventCollection.Evt_NotifyMovieEnd += new Del_Void_IntInt(OnMovieEnd);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_SetGamePause = (Del_Void_SetGamePause)Delegate.Combine(bGWEventCollection.Evt_SetGamePause, new Del_Void_SetGamePause(OnSetGamePause));
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		BGW_EventCollection bGWEventCollection = base.BGWEventCollection;
		bGWEventCollection.Evt_SetGamePause = (Del_Void_SetGamePause)Delegate.Remove(bGWEventCollection.Evt_SetGamePause, new Del_Void_SetGamePause(OnSetGamePause));
	}

	public void OnSetGamePause(EPauseEvent PauseEvent, bool bPause)
	{
		if (PauseEvent == EPauseEvent.TakePhoto)
		{
			EnvironmentMaskData.bInPhotoMode = bPause;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (EnvironmentMaskData.bStartEndDBCTimerCountdown)
		{
			EnvironmentMaskData.NotifyEndDBCTimer -= DeltaTime;
			if (EnvironmentMaskData.NotifyEndDBCTimer <= 0f)
			{
				NotifyEndDBCEffects();
				EnvironmentMaskData.bStartEndDBCTimerCountdown = false;
			}
		}
		if (!EnvironmentMaskData.bShouldTick || EnvironmentMaskData.bInPhotoMode || MagicallyChangeData.IsDurMagicallyChange())
		{
			return;
		}
		BGWDataAsset_EnvironmentMaskGlobalConfig environmentMaskGlobalConfig = BGW_PreloadAssetMgr.Get(Owner).EnvironmentMaskGlobalConfig;
		if (environmentMaskGlobalConfig == null || environmentMaskGlobalConfig.EnvironmentMaskMappingList == null)
		{
			return;
		}
		float value = 0f;
		Dictionary<ESceneItemSurfaceType, bool> dictionary = new Dictionary<ESceneItemSurfaceType, bool>();
		BGUEnvironmentSurfaceEffectMgr effectMgr = EnvMgrData.EffectMgr;
		if (effectMgr != null && effectMgr.WeatherType == EWeatherType.Snowy)
		{
			ESceneItemSurfaceType eSceneItemSurfaceType = ESceneItemSurfaceType.SnowSurface;
			if (environmentMaskGlobalConfig.EnvironmentMaskMappingList.TryGetValue(eSceneItemSurfaceType, out var value2))
			{
				bool num = effectMgr.GetEnvironmentSurfaceVolumeByLocation(BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner)) != null;
				float num2 = value2.AccumulateMaxValue;
				if (num2 <= 0f || num2 > 1f)
				{
					num2 = 1f;
				}
				if (num)
				{
					num2 = 0f;
				}
				if (!EnvironmentMaskData.PendingFadeTargetData.ContainsKey(eSceneItemSurfaceType))
				{
					EnvironmentMaskData.PendingFadeTargetData.Add(eSceneItemSurfaceType, 0f);
				}
				EnvironmentMaskData.PendingFadeTargetData[eSceneItemSurfaceType] = num2;
				if (!EnvironmentMaskData.AccumulatedMaskData.ContainsKey(eSceneItemSurfaceType))
				{
					EnvironmentMaskData.AccumulatedMaskData.Add(eSceneItemSurfaceType, 0f);
				}
				bool flag = EnvironmentMaskData.AccumulatedMaskData[eSceneItemSurfaceType] < num2;
				if (!num && flag)
				{
					value = EnvironmentMaskData.ModifyAccumulatedValue(eSceneItemSurfaceType, value2.AccumulateSpeed * DeltaTime, 0f, num2);
					dictionary[ESceneItemSurfaceType.SnowSurface] = true;
				}
			}
		}
		foreach (ESceneItemSurfaceType item in new List<ESceneItemSurfaceType>(EnvironmentMaskData.AccumulatedMaskData.Keys))
		{
			if (!environmentMaskGlobalConfig.EnvironmentMaskMappingList.TryGetValue(item, out var value3))
			{
				continue;
			}
			bool num3 = dictionary.ContainsKey(item) && dictionary[item];
			float value4;
			float num4 = (EnvironmentMaskData.PendingFadeTargetData.TryGetValue(item, out value4) ? value4 : 0f);
			bool flag2 = EnvironmentMaskData.AccumulatedMaskData[item] > num4;
			if (flag2)
			{
				float deltaValue = (0f - value3.FadeSpeed) * DeltaTime;
				value = EnvironmentMaskData.ModifyAccumulatedValue(item, deltaValue, 0f, 1f);
				if (EnvironmentMaskData.AccumulatedMaskData[item] < num4)
				{
					EnvironmentMaskData.AccumulatedMaskData[item] = num4;
				}
			}
			if (num3 || flag2)
			{
				ApplyToMaterial(value, ref value3);
			}
		}
		if (DebugConfig.ShowChrEnvMaskValue && Owner is BGUCharacterCS)
		{
			EnvironmentMaskData.AccumulatedMaskData.TryGetValue(ESceneItemSurfaceType.WaterSurface, out var value5);
			EnvironmentMaskData.AccumulatedMaskData.TryGetValue(ESceneItemSurfaceType.SnowSurface, out var value6);
			EnvironmentMaskData.AccumulatedMaskData.TryGetValue(ESceneItemSurfaceType.BloodSurface, out var value7);
			EnvironmentMaskData.AccumulatedMaskData.TryGetValue(ESceneItemSurfaceType.MudSurface, out var value8);
			EnvironmentMaskData.AccumulatedMaskData.TryGetValue(ESceneItemSurfaceType.BajieMud, out var value9);
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("ShowChrEnvMaskValue", $"WaterSurfaceValue：{value5}");
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("ShowChrEnvMaskValue", $"SnowSurfaceValue：{value6}", 1);
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("ShowChrEnvMaskValue", $"BloodSurfaceValue：{value7}", 2);
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("ShowChrEnvMaskValue", $"MudSurfaceValue | BajieMudValue：{value8} | {value9}", 3);
		}
	}

	private void NotifyEndDBCEffects()
	{
		foreach (Dictionary<FName, int> value2 in EnvironmentMaskData.GamePlayDispReqIDCache.Values)
		{
			foreach (KeyValuePair<FName, int> item in value2)
			{
				int value = item.Value;
				if (value > 0)
				{
					DBCEventCollection.Evt_RequestEndDBCEffects?.Invoke(value);
				}
			}
		}
		EnvironmentMaskData.GamePlayDispReqIDCache.Clear();
	}

	private void OnApplyEnvironmentMask(List<EnvironmentMaskData> EnvironmentMaskDataList)
	{
		if (MagicallyChangeData.IsDurMagicallyChange())
		{
			return;
		}
		BGWDataAsset_EnvironmentMaskGlobalConfig environmentMaskGlobalConfig = BGW_PreloadAssetMgr.Get(Owner).EnvironmentMaskGlobalConfig;
		if (environmentMaskGlobalConfig == null)
		{
			BGW_LogUtil.LogError("EnvironmentMaskGlobalConfig is not loaded!");
			return;
		}
		foreach (EnvironmentMaskData EnvironmentMaskData in EnvironmentMaskDataList)
		{
			ESceneItemSurfaceType surfaceType = EnvironmentMaskData.SurfaceType;
			float increment = EnvironmentMaskData.Increment;
			if (surfaceType == EnvironmentInteractionMgrData.ResultSurfaceType && environmentMaskGlobalConfig.EnvironmentMaskMappingList.TryGetValue(surfaceType, out var value))
			{
				if (!this.EnvironmentMaskData.AccumulatedMaskData.ContainsKey(surfaceType))
				{
					this.EnvironmentMaskData.AccumulatedMaskData.Add(surfaceType, 0f);
				}
				float value2 = this.EnvironmentMaskData.ModifyAccumulatedValue(surfaceType, increment, 0f, 1f);
				ApplyToMaterial(value2, ref value);
			}
		}
	}

	private void ApplyToMaterial(float Value, ref EnvironmentMaskMappingData MappingData)
	{
		FName fName = new FName(MappingData.LayerMappingName_Layer);
		FName fName2 = new FName(MappingData.ParamName);
		if (fName == FName.None || fName2 == FName.None)
		{
			return;
		}
		if (DBCEventCollection == null)
		{
			DBCEventCollection = BUS_DispLibEventCollection.Get(Owner);
			if (DBCEventCollection == null)
			{
				return;
			}
		}
		int value = -1;
		if (!EnvironmentMaskData.GamePlayDispReqIDCache.TryGetValue(fName, out var value2))
		{
			value2 = new Dictionary<FName, int> { { fName2, -1 } };
			EnvironmentMaskData.GamePlayDispReqIDCache.Add(fName, value2);
		}
		if (!value2.TryGetValue(fName2, out value))
		{
			value2.Add(fName2, -1);
		}
		EnvironmentMaskData.bStartEndDBCTimerCountdown = true;
		EnvironmentMaskData.ResetNotifyEndDBCTimer();
		if (value == -1)
		{
			FMatLayerFunctionInfo value3 = default(FMatLayerFunctionInfo);
			if (BGW_PreloadAssetMgr.Get(this).MatLayerFunctionMappingConfigMap.TryGetValue(0, out var value4) && value4.MatLayerFunctionInfoMap.TryGetValue(fName, out value3))
			{
				UMaterialFunctionInterface layerFunction = value3.LayerFunction;
				EMaterialParameterAssociation association = value3.Association;
				BUC_DispLibDBC_MaterialEffectTargetInfo allCompsAllMats = BUC_DispLibDBC_MaterialEffectTargetInfo.AllCompsAllMats;
				BUC_DispLibUtil_DBCAdvProcessScalar processValue = default(BUC_DispLibUtil_DBCAdvProcessScalar).SetCustomData(Value, 0f);
				List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> setScalarParam = new List<BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam> { default(BUC_DispLibUtil_DBCAdvProcessScalarMatLayerParam).SetCustomData(association, layerFunction, fName2, processValue) };
				BUC_DispLibDBC_ModifyMaterial d = default(BUC_DispLibDBC_ModifyMaterial).SetCustomData(allCompsAllMats, 0f, DispLibDBCEndMode.ProcedureNotity, 0f, 0f, setScalarParam, null, null, null, null, 0, 0, 0, 0);
				DBCEventCollection.Evt_RequestApply_One_ModMat?.Invoke(d, out value);
				if (value > 0)
				{
					value2[fName2] = value;
				}
			}
		}
		else
		{
			DBCEventCollection.Evt_RequestUpdateMatScalarParam?.Invoke(value, Value);
		}
	}

	private void OnSkeletalMeshAssetChanged(USkeletalMeshComponent MeshComp, USkeletalMesh OldSkeletalMeshAsset, USkeletalMesh NewSkeletalMeshAsset)
	{
		if (EnvironmentMaskData.bInPhotoMode)
		{
			return;
		}
		IBUC_EquipData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_EquipData>(Owner);
		if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.bInPhotoMode)
		{
			return;
		}
		foreach (ESceneItemSurfaceType item in EnvironmentMaskData.AccumulatedMaskData.Keys.ToList())
		{
			EnvironmentMaskData.AccumulatedMaskData[item] = 0f;
		}
		if (DBCEventCollection == null)
		{
			DBCEventCollection = BUS_DispLibEventCollection.Get(Owner);
			if (DBCEventCollection == null)
			{
				return;
			}
		}
		NotifyEndDBCEffects();
	}

	private void OnMovieBegin(int SeqID, int UniqueID)
	{
		EnvironmentMaskData.bShouldTick = false;
	}

	private void OnMovieEnd(int SeqID, int UniqueID)
	{
		EnvironmentMaskData.bShouldTick = true;
	}
}
