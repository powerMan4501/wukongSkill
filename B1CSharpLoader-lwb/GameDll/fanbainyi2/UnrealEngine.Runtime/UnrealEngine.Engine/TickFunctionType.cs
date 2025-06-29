namespace UnrealEngine.Engine;

public enum TickFunctionType : byte
{
	FActorComponentTickFunction,
	FActorTickFunction,
	FCharacterMovementComponentPostPhysicsTickFunction,
	FEndPhysicsTickFunction,
	FSkeletalMeshComponentClothTickFunction,
	FSkeletalMeshComponentEndPhysicsTickFunction,
	FStartPhysicsTickFunction
}
