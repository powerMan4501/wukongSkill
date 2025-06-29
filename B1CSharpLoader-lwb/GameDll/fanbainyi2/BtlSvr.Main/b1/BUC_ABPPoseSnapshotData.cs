using UnrealEngine.Engine;

namespace b1;

public class BUC_ABPPoseSnapshotData : IBUC_ABPPoseSnapshotData
{
	public bool bUsePoseOverride { get; set; }

	public FPoseSnapshot PoseSnapshot { get; set; }

	public float EnableSnapshotBlendTime { get; set; }

	public float DisableSnapshotBlendTime { get; set; }
}
