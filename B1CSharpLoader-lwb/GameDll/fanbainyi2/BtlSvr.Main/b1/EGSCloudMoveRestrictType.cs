using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EGSCloudMoveRestrictType")]
public enum EGSCloudMoveRestrictType : byte
{
	[DisplayName("无")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	None,
	[UProperty]
	[EditAnywhere]
	[DisplayName("禁止筋斗云飞行")]
	[BlueprintReadWrite]
	ForbidEnableCloudMove,
	[DisplayName("禁止下筋斗云")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	ForbidDisableCloudMove
}
