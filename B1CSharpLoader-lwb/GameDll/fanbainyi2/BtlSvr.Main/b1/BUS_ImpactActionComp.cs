using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_ImpactActionComp : UActorCompBaseCS
{
	private b1.BUC_ImpactActionData ImpactActionData;

	private IBUC_UnitStateData UnitStateData;

	private static FName CheckCapsuleTagName = B1GlobalFNames.ImpactActionCheck;

	private List<EObjectTypeQuery> ObjectTypeQuery = new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery2 };

	private List<AActor> IgnoreActors = new List<AActor>();

	private static List<ECollisionChannel> Filter = new List<ECollisionChannel> { ECollisionChannel.ECC_WorldDynamic };

	public override void OnAttach()
	{
		ImpactActionData = RequireWritableData<b1.BUC_ImpactActionData>();
		UnitStateData = RequireReadOnlyData<IBUC_UnitStateData, BUC_UnitStateData>();
	}

	public override void OnBeginPlay()
	{
		if (!ImpactActionData.bEnableImpactAction)
		{
			return;
		}
		foreach (UActorComponent item2 in GetOwner().GetComponentsByTag(UClass.GetClass<UShapeComponent>(), CheckCapsuleTagName))
		{
			UShapeComponent uShapeComponent = item2 as UShapeComponent;
			if (uShapeComponent != null)
			{
				ImpactActionData.CheckComps.Add(uShapeComponent);
				FGSSweepCheckShapeInfo item = default(FGSSweepCheckShapeInfo);
				if (uShapeComponent is UBoxComponent uBoxComponent)
				{
					item.SweepCheckShapeType = EGSSweepCheckShapeType.BoxShape;
					item.ShapeParamVector = uBoxComponent.GetScaledBoxExtent();
				}
				else if (uShapeComponent is UCapsuleComponent uCapsuleComponent)
				{
					item.SweepCheckShapeType = EGSSweepCheckShapeType.SphereShape;
					item.ShapeParamFloat = ((uCapsuleComponent.GetScaledCapsuleHalfHeight() > uCapsuleComponent.GetScaledCapsuleRadius()) ? uCapsuleComponent.GetScaledCapsuleHalfHeight() : uCapsuleComponent.GetScaledCapsuleRadius());
				}
				else if (uShapeComponent is USphereComponent uSphereComponent)
				{
					item.SweepCheckShapeType = EGSSweepCheckShapeType.SphereShape;
					item.ShapeParamFloat = uSphereComponent.GetScaledSphereRadius();
				}
				ImpactActionData.CheckCompShapeInfo.Add(item);
			}
		}
		IgnoreActors.Add(Owner);
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!ImpactActionData.bEnableImpactAction || ImpactActionData.CheckComps.Count == 0)
		{
			return;
		}
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null || aCharacter.CapsuleComponent == null || aCharacter.Mesh.GetAnimInstance() == null || aCharacter.Mesh.GetAnimInstance().GetCurrentActiveMontage() != null)
		{
			return;
		}
		FVector actorForwardVector = aCharacter.GetActorForwardVector();
		float num = aCharacter.CharacterMovement.Velocity.Size() * ImpactActionData.EnableImplactCalculationParameter;
		for (int i = 0; i < ImpactActionData.CheckComps.Count; i++)
		{
			UShapeComponent uShapeComponent = ImpactActionData.CheckComps[i];
			if (uShapeComponent == null)
			{
				continue;
			}
			FVector worldLocation = uShapeComponent.GetWorldLocation();
			FVector translation = worldLocation + actorForwardVector * 1.0;
			UBGUFuncLibSelectTargets.BGUGetSweepCheckResultsByCollisionChannel(Owner, new FTransform(worldLocation), new FTransform(translation), uShapeComponent.GetWorldRotation().Quaternion(), ECollisionChannel.ECC_GameTraceChannel2, ImpactActionData.CheckCompShapeInfo[i], out var SweepResults, IgnoreActors, null, Filter);
			if (SweepResults == null || SweepResults.Count <= 0)
			{
				continue;
			}
			foreach (FUStGSHitResult item in SweepResults)
			{
				if (item.HitComponent == null)
				{
					continue;
				}
				AActor actor = item.Actor;
				if (actor == null)
				{
					continue;
				}
				b1.IBUC_DestructibleData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_DestructibleData, b1.BUC_DestructibleData>(actor);
				if (readOnlyData == null || readOnlyData.IsDestroyed || num - readOnlyData.Mass <= 0f)
				{
					continue;
				}
				FVector impactPoint = item.ImpactPoint;
				FVector normal = item.Normal;
				BGUFunctionLibraryCS.BGUDestroyDestructible(actor, new FVector(impactPoint.X, impactPoint.Y, impactPoint.Z), -1.0 * new FVector(normal.X, normal.Y, normal.Z));
				if (aCharacter.CharacterMovement.Velocity.Size() * ImpactActionData.EnableImplactCalculationParameter - readOnlyData.Mass <= ImpactActionData.EnableImpactAnimThreshold)
				{
					continue;
				}
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(actor);
				List<UActorComponent> componentsByClass = actor.GetComponentsByClass(UClass.GetClass<UShapeComponent>());
				if (componentsByClass != null)
				{
					foreach (UActorComponent item2 in componentsByClass)
					{
						UCapsuleComponent uCapsuleComponent = item2 as UCapsuleComponent;
						UBoxComponent uBoxComponent = item2 as UBoxComponent;
						USphereComponent uSphereComponent = item2 as USphereComponent;
						if (uCapsuleComponent != null)
						{
							fVector.Z += uCapsuleComponent.GetScaledCapsuleHalfHeight() * 2f;
							break;
						}
						if (uBoxComponent != null)
						{
							fVector.Z += uBoxComponent.GetScaledBoxExtent().Z;
							break;
						}
						if (uSphereComponent != null)
						{
							fVector.Z += uSphereComponent.GetScaledSphereRadius() * 2f;
							break;
						}
					}
				}
				if (fVector.Z - worldLocation.Z < ImpactActionData.EnableImpactActionHeightDiff || UnitStateData.HasState(EBGUUnitState.Attacking) || UnitStateData.HasState(EBGUUnitState.ImpactActionPlaying))
				{
					continue;
				}
				UAnimMontage impactMontage = GetImpactMontage(new FVector(impactPoint.X, impactPoint.Y, impactPoint.Z));
				if (impactMontage != null)
				{
					float num2 = BGUFuncLibAnim.BGUActorTryPlayMontage(aCharacter, impactMontage, FName.None);
					if (num2 > 0f)
					{
						base.BUSEventCollection.Evt_UnitStateTrigger.Invoke(EBUStateTrigger.EnableImpactAction, num2, NeedForceUpdate: true);
					}
				}
			}
		}
	}

	private UAnimMontage GetImpactMontage(FVector HitItemPostion)
	{
		UAnimMontage result = null;
		AActor owner = GetOwner();
		if (owner != null)
		{
			AIFuncLibForCS.GetTurnAngle(owner, HitItemPostion, out var AbsDegValue, out var IsClockwise);
			if (IsClockwise)
			{
				if (AbsDegValue <= ImpactActionData.MiddleRightAngleSplitLine)
				{
					result = ImpactActionData.ForwardImpactActionAnim;
				}
				else if (AbsDegValue <= ImpactActionData.RightAngleSplitLine)
				{
					result = ImpactActionData.RightSideImpactActionAnim;
				}
			}
			else if (AbsDegValue <= ImpactActionData.MiddleLeftAngleSplitLine)
			{
				result = ImpactActionData.ForwardImpactActionAnim;
			}
			else if (AbsDegValue <= ImpactActionData.LeftAngleSplitLine)
			{
				result = ImpactActionData.LeftSideImpactActionAnim;
			}
		}
		return result;
	}
}
