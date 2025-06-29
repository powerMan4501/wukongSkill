using UnrealEngine.Runtime;

namespace b1;

internal class BUC_RootMotionFollowData
{
	public b1.BGU_Timeline InterpTransformTL = new b1.BGU_Timeline();

	public FTransform DefaultTransform = FTransform.Identity;

	public float InterpTime = 0.3f;

	public float FollowStateRotationRate { get; set; }

	public uint MovingRotationRateHandleID { get; set; }

	public BUC_RootMotionFollowData()
	{
		InterpTransformTL.SetTimelineLength(InterpTime);
	}
}
