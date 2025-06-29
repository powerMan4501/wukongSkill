using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class BGU_UnrealActorUtil
{
	public static FVector GetActorRelativeLocation(AActor Actor)
	{
		return Actor.GetRootComponent().RelativeLocation;
	}

	public static void AttachToActorSimple(AActor ChildActor, AActor ParentActor, EAttachmentTransformRules Rule)
	{
		switch (Rule)
		{
		case EAttachmentTransformRules.KeepRelativeTransform:
			ChildActor.AttachToActor(ParentActor, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
			break;
		case EAttachmentTransformRules.KeepWorldTransform:
			ChildActor.AttachToActor(ParentActor, FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
			break;
		case EAttachmentTransformRules.SnapToTargetNotIncludingScale:
			ChildActor.AttachToActor(ParentActor, FName.None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
			break;
		case EAttachmentTransformRules.SnapToTargetIncludingScale:
			ChildActor.AttachToActor(ParentActor, FName.None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
			break;
		}
	}

	public static void DetachFromActor(AActor ChildActor, EDetachmentTransformRules Rule)
	{
		switch (Rule)
		{
		case EDetachmentTransformRules.KeepRelativeTransform:
			ChildActor.DetachFromActor();
			break;
		case EDetachmentTransformRules.KeepWorldTransform:
			ChildActor.DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			break;
		}
	}

	public static void BGUFinishSpawningActor(AActor NewActor, FTransform SpawnTransform)
	{
		UBGUFunctionLibrary.BGUFinishSpawningActor(NewActor, SpawnTransform);
	}

	public static void BGUFinishSpawningActorAndECSBeginPlay(UObject WorldContext, AActor NewActor, FTransform SpawnTransform)
	{
		UBGUFunctionLibrary.BGUFinishSpawningActor(NewActor, SpawnTransform);
		BGW_ECSWorld.Get(WorldContext).BeginPlayEntity(ECSUtil.ToEntity(NewActor));
	}

	public static AActor BGUBeginDeferredActorSpawnFromClass(UObject World, TSubclassOf<AActor> PawnClass, FTransform SpawnTransform, ESpawnActorCollisionHandlingMethod Method, AActor Owner)
	{
		return UBGUFunctionLibrary.BGUBeginDeferredActorSpawnFromClass(World, PawnClass, SpawnTransform, Method, Owner);
	}
}
