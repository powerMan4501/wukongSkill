using UnrealEngine.Engine;

namespace b1;

internal interface IBUC_ObjActorCompsData
{
	BGUProjectileBaseActor OwnerObjActor { get; }

	UProjectileMovementComponent OwnerMovement { get; }
}
