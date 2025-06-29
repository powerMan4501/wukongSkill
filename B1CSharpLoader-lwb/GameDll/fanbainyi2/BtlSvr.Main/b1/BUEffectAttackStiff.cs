using BtlShare;
using UnrealEngine.Engine;

namespace b1;

public class BUEffectAttackStiff : BUEffectTemplate
{
	public BUEffectAttackStiff()
	{
		EffectType = EBuffAndSkillEffectType.AttackStiff;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		AGameStateBase gameState = UGameplayStatics.GetGameState(Caster);
		if (gameState != null)
		{
			BGU_DataUtil.GetReadOnlyData<IBGC_PredictionKeyData, BGC_PredictionKeyData>(gameState).ServerRecving();
		}
	}
}
