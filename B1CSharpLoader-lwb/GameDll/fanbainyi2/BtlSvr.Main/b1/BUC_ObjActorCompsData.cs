using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ObjActorCompsData : b1.IBUC_ObjActorCompsData
{
	private TStrongObjectPtr<BGUProjectileBaseActor> mOwnerObjActor = new TStrongObjectPtr<BGUProjectileBaseActor>();

	private TStrongObjectPtr<UProjectileMovementComponent> mOwnerMovement = new TStrongObjectPtr<UProjectileMovementComponent>();

	public BGUProjectileBaseActor OwnerObjActor
	{
		get
		{
			return mOwnerObjActor.Get();
		}
		set
		{
			mOwnerObjActor.Set(value);
		}
	}

	public UProjectileMovementComponent OwnerMovement
	{
		get
		{
			return mOwnerMovement.Get();
		}
		set
		{
			mOwnerMovement.Set(value);
		}
	}

	public void InitWithObjActor(BGUProjectileBaseActor ObjActor)
	{
		OwnerObjActor = ObjActor;
		OwnerMovement = ObjActor.GetProjectileMovement();
	}
}
