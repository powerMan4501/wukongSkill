using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UEnum]
[UMetaPath("/Script/SlateCore.EFontLoadingPolicy", "SlateCore", UnrealModuleType.Engine)]
public enum EFontLoadingPolicy
{
	LazyLoad,
	Stream,
	Inline
}
