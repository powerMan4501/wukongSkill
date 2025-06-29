using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EGSTrainDummyHPType")]
public enum EGSTrainDummyHPType : byte
{
	[Tooltip("使用单位默认属性")]
	[DisplayName("默认")]
	Default,
	[Tooltip("木桩单位无限HP")]
	[DisplayName("无限")]
	Infinite,
	[DisplayName("指定值")]
	[Tooltip("使用指定HP值")]
	Value
}
