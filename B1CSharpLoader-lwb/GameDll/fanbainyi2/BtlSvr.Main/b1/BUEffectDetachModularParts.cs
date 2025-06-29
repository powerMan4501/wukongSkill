using BtlShare;
using UnrealEngine.Engine;

namespace b1;

[AffectCaster]
public class BUEffectDetachModularParts : BUEffectTemplate
{
	public BUEffectDetachModularParts()
	{
		EffectType = EBuffAndSkillEffectType.DetachModularParts;
	}

	[ParamInfoS(0, "父骨骼名")]
	[ParamInfoS(1, "需要关闭碰撞等的ComponentTag")]
	[ParamInfoI(0, ">0:递归分离 其他: false")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		string boneName = ((skillEffectDesc.EffectParamsStr.Count > 0) ? skillEffectDesc.EffectParamsStr[0] : "");
		string componentTag = ((skillEffectDesc.EffectParamsStr.Count > 1) ? skillEffectDesc.EffectParamsStr[1] : "");
		bool bDetachRecursively = skillEffectDesc.EffectParamsInt.Count > 0 && skillEffectDesc.EffectParamsInt[0] > 0;
		BUS_EventCollectionCS.Get(Caster).Evt_DetachModularParts.Invoke(boneName, componentTag, bDetachRecursively);
	}
}
