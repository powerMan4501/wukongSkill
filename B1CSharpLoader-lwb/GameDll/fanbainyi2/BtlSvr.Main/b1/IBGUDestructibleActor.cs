using UnrealEngine.Runtime;

namespace b1;

public interface IBGUDestructibleActor
{
	void OnDestroyDestructible(FVector HitLocation, FVector ImpulseDir, float ImpulseStrength, float Damage);

	void OnResetDestructible(bool IsDestroyed);
}
