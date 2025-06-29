using UnrealEngine.Runtime;

namespace b1;

public struct SlowIK_RelativeTransData
{
	public FTransform LockTransform_Local;

	public FTransform Relative_l_in_r;

	public FTransform Relative_r_in_l;
}
