using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using b1.BGW;
using b1.EventDelDefine;
using b1.Prediction;
using BtlB1;
using BtlShare;
using Diana.Common;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_BeAttackedComp : UActorCompBaseCS
{
	private struct FDamageDynamicParam
	{
		public float HitWeight;

		public int StiffLevel;

		public int HitPartID;

		public BGWDataAsset_UnitBeAttackedConfig NowUseUBAConfig;

		public EAttackerArea AttackerArea;
	}

	private struct FDamageDescParam
	{
		public int HitVEffectID;

		public int AttackStiffEffectID;

		public ESkillDamageType SkillDamageType;

		public float HitWeight;

		public float BaseDamage;

		public int SpecialHitPartID;

		public float PartDamage;

		public float BaseDamageRatio;

		public float SkillArmorHit;

		public float BlockArmorHit;

		public float ImmobilizeHit;

		public bool bIgnoreBeAttacked;

		public float CritRateAddition;

		public float CritDamageAddition;

		public float HPMaxINV10000Damage_Element;

		public bool bCanTriggerFX;

		public bool bCanTriggerFightBackCounter;

		public EAbnormalStateType ElemAtkType;

		public float TargetCurHpRatio;

		public int ElementDmgLevel;

		public float HPMaxINV10000Damage_Abs;

		public bool BreakFrozenImmediatelyFlag;
	}

	private enum EBeAttackedEvent
	{
		ExitRiding,
		ExitRidingHit,
		PhaseTran,
		LifeSaving,
		Dead,
		AnimationSyncing,
		PartBreak,
		BlockArmorBreak2Weak,
		BlockArmorBreak,
		SkillSuperArmorBreak,
		ImmobilizedBreak,
		FrozenBreak,
		SkillSuperArmorHit,
		ImmobilizedHit,
		FrozenHit,
		BlockArmorHit,
		FightBack,
		NormalStiff,
		Nothing
	}

	private abstract class BeAttackedEventBase
	{
		protected BGUCharacterCS VictimChr;

		protected BUS_BeAttackedComp OwningComp;

		protected BUS_GSEventCollection VictimBE;

		public abstract FName BeAttackedEventName { get; }

		public void Init(BGUCharacterCS _VictimChr, BUS_BeAttackedComp _OwningComp, BUS_GSEventCollection _VictimBE)
		{
			VictimChr = _VictimChr;
			OwningComp = _OwningComp;
			VictimBE = _VictimBE;
		}

		public virtual void CalculationProcessForHitPerformType(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, ref List<EHitPerformFXEventType> HitPerformFXEventTypeList, ref List<EHitPerformAudioEventType> HitPerformAudioEventTypeList, in FSkillDamageConfig SkillDamageConfig)
		{
		}

		public abstract EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig);

		public abstract void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq);
	}

	private class BeAttackedEvent_ExitRiding : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_ExitRiding;

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (BGU_DataUtil.GetActorType(VictimChr) == BGU_ActorType.CharacterPlayer)
			{
				IBPC_PlayerTagData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBPC_PlayerTagData, BPC_PlayerTagData>(VictimChr.PlayerState);
				if (readOnlyData != null && readOnlyData.HasTag(EBGPPlayerTag.Transforming) && VictimChr.IsLocallyControlled())
				{
					if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.RidingExitingStatus))
					{
						return EBeAttackedEvent.ExitRidingHit;
					}
					FUStPlayerTransUnitConfDesc fUStPlayerTransUnitConfDesc = BGW_GameDB.GetFUStPlayerTransUnitConfDesc(VictimChr.GetResID());
					if (fUStPlayerTransUnitConfDesc != null && fUStPlayerTransUnitConfDesc.TransBackBeHit > 0)
					{
						return EBeAttackedEvent.ExitRiding;
					}
				}
			}
			return EBeAttackedEvent.Nothing;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			if (CurrentEvent == EBeAttackedEvent.ExitRiding && BGU_DataUtil.GetActorType(VictimChr) == BGU_ActorType.CharacterPlayer && VictimChr.IsLocallyControlled())
			{
				BPS_GSEventCollection.Get(VictimChr?.PlayerState)?.Evt_TriggerPlayerTransEnd.Invoke(EPlayerTransEndType.BeatBack, default(PlayerTransParam));
			}
		}
	}

	private class BeAttackedEvent_PhaseTran : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_PhaseTran;

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.InPhaseTransition))
			{
				return EBeAttackedEvent.Nothing;
			}
			return EBeAttackedEvent.PhaseTran;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
		}
	}

	private class BeAttackedEvent_Dead : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_Dead;

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.CantBeDead) || OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.CantBeDead1HP) || OwningComp.GlobalVariableData.bAllUnitCannotDead)
			{
				return EBeAttackedEvent.Nothing;
			}
			if (OwningComp.VictimAttrCon.GetFloatValue(EBGUAttrFloat.Hp) <= 0f)
			{
				return EBeAttackedEvent.Dead;
			}
			return EBeAttackedEvent.Nothing;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			if (CurrentEvent != EBeAttackedEvent.Dead)
			{
				return;
			}
			EDeadReason deadReason = ((SkillDamageConfig.DmgReason == EDamageReason.DeadZone) ? EDeadReason.DeadZone : ((SkillDamageConfig.DmgReason == EDamageReason.FallDmg) ? EDeadReason.FallDead : EDeadReason.SkillDamage));
			bool bIsDotDmg = SkillDamageConfig.DamageCalcType == EDamageCalcType.ElemDot;
			int dmgID = ((EffectInstReq.TriggerSkillId <= 0) ? SkillDamageConfig.DmgReasonEffectID : EffectInstReq.TriggerSkillId);
			if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing))
			{
				if (OwningComp.VictimUnitStateData.HasState(EBGUUnitState.InAnimationSyncDeathWindow))
				{
					VictimBE.Evt_UnitDead.Invoke(Attacker, deadReason, dmgID, DamageDynamicParam.StiffLevel, null, EffectInstReq, bIsDotDmg, DamageDescParam.ElemAtkType);
					BUS_EventCollectionCS.Get(Attacker)?.Evt_StopSkillSequence.Invoke();
					BGS_EventCollectionCS.Get(Attacker)?.Evt_BGS_EndSyncAnimation.Invoke(VictimChr, bHostOrGuest: false);
				}
				else
				{
					VictimBE.Evt_SetPendingDeathInASS.Invoke(Attacker, DamageDynamicParam.StiffLevel, dmgID, bIsSummon: false, EffectInstReq);
				}
			}
			else
			{
				int partMappingBeAttackedInfoID = OwningComp.GetPartMappingBeAttackedInfoID(OwningComp.VictimBeAttackData.GetCurrentBeAttackedInfoID(), DamageDynamicParam.HitPartID);
				bool HasValidConfigOrData;
				UAnimMontage montagePathByRule = OwningComp.GetMontagePathByRule(partMappingBeAttackedInfoID, DamageDynamicParam.StiffLevel, DamageDynamicParam.AttackerArea, EffectInstReq.HitActionDir, DamageDynamicParam.NowUseUBAConfig, out HasValidConfigOrData);
				VictimBE.Evt_UnitDead.Invoke(Attacker, deadReason, dmgID, DamageDynamicParam.StiffLevel, montagePathByRule, EffectInstReq, bIsDotDmg);
			}
		}
	}

	private class BeAttackedEvent_LifeSaving : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_LifeSaving;

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.CantBeDead) || OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.CantBeDead1HP) || OwningComp.GlobalVariableData.bAllUnitCannotDead)
			{
				return EBeAttackedEvent.Nothing;
			}
			if (OwningComp.VictimAttrCon.GetFloatValue(EBGUAttrFloat.Hp) > 0f)
			{
				return EBeAttackedEvent.Nothing;
			}
			if (CanUseLifeSavingHair(in SkillDamageConfig))
			{
				return EBeAttackedEvent.LifeSaving;
			}
			return EBeAttackedEvent.Nothing;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			if (CurrentEvent != EBeAttackedEvent.LifeSaving)
			{
				return;
			}
			VictimBE?.Evt_LifeSavingHair_PendingStart.Invoke();
			if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing))
			{
				if (OwningComp.VictimUnitStateData.HasState(EBGUUnitState.InAnimationSyncDeathWindow))
				{
					TriggerLifeSaving(Attacker, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in EffectInstReq);
					BUS_EventCollectionCS.Get(Attacker)?.Evt_StopSkillSequence.Invoke();
					BGS_EventCollectionCS.Get(Attacker)?.Evt_BGS_EndSyncAnimation.Invoke(VictimChr, bHostOrGuest: false);
				}
				else
				{
					VictimBE.Evt_SetPendingLifeSavingInASS.Invoke(Attacker, DamageDynamicParam.StiffLevel, EffectInstReq);
				}
			}
			else
			{
				FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(DamageDescParam.AttackStiffEffectID, Attacker);
				if (skillEffectDesc != null && Attacker != null && OwningComp.CheckCanRotate(DamageDynamicParam.StiffLevel, DamageDynamicParam.NowUseUBAConfig))
				{
					BGUFuncLibBeAttackedAndUnitDeathDispCS.RotateToTargetActor(Attacker, VictimChr, DamageDynamicParam.AttackerArea, 0f, skillEffectDesc.HitOrientationType, skillEffectDesc.HitOriBaseCompName, in EffectInstReq);
				}
				TriggerLifeSaving(Attacker, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in EffectInstReq);
			}
		}

		private void TriggerLifeSaving(AActor Attacker, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			bool bIsDotDmg = SkillDamageConfig.DamageCalcType == EDamageCalcType.ElemDot;
			int partMappingBeAttackedInfoID = OwningComp.GetPartMappingBeAttackedInfoID(OwningComp.VictimBeAttackData.GetCurrentBeAttackedInfoID(), DamageDynamicParam.HitPartID);
			bool HasValidConfigOrData;
			UAnimMontage montagePathByRule = OwningComp.GetMontagePathByRule(partMappingBeAttackedInfoID, DamageDynamicParam.StiffLevel, DamageDynamicParam.AttackerArea, EffectInstReq.HitActionDir, DamageDynamicParam.NowUseUBAConfig, out HasValidConfigOrData);
			VictimBE?.Evt_FakeDeadForSkillDamage.Invoke(Attacker, DamageDynamicParam.StiffLevel, montagePathByRule, in EffectInstReq, bIsDotDmg, DamageDescParam.ElemAtkType);
		}

		public bool CanUseLifeSavingHair(in FSkillDamageConfig SkillDamageConfig)
		{
			if (OwningComp == null || OwningComp.VictimLifeSavingData == null || !OwningComp.VictimLifeSavingData.CanUseLifeSavingHair(OwningComp.VictimUnitStateData, OwningComp.VictimSimpleStateData))
			{
				return false;
			}
			IBIC_DeathData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_DeathData, BIC_DeathData>(OwningComp.Owner);
			if (gameInstanceReadonlyData != null && gameInstanceReadonlyData.bAllUnitCannotDead)
			{
				return false;
			}
			if (SkillDamageConfig.DmgReason == EDamageReason.DeadZone || SkillDamageConfig.DmgReason == EDamageReason.FallDmg)
			{
				return false;
			}
			return true;
		}
	}

	private class BeAttackedEvent_AnimationSyncing : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_AnimationSyncing;

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.InAnimationSyncing))
			{
				return EBeAttackedEvent.Nothing;
			}
			return EBeAttackedEvent.AnimationSyncing;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
		}
	}

	private class BeAttackedEvent_PartHit : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_PartHit;

		public override void CalculationProcessForHitPerformType(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, ref List<EHitPerformFXEventType> HitPerformFXEventTypeList, ref List<EHitPerformAudioEventType> HitPerformAudioEventTypeList, in FSkillDamageConfig SkillDamageConfig)
		{
			int hitPartID = DamageDynamicParam.HitPartID;
			if (CheckPartIsBreak(hitPartID) && SkillDamageConfig.DamageCalcType == EDamageCalcType.Normal)
			{
				HitPerformFXEventTypeList.Add(EHitPerformFXEventType.PartBreakHit);
				HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.PartBreakHit);
			}
		}

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			int hitPartID = DamageDynamicParam.HitPartID;
			if (CheckPartIsBreak(hitPartID) && SkillDamageConfig.DamageCalcType == EDamageCalcType.Normal)
			{
				return EBeAttackedEvent.PartBreak;
			}
			return EBeAttackedEvent.Nothing;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			if (CurrentEvent == EBeAttackedEvent.PartBreak)
			{
				OwningComp.SolveBreakPartLogic(DamageDynamicParam.HitPartID, Attacker, DamageDynamicParam.AttackerArea);
			}
		}

		private bool CheckPartIsBreak(int HitPartID)
		{
			if (HitPartID != -1 && OwningComp.VictimPartMgrData.IsPartActive(HitPartID) && OwningComp.VictimPartMgrData.IsPartBreakInCurrentStage(HitPartID) && !OwningComp.VictimPartMgrData.IsPartCompletelyBreak(HitPartID) && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueStiff))
			{
				return true;
			}
			return false;
		}
	}

	private class BeAttackedEvent_ImmobilizedHit : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_ImmobilizedHit;

		public override void CalculationProcessForHitPerformType(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, ref List<EHitPerformFXEventType> HitPerformFXEventTypeList, ref List<EHitPerformAudioEventType> HitPerformAudioEventTypeList, in FSkillDamageConfig SkillDamageConfig)
		{
			if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
			{
				if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance) && OwningComp.VictimBeImmobilizedData.CurrentImmobilizeHP - (FinalDamageValue + DamageDescParam.ImmobilizeHit) <= 0f)
				{
					HitPerformFXEventTypeList.Add(EHitPerformFXEventType.ImmobilizedBreakHit);
					HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.ImmobilizedBreakHit);
				}
				else
				{
					HitPerformFXEventTypeList.Add(EHitPerformFXEventType.ImmobilizedHit);
					HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.ImmobilizedHit);
				}
			}
		}

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
			{
				if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance))
				{
					VictimBE?.Evt_HitWhenInImmobilized.Invoke(FinalDamageValue + DamageDescParam.ImmobilizeHit);
					if (OwningComp.VictimBeImmobilizedData.CurrentImmobilizeHP <= 0f)
					{
						return EBeAttackedEvent.ImmobilizedBreak;
					}
				}
				return EBeAttackedEvent.ImmobilizedHit;
			}
			return EBeAttackedEvent.Nothing;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			if (CurrentEvent == EBeAttackedEvent.ImmobilizedBreak)
			{
				OwningComp.SolveBreakImmobilized(Attacker, in DamageDynamicParam, in DamageDescParam, in EffectInstReq, in SkillDamageConfig);
			}
		}
	}

	private class BeAttackedEvent_FrozenHit : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_FrozenHit;

		public override void CalculationProcessForHitPerformType(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, ref List<EHitPerformFXEventType> HitPerformFXEventTypeList, ref List<EHitPerformAudioEventType> HitPerformAudioEventTypeList, in FSkillDamageConfig SkillDamageConfig)
		{
			if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
			{
				if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance) && OwningComp.VictimAbnormalStateData.CurrentFrozenBrokenAccHP - FinalDamageValue <= 0f)
				{
					HitPerformFXEventTypeList.Add(EHitPerformFXEventType.FrozenBreakHit);
					HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.FrozenBreakHit);
				}
				else
				{
					HitPerformFXEventTypeList.Add(EHitPerformFXEventType.FrozenHit);
					HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.FrozenHit);
				}
			}
		}

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
			{
				if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance))
				{
					if (DamageDescParam.BreakFrozenImmediatelyFlag)
					{
						return EBeAttackedEvent.FrozenBreak;
					}
					VictimBE?.Evt_HitWhenInFrozen.Invoke(FinalDamageValue);
					if (OwningComp.VictimAbnormalStateData.CurrentFrozenBrokenAccHP <= 0f)
					{
						return EBeAttackedEvent.FrozenBreak;
					}
				}
				return EBeAttackedEvent.FrozenHit;
			}
			return EBeAttackedEvent.Nothing;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			if (CurrentEvent == EBeAttackedEvent.FrozenBreak)
			{
				OwningComp.SolveBreakFrozen(Attacker, in DamageDynamicParam, in DamageDescParam, in EffectInstReq, in SkillDamageConfig);
			}
		}
	}

	private class BeAttackedEvent_SkillSuperArmorHit : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_SkillSuperArmorHit;

		public override void CalculationProcessForHitPerformType(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, ref List<EHitPerformFXEventType> HitPerformFXEventTypeList, ref List<EHitPerformAudioEventType> HitPerformAudioEventTypeList, in FSkillDamageConfig SkillDamageConfig)
		{
			if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.SkillSuperArmor))
			{
				return;
			}
			if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance) && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueStiff))
			{
				float num = OwningComp.VictimAttrCon.GetFloatValue(EBGUAttrFloat.SkillSuperArmor) - DamageDescParam.SkillArmorHit;
				if (DamageDescParam.SkillArmorHit > 0f && num <= 0f)
				{
					HitPerformFXEventTypeList.Add(EHitPerformFXEventType.SkillSurperArmorBreakHit);
					HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.SkillSurperArmorBreakHit);
					return;
				}
			}
			HitPerformFXEventTypeList.Add(EHitPerformFXEventType.SkillSurperArmorHit);
			HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.SkillSurperArmorHit);
		}

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.SkillSuperArmor))
			{
				if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance) && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueStiff))
				{
					float num = OwningComp.VictimAttrCon.GetFloatValue(EBGUAttrFloat.SkillSuperArmor) - DamageDescParam.SkillArmorHit;
					VictimBE?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.SkillSuperArmor, 0f - DamageDescParam.SkillArmorHit);
					if (DamageDescParam.SkillArmorHit > 0f && num <= 0f)
					{
						return EBeAttackedEvent.SkillSuperArmorBreak;
					}
				}
				return EBeAttackedEvent.SkillSuperArmorHit;
			}
			return EBeAttackedEvent.Nothing;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			if (CurrentEvent == EBeAttackedEvent.SkillSuperArmorBreak)
			{
				OwningComp.SolveBreakSuperSkillArmorLogic(Attacker, in DamageDynamicParam, in DamageDescParam, in EffectInstReq, in SkillDamageConfig);
			}
		}
	}

	private class BeAttackedEVent_BlockArmorHit : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEVent_BlockArmorHit;

		public override void CalculationProcessForHitPerformType(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, ref List<EHitPerformFXEventType> HitPerformFXEventTypeList, ref List<EHitPerformAudioEventType> HitPerformAudioEventTypeList, in FSkillDamageConfig SkillDamageConfig)
		{
			if (OwningComp.VictimUnitStateData.HasState(EBGUUnitState.BlockBeatBack) || OwningComp.VictimUnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack))
			{
				if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance))
				{
					float floatValue = OwningComp.VictimAttrCon.GetFloatValue(EBGUAttrFloat.BlockCollapseArmor);
					if (!OwningComp.VictimUnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack))
					{
						float num = floatValue - DamageDescParam.BlockArmorHit;
						if (DamageDescParam.BlockArmorHit > 0f && num <= 0f)
						{
							HitPerformFXEventTypeList.Add(EHitPerformFXEventType.BlockArmorBreakHit);
							HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.BlockArmorBreakHit);
							return;
						}
					}
					else
					{
						OwningComp.VictimArmorData.GetCurrentBlockInfoConfig(out var _NowUseBlockInfoConfig);
						if (_NowUseBlockInfoConfig != null)
						{
							List<FPerfectBlockDamageInfo> perfectBlockDamageInfoList = _NowUseBlockInfoConfig.PerfectBlockInfoWarp.PerfectBlockDamageInfoList;
							if (perfectBlockDamageInfoList != null && perfectBlockDamageInfoList.Count > 0)
							{
								float num2 = 0f;
								FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(DamageDescParam.AttackStiffEffectID, Attacker);
								if (skillEffectDesc != null && skillEffectDesc.EffectParamsFloat.Count > 0)
								{
									num2 = skillEffectDesc.EffectParamsFloat[0];
								}
								foreach (FPerfectBlockDamageInfo item in perfectBlockDamageInfoList)
								{
									if ((float)item.TriggerDeductPerfectBlockValueHitWeight == num2)
									{
										int deductPerfectBlockValueRadio = item.DeductPerfectBlockValueRadio;
										float num3 = DamageDescParam.BlockArmorHit * (float)deductPerfectBlockValueRadio / 10000f;
										float num4 = floatValue - num3;
										if (num3 > 0f && num4 <= 0f)
										{
											HitPerformFXEventTypeList.Add(EHitPerformFXEventType.BlockArmorBreakHit);
											HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.BlockArmorBreakHit);
											return;
										}
										break;
									}
								}
							}
						}
					}
				}
				HitPerformFXEventTypeList.Add(OwningComp.VictimUnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack) ? EHitPerformFXEventType.PerfectBlockArmorHit : EHitPerformFXEventType.BlockArmorHit);
				HitPerformAudioEventTypeList.Add(OwningComp.VictimUnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack) ? EHitPerformAudioEventType.PerfectBlockArmorHit : EHitPerformAudioEventType.BlockArmorHit);
			}
			else
			{
				if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BreakBlock))
				{
					return;
				}
				OwningComp.VictimArmorData.GetCurrentBlockInfoConfig(out var _NowUseBlockInfoConfig2);
				if (_NowUseBlockInfoConfig2 != null)
				{
					float num5 = 0f;
					FUStSkillEffectDesc skillEffectDesc2 = BGW_GameDB.GetSkillEffectDesc(DamageDescParam.AttackStiffEffectID, Attacker);
					if (skillEffectDesc2 != null && skillEffectDesc2.EffectParamsFloat.Count > 0)
					{
						num5 = skillEffectDesc2.EffectParamsFloat[0];
					}
					if ((float)(OwningComp.VictimArmorData.CheckIsInPerfectBlock() ? _NowUseBlockInfoConfig2.PerfectBlockInfoWarp.TriggerBlock2WeakMinHitWeight : _NowUseBlockInfoConfig2.NormalBlockInfoWarp.TriggerBlock2WeakMinHitWeight) <= num5)
					{
						HitPerformFXEventTypeList.Add(EHitPerformFXEventType.BlockArmorBreak2WeakHit);
						HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.BlockArmorBreak2WeakHit);
					}
				}
			}
		}

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BreakBlock))
			{
				OwningComp.VictimArmorData.GetCurrentBlockInfoConfig(out var _NowUseBlockInfoConfig);
				if (_NowUseBlockInfoConfig != null)
				{
					float num = 0f;
					FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(DamageDescParam.AttackStiffEffectID, Attacker);
					if (skillEffectDesc != null && skillEffectDesc.EffectParamsFloat.Count > 0)
					{
						num = skillEffectDesc.EffectParamsFloat[0];
					}
					if (!((float)(OwningComp.VictimArmorData.CheckIsInPerfectBlock() ? _NowUseBlockInfoConfig.PerfectBlockInfoWarp.TriggerBlock2WeakMinHitWeight : _NowUseBlockInfoConfig.NormalBlockInfoWarp.TriggerBlock2WeakMinHitWeight) <= num))
					{
						return EBeAttackedEvent.BlockArmorHit;
					}
					return EBeAttackedEvent.BlockArmorBreak2Weak;
				}
			}
			else
			{
				if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BreakBlock2Weak))
				{
					return EBeAttackedEvent.BlockArmorHit;
				}
				if (OwningComp.VictimUnitStateData.HasState(EBGUUnitState.BlockBeatBack) || OwningComp.VictimUnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack))
				{
					if (!OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance))
					{
						float floatValue = OwningComp.VictimAttrCon.GetFloatValue(EBGUAttrFloat.BlockCollapseArmor);
						if (!OwningComp.VictimUnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack))
						{
							float num2 = floatValue - DamageDescParam.BlockArmorHit;
							VictimBE?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.BlockCollapseArmor, 0f - DamageDescParam.BlockArmorHit);
							if (DamageDescParam.BlockArmorHit > 0f && num2 <= 0f)
							{
								return EBeAttackedEvent.BlockArmorBreak;
							}
						}
						else
						{
							OwningComp.VictimArmorData.GetCurrentBlockInfoConfig(out var _NowUseBlockInfoConfig2);
							if (_NowUseBlockInfoConfig2 != null)
							{
								List<FPerfectBlockDamageInfo> perfectBlockDamageInfoList = _NowUseBlockInfoConfig2.PerfectBlockInfoWarp.PerfectBlockDamageInfoList;
								if (perfectBlockDamageInfoList != null && perfectBlockDamageInfoList.Count > 0)
								{
									float num3 = 0f;
									FUStSkillEffectDesc skillEffectDesc2 = BGW_GameDB.GetSkillEffectDesc(DamageDescParam.AttackStiffEffectID, Attacker);
									if (skillEffectDesc2 != null && skillEffectDesc2.EffectParamsFloat.Count > 0)
									{
										num3 = skillEffectDesc2.EffectParamsFloat[0];
									}
									foreach (FPerfectBlockDamageInfo item in perfectBlockDamageInfoList)
									{
										if (Math.Abs((float)item.TriggerDeductPerfectBlockValueHitWeight - num3) < 0.01f)
										{
											int deductPerfectBlockValueRadio = item.DeductPerfectBlockValueRadio;
											float num4 = DamageDescParam.BlockArmorHit * (float)deductPerfectBlockValueRadio / 10000f;
											float num5 = floatValue - num4;
											VictimBE?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.BlockCollapseArmor, 0f - num4);
											if (num4 > 0f && num5 <= 0f)
											{
												return EBeAttackedEvent.BlockArmorBreak;
											}
											break;
										}
									}
								}
							}
						}
					}
					return EBeAttackedEvent.BlockArmorHit;
				}
				if (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.CanTriggerBlockNormal) && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance))
				{
					OwningComp.VictimArmorData.GetCurrentBlockInfoConfig(out var _NowUseBlockInfoConfig3);
					if (_NowUseBlockInfoConfig3 != null)
					{
						float num6 = 0f;
						foreach (FBeAttackedBlockDamageInfo item2 in _NowUseBlockInfoConfig3.BeAttackedBlockInfoWarp.BeAttackedBlockDamageInfo)
						{
							if (Math.Abs((float)item2.TriggerDeductBlockArmorLevel - DamageDynamicParam.HitWeight) < 0.01f)
							{
								num6 = item2.DeductBlockArmorValue;
								break;
							}
							if (num6 == 0f && item2.TriggerDeductBlockArmorLevel == -1)
							{
								num6 = item2.DeductBlockArmorValue;
							}
						}
						float num7 = 0f;
						int num8 = -1;
						if ((OwningComp.CanTriggerNormalStiff() && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.SkillSuperArmor) && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Frozen)) || OwningComp.IsSuperArmorBreak() || (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && OwningComp.VictimBeImmobilizedData.CurrentImmobilizeHP <= 0f) || (OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) && OwningComp.VictimAbnormalStateData.CurrentFrozenBrokenAccHP <= 0f))
						{
							num8 = DamageDynamicParam.StiffLevel;
						}
						foreach (FBeAttackedBlockDamageInfo item3 in _NowUseBlockInfoConfig3.BeAttackedBlockInfoWarp.BeAttackedBlockDamageInfoByStiffLevel)
						{
							if (item3.TriggerDeductBlockArmorLevel == num8)
							{
								num7 = item3.DeductBlockArmorValue;
								break;
							}
							if (num7 == 0f && item3.TriggerDeductBlockArmorLevel == -1)
							{
								num7 = item3.DeductBlockArmorValue;
							}
						}
						num6 += num7;
						if (num6 > 0f)
						{
							float num9 = OwningComp.VictimAttrCon.GetFloatValue(EBGUAttrFloat.BlockCollapseArmor) - num6;
							VictimBE?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.BlockCollapseArmor, 0f - num6);
							if (num9 <= 0f)
							{
								return EBeAttackedEvent.BlockArmorBreak;
							}
						}
					}
				}
			}
			return EBeAttackedEvent.Nothing;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			if (CurrentEvent == EBeAttackedEvent.BlockArmorHit || CurrentEvent == EBeAttackedEvent.BlockArmorBreak || CurrentEvent == EBeAttackedEvent.BlockArmorBreak2Weak)
			{
				OwningComp.SolveBlockRelatedLogic(CurrentEvent, Attacker, (int)DamageDescParam.HitWeight, EffectInstReq.HitActionDir);
			}
		}
	}

	private class BeAttackedEvent_FightBack : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_FightBack;

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (!DamageDescParam.bCanTriggerFightBackCounter)
			{
				return EBeAttackedEvent.Nothing;
			}
			if (OwningComp.VictimArmorData.CanTriggerAddCounterAttackTimes(EFightBackCountType.BeHitCount) && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance) && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.SkillSuperArmor))
			{
				VictimBE?.Evt_AddCounterAttackTimes.Invoke();
				if (!OwningComp.VictimChargeSkillData.IsCastingChargeSkill && OwningComp.VictimArmorData.CanTriggerCounterFightBack())
				{
					return EBeAttackedEvent.FightBack;
				}
			}
			return EBeAttackedEvent.Nothing;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			if (OwningComp.VictimArmorData.IsInPreHRCounterattacking() && CurrentEvent < EBeAttackedEvent.SkillSuperArmorHit)
			{
				VictimBE?.Evt_ResetCounterAttack.Invoke();
			}
			if (CurrentEvent == EBeAttackedEvent.FightBack && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.SkillSuperArmor))
			{
				OwningComp.SolveCounterAttack();
			}
		}
	}

	private class BeAttackedEvent_NormalStiff : BeAttackedEventBase
	{
		public override FName BeAttackedEventName => B1GlobalFNames.BeAttackedEvent_NormalStiff;

		public override EBeAttackedEvent NumericalCalculationProcess(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig)
		{
			if (!OwningComp.CanTriggerNormalStiff())
			{
				return EBeAttackedEvent.Nothing;
			}
			return EBeAttackedEvent.NormalStiff;
		}

		public override void EventSettlementProcess(AActor Attacker, EBeAttackedEvent CurrentEvent, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq)
		{
			if ((CurrentEvent == EBeAttackedEvent.NormalStiff || CurrentEvent == EBeAttackedEvent.FightBack) && DamageDescParam.AttackStiffEffectID > 0 && !OwningComp.VictimSimpleStateData.HasSimpleState(EBGUSimpleState.SkillSuperArmor))
			{
				OwningComp.SolveNormalStiff(Attacker, in DamageDynamicParam, in DamageDescParam, in EffectInstReq, in SkillDamageConfig, CurrentEvent);
			}
		}
	}

	private enum EBeatbackAMResultCheck : byte
	{
		None,
		Pending,
		Success,
		Fail
	}

	private BUC_UnitBeAttackedFequenceData VictimUnitBeAttackedFequeceData;

	private BUC_BeAttackData VictimBeAttackData;

	private IBUC_AttrContainer VictimAttrCon;

	private IBUC_UnitStateData VictimUnitStateData;

	private IBUC_SimpleStateData VictimSimpleStateData;

	private IBUC_ArmorData VictimArmorData;

	private IBUC_PartMgrData VictimPartMgrData;

	private IBUC_MandatoryAITaskData VictimMandatoryAITaskData;

	private IBUC_FallDyingData VictimFallDyingData;

	private b1.IBUC_LifeSavingData VictimLifeSavingData;

	private IBUC_BeImmobilizedData VictimBeImmobilizedData;

	private IBUC_AbnormalStateData VictimAbnormalStateData;

	private IBUC_ChargeSkillData VictimChargeSkillData;

	private IBUC_AIData VictimAIData;

	private IBUC_GuidData VictimGuidData;

	private IBUC_BuffData VictimBuffData;

	private IBGC_LocalPlayerSharedData LocalPlayerSharedData;

	private IBGC_TeamRelationData TeamRelationData;

	private IBIC_DeathData GlobalVariableData;

	private IBIC_LevelData LevelData;

	private IBIC_BossRushData BossRushData;

	private IBPC_PlayerRoleData PlayerRoleData;

	private List<BeAttackedEventBase> BeAttackedEventTemplateList;

	private const float INV10000 = 0.0001f;

	private const float RATIO = 10000f;

	private EBeatbackAMResultCheck BeatbackAMResultCheck;

	public override void OnAttach()
	{
		VictimUnitBeAttackedFequeceData = RequireWritableData<BUC_UnitBeAttackedFequenceData>();
		VictimBeAttackData = RequireWritableData<BUC_BeAttackData>();
		VictimAttrCon = RequireReadOnlyData<IBUC_AttrContainer, BUC_AttrContainer>();
		VictimUnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
		VictimSimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		VictimArmorData = RequireReadOnlyData<IBUC_ArmorData, BUC_ArmorData>();
		VictimPartMgrData = RequireReadOnlyData<IBUC_PartMgrData, BUC_PartMgrData>();
		VictimMandatoryAITaskData = RequireReadOnlyData<IBUC_MandatoryAITaskData, BUC_MandatoryAITaskData>();
		VictimFallDyingData = RequireReadOnlyData<IBUC_FallDyingData, BUC_FallDyingData>();
		VictimLifeSavingData = RequireReadOnlyData<b1.IBUC_LifeSavingData, BUC_LifeSavingData>();
		VictimBeImmobilizedData = RequireReadOnlyData<IBUC_BeImmobilizedData, BUC_BeImmobilizedData>();
		VictimAbnormalStateData = RequireReadOnlyData<IBUC_AbnormalStateData, BUC_AbnormalStateData>();
		VictimChargeSkillData = RequireReadOnlyData<IBUC_ChargeSkillData, BUC_ChargeSkillData>();
		VictimAIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		VictimGuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
		VictimBuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		LocalPlayerSharedData = RequireReadOnlyGameStateData<IBGC_LocalPlayerSharedData, BGC_LocalPlayerSharedData>();
		TeamRelationData = RequireReadOnlyGameStateData<IBGC_TeamRelationData, BGC_TeamRelationData>();
		GlobalVariableData = RequireReadonlyGameInstanceData<IBIC_DeathData, BIC_DeathData>();
		LevelData = RequireReadonlyGameInstanceData<IBIC_LevelData, BIC_LevelData>();
		BossRushData = RequireReadonlyGameInstanceData<IBIC_BossRushData, BIC_BossRushData>();
		PlayerRoleData = RequireReadOnlyLocalPlayerControlData<IBPC_PlayerRoleData, BPC_PlayerRoleData>();
		base.BUSEventCollection.Evt_TriggerNormalDamageEffect.Predict += new GSDel_TriggerNormalDamageEffect_IPK_Del.Del_Predict(OnHandleNormalDamageEffect_Predict);
		base.BUSEventCollection.Evt_TriggerNormalDamageEffect.Cue += new GSDel_TriggerNormalDamageEffect_IPK_Del.Del_Predict(OnHandleNormalDamageEffect_Cue);
		base.BUSEventCollection.Evt_TriggerNormalDamageEffect.RollBack += new GSDel_TriggerNormalDamageEffect_IPK_Del.Del_Predict(OnHandleNormalDamageEffect_RollBack);
		base.BUSEventCollection.Evt_MarkBeAttackedProtectTime += new Del_MarkBeAttackedWarnningProtectTime(OnMarkBeAttackedProtectTime);
		base.BUSEventCollection.Evt_SetNewBeAttackedInfoID += new Del_Void_Int(OnSetNewBeAttackedInfoID);
		base.BUSEventCollection.Evt_ResetBeAttackedInfoID += new Del_Void(OnResetBeAttackedInfoID);
		base.BUSEventCollection.Evt_SetTriggerMontage += new Del_Void_Bool(OnSetTriggerMontage);
		base.BUSEventCollection.Evt_PlayMontageCallback += new Del_PlayMontageCallback(OnPlayMontageCallback);
	}

	public override void PreBeginPlay()
	{
		if (GetOwner() == null)
		{
			return;
		}
		OnResetBeAttackedInfoID();
		BeAttackedEventTemplateList = new List<BeAttackedEventBase>
		{
			new BeAttackedEvent_ExitRiding(),
			new BeAttackedEvent_PhaseTran(),
			new BeAttackedEvent_Dead(),
			new BeAttackedEvent_AnimationSyncing(),
			new BeAttackedEvent_LifeSaving(),
			new BeAttackedEvent_PartHit(),
			new BeAttackedEvent_ImmobilizedHit(),
			new BeAttackedEvent_FrozenHit(),
			new BeAttackedEvent_SkillSuperArmorHit(),
			new BeAttackedEVent_BlockArmorHit(),
			new BeAttackedEvent_FightBack(),
			new BeAttackedEvent_NormalStiff()
		};
		foreach (BeAttackedEventBase beAttackedEventTemplate in BeAttackedEventTemplateList)
		{
			beAttackedEventTemplate?.Init(OwnerAsCharacterCS, this, base.BUSEventCollection);
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		VictimUnitBeAttackedFequeceData.UpdateCheckBeAttackedFequenceData(DeltaTime);
		if (VictimBeAttackData.CurrentBeAttackedStiffLevel > 0 && !VictimUnitStateData.HasState(EBGUUnitState.Beatback))
		{
			VictimBeAttackData.CurrentBeAttackedStiffLevel = -1;
			VictimBeAttackData.CurrentBeAttackedAttackerGUID = "";
		}
	}

	private void HandleNormalDamageEffectPerform(AActor Attacker, AActor AtkerMasterActor, bool IsTriggerByMagicField, bool IsCrit, float DmgNoiseMul, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData)
	{
		List<EHitPerformFXEventType> HitPerformFXEventTypeList = new List<EHitPerformFXEventType> { (!IsCrit) ? EHitPerformFXEventType.NormalHit : EHitPerformFXEventType.CritHit };
		List<EHitPerformAudioEventType> HitPerformAudioEventTypeList = new List<EHitPerformAudioEventType> { (!IsCrit) ? EHitPerformAudioEventType.NormalHit : EHitPerformAudioEventType.CritHit };
		float FinalDamageValue = 0f;
		float FinalNonElementDmgValue = 0f;
		float FinalElementDmgValue = 0f;
		bool hasCausedDamage = false;
		if (IsDamageValid(in SkillDamageConfig))
		{
			hasCausedDamage = true;
			CalcDmgValueOnly(Attacker, IsCrit, DmgNoiseMul, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in Attacker_AttrMemData, out FinalDamageValue, out var _, out var _, out FinalElementDmgValue, out FinalNonElementDmgValue, bPrintLog: false);
		}
		foreach (BeAttackedEventBase beAttackedEventTemplate in BeAttackedEventTemplateList)
		{
			beAttackedEventTemplate.CalculationProcessForHitPerformType(Attacker, FinalDamageValue, in DamageDynamicParam, in DamageDescParam, ref HitPerformFXEventTypeList, ref HitPerformAudioEventTypeList, in SkillDamageConfig);
		}
		FUStBeAttackedInfoDesc beAttackedInfoDesc = BGW_GameDB.GetBeAttackedInfoDesc(VictimBeAttackData.GetCurrentBeAttackedInfoID());
		if (beAttackedInfoDesc != null && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Frozen) && SkillDamageConfig.DamageCalcType == EDamageCalcType.Normal && !DamageDescParam.bIgnoreBeAttacked)
		{
			int unitBeAttackedBlendType = beAttackedInfoDesc.UnitBeAttackedBlendType;
			if ((unitBeAttackedBlendType & 1) != 0)
			{
				base.BUSEventCollection?.Evt_PlayBeAttackedPhysAnim.Invoke(DamageDynamicParam.StiffLevel, EffectInstReq, beAttackedInfoDesc.PhysAnimImpulseScale);
			}
			if ((unitBeAttackedBlendType & 2) != 0)
			{
				base.BUSEventCollection?.Evt_PlayBeAttackedAdditiveAnim.Invoke(BGUFuncLibBeAttackedAndUnitDeathDispCS.GetHitActionDirVector(EffectInstReq.HitActionDir));
			}
			if ((unitBeAttackedBlendType & 4) != 0)
			{
				FTransform hitTransform = new FTransform(EffectInstReq.HitPointNormalDir, EffectInstReq.HitLocation);
				base.BUSEventCollection?.Evt_TriggerAttachBehitComp.Invoke(EffectInstReq.ObjectID, 5f, DamageDynamicParam.HitWeight + 1f, hitTransform, EffectInstReq.HitDiretionRealDir, EffectInstReq.HitBoneName);
			}
			int SkillDamageExpandID;
			FUStSkillDamageExpandDesc skillDamageExpandDesc = BGW_GameDB.GetSkillDamageExpandDesc(SkillDamageConfig.DmgReasonEffectID, Attacker, out SkillDamageExpandID);
			if (skillDamageExpandDesc != null && skillDamageExpandDesc.CanTriggerScar == EGSYesNo.Yes && (unitBeAttackedBlendType & 8) != 0)
			{
				int actorResID = BGU_DataUtil.GetActorResID(Attacker);
				int actorResID2 = GetActorResID();
				int num = -1;
				Dictionary<int, FUStScarInfoDesc> allScarInfoDesc = BGW_GameDB.GetAllScarInfoDesc();
				if (allScarInfoDesc != null && allScarInfoDesc.Count > 0)
				{
					foreach (KeyValuePair<int, FUStScarInfoDesc> item in allScarInfoDesc)
					{
						FUStScarInfoDesc value = item.Value;
						if (value != null && value.AttackerResID == actorResID)
						{
							if (value.VictimResID == actorResID2)
							{
								num = item.Key;
								break;
							}
							if (value.VictimResID == 0)
							{
								num = item.Key;
							}
						}
					}
				}
				if (num >= 0)
				{
					FUStScarInfoDesc scarInfoDesc = BGW_GameDB.GetScarInfoDesc(num);
					if (scarInfoDesc != null)
					{
						bool flag = true;
						if (scarInfoDesc.ScarDecalTriggerType == EScarDecalTriggerType.Dcss)
						{
							BUC_AttrContainer readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(Attacker);
							if (readOnlyData != null && readOnlyData.GetFloatValue(EBGUAttrFloat.Pevalue) <= 0f)
							{
								flag = false;
							}
						}
						if (flag)
						{
							base.BUSEventCollection?.Evt_TriggerScarFX.Invoke(num, EffectInstReq.HitBoneName, EffectInstReq.HitLocation, EffectInstReq.HitPointNormalDir.Conv_RotatorToVector().GetSafeNormal(), EffectInstReq.HitDiretionRealDir);
						}
					}
				}
			}
		}
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.InTTTB))
		{
			base.BUSEventCollection?.Evt_TriggerTTTBEffect.Invoke(5f, DamageDynamicParam.HitWeight + 1f, EffectInstReq.HitBoneName, EffectInstReq.HitLocation, EffectInstReq.HitPointNormalDir.Conv_RotatorToVector().GetSafeNormal(), -1.0 * EffectInstReq.HitPointNormalDir.Vector().Normal());
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(AtkerMasterActor);
		bool flag2 = Attacker_AttrMemData.AttackerIsPlayer_ForDmgNumer(AtkerMasterActor);
		if (flag2)
		{
			base.BUSEventCollection?.Evt_BeAttackedByPlayer_ForUI.Invoke();
		}
		if (CanShowDmgNumUI(AtkerMasterActor, hasCausedDamage, in Attacker_AttrMemData, flag2))
		{
			EDamageNumberType inDamageType = ((!IsCrit) ? EDamageNumberType.Normal : EDamageNumberType.Critical);
			EDmgNumUITeamType attackerTeamType = ((!flag2) ? EDmgNumUITeamType.Enemy : EDmgNumUITeamType.Hero);
			int num2 = (((int)FinalDamageValue > 108000) ? 108000 : ((int)FinalDamageValue));
			bUS_GSEventCollection?.Evt_DisplayDamageNumUIV2.Invoke(new DamageNumParam(inDamageType, -num2, 1f, EffectInstReq.HitLocation, default(FVector), attackerTeamType));
		}
		int num3;
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BounceAttack) && !IsTriggerByMagicField)
		{
			num3 = ((!EffectInstReq.bFromBullet) ? 1 : 0);
			if (num3 != 0)
			{
				HitPerformFXEventTypeList.Add(EHitPerformFXEventType.ParryHit);
				HitPerformAudioEventTypeList.Add(EHitPerformAudioEventType.ParryHit);
			}
		}
		else
		{
			num3 = 0;
		}
		EHitPerformFXEventType eHitPerformFXEventType = CalcPerformPriorityRuleForFX(HitPerformFXEventTypeList);
		EHitPerformAudioEventType hitPerformAudioEventType = CalcPerformPriorityRuleForAudio(HitPerformAudioEventTypeList);
		if (num3 == 0)
		{
			SolveHitVEffectLogic(Attacker, DamageDescParam.HitVEffectID, IsCrit);
		}
		if (Owner is BGUPlayerCharacterCS && !string.IsNullOrEmpty(SkillDamageConfig.CameraShakeDA))
		{
			BGUFunctionLibraryCS.PlayCamShakeWithControl(SkillDamageConfig.CameraShakeDA, Owner);
		}
		int actorResID3 = BGU_DataUtil.GetActorResID(AtkerMasterActor);
		if (SkillDamageConfig.DmgReason == EDamageReason.Buff)
		{
			base.BUSEventCollection?.Evt_TriggerBuffDamageFX.Invoke(SkillDamageConfig.DmgReasonEffectID, actorResID3);
		}
		else
		{
			if (SkillDamageConfig.DmgReason != EDamageReason.Skill)
			{
				return;
			}
			int dmgReasonEffectID = SkillDamageConfig.DmgReasonEffectID;
			if (!VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueAttackPerformEffect))
			{
				if (DamageDescParam.bCanTriggerFX)
				{
					bUS_GSEventCollection?.Evt_AttackFeedbackPerform.Invoke(Owner, DamageDescParam.SkillDamageType, eHitPerformFXEventType, EffectInstReq, actorResID3, dmgReasonEffectID, DamageDynamicParam.HitPartID);
				}
				bUS_GSEventCollection?.Evt_PlayAttackHitAudioByRule.Invoke(Owner, EffectInstReq.AudioID_HitChr, hitPerformAudioEventType, EffectInstReq.HitLocation, EffectInstReq.HitPointNormalDir, actorResID3, DamageDynamicParam.HitPartID);
			}
			if (!VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueBeAttackedPerformEffect) && DamageDescParam.bCanTriggerFX)
			{
				base.BUSEventCollection?.Evt_BeAttackedVisualEffect.Invoke(AtkerMasterActor, DamageDescParam.SkillDamageType, eHitPerformFXEventType, EffectInstReq, dmgReasonEffectID, DamageDynamicParam.HitPartID);
			}
		}
	}

	private bool CanShowDmgNumUI(AActor AttackerMasterActor, bool HasCausedDamage, in FBattleAttrSnapShot Attacker_AttrMemData, bool AttackerIsPlayer_ForDmgNumber)
	{
		if (AttackerMasterActor.IsNullOrDestroyed())
		{
			return false;
		}
		if (!HasCausedDamage)
		{
			return false;
		}
		if (GSGameplayCVar.CVar_B1ShowDamageNumber.GetValueInGameThread() == 0)
		{
			return false;
		}
		if (LocalPlayerSharedData == null)
		{
			return false;
		}
		BGUCharacterCS bGUCharacterCS = LocalPlayerSharedData.FirstLocalPlayerPawn as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return false;
		}
		if (AttackerIsPlayer_ForDmgNumber || OwnerAsCharacterCS.GetTeamIDInCS() == bGUCharacterCS.GetTeamIDInCS())
		{
			BUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(bGUCharacterCS);
			if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.CantShowDamageUI))
			{
				return false;
			}
			BUC_SimpleStateData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(AttackerMasterActor);
			if (readOnlyData2 != null && readOnlyData2.HasSimpleState(EBGUSimpleState.DisableDamageNumUI))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	private void HandleNormalDamageEffectLogic(AActor Attacker, AActor AtkerMasterActor, bool IsTriggerByMagicField, bool IsCrit, float DmgNoiseMul, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData)
	{
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(AtkerMasterActor);
		BUC_SimpleStateData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SimpleStateData>(Attacker);
		if (readOnlyData != null && readOnlyData.HasSimpleState(EBGUSimpleState.CanDefeatTTTB))
		{
			base.BUSEventCollection?.Evt_OnRemoveIronBodyStartBuff.Invoke();
		}
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Owner);
		if (BGU_DataUtil.GetActorType(Owner) == BGU_ActorType.CharacterAI && aActor == null && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.IgnoreHostile))
		{
			base.BUSEventCollection?.Evt_AICatchTarget.Invoke(AtkerMasterActor, ETargetSourceType.Target_BeAttackedAssignAttackerAsTarget);
		}
		OnSetTriggerMontage(bIsPlay: false);
		if (IsCrit)
		{
			bUS_GSEventCollection?.Evt_NotifyTriggerBuffWhenConditionMet.Invoke(EBuffEffectTriggerType.OnCriticalHit, in EffectInstReq);
		}
		DoDamageLogic(Attacker, AtkerMasterActor, IsCrit, DmgNoiseMul, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in EffectInstReq, in Attacker_AttrMemData, out var FinalDamageValue);
		if ((SkillDamageConfig.DamageCalcType == EDamageCalcType.Normal || SkillDamageConfig.DamageCalcType == EDamageCalcType.ElemDot) && FinalDamageValue > 0f)
		{
			base.BUSEventCollection?.Evt_NotifyTriggerBuffWhenConditionMet.Invoke(EBuffEffectTriggerType.BeHurted, in EffectInstReq);
			if (DamageDescParam.ElemAtkType == EAbnormalStateType.Abnormal_Burn)
			{
				base.BUSEventCollection?.Evt_NotifyTriggerBuffWhenConditionMet.Invoke(EBuffEffectTriggerType.BeHurtedBurn, in EffectInstReq);
			}
		}
		if (BGU_DataUtil.GetActorType(Owner) == BGU_ActorType.CharacterAI)
		{
			BGUCharacterCS bGUCharacterCS = AtkerMasterActor as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				base.BUSEventCollection?.Evt_CalculateTargetHatredValueByDamage.Invoke(bGUCharacterCS, EffectInstReq.TriggerSkillId, FinalDamageValue);
			}
		}
		DoAndSolveDamageExtraLogic(Attacker, FinalDamageValue, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in EffectInstReq, out var OutBeAttackedEvent);
		bool flag = OutBeAttackedEvent == EBeAttackedEvent.Dead;
		if (!flag)
		{
			base.BUSEventCollection?.Evt_TriggerIntimidation.Invoke(DamageDynamicParam.StiffLevel, bTriggerByDead: false);
		}
		else
		{
			bUS_GSEventCollection?.Evt_OnKillVictim.Invoke(Owner);
			bUS_GSEventCollection?.Evt_NotifyTriggerBuffWhenConditionMet.Invoke(EBuffEffectTriggerType.OnKillUnit, in EffectInstReq);
		}
		bUS_GSEventCollection?.Evt_NotifyAttackerHitSuccess.Invoke(Owner, in SkillDamageConfig, in EffectInstReq, flag);
		if (SkillDamageConfig.DmgReason == EDamageReason.Skill)
		{
			bool flag2 = false;
			if (!IsTriggerByMagicField && !EffectInstReq.bFromBullet)
			{
				flag2 = VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BounceAttack);
				if (!flag2 && VictimPartMgrData.GetPartInfo(DamageDynamicParam.HitPartID, out var PartInfoOut))
				{
					FUStPartRuleInfoDesc partRuleInfoDesc = BGW_GameDB.GetPartRuleInfoDesc(PartInfoOut.DescID, Owner);
					if (partRuleInfoDesc != null)
					{
						flag2 = partRuleInfoDesc.CanTriggerAtkRebounding == EGSYesNo.Yes;
					}
				}
			}
			bUS_GSEventCollection?.Evt_AttackFeedback.Invoke(Owner, EffectInstReq.TriggerSkillId, SkillDamageConfig.DmgReasonEffectID, EffectInstReq.ObjectID, flag2);
		}
		OnBeHitSetInfo(Attacker, in DamageDescParam, in DamageDynamicParam, in SkillDamageConfig, in EffectInstReq, FinalDamageValue);
		if (DebugConfig.CricketBattleMode)
		{
			BGW_CricketBattleMgr.Get(GetOwner()).IncDPS(Attacker, (int)FinalDamageValue);
		}
	}

	private bool PackageDamageDescParam(AActor Caster, in FEffectInstReq EffectInstReq, in FSkillDamageConfig SkillDamageConfig, out FDamageDescParam DamageDescParam)
	{
		DamageDescParam = default(FDamageDescParam);
		if (SkillDamageConfig.DmgReason == EDamageReason.Skill)
		{
			if (SkillDamageConfig.DamageCalcType != EDamageCalcType.Normal)
			{
				return false;
			}
			int dmgReasonEffectID = SkillDamageConfig.DmgReasonEffectID;
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(dmgReasonEffectID, Caster);
			if (skillEffectDesc != null)
			{
				int SkillDamageExpandID;
				FUStSkillDamageExpandDesc fUStSkillDamageExpandDesc = BGW_GameDB.GetSkillDamageExpandDesc(dmgReasonEffectID, Caster, out SkillDamageExpandID);
				if (fUStSkillDamageExpandDesc == null)
				{
					fUStSkillDamageExpandDesc = new FUStSkillDamageExpandDesc();
				}
				IBUC_SuperArmorLevelMappingData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_SuperArmorLevelMappingData, BUC_SuperArmorLevelMappingData>(Caster);
				if (skillEffectDesc.EffectParamsStr.Count > 0)
				{
					float SuperArmorValue = 0f;
					if (readOnlyData != null)
					{
						SuperArmorValue = readOnlyData.GetSuperArmorLevelValue(skillEffectDesc.EffectParamsStr[0], " EffectID: " + dmgReasonEffectID, BGW_GameDB.GetSkillSToBlame(EffectInstReq.TriggerSkillId), Owner);
					}
					else
					{
						BGUFunctionLibraryCS.BGUGetSuperArmorValueByLevel(skillEffectDesc.EffectParamsStr[0], " EffectID: " + dmgReasonEffectID, BGW_GameDB.GetSkillSToBlame(EffectInstReq.TriggerSkillId), out SuperArmorValue, Owner);
					}
					if (SuperArmorValue != 0f)
					{
						DamageDescParam.SkillArmorHit = SuperArmorValue;
					}
					else if (readOnlyData != null)
					{
						DamageDescParam.SkillArmorHit = readOnlyData.GetSuperArmorValue(skillEffectDesc.EffectParamsFloat[0], " EffectID: " + dmgReasonEffectID, BGW_GameDB.GetSkillSToBlame(EffectInstReq.TriggerSkillId));
					}
					else
					{
						DamageDescParam.SkillArmorHit = skillEffectDesc.EffectParamsFloat[0];
					}
				}
				else if (readOnlyData != null)
				{
					DamageDescParam.SkillArmorHit = readOnlyData.GetSuperArmorValue(skillEffectDesc.EffectParamsFloat[0], " EffectID: " + dmgReasonEffectID, BGW_GameDB.GetSkillSToBlame(EffectInstReq.TriggerSkillId));
				}
				else
				{
					DamageDescParam.SkillArmorHit = skillEffectDesc.EffectParamsFloat[0];
				}
				DamageDescParam.HitVEffectID = skillEffectDesc.EffectParamsInt[0];
				DamageDescParam.AttackStiffEffectID = skillEffectDesc.EffectParamsInt[1];
				DamageDescParam.SkillDamageType = (ESkillDamageType)skillEffectDesc.EffectParamsInt[2];
				DamageDescParam.ElementDmgLevel = ((skillEffectDesc.EffectParamsInt.Count > 4) ? skillEffectDesc.EffectParamsInt[4] : 0);
				DamageDescParam.bCanTriggerFX = fUStSkillDamageExpandDesc.CanTriggerFX == 0;
				DamageDescParam.bCanTriggerFightBackCounter = fUStSkillDamageExpandDesc.CanTriggerFightBackCounter == 0;
				DamageDescParam.ElemAtkType = ((skillEffectDesc.EffectParamsInt.Count > 5) ? ((EAbnormalStateType)skillEffectDesc.EffectParamsInt[5]) : EAbnormalStateType.None);
				DamageDescParam.ImmobilizeHit = fUStSkillDamageExpandDesc.ImmobilizeHit;
				DamageDescParam.PartDamage = fUStSkillDamageExpandDesc.PartDamage;
				DamageDescParam.BaseDamage = skillEffectDesc.EffectParamsFloat[1];
				DamageDescParam.BaseDamageRatio = skillEffectDesc.EffectParamsFloat[2];
				DamageDescParam.bIgnoreBeAttacked = fUStSkillDamageExpandDesc.IgnoreBeAttacked == EGSYesNo.Yes;
				DamageDescParam.CritRateAddition = fUStSkillDamageExpandDesc.CritRateAddition;
				DamageDescParam.CritDamageAddition = fUStSkillDamageExpandDesc.CritDmgAddition;
				DamageDescParam.BlockArmorHit = skillEffectDesc.EffectParamsFloat[6];
				DamageDescParam.TargetCurHpRatio = fUStSkillDamageExpandDesc.AddTargetCurHpRatio;
				DamageDescParam.BreakFrozenImmediatelyFlag = fUStSkillDamageExpandDesc.BrokenFrozenImmediately == EGSYesNo.Yes;
				return true;
			}
		}
		else if (SkillDamageConfig.DmgReason == EDamageReason.Buff)
		{
			BuffInstData BuffData = null;
			bool flag = false;
			if (SkillDamageConfig.BuffOwner != null)
			{
				IBUC_BuffData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_BuffData, BUC_BuffData>(SkillDamageConfig.BuffOwner);
				if (readOnlyData2 != null)
				{
					flag = readOnlyData2.GetBuffInstData(SkillDamageConfig.DmgReasonEffectID, out BuffData);
				}
			}
			if (flag)
			{
				IBUC_PassiveSkillData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_PassiveSkillData, BUC_PassiveSkillData>(EntitySharedRefFuncLib.Actor(BuffData.RootCasterRef));
				BuffDescRuntime buffDescRuntime = BGW_GameDB.GetBuffDescRuntime(BuffData.BuffID, readOnlyData3);
				if (buffDescRuntime != null)
				{
					int dmgReasonEffectIdx = SkillDamageConfig.DmgReasonEffectIdx;
					DamageDescParam.HitVEffectID = 0;
					if (SkillDamageConfig.DamageCalcType == EDamageCalcType.Normal)
					{
						int intEffectParamCount = buffDescRuntime.GetIntEffectParamCount(dmgReasonEffectIdx);
						DamageDescParam.AttackStiffEffectID = buffDescRuntime.GetIntEffectParam(dmgReasonEffectIdx, 0);
						DamageDescParam.SkillDamageType = ((intEffectParamCount > 1) ? ((ESkillDamageType)buffDescRuntime.GetIntEffectParam(dmgReasonEffectIdx, 1)) : ESkillDamageType.NoneEffectAtk);
						DamageDescParam.bCanTriggerFX = intEffectParamCount <= 2 || buffDescRuntime.GetIntEffectParam(dmgReasonEffectIdx, 2) == 0;
						DamageDescParam.bCanTriggerFightBackCounter = intEffectParamCount <= 3 || buffDescRuntime.GetIntEffectParam(dmgReasonEffectIdx, 3) == 0;
						DamageDescParam.ElemAtkType = ((intEffectParamCount > 4) ? ((EAbnormalStateType)buffDescRuntime.GetIntEffectParam(dmgReasonEffectIdx, 4)) : EAbnormalStateType.None);
						DamageDescParam.ElementDmgLevel = ((intEffectParamCount > 7) ? buffDescRuntime.GetIntEffectParam(dmgReasonEffectIdx, 7) : 0);
						IBUC_SuperArmorLevelMappingData readOnlyData4 = BGU_DataUtil.GetReadOnlyData<IBUC_SuperArmorLevelMappingData, BUC_SuperArmorLevelMappingData>(Caster);
						int stringEffectParamCount = buffDescRuntime.GetStringEffectParamCount(dmgReasonEffectIdx);
						if (stringEffectParamCount > 0)
						{
							float SuperArmorValue2 = 0f;
							if (readOnlyData4 != null)
							{
								SuperArmorValue2 = readOnlyData4.GetSuperArmorLevelValue(buffDescRuntime.GetStringEffectParam(dmgReasonEffectIdx, 0), " BuffID: " + BuffData.BuffID, BGW_GameDB.GetBuffToBlame(BuffData.BuffID), Owner);
							}
							else
							{
								BGUFunctionLibraryCS.BGUGetSuperArmorValueByLevel(buffDescRuntime.GetStringEffectParam(dmgReasonEffectIdx, 0), " BuffID: " + BuffData.BuffID, BGW_GameDB.GetBuffToBlame(BuffData.BuffID), out SuperArmorValue2, Owner);
							}
							if (SuperArmorValue2 != 0f)
							{
								DamageDescParam.SkillArmorHit = SuperArmorValue2;
							}
							else if (readOnlyData4 != null)
							{
								DamageDescParam.SkillArmorHit = readOnlyData4.GetSuperArmorValue(buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 0), " BuffID: " + BuffData.BuffID, BGW_GameDB.GetBuffToBlame(BuffData.BuffID));
							}
							else
							{
								DamageDescParam.SkillArmorHit = buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 0);
							}
						}
						else if (readOnlyData4 != null)
						{
							DamageDescParam.SkillArmorHit = readOnlyData4.GetSuperArmorValue(buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 0), " BuffID: " + BuffData.BuffID, BGW_GameDB.GetBuffToBlame(BuffData.BuffID));
						}
						else
						{
							DamageDescParam.SkillArmorHit = buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 0);
						}
						if (stringEffectParamCount > 1)
						{
							if (StringParseHelper.SafeTryFloatParse(buffDescRuntime.GetStringEffectParam(dmgReasonEffectIdx, 1), out var Ret, IsNeedCatch: false))
							{
								DamageDescParam.ImmobilizeHit = Ret;
							}
							else
							{
								DamageDescParam.ImmobilizeHit = 0f;
							}
						}
						if (stringEffectParamCount > 2)
						{
							string[] array = buffDescRuntime.GetStringEffectParam(dmgReasonEffectIdx, 2).Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
							if (array.Count() == 2)
							{
								if (int.TryParse(array[0], out var result) && StringParseHelper.SafeTryFloatParse(array[1], out var Ret2, IsNeedCatch: false))
								{
									DamageDescParam.SpecialHitPartID = result;
									DamageDescParam.PartDamage = Ret2;
								}
								else
								{
									DamageDescParam.PartDamage = 0f;
								}
							}
						}
						DamageDescParam.BaseDamage = buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 1);
						DamageDescParam.BaseDamageRatio = buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 2);
						DamageDescParam.bIgnoreBeAttacked = !FMath.IsNearlyZero(buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 3));
						DamageDescParam.bCanTriggerFightBackCounter = DamageDescParam.bCanTriggerFightBackCounter && !DamageDescParam.bIgnoreBeAttacked;
						DamageDescParam.CritRateAddition = buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 4);
						DamageDescParam.CritDamageAddition = buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 5);
						DamageDescParam.BlockArmorHit = buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 6);
						DamageDescParam.TargetCurHpRatio = ((buffDescRuntime.GetFloatEffectParamCount(dmgReasonEffectIdx) > 7) ? buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 7) : 0f);
						return true;
					}
					if (SkillDamageConfig.DamageCalcType == EDamageCalcType.ElemDot)
					{
						DamageDescParam.ElemAtkType = ((buffDescRuntime.GetIntEffectParamCount(dmgReasonEffectIdx) > 4) ? ((EAbnormalStateType)buffDescRuntime.GetIntEffectParam(dmgReasonEffectIdx, 4)) : EAbnormalStateType.None);
						if (DamageDescParam.ElemAtkType == EAbnormalStateType.None)
						{
							return false;
						}
						DamageDescParam.AttackStiffEffectID = 0;
						DamageDescParam.SkillDamageType = ESkillDamageType.NoneEffectAtk;
						DamageDescParam.bCanTriggerFX = false;
						DamageDescParam.bCanTriggerFightBackCounter = false;
						DamageDescParam.SkillArmorHit = 0f;
						DamageDescParam.BaseDamage = 0f;
						DamageDescParam.BaseDamageRatio = 0f;
						DamageDescParam.bIgnoreBeAttacked = true;
						DamageDescParam.CritRateAddition = 0f;
						DamageDescParam.CritDamageAddition = 0f;
						DamageDescParam.BlockArmorHit = 0f;
						DamageDescParam.HPMaxINV10000Damage_Element = buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 0);
						return true;
					}
					if (SkillDamageConfig.DamageCalcType == EDamageCalcType.HPMaxRatioAbs)
					{
						DamageDescParam.AttackStiffEffectID = 0;
						DamageDescParam.SkillDamageType = ESkillDamageType.NoneEffectAtk;
						DamageDescParam.bCanTriggerFX = false;
						DamageDescParam.bCanTriggerFightBackCounter = false;
						DamageDescParam.SkillArmorHit = 0f;
						DamageDescParam.BaseDamage = 0f;
						DamageDescParam.BaseDamageRatio = 0f;
						DamageDescParam.bIgnoreBeAttacked = true;
						DamageDescParam.CritRateAddition = 0f;
						DamageDescParam.CritDamageAddition = 0f;
						DamageDescParam.BlockArmorHit = 0f;
						DamageDescParam.HPMaxINV10000Damage_Abs = buffDescRuntime.GetFloatEffectParam(dmgReasonEffectIdx, 0);
						return true;
					}
				}
			}
		}
		else if (SkillDamageConfig.DmgReason == EDamageReason.FallDmg || SkillDamageConfig.DmgReason == EDamageReason.DeadZone)
		{
			DamageDescParam.HPMaxINV10000Damage_Abs = SkillDamageConfig.HPMaxINV10000Damage_Abs;
			return true;
		}
		return false;
	}

	private void PackageDamageDynamicParam(AActor Caster, in FDamageDescParam DamageDescParam, in FEffectInstReq EffectInstReq, out FDamageDynamicParam DamageDynamicParam)
	{
		DamageDynamicParam = default(FDamageDynamicParam);
		DamageDynamicParam.HitPartID = ((DamageDescParam.SpecialHitPartID > 0) ? DamageDescParam.SpecialHitPartID : EffectInstReq.HitPartID);
		DamageDynamicParam.NowUseUBAConfig = GetNowUseUBAConfig(DamageDynamicParam.HitPartID);
		float hitWeight = 0f;
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(DamageDescParam.AttackStiffEffectID, Caster);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsFloat.Count > 0)
		{
			hitWeight = skillEffectDesc.EffectParamsFloat[0];
		}
		DamageDynamicParam.HitWeight = hitWeight;
		DamageDynamicParam.StiffLevel = CalcStiffLevel(DamageDynamicParam.HitWeight, VictimAttrCon.GetFloatValue(EBGUAttrFloat.Tenacity));
		FVector victimToAttackerDir = ((Caster != null) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(Caster) : Owner.GetActorTransform().TransformPosition(FVector.ForwardVector)) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		EAttackerArea attackerAreaByUBAConfig = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetAttackerAreaByUBAConfig(DamageDynamicParam.StiffLevel, DamageDynamicParam.NowUseUBAConfig, Owner.GetActorForwardVector(), victimToAttackerDir);
		DamageDynamicParam.AttackerArea = attackerAreaByUBAConfig;
	}

	private void OnHandleNormalDamageEffect_Predict(AActor Attacker, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData, GSPredictionKey PredictionKey)
	{
		AActor owner = Owner;
		if (owner == null || GetOwner() as ACharacter == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(owner);
		if (!BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find UnitCommDesc failed! ResID: {0}", actorResID) && !VictimUnitStateData.HasState(EBGUUnitState.Dead) && !VictimUnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) && (VictimFallDyingData == null || VictimFallDyingData.GetFallDyingState() == EFallDyingState.Alive) && PackageDamageDescParam(Attacker, in EffectInstReq, in SkillDamageConfig, out var DamageDescParam))
		{
			PackageDamageDynamicParam(Attacker, in DamageDescParam, in EffectInstReq, out var DamageDynamicParam);
			bool isCrit = SkillDamageConfig.DamageCalcType == EDamageCalcType.Normal && IsAttackCrit(Attacker, in DamageDescParam, in Attacker_AttrMemData);
			float dmgNoiseMultiplier = GetDmgNoiseMultiplier();
			if (!VictimBeAttackData.DmgPredictMap.TryGetValue(PredictionKey, out var _))
			{
				VictimBeAttackData.DmgPredictMap.Add(PredictionKey, new FDmgPredictInfo(isCrit, dmgNoiseMultiplier));
			}
			else
			{
				VictimBeAttackData.DmgPredictMap[PredictionKey] = new FDmgPredictInfo(isCrit, dmgNoiseMultiplier);
			}
			AActor AtkerMasterActor;
			bool isTriggerByMagicField = IsTriggeredByMagicField(Attacker, out AtkerMasterActor);
			HandleNormalDamageEffectPerform(Attacker, AtkerMasterActor, isTriggerByMagicField, isCrit, dmgNoiseMultiplier, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in EffectInstReq, in Attacker_AttrMemData);
		}
	}

	private void OnHandleNormalDamageEffect_Cue(AActor Attacker, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData, GSPredictionKey PredictionKey)
	{
		AActor owner = Owner;
		if (owner == null || GetOwner() as ACharacter == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(owner);
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find UnitCommDesc failed! ResID: {0}", actorResID) || VictimUnitStateData.HasState(EBGUUnitState.Dead) || VictimUnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || VictimSimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing) || (VictimUnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) && SkillDamageConfig.DmgReason != EDamageReason.DeadZone && SkillDamageConfig.DmgReason == EDamageReason.FallDmg) || (VictimFallDyingData != null && VictimFallDyingData.GetFallDyingState() != EFallDyingState.Alive))
		{
			return;
		}
		VictimBeAttackData.NormalDmgEffectTriggerAfterPredict = PredictionKey != null;
		if (PackageDamageDescParam(Attacker, in EffectInstReq, in SkillDamageConfig, out var DamageDescParam))
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>=============================受击流程开始=============================</>");
			}
			PackageDamageDynamicParam(Attacker, in DamageDescParam, in EffectInstReq, out var DamageDynamicParam);
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, $"<character>{Owner?.GetName()}</><action>DynamicParam HitWeight = </><effect>{DamageDynamicParam.HitWeight}</><action>，韧性 = </><effect>{VictimAttrCon.GetFloatValue(EBGUAttrFloat.Tenacity)}</><action>，HitBoneName = </><effect>{EffectInstReq.HitBoneName}</><action>，HitPartID = </><effect>{DamageDynamicParam.HitPartID}</><action>，StiffLevel = </><effect>{DamageDynamicParam.StiffLevel}</>");
			}
			bool isCrit = SkillDamageConfig.DamageCalcType == EDamageCalcType.Normal && IsAttackCrit(Attacker, in DamageDescParam, in Attacker_AttrMemData);
			float dmgNoiseMul = GetDmgNoiseMultiplier();
			AActor AtkerMasterActor;
			bool isTriggerByMagicField = IsTriggeredByMagicField(Attacker, out AtkerMasterActor);
			if (PredictionKey != null && VictimBeAttackData.DmgPredictMap.TryGetValue(PredictionKey, out var value))
			{
				isCrit = value.IsCrit;
				dmgNoiseMul = value.DmgRandomValue;
				VictimBeAttackData.DmgPredictMap.Remove(PredictionKey);
			}
			else
			{
				HandleNormalDamageEffectPerform(Attacker, AtkerMasterActor, isTriggerByMagicField, isCrit, dmgNoiseMul, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in EffectInstReq, in Attacker_AttrMemData);
			}
			HandleNormalDamageEffectLogic(Attacker, AtkerMasterActor, isTriggerByMagicField, isCrit, dmgNoiseMul, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in EffectInstReq, in Attacker_AttrMemData);
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>=============================受击流程结束=============================</>");
			}
		}
		VictimBeAttackData.NormalDmgEffectTriggerAfterPredict = false;
	}

	private void OnHandleNormalDamageEffect_RollBack(AActor Attacker, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData, GSPredictionKey PredictionKey)
	{
		if (PredictionKey != null && VictimBeAttackData.DmgPredictMap.TryGetValue(PredictionKey, out var _))
		{
			VictimBeAttackData.DmgPredictMap.Remove(PredictionKey);
		}
	}

	private void OnMarkBeAttackedProtectTime(string SkillTaskUniqID, float ResetTime, float GroupResetTime, int GroupID, int FromInstanceID = -1)
	{
		AActor owner = GetOwner();
		if (!(owner == null) && !(owner.World == null))
		{
			VictimUnitBeAttackedFequeceData.MarkBeAttackedFequenceData(SkillTaskUniqID, FromInstanceID, GroupID, ResetTime, GroupResetTime, IsTriggered: true);
		}
	}

	private void OnSetNewBeAttackedInfoID(int NewID)
	{
		if (!(GetOwner() == null))
		{
			VictimBeAttackData.SetBeAttackedInfoID(NewID);
			FUStBeAttackedInfoDesc beAttackedInfoDesc = BGW_GameDB.GetBeAttackedInfoDesc(NewID);
			if (beAttackedInfoDesc != null)
			{
				VictimBeAttackData.UnitBeAttackedConfigPath = beAttackedInfoDesc.UnitBeAttackedConfigPath;
			}
		}
	}

	private void OnResetBeAttackedInfoID()
	{
		if (GetOwner() == null)
		{
			return;
		}
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(GetActorResID());
		if (unitCommDesc != null)
		{
			VictimBeAttackData.SetBeAttackedInfoID(unitCommDesc.DefaultBeAttackedInfoID);
			FUStBeAttackedInfoDesc beAttackedInfoDesc = BGW_GameDB.GetBeAttackedInfoDesc(unitCommDesc.DefaultBeAttackedInfoID);
			if (beAttackedInfoDesc != null)
			{
				VictimBeAttackData.UnitBeAttackedConfigPath = beAttackedInfoDesc.UnitBeAttackedConfigPath;
			}
		}
	}

	private void OnSetTriggerMontage(bool bIsPlay)
	{
		VictimBeAttackData.SetPlayedMontage(bIsPlay);
	}

	private void OnPlayMontageCallback(EMontageBindReason Reason, UAnimMontage Montage, EMontageCallbackState State)
	{
		if (BeatbackAMResultCheck == EBeatbackAMResultCheck.Pending)
		{
			switch (State)
			{
			case EMontageCallbackState.OnStarted:
				BeatbackAMResultCheck = EBeatbackAMResultCheck.Success;
				break;
			case EMontageCallbackState.OnPlayFailed:
				BeatbackAMResultCheck = EBeatbackAMResultCheck.Fail;
				break;
			}
		}
	}

	private void OnBeHitSetInfo(AActor Attacker, in FDamageDescParam DamageDescParam, in FDamageDynamicParam DamageDynamicParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, float FinalDamageValue)
	{
		if (Owner != null && !Owner.IsPendingKill && VictimAIData.IsBeHitResetAIWatchTime && !VictimUnitStateData.HasState(EBGUUnitState.BlockBeatBack) && !VictimUnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack))
		{
			base.BUSEventCollection?.Evt_SetWatchTime.Invoke(0f);
		}
		VictimBeAttackData.SetAttacker(Attacker);
		if (SkillDamageConfig.DamageCalcType != EDamageCalcType.Normal || DamageDescParam.bIgnoreBeAttacked)
		{
			return;
		}
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.InTTTB))
		{
			base.BUSEventCollection?.Evt_CastIronBody.Invoke(EffectInstReq.Attacker, SkillDamageConfig.DmgReasonEffectID, DamageDescParam.SkillDamageType);
		}
		bool flag = true;
		if (VictimPartMgrData.GetPartInfo(DamageDynamicParam.HitPartID, out var PartInfoOut))
		{
			FUStPartRuleInfoDesc partRuleInfoDesc = BGW_GameDB.GetPartRuleInfoDesc(PartInfoOut.DescID, Owner);
			if (partRuleInfoDesc != null)
			{
				flag = partRuleInfoDesc.CanTriggerBeAttackedBuffEffect == EGSYesNo.Yes;
			}
		}
		if (flag)
		{
			base.BUSEventCollection?.Evt_NotifyTriggerBuffWhenConditionMet.Invoke(EBuffEffectTriggerType.BeAttacked, in EffectInstReq);
		}
		base.BUSEventCollection?.Evt_NotifyRemoveBuffWhenConditionMet.Invoke(bAttackedOrAttackHit: true);
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Attacker);
		bUS_GSEventCollection?.Evt_NotifyTriggerBuffWhenConditionMet.Invoke(EBuffEffectTriggerType.OnSkillDamage, in EffectInstReq, Owner);
		if (FinalDamageValue > 0f)
		{
			bUS_GSEventCollection?.Evt_NotifyTriggerBuffWhenConditionMet.Invoke(EBuffEffectTriggerType.SkillCostOnceDmg, in EffectInstReq);
			float timeSeconds = Owner.World.GetTimeSeconds();
			VictimBeAttackData.HandleSkillBeHitCounter(EffectInstReq.TriggerSkillId, timeSeconds);
			VictimBeAttackData.HandleSkillEffectBeHitCounter(SkillDamageConfig.DmgReasonEffectID, timeSeconds);
			base.BGWEventCollection.Evt_BGW_BeAttackedFromSkill(Owner, EffectInstReq.TriggerSkillId);
			base.BGWEventCollection.Evt_BGW_BeAttackedFromSkillEffect(Owner, SkillDamageConfig.DmgReasonEffectID);
		}
		bUS_GSEventCollection?.Evt_NotifyRemoveBuffWhenConditionMet.Invoke(bAttackedOrAttackHit: false);
	}

	private EHitPerformFXEventType CalcPerformPriorityRuleForFX(List<EHitPerformFXEventType> HitPerformFXEventTypeList)
	{
		EHitPerformFXEventType eHitPerformFXEventType = EHitPerformFXEventType.None;
		if (HitPerformFXEventTypeList.Count > 0)
		{
			HitPerformFXEventTypeList.Sort();
			eHitPerformFXEventType = HitPerformFXEventTypeList[HitPerformFXEventTypeList.Count - 1];
			if (eHitPerformFXEventType - 9 <= EHitPerformFXEventType.SkillSurperArmorHit)
			{
				eHitPerformFXEventType = ((!HitPerformFXEventTypeList.Contains(EHitPerformFXEventType.CritHit)) ? EHitPerformFXEventType.NormalHit : EHitPerformFXEventType.CritHit);
			}
		}
		return eHitPerformFXEventType;
	}

	private EHitPerformAudioEventType CalcPerformPriorityRuleForAudio(List<EHitPerformAudioEventType> HitPerformAudioEventTypeList)
	{
		EHitPerformAudioEventType eHitPerformAudioEventType = EHitPerformAudioEventType.None;
		if (HitPerformAudioEventTypeList.Count > 0)
		{
			HitPerformAudioEventTypeList.Sort();
			eHitPerformAudioEventType = HitPerformAudioEventTypeList[HitPerformAudioEventTypeList.Count - 1];
			if (eHitPerformAudioEventType == EHitPerformAudioEventType.BlockArmorBreak2WeakHit)
			{
				eHitPerformAudioEventType = ((!HitPerformAudioEventTypeList.Contains(EHitPerformAudioEventType.CritHit)) ? EHitPerformAudioEventType.NormalHit : EHitPerformAudioEventType.CritHit);
			}
		}
		return eHitPerformAudioEventType;
	}

	private int CalcStiffLevel(float HitWeight, float DefWeight)
	{
		if (GetOwner() == null)
		{
			return -1;
		}
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueStiff))
		{
			return -1;
		}
		float num = HitWeight - DefWeight;
		if (BGW_GameDB.GetBeAttackedDispInfoDescDictByResID(GetActorResID(), (int)num, out var MappingStiffLevel))
		{
			return MappingStiffLevel;
		}
		return (int)num;
	}

	private BGWDataAsset_UnitBeAttackedConfig GetNowUseUBAConfig(int PartID)
	{
		int actorResID = GetActorResID();
		int finalBattleInfoExtendID = GetFinalBattleInfoExtendID();
		string finalGuid = VictimGuidData.GetFinalGuid();
		BGWDataAsset_UnitBeAttackedConfig bGWDataAsset_UnitBeAttackedConfig = BGW_PreloadAssetMgr.Get(Owner).GetUBAConfig(actorResID, finalBattleInfoExtendID, finalGuid, VictimBeAttackData.UnitBeAttackedConfigPath);
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>======开始获取当前UBAC======</>");
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, $"<character>{Owner?.GetName()}</><action>HitPartID = </><effect>{PartID}</><action>，ResID = </><effect>{actorResID}</><action>，OverrideID = </><effect>{finalBattleInfoExtendID}</>");
		}
		if (VictimPartMgrData.GetPartInfo(PartID, out var PartInfoOut))
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>打中合理部位！！！尝试寻找部位UBAC！！！</>");
			}
			FUStPartRuleInfoDesc partRuleInfoDesc = BGW_GameDB.GetPartRuleInfoDesc(PartInfoOut.DescID, Owner);
			if (partRuleInfoDesc != null)
			{
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>部位UBAC路径 = </><effect>" + partRuleInfoDesc.PartHitUnitBeAttackedConfigPath + "</>");
				}
				BGWDataAsset_UnitBeAttackedConfig uBAConfig = BGW_PreloadAssetMgr.Get(Owner).GetUBAConfig(actorResID, finalBattleInfoExtendID, finalGuid, partRuleInfoDesc.PartHitUnitBeAttackedConfigPath);
				if (uBAConfig != null)
				{
					bGWDataAsset_UnitBeAttackedConfig = uBAConfig;
				}
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, (uBAConfig != null) ? ("<character>" + Owner?.GetName() + "</><action>找到了对应的部位UBAC！！！</>") : ("<character>" + Owner?.GetName() + "</><action>没有找到对应的部位UBAC！！！</>"));
				}
			}
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>不是合法部位！！！尝试读取受击表里的UBAC</>");
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, (bGWDataAsset_UnitBeAttackedConfig == null) ? ("<character>" + Owner?.GetName() + "</><action>找不到UBAC！！！ 麻烦确认资源是否正确！！！受击表里的路径是：</><effect>" + VictimBeAttackData.UnitBeAttackedConfigPath + "</>") : ("<character>" + Owner?.GetName() + "</><action>找到UBAC！！！ 路径是：</><effect>" + bGWDataAsset_UnitBeAttackedConfig.GetPathName() + "</>"));
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>======获取当前UBAC结束======</>");
		}
		return bGWDataAsset_UnitBeAttackedConfig;
	}

	private string GetBeAttackedInfoIDStr(int VictimBeAttackedInfoID)
	{
		int num = VictimBeAttackedInfoID % 100;
		if (num >= 10)
		{
			return num.ToString();
		}
		return $"0{num}";
	}

	private int GetPartMappingBeAttackedInfoID(int OriBeAttackedInfoID, int HitPartID)
	{
		int result = OriBeAttackedInfoID;
		if (VictimPartMgrData.GetPartInfo(HitPartID, out var PartInfoOut))
		{
			FUStPartRuleInfoDesc partRuleInfoDesc = BGW_GameDB.GetPartRuleInfoDesc(PartInfoOut.DescID, Owner);
			if (partRuleInfoDesc != null && partRuleInfoDesc.PartHitMappingUnitBeAttackedInfoID > 0)
			{
				result = partRuleInfoDesc.PartHitMappingUnitBeAttackedInfoID;
			}
		}
		return result;
	}

	private UAnimMontage GetMontagePathByRule(int VictimBeAttackedInfoID, int StiffLevel, EAttackerArea AttackerArea, EHitActionDir HitActionDir, BGWDataAsset_UnitBeAttackedConfig NowUseUBAConfig, out bool HasValidConfigOrData)
	{
		HasValidConfigOrData = false;
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return null;
		}
		if (BGW_GameDB.GetUnitCommDesc(GetActorResID()) == null || NowUseUBAConfig == null)
		{
			return null;
		}
		UAnimMontage uAnimMontage = null;
		HasValidConfigOrData = true;
		string unitResName = NowUseUBAConfig.UnitResName;
		BGUFuncLibBeAttackedAndUnitDeathDispCS.GetActualStiffLevelInfo(StiffLevel, NowUseUBAConfig, out var IsValid, out var NormalStiffInfo);
		if (IsValid)
		{
			string beAttackedAttackerAreaStr = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetBeAttackedAttackerAreaStr(AttackerArea);
			string beAttackedActionDirStr = BGUFuncLibBeAttackedAndUnitDeathDispCS.GetBeAttackedActionDirStr(HitActionDir, AttackerArea);
			string beAttackedInfoIDStr = GetBeAttackedInfoIDStr(VictimBeAttackedInfoID);
			string text = $"AM_{unitResName}_bh_dep{beAttackedInfoIDStr}_sl{StiffLevel}_d{beAttackedAttackerAreaStr}_h{beAttackedActionDirStr}";
			switch (NormalStiffInfo.EllipsisType)
			{
			case EEllipsisType.NoHitAction:
				text = $"AM_{unitResName}_bh_dep{beAttackedInfoIDStr}_sl{StiffLevel}_d{beAttackedAttackerAreaStr}";
				break;
			case EEllipsisType.NoAttackerArea:
				text = $"AM_{unitResName}_bh_dep{beAttackedInfoIDStr}_sl{StiffLevel}_h{beAttackedActionDirStr}";
				break;
			case EEllipsisType.BothNoAttackerAreaNHitAction:
				text = $"AM_{unitResName}_bh_dep{beAttackedInfoIDStr}_sl{StiffLevel}";
				break;
			case EEllipsisType.NoGears:
				text = "AM_" + unitResName + "_bh_dep" + beAttackedInfoIDStr;
				break;
			case EEllipsisType.NoDepot:
				text = "AM_" + unitResName + "_bh";
				break;
			}
			List<UAnimMontage> randomNormalStiffAM = BGW_PreloadAssetMgr.Get(aCharacter).GetRandomNormalStiffAM(GetActorResID(), text);
			if (randomNormalStiffAM != null && randomNormalStiffAM.Count > 0)
			{
				uAnimMontage = randomNormalStiffAM[UB1Util.GetRandomNumberInt(0, randomNormalStiffAM.Count - 1)];
			}
			if (uAnimMontage == null)
			{
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>找不到普通硬直动画！！！麻烦确认资源是否正确，根路径是：</><effect>" + text + "</>");
				}
				if (NormalStiffInfo.EllipsisType == EEllipsisType.None && IsValid)
				{
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>===开始进行缺省寻找动画，会替换【受击方向】来寻找===</>");
					}
					List<UAnimMontage> list = new List<UAnimMontage>();
					string[] array = new string[6] { "f", "b", "l", "r", "u", "d" };
					foreach (string text2 in array)
					{
						text = $"AM_{unitResName}_bh_dep{beAttackedInfoIDStr}_sl{StiffLevel}_d{beAttackedAttackerAreaStr}_h{text2}";
						randomNormalStiffAM = BGW_PreloadAssetMgr.Get(aCharacter).GetRandomNormalStiffAM(GetActorResID(), text);
						foreach (UAnimMontage item in randomNormalStiffAM)
						{
							list.Add(item);
						}
					}
					if (list.Count > 0)
					{
						int randomNumberInt = UB1Util.GetRandomNumberInt(0, list.Count - 1);
						uAnimMontage = list[randomNumberInt];
					}
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						if (uAnimMontage != null)
						{
							BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>找到了路径为：</><effect>" + uAnimMontage.GetPathName() + "</><action>的动画作为替代!!!</>");
						}
						else
						{
							BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>没有找到合适的缺省动画！！！</>");
						}
						BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>===缺省动画寻找结束===</>");
					}
				}
			}
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				if (uAnimMontage != null)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>找到了匹配的普通硬直动画！路径是：</><effect>" + uAnimMontage.GetPathName() + "</>");
				}
				else
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, $"<character>{Owner?.GetName()}</><action>找不到任何动画作为替代, 麻烦检查一下配置, BeAttackedID = </><effect>{VictimBeAttackedInfoID}</><action>, StiffLevel = </><effect>{StiffLevel}</><action>, AttackerArea = </><effect>{AttackerArea}</><action>, HitDir = </><effect>{beAttackedActionDirStr}</>");
				}
			}
		}
		return uAnimMontage;
	}

	private bool CheckCanRotate(int StiffLevel, BGWDataAsset_UnitBeAttackedConfig UBAConfig)
	{
		BGUFuncLibBeAttackedAndUnitDeathDispCS.GetActualStiffLevelInfo(StiffLevel, UBAConfig, out var IsValid, out var NormalStiffInfo);
		if (IsValid)
		{
			return NormalStiffInfo.EnableBeAttackedRotate;
		}
		return false;
	}

	private bool IsDamageValid(in FSkillDamageConfig SkillDamageConfig)
	{
		if (SkillDamageConfig.DmgReason == EDamageReason.DeadZone)
		{
			return true;
		}
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueDamage))
		{
			return false;
		}
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.StrongDamageImmue))
		{
			return SkillDamageConfig.DamageImmueLevel > 1;
		}
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.CommonDamageImmue))
		{
			return SkillDamageConfig.DamageImmueLevel > 0;
		}
		return true;
	}

	private bool IsAttackCrit(AActor Attacker, in FDamageDescParam DamageDescParam, in FBattleAttrSnapShot Attacker_AttrMemData)
	{
		if (MathLib.Abs(BGW_GameDB.GetElementDmgRatio(DamageDescParam.ElementDmgLevel) - 1f) <= 0.0001f)
		{
			return false;
		}
		float attr_CritRate = Attacker_AttrMemData.Attr_CritRate;
		int num = FMath.RandRange(1, 10000);
		float critRateAddition = DamageDescParam.CritRateAddition;
		float floatValue = VictimAttrCon.GetFloatValue(EBGUAttrFloat.CritRateDef);
		GSGameplayCVar.CVar_DmgCacl.GetValueInGameThread();
		float num2 = FMath.Max(0f, attr_CritRate + critRateAddition - floatValue);
		return (float)num <= num2;
	}

	private float GetDmgNoiseMultiplier()
	{
		return FMath.FRandRange(0.97f, 1.03f);
	}

	private bool IsTriggeredByMagicField(AActor Attacker, out AActor AtkerMasterActor)
	{
		AtkerMasterActor = Attacker;
		BGUMagicFieldBaseCS bGUMagicFieldBaseCS = Attacker as BGUMagicFieldBaseCS;
		if (bGUMagicFieldBaseCS != null)
		{
			BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUMagicFieldBaseCS);
			if (readOnlyData != null)
			{
				AtkerMasterActor = readOnlyData.GetMasterActor();
				return true;
			}
		}
		return false;
	}

	public bool CanTriggerNormalStiff()
	{
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance) || VictimUnitStateData.HasState(EBGUUnitState.BlockBeatBack) || VictimUnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack) || VictimSimpleStateData.HasSimpleState(EBGUSimpleState.HRCounterattackProtectOneFrame) || VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BreakBlock) || VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BreakPart2Weak))
		{
			return false;
		}
		return true;
	}

	public bool IsSuperArmorBreak()
	{
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.SkillSuperArmor) && VictimAttrCon.GetFloatValue(EBGUAttrFloat.SkillSuperArmor) <= 0f)
		{
			return true;
		}
		return false;
	}

	private void CalcDmgValueOnly(AActor Attacker, bool IsCrit, float DmgNoiseMul, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FBattleAttrSnapShot Attacker_AttrMemData, out float FinalDamageValue, out float FinalDmgForPart, out float FinalDmgForShield, out float FinalElementDmgValue, out float FinalNonElementDmgValue, bool bPrintLog = true)
	{
		FinalDamageValue = 0f;
		FinalDmgForPart = -1f;
		FinalDmgForShield = 0f;
		FinalElementDmgValue = 0f;
		FinalNonElementDmgValue = 0f;
		switch (SkillDamageConfig.DamageCalcType)
		{
		case EDamageCalcType.Normal:
			DoDmg_B1_V2(Attacker, IsCrit, DmgNoiseMul, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in Attacker_AttrMemData, out FinalDamageValue, out FinalDmgForPart, out FinalElementDmgValue, bPrintLog);
			break;
		case EDamageCalcType.ElemDot:
			FinalDamageValue = DoElementDotDmg_B1(in DamageDescParam, in Attacker_AttrMemData, bPrintLog);
			FinalElementDmgValue = FinalDamageValue;
			break;
		case EDamageCalcType.HPMaxRatioAbs:
			FinalDamageValue = DoHPMaxRatioAbsDmg_B1(Attacker, in DamageDescParam, bPrintLog);
			break;
		}
		int teamDamageReductionRatio = TeamRelationData.GetTeamDamageReductionRatio(Owner, Attacker);
		if (teamDamageReductionRatio != 0)
		{
			float num = 1f - (float)teamDamageReductionRatio * 0.0001f;
			FinalDamageValue *= num;
			FinalElementDmgValue *= num;
		}
		FinalNonElementDmgValue = FinalDamageValue - FinalElementDmgValue;
		FinalDmgForShield = FMath.Min(VictimAttrCon.GetFloatValue(EBGUAttrFloat.Shield), FinalDamageValue);
		FinalDamageValue = Math.Max(0f, FinalDamageValue - FinalDmgForShield);
	}

	private void DoDamageLogic(AActor Attacker, AActor AttackerMaster, bool IsCrit, float DmgNoiseMul, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, in FBattleAttrSnapShot Attacker_AttrMemData, out float FinalDamageValue)
	{
		FinalDamageValue = 0f;
		float FinalNonElementDmgValue = 0f;
		float FinalElementDmgValue = 0f;
		if (IsDamageValid(in SkillDamageConfig))
		{
			CalcDmgValueOnly(Attacker, IsCrit, DmgNoiseMul, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in Attacker_AttrMemData, out FinalDamageValue, out var FinalDmgForPart, out var FinalDmgForShield, out FinalElementDmgValue, out FinalNonElementDmgValue);
			if (VictimPartMgrData.GetPartInfo(DamageDynamicParam.HitPartID, out var PartInfoOut))
			{
				if (!VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueStiff) && FinalDmgForPart > 0f)
				{
					float num = FinalDmgForPart;
					if (SkillDamageConfig.DamageCalcType == EDamageCalcType.Normal && SkillDamageConfig.DmgReason == EDamageReason.Skill)
					{
						bool flag = false;
						FUStPartRuleInfoDesc partRuleInfoDesc = BGW_GameDB.GetPartRuleInfoDesc(PartInfoOut.DescID, Owner);
						if (partRuleInfoDesc != null && partRuleInfoDesc.CantBreakPartDmgEffectIDList != null && partRuleInfoDesc.CantBreakPartDmgEffectIDList.Count > 0 && partRuleInfoDesc.CantBreakPartDmgEffectIDList.Contains(SkillDamageConfig.DmgReasonEffectID))
						{
							flag = true;
						}
						if (flag && PartInfoOut.CurrentPartDamagedValue <= num)
						{
							num = PartInfoOut.CurrentPartDamagedValue - 1f;
						}
					}
					base.BUSEventCollection?.Evt_TriggerHitInPart.Invoke(DamageDynamicParam.HitPartID, num, DamageDynamicParam.StiffLevel);
				}
				switch (PartInfoOut.ReduceAttrType)
				{
				case EHitPartReduceAttrType.Mp:
					HandleDmgCovertToMPReduce(PartInfoOut, in DamageDescParam, in Attacker_AttrMemData);
					break;
				case EHitPartReduceAttrType.Stamina:
					HandleDmgCovertToStaminaReduce(PartInfoOut, in DamageDescParam, in Attacker_AttrMemData);
					break;
				}
				HandlePartHitExpandAttrResult(PartInfoOut, PartInfoOut.PartHitExpandInfo, FinalDmgForPart);
			}
			float floatValue = VictimAttrCon.GetFloatValue(EBGUAttrFloat.Shield);
			if (floatValue > 0f)
			{
				if (FinalDmgForShield >= floatValue)
				{
					base.BUSEventCollection?.Evt_NotifyTriggerBuffWhenConditionMet.Invoke(EBuffEffectTriggerType.OnShieldBreak, in EffectInstReq);
				}
				base.BUSEventCollection?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Shield, 0f - FinalDmgForShield);
			}
			float floatValue2 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.Shield);
			float floatValue3 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.Hp);
			float num2 = floatValue3 - FinalDamageValue;
			if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.CantBeDead1HP) && num2 <= 0f)
			{
				FinalDamageValue = floatValue3 - 1f;
				num2 = 1f;
			}
			bool flag2 = VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance);
			bool flag3 = VictimSimpleStateData.HasSimpleState(EBGUSimpleState.InPhaseTransition);
			if (VictimMandatoryAITaskData != null)
			{
				foreach (FMandatoryTask mandatoryTask in VictimMandatoryAITaskData.MandatoryTasks)
				{
					if (mandatoryTask.IsDone || mandatoryTask.TaskCondition != EAITaskCondition.SelfHpLessThan)
					{
						continue;
					}
					float num3 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.HpMax) * mandatoryTask.ConditionFloatParams[0] / 100f;
					if (num3 > num2)
					{
						if (flag2 || flag3)
						{
							FinalDamageValue = num3 + 1f - floatValue3;
							num2 = num3 + 1f;
						}
						else
						{
							FinalDamageValue = floatValue3 - num3;
							num2 = num3;
							base.BUSEventCollection?.Evt_ExecuteMandatoryTask.Invoke(mandatoryTask);
						}
					}
				}
			}
			if ((flag2 || flag3) && num2 <= 0f)
			{
				FinalDamageValue = floatValue3 - 1f;
				num2 = 1f;
			}
			base.BUSEventCollection?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Hp, 0f - FinalDamageValue);
			base.BUSEventCollection?.Evt_SetLastAtkDmgTime.Invoke(Owner.World.GetTimeSeconds());
			VictimBeAttackData.SetLastBeAttackedHitLocation(EffectInstReq.HitLocation);
			base.BGWEventCollection.Evt_BGW_BeHurt(Owner, Attacker, FinalDamageValue);
			base.BUSEventCollection?.Evt_BeHurt.Invoke(Attacker, FMath.Min(FinalDamageValue, floatValue3));
			if (AttackerMaster != null)
			{
				BUS_EventCollectionCS.Get(AttackerMaster)?.Evt_UpdateOSSAttackData.Invoke(EffectInstReq.TriggerSkillId, Owner, (int)FinalDamageValue, IsCrit, SkillDamageConfig.DamageCalcType == EDamageCalcType.ElemDot);
				base.BUSEventCollection?.Evt_UpdateOSSDefenceData.Invoke(EffectInstReq.TriggerSkillId, AttackerMaster, (int)FinalDamageValue, IsCrit, SkillDamageConfig.DamageCalcType == EDamageCalcType.ElemDot);
				int effectID = ((SkillDamageConfig.DmgReason == EDamageReason.Skill) ? SkillDamageConfig.DmgReasonEffectID : 0);
				int buffID = ((SkillDamageConfig.DmgReason == EDamageReason.Buff) ? SkillDamageConfig.DmgReasonEffectID : 0);
				base.BGWEventCollection.Evt_ReportSkillDamageInfo(Attacker, Owner, EffectInstReq.TriggerSkillId, buffID, effectID, FinalDamageValue);
			}
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				string text = "";
				float num4 = FinalDamageValue / VictimAttrCon.GetFloatValue(EBGUAttrFloat.HpMax);
				text = ((num4 > 0.75f) ? "效果拔群" : ((num4 > 0.5f) ? "效果显著" : ((num4 > 0.25f) ? "效果不一般" : ((!(num4 > 0.125f)) ? "效果甚微" : "效果一般"))));
				if (Attacker != null)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Attacker, EBattleInfoType.DamageCalc, (FinalDmgForShield > 0f) ? $"<character>{Attacker?.GetName()}</><action>对</><bechosed>{GetOwner().GetName()}</><action>造成了</><damage>{FinalDamageValue}</><action>点伤害</><hp>({floatValue3}->{((num2 < 0f) ? 0f : num2)})</><action>护盾抵消了</><damage>{FinalDmgForShield}</><action>点伤害</><hp>({floatValue}->{((floatValue2 < 0f) ? 0f : floatValue2)})</><effect>{text}</>" : $"<character>{Attacker?.GetName()}</><action>对</><bechosed>{GetOwner().GetName()}</><action>造成了</><damage>{FinalDamageValue}</><action>点伤害</><hp>({floatValue3}->{((num2 < 0f) ? 0f : num2)})</><effect>{text}</>");
				}
				BGUFunctionLibraryCS.LogBattleInfo(GetOwner(), EBattleInfoType.DamageCalc, (FinalDmgForShield > 0f) ? $"<character>{GetOwner().GetName()}</><action>受到了来自</><bechosed>{Attacker?.GetName()}</><action>的</><damage>{FinalDamageValue}</><action>点伤害</><hp>({floatValue3}->{((num2 < 0f) ? 0f : num2)})</><action>护盾抵消了</><damage>{FinalDmgForShield}</><action>点伤害</><hp>({floatValue}->{((floatValue2 < 0f) ? 0f : floatValue2)})</><effect>{text}</>" : $"<character>{GetOwner().GetName()}</><action>受到了来自</><bechosed>{Attacker?.GetName()}</><action>的</><damage>{FinalDamageValue}</><action>点伤害</><hp>({floatValue3}->{((num2 < 0f) ? 0f : num2)})</><effect>{text}</>");
			}
		}
		int SkillDamageExpandID;
		FUStSkillDamageExpandDesc skillDamageExpandDesc = BGW_GameDB.GetSkillDamageExpandDesc(SkillDamageConfig.DmgReasonEffectID, Attacker, out SkillDamageExpandID);
		if (skillDamageExpandDesc != null && (skillDamageExpandDesc.PillarFormTerminatorType == EPillarFormTerminatorType.ClearStamina || skillDamageExpandDesc.PillarFormTerminatorType == EPillarFormTerminatorType.BreakPillarForm) && BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.PillarFormStateBuff, out var ConfigInfo))
		{
			int intValue = ConfigInfo.IntValue;
			if (VictimBuffData.HasBuff(intValue))
			{
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DamageCalc, $"<character>{Owner?.GetName()}</><action>处于撑棍状态下，被撑棍终结者击中！！！对应的EffectExpandID = {SkillDamageExpandID}，PillarFormTerminatorType = {skillDamageExpandDesc.PillarFormTerminatorType}</>");
				}
				if (skillDamageExpandDesc.PillarFormTerminatorType == EPillarFormTerminatorType.BreakPillarForm && BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.PillarFormTerminatorBuff, out var ConfigInfo2))
				{
					int intValue2 = ConfigInfo2.IntValue;
					if (BGW_GameDB.GetOriginalBuffDesc(intValue2) != null)
					{
						base.BUSEventCollection?.Evt_BuffAdd.Invoke(intValue2, Owner, Owner, 100f, EBuffSourceType.BeAttacked);
					}
				}
				float floatValue4 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.StaminaMax);
				base.BUSEventCollection?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Stamina, 0f - floatValue4);
			}
		}
		BUS_EventCollectionCS.Get(AttackerMaster)?.Evt_OnSkillCostDmg.Invoke(Owner, EffectInstReq.TriggerSkillId, (int)FinalDamageValue, IsCrit);
	}

	private float CalcElemDmgMultiplierV2(EAbnormalStateType ElemAtkType, FBattleAttrSnapShot Attacker_AttrMemData, out string ElemDmgMultiplierLogStr)
	{
		ElemDmgMultiplierLogStr = "";
		if (ElemAtkType == EAbnormalStateType.None)
		{
			return 1f;
		}
		float num = 0f;
		float num2 = 0f;
		switch (ElemAtkType)
		{
		case EAbnormalStateType.Abnormal_Freeze:
			num = VictimAttrCon.GetFloatValue(EBGUAttrFloat.FreezeDef);
			num2 = Attacker_AttrMemData.Attr_FreezeAtk;
			break;
		case EAbnormalStateType.Abnormal_Burn:
			num = VictimAttrCon.GetFloatValue(EBGUAttrFloat.BurnDef);
			num2 = Attacker_AttrMemData.Attr_BurnAtk;
			break;
		case EAbnormalStateType.Abnormal_Poison:
			num = VictimAttrCon.GetFloatValue(EBGUAttrFloat.PoisonDef);
			num2 = Attacker_AttrMemData.Attr_PoisonAtk;
			break;
		case EAbnormalStateType.Abnormal_Thunder:
			num = VictimAttrCon.GetFloatValue(EBGUAttrFloat.ThunderDef);
			num2 = Attacker_AttrMemData.Attr_ThunderAtk;
			break;
		case EAbnormalStateType.Abnormal_Yin:
			num = VictimAttrCon.GetFloatValue(EBGUAttrFloat.YinDef);
			break;
		case EAbnormalStateType.Abnormal_Yang:
			num = VictimAttrCon.GetFloatValue(EBGUAttrFloat.YangDef);
			break;
		}
		float num3 = 1f - FMath.Max(-1f, 0.9f * (num / (num + 36f)));
		_ = Attacker_AttrMemData.Attr_IgnoreTargetElemDef;
		float num4 = num - num2;
		if (Attacker_AttrMemData.Attr_IgnoreTargetElemDef)
		{
			num4 = 0f - num2;
		}
		num3 = ((!(num4 >= 0f)) ? (1f + 0.9f * num4 / (num4 - 72f)) : (1f - 0.9f * num4 / (num4 + 36f)));
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			string text = "";
			text = ElemAtkType switch
			{
				EAbnormalStateType.Abnormal_Freeze => "冰属性", 
				EAbnormalStateType.Abnormal_Burn => "火属性", 
				EAbnormalStateType.Abnormal_Poison => "毒属性", 
				EAbnormalStateType.Abnormal_Thunder => "雷属性", 
				_ => "无属性", 
			};
			ElemDmgMultiplierLogStr += $"<action>攻击者</><effect>{text}</><action>攻击力：</><effect>{num2}</>\n";
			ElemDmgMultiplierLogStr += $"<action>受击者</><effect>{text}</><action>抗性：</><effect>{num}</>\n";
			if (Attacker_AttrMemData.Attr_IgnoreTargetElemDef)
			{
				ElemDmgMultiplierLogStr += "<action>攻击者无视对方属性抗性（ESimpleState::IgnoreTargetElemDef）</>\n";
			}
			ElemDmgMultiplierLogStr += $"<action>最终属性抗性值 = 属性攻击 - 属性抗性 ：{num4}</>\n";
			if (num4 >= 0f)
			{
				ElemDmgMultiplierLogStr += $"<action>属性伤害倍数 = 1 - 0.9*属性抗性/(属性抗性+36)：</><effect>{num3}</>\n";
			}
			else
			{
				ElemDmgMultiplierLogStr += $"<action>属性伤害倍数 = 1 + 0.9*属性抗性/(属性抗性-72)))：</><effect>{num3}</>\n";
			}
		}
		return num3;
	}

	private float CalcYinYangDmgMultiplier(AActor Attacker, AActor Victim)
	{
		float result = 1f;
		if ((BGUFuncLib_AbnormalState.IsInFinalAbnormalState(Victim, EAbnormalStateType.Abnormal_Yin) && BGUFuncLib_AbnormalState.IsInFinalAbnormalState(Attacker, EAbnormalStateType.Abnormal_Yang)) || (BGUFuncLib_AbnormalState.IsInFinalAbnormalState(Victim, EAbnormalStateType.Abnormal_Yang) && BGUFuncLib_AbnormalState.IsInFinalAbnormalState(Attacker, EAbnormalStateType.Abnormal_Yin)))
		{
			BGU_ActorType actorType = BGU_DataUtil.GetActorType(Victim);
			BGU_ActorType actorType2 = BGU_DataUtil.GetActorType(Attacker);
			BGUGlobalConfigInfo ConfigInfo4;
			if (actorType2 == BGU_ActorType.CharacterPlayer && actorType == BGU_ActorType.CharacterPlayer)
			{
				if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.YinYangDmgMultiplier_PlayerHitPlayer, out var ConfigInfo))
				{
					result = ConfigInfo.FloatValue;
				}
			}
			else if (actorType2 == BGU_ActorType.CharacterAI && actorType == BGU_ActorType.CharacterPlayer)
			{
				if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.YinYangDmgMultiplier_MonsterHitPlayer, out var ConfigInfo2))
				{
					result = ConfigInfo2.FloatValue;
				}
			}
			else if (actorType2 == BGU_ActorType.CharacterPlayer && actorType == BGU_ActorType.CharacterAI)
			{
				if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.YinYangDmgMultiplier_PlayerHitMonster, out var ConfigInfo3))
				{
					result = ConfigInfo3.FloatValue;
				}
			}
			else if (actorType2 == BGU_ActorType.CharacterAI && actorType == BGU_ActorType.CharacterAI && BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.YinYangDmgMultiplier_MonsterHitMonster, out ConfigInfo4))
			{
				result = ConfigInfo4.FloatValue;
			}
		}
		return result;
	}

	private void HandleDmgCovertToMPReduce(PartInfoData PartInfo, in FDamageDescParam DamageDescParam, in FBattleAttrSnapShot Attacker_AttrMemData)
	{
		float num = DamageDescParam.BaseDamageRatio / 10000f;
		float baseDamage = DamageDescParam.BaseDamage;
		float num2 = Attacker_AttrMemData.Attr_Atk * num + baseDamage;
		if (DamageDescParam.TargetCurHpRatio > 0f)
		{
			float num3 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.Hp) * DamageDescParam.TargetCurHpRatio / 10000f;
			num3 = FMath.Clamp(num3, 0f, num3);
			num2 += num3;
		}
		float floatValue = VictimAttrCon.GetFloatValue(EBGUAttrFloat.HpMax);
		float floatValue2 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.MpMax);
		float num4 = num2 / floatValue * floatValue2 * PartInfo.MPConvertRatio;
		base.BUSEventCollection?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Mp, 0f - num4);
	}

	private void HandleDmgCovertToStaminaReduce(PartInfoData PartInfo, in FDamageDescParam DamageDescParam, in FBattleAttrSnapShot Attacker_AttrMemData)
	{
		float num = DamageDescParam.BaseDamageRatio / 10000f;
		float baseDamage = DamageDescParam.BaseDamage;
		float num2 = Attacker_AttrMemData.Attr_Atk * num + baseDamage;
		if (DamageDescParam.TargetCurHpRatio > 0f)
		{
			float num3 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.Hp) * DamageDescParam.TargetCurHpRatio / 10000f;
			num3 = FMath.Clamp(num3, 0f, num3);
			num2 += num3;
		}
		float floatValue = VictimAttrCon.GetFloatValue(EBGUAttrFloat.HpMax);
		float floatValue2 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.StaminaMax);
		float num4 = num2 / floatValue * floatValue2 * PartInfo.StaminaConvertRatio;
		base.BUSEventCollection?.Evt_IncreaseAttrFloat.Invoke(EBGUAttrFloat.Stamina, 0f - num4);
	}

	private void HandlePartHitExpandAttrResult(PartInfoData PartInfo, FPartHitExpandInfo PartHitExpandInfo, float DamageValue)
	{
		foreach (FPartHitAttrRecoverConfig partHitAttrConfig in PartHitExpandInfo.PartHitAttrConfigList)
		{
			EBGUAttrFloat attrID = EBGUAttrFloat.None;
			switch (partHitAttrConfig.RecoverAttrType)
			{
			case EHitPartRecoverAttrType.Hp:
				attrID = EBGUAttrFloat.Hp;
				break;
			case EHitPartRecoverAttrType.Mp:
				attrID = EBGUAttrFloat.Mp;
				break;
			case EHitPartRecoverAttrType.Stamina:
				attrID = EBGUAttrFloat.Stamina;
				break;
			case EHitPartRecoverAttrType.Pevalue:
				attrID = EBGUAttrFloat.Pevalue;
				break;
			case EHitPartRecoverAttrType.TransEnergy:
				attrID = EBGUAttrFloat.CurEnergy;
				break;
			}
			float num = 0f;
			switch (partHitAttrConfig.RecoverAttrConversionType)
			{
			case EHitPartRecoverAttrConversionType.ByValue:
				num = DamageValue;
				break;
			case EHitPartRecoverAttrConversionType.ByRatio:
			{
				float floatValMax = VictimAttrCon.GetFloatValMax(attrID);
				num = DamageValue / PartInfo.MaxPartDamagedValue * floatValMax;
				break;
			}
			}
			float num2 = partHitAttrConfig.DamageConversionRatio * 0.0001f * num;
			switch (partHitAttrConfig.ValueClampType)
			{
			case EValueClampType.Value:
				num2 = FMath.Clamp(num2, partHitAttrConfig.MinValue, partHitAttrConfig.MaxValue);
				break;
			case EValueClampType.MaxRatio:
			{
				float floatValMax2 = VictimAttrCon.GetFloatValMax(attrID);
				num2 = FMath.Clamp(num2, partHitAttrConfig.MinValue * 0.0001f * floatValMax2, partHitAttrConfig.MaxValue * 0.0001f * floatValMax2);
				break;
			}
			}
			if (partHitAttrConfig.RecoverAttrType == EHitPartRecoverAttrType.Pevalue)
			{
				base.BUSEventCollection?.Evt_IncreasePEValue.Invoke(num2, EPotentialEnergyIncreaseReason.Normal);
			}
			else
			{
				base.BUSEventCollection?.Evt_IncreaseAttrFloat.Invoke(attrID, num2);
			}
		}
	}

	private void DoDmg_B1_V2(AActor Attacker, bool IsCrit, float DmgNoiseMul, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FBattleAttrSnapShot Attacker_AttrMemData, out float FinalDamageValue, out float FinalDmgForPart, out float FinalElementDmgValue, bool bPrintLog = true)
	{
		FinalDamageValue = 0f;
		FinalDmgForPart = 0f;
		FinalElementDmgValue = 0f;
		float num = 0f;
		float num2 = DamageDescParam.BaseDamageRatio / 10000f;
		float baseDamage = DamageDescParam.BaseDamage;
		float num3 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.DmgDef) / 10000f;
		float num4 = Attacker_AttrMemData.Attr_DmgAddition / 10000f;
		float num5 = FMath.Max(0.2f, (1f - num3) * (1f + num4));
		float num6 = CalcYinYangDmgMultiplier(Attacker, Owner);
		num = (Attacker_AttrMemData.Attr_Atk * num2 + baseDamage) * num5 * num6;
		float num7 = 0f;
		FUStUnitBattleInfoExtendDesc unitBattleInfoExtendDesc = BGW_GameDB.GetUnitBattleInfoExtendDesc(BGU_DataUtil.GetFinalBattleInfoExtendID(Attacker));
		if (unitBattleInfoExtendDesc != null)
		{
			num7 = unitBattleInfoExtendDesc.TrueDamageRatio;
		}
		BGU_ActorType actorType = BGU_DataUtil.GetActorType(Owner);
		float floatValue = VictimAttrCon.GetFloatValue(EBGUAttrFloat.HpMax);
		float num8 = floatValue;
		if (actorType == BGU_ActorType.CharacterPlayer)
		{
			num8 = GetLevelPlayerDesiredHPMax();
		}
		float num9 = floatValue / num8;
		if (B1Global.GIsBossRushMode && BossRushData != null && OwnerAsCharacterCS.IsPlayerControlled())
		{
			bool flag = false;
			foreach (int debuff in BossRushData.BossRushBattleData.DebuffList)
			{
				BossRushDebuffDesc bossRushDebuffDesc = GameDBRuntime.GetBossRushDebuffDesc(debuff);
				if (bossRushDebuffDesc != null && bossRushDebuffDesc.DebuffId == 1)
				{
					flag = true;
					break;
				}
			}
			if (flag && BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.BossRushDesiredHPRatio_ForTrueDmg, out var ConfigInfo))
			{
				num9 = ConfigInfo.FloatValue;
			}
		}
		float num10 = num * num7 * num9;
		float elementDmgRatio = BGW_GameDB.GetElementDmgRatio(DamageDescParam.ElementDmgLevel);
		float num11 = elementDmgRatio * (1f - num7);
		string ElemDmgMultiplierLogStr;
		float num12 = CalcElemDmgMultiplierV2(DamageDescParam.ElemAtkType, Attacker_AttrMemData, out ElemDmgMultiplierLogStr);
		float num13 = (FinalElementDmgValue = num * num11 * num12);
		float num14 = 1f - num7 - num11;
		float num15 = 1f;
		string text = "";
		if (IsCrit)
		{
			float attr_CritMultiplier = Attacker_AttrMemData.Attr_CritMultiplier;
			float critDamageAddition = DamageDescParam.CritDamageAddition;
			float floatValue2 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.CritDmgMulDef);
			num15 = FMath.Max(1f, 1.3f + (attr_CritMultiplier + critDamageAddition - floatValue2) / 10000f);
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				text = text + "<action>发生了暴击</>\n" + $"<action>攻击方暴击伤害：</><effect>{attr_CritMultiplier}</>\n" + $"<action>技能暴击倍率加成：</><effect>{critDamageAddition}</>\n" + $"<action>防御方暴击伤害减免：</><effect>{floatValue2}</>\n";
			}
		}
		else if (DebugConfig.IsOpenBattleInfoTool)
		{
			text += "<action>没有发生暴击</>\n";
		}
		float num16 = 0f;
		float floatValue3 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.Def);
		num16 = 1f - 0.48f * floatValue3 / (90f + 0.52f * FMath.Abs(floatValue3));
		float num17 = num * num14 * num16 * num15 * DmgNoiseMul;
		string text2 = "";
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueDmgExceptElementDmg))
		{
			text2 = "<action>存在状态：免疫非属性伤害</>\n";
			FinalDamageValue = num13;
		}
		else
		{
			FinalDamageValue = num10 + num13 + num17;
		}
		string text3 = "";
		if (DamageDescParam.TargetCurHpRatio > 0f)
		{
			float floatValue4 = VictimAttrCon.GetFloatValue(EBGUAttrFloat.Hp);
			float num18 = floatValue4 * DamageDescParam.TargetCurHpRatio / 10000f;
			num18 = FMath.Clamp(num18, 0f, num18);
			FinalDamageValue += num18;
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				text3 = text3 + "<effect>--------------------------附加生命百分比伤害----------------------</>\n" + $"<action>目标当前生命：</><effect>{floatValue4}</>\n" + $"<action>附加目标当前生命伤害万分比：</><effect>{DamageDescParam.TargetCurHpRatio}</>\n" + $"<action>附加目标当前生命伤害：</><effect>{num18}</>\n";
			}
		}
		FinalDamageValue = (int)FinalDamageValue;
		FinalDmgForPart = FinalDamageValue + DamageDescParam.PartDamage;
		string text4 = "";
		PartInfoData PartInfoOut;
		bool partInfo = VictimPartMgrData.GetPartInfo(DamageDynamicParam.HitPartID, out PartInfoOut);
		if (partInfo && PartInfoOut.IsActive && !PartInfoOut.IsBreak)
		{
			if (PartInfoOut.CanReduceUnitHP)
			{
				float num19 = 1f + PartInfoOut.ReduceHPAdditionRatio * 0.0001f;
				FinalDamageValue *= num19;
				FinalElementDmgValue *= num19;
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					text4 = text4 + "<effect>------------------------部位伤害加深---------------</>\n" + $"<action>本次命中部位，开启了伤害加深，加深系数为(负数会被优化成0)：</><effect>{PartInfoOut.ReduceHPAdditionRatio}</>\n";
				}
			}
			else
			{
				FinalDamageValue = 0f;
				FinalElementDmgValue = 0f;
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					text4 += "<effect>------------------------部位伤害加深---------------</>\n<action>本次命中部位，未开启伤害加深，最终伤害为：0</>\n";
				}
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool && bPrintLog)
		{
			string text5 = "";
			if (SkillDamageConfig.DmgReason == EDamageReason.Skill)
			{
				text5 = $"<action>伤害SkillEffectID：</><effect>{SkillDamageConfig.DmgReasonEffectID}</>\n";
			}
			else if (SkillDamageConfig.DmgReason == EDamageReason.Buff)
			{
				text5 = $"<action>伤害BuffID：</><effect>{SkillDamageConfig.DmgReasonEffectID}</>\n";
			}
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DamageCalc, "<character>" + Attacker.GetName() + "</><action>对</><bechosed>" + Owner.GetName() + "</><effect>造成伤害：</>\n" + text5 + $"<action>攻击者攻击力：</><effect>{Attacker_AttrMemData.Attr_Atk}</>\n" + $"<action>技能伤害万分比：</><effect>{DamageDescParam.BaseDamageRatio}</>\n" + $"<action>技能伤害绝对值：</><effect>{baseDamage}</>\n" + $"<action>防御方伤害减免：</><effect>{num3}</>\n" + $"<action>攻击方伤害加成：</><effect>{num4}</>\n" + $"<action>伤害倍数 = max(0.2,(1-防御方伤害减免)*(1+攻击方伤害加成) :</><effect>{num5}</>\n" + $"<action>阴阳伤害倍数：</><effect>{num6}</>\n" + $"<action>预计算伤害 = (攻击力*技能伤害万分比 + 技能伤害绝对值) * 伤害倍数 * 阴阳伤害倍数：</><effect>{num}</>\n" + "<effect>----------------------------真实伤害---------------------------</>\n" + $"<action>真实伤害结算比例：</><effect>{num7}</>\n" + $"<action>期望血量上限 ((是玩家?)关卡玩家期望血量上限  否则：单位血量上限)：</><effect>{num8}</>\n" + $"<action>实际血量上限：</><effect>{floatValue}</>\n" + $"<action>真实伤害 = 预计算伤害 * 真实伤害比率 * 实际血量上限 / 期望血量上限：</><effect>{num10}</>\n" + "<effect>----------------------------属性伤害---------------------------</>\n" + $"<action>属性占非真实伤害部分的比率：</><effect>{elementDmgRatio}</>\n" + $"<action>属性伤害比率（占总体）：</><effect>{num11}</>\n" + ElemDmgMultiplierLogStr + $"<action>属性伤害 = 预计算伤害 * 属性伤害比率 * 属性伤害倍率：</><effect>{num13}</>\n" + "<effect>----------------------------物理伤害---------------------------</>\n" + $"<action>物理伤害比率（占总体）：</><effect>{num14}</>\n" + text + $"<action>守方防御：</><effect>{floatValue3}</>\n" + $"<action>防御方伤害承担 = 1 - 0.48 * 守方防御 / (90 + 0.52 * ABS(守方防御))：</><effect>{num16}</>\n" + $"<action>随机数：</><effect>{DmgNoiseMul}</>\n" + $"<action>物理伤害 = 预计算伤害 * 物理伤害比率 * 防御方伤害承担 * 暴击倍数 * 随机数：</><effect>{num17}</>\n" + text3 + text4 + "<effect>----------------------------------------------------</>\n" + text2 + $"<action>最终伤害结算(伤害取整)：</><effect>{FinalDamageValue}</>\n");
		}
		bool num20 = VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ForcePerformance);
		bool flag2 = VictimSimpleStateData.HasSimpleState(EBGUSimpleState.InPhaseTransition);
		if ((num20 || flag2) && partInfo)
		{
			float currentPartDamagedValue = PartInfoOut.CurrentPartDamagedValue;
			if (currentPartDamagedValue - FinalDamageValue <= 0f)
			{
				FinalDmgForPart = currentPartDamagedValue - 1f;
			}
		}
		FinalDamageValue = Math.Max(0f, FinalDamageValue);
		FinalDmgForPart = Math.Max(0f, FinalDmgForPart);
		FinalElementDmgValue = Math.Max(0f, FinalElementDmgValue);
	}

	private float GetLevelPlayerDesiredHPMax()
	{
		float num = 0f;
		int num2 = 1;
		if (PlayerRoleData != null)
		{
			num2 = BGW_GamePlayCountUtil.GetCurGamePlayCount(Owner, PlayerRoleData);
		}
		int valueInGameThread = GSGameplayCVar.CVar_LevelDesiredPlayerHP.GetValueInGameThread();
		if (valueInGameThread > 0)
		{
			num = valueInGameThread;
		}
		else
		{
			if (B1Global.GIsBossRushMode && BossRushData != null && (BossRushData.BossRushType == EBossRushType.BossIterations || BossRushData.BossRushType == EBossRushType.IterationsPractise))
			{
				if (BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.BossRushIterationsLevelDesiredHPMax, out var ConfigInfo))
				{
					return ConfigInfo.FloatValue;
				}
				return 300f;
			}
			if (LevelData != null && LevelData.IsValidLevel())
			{
				LevelDesc levelDesc = GameDBRuntime.FastGetLevelDesc(LevelData.CurrentLevelID);
				num2 = ((num2 > 6) ? 6 : num2);
				if (levelDesc != null && levelDesc.PlayerDesiredHp.Count >= num2)
				{
					num = levelDesc.PlayerDesiredHp[num2 - 1];
				}
			}
		}
		if (num <= 0f)
		{
			num = num2 switch
			{
				1 => 300f, 
				2 => 850f, 
				_ => 900f, 
			};
		}
		return num;
	}

	private float DoElementDotDmg_B1(in FDamageDescParam DamageDescParam, in FBattleAttrSnapShot Attacker_AttrMemData, bool bPrintLog = true)
	{
		float num = 0f;
		float floatValue = VictimAttrCon.GetFloatValue(EBGUAttrFloat.HpMax);
		string ElemDmgMultiplierLogStr;
		float num2 = CalcElemDmgMultiplierV2(DamageDescParam.ElemAtkType, Attacker_AttrMemData, out ElemDmgMultiplierLogStr);
		num = floatValue * DamageDescParam.HPMaxINV10000Damage_Element * 0.0001f * num2;
		num = (int)num;
		if (DebugConfig.IsOpenBattleInfoTool && bPrintLog)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DamageCalc, "<effect>----------------------------属性Dot伤害---------------------------</>\n<bechosed>" + Owner.GetName() + "</><effect>受到属性Dot伤害：</>\n" + $"<action>最大生命上限：</><effect>{floatValue}</>\n" + $"<action>扣减万分比：</><effect>{DamageDescParam.HPMaxINV10000Damage_Element}</>\n" + ElemDmgMultiplierLogStr + "<action>伤害 = 最大生命上限 * 扣减万分比 * 属性伤害倍数</>\n" + $"<action>最终伤害结算：</><effect>{num}</>\n");
		}
		return num;
	}

	private float DoHPMaxRatioAbsDmg_B1(AActor Attacker, in FDamageDescParam DamageDescParam, bool bPrintLog = true)
	{
		float num = 0f;
		float floatValue = VictimAttrCon.GetFloatValue(EBGUAttrFloat.HpMax);
		num = floatValue * DamageDescParam.HPMaxINV10000Damage_Abs * 0.0001f;
		num = (int)num;
		if (DebugConfig.IsOpenBattleInfoTool && bPrintLog)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.DamageCalc, "<effect>----------------------------生命万分比伤害---------------------------</>\n<effect>----------------------------坠落/DeadZone/机制---------------------------</>\n<character>" + Owner.GetName() + "</><action>受到生命万分比伤害</>\n" + $"<action>最大生命上限：</><effect>{floatValue}</>\n" + $"<action>扣减万分比：</><effect>{DamageDescParam.HPMaxINV10000Damage_Abs}</>\n" + $"<action>最终伤害结算：</><effect>{num}</>\n");
		}
		return num;
	}

	private void DoAndSolveDamageExtraLogic(AActor Attacker, float FinalDamageValue, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FSkillDamageConfig SkillDamageConfig, in FEffectInstReq EffectInstReq, out EBeAttackedEvent OutBeAttackedEvent)
	{
		OutBeAttackedEvent = EBeAttackedEvent.Nothing;
		AActor owner = GetOwner();
		if (owner == null || owner as ACharacter == null)
		{
			return;
		}
		int actorResID = BGU_DataUtil.GetActorResID(owner);
		if (BGW_LogUtil.LogIfNull(BGW_GameDB.GetUnitCommDesc(actorResID), "Find UnitCommDesc failed! ResID: {0}", actorResID))
		{
			return;
		}
		List<EBeAttackedEvent> list = new List<EBeAttackedEvent>();
		EBeAttackedEvent eBeAttackedEvent = EBeAttackedEvent.Nothing;
		foreach (BeAttackedEventBase beAttackedEventTemplate in BeAttackedEventTemplateList)
		{
			EBeAttackedEvent eBeAttackedEvent2 = beAttackedEventTemplate.NumericalCalculationProcess(Attacker, FinalDamageValue, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig);
			if (eBeAttackedEvent > eBeAttackedEvent2)
			{
				eBeAttackedEvent = eBeAttackedEvent2;
			}
			list.Add(eBeAttackedEvent2);
		}
		if (eBeAttackedEvent < EBeAttackedEvent.ImmobilizedBreak)
		{
			if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && eBeAttackedEvent != EBeAttackedEvent.Dead)
			{
				SolveBreakImmobilized(Attacker, in DamageDynamicParam, in DamageDescParam, in EffectInstReq, in SkillDamageConfig, bWithOutBreakAM: true);
			}
			if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
			{
				base.BUSEventCollection?.Evt_EndFrozen.Invoke();
			}
		}
		foreach (BeAttackedEventBase beAttackedEventTemplate2 in BeAttackedEventTemplateList)
		{
			beAttackedEventTemplate2.EventSettlementProcess(Attacker, eBeAttackedEvent, in DamageDynamicParam, in DamageDescParam, in SkillDamageConfig, in EffectInstReq);
		}
		OutBeAttackedEvent = eBeAttackedEvent;
		if (!DebugConfig.IsOpenBattleInfoTool)
		{
			return;
		}
		StringBuilder stringBuilder = new StringBuilder();
		List<EBeAttackedEvent> list2 = list.Distinct().ToList();
		for (int i = 0; i < list2.Count; i++)
		{
			if (list2[i] != EBeAttackedEvent.Nothing)
			{
				stringBuilder.Append(list2[i].ToString());
				if (i < list2.Count - 1)
				{
					stringBuilder.Append("、");
				}
				else
				{
					stringBuilder.Append("，");
				}
			}
		}
		if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueStiff))
		{
			stringBuilder.Append("存在免疫硬直状态，");
		}
		int num = ((SkillDamageConfig.DmgReason == EDamageReason.Skill || SkillDamageConfig.DmgReason == EDamageReason.Buff) ? SkillDamageConfig.DmgReasonEffectID : 0);
		BGUFunctionLibraryCS.LogBattleInfo(GetOwner(), EBattleInfoType.BeAttacked, $"<character>{GetOwner().GetName()}</><action>受到了来自</><bechosed>{Attacker?.GetName()}</><action>的攻击，StiffLevel = </><effect>{DamageDynamicParam.StiffLevel}</><action>，DmgID = </><effect>{num}</><action>，攻击者朝向是：</><effect>{DamageDynamicParam.AttackerArea}</><action>，触发了受击事件</><effect>{stringBuilder}</><action>最后触发的事件是</><effect>{eBeAttackedEvent}</>");
	}

	private void SolveHitVEffectLogic(AActor Attacker, int VEffectID, bool IsCrit)
	{
		if (Attacker as BGUCharacterCS == null)
		{
			return;
		}
		BUC_UnitHitVEffectData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_UnitHitVEffectData>(Attacker);
		float timeSeconds = Owner.World.GetTimeSeconds();
		if (readOnlyData == null || readOnlyData.CheckIsInFreezeFrameGap(timeSeconds))
		{
			return;
		}
		float num = 0f;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Attacker);
		if (readOnlyData.CanTriggerSlowIK())
		{
			num = (IsCrit ? FMath.Max(readOnlyData.SlowTime_Crit, readOnlyData.SlowTime) : readOnlyData.SlowTime);
			bUS_GSEventCollection.Evt_TriggerSlowIK.Invoke(readOnlyData.SlowIKType, num);
			num *= 0.3f;
		}
		else
		{
			FUStHitVEffectDesc hitVEffectDesc = BGW_GameDB.GetHitVEffectDesc(VEffectID);
			if (hitVEffectDesc == null)
			{
				return;
			}
			num = (IsCrit ? hitVEffectDesc.CritFreezeFrameTime : hitVEffectDesc.FreezeFrameTime);
			if (num <= 0f)
			{
				return;
			}
			bUS_GSEventCollection.Evt_TriggerFreezeFrame.Invoke(num, hitVEffectDesc.FreezeFrameGap);
		}
		if (num <= 0f)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = Owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(bGUCharacterCS.GetResID());
			if (unitCommDesc != null && unitCommDesc.CanApplyFreezeFrame != EGSYesNo.No && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.DisableFreezeFrame) && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
			{
				float victimFreezeFrameGap = unitCommDesc.VictimFreezeFrameGap;
				base.BUSEventCollection?.Evt_TriggerFreezeFrame.Invoke(num, victimFreezeFrameGap, EnableCache: true, VictimBeAttackData.IsPlayedMontage());
			}
		}
	}

	private void SolveBreakSuperSkillArmorLogic(AActor Attacker, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FEffectInstReq EffectInstReq, in FSkillDamageConfig SkillDamageConfig)
	{
		if (!(GetOwner() == null) && IsSuperArmorBreak())
		{
			if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
			{
				base.BUSEventCollection?.Evt_RelieveImmobilized.Invoke();
			}
			base.BUSEventCollection?.Evt_PlayBRKSuperSkillArmorMontage.Invoke();
			if (!VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BreakSkillSuperArmor) && DamageDescParam.AttackStiffEffectID > 0)
			{
				SolveNormalStiff(Attacker, in DamageDynamicParam, in DamageDescParam, in EffectInstReq, in SkillDamageConfig);
			}
		}
	}

	private void SolveBreakImmobilized(AActor Attacker, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FEffectInstReq EffectInstReq, in FSkillDamageConfig SkillDamageConfig, bool bWithOutBreakAM = false)
	{
		if (OwnerAsCharacterCS == null)
		{
			return;
		}
		BGWDataAsset_UnitBeAttackedConfig nowUseUBAConfig = DamageDynamicParam.NowUseUBAConfig;
		UAnimMontage uAnimMontage = null;
		bool bIsNormalStiff = false;
		if (!bWithOutBreakAM && nowUseUBAConfig != null && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.DisableImmobilizedBreakAnim))
		{
			if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.EnableSpecialImmobilizedBreakAnim))
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerAsCharacterCS);
				FVector actorForwardVector = OwnerAsCharacterCS.GetActorForwardVector();
				FVector victimToAttackerDir = ((Attacker != null) ? BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker) : (actorForwardVector * 100.0 + fVector)) - fVector;
				switch (BGUFuncLibBeAttackedAndUnitDeathDispCS.GetAttackerAreaByUBAConfig(DamageDynamicParam.StiffLevel, nowUseUBAConfig, actorForwardVector, victimToAttackerDir))
				{
				case EAttackerArea.Forward:
					uAnimMontage = nowUseUBAConfig.ImmobilizeBreakForwardAM;
					break;
				case EAttackerArea.LeftSide:
					uAnimMontage = nowUseUBAConfig.ImmobilizeBreakLeftsideAM;
					break;
				case EAttackerArea.RightSide:
					uAnimMontage = nowUseUBAConfig.ImmobilizeBreakRightsideAM;
					break;
				case EAttackerArea.Backward:
					uAnimMontage = nowUseUBAConfig.ImmobilizeBreakBackwardAM;
					break;
				}
			}
			if (uAnimMontage == null)
			{
				FDamageDynamicParam DamageDynamicParam2 = DamageDynamicParam;
				int partMappingBeAttackedInfoID = GetPartMappingBeAttackedInfoID(VictimBeAttackData.GetCurrentBeAttackedInfoID(), DamageDynamicParam.HitPartID);
				uAnimMontage = GetMontagePathByRule(partMappingBeAttackedInfoID, DamageDynamicParam.StiffLevel, DamageDynamicParam.AttackerArea, EffectInstReq.HitActionDir, nowUseUBAConfig, out var HasValidConfigOrData);
				if (uAnimMontage == null)
				{
					int num = int.MaxValue;
					foreach (FNormalStiffInfo normalStiffInfo in nowUseUBAConfig.NormalStiffInfoList)
					{
						if (normalStiffInfo.StiffLevelID < num)
						{
							num = normalStiffInfo.StiffLevelID;
						}
					}
					uAnimMontage = GetMontagePathByRule(partMappingBeAttackedInfoID, num, DamageDynamicParam.AttackerArea, EffectInstReq.HitActionDir, nowUseUBAConfig, out HasValidConfigOrData);
					DamageDynamicParam2.StiffLevel = num;
				}
				bIsNormalStiff = true;
				SolveNormalStiff(Attacker, in DamageDynamicParam2, in DamageDescParam, in EffectInstReq, in SkillDamageConfig);
			}
		}
		base.BUSEventCollection.Evt_TriggerImmobilizedBreak.Invoke(Attacker, DamageDynamicParam.StiffLevel, in EffectInstReq, uAnimMontage, bIsNormalStiff);
	}

	private void SolveBreakFrozen(AActor Attacker, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FEffectInstReq EffectInstReq, in FSkillDamageConfig SkillDamageConfig)
	{
		if (OwnerAsCharacterCS == null)
		{
			return;
		}
		bool bIsNormalStiff = false;
		UAnimMontage uAnimMontage = null;
		if (!VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueFrozenBrokenAM))
		{
			BGWDataAsset_UnitBeAttackedConfig nowUseUBAConfig = DamageDynamicParam.NowUseUBAConfig;
			if (nowUseUBAConfig != null)
			{
				uAnimMontage = nowUseUBAConfig.FrozenBreakAM;
				if (uAnimMontage == null)
				{
					FDamageDynamicParam DamageDynamicParam2 = DamageDynamicParam;
					int partMappingBeAttackedInfoID = GetPartMappingBeAttackedInfoID(VictimBeAttackData.GetCurrentBeAttackedInfoID(), DamageDynamicParam.HitPartID);
					uAnimMontage = GetMontagePathByRule(partMappingBeAttackedInfoID, DamageDynamicParam.StiffLevel, DamageDynamicParam.AttackerArea, EffectInstReq.HitActionDir, nowUseUBAConfig, out var HasValidConfigOrData);
					if (uAnimMontage == null)
					{
						int num = int.MaxValue;
						foreach (FNormalStiffInfo normalStiffInfo in nowUseUBAConfig.NormalStiffInfoList)
						{
							if (normalStiffInfo.StiffLevelID < num)
							{
								num = normalStiffInfo.StiffLevelID;
							}
						}
						uAnimMontage = GetMontagePathByRule(partMappingBeAttackedInfoID, num, DamageDynamicParam.AttackerArea, EffectInstReq.HitActionDir, nowUseUBAConfig, out HasValidConfigOrData);
						DamageDynamicParam2.StiffLevel = num;
					}
					bIsNormalStiff = true;
					SolveNormalStiff(Attacker, in DamageDynamicParam2, in DamageDescParam, in EffectInstReq, in SkillDamageConfig);
				}
			}
		}
		base.BUSEventCollection.Evt_TriggerFrozenBreak.Invoke(in EffectInstReq, uAnimMontage, bIsNormalStiff);
	}

	private void SolveBlockRelatedLogic(EBeAttackedEvent CurrentEvent, AActor Attacker, int HitLevel, EHitActionDir HitActionDir)
	{
		if (GetOwner() == null)
		{
			return;
		}
		switch (CurrentEvent)
		{
		case EBeAttackedEvent.BlockArmorHit:
			if (VictimUnitStateData.HasState(EBGUUnitState.BlockBeatBack) || VictimUnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack))
			{
				base.BUSEventCollection?.Evt_PlayBlockBouncedMontage.Invoke(Attacker);
			}
			break;
		case EBeAttackedEvent.BlockArmorBreak:
			if ((VictimUnitStateData.HasState(EBGUUnitState.BlockBeatBack) || VictimUnitStateData.HasState(EBGUUnitState.PerfectBlockBeatBack) || VictimSimpleStateData.HasSimpleState(EBGUSimpleState.CanTriggerBlockNormal)) && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BreakBlock) && VictimAttrCon.GetFloatValue(EBGUAttrFloat.BlockCollapseArmor) <= 0f)
			{
				if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
				{
					base.BUSEventCollection?.Evt_RelieveImmobilized.Invoke();
				}
				base.BUSEventCollection?.Evt_PlayBRKBlockCollapseArmorMontage.Invoke(Attacker);
			}
			break;
		case EBeAttackedEvent.BlockArmorBreak2Weak:
			if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BreakBlock) && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BreakBlock2Weak))
			{
				base.BUSEventCollection?.Evt_PlayBRKBlockArmor2WeakMontage.Invoke(Attacker);
			}
			break;
		}
	}

	private void SolveBreakPartLogic(int HitPartID, AActor Attacker, EAttackerArea AttackerArea)
	{
		if (!(GetOwner() == null) && (!VictimSimpleStateData.HasSimpleState(EBGUSimpleState.BreakPart2Weak) || VictimPartMgrData.CanInterruptLastPartBreak(HitPartID)) && HitPartID != -1 && VictimPartMgrData.IsPartBreakInCurrentStage(HitPartID))
		{
			if (VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing))
			{
				base.BUSEventCollection?.Evt_RelieveImmobilized.Invoke();
			}
			string actorGuid = BGU_DataUtil.GetActorGuid(Attacker);
			base.BUSEventCollection?.Evt_PlayBreakPartMontage.Invoke(HitPartID, actorGuid, AttackerArea);
		}
	}

	private void SolveCounterAttack()
	{
		if (!(GetOwner() == null) && VictimArmorData.CanTriggerCounterFightBack() && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Immobilizing) && !VictimSimpleStateData.HasSimpleState(EBGUSimpleState.Frozen))
		{
			base.BUSEventCollection?.Evt_TriggerCounterAttack.Invoke(!VictimUnitStateData.HasState(EBGUUnitState.Attacking) && !VictimUnitStateData.HasState(EBGUUnitState.Beatback));
			if (VictimArmorData.IsInPreHRCounterattacking() && !VictimArmorData.IsInPreHRCounterattackingSuperArmor() && VictimUnitStateData.HasState(EBGUUnitState.Beatback))
			{
				base.BUSEventCollection?.Evt_CounterAttackSuperArmor.Invoke();
			}
		}
	}

	private void SolveNormalStiff(AActor Attacker, in FDamageDynamicParam DamageDynamicParam, in FDamageDescParam DamageDescParam, in FEffectInstReq EffectInstReq, in FSkillDamageConfig SkillDamageConfig, EBeAttackedEvent CurAttackedEvent = EBeAttackedEvent.NormalStiff)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null || aCharacter.IsPendingKill)
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(DamageDescParam.AttackStiffEffectID, Owner);
		if (skillEffectDesc == null || VictimUnitStateData.HasState(EBGUUnitState.Dead) || VictimUnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || VictimSimpleStateData.HasSimpleState(EBGUSimpleState.ImmueStiff) || VictimSimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			return;
		}
		int currentBeAttackedInfoID = VictimBeAttackData.GetCurrentBeAttackedInfoID();
		FUStBeAttackedInfoDesc beAttackedInfoDesc = BGW_GameDB.GetBeAttackedInfoDesc(currentBeAttackedInfoID);
		if (beAttackedInfoDesc == null)
		{
			return;
		}
		BGWDataAsset_UnitBeAttackedConfig nowUseUBAConfig = DamageDynamicParam.NowUseUBAConfig;
		if (nowUseUBAConfig == null || (CurAttackedEvent == EBeAttackedEvent.FightBack && !VictimArmorData.IsInPreHRCounterattacking()))
		{
			return;
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>==============普通硬直流程开始==============</>");
		}
		float hitWeight = skillEffectDesc.EffectParamsFloat[0];
		float additionHeight = 0f;
		float additionTime = 0f;
		float rotateToTargetOffset = 0f;
		if (skillEffectDesc.EffectParamsFloat.Count >= 6)
		{
			additionHeight = skillEffectDesc.EffectParamsFloat[4];
			additionTime = skillEffectDesc.EffectParamsFloat[5];
			rotateToTargetOffset = ((skillEffectDesc.EffectParamsFloat.Count >= 7) ? skillEffectDesc.EffectParamsFloat[6] : 0f);
		}
		int hitPartID = DamageDynamicParam.HitPartID;
		int stiffLevel = DamageDynamicParam.StiffLevel;
		EAttackerArea attackerArea = DamageDynamicParam.AttackerArea;
		VictimBeAttackData.SetLastBeAttackedStiffLevel(stiffLevel);
		AActor aActor = Attacker;
		if (BGU_DataUtil.GetActorType(Attacker) == BGU_ActorType.Bullet || BGU_DataUtil.GetActorType(Attacker) == BGU_ActorType.MagicField)
		{
			aActor = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Attacker)?.GetMasterActor();
		}
		base.BUSEventCollection?.Evt_ClearSweepCheckData.Invoke();
		base.BGWEventCollection?.Evt_BGW_TriggerAttackStiff(Owner, aActor, stiffLevel);
		base.BGWEventCollection?.Evt_BGW_TriggerAttackStiff_ListenAttacker(Owner, aActor, stiffLevel);
		base.BUSEventCollection?.Evt_TriggerAttackStiff.Invoke(aActor, stiffLevel, hitWeight);
		bool flag = VictimUnitStateData.HasState(EBGUUnitState.JumpMoving);
		if (flag && stiffLevel <= nowUseUBAConfig.HitLevelDivide_Jump)
		{
			base.BUSEventCollection?.Evt_PlayBeAttackedAdditiveAnim_Jump.Invoke(BGUFuncLibBeAttackedAndUnitDeathDispCS.GetHitActionDirVector(EffectInstReq.HitActionDir));
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>跳跃状态，触发叠加受击</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>==============普通硬直流程结束==============</>");
			}
			return;
		}
		if (VictimUnitStateData.HasState(EBGUUnitState.GlideMoving))
		{
			base.BUSEventCollection?.Evt_PlayBeAttackedAdditiveAnim_Jump.Invoke(BGUFuncLibBeAttackedAndUnitDeathDispCS.GetHitActionDirVector(EffectInstReq.HitActionDir));
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>滑沙状态，触发叠加受击【现在暂时用跳跃的叠加动画】</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>==============普通硬直流程结束==============</>");
			}
			return;
		}
		int num = -1;
		bool IsValid = true;
		UAnimMontage uAnimMontage;
		if (flag)
		{
			uAnimMontage = nowUseUBAConfig.BeAttackedAnim_Jump;
		}
		else
		{
			num = GetPartMappingBeAttackedInfoID(currentBeAttackedInfoID, hitPartID);
			uAnimMontage = GetMontagePathByRule(num, stiffLevel, attackerArea, EffectInstReq.HitActionDir, nowUseUBAConfig, out var _);
			BGUFuncLibBeAttackedAndUnitDeathDispCS.GetActualStiffLevelInfo(stiffLevel, nowUseUBAConfig, out IsValid, out var _);
		}
		int SkillDamageExpandID;
		FUStSkillDamageExpandDesc skillDamageExpandDesc = BGW_GameDB.GetSkillDamageExpandDesc(SkillDamageConfig.DmgReasonEffectID, Attacker, out SkillDamageExpandID);
		if (skillDamageExpandDesc != null && skillDamageExpandDesc.PillarFormTerminatorType == EPillarFormTerminatorType.BreakPillarForm && BGW_GameDB.GetGlobalConfigByAlias(B1GlobalConfigFNames.PillarFormStateBuff, out var ConfigInfo))
		{
			int intValue = ConfigInfo.IntValue;
			if (VictimBuffData.HasBuff(intValue))
			{
				uAnimMontage = nowUseUBAConfig.BeAttackedAnim_PillarFormBreak;
			}
		}
		if (uAnimMontage == null)
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				string text = (IsValid ? "找不到对应的普通硬直动画" : "找不到对应的挡位信息");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, $"<character>{Owner?.GetName()}</><action>{text}，麻烦确认配置是否正常, BeAttackedInfoID = </><effect>{currentBeAttackedInfoID}</><action>, HitPartID = </><effect>{hitPartID}</><action>，PartMappingBeAttackedInfoID = </><effect>{num}</><action>, StiffLevel = </><effect>{stiffLevel}</>");
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>==============普通硬直流程结束==============</>");
			}
			return;
		}
		bool flag2 = CheckCanRotate(stiffLevel, nowUseUBAConfig);
		if (flag || flag2)
		{
			BGUFuncLibBeAttackedAndUnitDeathDispCS.RotateToTargetActor(Attacker, aCharacter, attackerArea, rotateToTargetOffset, skillEffectDesc.HitOrientationType, skillEffectDesc.HitOriBaseCompName, in EffectInstReq);
		}
		VictimBeAttackData.CurrentBeAttackedStiffLevel = stiffLevel;
		VictimBeAttackData.CurrentBeAttackedAttackerGUID = BGU_DataUtil.GetActorGuid(Attacker);
		if (VictimUnitStateData.HasState(EBGUUnitState.FloatingHit))
		{
			base.BUSEventCollection?.Evt_AdditionFloatingHit.Invoke(additionHeight, additionTime);
		}
		else
		{
			if (VictimUnitStateData.HasState(EBGUUnitState.Dead) || VictimUnitStateData.HasState(EBGUUnitState.LifeSavingHair_FakeDead) || (VictimFallDyingData != null && VictimFallDyingData.GetFallDyingState() != EFallDyingState.Alive) || VictimSimpleStateData.HasSimpleState(EBGUSimpleState.PendingDeathInAnimationSyncing))
			{
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>因为状态判断失败，提前结束！</>");
					BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>==============普通硬直流程结束==============</>");
				}
				return;
			}
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, $"<character>{Owner?.GetName()}</><action>受击动画：</><effect>{uAnimMontage.GetPathName()}</><action>, BeAttackedInfoID = </><effect>{currentBeAttackedInfoID}</><action>, HitPartID = </><effect>{hitPartID}</><action>，PartMappingBeAttackedInfoID = </><effect>{num}</><action>, StiffLevel = </><effect>{stiffLevel}</>");
			}
			aCharacter.StopAnimMontage(null);
			base.BUSEventCollection.Evt_OnMagicallyChangeBreak.Invoke();
			base.BUSEventCollection?.Evt_UnitTryBreakSkill.Invoke("受击硬直");
			BeatbackAMResultCheck = EBeatbackAMResultCheck.Pending;
			base.BUSEventCollection?.Evt_MoveWithAnimMontage_BeAttackedClient.Invoke(uAnimMontage, 1f, 1f, 0f, FName.None);
			EBeatbackAMResultCheck beatbackAMResultCheck = BeatbackAMResultCheck;
			BeatbackAMResultCheck = EBeatbackAMResultCheck.None;
			if (beatbackAMResultCheck == EBeatbackAMResultCheck.Success)
			{
				VictimBeAttackData.SetPlayedMontage(bValue: true);
				float sequenceLength = uAnimMontage.SequenceLength;
				UGSE_AnimFuncLib.AnimMontageGetBlendInAndOutTime(uAnimMontage, out var BlendInTime, out var BlendOutTime);
				sequenceLength -= BlendInTime + BlendOutTime;
				base.BUSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, sequenceLength, NeedForceUpdate: true);
				if (VictimArmorData.CanTriggerAddCounterAttackTimes(EFightBackCountType.StiffCount))
				{
					base.BUSEventCollection?.Evt_AddCounterAttackTimes.Invoke();
					if (VictimArmorData.CanTriggerCounterFightBack())
					{
						base.BUSEventCollection?.Evt_TriggerCounterAttack.Invoke(P1: false);
					}
				}
				if (VictimArmorData.IsInPreHRCounterattacking() && !VictimArmorData.IsInPreHRCounterattackingSuperArmor())
				{
					base.BUSEventCollection?.Evt_CounterAttackSuperArmor.Invoke();
				}
			}
		}
		base.BUSEventCollection?.Evt_TriggerAttackStiffForBeImmobilized.Invoke(stiffLevel);
		if ((stiffLevel >= beAttackedInfoDesc.MinHitIntoCliffLevel && stiffLevel <= beAttackedInfoDesc.MaxHitIntoCliffLevel && uAnimMontage != null) || flag)
		{
			float num2 = 0f;
			FVector hitDir = FVector.ZeroVector;
			if (flag)
			{
				num2 = nowUseUBAConfig.BeAttackedAnim_Jump_CliffDistCheck;
				hitDir = BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker) - BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter);
			}
			else if (UBGUFuncLibSkill.BGUGetMontageHasRootMotion(uAnimMontage))
			{
				FTransform fTransform = UGSE_AnimFuncLib.Montage_GetBoneTransformCS(uAnimMontage, uAnimMontage.SequenceLength, B1GlobalFNames.root, FName.None, bExtractRootMotion: false);
				num2 = fTransform.GetLocation().Size2D();
				num2 *= 0.7f;
				hitDir = BGUFuncLibActorTransformCS.BGUGetActorTransform(aCharacter).TransformLocation(fTransform.Translation) - BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter);
			}
			else if (!Attacker.IsNullOrDestroyed() && Attacker != Owner)
			{
				num2 = 500f;
				hitDir = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter) - BGUFuncLibActorTransformCS.BGUGetActorLocation(Attacker);
			}
			if (num2 != 0f)
			{
				base.BUSEventCollection?.Evt_OnBeatBackStartCheck.Invoke(Attacker, hitDir, num2);
			}
		}
		if (DebugConfig.IsOpenBattleInfoTool)
		{
			BGUFunctionLibraryCS.LogBattleInfo(Owner, EBattleInfoType.BeAttacked, "<character>" + Owner?.GetName() + "</><action>==============普通硬直流程结束==============</>");
		}
	}
}
