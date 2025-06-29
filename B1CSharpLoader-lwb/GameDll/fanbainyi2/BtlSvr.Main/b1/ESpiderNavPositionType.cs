using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.SpiderNavPositionType")]
public enum ESpiderNavPositionType : byte
{
	[DisplayName("地面")]
	Ground,
	[DisplayName("墙面")]
	Wall
}
