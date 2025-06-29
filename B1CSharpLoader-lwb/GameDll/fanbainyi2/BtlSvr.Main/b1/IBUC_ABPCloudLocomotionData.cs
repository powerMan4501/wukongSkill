using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public interface IBUC_ABPCloudLocomotionData
{
	float InputVelocityAngle { get; }

	float StartAngle { get; }

	EGaitGroundedState GaitGroundedState { get; }

	bool bCloudFall { get; }

	int CloudBreakAnimId { get; }

	bool bIsCloudFallInLowAirArea { get; }

	BUABPJump_LandSettingData CloudLand_Low { get; }

	BUABPJump_LandSettingData CloudLand_High { get; }

	UAnimSequence AnimCloudFallLoop { get; }

	Dictionary<int, FCloudBreakAnimSetting> CloudBreakAnimSettings { get; }
}
