using UnrealEngine.Engine;

namespace b1;

public class BUABPJump_LandSettingData
{
	public UAnimSequence AnimSeq_Land { get; private set; }

	public float WalkAnimLand_MoveTime { get; private set; }

	public float AnimLand_MoveTime { get; private set; }

	public float AnimLand_JumpTime { get; private set; }

	public float AnimLand_AttackTime { get; private set; }

	public float AnimLand_DodgeTime { get; private set; }

	public BUABPJump_LandSettingData(in FAnimHumanoidSetting_Jump_Land Setting)
	{
		AnimSeq_Land = Setting.AnimSeq_Land;
		WalkAnimLand_MoveTime = Setting.WalkAnimLand_MoveTime;
		AnimLand_MoveTime = Setting.AnimLand_MoveTime;
		AnimLand_JumpTime = Setting.AnimLand_JumpTime;
		AnimLand_AttackTime = Setting.AnimLand_AttackTime;
		AnimLand_DodgeTime = Setting.AnimLand_DodgeTime;
	}
}
