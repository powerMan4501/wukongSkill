using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using b1.Plugins.AkAudio;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PotentialEnergyCompImpl : UActorCompBaseCS
{
	private BUC_PotentialEnergyData PotentialEnergyData;

	private IBUC_AttrContainer AttrContainer;

	private IBUC_SimpleStateData SimpleStateData;

	private BUAttrCostTemplate AttrCostTemplate;

	private IBUC_ChargeSkillData ChargeSkillData { get; set; }

	public override void OnAttach()
	{
		PotentialEnergyData = RequireWritableData<BUC_PotentialEnergyData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		ChargeSkillData = RequireReadOnlyData<IBUC_ChargeSkillData, BUC_ChargeSkillData>();
		AttrCostTemplate = BGW_EffectTemplateList.Get(Owner).GetAttrCostTemplate(EAttrCostType.PotentialEnergy);
		if (base.BUSEventCollection != null)
		{
			base.BUSEventCollection.Evt_IncreasePEValue += new Del_IncreasePEValue(IncreasePEValue);
			base.BUSEventCollection.Evt_ClearPEValue += new Del_Void(ClearPEValue);
			base.BUSEventCollection.Evt_SwitchPEConfig += new Del_Void_IntInt(SwitchPEConfig);
			base.BUSEventCollection.Evt_ReloadPEConfig += new Del_Void(ResetPEConfig);
			base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		}
		ResetPEConfig();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		DecreaseTick(DeltaTime);
	}

	private int CheckPELevelByValue(float Value)
	{
		int num = 0;
		foreach (KeyValuePair<int, PotentialEnergyLevelDetail> item in PotentialEnergyData.LevelMap)
		{
			if (item.Key > num && Value >= item.Value.LevelValue)
			{
				num = item.Key;
			}
		}
		return num;
	}

	private void DecreaseTick(float DeltaTime)
	{
		float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue);
		if (floatValue <= 0f)
		{
			return;
		}
		if (PotentialEnergyData.ProtectTime > 0f)
		{
			PotentialEnergyData.ProtectTime -= DeltaTime;
		}
		if (PotentialEnergyData.ProtectTime > 0f || PotentialEnergyData.ProtectTime == -1f)
		{
			return;
		}
		if (PotentialEnergyData.DecreaseProtecTimer > 0f)
		{
			PotentialEnergyData.DecreaseProtecTimer -= DeltaTime;
		}
		if (PotentialEnergyData.DecreaseProtecTimer > 0f)
		{
			return;
		}
		int curPELevel = PotentialEnergyData.GetCurPELevel(Owner);
		float num = PotentialEnergyData.DecreasePerSecond * DeltaTime;
		float value = floatValue - num;
		int num2 = CheckPELevelByValue(value);
		if (num2 < curPELevel)
		{
			if (PotentialEnergyData.LevelMap[num2].ProtectTime == -1f)
			{
				num = floatValue - PotentialEnergyData.LevelMap[num2 + 1].LevelValue;
			}
			else if (PotentialEnergyData.LevelMap[num2].ProtectTime > 0f)
			{
				if (PotentialEnergyData.DecreaseProtecTimer == -1f)
				{
					PotentialEnergyData.DecreaseProtecTimer = PotentialEnergyData.LevelMap[num2].ProtectTime;
				}
				if (PotentialEnergyData.DecreaseProtecTimer > 0f)
				{
					num = floatValue - PotentialEnergyData.LevelMap[num2 + 1].LevelValue;
				}
			}
		}
		AttrCostTemplate.DoCostAttrValue(Owner, AttrContainer, num, 0f);
		int curPELevel2 = PotentialEnergyData.GetCurPELevel(Owner);
		if (curPELevel2 < curPELevel)
		{
			EnterNewLevel(curPELevel2, curPELevel);
		}
	}

	private void ClearDecreaseProtecTimer()
	{
		PotentialEnergyData.DecreaseProtecTimer = -1f;
	}

	private void IncreasePEValue(float IncreaseValue, EPotentialEnergyIncreaseReason Reason)
	{
		if (IncreaseValue == 0f)
		{
			return;
		}
		if (IncreaseValue < 0f)
		{
			DecreasePEValue(IncreaseValue);
		}
		else
		{
			if (SimpleStateData.HasSimpleState(EBGUSimpleState.PEClearProtect))
			{
				return;
			}
			int curPELevel = PotentialEnergyData.GetCurPELevel(Owner);
			float increaseValue = 0f;
			switch (Reason)
			{
			case EPotentialEnergyIncreaseReason.Normal:
				increaseValue = IncreasePEValue_Normal(IncreaseValue);
				break;
			case EPotentialEnergyIncreaseReason.ByChargeSkill:
				increaseValue = IncreasePEValue_ByChargeSkill(IncreaseValue);
				break;
			}
			ClearDecreaseProtecTimer();
			base.BUSEventCollection?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Pevalue, increaseValue);
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue);
			switch (Reason)
			{
			case EPotentialEnergyIncreaseReason.Normal:
				if (floatValue >= PotentialEnergyData.PELimit_Normal)
				{
					base.BUSEventCollection?.Evt_PEValueFull.Invoke();
				}
				break;
			case EPotentialEnergyIncreaseReason.ByChargeSkill:
				if (floatValue >= PotentialEnergyData.PELimit_ByChargeSkill)
				{
					base.BUSEventCollection?.Evt_PEValueFull.Invoke();
				}
				break;
			}
			int curPELevel2 = PotentialEnergyData.GetCurPELevel(Owner);
			int num = curPELevel2 - curPELevel;
			if (num > 0)
			{
				int num2 = curPELevel;
				while (num > 0)
				{
					num2++;
					HandleUpgradePerLevel(num2, Reason);
					num--;
				}
				EnterNewLevel(curPELevel2);
			}
		}
	}

	private float IncreasePEValue_Normal(float IncreaseValue)
	{
		float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue);
		if (floatValue >= PotentialEnergyData.PELimit_Normal)
		{
			return 0f;
		}
		return MathLib.Clamp(floatValue + IncreaseValue, floatValue, PotentialEnergyData.PELimit_Normal) - floatValue;
	}

	private float IncreasePEValue_ByChargeSkill(float IncreaseValue)
	{
		float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue);
		if (floatValue >= PotentialEnergyData.PELimit_ByChargeSkill)
		{
			return 0f;
		}
		return MathLib.Clamp(floatValue + IncreaseValue, floatValue, PotentialEnergyData.PELimit_ByChargeSkill) - floatValue;
	}

	private void HandleUpgradePerLevel(int Level_AfterGrowUp, EPotentialEnergyIncreaseReason Reason)
	{
		if (Reason == EPotentialEnergyIncreaseReason.ByChargeSkill)
		{
			UAkGameplayStatics.PostEvent(BGW_PreloadAssetMgr.Get(Owner).TryGetCachedResourceObj<UAkAudioEvent>($"AkAudioEvent'/Game/00Main/Audio/Motion/Motion_player_xuli_done_{Level_AfterGrowUp}.Motion_player_xuli_done_{Level_AfterGrowUp}'", ELoadResourceType.SyncLoadAndCache), Owner, 0, null);
		}
		TriggeSkillComboGraph_LevelGrowUp();
		IncreaseChargeLevel();
		TriggerBuff_PerLevelGrowUp(Level_AfterGrowUp);
	}

	private void DecreasePEValue(float DecreaseValue)
	{
		DecreaseValue = FMath.Abs(DecreaseValue);
		int curPELevel = PotentialEnergyData.GetCurPELevel(Owner);
		AttrCostTemplate.DoCostAttrValue(Owner, AttrContainer, DecreaseValue, 0f);
		int curPELevel2 = PotentialEnergyData.GetCurPELevel(Owner);
		int num = curPELevel - curPELevel2;
		if (num > 0)
		{
			EnterNewLevel(curPELevel2, curPELevel);
			while (num > 0)
			{
				DecreaseChargeLevel();
				num--;
			}
		}
	}

	private void EnterNewLevel(int NewLevel, int PreLevel = 0, bool bFromPEConfigChange = false)
	{
		ClearDecreaseProtecTimer();
		if (NewLevel == 0)
		{
			PotentialEnergyData.DecreasePerSecond = PotentialEnergyData.LevelMap[NewLevel].DecreaseValuePerSecond;
			PotentialEnergyData.ProtectTime = 0f;
		}
		else
		{
			PotentialEnergyData.DecreasePerSecond = PotentialEnergyData.LevelMap[NewLevel].DecreaseValuePerSecond;
			if (NewLevel > PreLevel)
			{
				PotentialEnergyData.ProtectTime = PotentialEnergyData.LevelMap[NewLevel].ProtectTime;
				if (!bFromPEConfigChange)
				{
					base.BUSEventCollection.Evt_RequestSpawnFXByDispConfigDA.Invoke(PotentialEnergyData.LevelMap[NewLevel].LevelDBC, out var _, OwnerAsCharacterCS.Mesh);
				}
			}
		}
		foreach (int item in PotentialEnergyData.LastLevelBuffID)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(item, EBuffEffectTriggerType.None, 1);
		}
		PotentialEnergyData.LastLevelBuffID.Clear();
		foreach (int buffID in PotentialEnergyData.LevelMap[NewLevel].BuffIDList)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(buffID, Owner, Owner, -1f, EBuffSourceType.PotentialEnergy);
			PotentialEnergyData.LastLevelBuffID.Add(buffID);
		}
		int switchPEConfigBuffID = PotentialEnergyData.LevelMap[NewLevel].SwitchPEConfigBuffID;
		if (PotentialEnergyData.LevelMap[NewLevel].SwitchPEConfigBuffID > 0)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(switchPEConfigBuffID, Owner, Owner, -1f, EBuffSourceType.PotentialEnergy);
		}
	}

	private void ClearPEValue()
	{
		BGW_EffectTemplateList.Get(Owner).GetAttrCostTemplate(EAttrCostType.PotentialEnergy).DoCostAttrValue(Owner, AttrContainer, 0f, 1f);
		if (PotentialEnergyData.LevelMap.Count >= 1)
		{
			EnterNewLevel(0);
		}
	}

	private void SetPEConfig(Dictionary<int, FUStPotentialEnergyConfigDesc> LevelMapedDesc)
	{
		if (LevelMapedDesc == null || LevelMapedDesc.Count < 0 || !LevelMapedDesc.TryGetValue(0, out var _))
		{
			return;
		}
		PotentialEnergyData.LevelMap = new Dictionary<int, PotentialEnergyLevelDetail>();
		foreach (KeyValuePair<int, FUStPotentialEnergyConfigDesc> item in LevelMapedDesc)
		{
			PotentialEnergyData.LevelMap.Add(item.Key, new PotentialEnergyLevelDetail(item.Value.PELevelConfig, PreloadAssetMgr.TryGetCachedResourceObj<BGWDataAsset_B1DBC>(item.Value.PELevelConfig.DBCDAPath, ELoadResourceType.SyncLoadAndCache)));
		}
		bool flag = false;
		foreach (FUStPotentialEnergyConfigDesc value2 in LevelMapedDesc.Values)
		{
			if (!flag)
			{
				flag = value2.PELevelConfig.IsNomalMaxLevel == EGSYesNo.Yes;
				PotentialEnergyData.PELimit_ByChargeSkill = value2.PELevelConfig.LevelValue;
			}
			PotentialEnergyData.PELimit_Normal = value2.PELevelConfig.LevelValue;
		}
		if (base.BUSEventCollection != null)
		{
			float newValue = FMath.Max(PotentialEnergyData.PELimit_Normal, PotentialEnergyData.PELimit_ByChargeSkill);
			base.BUSEventCollection?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.PevalueMaxBase, newValue);
			base.BUSEventCollection?.Evt_OnPEConfigChange.Invoke();
		}
		if (AttrContainer.GetFloatValue(EBGUAttrFloat.Pevalue) > PotentialEnergyData.PELimit_Normal)
		{
			base.BUSEventCollection?.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.Pevalue, PotentialEnergyData.PELimit_Normal);
		}
		int curPELevel = PotentialEnergyData.GetCurPELevel(Owner);
		EnterNewLevel(curPELevel, 0, bFromPEConfigChange: true);
	}

	private void SwitchPEConfig(int LastIndex, int NewIndex)
	{
		if (LastIndex != NewIndex)
		{
			ResetPEConfig();
		}
	}

	private void ResetPEConfig()
	{
		int actorResID = GetActorResID();
		Dictionary<int, FUStPotentialEnergyConfigDesc> potentialEnergyConfigDesc = BGW_GameDB.GetPotentialEnergyConfigDesc(actorResID, Owner);
		if (potentialEnergyConfigDesc == null)
		{
			BGW_LogUtil.LogError("角色棍势配置异常，找不到任何可用棍势配置!!!!!!!!  ResID: " + actorResID + "!");
		}
		else
		{
			SetPEConfig(potentialEnergyConfigDesc);
		}
	}

	private void IncreaseChargeLevel()
	{
		if (ChargeSkillData.IsCastingChargeSkill)
		{
			base.BUSEventCollection?.Evt_OnIncreaseChargeLevel.Invoke(1);
		}
	}

	private void DecreaseChargeLevel()
	{
	}

	public void TriggeSkillComboGraph_LevelGrowUp()
	{
		AActor owner = GetOwner();
		if (!(owner == null) && !owner.IsPendingKill)
		{
			base.BUSEventCollection.Evt_TriggerChargeSkillNextStageEvent.Invoke(EChargeSkillEndEventType.PELevelGrowUp);
		}
	}

	public void TriggerBuff_PerLevelGrowUp(int Level_AfterGrowUp)
	{
		foreach (int item in PotentialEnergyData.LevelMap[Level_AfterGrowUp].BuffIDListLevelUp)
		{
			base.BUSEventCollection.Evt_BuffAdd.Invoke(item, Owner, Owner, 0f, EBuffSourceType.PotentialEnergy);
		}
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		if (DeadReason != EDeadReason.PlayerTrans)
		{
			ClearPEValue();
		}
	}
}
