using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.DetectedForceType")]
public enum EDetectedForceType : byte
{
	[UMeta(MD.DisplayName, "友方")]
	Friend,
	[UMeta(MD.DisplayName, "敌方")]
	Enemy,
	[UMeta(MD.DisplayName, "其他")]
	Other
}
