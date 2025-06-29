using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SurfaceTypeOverrideMethod")]
public enum ESurfaceTypeOverrideMethod : byte
{
	None,
	Replace,
	Generate
}
