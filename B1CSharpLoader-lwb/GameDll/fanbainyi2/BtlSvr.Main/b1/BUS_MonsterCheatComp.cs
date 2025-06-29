namespace b1;

public class BUS_MonsterCheatComp : UActorCompBaseCS
{
	private IBIC_CheatData CheatData { get; set; }

	public override void OnAttach()
	{
		CheatData = RequireReadonlyGameInstanceData<IBIC_CheatData, BIC_CheatData>();
	}

	public override void PreBeginPlay()
	{
		SetCanTick(Val: false);
	}

	public override void LateBeginPlay()
	{
		if (CheatData != null)
		{
			if (CheatData.bLockAllMonsterHP)
			{
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.ImmueDamage);
			}
			if (CheatData.bCancelAllMonsterSkillCD)
			{
				base.BUSEventCollection.Evt_UnitSetSimpleState.Invoke(EBGUSimpleState.CancelSkillCD);
			}
			if (CheatData.bPauseAllMonsterAI)
			{
				base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: true);
			}
		}
	}
}
