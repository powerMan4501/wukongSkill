using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.DistributionType")]
public enum EDistributionType : byte
{
	[DisplayName("发送事件给所有成员")]
	SenderToAllMembers,
	[DisplayName("发送事件给除自己以外的成员")]
	SenderToOtherMembers
}
