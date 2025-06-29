using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.BlockAMSelectMode")]
public enum EBlockAMSelectMode : byte
{
	[DisplayName("序列选择模式")]
	SequenceSelectMode,
	[DisplayName("随机选择模式")]
	RandomSelectMode
}
