using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AiWeakInteractCheckType")]
public enum EAiWeakInteractCheckType : byte
{
	[DisplayName("玩家和跟随单位同在")]
	BothPlayerAndFollowPartner,
	[DisplayName("只有跟随单位")]
	OnlyFollowPartner
}
