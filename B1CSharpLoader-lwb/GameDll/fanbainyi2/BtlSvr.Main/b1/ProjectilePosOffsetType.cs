using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.ProjectilePosOffsetType")]
public enum ProjectilePosOffsetType : byte
{
	[DisplayName("无偏移")]
	None,
	[DisplayName("固定偏移")]
	Normal,
	[DisplayName("范围偏移")]
	RangeOffset,
	[DisplayName("随机偏移")]
	RandomOffset
}
