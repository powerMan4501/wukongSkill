using UnrealEngine.Engine;

namespace b1;

public class BUC_BossControlData : IBUC_BossControlData
{
	public bool bHasImmuneDamageBuff { get; set; }

	public bool bHasImmuneSkillPerformBuff { get; set; }

	public bool bHasCantBeTargetBuff { get; set; }

	public bool bHasCantBeControlBuff { get; set; }

	public bool bInSafeState { get; set; }

	public bool CanBossCatchTarget(AActor TargetActor, ETargetSourceType SourceType)
	{
		if (bInSafeState)
		{
			if (B1Global.GIsBossRushMode && SourceType != ETargetSourceType.Target_CPGAssignTarget)
			{
				return false;
			}
			if (SourceType != ETargetSourceType.Target_AIPerception && SourceType != ETargetSourceType.Target_CPGAssignTarget && SourceType != ETargetSourceType.Target_CMGAssignTarget)
			{
				return false;
			}
			if (TargetActor is BGUPlayerCharacterCS)
			{
				return true;
			}
			if (TargetActor is BGU_CharacterAI { bBossRoomMonster: not false })
			{
				return true;
			}
			return false;
		}
		return true;
	}
}
