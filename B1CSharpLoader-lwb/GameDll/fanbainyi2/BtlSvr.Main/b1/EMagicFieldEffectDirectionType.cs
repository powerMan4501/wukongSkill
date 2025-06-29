using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MagicFieldEffectDirectionType")]
public enum EMagicFieldEffectDirectionType : byte
{
	[Tooltip("受影响角色前后有不同效果")]
	[DisplayName("前后")]
	FrontBack,
	[DisplayName("前后左右")]
	[Tooltip("受影响角色前后左右有不同效果")]
	FrontBackLeftRight
}
