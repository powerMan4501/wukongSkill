using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPUpperBodyAimingData : IBUC_ABPUpperBodyAimingData
{
	private IBUC_SceneItemData SceneItemData;

	public bool NeedReset { get; set; }

	public bool Enable { get; set; }

	public float UpperBodyAimYaw { get; set; }

	public float UpperBodyAimPitch { get; set; }

	public FVector InnerTargetPosition { get; set; }

	public EBTTargetType TargetType { get; set; }

	public void Init(IBUC_SceneItemData InSceneItemData)
	{
		SceneItemData = InSceneItemData;
	}

	public void Update(AActor Owner, IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		if (NeedReset)
		{
			UpperBodyAimYaw = FMath.FInterpTo(UpperBodyAimYaw, 0f, DeltaTime, 10f);
			UpperBodyAimPitch = FMath.FInterpTo(UpperBodyAimPitch, 0f, DeltaTime, 10f);
			if (FMath.Abs(UpperBodyAimYaw) < 1f && FMath.Abs(UpperBodyAimPitch) < 1f)
			{
				UpperBodyAimYaw = 0f;
				UpperBodyAimPitch = 0f;
				NeedReset = false;
			}
		}
		if (!Enable)
		{
			return;
		}
		NeedReset = false;
		float target = 0f;
		float target2 = 0f;
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter != null)
		{
			FVector target3 = FVector.ZeroVector;
			switch (TargetType)
			{
			default:
				return;
			case EBTTargetType.Target:
			{
				ACharacter aCharacter2 = BGUFunctionLibraryCS.BGUGetTarget(aCharacter) as ACharacter;
				if (aCharacter2 == null)
				{
					return;
				}
				target3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter2);
				float scaledCapsuleHalfHeight = aCharacter2.CapsuleComponent.GetScaledCapsuleHalfHeight();
				FVector actorUpVector = aCharacter2.GetActorUpVector();
				actorUpVector.Normalize();
				target3 += scaledCapsuleHalfHeight / 2f * actorUpVector;
				break;
			}
			case EBTTargetType.SceneItem:
				if (SceneItemData != null)
				{
					BGUSceneItemBase sceneItemCatch = SceneItemData.SceneItemCatch;
					if (sceneItemCatch == null)
					{
						return;
					}
					target3 = BGUFuncLibActorTransformCS.BGUGetActorLocation(sceneItemCatch);
				}
				break;
			case EBTTargetType.Location:
				target3 = InnerTargetPosition;
				break;
			case EBTTargetType.AlignToCamFwd:
			{
				AController controller = aCharacter.GetController();
				if (controller.IsNullOrDestroyed())
				{
					return;
				}
				FVector2D safeNormal = controller.GetActorForwardVector().Conv_VectorToVector2D().GetSafeNormal();
				target3 = ChrData.ActorLocation + safeNormal.Conv_Vector2DToVector() * 10000.0;
				break;
			}
			case EBTTargetType.Player:
				return;
			}
			FVector actorLocation = ChrData.ActorLocation;
			float scaledCapsuleHalfHeight2 = ChrData.ScaledCapsuleHalfHeight;
			FVector upVector = ChrData.UpVector;
			upVector.Normalize();
			actorLocation += scaledCapsuleHalfHeight2 / 2f * upVector;
			FRotator rotation = MathLib.FindLookAtRotation(actorLocation, target3);
			rotation = MathLib.InverseTransformRotation(new FTransform(ChrData.ActorRotation, ChrData.ActorLocation, ChrData.ActorScale3D), rotation);
			target = FMath.ClampAngle(rotation.Yaw, -90f, 90f);
			target2 = FMath.ClampAngle(rotation.Pitch, -90f, 90f);
		}
		UpperBodyAimYaw = FMath.FInterpTo(UpperBodyAimYaw, target, DeltaTime, 10f);
		UpperBodyAimPitch = FMath.FInterpTo(UpperBodyAimPitch, target2, DeltaTime, 10f);
	}
}
