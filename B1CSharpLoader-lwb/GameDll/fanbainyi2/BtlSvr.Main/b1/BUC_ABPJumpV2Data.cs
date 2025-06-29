using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPJumpV2Data : IBUC_ABPJumpV2Data
{
	private float LandAnimCantMoveTimer;

	private float LandAnimCantJumpTimer;

	private float LandAnimCantAttackTimer;

	private float LandAnimCantDodgeTimer;

	private bool bOpenLandCheck_Move;

	private bool bOpenLandCheck_Jump;

	private bool bOpenLandCheck_Attack;

	private bool bOpenLandCheck_Dodge;

	private IBUC_MovementData MovementData;

	private IBUC_JumpData JumpData;

	private IBUC_UnitStateData UnitStateData;

	private const float AlphaSpeed = 12f;

	public ESkillDirection StartJumpDir { get; set; }

	public bool bIsJumpStartFast { get; set; }

	public bool bInJump { get; set; }

	public float TriggerLandHeight { get; set; }

	public float HeightDividingLine_Low { get; set; }

	public float HeightDividingLine_Mid { get; set; }

	public EJumpType JumpType { get; set; }

	public bool bFallByJump { get; set; }

	public float CustomJumpVelocityIncrementWhenPressed { get; set; }

	public float CustomJumpVelocityIncrementWhenPressed_Locked { get; set; }

	public UBlendSpace BS_jump_start_fwd { get; set; }

	public UBlendSpace BS_jump_start_bwd { get; set; }

	public UBlendSpace BS_jump_loop_fwd { get; set; }

	public UBlendSpace BS_jump_loop_bwd { get; set; }

	public UBlendSpace BS_jump_additive_lean { get; set; }

	public UBlendSpace BS_jump_additive_rot { get; set; }

	public UAnimSequence AnimGroundJumpStart { get; set; }

	public UAnimSequence AnimJumpStart_N { get; set; }

	public UAnimSequence AnimJumpStart_F { get; set; }

	public UAnimSequence AnimJumpStart_L { get; set; }

	public UAnimSequence AnimJumpStart_R { get; set; }

	public UAnimSequence AnimJumpStart_B { get; set; }

	public UAnimSequence AnimFallStart { get; set; }

	public UAnimSequence AnimFallStart_N { get; set; }

	public UAnimSequence AnimFallStart_F { get; set; }

	public UAnimSequence AnimFallStart_B { get; set; }

	public UAnimSequence AnimFallStart_L { get; set; }

	public UAnimSequence AnimFallStart_R { get; set; }

	public UAnimSequence AnimFallLoop { get; set; }

	public float WalkAnimLand_MoveTime { get; set; }

	public float AnimLand_MoveTime { get; set; }

	public float AnimLand_JumpTime { get; set; }

	public float AnimLand_AttackTime { get; set; }

	public float AnimLand_DodgeTime { get; set; }

	public UAnimSequence AnimLand_F_Low { get; set; }

	public UAnimSequence AnimLand_F_Mid { get; set; }

	public UAnimSequence AnimLand_F_High { get; set; }

	public UAnimSequence AnimLand_L { get; set; }

	public UAnimSequence AnimLand_R { get; set; }

	public UAnimSequence AnimLand_B { get; set; }

	public BUABPJump_LandSettingData Land_F_Low { get; set; }

	public BUABPJump_LandSettingData Land_F_Mid { get; set; }

	public BUABPJump_LandSettingData Land_F_High { get; set; }

	public BUABPJump_LandSettingData Land_L { get; set; }

	public BUABPJump_LandSettingData Land_R { get; set; }

	public BUABPJump_LandSettingData Land_B { get; set; }

	public UAnimSequence AddtiveMoveAfterJump_F { get; set; }

	public UAnimSequence AddtiveMoveAfterJump_B { get; set; }

	public UAnimSequence AddtiveMoveAfterJump_L { get; set; }

	public UAnimSequence AddtiveMoveAfterJump_R { get; set; }

	public float AdditiveMoveAfterJumpFAlpha { get; set; }

	public float AdditiveMoveAfterJumpBAlpha { get; set; }

	public float AdditiveMoveAfterJumpLAlpha { get; set; }

	public float AdditiveMoveAfterJumpRAlpha { get; set; }

	public UAnimSequence AnimGlideJumpStart { get; set; }

	public float LandAnimCantJumpTimer_Glide { get; set; }

	public bool bIsLittleFall { get; set; }

	public bool bIsInLandCantMoveTime { get; set; }

	public bool bIsInLandCantJumpTime { get; set; }

	public bool bIsInLandCantAttackTime { get; set; }

	public bool bIsInLandCantDodgeTime { get; set; }

	public bool bHasFallAnimAsset { get; set; }

	public EStartJumpSpdState StartJumpSpdState { get; set; }

	public EFallHeightType_V2 FallHeightType { get; set; }

	public float FallHeight { get; set; }

	public float AimOffsetForJumpEnableX { get; set; }

	public float AimOffsetForJumpEnableY { get; set; }

	public FVector2D LocalInput2D { get; set; }

	public FVector2D VelocityBlend { get; set; }

	public FVector4 VelocityBlendAlpha { get; set; }

	public float VelocityDeltaAngle { get; set; }

	public float VelocityDeltaAngleTrans { get; set; }

	public void Init(BUABPSettingData Setting, IBUC_ActorBasicData ActorBasicData, IBUC_MovementData InMovementData, IBUC_JumpData InJumpData, IBUC_UnitStateData InUnitStateData)
	{
		MovementData = InMovementData;
		JumpData = InJumpData;
		UnitStateData = InUnitStateData;
		if (ActorBasicData.ActorType == BGU_ActorType.CharacterPlayer)
		{
			BUABPJumpSettingData jumpSetting = Setting.JumpSetting;
			TriggerLandHeight = jumpSetting.TriggerLandHeight;
			HeightDividingLine_Low = jumpSetting.HeightDividingLine_Low;
			HeightDividingLine_Mid = jumpSetting.HeightDividingLine_Mid;
			JumpType = EJumpType.Normal;
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
			AnimGroundJumpStart = AnimJumpStart_N;
			AnimFallStart_N = jumpSetting.AnimFallStart_N;
			AnimFallStart_F = jumpSetting.AnimFallStart_F;
			AnimFallStart_L = jumpSetting.AnimFallStart_L;
			AnimFallStart_R = jumpSetting.AnimFallStart_R;
			AnimFallStart_B = jumpSetting.AnimFallStart_B;
			AnimFallStart = AnimFallStart_F;
			AnimFallLoop = jumpSetting.AnimFallLoop;
			Land_F_Low = jumpSetting.Land_F_Low;
			Land_F_Mid = jumpSetting.Land_F_Mid;
			Land_F_High = jumpSetting.Land_F_High;
			Land_L = jumpSetting.Land_L;
			Land_R = jumpSetting.Land_R;
			Land_B = jumpSetting.Land_B;
			AnimLand_F_Low = Land_F_Low.AnimSeq_Land;
			AnimLand_F_Mid = Land_F_Mid.AnimSeq_Land;
			AnimLand_F_High = Land_F_High.AnimSeq_Land;
			AnimLand_L = Land_L.AnimSeq_Land;
			AnimLand_R = Land_R.AnimSeq_Land;
			AnimLand_B = Land_B.AnimSeq_Land;
			WalkAnimLand_MoveTime = 0f;
			AnimLand_MoveTime = 0f;
			AnimLand_JumpTime = 0f;
			AnimLand_AttackTime = 0f;
			AnimLand_DodgeTime = 0f;
			AddtiveMoveAfterJump_F = jumpSetting.AddtiveMoveAfterJump_F;
			AddtiveMoveAfterJump_B = jumpSetting.AddtiveMoveAfterJump_B;
			AddtiveMoveAfterJump_L = jumpSetting.AddtiveMoveAfterJump_L;
			AddtiveMoveAfterJump_R = jumpSetting.AddtiveMoveAfterJump_R;
			BUABPGlideJumpSettingData glideJump = jumpSetting.GlideJump;
			AnimGlideJumpStart = glideJump.ASGlideJumpStart;
			bIsInLandCantMoveTime = false;
			bIsInLandCantJumpTime = false;
			bIsInLandCantAttackTime = false;
			bOpenLandCheck_Move = false;
			bOpenLandCheck_Jump = false;
			bOpenLandCheck_Attack = false;
			bOpenLandCheck_Dodge = false;
			bIsLittleFall = false;
			LandAnimCantMoveTimer = -1f;
			LandAnimCantJumpTimer = -1f;
			LandAnimCantAttackTimer = -1f;
			LandAnimCantDodgeTimer = -1f;
			bHasFallAnimAsset = USystemLibrary.IsValid(AnimFallStart_N) && USystemLibrary.IsValid(AnimFallStart_F) && USystemLibrary.IsValid(AnimFallStart_B) && USystemLibrary.IsValid(AnimFallStart_L) && USystemLibrary.IsValid(AnimFallStart_R);
		}
	}

	public void Update(AActor Owner, IBUC_ActorBasicData ActorBasicData, IBUC_ABPCharacterData ChrData, IBUC_ABPBasicData BasicData, IBUC_ABPSpecialMoveData SpecialMoveData, float DeltaTime)
	{
		if (ActorBasicData.ActorType != BGU_ActorType.CharacterPlayer)
		{
			return;
		}
		ACharacter aCharacter = Owner as ACharacter;
		if (!(aCharacter == null))
		{
			bInJump = JumpData.IsInJump();
			if (SpecialMoveData.LastFrameSpecialMovementMode != ESpecialMovementMode.AirMove && SpecialMoveData.SpecialMovementMode == ESpecialMovementMode.AirMove)
			{
				bFallByJump = bInJump;
			}
			CheckLandCantMoveTime(ChrData, BasicData, DeltaTime);
			CheckLandCantJumpTime_Glide(DeltaTime, Owner);
			CheckLandCantJumpTime(ChrData, DeltaTime, Owner);
			CheckLandCantAttackTime(ChrData, DeltaTime, Owner);
			CheckLandCantDodgeTime(ChrData, DeltaTime, Owner);
			FVector4 TargetVelocityBlendAlpha = BGUFuncLibForMove.BGUCalcRelativeVectorDirectionAlpha(ChrData.Velocity, ChrData.ActorRotation);
			LandAddtiveToMoveTick(Owner, ChrData, in TargetVelocityBlendAlpha, DeltaTime);
			bIsInLandCantMoveTime = LandAnimCantMoveTimer > 0f;
			bIsInLandCantJumpTime = ((LandAnimCantJumpTimer > 0f || LandAnimCantJumpTimer_Glide > 0f) ? true : false);
			bIsInLandCantAttackTime = LandAnimCantAttackTimer > 0f;
			bIsInLandCantDodgeTime = LandAnimCantDodgeTimer > 0f;
			if (MovementData != null)
			{
				FVector currentWorldInputVec = MovementData.GetCurrentWorldInputVec(aCharacter);
				LocalInput2D = new FVector2D(aCharacter.GetActorTransform().InverseTransformDirection(currentWorldInputVec).GetSafeNormal2D());
			}
			if (ChrData.Velocity.Size2D() == 0f)
			{
				TargetVelocityBlendAlpha = FVector4.ZeroVector;
			}
			float num = FMath.FInterpTo(VelocityBlendAlpha.X, TargetVelocityBlendAlpha.X, DeltaTime, 12f);
			float num2 = FMath.FInterpTo(VelocityBlendAlpha.Y, TargetVelocityBlendAlpha.Y, DeltaTime, 12f);
			float num3 = FMath.FInterpTo(VelocityBlendAlpha.Z, TargetVelocityBlendAlpha.Z, DeltaTime, 12f);
			float num4 = FMath.FInterpTo(VelocityBlendAlpha.W, TargetVelocityBlendAlpha.W, DeltaTime, 12f);
			VelocityBlendAlpha = new FVector4(num, num2, num3, num4);
			VelocityBlend = new FVector2D(VelocityBlendAlpha.X - VelocityBlendAlpha.Y, VelocityBlendAlpha.W - VelocityBlendAlpha.Z);
			VelocityDeltaAngle = ((ChrData.Velocity.Size2D() > 0f) ? MathLib.NormalizedDeltaRotator(ChrData.Velocity.Rotation(), ChrData.ActorRotation).Yaw : 0f);
			if (FMath.Abs(VelocityDeltaAngle) > 90f)
			{
				VelocityDeltaAngleTrans = ((VelocityDeltaAngle > 0f) ? (180f - VelocityDeltaAngle) : (-180f - VelocityDeltaAngle));
			}
			else
			{
				VelocityDeltaAngleTrans = VelocityDeltaAngle;
			}
		}
	}

	private void LandAddtiveToMoveTick(AActor Owner, IBUC_ABPCharacterData ChrData, in FVector4 TargetVelocityBlendAlpha, float DeltaTime)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null || !aCharacter.IsPlayerControlled())
		{
			return;
		}
		float target = 0f;
		float target2 = 0f;
		float target3 = 0f;
		float target4 = 0f;
		if (ChrData.Velocity.Size() > 0f)
		{
			if (!ChrData.IsLocking)
			{
				target = 1f;
			}
			else
			{
				target = TargetVelocityBlendAlpha.X;
				target2 = TargetVelocityBlendAlpha.Y;
				target3 = TargetVelocityBlendAlpha.Z;
				target4 = TargetVelocityBlendAlpha.W;
			}
		}
		AdditiveMoveAfterJumpFAlpha = FMath.FInterpTo(AdditiveMoveAfterJumpFAlpha, target, DeltaTime, 12f);
		AdditiveMoveAfterJumpBAlpha = FMath.FInterpTo(AdditiveMoveAfterJumpBAlpha, target2, DeltaTime, 12f);
		AdditiveMoveAfterJumpLAlpha = FMath.FInterpTo(AdditiveMoveAfterJumpLAlpha, target3, DeltaTime, 12f);
		AdditiveMoveAfterJumpRAlpha = FMath.FInterpTo(AdditiveMoveAfterJumpRAlpha, target4, DeltaTime, 12f);
	}

	private void CheckLandCantMoveTime(IBUC_ABPCharacterData ChrData, IBUC_ABPBasicData BasicData, float DeltaTime)
	{
		if (ChrData.IsFalling && !bOpenLandCheck_Move)
		{
			bOpenLandCheck_Move = true;
		}
		if (!bOpenLandCheck_Move)
		{
			return;
		}
		if (!ChrData.IsFalling && LandAnimCantMoveTimer == -1f)
		{
			float num = ((BasicData.MoveSpeedState == EMoveSpeedLevel.Walk) ? FMath.Max(WalkAnimLand_MoveTime, AnimLand_MoveTime) : AnimLand_MoveTime);
			if (num <= 0f)
			{
				bOpenLandCheck_Move = false;
				return;
			}
			LandAnimCantMoveTimer = num;
		}
		if (LandAnimCantMoveTimer >= 0f)
		{
			LandAnimCantMoveTimer -= DeltaTime;
			if (LandAnimCantMoveTimer < 0f || UnitStateData.HasState(EBGUUnitState.Attacking))
			{
				WalkAnimLand_MoveTime = 0f;
				AnimLand_MoveTime = 0f;
				LandAnimCantMoveTimer = -1f;
				bOpenLandCheck_Move = false;
			}
		}
	}

	private void CheckLandCantJumpTime_Glide(float DeltaTime, AActor Owner)
	{
		if (LandAnimCantJumpTimer_Glide > 0f)
		{
			LandAnimCantJumpTimer_Glide -= DeltaTime;
		}
	}

	private void CheckLandCantJumpTime(IBUC_ABPCharacterData ChrData, float DeltaTime, AActor Owner)
	{
		if (ChrData.IsFalling && !bOpenLandCheck_Jump)
		{
			bOpenLandCheck_Jump = true;
		}
		if (!bOpenLandCheck_Jump)
		{
			return;
		}
		if (!ChrData.IsFalling && LandAnimCantJumpTimer == -1f)
		{
			if (AnimLand_JumpTime <= 0f)
			{
				bOpenLandCheck_Jump = false;
				return;
			}
			LandAnimCantJumpTimer = AnimLand_JumpTime;
		}
		if (LandAnimCantJumpTimer >= 0f)
		{
			LandAnimCantJumpTimer -= DeltaTime;
			if (LandAnimCantJumpTimer < 0f)
			{
				AnimLand_JumpTime = 0f;
				LandAnimCantJumpTimer = -1f;
				bOpenLandCheck_Jump = false;
			}
		}
	}

	private void CheckLandCantAttackTime(IBUC_ABPCharacterData ChrData, float DeltaTime, AActor Owner)
	{
		if (ChrData.IsFalling && !bOpenLandCheck_Attack)
		{
			bOpenLandCheck_Attack = true;
		}
		if (!bOpenLandCheck_Attack)
		{
			return;
		}
		if (!ChrData.IsFalling && LandAnimCantAttackTimer == -1f)
		{
			if (AnimLand_AttackTime <= 0f)
			{
				bOpenLandCheck_Attack = false;
				return;
			}
			LandAnimCantAttackTimer = AnimLand_AttackTime;
		}
		if (LandAnimCantAttackTimer >= 0f)
		{
			LandAnimCantAttackTimer -= DeltaTime;
			if (LandAnimCantAttackTimer < 0f)
			{
				AnimLand_AttackTime = 0f;
				LandAnimCantAttackTimer = -1f;
				bOpenLandCheck_Attack = false;
			}
		}
	}

	private void CheckLandCantDodgeTime(IBUC_ABPCharacterData ChrData, float DeltaTime, AActor Owner)
	{
		if (ChrData.IsFalling && !bOpenLandCheck_Dodge)
		{
			bOpenLandCheck_Dodge = true;
		}
		if (!bOpenLandCheck_Dodge)
		{
			return;
		}
		if (!ChrData.IsFalling && LandAnimCantDodgeTimer == -1f)
		{
			if (AnimLand_DodgeTime <= 0f)
			{
				bOpenLandCheck_Dodge = false;
				return;
			}
			LandAnimCantDodgeTimer = AnimLand_DodgeTime;
		}
		if (LandAnimCantDodgeTimer >= 0f)
		{
			LandAnimCantDodgeTimer -= DeltaTime;
			if (LandAnimCantDodgeTimer < 0f)
			{
				AnimLand_DodgeTime = 0f;
				LandAnimCantDodgeTimer = -1f;
				bOpenLandCheck_Dodge = false;
			}
		}
	}
}
