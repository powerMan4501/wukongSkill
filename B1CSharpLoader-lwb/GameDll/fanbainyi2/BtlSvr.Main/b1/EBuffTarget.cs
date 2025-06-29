using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BuffTarget")]
public enum EBuffTarget : byte
{
	[DisplayName("主角")]
	Player,
	[DisplayName("触发Trigger的单位")]
	OtherUnit,
	[DisplayName("场景中手动选择单位")]
	SceneUnit
}
