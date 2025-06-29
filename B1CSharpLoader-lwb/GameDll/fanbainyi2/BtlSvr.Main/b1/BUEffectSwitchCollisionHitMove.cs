using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectSwitchCollisionHitMove : BUEffectTemplate
{
	public BUEffectSwitchCollisionHitMove()
	{
		EffectType = EBuffAndSkillEffectType.SwitchCollisionHitMove;
	}

	[ParamInfoI(0, "0：关闭 1：开启 ")]
	[ParamInfoS(0, "（可选）需要被控制的Collision名称片段【若string参数全空，则整体开关】")]
	[ParamInfoS(1, "（可选）需要被控制的Collision名称片段【若string参数全空，则整体开关】")]
	[ParamInfoS(2, "（可选）需要被控制的Collision名称片段【若string参数全空，则整体开关】")]
	[TemplateFuncTips("如果需要全部关，String参数数量填0")]
	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null || !(Target as ACharacter != null))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			bool flag = buffDescRuntime.GetIntEffectParamCount(EffectIdx) > 0 && buffDescRuntime.GetIntEffectParam(EffectIdx, 0) != 0;
			if (buffDescRuntime.GetStringEffectParamCount(EffectIdx) > 0)
			{
				ulong requestID = (ulong)(((long)BuffInst.BuffID << 32) | EffectIdx);
				bUS_GSEventCollection.Evt_RequestSetEnableHitMoveCollision.Invoke(buffDescRuntime.GetStringEffectParamList(EffectIdx), flag, requestID);
			}
			else
			{
				bUS_GSEventCollection.Evt_SetIsEnableCollisionHitMove.Invoke(flag, ECollisionHitMoveEnableReqType.Buff, BuffInst.BuffID);
			}
		}
	}

	[TemplateFunNote("恢复")]
	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		BUC_BuffData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_BuffData>(Target);
		if (readOnlyData == null || readOnlyData.GetBuffLayer(BuffInst.BuffID) > 1)
		{
			return;
		}
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime == null)
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(Target);
		if (bUS_GSEventCollection != null)
		{
			if (buffDescRuntime.GetStringEffectParamCount(EffectIdx) > 0)
			{
				ulong requestID = (ulong)(((long)BuffInst.BuffID << 32) | EffectIdx);
				bUS_GSEventCollection.Evt_PopRequestSetEnableHitMoveCollision.Invoke(requestID);
			}
			else
			{
				bUS_GSEventCollection.Evt_ResetIsEnableCollisionHitMove.Invoke(ECollisionHitMoveEnableReqType.Buff, BuffInst.BuffID);
			}
		}
	}
}
