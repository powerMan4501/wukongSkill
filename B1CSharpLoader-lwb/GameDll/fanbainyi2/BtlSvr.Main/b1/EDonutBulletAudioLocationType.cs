using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.DonutBulletAudioLocationType")]
public enum EDonutBulletAudioLocationType : byte
{
	[UMeta(MDFunc.DisplayName, "不发声")]
	None,
	[UMeta(MDFunc.DisplayName, "内径边缘发声")]
	InnerBorder,
	[UMeta(MDFunc.DisplayName, "外径边缘发声")]
	OuterBorder,
	[UMeta(MDFunc.DisplayName, "内外径之间发声")]
	Between
}
