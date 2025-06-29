using System;
using System.Collections.Generic;
using b1.ECS;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_BuffComp : UActorCompBaseCS
{
	private static float INV1000 = 0.001f;

	private BUC_BuffData BuffData;

	private IBUC_MasterData MasterData;

	private IBUC_ConfigInfoData ConfigInfoData;

	private IBUC_SimpleStateData SimpleStateData;

	private b1.IBUC_UnitDebugData UnitDebugData;

	private IBUC_GuidData GuidData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private IBGC_LevelBattleData LevelBattleData;

	public static Dictionary<EBuffAndSkillEffectCategory, EBGUSimpleState> BuffEffectCategoryImmuneSimpleStateDict = new Dictionary<EBuffAndSkillEffectCategory, EBGUSimpleState>
	{
		{
			EBuffAndSkillEffectCategory.Neutral,
			EBGUSimpleState.ImmuneNeutral
		},
		{
			EBuffAndSkillEffectCategory.Positive,
			EBGUSimpleState.ImmunePositive
		},
		{
			EBuffAndSkillEffectCategory.Negative,
			EBGUSimpleState.ImmuneNegative
		}
	};

	private bool HasAddBirthBuffInLifeTimeBegin;

	private List<int> BuffTickRuleBySimpleStateIDList = new List<int>();

	public override void OnAttach()
	{
		BuffData = RequireWritableData<BUC_BuffData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		LevelBattleData = RequireReadOnlyGameStateData<IBGC_LevelBattleData, BGC_LevelBattleData>();
		MasterData = RequireReadOnlyData<IBUC_MasterData, BUC_MasterData>();
		ConfigInfoData = RequireReadOnlyData<IBUC_ConfigInfoData, BUC_ConfigInfoData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		UnitDebugData = RequireReadOnlyData<b1.IBUC_UnitDebugData, BUC_UnitDebugData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		base.BUSEventCollection.Evt_BuffAdd += new Del_BuffAdd(BuffBegin);
		base.BUSEventCollection.Evt_BuffRemove += new Del_BuffRemove(BuffRemove);
		base.BUSEventCollection.Evt_BuffRemoveImmediately += new Del_BuffRemoveImmediately(BuffRemoveImmediately);
		base.BUSEventCollection.Evt_BuffAllRemove += new Del_BuffAllRemove(BuffAllRemove);
		base.BUSEventCollection.Evt_CopyBuffFromOtherUnit += new Del_CopyBuffFromOtherUnit(OnCopyBuffFromOtherUnit);
		base.BUSEventCollection.Evt_NotifyTriggerBuffWhenConditionMet += new Del_NotifyTriggerBuffWhenConditionMet(OnTriggerBuffWhenConditionMet);
		base.BUSEventCollection.Evt_NotifyRemoveBuffWhenConditionMet += new Del_NotifyRemoveBuffWhenConditionMet(OnRemoveBuffWhenConditionMet);
		base.BUSEventCollection.Evt_ResetActorStatusPre += new Del_Void_ResetActorReason(OnResetActorStatusPre);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_PauseUpdate += new Del_Void_Bool(OnPauseUpdate);
		base.BUSEventCollection.Evt_EnableCheckBuffGroup += new Del_EnableCheckBuffGroup(OnEnableCheckBuffGroup);
		base.BUSEventCollection.Evt_DisableCheckBuffGroup += new Del_DisableCheckBuffGroup(OnDisableCheckBuffGroup);
		base.BUSEventCollection.Evt_CacheFixFunctionReturnValue += new Del_Void_IntIntFloat(OnCacheFixFunctionReturnValue);
		base.BUSEventCollection.Evt_OnSkillEnd += new Del_Void_Int(OnSkillEnd);
		base.BUSEventCollection.Evt_UnitCastSkillSuccess += new Del_UnitCastSkillSuccess(OnUnitCastSkillSuccess);
		base.BUSEventCollection.Evt_UnitTriggerDead += new Del_UnitTriggerDead(OnUnitTriggerDead);
		base.BUSEventCollection.Evt_FilterBuffAdd += new Del_FilterBuffAndSkillEffect(FilterBuffAdd);
		base.BUSEventCollection.Evt_FilterBuffRemove += new Del_FilterBuffAndSkillEffect(FilterBuffRemove);
		base.BUSEventCollection.Evt_FilterSkillEffectAdd += new Del_FilterBuffAndSkillEffect(FilterSkillEffectAdd);
		base.BUSEventCollection.Evt_FilterSkillEffectRemove += new Del_FilterBuffAndSkillEffect(FilterSkillEffectRemove);
		base.BUSEventCollection.Evt_NotifyCanAddBuff += new Del_Void(OnNotifyCanAddBuff);
		base.BGSEventCollection.Evt_NotifyPossessEntityChanged += new Del_Void_EntityEntity(OnPossessEntityChanged);
		BuffData.BuffInstsDict.OnAdd += OnAdd;
		BindDictInt_BuffInstData buffInstsDict = BuffData.BuffInstsDict;
		buffInstsDict.OnRemove = (Action<int, BuffInstData>)Delegate.Combine(buffInstsDict.OnRemove, new Action<int, BuffInstData>(OnRemove));
		base.BUSEventCollection.Evt_UpdateBuffCaster += new Del_Void_ActorActorInt(UpdateBuffInstData_CasterChange);
		base.BUSEventCollection.Evt_PlayerRebirthAddBuff += new Del_Void(AddBirthBuff);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.OnEndPlay(EndPlayReason);
		base.BGSEventCollection.Evt_NotifyPossessEntityChanged -= new Del_Void_EntityEntity(OnPossessEntityChanged);
	}

	private void OnPossessEntityChanged(Entity OldEntity, Entity NewEntity)
	{
		if (Owner == ECSExtension.ToActor(OldEntity))
		{
			return;
		}
		foreach (BuffInstData allBuffInstDatum in BuffData.GetAllBuffInstData())
		{
			if (allBuffInstDatum.CasterRef == OldEntity)
			{
				allBuffInstDatum.CasterRef.Set(NewEntity);
			}
			if (allBuffInstDatum.RootCasterRef == OldEntity)
			{
				allBuffInstDatum.RootCasterRef.Set(NewEntity);
			}
		}
	}

	private void OnAdd(int BuffID, BuffInstData BuffInstData)
	{
		base.BUSEventCollection.Evt_BuffInstsDictOnAdd.Invoke(BuffID, BuffInstData.Duration, BuffInstData.BuffSourceType, EntitySharedRefFuncLib.Actor(BuffInstData.CasterRef));
	}

	private void OnRemove(int BuffID, BuffInstData BuffInstData)
	{
		base.BUSEventCollection.Evt_BuffInstsDictOnRemove.Invoke(BuffID);
	}

	public override void PreBeginPlay()
	{
		BuffData.bEnableBuffGroupCheck = true;
		BuffData.bCanAddBuff = true;
	}

	public override void OnBeginPlay()
	{
		HasAddBirthBuffInLifeTimeBegin = false;
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!HasAddBirthBuffInLifeTimeBegin)
		{
			HasAddBirthBuffInLifeTimeBegin = true;
			if (BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(GetOwner()))
			{
				InitBuff();
			}
		}
		UpdateBuffTime(DeltaTime);
	}

	private void OnPauseUpdate(bool bShouldPause)
	{
		BuffData.bShouldUpdateBuffTime = !bShouldPause;
		base.BUSEventCollection.Evt_ShouledUpdateBuffTime.Invoke(!bShouldPause);
	}

	private void OnResetActorStatusPre(EResetActorReason ResetReason)
	{
		OwnerAsCharacterCS.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
		UBGUFunctionLibraryForCS.CompForceUpdateOverlaps(OwnerAsCharacterCS.CapsuleComponent);
		BuffAllRemove(EBuffEffectTriggerType.None, WithTriggerRemoveEffect: false);
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		InitBuff();
		OwnerAsCharacterCS.CapsuleComponent.SetGenerateOverlapEvents(bInGenerateOverlapEvents: true);
		UBGUFunctionLibraryForCS.CompForceUpdateOverlaps(OwnerAsCharacterCS.CapsuleComponent);
	}

	private void InitBuff()
	{
		AddBirthBuff();
		SolveCPGCacheBuffEvent();
		SolveBossRushBuffEvent();
	}

	private void AddBirthBuff()
	{
		if (ConfigInfoData != null)
		{
			foreach (int birthBuff in ConfigInfoData.GetBirthBuffs())
			{
				BuffBegin(birthBuff, Owner, Owner, 0f, EBuffSourceType.Birth);
			}
		}
		if (!IsOnline() || !BGUFuncLibActorTransformCS.BGUGetActorHasAuthority(GetOwner()))
		{
			return;
		}
		int gameDifficultBuffId = LevelBattleData.GetGameDifficultBuffId();
		if (!BGUFunctionLibraryCS.BGUIsEnemyTeam(UnrealGameplayData.GetFirstLocalPlayerController()?.GetControlledPawn(), GetOwner()))
		{
			return;
		}
		int num = BuffData.GetBuffLayer(gameDifficultBuffId) + 1;
		if (num > LevelBattleData.GetGamePlayerNum())
		{
			BuffRemove(gameDifficultBuffId, EBuffEffectTriggerType.None, num - LevelBattleData.GetGamePlayerNum());
		}
		else if (num < LevelBattleData.GetGamePlayerNum())
		{
			for (int i = 0; i < LevelBattleData.GetGamePlayerNum() - num; i++)
			{
				BuffBegin(gameDifficultBuffId, Owner, Owner, -1f, EBuffSourceType.Birth);
			}
		}
	}

	private void SolveCPGCacheBuffEvent()
	{
		if (Owner as ACharacter == null)
		{
			return;
		}
		IBIC_TaskData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_TaskData, BIC_TaskData>(GetOwner());
		if (gameInstanceReadonlyData == null)
		{
			return;
		}
		string finalGuid = GuidData.GetFinalGuid();
		if (!gameInstanceReadonlyData.TryGetCacheNPCBuffEventInfoList(finalGuid, out var BuffEventInfoList))
		{
			return;
		}
		List<CacheCPGBuffEventInfo> list = new List<CacheCPGBuffEventInfo>();
		List<CacheCPGBuffEventInfo> list2 = new List<CacheCPGBuffEventInfo>();
		foreach (CacheCPGBuffEventInfo item in BuffEventInfoList)
		{
			if (item.IsAdd)
			{
				list.Add(item);
			}
			else
			{
				list2.Add(item);
			}
		}
		foreach (CacheCPGBuffEventInfo item2 in list2)
		{
			BuffRemove(item2.BuffID, EBuffEffectTriggerType.None, item2.BuffLayer, item2.bTriggerRemoveEffect);
		}
		foreach (CacheCPGBuffEventInfo item3 in list)
		{
			BuffBegin(item3.BuffID, Owner, Owner, item3.BuffDuration, EBuffSourceType.CPG);
		}
	}

	private void SolveBossRushBuffEvent()
	{
		IBIC_BossRushData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_BossRushData, BIC_BossRushData>(Owner);
		if ((gameInstanceReadonlyData == null || gameInstanceReadonlyData.BossRushType != EBossRushType.BossIterations) && gameInstanceReadonlyData.BossRushType != EBossRushType.IterationsPractise)
		{
			return;
		}
		EBRLimitTargetType targetType = ((Owner is BGUPlayerCharacterCS) ? EBRLimitTargetType.Player : EBRLimitTargetType.Monster);
		foreach (int debuff in gameInstanceReadonlyData.BossRushBattleData.DebuffList)
		{
			BossRushDebuffDesc bossRushDebuffDesc = GameDBRuntime.GetBossRushDebuffDesc(debuff);
			if (bossRushDebuffDesc == null)
			{
				continue;
			}
			List<int> bossRushBuffIDList = BGW_GameDB.GetBossRushBuffIDList(bossRushDebuffDesc.DebuffId, targetType);
			if (bossRushBuffIDList == null)
			{
				continue;
			}
			foreach (int item in bossRushBuffIDList)
			{
				BuffBegin(item, Owner, Owner, 0f, EBuffSourceType.BossRushDebuff);
			}
		}
	}

	private void UpdateBuffTime(float DeltaTime)
	{
		float timeSeconds = UnrealGameplayData.GetTimeSeconds();
		bool flag = false;
		BuffData.BuffInstsDict.BeginItr();
		while (true)
		{
			BuffData.BuffInstsDict.NextItr(out var output);
			if (output == null)
			{
				break;
			}
			if (!BuffData.bShouldUpdateBuffTime)
			{
				continue;
			}
			output.ReliabilityUpdate(timeSeconds);
			if (output.bNeedRemove_Over3Min(timeSeconds))
			{
				BuffRemoveImmediately(output.BuffID, EBuffEffectTriggerType.None, WithTriggerRemoveEffect: true);
				BGW_LogUtil.LogError($"请反馈给OCEAN: BuffID [ {output.BuffID} ],Entity.Actor()销毁后150秒 该Buff还在运作,目前处理方式是强行Remove");
				continue;
			}
			if (!flag)
			{
				flag = true;
				BGUFunctionLibraryCS.GetBuffTickRuleBySimpleStateIDList(Owner, ref BuffTickRuleBySimpleStateIDList);
			}
			if (BGUFunctionLibraryCS.IsNeedPauseBuffTick(output.BuffID, BuffTickRuleBySimpleStateIDList))
			{
				continue;
			}
			if (output.bActive)
			{
				if (output.DelayTime > 0f)
				{
					output.DelayTime -= DeltaTime;
					if (output.DelayTime <= 0f)
					{
						FEffectInstReq EffectInstReq = new FEffectInstReq(EntitySharedRefFuncLib.Actor(output.RootCasterRef));
						TriggerEffect(output.BuffID, EBuffEffectTriggerType.Generation, ref EffectInstReq, EntitySharedRefFuncLib.Actor(output.RootCasterRef));
						TriggerEffect(output.BuffID, EBuffEffectTriggerType.Time, ref EffectInstReq, EntitySharedRefFuncLib.Actor(output.RootCasterRef));
						TriggerEffect(output.BuffID, EBuffEffectTriggerType.LayerMax, ref EffectInstReq, EntitySharedRefFuncLib.Actor(output.RootCasterRef));
						IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(output.RootCasterRef));
						BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(output.BuffID, readOnlyData);
						output.UpdateTimer = (float)(-buffDescRuntime.GetInterval()) * INV1000;
					}
				}
				else
				{
					output.UpdateTimer += DeltaTime;
					IBUC_PassiveSkillData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(output.RootCasterRef));
					float num = BGW_GameDB.GetBuffDescRuntime(output.BuffID, readOnlyData2).GetInterval();
					if (output.UpdateTimer >= num * INV1000)
					{
						output.UpdateTimer -= num * INV1000;
						FEffectInstReq EffectInstReq2 = new FEffectInstReq(EntitySharedRefFuncLib.Actor(output.RootCasterRef));
						TriggerEffect(output.BuffID, EBuffEffectTriggerType.Time, ref EffectInstReq2, EntitySharedRefFuncLib.Actor(output.RootCasterRef), bIsPeriodical: true);
					}
				}
				if (!(output.LeftTime > 0f))
				{
					continue;
				}
				output.LeftTime -= DeltaTime;
				if (output.LeftTime <= 0f)
				{
					BuffRemove(output.BuffID, EBuffEffectTriggerType.None, 1);
				}
				else if (output.AlmostEndAheadTime > 0f && !output.bHasTriggerAlmostEndLogic)
				{
					output.AlmostEndAheadTime -= DeltaTime;
					if (output.AlmostEndAheadTime <= 0f)
					{
						output.bHasTriggerAlmostEndLogic = true;
						NotifyBuffAlmostEnd(output.BuffID, output.RootCasterRef);
					}
				}
			}
			else
			{
				BuffData.BuffInstsDict.Remove(output.BuffID);
			}
		}
	}

	private void FilterBuffAdd(int BuffID, int FilterID)
	{
		if (BuffData.FilterBuffInstsDict.ContainsKey(BuffID))
		{
			BuffData.FilterBuffInstsDict[BuffID].Add(FilterID);
		}
		else
		{
			BuffData.FilterBuffInstsDict.Add(BuffID, new List<int>(FilterID));
		}
	}

	private void FilterBuffRemove(int BuffID, int FilterID)
	{
		if (BuffData.FilterBuffInstsDict.ContainsKey(BuffID))
		{
			BuffData.FilterBuffInstsDict[BuffID].Remove(FilterID);
			if (BuffData.FilterBuffInstsDict[BuffID].Count <= 0)
			{
				BuffData.FilterBuffInstsDict.Remove(BuffID);
			}
		}
	}

	private void FilterSkillEffectAdd(int BuffID, int FilterID)
	{
		if (BuffData.FilterSkillEffectInstsDict.ContainsKey(BuffID))
		{
			BuffData.FilterSkillEffectInstsDict[BuffID].Add(FilterID);
			return;
		}
		BuffData.FilterSkillEffectInstsDict.Add(BuffID, new List<int>());
		BuffData.FilterSkillEffectInstsDict[BuffID].Add(FilterID);
	}

	private void FilterSkillEffectRemove(int BuffID, int FilterID)
	{
		if (BuffData.FilterSkillEffectInstsDict.ContainsKey(BuffID))
		{
			BuffData.FilterSkillEffectInstsDict[BuffID].Remove(FilterID);
			if (BuffData.FilterSkillEffectInstsDict[BuffID].Count <= 0)
			{
				BuffData.FilterSkillEffectInstsDict.Remove(BuffID);
			}
		}
	}

	private void BuffBegin(int BuffID, AActor Caster, AActor RootCaster, float Duration, EBuffSourceType BuffSourceType = EBuffSourceType.Default, bool bRecursed = false, FBattleAttrSnapShot BattleAttrSnapShot = default(FBattleAttrSnapShot))
	{
		if (!(RootCaster is IECSWorldObj) || !this.BuffData.bCanAddBuff)
		{
			return;
		}
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(RootCaster);
		BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(BuffID, readOnlyData);
		if (buffDescRuntime == null)
		{
			return;
		}
		DoBuffRuleLogic(BuffID, Caster, RootCaster, out var BuffCanAdd);
		if (!BuffCanAdd || !CheckBuffNotImmune(BuffID))
		{
			return;
		}
		BuffInstData BuffData;
		bool buffInstData = this.BuffData.GetBuffInstData(BuffID, out BuffData);
		if (buffInstData && buffDescRuntime.GetIsExclusiveBuff())
		{
			return;
		}
		this.BuffData.GetAllFilterBuffID(out var OutFilterIDs);
		if (OutFilterIDs.Contains(BuffID))
		{
			return;
		}
		FEffectInstReq EffectInstReq = new FEffectInstReq(RootCaster);
		int effectsCount = buffDescRuntime.GetEffectsCount();
		float FinalOutBuffDuration = Duration;
		if (buffInstData)
		{
			int maxLayer = buffDescRuntime.GetMaxLayer();
			if (maxLayer < 0 || BuffData.Layer + 1 <= maxLayer)
			{
				this.BuffData.AddBuff(BuffID, 1, Caster, RootCaster, Owner, Duration, effectsCount, BuffSourceType, out FinalOutBuffDuration, BattleAttrSnapShot);
				if (buffDescRuntime.GetDelay() == 0)
				{
					TriggerEffect(BuffID, EBuffEffectTriggerType.Generation, ref EffectInstReq, EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
					TriggerEffect(BuffID, EBuffEffectTriggerType.Time, ref EffectInstReq, EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
				}
			}
			else
			{
				this.BuffData.AddBuff(BuffID, 1, Caster, RootCaster, Owner, Duration, effectsCount, BuffSourceType, out FinalOutBuffDuration, BattleAttrSnapShot);
			}
			if (BuffData.Layer == maxLayer && buffDescRuntime.GetDelay() == 0)
			{
				TriggerEffect(BuffID, EBuffEffectTriggerType.LayerMax, ref EffectInstReq, EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
			}
		}
		else
		{
			this.BuffData.AddBuff(BuffID, 1, Caster, RootCaster, Owner, Duration, effectsCount, BuffSourceType, out FinalOutBuffDuration, BattleAttrSnapShot);
			if (buffDescRuntime.GetDelay() == 0)
			{
				TriggerEffect(BuffID, EBuffEffectTriggerType.Generation, ref EffectInstReq, RootCaster);
				TriggerEffect(BuffID, EBuffEffectTriggerType.Time, ref EffectInstReq, RootCaster);
				if (buffDescRuntime.GetMaxLayer() == 1)
				{
					TriggerEffect(BuffID, EBuffEffectTriggerType.LayerMax, ref EffectInstReq, RootCaster);
				}
			}
		}
		if (!bRecursed && this.BuffData.bEnableBuffGroupCheck)
		{
			foreach (BuffGroupInstData value in this.BuffData.BuffGroupInstsDict.Values)
			{
				if (BGW_GameDB.DoesBuffBelongToBuffGroup(BuffID, value.BuffGroupID))
				{
					int ActiveBuffCount = 0;
					if (BGUFunctionLibraryCS.BGUGetTotalBuffLayersFromBuffGroup(GetOwner(), value.BuffGroupID, ref ActiveBuffCount) >= value.TotalLayerCount && ActiveBuffCount >= value.RequiredActiveBuffCount)
					{
						BuffBegin(value.AddBuffID, Caster, RootCaster, 0f, BuffSourceType, bRecursed: true);
					}
				}
			}
		}
		BuffInstData BuffData2 = null;
		this.BuffData.GetBuffInstData(BuffID, out BuffData2);
		NotifyAddBuff(BuffID, Caster, buffInstData, Duration, BuffData2);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = "";
			int effectsCount2 = buffDescRuntime.GetEffectsCount();
			for (int i = 0; i < effectsCount2; i++)
			{
				string text2 = buffDescRuntime.GetEffectType(i).ToString();
				if (i < effectsCount2 - 1)
				{
					text2 += "、";
				}
				text += text2;
			}
			string text3 = ((FinalOutBuffDuration > 0f) ? $"{FinalOutBuffDuration:0.00}秒" : "永久Buff");
			BGUFunctionLibraryCS.LogBattleInfo(GetOwner(), EBattleInfoType.AddBuff, (text == "") ? $"<character>{RootCaster.GetName()}</><action>给</><bechosed>{GetOwner().GetName()}</><action>添加buff效果</><effectnum>{BuffID}</><action>，持续时间：</><damage>{text3}</>" : $"<character>{RootCaster.GetName()}</><action>给</><bechosed>{GetOwner().GetName()}</><action>添加buff效果</><effectnum>{BuffID}</><action>，持续时间：</><damage>{text3}</><action>，包含以下效果：</><effect>{text}</>");
		}
		base.BUSEventCollection.Evt_BuffUpdated.Invoke(BuffID);
	}

	private void BuffRemove(int BuffID, EBuffEffectTriggerType RemoveTriggerType, int InLayer, bool WithTriggerRemoveEffect = true)
	{
		if (!this.BuffData.GetBuffInstData(BuffID, out var BuffData))
		{
			return;
		}
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
		BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(BuffID, readOnlyData);
		if (buffDescRuntime == null)
		{
			return;
		}
		int num = InLayer;
		int buffLayer = this.BuffData.GetBuffLayer(BuffID);
		if (buffDescRuntime.GetBuffLayerCounterType() == EGSBuffLayerCounterType.RemoveDirectly)
		{
			num = buffLayer;
		}
		if (num > 0 && buffLayer > num)
		{
			if (WithTriggerRemoveEffect)
			{
				BuffEndLayer(BuffID, num);
			}
			this.BuffData.RemoveBuff(Owner, BuffID, num);
			return;
		}
		BuffEnd(BuffID, RemoveTriggerType, num, WithTriggerRemoveEffect);
		NotifyRemoveBuff(BuffID, BuffData.RootCasterRef);
		this.BuffData.RemoveBuff(Owner, BuffID, num);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(GetOwner(), EBattleInfoType.RemoveBuff, $"<character>{GetOwner().GetName()}</><action>移除buff效果</><effectnum>{BuffID}</>");
		}
	}

	private void BuffRemoveImmediately(int BuffID, EBuffEffectTriggerType RemoveTriggerType, bool WithTriggerRemoveEffect)
	{
		BuffRemove(BuffID, RemoveTriggerType, -1, WithTriggerRemoveEffect);
	}

	private void BuffAllRemove(EBuffEffectTriggerType RemoveTriggerType, bool WithTriggerRemoveEffect)
	{
		List<int> list = new List<int>();
		foreach (int key in BuffData.BuffInstsDict.Keys)
		{
			list.Add(key);
		}
		foreach (int item in list)
		{
			BuffRemoveImmediately(item, RemoveTriggerType, WithTriggerRemoveEffect);
		}
	}

	private void OnCopyBuffFromOtherUnit(AActor OtherUnit, bool NeedCleanCurrent)
	{
		if (!(OtherUnit == null) && !OtherUnit.IsPendingKill)
		{
			BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(OtherUnit);
			BuffData.CopyBuff(readOnlyData.GetAllBuffInstData(), NeedCleanCurrent);
		}
	}

	private void OnTriggerBuffWhenConditionMet(EBuffEffectTriggerType TriggerType, in FEffectInstReq InEffectInstReq, AActor Victim)
	{
		if (TriggerType == EBuffEffectTriggerType.SkillCostOnceDmg && !BuffData.CostDmgInSkill_BuffHandler.CanTrigger(InEffectInstReq.TriggerSkillId))
		{
			return;
		}
		FEffectInstReq EffectInstReq = new FEffectInstReq
		{
			Attacker = InEffectInstReq.Attacker
		};
		List<int> list = new List<int>();
		foreach (int key in BuffData.BuffInstsDict.Keys)
		{
			list.Add(key);
		}
		foreach (int item in list)
		{
			if (!BuffData.BuffInstsDict.TryGetValue(item, out var OutValue))
			{
				continue;
			}
			if (OutValue != null && OutValue.bActive)
			{
				IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(OutValue.RootCasterRef));
				if (BGW_GameDB.GetBuffDescRuntime(OutValue.BuffID, readOnlyData) == null)
				{
					continue;
				}
				switch (TriggerType)
				{
				case EBuffEffectTriggerType.BeAttacked:
				case EBuffEffectTriggerType.OnCriticalHit:
				case EBuffEffectTriggerType.OnKillUnit:
				case EBuffEffectTriggerType.SkillCostOnceDmg:
				case EBuffEffectTriggerType.OnShieldBreak:
					TriggerEffectWithOutDefaultEffReq(OutValue.BuffID, TriggerType, in InEffectInstReq, EntitySharedRefFuncLib.Actor(OutValue.RootCasterRef));
					break;
				case EBuffEffectTriggerType.OnSkillBreak:
				case EBuffEffectTriggerType.IntoChargeEnd:
					TriggerEffect(OutValue.BuffID, TriggerType, ref EffectInstReq, EntitySharedRefFuncLib.Actor(OutValue.RootCasterRef));
					break;
				case EBuffEffectTriggerType.OnSkillDamage:
				case EBuffEffectTriggerType.BeHurted:
				case EBuffEffectTriggerType.BeHurtedNoneElem:
				case EBuffEffectTriggerType.BeHurtedFreeze:
				case EBuffEffectTriggerType.BeHurtedBurn:
				case EBuffEffectTriggerType.BeHurtedPoison:
				case EBuffEffectTriggerType.BeHurtedThunder:
				case EBuffEffectTriggerType.BeHurtedYin:
				case EBuffEffectTriggerType.BeHurtedYang:
					if (InEffectInstReq.TriggerSkillId != 0)
					{
						TriggerEffectWithOutDefaultEffReq(OutValue.BuffID, TriggerType, in InEffectInstReq, EntitySharedRefFuncLib.Actor(OutValue.RootCasterRef), bIsPeriodical: false, Victim);
					}
					else
					{
						TriggerEffect(OutValue.BuffID, TriggerType, ref EffectInstReq, EntitySharedRefFuncLib.Actor(OutValue.RootCasterRef), bIsPeriodical: false, Victim);
					}
					break;
				}
			}
			else
			{
				BuffData.BuffInstsDict.Remove(item);
			}
		}
	}

	private void OnRemoveBuffWhenConditionMet(bool bAttackedOrAttackHit)
	{
		List<int> list = new List<int>();
		foreach (int key in BuffData.BuffInstsDict.Keys)
		{
			list.Add(key);
		}
		foreach (int item in list)
		{
			if (!BuffData.BuffInstsDict.TryGetValue(item, out var OutValue))
			{
				continue;
			}
			if (OutValue == null)
			{
				break;
			}
			if (OutValue.bActive)
			{
				IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(OutValue.RootCasterRef));
				BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(OutValue.BuffID, readOnlyData);
				if (buffDescRuntime != null && (bAttackedOrAttackHit ? buffDescRuntime.GetCanRemoveWhenAttacked() : buffDescRuntime.GetCanRemoveWhenAttackHit()))
				{
					BuffRemove(OutValue.BuffID, EBuffEffectTriggerType.None, 1);
				}
			}
			else
			{
				BuffData.BuffInstsDict.Remove(OutValue.BuffID);
			}
		}
	}

	private void NotifyAddBuff(int BuffID, AActor Caster, bool IsHasBuffBefore, float BuffDuration, BuffInstData BuffInstData)
	{
		base.BUSEventCollection.Evt_AddBuffNotify.Invoke(IsHasBuffBefore, Caster, BuffID, BuffDuration);
	}

	private void NotifyBuffAlmostEnd(int BuffID, EntitySharedRef RootCasterRef)
	{
		int actorResID = BGU_DataUtil.GetActorResID(RootCasterRef);
		base.BUSEventCollection.Evt_TriggerBuffAlmostEndFX.Invoke(BuffID, actorResID);
	}

	private AActor GetBuffEffectTargetBase(int BuffID, BuffDescRuntime BuffDesc, EBuffEffectTriggerType TriggerType, AActor CheckTarget)
	{
		if (BuffDesc == null)
		{
			return null;
		}
		if (!BGUFunctionLibraryCS.BGUCheckBuffEffectActiveCondition(BuffID, bIsBuff: true, GetOwner(), BuffDesc.GetActiveConditionType(), BuffDesc.GetSplittedActiveConditionParams(), CheckTarget))
		{
			return null;
		}
		if (!this.BuffData.GetBuffInstData(BuffID, out var BuffData))
		{
			return null;
		}
		if (TriggerType == EBuffEffectTriggerType.Remove)
		{
			if (BuffData.BuffEndTriggerByRemove)
			{
				return null;
			}
			BuffData.BuffEndTriggerByRemove = true;
		}
		if (TriggerType == EBuffEffectTriggerType.Dead)
		{
			if (BuffData.BuffEndTriggerByDead)
			{
				return null;
			}
			BuffData.BuffEndTriggerByDead = true;
		}
		AActor aActor = null;
		switch (BuffDesc.GetTargetBase())
		{
		case EBuffRangeTargetBase.RootCaster:
			aActor = EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef);
			break;
		case EBuffRangeTargetBase.Caster:
			aActor = EntitySharedRefFuncLib.Actor(BuffData.CasterRef);
			break;
		case EBuffRangeTargetBase.Owner:
			aActor = GetOwner();
			break;
		}
		if (aActor.IsNullOrDestroyed())
		{
			return null;
		}
		return aActor;
	}

	private void TriggerEffect(int BuffID, EBuffEffectTriggerType TriggerType, ref FEffectInstReq EffectInstReq, AActor RootCaster, bool bIsPeriodical = false, AActor Victim = null)
	{
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(RootCaster);
		BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(BuffID, readOnlyData);
		if (buffDescRuntime != null)
		{
			AActor buffEffectTargetBase = GetBuffEffectTargetBase(BuffID, buffDescRuntime, TriggerType, Victim);
			if (!(buffEffectTargetBase == null))
			{
				EffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(buffEffectTargetBase);
				EffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(buffEffectTargetBase);
				EffectInstReq.HitActionDir = EHitActionDir.Default;
				TriggerEffect(BuffID, TriggerType, EffectInstReq, buffEffectTargetBase, RootCaster, bIsPeriodical);
			}
		}
	}

	private void TriggerEffectWithOutDefaultEffReq(int BuffID, EBuffEffectTriggerType TriggerType, in FEffectInstReq EffectInstReq, AActor RootCaster, bool bIsPeriodical = false, AActor Victim = null)
	{
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(RootCaster);
		BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(BuffID, readOnlyData);
		if (buffDescRuntime != null)
		{
			AActor buffEffectTargetBase = GetBuffEffectTargetBase(BuffID, buffDescRuntime, TriggerType, Victim);
			if (!(buffEffectTargetBase == null))
			{
				TriggerEffect(BuffID, TriggerType, EffectInstReq, buffEffectTargetBase, RootCaster, bIsPeriodical);
			}
		}
	}

	private void TriggerEffect(int BuffID, EBuffEffectTriggerType TriggerType, FEffectInstReq EffectInstReq, AActor TargetBase, AActor RootCaster, bool bIsPeriodical = false)
	{
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(RootCaster);
		BuffDescRuntime BuffDesc = BGW_GameDB.GetBuffDescRuntime(BuffID, readOnlyData);
		if (BuffDesc == null || TargetBase == null || !this.BuffData.GetBuffInstData(BuffID, out var BuffData))
		{
			return;
		}
		int effectsCount = BuffDesc.GetEffectsCount();
		for (int i = 0; i < effectsCount; i++)
		{
			if (BuffDesc.GetEffectTriggerType(i) != TriggerType)
			{
				continue;
			}
			EBuffAndSkillEffectType effectType = BuffDesc.GetEffectType(i);
			BGW_EffectTemplateList.Get(GetOwner()).EffectTemplatesCS.TryGetValue(effectType, out var value);
			if (value == null)
			{
				continue;
			}
			EBuffEffectTargetSelectType effectTargetSelectType = BuffDesc.GetEffectTargetSelectType(i);
			foreach (AActor item in BGU_B1TargetFuncs.BuffSelectRangeTarget(GetOwner(), TargetBase, in BuffDesc, in EffectInstReq, effectTargetSelectType))
			{
				EffectInstReq.HitPartID = 0;
				base.BUSEventCollection.Evt_TriggerSkillEffectByBuff.Invoke(BuffID, item, i, EffectInstReq, bIsPeriodical);
				BuffData.AddEffectTarget(i, item);
			}
			if (BuffDesc.GetRangeType() == ERangeType.TargetBaseObj)
			{
				continue;
			}
			bool flag = false;
			AActor masterActor = MasterData.GetMasterActor();
			if (masterActor == null)
			{
				if (UnitDebugData != null && UnitDebugData.DrawBuffArea)
				{
					flag = true;
				}
			}
			else
			{
				b1.IBUC_UnitDebugData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_UnitDebugData>(masterActor);
				if (readOnlyData2 != null && readOnlyData2.DrawBuffArea)
				{
					flag = true;
				}
			}
			if (flag)
			{
				DrawBuffArea(TargetBase, BuffDesc);
			}
		}
	}

	private void BuffEndLayer(int BuffID, int Layer)
	{
		TriggerEffectRemoveByBuff(BuffID, Layer);
	}

	private void BuffEnd(int BuffID, EBuffEffectTriggerType RemoveTriggerType, int Layer, bool WithTriggerRemoveEffect)
	{
		this.BuffData.GetBuffInstData(BuffID, out var BuffData);
		if (BuffData == null)
		{
			BGW_LogUtil.LogError($"BuffEnd {BuffID} BuffInstData == null");
			return;
		}
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
		if (BGW_GameDB.GetBuffDescRuntime(BuffID, readOnlyData) != null)
		{
			FEffectInstReq EffectInstReq = new FEffectInstReq(EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
			if (WithTriggerRemoveEffect)
			{
				TriggerEffect(BuffID, EBuffEffectTriggerType.Remove, ref EffectInstReq, EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
			}
			if (RemoveTriggerType == EBuffEffectTriggerType.Dead)
			{
				TriggerEffect(BuffID, EBuffEffectTriggerType.Dead, ref EffectInstReq, EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
			}
			TriggerEffectRemoveByBuff(BuffID, Layer);
		}
	}

	private void TriggerEffectRemoveByBuff(int BuffID, int Layer)
	{
		if (!this.BuffData.GetBuffInstData(BuffID, out var BuffData) || GetOwner() == null)
		{
			return;
		}
		IBUC_PassiveSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
		BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(BuffID, readOnlyData);
		if (buffDescRuntime == null)
		{
			return;
		}
		Layer = ((Layer > 0) ? Layer : BuffData.Layer);
		if (BuffData.HasTriggerAllRemoveByBuff)
		{
			return;
		}
		if (BuffData.Layer <= Layer)
		{
			BuffData.HasTriggerAllRemoveByBuff = true;
		}
		int effectsCount = buffDescRuntime.GetEffectsCount();
		for (int i = 0; i < effectsCount; i++)
		{
			EBuffAndSkillEffectType effectType = buffDescRuntime.GetEffectType(i);
			BGW_EffectTemplateList.Get(GetOwner()).EffectTemplatesCS.TryGetValue(effectType, out var value);
			if (value == null || !BuffData.EffectTargetDic.TryGetValue(i, out var value2))
			{
				continue;
			}
			int num = ((Layer < BuffData.Layer) ? Layer : BuffData.Layer);
			EntitySharedRef[] array = new EntitySharedRef[value2.Keys.Count];
			value2.Keys.CopyTo(array, 0);
			EntitySharedRef[] array2 = array;
			foreach (EntitySharedRef entitySharedRef in array2)
			{
				int num2 = value2[entitySharedRef];
				if (num2 > 0)
				{
					AActor aActor = EntitySharedRefFuncLib.Actor(entitySharedRef);
					if (!aActor.IsNullOrDestroyed())
					{
						value.RemoveByBuff(BuffData, aActor, i, num);
					}
					value2[entitySharedRef] = num2 - num;
				}
			}
			BuffData.EffectTargetDic[i] = value2;
		}
	}

	private void NotifyRemoveBuff(int BuffID, EntitySharedRef RootCasterRef)
	{
		int actorResID = BGU_DataUtil.GetActorResID(RootCasterRef);
		base.BUSEventCollection.Evt_RemoveBuffNotify.Invoke(BuffID, actorResID);
	}

	private void DrawBuffArea(AActor TargetBase, BuffDescRuntime BuffDesc)
	{
		if (TargetBase == null)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetBase);
		fVector.Z = 10f;
		FVector actorForwardVector = TargetBase.GetActorForwardVector();
		ERangeType rangeType = BuffDesc.GetRangeType();
		int rangeParamCount = BuffDesc.GetRangeParamCount();
		switch (rangeType)
		{
		case ERangeType.Circle:
			if (rangeParamCount >= 1)
			{
				int rangeParam = BuffDesc.GetRangeParam(0);
				if (rangeParam > 0)
				{
					UBGUFunctionLibraryForCS.BGUDrawDebugCircle(GetOwner().World, fVector, rangeParam);
				}
			}
			break;
		case ERangeType.Rect:
			if (rangeParamCount >= 2)
			{
				int rangeParam = BuffDesc.GetRangeParam(0);
				int rangeParam2 = BuffDesc.GetRangeParam(1);
				if (rangeParam > 0 && rangeParam2 > 0)
				{
					UBGUFunctionLibraryForCS.BGUDrawDebugRect(GetOwner().World, fVector, actorForwardVector, rangeParam, rangeParam2);
				}
			}
			break;
		case ERangeType.ForwardRect:
			if (rangeParamCount >= 2)
			{
				int rangeParam = BuffDesc.GetRangeParam(0);
				int rangeParam2 = BuffDesc.GetRangeParam(1);
				if (rangeParam > 0 && rangeParam2 > 0)
				{
					UBGUFunctionLibraryForCS.BGUDrawDebugRect(GetOwner().World, fVector + actorForwardVector * rangeParam2 / 2.0, actorForwardVector, rangeParam, rangeParam2);
				}
			}
			break;
		case ERangeType.Ring:
			if (rangeParamCount >= 4)
			{
				int rangeParam = BuffDesc.GetRangeParam(0);
				int rangeParam2 = BuffDesc.GetRangeParam(1);
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(GetOwner().World, fVector, rangeParam);
				UBGUFunctionLibraryForCS.BGUDrawDebugCircle(GetOwner().World, fVector, rangeParam2);
			}
			break;
		case ERangeType.Cylinder:
		case ERangeType.Sphere:
		case ERangeType.Sector:
			break;
		}
	}

	private void DoBuffRuleLogic(int CurAddBuffID, AActor CurCaster, AActor RootCaster, out bool BuffCanAdd)
	{
		BuffCanAdd = true;
		Dictionary<EBuffRuleType, List<BGW_GameDB.BuffRuleInfo>> buffRuleDic = BGW_GameDB.GetBuffRuleDic(CurAddBuffID);
		if (buffRuleDic == null)
		{
			return;
		}
		List<BuffInstData> allBuffInstData = BuffData.GetAllBuffInstData();
		if (buffRuleDic.TryGetValue(EBuffRuleType.BrExclude, out var value))
		{
			foreach (BuffInstData item in allBuffInstData)
			{
				foreach (BGW_GameDB.BuffRuleInfo item2 in value)
				{
					if (item2.RelationalBuffIDList.Contains(item.BuffID))
					{
						BuffCanAdd = false;
						return;
					}
				}
			}
		}
		if (buffRuleDic.TryGetValue(EBuffRuleType.BrReplace, out var value2))
		{
			foreach (BuffInstData item3 in allBuffInstData)
			{
				foreach (BGW_GameDB.BuffRuleInfo item4 in value2)
				{
					if (item4.RelationalBuffIDList.Contains(item3.BuffID))
					{
						BuffRemove(item3.BuffID, EBuffEffectTriggerType.None, item3.Layer, item4.WithTriggerRemoveEffect);
					}
				}
			}
		}
		if (!buffRuleDic.TryGetValue(EBuffRuleType.BrCompose, out var value3))
		{
			return;
		}
		foreach (BuffInstData item5 in allBuffInstData)
		{
			foreach (BGW_GameDB.BuffRuleInfo item6 in value3)
			{
				if (!item6.RelationalBuffIDList.Contains(item5.BuffID))
				{
					continue;
				}
				if (!item6.ComposedKeepOldBuff)
				{
					BuffRemove(item5.BuffID, EBuffEffectTriggerType.None, item5.Layer, item6.WithTriggerRemoveEffect);
				}
				BuffCanAdd = false;
				foreach (int composedBuffID in item6.ComposedBuffIDList)
				{
					BuffBegin(composedBuffID, CurCaster, RootCaster, 0f, EBuffSourceType.BuffRule);
				}
			}
		}
	}

	public static EBuffAndSkillEffectCategory GetBuffCategory(int BuffID)
	{
		if (BGW_GameDB.GetAllBuffDesc().TryGetValue(BuffID, out var value))
		{
			return value.BuffCategory;
		}
		return EBuffAndSkillEffectCategory.Neutral;
	}

	private bool CheckBuffNotImmune(int BuffID)
	{
		if (BuffEffectCategoryImmuneSimpleStateDict.TryGetValue(GetBuffCategory(BuffID), out var value))
		{
			if (SimpleStateData == null)
			{
				return true;
			}
			return !SimpleStateData.HasSimpleState(value);
		}
		return true;
	}

	private void OnEnableCheckBuffGroup(int BuffGroupID, int TotalLayerCount, int RequiredActiveBuffCount, int AddBuffID)
	{
		if (!BuffData.BuffGroupInstsDict.TryGetValue(BuffGroupID, out var value))
		{
			value = default(BuffGroupInstData);
			BuffData.BuffGroupInstsDict.Add(BuffGroupID, value);
		}
		value.BuffGroupID = BuffGroupID;
		value.TotalLayerCount = TotalLayerCount;
		value.RequiredActiveBuffCount = RequiredActiveBuffCount;
		value.AddBuffID = AddBuffID;
		BuffData.bEnableBuffGroupCheck = true;
		BuffData.BuffGroupInstsDict[BuffGroupID] = value;
	}

	private void OnDisableCheckBuffGroup(int BuffGroupID)
	{
		BuffData.BuffGroupInstsDict.Remove(BuffGroupID);
		if (BuffData.BuffGroupInstsDict.Count == 0)
		{
			BuffData.bEnableBuffGroupCheck = false;
		}
	}

	private void OnCacheFixFunctionReturnValue(int BuffID, int EffectIdx, float Value)
	{
		this.BuffData.GetBuffInstData(BuffID, out var BuffData);
		BuffData.CachedFixFunctionReturnValues[EffectIdx] = Value;
	}

	private void OnUnitCastSkillSuccess(int MappingSkillID, int OriSkillID, ECastSkillSourceType SourceType)
	{
		BuffData.CostDmgInSkill_BuffHandler.OnSkillStart(MappingSkillID);
	}

	private void OnSkillEnd(int SKillID)
	{
		BuffData.CostDmgInSkill_BuffHandler.OnSkillEnd();
	}

	private void OnUnitTriggerDead(AActor Attacker, EDeadReason DeadReason, int DmgID)
	{
		BuffData.bCanAddBuff = false;
	}

	private void OnNotifyCanAddBuff()
	{
		BuffData.bCanAddBuff = true;
		if (GetOwner() as BGUPlayerCharacterCS != null)
		{
			AddBirthBuff();
		}
	}

	private void UpdateBuffInstData_CasterChange(AActor Caster, AActor RootCaster, int BuffID)
	{
		if (this.BuffData.GetBuffInstData(BuffID, out var BuffData))
		{
			BuffData.CasterRef = new EntitySharedRef(Caster);
			BuffData.RootCasterRef = new EntitySharedRef(RootCaster);
			BuffData.Caster_AttrMemData = new FBattleAttrSnapShot(RootCaster);
		}
	}
}
