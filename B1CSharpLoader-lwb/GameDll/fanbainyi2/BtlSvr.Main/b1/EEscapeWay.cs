using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EscapeWay")]
public enum EEscapeWay : byte
{
	[UMeta(MD.Hidden)]
	[DisplayName("无")]
	None,
	[DisplayName("移动脱困")]
	MoveTo,
	[DisplayName("释放技能")]
	CastSkill
}
