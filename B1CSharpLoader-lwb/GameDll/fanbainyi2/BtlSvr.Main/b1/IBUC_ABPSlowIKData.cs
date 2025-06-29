using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPSlowIKData
{
	float Alpha { get; }

	bool Enable { get; }

	ESlowIKType SlowIKType { get; }

	FTransform LockTransform_Local { get; }

	FTransform Relative_l_in_r { get; }

	FTransform Relative_r_in_l { get; }
}
