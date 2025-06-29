using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_HardMoveCompImpl : UActorCompBaseCS
{
	private b1.BUC_HardMoveData HardMoveData;

	private b1.IBUC_MagicFieldParamData MagicFieldParamData;

	private IBUC_SimpleStateData SimpleStateData;

	private IBUC_BuffData BuffData;

	private IBUC_TickRateData TickRateData;

	public override void OnAttach()
	{
		HardMoveData = RequireWritableData<b1.BUC_HardMoveData>();
		MagicFieldParamData = RequireReadOnlyData<b1.IBUC_MagicFieldParamData, b1.BUC_MagicFieldParamData>();
		SimpleStateData = RequireReadOnlyData<IBUC_SimpleStateData, BUC_SimpleStateData>();
		BuffData = RequireReadOnlyData<IBUC_BuffData, BUC_BuffData>();
		TickRateData = RequireReadOnlyData<IBUC_TickRateData, BUC_TickRateData>();
		base.BUSEventCollection.Evt_SetImmuneHardMoveAll += new Del_Bool(OnSetImmuneHardMoveAll);
		base.BUSEventCollection.Evt_SetImmuneHardMoveFrozen += new Del_Bool(OnSetImmuneHardMoveFrozen);
		base.BUSEventCollection.Evt_SetImmuneHardMoveMuddy += new Del_Bool(OnSetImmuneHardMoveMuddy);
		base.BUSEventCollection.Evt_SetImmuneHardMoveWindy += new Del_Bool(OnSetImmuneHardMoveWindy);
		base.BUSEventCollection.Evt_SetImmuneHardMoveSpiderSilk += new Del_Bool(OnSetImmuneHardMoveSpiderSilky);
	}

	public override void PreBeginPlay()
	{
		InitData();
	}

	private void InitData()
	{
		HardMoveData.WindyMoveAffectedHalfAngleForwardCos = FMath.Cos(FMath.DegreesToRadians(HardMoveData.WindyMoveAffectedAngleForward / 2f));
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		float AccumulatedDeltaTime;
		float DifferenceTimeToLast100ms;
		float DifferenceTimeToLast200ms;
		float DifferenceTimeToLast500ms;
		float DifferenceTimeToLast1000ms;
		if (!HardMoveData.bEnableHardMove)
		{
			HardMoveData.bFrozenHardMoving = false;
			HardMoveData.bMuddyHardMoving = false;
			HardMoveData.bWindyHardMoving = false;
			HardMoveData.bSpiderSilkyHardMoving = false;
		}
		else if (TickRateData.CanTickFor200msInterval(out AccumulatedDeltaTime, out DifferenceTimeToLast100ms, out DifferenceTimeToLast200ms, out DifferenceTimeToLast500ms, out DifferenceTimeToLast1000ms))
		{
			UpdateWindyMoveWindDirection();
			UpdateHardMovingState();
			UpdateWinddyMoveState();
		}
	}

	private void UpdateWindyMoveWindDirection()
	{
		HardMoveData.WindyMoveWindDirection = EMoveDirection.None;
		if (SimpleStateData.HasSimpleState(EBGUSimpleState.WinddyMoving))
		{
			FVector a = -MagicFieldParamData.GetMFDirectionByUsage(EMagicFieldDirectionUsage.WindyMove).GetSafeNormal();
			if (FVector.DotProduct(a, Owner.GetActorForwardVector()) > HardMoveData.WindyMoveAffectedHalfAngleForwardCos)
			{
				HardMoveData.WindyMoveWindDirection = EMoveDirection.Forward;
			}
			else
			{
				HardMoveData.WindyMoveWindDirection = EMoveDirection.Backward;
			}
		}
	}

	private void UpdateWinddyMoveState()
	{
		bool flag = HardMoveData.bWindyHardMoving && HardMoveData.WindyMoveWindDirection == EMoveDirection.Forward;
		bool flag2 = HardMoveData.bWindyHardMoving && HardMoveData.WindyMoveWindDirection == EMoveDirection.Backward;
		if (HardMoveData.WindyMoveForwardBuffID > 0)
		{
			if (flag && !BuffData.HasBuff(HardMoveData.WindyMoveForwardBuffID))
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(HardMoveData.WindyMoveForwardBuffID, Owner, Owner, 0f, EBuffSourceType.HardMove);
			}
			if (!flag && BuffData.HasBuff(HardMoveData.WindyMoveForwardBuffID))
			{
				base.BUSEventCollection.Evt_BuffRemove.Invoke(HardMoveData.WindyMoveForwardBuffID, EBuffEffectTriggerType.None, 1);
			}
		}
		if (HardMoveData.WindyMoveBackwardBuffID > 0)
		{
			if (flag2 && !BuffData.HasBuff(HardMoveData.WindyMoveBackwardBuffID))
			{
				base.BUSEventCollection.Evt_BuffAdd.Invoke(HardMoveData.WindyMoveBackwardBuffID, Owner, Owner, 0f, EBuffSourceType.HardMove);
			}
			if (!flag2 && BuffData.HasBuff(HardMoveData.WindyMoveBackwardBuffID))
			{
				base.BUSEventCollection.Evt_BuffRemove.Invoke(HardMoveData.WindyMoveBackwardBuffID, EBuffEffectTriggerType.None, 1);
			}
		}
		if (HardMoveData.WindyMoveForwardBlendAnim != null)
		{
			if (flag && !HardMoveData.bWindyMoveBlendAnim)
			{
				base.BUSEventCollection.Evt_SetEnableAnimCurveBodyBlend.Invoke(ECurveBodyBlendType.UpperBody, bEnable: true, HardMoveData.WindyMoveForwardBlendAnim);
				HardMoveData.bWindyMoveBlendAnim = true;
			}
			if (!flag && HardMoveData.bWindyMoveBlendAnim)
			{
				base.BUSEventCollection.Evt_SetEnableAnimCurveBodyBlend.Invoke(ECurveBodyBlendType.UpperBody, bEnable: false, null);
				HardMoveData.bWindyMoveBlendAnim = false;
			}
		}
	}

	private void UpdateHardMovingState()
	{
		bool flag = SimpleStateData.HasSimpleState(EBGUSimpleState.FrozenMoving) && !HardMoveData.bImmuneHardMovingAll && !HardMoveData.bImmuneHardMovingFrozen;
		bool flag2 = SimpleStateData.HasSimpleState(EBGUSimpleState.MuddyMoving) && !HardMoveData.bImmuneHardMovingAll && !HardMoveData.bImmuneHardMovingMuddy;
		bool flag3 = SimpleStateData.HasSimpleState(EBGUSimpleState.WinddyMoving) && !HardMoveData.bImmuneHardMovingAll && !HardMoveData.bImmuneHardMovingWindy;
		bool flag4 = SimpleStateData.HasSimpleState(EBGUSimpleState.SpiderSilkyHardMoving) && !HardMoveData.bImmuneHardMovingAll && !HardMoveData.bImmuneHardMovingSpiderSilky;
		if (HardMoveData.FrozenMoveEnterSkill != 0 && flag && !HardMoveData.bFrozenHardMoving)
		{
			base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(HardMoveData.FrozenMoveEnterSkill, ECastSkillSourceType.HardMove));
		}
		if (HardMoveData.MuddyMoveEnterSkill != 0 && flag2 && !HardMoveData.bMuddyHardMoving)
		{
			base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(HardMoveData.MuddyMoveEnterSkill, ECastSkillSourceType.HardMove));
		}
		if (HardMoveData.WindyMoveEnterSkill != 0 && flag3 && !HardMoveData.bWindyHardMoving)
		{
			base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(HardMoveData.WindyMoveEnterSkill, ECastSkillSourceType.HardMove));
		}
		if (HardMoveData.SpiderSilkyMoveEnterSkill != 0 && flag4 && !HardMoveData.bSpiderSilkyHardMoving)
		{
			base.BUSEventCollection.Evt_UnitCastSkillTry.Invoke(new FCastSkillInfo(HardMoveData.SpiderSilkyMoveEnterSkill, ECastSkillSourceType.HardMove));
		}
		HardMoveData.bFrozenHardMoving = flag;
		HardMoveData.bMuddyHardMoving = flag2;
		HardMoveData.bWindyHardMoving = flag3;
		HardMoveData.bSpiderSilkyHardMoving = flag4;
	}

	private void OnSetImmuneHardMoveAll(bool EnableImmune)
	{
		HardMoveData.bImmuneHardMovingAll = EnableImmune;
	}

	private void OnSetImmuneHardMoveFrozen(bool EnableImmune)
	{
		HardMoveData.bImmuneHardMovingFrozen = EnableImmune;
	}

	private void OnSetImmuneHardMoveMuddy(bool EnableImmune)
	{
		HardMoveData.bImmuneHardMovingMuddy = EnableImmune;
	}

	private void OnSetImmuneHardMoveWindy(bool EnableImmune)
	{
		HardMoveData.bImmuneHardMovingWindy = EnableImmune;
	}

	private void OnSetImmuneHardMoveSpiderSilky(bool EnableImmune)
	{
		HardMoveData.bImmuneHardMovingSpiderSilky = EnableImmune;
	}
}
