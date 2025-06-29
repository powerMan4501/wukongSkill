using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.ESlateBrushImageType", "SlateCore", UnrealModuleType.Engine)]
public enum ESlateBrushImageType
{
	NoImage,
	FullColor,
	Linear,
	Vector
}
