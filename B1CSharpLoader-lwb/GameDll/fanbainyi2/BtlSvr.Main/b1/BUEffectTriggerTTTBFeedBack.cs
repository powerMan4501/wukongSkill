using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[EffectTemplateTips(new string[] { "若铜头铁臂未被打破，则可以让主角能够强制释放技能", "若铜头铁臂被打破，则播放配置好的击破受击动画" })]
[AffectTarget]
public class BUEffectTriggerTTTBFeedBack : BUEffectTemplate
{
	public BUEffectTriggerTTTBFeedBack()
	{
		EffectType = EBuffAndSkillEffectType.TriggerTttbFeedback;
	}

	[ParamInfoS(0, "铜头铁臂被打破动画AM")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		BUC_ChargeSkillData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_ChargeSkillData>(Target);
		if (readOnlyData == null)
		{
			return;
		}
		if (!BGU_DataUtil.GetReadOnlyData<BUC_IronBodyData>(Target).IsDefeat)
		{
			BUS_EventCollectionCS.Get(Target).Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CanForceAttackInChargeSkill);
			readOnlyData.BeAttackedTriggerForceAttackCnt++;
		}
		else if (buffDescRuntime.GetStringEffectParamCount(EffectIdx) >= 1)
		{
			UAnimMontage uAnimMontage = BGW_PreloadAssetMgr.Get(Target).TryGetCachedResourceObj<UAnimMontage>(buffDescRuntime.GetStringEffectParam(EffectIdx, 0), ELoadResourceType.SyncLoadAndCache);
			if (!(uAnimMontage == null))
			{
				BGUCharacterCS obj = Target as BGUCharacterCS;
				obj.StopAnimMontage(null);
				BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(obj);
				bUS_GSEventCollection?.Evt_OnMagicallyChangeBreak.Invoke();
				bUS_GSEventCollection?.Evt_UnitTryBreakSkill.Invoke("铜头铁臂反馈");
				BGUFuncLibAnim.BGUActorTryPlayMontage(obj, uAnimMontage, FName.None);
				float num = UBGUFunctionLibrary.BGUGetMontageSectionLengthByIndex(Target, uAnimMontage, 0);
				UGSE_AnimFuncLib.AnimMontageGetBlendInAndOutTime(uAnimMontage, out var BlendInTime, out var BlendOutTime);
				num -= BlendInTime + BlendOutTime;
				bUS_GSEventCollection?.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.Beatback, num, NeedForceUpdate: true);
			}
		}
	}
}
