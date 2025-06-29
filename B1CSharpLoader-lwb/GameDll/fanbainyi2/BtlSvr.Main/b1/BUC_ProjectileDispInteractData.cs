using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_ProjectileDispInteractData : IPersistentECSData
{
	public bool EnableInteract;

	private TStrongObjectPtr<USphereComponent> mInteractStartComp = new TStrongObjectPtr<USphereComponent>();

	private TStrongObjectPtr<USphereComponent> mInteractEndComp = new TStrongObjectPtr<USphereComponent>();

	public float Interact_Start_SphereRadius;

	public FTransform Interact_Start_LocalTransform;

	public float Interact_End_SphereRadius;

	public FTransform Interact_End_LocalTransform;

	public USphereComponent InteractStartComp
	{
		get
		{
			return mInteractStartComp.Get();
		}
		set
		{
			mInteractStartComp.Set(value);
		}
	}

	public USphereComponent InteractEndComp
	{
		get
		{
			return mInteractEndComp.Get();
		}
		set
		{
			mInteractEndComp.Set(value);
		}
	}

	public BUC_ProjectileDispInteractData()
	{
		EnableInteract = false;
	}

	public float GetScaledSphereRadius_Interact_Start(AActor Owner)
	{
		return (float)Owner.GetActorScale3D().GetMin() * Interact_Start_SphereRadius;
	}

	public float GetScaledSphereRadius_Interact_End(AActor Owner)
	{
		return (float)Owner.GetActorScale3D().GetMin() * Interact_End_SphereRadius;
	}

	public FVector GetWorldLocation_Interact_Start(AActor Owner)
	{
		return Owner.GetActorTransform().TransformPosition(Interact_Start_LocalTransform.GetLocation());
	}

	public FVector GetWorldLocation_Interact_End(AActor Owner)
	{
		return Owner.GetActorTransform().TransformPosition(Interact_End_LocalTransform.GetLocation());
	}
}
