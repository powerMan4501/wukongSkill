using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.EquipFXType")]
public enum EEquipFXType : byte
{
	None,
	[DisplayName("穿戴特效")]
	Wear,
	[DisplayName("升级特效")]
	Upgrade,
	[DisplayName("升级切换模型特效")]
	UpgradeChange
}
