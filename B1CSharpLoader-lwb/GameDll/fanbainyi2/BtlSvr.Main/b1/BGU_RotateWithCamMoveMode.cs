using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGU_RotateWithCamMoveMode : BUC_MoveModeWithRotateBase
{
	protected override void OnUpdate(float DeltaTime)
	{
		if (RotateSpeed > 0f)
		{
			FRotator Current = BGUFuncLibActorTransformCS.BGUGetActorRotation(OwnerCharacter);
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter);
			FVector2D unitRotateAimDir = OwnerCharacter.GetActorForwardVector().GetSafeNormal2D().Conv_VectorToVector2D();
			FVector2D unit2TargetDir = new FVector2D(TargetPos.X - fVector.X, TargetPos.Y - fVector.Y);
			float rotateAngle2D = BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, unit2TargetDir);
			bool num = BGU_MoveUtil.IsRotateClockwise(unitRotateAimDir, unit2TargetDir);
			FRotator Target = Current;
			if (num)
			{
				Target.Yaw = MathLib.NormalizeAxis(Target.Yaw + rotateAngle2D);
			}
			else
			{
				Target.Yaw = MathLib.NormalizeAxis(Target.Yaw - rotateAngle2D);
			}
			FRotator newRotation = MathLib.RInterpConstantTo(in Current, in Target, DeltaTime, RotateSpeed);
			newRotation.Pitch = Current.Pitch;
			newRotation.Roll = Current.Roll;
			BGUFuncLibActorTransformCS.BGUSetActorRotation(OwnerCharacter, newRotation, bTeleportPhysics: false);
		}
	}

	public override EBGUMoveMode GetMoveMode()
	{
		return EBGUMoveMode.RotateWithCam;
	}
}
