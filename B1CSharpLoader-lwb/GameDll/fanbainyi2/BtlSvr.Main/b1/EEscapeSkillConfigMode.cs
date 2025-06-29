using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EscapeSkillConfigMode")]
public enum EEscapeSkillConfigMode : byte
{
	[UMeta(MD.Hidden)]
	None,
	[DisplayName("单方向")]
	Single,
	[DisplayName("多方向")]
	Multiple,
	[DisplayName("使用场景点配置的技能")]
	FromSceneItem
}
