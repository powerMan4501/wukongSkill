using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPAttackOffsetData : IBUC_ABPAttackOffsetData
{
	public float Alpha { get; set; }

	public FQuat AttackOffset_WorldRotOffset { get; set; }

	public EAttackOffsetType AttackOffset_AttackOffsetType { get; set; }

	public void Init()
	{
		Alpha = 0f;
		AttackOffset_WorldRotOffset = FQuat.Identity;
		AttackOffset_AttackOffsetType = EAttackOffsetType.AttackOffset_None;
	}
}
