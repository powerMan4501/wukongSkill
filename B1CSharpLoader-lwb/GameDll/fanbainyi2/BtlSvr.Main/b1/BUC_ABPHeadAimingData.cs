using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPHeadAimingData : IBUC_ABPHeadAimingData
{
	public float HeadAimYaw { get; set; }

	public float HeadAimPitch { get; set; }

	public int AimOffsetTurnSpeed { get; set; }

	public int AimOffsetBlindAngle { get; set; }

	public void Update(AActor Owner, IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		FRotator fRotator = new FRotator(0.0, 0.0, 0.0);
		ACharacter aCharacter = BGUFunctionLibraryCS.BGUGetAOTarget(Owner) as ACharacter;
		IBUC_TargetInfoData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Owner);
		if (aCharacter != null)
		{
			FVector target = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter);
			FVector start = ChrData.ActorLocation;
			float scaledCapsuleHalfHeight = aCharacter.CapsuleComponent.GetScaledCapsuleHalfHeight();
			FVector actorUpVector = aCharacter.GetActorUpVector();
			actorUpVector.Normalize();
			target += scaledCapsuleHalfHeight / 2f * actorUpVector;
			scaledCapsuleHalfHeight = ChrData.ScaledCapsuleHalfHeight;
			actorUpVector = ChrData.UpVector;
			actorUpVector.Normalize();
			start += scaledCapsuleHalfHeight / 2f * actorUpVector;
			if (!ChrData.AimOffsetEyeSocketName.Equals(FName.None))
			{
				start = ChrData.AimOffsetEyeSocketPos;
			}
			IBUC_ABPCharacterData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_ABPCharacterData, BUC_ABPCharacterData>(aCharacter);
			if (unPersistentReadOnlyData != null && !unPersistentReadOnlyData.AimOffsetBeWatchedSocketName.Equals(FName.None))
			{
				target = unPersistentReadOnlyData.AimOffsetBeWatchedSocketPos;
			}
			fRotator = UMathLibrary.FindLookAtRotation(start, target);
			fRotator.Roll = 0f;
			fRotator.Yaw = UMathLibrary.NormalizeAxis(UMathLibrary.NormalizeAxis(fRotator.Yaw) - UMathLibrary.NormalizeAxis(ChrData.ActorRotation.Yaw));
			UnitLockTargetInfo aOTarget = readOnlyData.GetAOTarget();
			if (aOTarget != null && aOTarget.NonCombatantAOTargetDegreeLimit > 0f && FMath.Abs(fRotator.Yaw) > aOTarget.NonCombatantAOTargetDegreeLimit)
			{
				fRotator.Yaw = 0f;
				fRotator.Pitch = 0f;
			}
			if (AimOffsetBlindAngle > 0)
			{
				float num = 180 - AimOffsetBlindAngle;
				if (fRotator.Yaw < 0f - num || fRotator.Yaw > num)
				{
					fRotator.Yaw = 0f;
					fRotator.Pitch = 0f;
				}
			}
		}
		HeadAimYaw = FMath.Clamp(FMath.FInterpConstantTo(HeadAimYaw, fRotator.Yaw, DeltaTime, AimOffsetTurnSpeed), -90f, 90f);
		HeadAimPitch = FMath.Clamp(FMath.FInterpConstantTo(HeadAimPitch, fRotator.Pitch, DeltaTime, AimOffsetTurnSpeed), -90f, 90f);
	}

	public void Init(BUABPSettingData Setting)
	{
		AimOffsetTurnSpeed = Setting.AimOffsetSetting.AimOffsetTurnSpeed;
		AimOffsetBlindAngle = Setting.AimOffsetSetting.AimOffsetBlindAngle;
	}
}
