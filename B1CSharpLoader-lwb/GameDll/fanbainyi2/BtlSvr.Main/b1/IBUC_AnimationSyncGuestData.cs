using UnrealEngine.Engine;

namespace b1;

public interface IBUC_AnimationSyncGuestData
{
	AActor Host { get; }

	UAnimMontage DeathMontage { get; }
}
