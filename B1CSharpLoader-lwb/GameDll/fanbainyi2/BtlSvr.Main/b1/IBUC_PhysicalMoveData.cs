using UnrealEngine.Runtime;

namespace b1;

internal interface IBUC_PhysicalMoveData
{
	FVector PhysicalMoveVelocity { get; }

	float GravityAddValue { get; }

	float AccuratelyMoveDistance { get; }

	float DefaultGravityZ { get; }
}
