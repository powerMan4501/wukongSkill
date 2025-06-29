using UnrealEngine.Engine;

namespace b1;

public interface IBUC_ABPPoseSnapshotData
{
	bool bUsePoseOverride { get; }

	FPoseSnapshot PoseSnapshot { get; }

	float EnableSnapshotBlendTime { get; }

	float DisableSnapshotBlendTime { get; }
}
