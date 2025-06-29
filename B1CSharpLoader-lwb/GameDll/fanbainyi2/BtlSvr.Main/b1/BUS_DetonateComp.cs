using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_DetonateComp : UActorCompBaseCS
{
	private BUC_DetonateData DetonateData { get; set; }

	private IBUC_AttrContainer AttrContainer { get; set; }

	private IBUC_PassiveSkillData PassiveSkillData { get; set; }

	private b1.IBGC_SimpleOverlapMgrData SimpleOverlapMgrData { get; set; }

	private int ReqID { get; set; } = 1;

	public override void OnAttach()
	{
		base.OnAttach();
		DetonateData = RequireWritableData<BUC_DetonateData>();
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_Detonate += new Del_Void_Int(DetonateUnit);
			base.BUSEventCollection.Evt_NotifyAttackerHitSuccess += new Del_NotifyAttackerHitSuccess(AttackCallBack);
		}
		SimpleOverlapMgrData = RequireReadOnlyGameStateData<b1.IBGC_SimpleOverlapMgrData, BGC_SimpleOverlapMgrData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		PassiveSkillData = RequireReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>();
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		if (Owner is BGUCharacterCS bGUCharacterCS)
		{
			DetonateData.IsActived = bGUCharacterCS.GetResID() == 18;
			FUStDetonateConfigDesc detonateConfigDesc = BGW_GameDB.GetDetonateConfigDesc(bGUCharacterCS.GetResID());
			if (detonateConfigDesc != null)
			{
				DetonateData.Init(detonateConfigDesc);
				DetonateData.DBCConfig = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BUC_DispLibDispBaseConfigDataAsset>(DetonateData.ExplosiveDBCPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low, DBCAsyncLoadFinishCallback, ReqID);
			}
		}
	}

	private void DBCAsyncLoadFinishCallback(int ReqID, UObject Obj)
	{
		if (Owner is BGUCharacterCS && Obj is BUC_DispLibDispBaseConfigDataAsset dBCConfig && ReqID == this.ReqID)
		{
			DetonateData.DBCConfig = dBCConfig;
		}
	}

	public void DetonateUnit(int ChargeLevel)
	{
		FVector inOriginalLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		SimpleOverlapMgrData.GetSimpleOverlapActorsByMask(Owner, inOriginalLocation, 1, DetonateData.TriggerExplosiveRadius, 0f, 0f, FVector2D.ZeroVector, IsSphere: true, out var OutList);
		Dictionary<BUS_GSEventCollection, int> dictionary = new Dictionary<BUS_GSEventCollection, int>();
		Dictionary<BUS_GSEventCollection, int> dictionary2 = new Dictionary<BUS_GSEventCollection, int>();
		Dictionary<AActor, int> dictionary3 = new Dictionary<AActor, int>();
		foreach (AActor item in OutList)
		{
			if (item == Owner)
			{
				continue;
			}
			BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(item);
			if (readOnlyData != null)
			{
				int buffLayer = readOnlyData.GetBuffLayer(DetonateData.DetonateBuff);
				if (buffLayer > 0 && !dictionary3.ContainsKey(item))
				{
					dictionary3.Add(item, buffLayer);
				}
			}
		}
		foreach (KeyValuePair<AActor, int> item2 in dictionary3)
		{
			AActor key = item2.Key;
			int value = item2.Value;
			if (value <= 0)
			{
				continue;
			}
			BGUAdsortLevelConfigInfo bGUAdsortLevelConfigInfo = DetonateData.AdsortLevelConfigInfoList[value - 1];
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(key);
			SimpleOverlapMgrData.GetSimpleOverlapActorsByMask(Owner, fVector, 1, bGUAdsortLevelConfigInfo.ExplosiveRadius, 0f, 0f, FVector2D.ZeroVector, IsSphere: true, out var OutList2);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(key);
			if (bUS_GSEventCollection != null)
			{
				BUC_AttachedNiagaraMgrData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_AttachedNiagaraMgrData>(key);
				if (readOnlyData2 != null && readOnlyData2.AttachedNiagaraConfigsMapping.TryGetValue(EAttachNiagaraEventType.SpiderEggByDetonate, out var value2))
				{
					foreach (AttachedNiagaraInst attachedNiagaraInst in value2.AttachedNiagaraInsts)
					{
						if (attachedNiagaraInst.BoneName != FName.None)
						{
							(key as BGUCharacterCS).Mesh.TransformFromBoneSpace(attachedNiagaraInst.BoneName, attachedNiagaraInst.RelativeLocation, FRotator.ZeroRotator, out var OutPosition, out var _);
							BUS_DispLibEventCollection bUS_DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
							int GamePlayDispReqID = 0;
							bUS_DispLibEventCollection.Evt_RequestApplyOneDBCDataAsset(DetonateData.DBCConfig, out GamePlayDispReqID);
							bUS_DispLibEventCollection.Evt_RequestSetDBCNiagaraVectorParam(GamePlayDispReqID, B1GlobalFNames.User_SpawnPoint, OutPosition);
						}
					}
				}
				bUS_GSEventCollection?.Evt_BuffRemove.Invoke(DetonateData.DetonateBuff, EBuffEffectTriggerType.Remove, value);
				bUS_GSEventCollection?.Evt_DestroyAllNiagaraByEventType.Invoke(EAttachNiagaraEventType.SpiderEggByDetonate);
				bUS_GSEventCollection?.Evt_TriggerClearScar.Invoke(EScarDecalTriggerType.Dcss);
				if (!dictionary.ContainsKey(bUS_GSEventCollection))
				{
					dictionary.Add(bUS_GSEventCollection, value);
				}
			}
			FEffectInstReq hitReq = default(FEffectInstReq);
			foreach (AActor item3 in OutList2)
			{
				BUS_GSEventCollection bUS_GSEventCollection2 = BUS_EventCollectionCS.Get(item3);
				if (!(item3 == key) && bUS_GSEventCollection2 != null)
				{
					for (int i = 0; i < bGUAdsortLevelConfigInfo.ExplosiveLevel; i++)
					{
						hitReq.HitLocation = fVector;
						AddDetonateBuff(item3, hitReq);
					}
				}
			}
			SimpleOverlapMgrData.GetSimpleOverlapActorsByMask(Owner, fVector, 1, bGUAdsortLevelConfigInfo.PlayerGainRadius, 0f, 0f, FVector2D.ZeroVector, IsSphere: true, out var OutList3);
			BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(bGUAdsortLevelConfigInfo.PlayerGainBuff, PassiveSkillData);
			foreach (AActor item4 in OutList3)
			{
				if (item4 == key || !(item4 is BGUPlayerCharacterCS))
				{
					continue;
				}
				BUS_GSEventCollection bUS_GSEventCollection3 = BUS_EventCollectionCS.Get(item4);
				if (!(bUS_GSEventCollection3 != null) || buffDescRuntime == null || dictionary2.ContainsKey(bUS_GSEventCollection3))
				{
					continue;
				}
				float num = FVector.Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(item4), fVector);
				int num2 = 0;
				foreach (FUStDelayPlayerGainConfig delayPlayerGainConfig in DetonateData.DelayPlayerGainConfigList)
				{
					if (num > delayPlayerGainConfig.Distance)
					{
						num2++;
						continue;
					}
					break;
				}
				if (num2 >= DetonateData.DelayPlayerGainConfigList.Count)
				{
					num2--;
				}
				BuffDescRuntime buffDescRuntime2 = BGW_GameDB.GetBuffDescRuntime(DetonateData.DelayPlayerGainConfigList[num2].BuffID, PassiveSkillData);
				if (buffDescRuntime2 != null)
				{
					bUS_GSEventCollection3.Evt_BuffAdd.Invoke(DetonateData.DelayPlayerGainConfigList[num2].BuffID, item4, item4, (float)buffDescRuntime2.GetDuration() / 1000f, EBuffSourceType.Detonate);
				}
				BuffDescRuntime buffDescRuntime3 = null;
				int buffID = -1;
				switch (value)
				{
				case 1:
					buffDescRuntime3 = BGW_GameDB.GetBuffDescRuntime(DetonateData.DelayPlayerGainConfigList[num2].PerformanceBuffL1, PassiveSkillData);
					buffID = DetonateData.DelayPlayerGainConfigList[num2].PerformanceBuffL1;
					break;
				case 2:
					buffDescRuntime3 = BGW_GameDB.GetBuffDescRuntime(DetonateData.DelayPlayerGainConfigList[num2].PerformanceBuffL2, PassiveSkillData);
					buffID = DetonateData.DelayPlayerGainConfigList[num2].PerformanceBuffL2;
					break;
				case 3:
					buffDescRuntime3 = BGW_GameDB.GetBuffDescRuntime(DetonateData.DelayPlayerGainConfigList[num2].PerformanceBuffL3, PassiveSkillData);
					buffID = DetonateData.DelayPlayerGainConfigList[num2].PerformanceBuffL3;
					break;
				case 4:
					buffDescRuntime3 = BGW_GameDB.GetBuffDescRuntime(DetonateData.DelayPlayerGainConfigList[num2].PerformanceBuffL4, PassiveSkillData);
					buffID = DetonateData.DelayPlayerGainConfigList[num2].PerformanceBuffL4;
					break;
				}
				if (buffDescRuntime3 != null)
				{
					bUS_GSEventCollection.Evt_BuffAdd.Invoke(buffID, item4, item4, buffDescRuntime3.GetDuration(), EBuffSourceType.Detonate);
				}
				bUS_GSEventCollection3.Evt_BuffAdd.Invoke(DetonateData.AdsortLevelConfigInfoList[value - 1].PlayerGainBuff, item4, item4, buffDescRuntime.GetDuration(), EBuffSourceType.Detonate);
			}
		}
		foreach (KeyValuePair<BUS_GSEventCollection, int> item5 in dictionary)
		{
			BUS_GSEventCollection key2 = item5.Key;
			BuffDescRuntime buffDescRuntime4 = BGW_GameDB.GetBuffDescRuntime(DetonateData.AdsortLevelConfigInfoList[item5.Value - 1].ExplosiveDamageBuff, PassiveSkillData);
			if (buffDescRuntime4 != null)
			{
				int duration = buffDescRuntime4.GetDuration();
				switch (item5.Value)
				{
				case 1:
					key2?.Evt_AttachNiagaraByEventType.Invoke(EAttachNiagaraEventType.ExplosiveByDetonatel0, (float)duration / 1000f);
					break;
				case 2:
					key2?.Evt_AttachNiagaraByEventType.Invoke(EAttachNiagaraEventType.ExplosiveByDetonatel1, (float)duration / 1000f);
					break;
				case 3:
					key2?.Evt_AttachNiagaraByEventType.Invoke(EAttachNiagaraEventType.ExplosiveByDetonatel2, (float)duration / 1000f);
					break;
				case 4:
					key2?.Evt_AttachNiagaraByEventType.Invoke(EAttachNiagaraEventType.ExplosiveByDetonatel3, (float)duration / 1000f);
					break;
				}
				key2.Evt_BuffAdd.Invoke(DetonateData.AdsortLevelConfigInfoList[item5.Value - 1].ExplosiveDamageBuff, Owner, Owner, duration, EBuffSourceType.Detonate);
			}
		}
		base.BUSEventCollection?.Evt_RemoveDetonate.Invoke();
	}

	public void AddDetonateBuff(AActor Victim, FEffectInstReq HitReq)
	{
		BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Victim);
		if (readOnlyData != null)
		{
			int buffLayer = readOnlyData.GetBuffLayer(DetonateData.DetonateBuff);
			BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(DetonateData.DetonateBuff, PassiveSkillData);
			int maxLayer = buffDescRuntime.GetMaxLayer();
			int duration = buffDescRuntime.GetDuration();
			FTransform frontLocationByHitPoint = BGUFunctionLibraryCS.GetFrontLocationByHitPoint(HitReq.Attacker, HitReq.HitLocation, HitReq.HitPointNormalDir, ETraceTypeQuery.TraceTypeQuery4, bDebug: false);
			FVector OutPosition = FVector.OneVector;
			if (Victim is BGUCharacterCS bGUCharacterCS)
			{
				bGUCharacterCS.Mesh.TransformToBoneSpace(HitReq.HitBoneName, frontLocationByHitPoint.GetLocation(), HitReq.HitPointNormalDir, out OutPosition, out var _);
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Victim);
			if (buffLayer < maxLayer)
			{
				bUS_GSEventCollection?.Evt_BuffAdd.Invoke(DetonateData.DetonateBuff, Owner, Owner, duration, EBuffSourceType.Detonate);
				bUS_GSEventCollection?.Evt_AttachNiagaraByEventTypeAndLocation.Invoke(EAttachNiagaraEventType.SpiderEggByDetonate, frontLocationByHitPoint.GetLocation(), HitReq.HitBoneName, OutPosition, (float)duration / 1000f);
			}
			else
			{
				bUS_GSEventCollection?.Evt_BuffAdd.Invoke(DetonateData.DetonateBuff, Owner, Owner, duration, EBuffSourceType.Detonate);
				bUS_GSEventCollection?.Evt_AttachNiagaraByEventTypeAndLocation.Invoke(EAttachNiagaraEventType.SpiderEggByDetonate, frontLocationByHitPoint.GetLocation(), HitReq.HitBoneName, OutPosition, (float)duration / 1000f);
				bUS_GSEventCollection?.Evt_DestroyNiagaraByEventType.Invoke(EAttachNiagaraEventType.SpiderEggByDetonate);
			}
			bUS_GSEventCollection?.Evt_ResetAllInstByEventType.Invoke(EAttachNiagaraEventType.SpiderEggByDetonate);
			base.BUSEventCollection?.Evt_AddDetonate.Invoke();
		}
	}

	public void AttackCallBack(AActor VictimActor, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, bool IsVictimDead)
	{
		if (DetonateData.IsActived && SkillDamageConfig.DmgReason == EDamageReason.Skill && !(AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue) <= 0f))
		{
			AddDetonateBuff(VictimActor, EffectInstReq);
			base.BUSEventCollection.Evt_IncreasePEValue.Invoke(-1f, EPotentialEnergyIncreaseReason.Normal);
		}
	}
}
