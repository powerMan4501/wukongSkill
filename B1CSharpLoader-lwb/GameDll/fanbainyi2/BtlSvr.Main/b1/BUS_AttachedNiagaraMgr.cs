using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using GSDispLib;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_AttachedNiagaraMgr : UActorCompBaseCS
{
	private BUC_AttachedNiagaraMgrData AttachedNiagaraMgrData { get; set; }

	private IBUC_BeAttackData BeAttackData { get; set; }

	private IBUC_ActorTransformInfoData ActorTransformInfoData { get; set; }

	private IBUC_PassiveSkillData PassiveSkillData { get; set; }

	private BUS_DispLibEventCollection DispLibEventCollection { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		AttachedNiagaraMgrData = RequireWritableData<BUC_AttachedNiagaraMgrData>();
		BeAttackData = RequireReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>();
		ActorTransformInfoData = RequireReadOnlyData<IBUC_ActorTransformInfoData, BUC_ActorTransformInfoData>();
		PassiveSkillData = RequireReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>();
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_AttachNiagaraByEventType += new Del_AttachNiagaraByEventType(OnAttachedNiagaraByEventType);
			base.BUSEventCollection.Evt_AttachNiagaraByEventTypeAndLocation += new Del_AttachNiagaraByEventTypeAndLocation(OnAttachedNiagaraByEventTypeAndLocation);
			base.BUSEventCollection.Evt_DestroyNiagaraByEventType += new Del_DestroyNiagaraByEventType(OnDestoryNiagaraByEventType);
			base.BUSEventCollection.Evt_DestroyAllNiagaraByEventType += new Del_DestroyNiagaraByEventType(OnDestoryAllNiagaraByEventType);
			base.BUSEventCollection.Evt_ResetAllInstByEventType += new Del_DestroyNiagaraByEventType(OnResetAllInstByEventType);
			base.BUSEventCollection.Evt_OnBuffLayerChanged += new Del_OnBuffLayerChanged(OnBuffLayerChanged);
			base.BUSEventCollection.Evt_PauseUpdate += new Del_Void_Bool(OnPauseUpdate);
		}
		DispLibEventCollection = BUS_DispLibEventCollection.Get(Owner);
	}

	public override void PreBeginPlay()
	{
		InitData();
	}

	private void InitData()
	{
		if (!(Owner is BGUCharacterCS bGUCharacterCS))
		{
			return;
		}
		Dictionary<int, FUStAttachedNiagaraByHitDesc> allAttachedNiagaraByHitDesc = BGW_GameDB.GetAllAttachedNiagaraByHitDesc();
		int resID = bGUCharacterCS.GetResID();
		foreach (KeyValuePair<int, FUStAttachedNiagaraByHitDesc> item in allAttachedNiagaraByHitDesc)
		{
			FUStAttachedNiagaraByHitDesc value = item.Value;
			if (value.ResID != resID && value.ResID != -1)
			{
				continue;
			}
			string dBCPath = value.DBCPath;
			if (value.IsUseUnitBodyCondition == EGSYesNo.Yes)
			{
				FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(resID);
				if (unitCommDesc != null)
				{
					switch (unitCommDesc.UnitBodyType)
					{
					case EUnitBodyType.None:
						dBCPath = value.NoneDBCpath;
						break;
					case EUnitBodyType.Small:
						dBCPath = value.SmallDBCpath;
						break;
					case EUnitBodyType.Medium:
						dBCPath = value.MediumDBCpath;
						break;
					case EUnitBodyType.MediumBig:
						dBCPath = value.MediumBigDBCpath;
						break;
					case EUnitBodyType.Big:
						dBCPath = value.BigDBCpath;
						break;
					case EUnitBodyType.Huge:
						dBCPath = value.HugeDBCpath;
						break;
					}
				}
			}
			BGUAttachedNiagaraConfig bGUAttachedNiagaraConfig = new BGUAttachedNiagaraConfig(value.RemoveAttachedNiagaraRule, dBCPath, value.Priority);
			if (AttachedNiagaraMgrData.AttachedNiagaraConfigsMapping.TryGetValue(value.AttachNiagaraEventType, out var value2))
			{
				if (bGUAttachedNiagaraConfig.Priority >= value2.Priority)
				{
					AttachedNiagaraMgrData.AttachedNiagaraConfigsMapping[value.AttachNiagaraEventType] = bGUAttachedNiagaraConfig;
				}
			}
			else
			{
				AttachedNiagaraMgrData.AttachedNiagaraConfigsMapping.Add(value.AttachNiagaraEventType, bGUAttachedNiagaraConfig);
			}
		}
		AttachedNiagaraMgrData.IsModing = false;
		AttachedNiagaraMgrData.IsUpdate = true;
	}

	private void OnPauseUpdate(bool bShouldPause)
	{
		AttachedNiagaraMgrData.IsUpdate = !bShouldPause;
	}

	private void OnBuffLayerChanged(EntitySharedRef RootCasterRef, int BuffID, int Layer_OldValue, int Layer_NewValue)
	{
		FUStDetonateConfigDesc detonateConfigDesc = BGW_GameDB.GetDetonateConfigDesc(18);
		if (detonateConfigDesc == null)
		{
			return;
		}
		if (Layer_NewValue == Layer_OldValue && Layer_NewValue == 4)
		{
			OnAttachedNiagaraByEventType(EAttachNiagaraEventType.SpiderEggMaxLevelByDetonate, -1f);
		}
		else if (BuffID == detonateConfigDesc.BuffID)
		{
			switch (Layer_NewValue)
			{
			case 0:
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel0);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel1);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel2);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel3);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggMaxLevelByDetonate);
				break;
			case 1:
				OnAttachedNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel0, -1f);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel1);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel2);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel3);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggMaxLevelByDetonate);
				break;
			case 2:
				OnAttachedNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel1, -1f);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel0);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel2);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel3);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggMaxLevelByDetonate);
				break;
			case 3:
				OnAttachedNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel2, -1f);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel0);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel1);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel3);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggMaxLevelByDetonate);
				break;
			case 4:
				OnAttachedNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel3, -1f);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel0);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel1);
				OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType.SpiderEggStandingByDetonateLevel2);
				OnAttachedNiagaraByEventType(EAttachNiagaraEventType.SpiderEggMaxLevelByDetonate, -1f);
				break;
			}
		}
	}

	public void OnAttachedNiagaraByEventType(EAttachNiagaraEventType EventType, float DurTime)
	{
		if (AttachedNiagaraMgrData.AttachedNiagaraConfigsMapping.TryGetValue(EventType, out var value))
		{
			SpawnOneNiagara(value, FVector.OneVector, FName.None, FVector.OneVector, DurTime);
		}
	}

	public void OnAttachedNiagaraByEventTypeAndLocation(EAttachNiagaraEventType EventType, FVector HitLocation, FName BoneName, FVector RelativeLocation, float DurTime)
	{
		if (AttachedNiagaraMgrData.AttachedNiagaraConfigsMapping.TryGetValue(EventType, out var value))
		{
			SpawnOneNiagara(value, HitLocation, BoneName, RelativeLocation, DurTime);
		}
	}

	public void OnDestoryAllNiagaraByEventType(EAttachNiagaraEventType EventType)
	{
		if (AttachedNiagaraMgrData.AttachedNiagaraConfigsMapping.TryGetValue(EventType, out var value) && value != null)
		{
			DestoryAllNiagara(value);
		}
	}

	public void OnDestoryNiagaraByEventType(EAttachNiagaraEventType EventType)
	{
		AttachedNiagaraMgrData.AttachedNiagaraConfigsMapping.TryGetValue(EventType, out var value);
		if (value != null)
		{
			DestroyOneNiagara(value);
		}
	}

	private void DBCAsyncLoadFinishCallback(int ReqID, UObject Obj)
	{
		if (!(Owner is BGUCharacterCS bGUCharacterCS) || !(Obj is BUC_DispLibDispBaseConfigDataAsset dBCDataAsset))
		{
			return;
		}
		string pathName = Obj.GetPathName();
		foreach (KeyValuePair<EAttachNiagaraEventType, BGUAttachedNiagaraConfig> item in AttachedNiagaraMgrData.AttachedNiagaraConfigsMapping)
		{
			if (!(pathName == item.Value.DBCPath))
			{
				continue;
			}
			foreach (AttachedNiagaraInst attachedNiagaraInst in item.Value.AttachedNiagaraInsts)
			{
				DispLibEventCollection.Evt_RequestApplyOneDBCDataAsset(dBCDataAsset, out var GamePlayDispReqID, bGUCharacterCS.Mesh);
				attachedNiagaraInst.GamePlayDispReqID = GamePlayDispReqID;
				DispLibEventCollection.Evt_RequestSetDBCNiagaraVectorParam(attachedNiagaraInst.GamePlayDispReqID, B1GlobalFNames.User_SpawnPoint, attachedNiagaraInst.HitLocation);
			}
		}
	}

	public void SpawnOneNiagara(BGUAttachedNiagaraConfig Config, FVector HitLocation, FName BoneName, FVector RelativeLocation, float DurTime)
	{
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			BUC_DispLibDispBaseConfigDataAsset bUC_DispLibDispBaseConfigDataAsset = BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<BUC_DispLibDispBaseConfigDataAsset>(Config.DBCPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low, DBCAsyncLoadFinishCallback);
			if (bUC_DispLibDispBaseConfigDataAsset == null)
			{
				Config.AttachedNiagaraInsts.Add(new AttachedNiagaraInst(HitLocation, DurTime, BoneName, RelativeLocation, -1, Config.DBCPath));
			}
			DispLibEventCollection.Evt_RequestApplyOneDBCDataAsset(bUC_DispLibDispBaseConfigDataAsset, out var GamePlayDispReqID, bGUCharacterCS.Mesh);
			DispLibEventCollection.Evt_RequestSetDBCNiagaraVectorParam(GamePlayDispReqID, B1GlobalFNames.User_SpawnPoint, HitLocation);
			Config.AttachedNiagaraInsts.Add(new AttachedNiagaraInst(HitLocation, DurTime, BoneName, RelativeLocation, GamePlayDispReqID, Config.DBCPath));
		}
	}

	public void DestoryAllNiagara(BGUAttachedNiagaraConfig Config)
	{
		if (Config.AttachedNiagaraInsts.Count > 0)
		{
			while (Config.AttachedNiagaraInsts.Count > 0)
			{
				DestroyOneNiagara(Config);
			}
		}
	}

	public void DestroyOneNiagara(BGUAttachedNiagaraConfig Config)
	{
		if (Config.AttachedNiagaraInsts.Count <= 0)
		{
			return;
		}
		if (Config.RemoveRule == ERemoveAttachedNiagaraRule.Queue)
		{
			AttachedNiagaraInst attachedNiagaraInst = Config.AttachedNiagaraInsts.First();
			if (attachedNiagaraInst != null)
			{
				Config.AttachedNiagaraInsts.Remove(attachedNiagaraInst);
				DispLibEventCollection.Evt_RequestEndDBCEffects(attachedNiagaraInst.GamePlayDispReqID, OnlyEndFX: false, OnlyEndProcedureEndMode: false, -1, ForceDestroyComponent: true);
			}
		}
		else if (Config.RemoveRule == ERemoveAttachedNiagaraRule.Stack)
		{
			AttachedNiagaraInst attachedNiagaraInst2 = Config.AttachedNiagaraInsts.Last();
			if (attachedNiagaraInst2 != null)
			{
				Config.AttachedNiagaraInsts.Remove(attachedNiagaraInst2);
				DispLibEventCollection.Evt_RequestEndDBCEffects(attachedNiagaraInst2.GamePlayDispReqID, OnlyEndFX: false, OnlyEndProcedureEndMode: false, -1, ForceDestroyComponent: true);
			}
		}
	}

	public void OnResetAllInstByEventType(EAttachNiagaraEventType EventType)
	{
		if (!AttachedNiagaraMgrData.AttachedNiagaraConfigsMapping.TryGetValue(EventType, out var value))
		{
			return;
		}
		foreach (AttachedNiagaraInst attachedNiagaraInst in value.AttachedNiagaraInsts)
		{
			attachedNiagaraInst.Timer = attachedNiagaraInst.DurTime;
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		base.OnTickWithGroup(DeltaTime, TickGroup);
		if (!AttachedNiagaraMgrData.IsUpdate)
		{
			return;
		}
		new List<AttachedNiagaraInst>();
		foreach (KeyValuePair<EAttachNiagaraEventType, BGUAttachedNiagaraConfig> item in AttachedNiagaraMgrData.AttachedNiagaraConfigsMapping)
		{
			BGUAttachedNiagaraConfig value = item.Value;
			for (int num = value.AttachedNiagaraInsts.Count - 1; num >= 0; num--)
			{
				if (value.AttachedNiagaraInsts[num].Timer != -1f)
				{
					if (value.AttachedNiagaraInsts[num].Timer > 0f)
					{
						value.AttachedNiagaraInsts[num].Timer -= DeltaTime;
					}
					else
					{
						if (value.AttachedNiagaraInsts[num].GamePlayDispReqID != -1)
						{
							DispLibEventCollection.Evt_RequestEndDBCEffects(value.AttachedNiagaraInsts[num].GamePlayDispReqID, OnlyEndFX: false, OnlyEndProcedureEndMode: false, -1, ForceDestroyComponent: true);
						}
						value.AttachedNiagaraInsts.RemoveAt(num);
					}
				}
			}
		}
	}
}
