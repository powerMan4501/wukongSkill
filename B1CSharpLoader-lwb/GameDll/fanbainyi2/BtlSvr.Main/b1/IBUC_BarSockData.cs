using b1.ECS;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_BarSockData
{
	FVector GetLockTargetSockLocation();

	FVector GetInteractSockLocation();

	string GetLockTargetSkeletonSocket();

	Entity GetLockTargetActor();

	float GetLastSwitchLockTime();

	bool GetIsTargetSp();

	bool IsCantShowBarSockUI();
}
