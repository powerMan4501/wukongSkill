using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.ManagedNPCUnitType")]
public enum EManagedNPCUnitType : byte
{
	[UProperty]
	[DisplayName("无")]
	None,
	[DisplayName("动态阻挡")]
	[UProperty]
	DynamicObstacle,
	[UProperty]
	[DisplayName("触发盒")]
	TriggerBox,
	[UProperty]
	[DisplayName("交互物")]
	Interactor,
	[UProperty]
	[DisplayName("刷怪器")]
	Spawner,
	[UProperty]
	[DisplayName("单位")]
	Unit
}
