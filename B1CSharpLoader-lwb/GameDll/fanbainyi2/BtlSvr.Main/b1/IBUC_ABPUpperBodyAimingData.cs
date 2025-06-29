using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ABPUpperBodyAimingData
{
	bool NeedReset { get; }

	bool Enable { get; }

	float UpperBodyAimYaw { get; }

	float UpperBodyAimPitch { get; }

	FVector InnerTargetPosition { get; }
}
