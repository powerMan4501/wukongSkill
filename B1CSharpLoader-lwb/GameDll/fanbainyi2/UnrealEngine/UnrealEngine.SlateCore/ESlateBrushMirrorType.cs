using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.ESlateBrushMirrorType", "SlateCore", UnrealModuleType.Engine)]
public enum ESlateBrushMirrorType
{
	NoMirror,
	Horizontal,
	Vertical,
	Both
}
