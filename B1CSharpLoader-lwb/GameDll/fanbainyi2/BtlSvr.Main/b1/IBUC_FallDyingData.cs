using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_FallDyingData
{
	float GetFallDyingTime();

	float GetSaveSelfWaitTime();

	bool GetCanSaveSelf();

	bool GetCanBeSaveByTarget();

	EFallDyingState GetFallDyingState();
}
