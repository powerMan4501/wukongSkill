using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.BGW;
using b1.EventDelDefine;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_ArmorCompImpl : UActorCompBaseCS
{
	private BUC_ArmorData ArmorData;

	private IBUC_SimpleStateData SimpStateData;

	private IBUC_UnitStateData UnitStateData;

	private IBUC_AttrContainer AttrContainer;

	private IBUC_ActionRequestData ActionRequestData;

	private int CacheMontageInstanceID = -1;

	private int CacheNotifyUniqueID = 1;

	public override void OnAttach()
	{
		ArmorData = RequireWritableData<BUC_ArmorData>();
		SimpStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		AttrContainer = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		ActionRequestData = RequireReadOnlyData<IBUC_ActionRequestData, BUC_ActionRequestData>();
		base.BUSEventCollection.Evt_ResetActorStatus += new Del_Void_ResetActorReason(OnResetActorStatus);
		base.BUSEventCollection.Evt_ResetActorStatusAfterAll += new Del_Void_ResetActorReason(OnResetActorStatusAfterAll);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
		base.BUSEventCollection.Evt_AddCounterAttackTimes += new Del_Void(OnAddCounterAttackTimes);
		base.BUSEventCollection.Evt_TriggerCounterAttack += new Del_Void_Bool(OnTriggerCounterAttack);
		base.BUSEventCollection.Evt_CastSkillToBreakHitRecover += new Del_Void(CastSkillToBreakHitRecover);
		base.BUSEventCollection.Evt_ResetCounterAttack += new Del_Void(OnResetCounterAttack);
		base.BUSEventCollection.Evt_CounterAttackSuperArmor += new Del_Void(OnTriggerPreHRCounterattackingSuperArmor);
		base.BUSEventCollection.Evt_TriggerBlock += new Del_TriggerBlock(OnTriggerBlock);
		base.BUSEventCollection.Evt_ResetBlockInfo += new Del_Void(OnResetBlockTimeCounting);
		base.BUSEventCollection.Evt_SetNewBlockInfoConfig += new Del_SetNewBlockInfoConfig(OnSetNewBlockInfoConfig);
		base.BUSEventCollection.Evt_PlayBlockBouncedMontage += new Del_Void_Actor(OnPlayBlockBouncedMontage);
		base.BUSEventCollection.Evt_PlayBRKBlockCollapseArmorMontage += new Del_Void_Actor(OnPlayBRKBlockCollapseArmorMontage);
		base.BUSEventCollection.Evt_PlayBRKBlockArmor2WeakMontage += new Del_Void_Actor(OnPlayBRKBlockArmorWeakMontage);
		base.BUSEventCollection.Evt_ReleaseBlockState += new Del_Void(OnReleaseBlockState);
		base.BUSEventCollection.Evt_TriggerBlockInSPState += new Del_TriggerBlockInSPState(OnTriggerBlockInSPState);
		base.BUSEventCollection.Evt_ReleaseBlockInSPState += new Del_ReleaseBlockInSPState(OnReleaseBlockInSPState);
		base.BUSEventCollection.Evt_OverrideArmorSetting += new Del_OverrideArmorSetting(OnOverrideArmorSetting);
		base.BUSEventCollection.Evt_ResetArmorSetting += new Del_Void(OnResetArmorSetting);
	}

	public override void PreBeginPlay()
	{
		OnResetArmorData();
		OnResetBlockTimeCounting();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!(GetOwner() == null))
		{
			UpdateForBlock(DeltaTime);
			UpdateForCounterattack();
			UpdateForCounterattackProtect();
		}
	}

	private void UpdateForCounterattackProtect()
	{
		if (SimpStateData.HasSimpleState(EBGUSimpleState.HRCounterattackProtectOneFrame))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.HRCounterattackProtectOneFrame, IsRemove: true);
		}
	}

	private void UpdateForCounterattack()
	{
		if (SimpStateData.HasSimpleState(EBGUSimpleState.DisableHRCounterAttack))
		{
			if (ArmorData.PreHRCounterattacking || ArmorData.PreHRCounterattackingUsingSuperArmor || ArmorData.Armor_BeAttackedCnt > 0 || ArmorData.Armor_LastTriggerTime != -1f)
			{
				OnResetCounterAttack();
			}
		}
		else if (ArmorData.PreHRCounterattacking && !UnitStateData.HasState(EBGUUnitState.Beatback) && !UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HRCounterattack, "<character>" + Owner.GetName() + "</><action>Tick判断可以尝试释放反击技【有预反击标识，且不在Beatback和Attacking中】</>");
			}
			CastSkillToBreakHitRecover();
		}
	}

	private void UpdateForBlock(float DeltaTime)
	{
		ArmorData.TriggerList.Update(DeltaTime);
		if (!UnitStateData.HasState(EBGUUnitState.BlockBeatBack) && !UnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack) && !UnitStateData.HasState(EBGUUnitState.BlockBounced))
		{
			RemoveBlockCacheTriggerBuff();
		}
		if (SimpStateData.HasSimpleState(EBGUSimpleState.BreakBlock))
		{
			if (ArmorData.RemoveBRKBlockCollapseArmorStateTimer > 0f)
			{
				ArmorData.RemoveBRKBlockCollapseArmorStateTimer -= DeltaTime;
				if (ArmorData.RemoveBRKBlockCollapseArmorStateTimer <= 0f)
				{
					OnResetBlockTimeCounting();
					ArmorData.BlockCoolDownTimer = ArmorData.BlockCoolDownTime;
					float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.BlockCollapseArmorMax);
					base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.BlockCollapseArmor, floatValue);
					base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakBlock, IsRemove: true);
				}
			}
			return;
		}
		if (SimpStateData.HasSimpleState(EBGUSimpleState.BreakBlock2Weak))
		{
			if (ArmorData.RemoveBRKBlockArmor2WeakStateTimer > 0f)
			{
				ArmorData.RemoveBRKBlockArmor2WeakStateTimer -= DeltaTime;
				if (ArmorData.RemoveBRKBlockArmor2WeakStateTimer <= 0f)
				{
					OnResetBlockTimeCounting();
					ArmorData.BlockCoolDownTimer = ArmorData.BlockCoolDownTime;
					float floatValue2 = AttrContainer.GetFloatValue(EBGUAttrFloat.BlockCollapseArmorMax);
					base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.BlockCollapseArmor, floatValue2);
					base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakBlock2Weak, IsRemove: true);
				}
			}
			return;
		}
		if (ArmorData.BlockCoolDownTimer > 0f)
		{
			ArmorData.BlockCoolDownTimer -= DeltaTime;
			if (ArmorData.BlockCoolDownTimer <= 0f)
			{
				OnResetBlockTimeCounting();
			}
		}
		else if (ArmorData.ResetBlockCounterTimer > 0f)
		{
			ArmorData.ResetBlockCounterTimer -= DeltaTime;
			if (ArmorData.ResetBlockCounterTimer <= 0f)
			{
				OnResetBlockTimeCounting();
			}
		}
		if (SimpStateData.HasSimpleState(EBGUSimpleState.CanTriggerBlockNormal) && !ArmorData.HasBeginBlock)
		{
			ArmorData.HasBeginBlock = true;
			OnResetArmorData();
		}
	}

	private void OnResetActorStatus(EResetActorReason ResetReason)
	{
		OnResetArmorData();
		OnResetBlockTimeCounting();
	}

	private void OnResetActorStatusAfterAll(EResetActorReason ResetReason)
	{
		RemoveBlockCacheTriggerBuff();
		ResetSPBlockState();
	}

	private void ResetSPBlockState()
	{
		if (SimpStateData.HasSimpleState(EBGUSimpleState.CanTriggerBlockInSPState))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CanTriggerBlockInSPState, IsRemove: true);
		}
		CacheMontageInstanceID = -1;
		CacheNotifyUniqueID = -1;
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (State == EMontageCallbackState.OnStarted)
		{
			ResetSPBlockState();
		}
	}

	private EAttackerArea GetAttackerArea(AActor OwnerActor, AActor Attacker)
	{
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerActor);
		FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker);
		FVector actorForwardVector = OwnerActor.GetActorForwardVector();
		FVector fVector3 = fVector2 - fVector;
		float areaDivisionLineForwardLeft = ArmorData.NowUseBlockInfoConfig.AreaDivisionLineForwardLeft;
		float areaDivisionLineForwardRight = ArmorData.NowUseBlockInfoConfig.AreaDivisionLineForwardRight;
		float areaDivisionLineBackwardLeft = ArmorData.NowUseBlockInfoConfig.AreaDivisionLineBackwardLeft;
		float areaDivisionLineBackwardRight = ArmorData.NowUseBlockInfoConfig.AreaDivisionLineBackwardRight;
		float num = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(actorForwardVector.GetSafeNormal2D(), fVector3.GetSafeNormal2D());
		if (num >= areaDivisionLineForwardLeft && num < areaDivisionLineForwardRight)
		{
			return EAttackerArea.Forward;
		}
		if (num >= areaDivisionLineBackwardLeft && num <= areaDivisionLineForwardLeft)
		{
			return EAttackerArea.LeftSide;
		}
		if (num <= areaDivisionLineBackwardRight && num >= areaDivisionLineForwardRight)
		{
			return EAttackerArea.RightSide;
		}
		return EAttackerArea.Backward;
	}

	private bool GetCacheOneDirectAMInfo(out FOneDirectBlockAMInfo OneDirectBlockAMInfo)
	{
		OneDirectBlockAMInfo = default(FOneDirectBlockAMInfo);
		switch (ArmorData.TriggerBlockAttackerArea)
		{
		case EAttackerArea.LeftSide:
			OneDirectBlockAMInfo = ArmorData.TriggerBlockAMInfo.DirectBlockAMInfo.LeftSideBlockAMInfo;
			return true;
		case EAttackerArea.RightSide:
			OneDirectBlockAMInfo = ArmorData.TriggerBlockAMInfo.DirectBlockAMInfo.RightSideBlockAMInfo;
			return true;
		case EAttackerArea.Forward:
			OneDirectBlockAMInfo = ArmorData.TriggerBlockAMInfo.DirectBlockAMInfo.ForwardBlockAMInfo;
			return true;
		case EAttackerArea.Backward:
			OneDirectBlockAMInfo = ArmorData.TriggerBlockAMInfo.DirectBlockAMInfo.BackwardBlockAMInfo;
			return true;
		default:
			return false;
		}
	}

	private void RemoveBlockCacheTriggerBuff()
	{
		if (GetOwner() == null)
		{
			return;
		}
		foreach (int cacheTriggerBuff in ArmorData.CacheTriggerBuffList)
		{
			base.BUSEventCollection.Evt_BuffRemove.Invoke(cacheTriggerBuff, EBuffEffectTriggerType.None, 1);
		}
		ArmorData.CacheTriggerBuffList.Clear();
	}

	private void AddBlockTriggerTime()
	{
		if (ArmorData.NowUseBlockInfoConfig.BlockAMSelectMode == EBlockAMSelectMode.SequenceSelectMode)
		{
			ArmorData.SequenceCounter++;
		}
		ArmorData.NowBlockTimes++;
		if (ArmorData.MaxBlockTimes > 0 && ArmorData.NowBlockTimes == ArmorData.MaxBlockTimes)
		{
			ArmorData.BlockCoolDownTimer = ArmorData.BlockCoolDownTime;
		}
	}

	private void OnResetArmorData()
	{
		if (ArmorData.CounterWithBloodConfig.Count > 0 && GetOwner() != null)
		{
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.Hp);
			float floatValue2 = AttrContainer.GetFloatValue(EBGUAttrFloat.HpMax);
			float num = floatValue / floatValue2 * 10000f;
			foreach (FGSArmorCounterWithBlood item in ArmorData.CounterWithBloodConfig)
			{
				if (num <= (float)item.BloodChangeLine)
				{
					num = item.BloodChangeLine;
					ArmorData.OriBeHitNum_Max = item.BeHitNum_Max;
					ArmorData.OriBeHitNum_Min = item.BeHitNum_Min;
				}
			}
		}
		ArmorData.Armor_BeAttackedNum = UB1Util.GetRandomNumberInt(ArmorData.OriBeHitNum_Min, ArmorData.OriBeHitNum_Max);
		ArmorData.Armor_BeAttackedCnt = 0;
		ArmorData.Armor_LastTriggerTime = -1f;
		ArmorData.TriggerList.Clear();
	}

	private void OnTriggerBlock(AActor Attacker, int MontageInstanceID, int GroupID, int NotifyID, float MontageTime, int HitLevel, EHitActionDir HitActionDir)
	{
		if (OwnerAsCharacterCS == null)
		{
			return;
		}
		FAnimNotifyTriggerList triggerList = ArmorData.TriggerList;
		long entityMontageID = triggerList.GetEntityMontageID(Attacker, MontageInstanceID);
		if (triggerList.IsCannotTrigger(entityMontageID, GroupID, NotifyID))
		{
			return;
		}
		int resID = OwnerAsCharacterCS.GetResID();
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(resID), "Find UnitCommDesc failed! ResID: {0}", resID) || ArmorData.NowUseBlockInfoConfig == null || ArmorData.BlockCoolDownTimer > 0f || UnitStateData.HasState(EBGUUnitState.Beatback) || SimpStateData.HasSimpleState(EBGUSimpleState.Immobilizing) || SimpStateData.HasSimpleState(EBGUSimpleState.Frozen) || SimpStateData.HasSimpleState(EBGUSimpleState.ForcePerformance) || SimpStateData.HasSimpleState(EBGUSimpleState.BreakPart2Weak) || SimpStateData.HasSimpleState(EBGUSimpleState.BreakSkillSuperArmor) || SimpStateData.HasSimpleState(EBGUSimpleState.BreakBlock) || SimpStateData.HasSimpleState(EBGUSimpleState.BreakBlock2Weak))
		{
			return;
		}
		bool flag = false;
		if (SimpStateData.HasSimpleState(EBGUSimpleState.CanTriggerBlockNormal))
		{
			if (UnitStateData.HasState(EBGUUnitState.BlockBeatBack) || UnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack) || UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				if (SimpStateData.HasSimpleState(EBGUSimpleState.CanTriggerBlockInSPState))
				{
					flag = true;
				}
			}
			else
			{
				flag = true;
			}
		}
		if (!flag)
		{
			return;
		}
		triggerList.MarkCannotTrigger(entityMontageID, GroupID, NotifyID, MontageTime);
		float blockTiggerAngleLeft = ArmorData.NowUseBlockInfoConfig.BlockTiggerAngleLeft;
		float blockTiggerAngleRight = ArmorData.NowUseBlockInfoConfig.BlockTiggerAngleRight;
		FVector actorForwardVector = Owner.GetActorForwardVector();
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		float num = UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(actorForwardVector.GetSafeNormal2D(), fVector.GetSafeNormal2D());
		if (num < blockTiggerAngleLeft || num > blockTiggerAngleRight)
		{
			return;
		}
		bool flag2 = ArmorData.CheckIsTriggerPerfectBlock();
		List<FBlockAMInfo> list = new List<FBlockAMInfo>();
		FBlockInfoByHitLevel CurrentBlockInfo;
		if (flag2)
		{
			list = ArmorData.NowUseBlockInfoConfig.PerfectBlockInfoWarp.BlockAMInfoList.ToList();
		}
		else if (ArmorData.GetCurrentBlockInfoByHitLevel(HitLevel, out CurrentBlockInfo))
		{
			list = CurrentBlockInfo.BlockAMInfoList;
		}
		UAnimMontage uAnimMontage = null;
		bool flag3 = false;
		int num2 = 0;
		int count = list.Count;
		if (count > 0)
		{
			int nowUseBlockInfoIdx = 0;
			if (flag2)
			{
				nowUseBlockInfoIdx = UB1Util.GetRandomNumberInt(0, count - 1);
			}
			else
			{
				switch (ArmorData.NowUseBlockInfoConfig.BlockAMSelectMode)
				{
				case EBlockAMSelectMode.RandomSelectMode:
					nowUseBlockInfoIdx = UB1Util.GetRandomNumberInt(0, count - 1);
					break;
				case EBlockAMSelectMode.SequenceSelectMode:
				{
					int sequenceCounter = ArmorData.SequenceCounter;
					sequenceCounter = ((sequenceCounter > count - 1) ? (sequenceCounter % count) : sequenceCounter);
					nowUseBlockInfoIdx = sequenceCounter;
					break;
				}
				}
			}
			ArmorData.ResetBlockCounterTimer = ArmorData.ResetBlockCounterTime;
			ArmorData.PreUseBlockInfoIdx = ArmorData.NowUseBlockInfoIdx;
			ArmorData.NowUseBlockInfoIdx = nowUseBlockInfoIdx;
			ArmorData.TriggerBlockAMInfo = list[ArmorData.NowUseBlockInfoIdx];
			ArmorData.TriggerBlockHitLevel = HitLevel;
			ArmorData.TriggerBlockAttackerArea = GetAttackerArea(Owner, Attacker);
			if (GetCacheOneDirectAMInfo(out var OneDirectBlockAMInfo))
			{
				if (OneDirectBlockAMInfo.IsUseBlockListInfo)
				{
					if (OneDirectBlockAMInfo.OneBlockListInfo != null && OneDirectBlockAMInfo.OneBlockListInfo.Count > 0)
					{
						bool flag4 = true;
						while (flag4)
						{
							int count2 = OneDirectBlockAMInfo.OneBlockListInfo.Count;
							int randomNumberInt = UB1Util.GetRandomNumberInt(0, count2 - 1);
							if (randomNumberInt < 0 || randomNumberInt >= count2)
							{
								break;
							}
							FOneBlockListInfo fOneBlockListInfo = OneDirectBlockAMInfo.OneBlockListInfo[randomNumberInt];
							flag3 = fOneBlockListInfo.IsUseSkill2Block;
							if (flag3)
							{
								num2 = fOneBlockListInfo.Skill2Block;
								if (BGUFuncLibAICS.BGURequestAIUseBestComboSkill(Owner, null, new List<int> { num2 }, IsFirstSkill: true, 1, 1, IsGetTopRange: true, 10000, EnableForceComboRelation: false, UseComboCondition: false, UsePursuitAnyWhere: false, NeedCheckSkillCanCast: true) != 0)
								{
									FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(ActionRequestData.GetLastSkillID(), Owner);
									uAnimMontage = PreloadAssetMgr.TryGetCachedResourceObj<UAnimMontage>(skillSDesc.TemplatePath, ELoadResourceType.SyncLoadAndCache);
									flag4 = false;
								}
							}
							else
							{
								uAnimMontage = fOneBlockListInfo.AM2Block;
								flag4 = false;
							}
							if (uAnimMontage != null)
							{
								ArmorData.Cache_IsUseSkill2BlockBounce = fOneBlockListInfo.IsUseSkill2BlockBounce;
								ArmorData.Cache_Skill2BlockBounce = fOneBlockListInfo.Skill2BlockBounce;
								ArmorData.Cache_BlockBounceAM = fOneBlockListInfo.BlockBounceAM;
							}
							OneDirectBlockAMInfo.OneBlockListInfo.RemoveAt(randomNumberInt);
						}
					}
				}
				else
				{
					flag3 = OneDirectBlockAMInfo.IsUseSkill2Block;
					if (flag3)
					{
						num2 = OneDirectBlockAMInfo.Skill2Block;
						if (BGUFuncLibAICS.BGURequestAIUseBestComboSkill(Owner, null, new List<int> { num2 }, IsFirstSkill: true, 1, 1, IsGetTopRange: true, 10000, EnableForceComboRelation: false, UseComboCondition: false, UsePursuitAnyWhere: false, NeedCheckSkillCanCast: true) != 0)
						{
							FUStSkillSDesc skillSDesc2 = BGW_GameDB.GetSkillSDesc(ActionRequestData.GetLastSkillID(), Owner);
							uAnimMontage = PreloadAssetMgr.TryGetCachedResourceObj<UAnimMontage>(skillSDesc2.TemplatePath, ELoadResourceType.SyncLoadAndCache);
						}
					}
					else
					{
						uAnimMontage = OneDirectBlockAMInfo.AM2Block;
					}
					if (uAnimMontage != null)
					{
						ArmorData.Cache_IsUseSkill2BlockBounce = OneDirectBlockAMInfo.IsUseSkill2BlockBounce;
						ArmorData.Cache_Skill2BlockBounce = OneDirectBlockAMInfo.Skill2BlockBounce;
						ArmorData.Cache_BlockBounceAM = OneDirectBlockAMInfo.BlockBounceAM;
					}
				}
				if (uAnimMontage != null)
				{
					if (!flag3)
					{
						base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
						base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("格挡");
						BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, uAnimMontage, FName.None);
						base.BUSEventCollection.Evt_SetTriggerMontage.Invoke(P1: true);
					}
					RemoveBlockCacheTriggerBuff();
					float sequenceLength = uAnimMontage.SequenceLength;
					foreach (int blockBuff in ArmorData.TriggerBlockAMInfo.BlockBuffList)
					{
						ArmorData.CacheTriggerBuffList.Add(blockBuff);
						base.BUSEventCollection.Evt_BuffAdd.Invoke(blockBuff, Owner, Owner, sequenceLength * 1000f, EBuffSourceType.Armor);
					}
					base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.LeaveAllBlockState, sequenceLength, NeedForceUpdate: true);
					base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(flag2 ? EBUStateTrigger.EnterPerfectBlockBeatBack : EBUStateTrigger.EnterBlockBeatBack, sequenceLength, NeedForceUpdate: true);
					if (ArmorData.NowUseBlockInfoConfig.BlockCounterType == EBlockCounterType.AddCountAfterBlock)
					{
						AddBlockTriggerTime();
					}
				}
			}
			if (flag2)
			{
				ArmorData.SequenceCounter = 0;
			}
		}
		if (!DebugConfig.IsOpenBattleInfoTool)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<character>" + Owner.GetName() + "</><action>触发了</>");
		stringBuilder.Append(flag2 ? "<effect>完美格挡！！！</>" : "<effect>普通格挡！</>");
		if (flag3)
		{
			stringBuilder.Append($"<effect>使用技能格挡！，格挡技能是：{num2}</>");
			if (uAnimMontage == null)
			{
				stringBuilder.Append("<action>，格挡技能释放失败(请检查配置)</>");
			}
		}
		else
		{
			stringBuilder.Append("<effect>使用动画格挡！</>");
			stringBuilder.Append((uAnimMontage != null) ? ("<action>格挡动画是：</><effect>" + uAnimMontage.GetName() + "</>") : "<action>但是没有格挡动画(请检查配置)</>");
		}
		BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.Block, stringBuilder.ToString());
		stringBuilder.Clear();
		stringBuilder.Append($"<action>攻击者是：</><bechosed>{Attacker.GetName()}</><action>，触发格挡时所在区域是：</><effect>{ArmorData.TriggerBlockAttackerArea}</><action>，触发格挡时打击力度是：</><effect>{ArmorData.TriggerBlockHitLevel}</><action>。当前格挡信息的序号是：{ArmorData.NowUseBlockInfoIdx}</><action>, 上个格挡信息的序号是：{ArmorData.PreUseBlockInfoIdx}</>");
		BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.Block, stringBuilder.ToString());
	}

	private void OnPlayBlockBouncedMontage(AActor Attacker)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(aCharacter);
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find UnitCommDesc failed! ResID: {0}", actorResID) || ArmorData.NowUseBlockInfoConfig == null)
		{
			return;
		}
		UAnimMontage uAnimMontage = null;
		if (ArmorData.Cache_IsUseSkill2BlockBounce)
		{
			if (BGUFuncLibAICS.BGURequestAIUseBestComboSkill(Owner, null, new List<int> { ArmorData.Cache_Skill2BlockBounce }, IsFirstSkill: true, 1, 1, IsGetTopRange: true, 10000, EnableForceComboRelation: false, UseComboCondition: false, UsePursuitAnyWhere: false, NeedCheckSkillCanCast: true) != 0)
			{
				FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(ActionRequestData.GetLastSkillID(), Owner);
				uAnimMontage = PreloadAssetMgr.TryGetCachedResourceObj<UAnimMontage>(skillSDesc.TemplatePath, ELoadResourceType.SyncLoadAndCache);
			}
		}
		else
		{
			uAnimMontage = ArmorData.Cache_BlockBounceAM;
		}
		if (uAnimMontage != null)
		{
			RemoveBlockCacheTriggerBuff();
			float num = UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(aCharacter, uAnimMontage, 0);
			foreach (int blockBouncedBuff in ArmorData.TriggerBlockAMInfo.BlockBouncedBuffList)
			{
				ArmorData.CacheTriggerBuffList.Add(blockBouncedBuff);
				base.BUSEventCollection.Evt_BuffAdd.Invoke(blockBouncedBuff, aCharacter, aCharacter, num * 1000f, EBuffSourceType.Armor);
			}
			base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
			base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("格挡弹回");
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.LeaveAllBlockState, num, NeedForceUpdate: true);
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnterBlockBounced, num, NeedForceUpdate: true);
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, num, NeedForceUpdate: true);
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, uAnimMontage, FName.None);
			base.BUSEventCollection.Evt_SetTriggerMontage.Invoke(P1: true);
			OnReleaseBlockInSPState(CacheMontageInstanceID, CacheNotifyUniqueID);
			if (ArmorData.NowUseBlockInfoConfig.BlockCounterType == EBlockCounterType.AddCountAfterBounced)
			{
				AddBlockTriggerTime();
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<character>" + aCharacter.GetName() + "</><action>触发了</>");
			if (ArmorData.CheckIsInPerfectBlock())
			{
				stringBuilder.Append("<effect>完美格挡下的弹回！！！</>");
			}
			else
			{
				stringBuilder.Append("<effect>普通格挡下的弹回！</>");
			}
			if (uAnimMontage != null)
			{
				stringBuilder.Append("<action>弹回动画是：</><effect>" + uAnimMontage.GetName() + "</>");
			}
			else
			{
				stringBuilder.Append("<action>但是没有弹回动画(请检查配置)</>");
			}
			BGUFunctionLibraryCS.LogBattleInfo(aCharacter, EBattleInfoType.Block, stringBuilder.ToString());
			stringBuilder.Clear();
			stringBuilder.Append($"<action>攻击者是：</><bechosed>{Attacker.GetName()}</><action>，触发格挡时所在区域是：</><effect>{ArmorData.TriggerBlockAttackerArea}</><action>，触发格挡时打击力度是：</><effect>{ArmorData.TriggerBlockHitLevel}</><action>。当前格挡信息的序号是：{ArmorData.NowUseBlockInfoIdx}</><action>, 上个格挡信息的序号是：{ArmorData.PreUseBlockInfoIdx}</>");
			BGUFunctionLibraryCS.LogBattleInfo(aCharacter, EBattleInfoType.Block, stringBuilder.ToString());
		}
	}

	private void OnPlayBRKBlockCollapseArmorMontage(AActor Attacker)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(aCharacter);
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find UnitCommDesc failed! ResID: {0}", actorResID) || ArmorData.NowUseBlockInfoConfig == null)
		{
			return;
		}
		UAnimMontage uAnimMontage = (ArmorData.CheckIsInPerfectBlock() ? ArmorData.NowUseBlockInfoConfig.PerfectBlockInfoWarp.BreakBlockAM : ArmorData.NowUseBlockInfoConfig.NormalBlockInfoWarp.BreakBlockAM);
		if (uAnimMontage != null)
		{
			aCharacter.StopAnimMontage(null);
			float num = UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(Owner, uAnimMontage, 0);
			ArmorData.RemoveBRKBlockCollapseArmorStateTimer = num;
			base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
			base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("格挡护甲崩溃");
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.LeaveAllBlockState, num, NeedForceUpdate: true);
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, num, NeedForceUpdate: true);
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakBlock);
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, uAnimMontage, FName.None);
			base.BUSEventCollection.Evt_SetTriggerMontage.Invoke(P1: true);
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<character>" + aCharacter.GetName() + "</><action>触发了</>");
			if (ArmorData.CheckIsInPerfectBlock())
			{
				stringBuilder.Append("<effect>完美格挡下的格挡护甲崩溃！！！</>");
			}
			else
			{
				stringBuilder.Append("<effect>普通格挡下的格挡护甲崩溃！</>");
			}
			if (uAnimMontage != null)
			{
				stringBuilder.Append("<action>格挡护甲崩溃动画是：</><effect>" + uAnimMontage.GetName() + "</>");
			}
			else
			{
				stringBuilder.Append("<action>但是没有格挡护甲崩溃动画(请检查配置)</>");
			}
			BGUFunctionLibraryCS.LogBattleInfo(aCharacter, EBattleInfoType.Block, stringBuilder.ToString());
			stringBuilder.Clear();
			stringBuilder.Append($"<action>攻击者是：</><bechosed>{Attacker.GetName()}</><action>，触发格挡时所在区域是：</><effect>{ArmorData.TriggerBlockAttackerArea}</><action>，触发格挡时打击力度是：</><effect>{ArmorData.TriggerBlockHitLevel}</><action>。当前格挡信息的序号是：{ArmorData.NowUseBlockInfoIdx}</><action>, 上个格挡信息的序号是：{ArmorData.PreUseBlockInfoIdx}</>");
			BGUFunctionLibraryCS.LogBattleInfo(aCharacter, EBattleInfoType.Block, stringBuilder.ToString());
		}
	}

	private void OnPlayBRKBlockArmorWeakMontage(AActor Attacker)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(aCharacter);
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find UnitCommDesc failed! ResID: {0}", actorResID) || ArmorData.NowUseBlockInfoConfig == null)
		{
			return;
		}
		UAnimMontage uAnimMontage = (ArmorData.CheckIsInPerfectBlock() ? ArmorData.NowUseBlockInfoConfig.PerfectBlockInfoWarp.BreakBlock2WeakAM : ArmorData.NowUseBlockInfoConfig.NormalBlockInfoWarp.BreakBlock2WeakAM);
		if (uAnimMontage != null)
		{
			aCharacter.StopAnimMontage(null);
			float num = UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(Owner, uAnimMontage, 0);
			ArmorData.RemoveBRKBlockArmor2WeakStateTimer = num;
			base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
			base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("格挡护甲崩溃虚弱");
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.LeaveAllBlockState, num, NeedForceUpdate: true);
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakBlock, IsRemove: true);
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, num, NeedForceUpdate: true);
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakBlock2Weak);
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, uAnimMontage, FName.None);
			base.BUSEventCollection.Evt_SetTriggerMontage.Invoke(P1: true);
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("<character>" + aCharacter.GetName() + "</><action>触发了</>");
			if (ArmorData.CheckIsInPerfectBlock())
			{
				stringBuilder.Append("<effect>完美格挡下的格挡护甲崩溃虚弱！！！</>");
			}
			else
			{
				stringBuilder.Append("<effect>普通格挡下的格挡护甲崩溃虚弱！</>");
			}
			if (uAnimMontage != null)
			{
				stringBuilder.Append("<action>格挡护甲崩溃虚弱动画是：</><effect>" + uAnimMontage.GetName() + "</>");
			}
			else
			{
				stringBuilder.Append("<action>但是没有格挡护甲崩溃虚弱动画(请检查配置)</>");
			}
			BGUFunctionLibraryCS.LogBattleInfo(aCharacter, EBattleInfoType.Block, stringBuilder.ToString());
			stringBuilder.Clear();
			stringBuilder.Append($"<action>攻击者是：</><bechosed>{Attacker.GetName()}</><action>，触发格挡时所在区域是：</><effect>{ArmorData.TriggerBlockAttackerArea}</><action>，触发格挡时打击力度是：</><effect>{ArmorData.TriggerBlockHitLevel}</><action>。当前格挡信息的序号是：{ArmorData.NowUseBlockInfoIdx}</><action>, 上个格挡信息的序号是：{ArmorData.PreUseBlockInfoIdx}</>");
			BGUFunctionLibraryCS.LogBattleInfo(aCharacter, EBattleInfoType.Block, stringBuilder.ToString());
		}
	}

	private void OnReleaseBlockState()
	{
		if (UnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack) || UnitStateData.HasState(EBGUUnitState.BlockBeatBack) || UnitStateData.HasState(EBGUUnitState.BlockBounced))
		{
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.LeaveAllBlockState, -1f, NeedForceUpdate: true);
		}
		if (UnitStateData.HasState(EBGUUnitState.Attacking))
		{
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.SkillBreak, -1f, NeedForceUpdate: true);
		}
		if (SimpStateData.HasSimpleState(EBGUSimpleState.BreakBlock))
		{
			OnResetBlockTimeCounting();
			ArmorData.BlockCoolDownTimer = ArmorData.BlockCoolDownTime;
			float floatValue = AttrContainer.GetFloatValue(EBGUAttrFloat.BlockCollapseArmorMax);
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.BlockCollapseArmor, floatValue);
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakBlock, IsRemove: true);
		}
		if (SimpStateData.HasSimpleState(EBGUSimpleState.BreakBlock2Weak))
		{
			OnResetBlockTimeCounting();
			ArmorData.BlockCoolDownTimer = ArmorData.BlockCoolDownTime;
			float floatValue2 = AttrContainer.GetFloatValue(EBGUAttrFloat.BlockCollapseArmorMax);
			base.BUSEventCollection.Evt_SetAttrFloat.Invoke(EBGUAttrFloat.BlockCollapseArmor, floatValue2);
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.BreakBlock2Weak, IsRemove: true);
		}
	}

	private void OnTriggerBlockInSPState(int MontageInstanceID, int NotifyUniqueID)
	{
		CacheMontageInstanceID = MontageInstanceID;
		CacheNotifyUniqueID = NotifyUniqueID;
		if (!SimpStateData.HasSimpleState(EBGUSimpleState.CanTriggerBlockInSPState))
		{
			base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CanTriggerBlockInSPState);
		}
	}

	private void OnReleaseBlockInSPState(int MontageInstanceID, int NotifyUniqueID)
	{
		if (CacheMontageInstanceID == MontageInstanceID && CacheNotifyUniqueID == NotifyUniqueID)
		{
			ResetSPBlockState();
		}
	}

	private void OnResetBlockTimeCounting()
	{
		ArmorData.BlockCoolDownTimer = 0f;
		ArmorData.ResetBlockCounterTimer = 0f;
		ArmorData.NowBlockTimes = 0;
		ArmorData.SequenceCounter = 0;
		ArmorData.NowUseBlockInfoIdx = -1;
		ArmorData.PreUseBlockInfoIdx = -1;
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.Block, "触发格挡信息重置");
		}
	}

	private void OnSetNewBlockInfoConfig(BGWDataAsset_BlockInfoConfig NewBlockInfoConfig, bool NeedUpdateDefaultValue)
	{
		ArmorData.SetNewBlockInfoConfig(NewBlockInfoConfig, NeedUpdateDefaultValue);
	}

	private void CastSkillToBreakHitRecover()
	{
		AActor owner = GetOwner();
		if (!ArmorData.PreHRCounterattacking)
		{
			return;
		}
		if (ArmorData.PreHRCounterattackingUsingSuperArmor && owner != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_RemoveSkillSuperArmor.Invoke(-1);
				ArmorData.PreHRCounterattackingUsingSuperArmor = false;
			}
		}
		ArmorData.PreHRCounterattacking = false;
		OnResetArmorData();
		if (!ArmorData.Armor_Enable || SimpStateData.HasSimpleState(EBGUSimpleState.DisableHRCounterAttack) || ArmorData.GetArmorSkillIDs() == null || ArmorData.GetArmorSkillIDs().Count <= 0)
		{
			return;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = "";
			foreach (int armorSkillID in ArmorData.GetArmorSkillIDs())
			{
				text = text + armorSkillID + ";";
			}
			BGUFunctionLibraryCS.LogBattleInfo(owner, EBattleInfoType.HRCounterattack, "<character>" + owner.GetName() + "</><action>本次反击技能列表有：" + text + "</>");
		}
		int num = BGUFuncLibAICS.BGURequestAIUseBestComboSkill(owner, null, ArmorData.GetArmorSkillIDs(), IsFirstSkill: true, 1, 1, ArmorData.IsGetTopRandomSkill, ArmorData.TopRandomSkillPercent, EnableForceComboRelation: false, UseComboCondition: false, UsePursuitAnyWhere: false, NeedCheckSkillCanCast: true);
		if (num != 0)
		{
			int lastSkillID = ActionRequestData.GetLastSkillID();
			FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(lastSkillID, owner);
			if (skillSDesc == null)
			{
				return;
			}
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(owner).TryGetCachedResourceObj<UAnimMontage>(skillSDesc.TemplatePath, ELoadResourceType.SyncLoadAndCache);
			if (uAnimMontage != null)
			{
				float time = UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(owner, uAnimMontage, 0);
				base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.HRCounterattackBegin, time);
				base.BUSEventCollection.Evt_SetTriggerMontage.Invoke(P1: true);
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.HRCounterattackProtectOneFrame);
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(owner, EBattleInfoType.HRCounterattack, $"<character>{owner.GetName()}</><action>释放反击技 </><effectnum>{lastSkillID}</><action> 成功</>");
				}
			}
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(owner, EBattleInfoType.HRCounterattack, $"<character>{owner.GetName()}</><action>尝试释放反击技失败</><action> SkillIdx :{num}</>");
		}
	}

	private void OnAddCounterAttackTimes()
	{
		if (!ArmorData.Armor_Enable || SimpStateData.HasSimpleState(EBGUSimpleState.DisableHRCounterAttack))
		{
			return;
		}
		if (UnitStateData.HasState(EBGUUnitState.HRCounterattacking) || ArmorData.IsInPreHRCounterattacking())
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HRCounterattack, "<character>" + Owner.GetName() + "</><action>已经处于反击 or 预反击中，不再继续计数</>");
			}
			return;
		}
		float timeSeconds = GetOwner().World.GetTimeSeconds();
		if (timeSeconds - ArmorData.Armor_LastTriggerTime > ArmorData.Armor_Timer)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HRCounterattack, "<character>" + Owner.GetName() + "</><action>反击计时超时！重置反击计数逻辑！</>");
			}
			OnResetArmorData();
		}
		if (ArmorData.Armor_BeAttackedCnt == 0 || ArmorData.Armor_LastTriggerTime < 0f)
		{
			ArmorData.Armor_LastTriggerTime = timeSeconds;
		}
		ArmorData.Armor_BeAttackedCnt++;
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HRCounterattack, $"<character>{Owner.GetName()}</><action>反击计数+1，当前计数为 {ArmorData.Armor_BeAttackedCnt}，本轮反击触发计数为：{ArmorData.Armor_BeAttackedNum}</>");
		}
	}

	private void OnResetCounterAttack()
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HRCounterattack, "<character>" + Owner.GetName() + "</><action>重置反击信息</>");
		}
		if (Owner != null && ArmorData.PreHRCounterattackingUsingSuperArmor)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_RemoveSkillSuperArmor.Invoke(-1);
			}
		}
		ArmorData.PreHRCounterattacking = false;
		ArmorData.PreHRCounterattackingUsingSuperArmor = false;
		OnResetArmorData();
	}

	private void OnTriggerPreHRCounterattackingSuperArmor()
	{
		if (!ArmorData.Armor_Enable || SimpStateData.HasSimpleState(EBGUSimpleState.DisableHRCounterAttack) || !(Owner != null))
		{
			return;
		}
		float SuperArmorValue = 0f;
		string superArmorLevelName = BGW_GameDB.GetSuperArmorLevelDescByID(1004).SuperArmorLevelName;
		BGUFunctionLibraryCS.BGUGetSuperArmorValueByLevel(superArmorLevelName, " PreHRCounterattackingSuperArmor: " + superArmorLevelName, "PreHRCounterattackingSuperArmor", out SuperArmorValue, Owner);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Owner);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(Owner);
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(actorResID);
		if (unitCommDesc == null)
		{
			return;
		}
		float setArmorValue = unitCommDesc.MaxSkillSuperArmorValue;
		if (SuperArmorValue >= 0f)
		{
			setArmorValue = SuperArmorValue;
		}
		ArmorData.PreHRCounterattackingUsingSuperArmor = true;
		bUS_GSEventCollection.Evt_TriggerSkillSuperArmor.Invoke(null, setArmorValue, -1);
		if (actorResID == 8000 && !BGUFunctionLibraryCS.BGUHasBuffByID(Owner, 800026) && !BGUFunctionLibraryCS.BGUHasBuffByID(Owner, 800009))
		{
			float buffDurationTimer = 3800f;
			if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.YJBreakImmueStiffDuration, out var ConfigInfo))
			{
				buffDurationTimer = ConfigInfo.FloatValue;
			}
			BGUFunctionLibraryCS.BGUAddBuff(Owner, Owner, 800093, EBuffSourceType.Armor, buffDurationTimer);
		}
	}

	private void OnTriggerCounterAttack(bool DoImmediately)
	{
		if (ArmorData.Armor_Enable && !SimpStateData.HasSimpleState(EBGUSimpleState.DisableHRCounterAttack))
		{
			ArmorData.Armor_LastTriggerTime = -1f;
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				string text = (DoImmediately ? "是" : "不是");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.HRCounterattack, "<character>" + Owner.GetName() + "</><action>满足条件可触发反击，本次反击 " + text + " 立刻反击</>");
			}
			ArmorData.PreHRCounterattacking = true;
			if (DoImmediately)
			{
				CastSkillToBreakHitRecover();
			}
		}
	}

	private void OnOverrideArmorSetting(FGSArmorSettingInBP NewSetting)
	{
		ArmorData.SetArmorSetting(NewSetting, GetOwner(), IsSetDefault: false, IsReset: false);
		OnResetCounterAttack();
		OnResetBlockTimeCounting();
	}

	private void OnResetArmorSetting()
	{
		ArmorData.ResetArmorSetting(GetOwner());
		OnResetCounterAttack();
		OnResetBlockTimeCounting();
	}
}
