using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectFrozenFracture : BUEffectTemplate
{
	public BUEffectFrozenFracture()
	{
		EffectType = EBuffAndSkillEffectType.FrozenFracture;
	}

	[TemplateFunNote("通过技能触发冰冻破碎死亡")]
	[AffectCaster]
	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (!(BUS_EventCollectionCS.Get(Caster) == null))
		{
			BGUCharacterCS bGUCharacterCS = Caster as BGUCharacterCS;
			BGW_LogUtil.LogIfNull(bGUCharacterCS, "CurCharacter Is Not ABGUCharacter");
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_UnitDead.Invoke(bGUCharacterCS, EDeadReason.FrozenFracture);
		}
	}
}
