using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[AffectTarget]
public class BUEffectMoveToPoint : BUEffectTemplate
{
	public BUEffectMoveToPoint()
	{
		EffectType = EBuffAndSkillEffectType.MoveToPoint;
	}

	[ParamInfoI(3, "点集ID")]
	[ParamInfoI(2, "1：使用点集数据 其他：传送无效")]
	[ParamInfoI(1, "1：正面朝向点 其他：背面朝向点")]
	[TemplateFunNote("移动到定点, Int[2]必须是1才有效果")]
	[ParamInfoI(0, "1：传送无效")]
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
		if (!(bUS_GSEventCollection != null) || buffDescRuntime.GetIntEffectParam(EffectIdx, 0) == 1 || buffDescRuntime.GetIntEffectParam(EffectIdx, 2) != 1)
		{
			return;
		}
		int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 3);
		List<FVector> list = BGUFunctionLibraryCS.BGUGetCachedPointSet(Target, intEffectParam);
		if (list.Count > 0)
		{
			FVector fVector = list[0];
			if (buffDescRuntime.GetIntEffectParam(EffectIdx, 1) == 0)
			{
				BGUFuncLibActorTransformCS.BGUSetActorRotation(Target, MathLib.Conv_VectorToRotator(fVector - BGUFuncLibActorTransformCS.BGUGetActorLocation(Target)), bTeleportPhysics: false);
			}
			else
			{
				BGUFuncLibActorTransformCS.BGUSetActorRotation(Target, MathLib.Conv_VectorToRotator(BGUFuncLibActorTransformCS.BGUGetActorLocation(Target) - fVector), bTeleportPhysics: false);
			}
			bUS_GSEventCollection.Evt_SetAMScaleRateByPosMultiCast.Invoke(EAMScaleType.ScaleForCachedPoint, EAMScaleRateAxis.AxisX, 0f, 0f, intEffectParam, AttackRangeLimit: false, DebugMode: false, BuffInst.Duration, BuffInst.LeftTime, BuffInst.LeftTime + BuffInst.Duration);
		}
	}
}
