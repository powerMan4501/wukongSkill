using BtlShare;

namespace b1;

internal interface IBUC_SmartCastSkillData
{
	ECtrlActionType LastAutoActionType { get; }

	bool IsInAttackRunTracing { get; }

	bool IsMovingToAttack { get; }

	bool bOnlyAutoLockTarget { get; }

	bool IsIgnoreWeakCtrl();
}
