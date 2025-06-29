namespace b1;

public interface IBIC_CheatData
{
	bool bLockAllMonsterHP { get; }

	bool bCancelAllMonsterSkillCD { get; }

	bool bPauseAllMonsterAI { get; }

	bool CanSendData();
}
