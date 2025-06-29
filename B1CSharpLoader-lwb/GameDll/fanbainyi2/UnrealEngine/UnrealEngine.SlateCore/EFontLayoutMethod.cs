using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.EFontLayoutMethod", "SlateCore", UnrealModuleType.Engine)]
public enum EFontLayoutMethod
{
	Metrics,
	BoundingBox
}
