using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ChangeTargetType")]
public enum EChangeTargetType : byte
{
	[DisplayName("无额外指定目标")]
	None,
	Player,
	Master,
	Summon,
	SkillBaseTarget,
	UnitGuid
}
