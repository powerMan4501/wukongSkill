using UnrealEngine.Runtime;

namespace b1;

public interface IBIC_GMRebirthData
{
	FVector GMRebirthPos { get; }

	FRotator GMRebirthRot { get; }

	bool UseGMRebirthTeleport { get; }

	int GMRebirthLevelID { get; }
}
