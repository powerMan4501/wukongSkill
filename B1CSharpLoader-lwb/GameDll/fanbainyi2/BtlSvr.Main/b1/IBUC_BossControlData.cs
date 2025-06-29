using UnrealEngine.Engine;

namespace b1;

public interface IBUC_BossControlData
{
	bool CanBossCatchTarget(AActor TargetActor, ETargetSourceType SourceType);
}
