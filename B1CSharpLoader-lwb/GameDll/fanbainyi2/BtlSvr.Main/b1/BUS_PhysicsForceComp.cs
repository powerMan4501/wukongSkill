using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PhysicsForceComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_FireImpulseLikeRadialForceComp += new Del_FireImpulseLikeRadialForceComp(FireImpulseLikeRadialForceComp);
	}

	private void FireImpulseLikeRadialForceComp(AActor OwnerActor, EPhysicsForceType PhysicsForceType, float ForceFieldSize, FVector ForceFieldOffset, float DestructibleDamage, float ImpulseStrength, List<EObjectTypeQuery> QueryObjectTypes, float forceDuration, bool IsDrawDebugShape = false)
	{
		if (OwnerActor == null)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerActor) + OwnerActor.GetActorForwardVector() * ForceFieldOffset;
		FGSSweepCheckShapeInfo overlapShapeInfo = new FGSSweepCheckShapeInfo
		{
			SweepCheckShapeType = EGSSweepCheckShapeType.SphereShape,
			ShapeParamFloat = ForceFieldSize
		};
		List<AActor> list = new List<AActor>();
		list.Add(OwnerActor);
		UBGUFuncLibSelectTargets.BGUOverlapMultiByObjectType(OwnerActor.World, fVector, FQuat.Identity, QueryObjectTypes, overlapShapeInfo, list, out var OverlapResults, IsDrawDebugShape);
		List<UPrimitiveComponent> list2 = new List<UPrimitiveComponent>();
		foreach (FUStGSOverlapResult item2 in OverlapResults)
		{
			UPrimitiveComponent item = item2.Component.Get();
			if (!list2.Contains(item))
			{
				list2.Add(item);
			}
		}
		foreach (UPrimitiveComponent item3 in list2)
		{
			AActor owner = item3.GetOwner();
			if (owner != null)
			{
				FVector impulseDir = FVector.ZeroVector;
				switch (PhysicsForceType)
				{
				case EPhysicsForceType.DirectionalForce:
					impulseDir = OwnerActor.GetActorForwardVector();
					break;
				case EPhysicsForceType.ExplosiveForce:
					impulseDir = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner) - fVector;
					break;
				}
				BGUFXActorBase bGUFXActorBase = owner as BGUFXActorBase;
				if (bGUFXActorBase != null)
				{
					BGUFunctionLibraryCS.BGUDestroyDestructible(bGUFXActorBase, BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUFXActorBase), impulseDir, ImpulseStrength);
				}
				item3.AddRadialImpulse(fVector, ForceFieldSize, ImpulseStrength, ERadialImpulseFalloff.RIF_Linear);
			}
		}
	}
}
