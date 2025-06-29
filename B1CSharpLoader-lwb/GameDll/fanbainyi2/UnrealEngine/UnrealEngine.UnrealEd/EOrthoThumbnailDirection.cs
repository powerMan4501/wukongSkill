using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EOrthoThumbnailDirection", "UnrealEd", UnrealModuleType.Engine)]
public enum EOrthoThumbnailDirection
{
	Top,
	Bottom,
	Left,
	Right,
	Front,
	Back
}
