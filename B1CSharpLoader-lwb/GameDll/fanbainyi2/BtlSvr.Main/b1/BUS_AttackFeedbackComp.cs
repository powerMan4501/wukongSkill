using System;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_AttackFeedbackComp")]
public class BUS_AttackFeedbackComp : UActorCompBaseUObj
{
	private IBUC_SimpleStateData SimpleStateData { get; set; }

	private IBUC_SkillInstsData SkillInstsData { get; set; }

	private IBUC_UnitStateData UnitStateData { get; set; }

	public override void OnAttach()
	{
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		SkillInstsData = RequireReadOnlyData<IBUC_SkillInstsData, BUC_SkillInstsData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		base.BUSEventCollection.Evt_AttackFeedback += new Del_AttackFeedback(OnAttackFeedback);
		base.BUSEventCollection.Evt_TriggerAtkRebounding += new Del_TriggerAtkRebounding(OnTriggerAtkRebounding);
	}

	private void OnAttackFeedback(AActor Victim, int AttackSkillID, int EffectID, int NotifyID, bool IsAtkRebounding)
	{
		if (GetOwner() as ACharacter == null)
		{
			return;
		}
		int actorResID = GetActorResID();
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find UnitCommDesc Failed ResID: {0}", actorResID))
		{
			return;
		}
		base.BUSEventCollection.Evt_SetLastHitActor.Invoke(Victim);
		if (IsAtkRebounding && NotifyID != -1)
		{
			FUStIronBodyConfigDesc victimIronBodyConfigDesc = null;
			if (BGU_DataUtil.GetReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>(Victim).HasSimpleState(EBGUSimpleState.InTTTB))
			{
				victimIronBodyConfigDesc = BGW_GameDB.GetIronBodyConfigDesc(BGU_DataUtil.GetActorResID(Victim), Victim);
			}
			TriggerAtkReboundingImpl(NotifyID, AttackSkillID, EffectID, victimIronBodyConfigDesc);
		}
	}

	private void OnTriggerAtkRebounding(AActor TriggerActor, int NotifyID, int AttackSkillID)
	{
		if (!(GetOwner() as ACharacter == null))
		{
			int actorResID = GetActorResID();
			if (!BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find UnitCommDesc Failed ResID: {0}", actorResID) && TriggerAtkReboundingImpl(NotifyID, AttackSkillID, -1))
			{
				BUS_EventCollectionCS.Get(TriggerActor)?.Evt_TriggerAtkReboundingSuccess.Invoke(Owner);
			}
		}
	}

	private bool TriggerAtkReboundingImpl(int NotifyID, int AttackSkillID, int SkillEffectID, FUStIronBodyConfigDesc VictimIronBodyConfigDesc = null)
	{
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>================= 开始计算触发弹刀 =================</>");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, $"<character>{Owner.GetName()}</><action>NotifyID = {NotifyID}，AttackSkillID = {AttackSkillID}，SkillEffectID = {SkillEffectID}</>");
		}
		UAnimMontage uAnimMontage = null;
		if (!UnitStateData.HasState(EBGUUnitState.Dead) && !UnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) && !UnitStateData.HasState(EBGUUnitState.LifeSavingHair_Rebirth))
		{
			ACharacter aCharacter = GetOwner() as ACharacter;
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(GetActorResID());
			if (unitCommDesc != null && aCharacter != null)
			{
				int atkReboundBuffID = unitCommDesc.AtkReboundBuffID;
				bool flag = false;
				FUStSkillSDesc skillSDesc = BGW_GameDB.GetSkillSDesc(AttackSkillID, Owner);
				if (BGW_GameDB.GetSkillEffectDesc(SkillEffectID, aCharacter) != null && VictimIronBodyConfigDesc != null)
				{
					int SkillDamageExpandID;
					FUStSkillDamageExpandDesc skillDamageExpandDesc = BGW_GameDB.GetSkillDamageExpandDesc(SkillEffectID, aCharacter, out SkillDamageExpandID);
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, $"<character>{Owner.GetName()}</><action>尝试触发铜头铁臂弹刀！！！SkillEffectID = {SkillEffectID}，SkillDamageExpandID = {SkillDamageExpandID}</>");
						if (skillDamageExpandDesc == null)
						{
							BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>SkillDamageExpandDesc寻找失败，中断铜头铁臂弹刀，改为尝试普通弹刀</>");
						}
					}
					if (skillDamageExpandDesc != null)
					{
						int num = 0;
						switch (skillDamageExpandDesc.HitWeightGearType)
						{
						case EHitWeightGearType.LowHitWeight:
							num = VictimIronBodyConfigDesc.LowHitWeight;
							break;
						case EHitWeightGearType.MediueHitWeight:
							num = VictimIronBodyConfigDesc.MediueHitWeight;
							break;
						case EHitWeightGearType.HeightHitWeight:
							num = VictimIronBodyConfigDesc.HeightHitWeight;
							break;
						case EHitWeightGearType.HugeHitWeight:
							num = VictimIronBodyConfigDesc.HugeHitWeight;
							break;
						case EHitWeightGearType.MustDefeatHitWeight:
							num = VictimIronBodyConfigDesc.MustDefeatHitWeight;
							break;
						}
						BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.CanDefeatTTTBAdditive, out var ConfigInfo);
						float num2 = (SimpleStateData.HasSimpleState(EBGUSimpleState.CanDefeatTTTB) ? ConfigInfo.FloatValue : 0f);
						float num3 = (float)(num + unitCommDesc.DefaultTenacity) + num2 - (float)VictimIronBodyConfigDesc.PlayerDefense;
						if (DebugConfig.IsOpenBattleInfoTool)
						{
							BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>开始计算</><effect>铜头铁臂</><action>弹刀！！！计算公式：ImpactValue = HitWeight + UnitCommDesc.DefaultTenacity + CanDefeatValue - VictimIronBodyConfigDesc.PlayerDefense</>");
							BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, $"<character>{Owner.GetName()}</><action>HitWeight = {num}</>\n<action>HitWeight = {unitCommDesc.DefaultTenacity}</>\n<action>HitWeight = {num2}</>\n<action>HitWeight = {VictimIronBodyConfigDesc.PlayerDefense}</>");
							if (num3 > 0f)
							{
								BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, $"<character>{Owner.GetName()}</><action>ImpactValue = {num3}，大于0，弹刀动画优先用SkillSDesc.LowAtkReboundingMontage【先判断SweepCheck再判断Skill】</>");
							}
							else
							{
								BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, $"<character>{Owner.GetName()}</><action>ImpactValue = {num3}，小于0，弹刀动画只能是AtkReboundingMontage【先判断SweepCheck再判断Skill】</>");
							}
						}
						if (num3 > 0f)
						{
							flag = true;
							uAnimMontage = SkillInstsData.GetSweepCheckLowAtkReboundingAM(NotifyID);
							if (uAnimMontage == null)
							{
								if (DebugConfig.IsOpenBattleInfoTool)
								{
									BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>从SweepCheck里尝试获取LowAtkReboundingAM失败，继续从Skill表里尝试获取</>");
								}
								if (skillSDesc != null)
								{
									uAnimMontage = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UAnimMontage>(skillSDesc.LowAtkReboundingMontage, ELoadResourceType.SyncLoadAndCache);
								}
							}
							else if (DebugConfig.IsOpenBattleInfoTool)
							{
								BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>从SweepCheck里获取LowAtkReboundingAM成功！！</><effect>" + uAnimMontage.GetPathName() + "</>");
							}
						}
					}
				}
				if (!flag)
				{
					uAnimMontage = SkillInstsData.GetSweepCheckAtkReboundingAM(NotifyID);
					if (uAnimMontage == null)
					{
						if (DebugConfig.IsOpenBattleInfoTool)
						{
							BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>从SweepCheck里尝试获取AtkReboundingAM失败，继续从Skill表里尝试获取</>");
						}
						if (skillSDesc != null)
						{
							uAnimMontage = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UAnimMontage>(skillSDesc.AtkReboundingMontage, ELoadResourceType.SyncLoadAndCache);
						}
					}
					else if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>从SweepCheck里获取AtkReboundingAM成功！！</><effect>" + uAnimMontage.GetPathName() + "</>");
					}
				}
				TriggerReboundingMontage(atkReboundBuffID, uAnimMontage);
			}
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>处于特殊状态下，弹刀触发中断！</>");
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>================= 弹刀计算逻辑结束 =================</>");
		}
		return uAnimMontage != null;
	}

	private void TriggerReboundingMontage(int AtkReboundBuffID, UAnimMontage AtkReboundingMontage)
	{
		if (AtkReboundingMontage != null)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>触发弹刀，弹刀动画是：</><effect>" + AtkReboundingMontage.GetPathName() + "</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, $"<character>{Owner.GetName()}</><action>触发弹刀，给自身添加Buff：</><effect>{AtkReboundBuffID}</>");
			}
			BGUFuncLibAnim.BGUActorTryPlayMontage(Owner, AtkReboundingMontage, FName.None);
			float num = UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(Owner, AtkReboundingMontage, 0);
			float num2 = UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(Owner, AtkReboundingMontage, 0);
			UGSE_AnimFuncLib.AnimMontageGetBlendInAndOutTime(AtkReboundingMontage, out var BlendInTime, out var BlendOutTime);
			num2 -= BlendInTime + BlendOutTime;
			base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
			base.BUSEventCollection.Evt_UnitTryBreakSkill.Invoke("触发弹刀");
			base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, num2, NeedForceUpdate: true);
			base.BUSEventCollection.Evt_BuffAdd.Invoke(AtkReboundBuffID, GetOwner(), GetOwner(), num * 1000f, EBuffSourceType.AttackFeedback);
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.AtkRebounding, "<character>" + Owner.GetName() + "</><action>弹刀动画为空，弹刀失败！！！</>");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_AttackFeedbackComp");
	}

	static BUS_AttackFeedbackComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_AttackFeedbackComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_AttackFeedbackComp));
	}
}
