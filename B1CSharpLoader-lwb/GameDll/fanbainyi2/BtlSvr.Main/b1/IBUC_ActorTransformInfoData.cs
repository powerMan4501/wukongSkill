using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_ActorTransformInfoData
{
	bool GetNextUpdateTransform(out FTransform OutTransform);

	bool GetNextUpdateLocation(out FVector OutLocation);

	bool GetNextUpdateRotation(out FRotator OutRotator);
}
