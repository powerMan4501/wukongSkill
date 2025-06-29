using System.Collections.Generic;
using GUR.Runtime;
using UnrealEngine.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_CloudMoveData
{
	bool ForbidEnableCloudMove { get; }

	bool ForbidDisableCloudMove { get; }

	bool IsCloudMoveEnabled { get; }

	List<int> CloudSkillList_GetOff { get; }

	float CurrentPositionHeightLimit { get; }

	bool DisableHeightLimitIfNoInput { get; }

	bool bCloudFall { get; }

	bool bIsCloudFallInLowAirArea { get; }

	int CloudBreakAnimId { get; }

	int CloudMoveItemId { get; }

	bool bIsAutoCloudMoveEnabled { get; }

	FVector AutoMoveTargetLocation { get; }
}
