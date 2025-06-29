using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.SocketMatchTamerType")]
public enum ESocketMatchTamerType : byte
{
	[DisplayName("前缀匹配")]
	Prefix,
	[DisplayName("全匹配")]
	Full
}
