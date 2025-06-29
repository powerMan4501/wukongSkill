using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.PriorityActionUnitType")]
public enum EPriorityActionUnitType : byte
{
	[DisplayName("激活群体AI的单位")]
	ActivatingGroupAIUnit,
	[DisplayName("没有激活群体AI的单位")]
	NoneActivatingGroupAIUnit,
	[Tooltip("只会选择对应ResID单位")]
	[DisplayName("全部单位")]
	AllUnit
}
