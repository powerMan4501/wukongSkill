using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.EFontHinting", "SlateCore", UnrealModuleType.Engine)]
public enum EFontHinting
{
	Default,
	Auto,
	AutoLight,
	Monochrome,
	None
}
