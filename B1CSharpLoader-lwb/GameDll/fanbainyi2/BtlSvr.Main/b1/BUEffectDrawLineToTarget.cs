using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[AffectTarget]
[EffectTemplateTips(new string[] { "朝目标绘制线条" })]
public class BUEffectDrawLineToTarget : BUEffectTemplate
{
	public BUEffectDrawLineToTarget()
	{
		EffectType = EBuffAndSkillEffectType.DrawLineToTarget;
	}

	[TemplateFunNote("添加Buff时朝目标绘制线条")]
	[ParamInfoI(0, "线条类型，0为从Target到Target的目标画一条线段，1为将Target身上的RayComp从Target位置指向其Master身上socket位置")]
	[ParamInfoF(0, "线条粗细，仅当Int第0个参数设为0时有效")]
	[ParamInfoS(0, "Target的Master身上的Socket名")]
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
		switch (buffDescRuntime.GetIntEffectParam(EffectIdx, 0))
		{
		case 0:
		{
			AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Target);
			if (aActor != null)
			{
				FVector lineStart = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
				FVector lineEnd = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
				float floatEffectParam = buffDescRuntime.GetFloatEffectParam(EffectIdx, 0);
				USystemLibrary.DrawDebugLine(Target, lineStart, lineEnd, FLinearColor.Red, (float)buffDescRuntime.GetInterval() / 1000f, floatEffectParam);
			}
			break;
		}
		case 1:
		{
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(Target);
			if (readOnlyData == null)
			{
				break;
			}
			AActor masterActor = readOnlyData.GetMasterActor();
			if (masterActor == null)
			{
				break;
			}
			USkeletalMeshComponent mesh = (masterActor as ACharacter).Mesh;
			FTransform fTransform = default(FTransform);
			fTransform.SetTranslation(mesh.GetSocketLocation(new FName(stringEffectParam)));
			List<UActorComponent> componentsByTag = Target.GetComponentsByTag(UClass.GetClass<USceneComponent>(), B1GlobalFNames.RayComp);
			for (int i = 0; i < componentsByTag.Count; i++)
			{
				USceneComponent uSceneComponent = componentsByTag[i] as USceneComponent;
				if (uSceneComponent != null)
				{
					uSceneComponent.SetWorldLocation(fTransform.GetLocation(), bSweep: false, out var SweepHitResult, bTeleport: false);
					uSceneComponent.SetWorldRotation(MathLib.Conv_VectorToRotator(-MathLib.Normal(fTransform.GetLocation() - BGUFuncLibActorTransformCS.BGUGetActorLocation(Target))), bSweep: false, out SweepHitResult, bTeleport: false);
				}
			}
			break;
		}
		}
	}

	public override void RemoveByBuff(BuffInstData BuffInst, AActor Target, int EffectIdx, int Layer)
	{
		b1.EffectTemplateUtil.ReturnIfUnitDead(Target);
	}
}
