using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.AreaType")]
public enum EAreaType : byte
{
	[Tooltip("进入触发")]
	[DisplayName("简单触发盒")]
	SimpleTrigger,
	[Tooltip("进入退出触发")]
	[DisplayName("Volume")]
	Volume
}
