using BtlShare;

namespace b1;

internal class BUC_SmartCastSkillData : b1.IBUC_SmartCastSkillData
{
	public int TryCastingSkillID { get; set; }

	public ECtrlActionType LastAutoActionType { get; set; }

	public bool IsInAttackRunTracing { get; set; }

	public int AttackRunTraceSkillID { get; set; }

	public int AttackRunTraceMoveIdx { get; set; }

	public float IgnoreWeakCtrlTime { get; set; }

	public int MovingToAttackSkillID { get; set; }

	public bool IsMovingToAttack { get; set; }

	public bool IsUnpausingBT { get; set; }

	public float MovingToAttackTimer { get; set; }

	public float MovingToAttackFallbackTime { get; set; }

	public bool bAutoCameraLock { get; set; }

	public bool bOnlyAutoLockTarget { get; set; }

	public bool IsIgnoreWeakCtrl()
	{
		if (!IsInAttackRunTracing)
		{
			return false;
		}
		if (IgnoreWeakCtrlTime > 0f)
		{
			return true;
		}
		return false;
	}
}
