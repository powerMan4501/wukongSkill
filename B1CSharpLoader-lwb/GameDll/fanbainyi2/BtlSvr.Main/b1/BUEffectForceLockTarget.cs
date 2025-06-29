using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[EffectTemplateTips(new string[] { "强制主角镜头锁定目标" })]
public class BUEffectForceLockTarget : BUEffectTemplate
{
	public BUEffectForceLockTarget()
	{
		EffectType = EBuffAndSkillEffectType.ForceLockTarget;
	}

	[TemplateFunNote("强制主角镜头锁定技能目标")]
	[TemplateFuncTips("Target是期望锁定的对象")]
	[ParamInfoS(0, "锁定的Socket")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Caster)?.GetControlledPawn();
		if (!(aPawn == null))
		{
			string skeletonSocketName = "";
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null && skillEffectDesc.EffectParamsStr.Count > 0)
			{
				skeletonSocketName = skillEffectDesc.EffectParamsStr[0];
			}
			BUS_EventCollectionCS.Get(aPawn)?.Evt_CameraLockTarget.Invoke(new UnitLockTargetInfo(Target, ETargetSourceType.Target_ForceCameraLock, ELockTargetWayType.Manual, "", skeletonSocketName));
		}
	}
}
