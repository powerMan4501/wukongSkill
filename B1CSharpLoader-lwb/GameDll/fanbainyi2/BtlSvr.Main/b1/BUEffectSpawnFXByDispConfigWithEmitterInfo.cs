using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUEffectSpawnFXByDispConfigWithEmitterInfo : BUEffectTemplate
{
	public BUEffectSpawnFXByDispConfigWithEmitterInfo()
	{
		EffectType = EBuffAndSkillEffectType.SpawnFxbyDispConfigWithEmitterInfo;
	}

	[ParamInfoS(0, "DBC路径")]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster))
		{
			return;
		}
		ACharacter aCharacter = Target as ACharacter;
		if (!(aCharacter == null))
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
			if (skillEffectDesc != null)
			{
				BUS_EventCollectionCS.Get(Caster)?.Evt_RequestSpawnFXByDispConfigWithEmitterInfo.Invoke(skillEffectDesc.EffectParamsStr[0], out var _, aCharacter.Mesh, FVector.ZeroVector);
			}
		}
	}
}
