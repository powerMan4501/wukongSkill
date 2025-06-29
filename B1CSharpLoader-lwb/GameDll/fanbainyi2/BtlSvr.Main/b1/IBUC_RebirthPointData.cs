using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_RebirthPointData
{
	int RebirthPointConfigID { get; }

	FTransform RebirthPointRebirthTrans { get; }

	bool bActiveState { get; }
}
