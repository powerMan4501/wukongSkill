using UnrealEngine.Engine;

namespace b1;

public class BUABPJumpSettingData : BUABPSettingDataBase
{
	public float CustomJumpVelocityIncrementWhenPressed { get; private set; }

	public float CustomJumpVelocityIncrementWhenPressed_Locked { get; private set; }

	public UBlendSpace BS_jump_start_fwd { get; private set; }

	public UBlendSpace BS_jump_start_bwd { get; private set; }

	public UBlendSpace BS_jump_loop_fwd { get; private set; }

	public UBlendSpace BS_jump_loop_bwd { get; private set; }

	public UBlendSpace BS_jump_additive_lean { get; private set; }

	public UBlendSpace BS_jump_additive_rot { get; private set; }

	public UAnimSequence AnimJumpStart_N { get; private set; }

	public UAnimSequence AnimJumpStart_F { get; private set; }

	public UAnimSequence AnimJumpStart_L { get; private set; }

	public UAnimSequence AnimJumpStart_R { get; private set; }

	public UAnimSequence AnimJumpStart_B { get; private set; }

	public UAnimSequence AnimFallStart_N { get; private set; }

	public UAnimSequence AnimFallStart_F { get; private set; }

	public UAnimSequence AnimFallStart_F_Dash { get; private set; }

	public UAnimSequence AnimFallStart_B { get; private set; }

	public UAnimSequence AnimFallStart_L { get; private set; }

	public UAnimSequence AnimFallStart_R { get; private set; }

	public UAnimSequence AnimFallLoop { get; private set; }

	public float TriggerLandHeight { get; private set; }

	public float HeightDividingLine_Low { get; private set; }

	public float HeightDividingLine_Mid { get; private set; }

	public BUABPJump_LandSettingData Land_F_Low { get; private set; }

	public BUABPJump_LandSettingData Land_F_Mid { get; private set; }

	public BUABPJump_LandSettingData Land_F_High { get; private set; }

	public BUABPJump_LandSettingData Land_L { get; private set; }

	public BUABPJump_LandSettingData Land_R { get; private set; }

	public BUABPJump_LandSettingData Land_B { get; private set; }

	public UAnimSequence AddtiveMoveAfterJump_F { get; private set; }

	public UAnimSequence AddtiveMoveAfterJump_B { get; private set; }

	public UAnimSequence AddtiveMoveAfterJump_L { get; private set; }

	public UAnimSequence AddtiveMoveAfterJump_R { get; private set; }

	public BUABPGlideJumpSettingData GlideJump { get; private set; }

	public override void InitSettingData(in BGWDataAsset_AbpHumanoidSetting ABPSetting)
	{
		if (!(ABPSetting == null))
		{
			FAnimHumanoidSetting_Jump jumpSetting = ABPSetting.JumpSetting;
			CustomJumpVelocityIncrementWhenPressed = jumpSetting.CustomJumpVelocityIncrementWhenPressed;
			CustomJumpVelocityIncrementWhenPressed_Locked = jumpSetting.CustomJumpVelocityIncrementWhenPressed_Locked;
			BS_jump_start_fwd = jumpSetting.BS_jump_start_fwd;
			BS_jump_start_bwd = jumpSetting.BS_jump_start_bwd;
			BS_jump_loop_fwd = jumpSetting.BS_jump_loop_fwd;
			BS_jump_loop_bwd = jumpSetting.BS_jump_loop_bwd;
			BS_jump_additive_lean = jumpSetting.BS_jump_additive_lean;
			BS_jump_additive_rot = jumpSetting.BS_jump_additive_rot;
			AnimJumpStart_N = jumpSetting.AnimJumpStart_N;
			AnimJumpStart_F = jumpSetting.AnimJumpStart_F;
			AnimJumpStart_L = jumpSetting.AnimJumpStart_L;
			AnimJumpStart_R = jumpSetting.AnimJumpStart_R;
			AnimJumpStart_B = jumpSetting.AnimJumpStart_B;
			AnimFallStart_N = jumpSetting.AnimFallStart_N;
			AnimFallStart_F = jumpSetting.AnimFallStart_F;
			AnimFallStart_F_Dash = jumpSetting.AnimFallStart_F_Dash;
			AnimFallStart_B = jumpSetting.AnimFallStart_B;
			AnimFallStart_L = jumpSetting.AnimFallStart_L;
			AnimFallStart_R = jumpSetting.AnimFallStart_R;
			AnimFallLoop = jumpSetting.AnimFallLoop;
			TriggerLandHeight = jumpSetting.TriggerLandHeight;
			HeightDividingLine_Low = jumpSetting.HeightDividingLine_Low;
			HeightDividingLine_Mid = jumpSetting.HeightDividingLine_Mid;
			Land_F_Low = new BUABPJump_LandSettingData(in jumpSetting.Land_F_Low);
			Land_F_Mid = new BUABPJump_LandSettingData(in jumpSetting.Land_F_Mid);
			Land_F_High = new BUABPJump_LandSettingData(in jumpSetting.Land_F_High);
			Land_L = new BUABPJump_LandSettingData(in jumpSetting.Land_L);
			Land_R = new BUABPJump_LandSettingData(in jumpSetting.Land_R);
			Land_B = new BUABPJump_LandSettingData(in jumpSetting.Land_B);
			AddtiveMoveAfterJump_F = jumpSetting.AddtiveMoveAfterJump_F;
			AddtiveMoveAfterJump_B = jumpSetting.AddtiveMoveAfterJump_B;
			AddtiveMoveAfterJump_L = jumpSetting.AddtiveMoveAfterJump_L;
			AddtiveMoveAfterJump_R = jumpSetting.AddtiveMoveAfterJump_R;
			GlideJump = new BUABPGlideJumpSettingData(in jumpSetting.GlideJump);
		}
	}
}
