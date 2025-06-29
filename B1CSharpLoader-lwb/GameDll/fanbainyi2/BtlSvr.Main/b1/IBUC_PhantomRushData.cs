using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public interface IBUC_PhantomRushData : IPersistentECSData
{
	int NowConfigID { get; }

	int CacheConfigID { get; }

	bool Imperceptible { get; }

	FPoseSnapshot PoseSnapshot { get; }
}
