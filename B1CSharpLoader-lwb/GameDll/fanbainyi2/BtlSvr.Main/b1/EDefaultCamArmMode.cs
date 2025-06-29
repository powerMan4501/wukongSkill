using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.DefaultCamArmMode")]
public enum EDefaultCamArmMode : byte
{
	Default,
	Close,
	Normal,
	Far,
	Free
}
