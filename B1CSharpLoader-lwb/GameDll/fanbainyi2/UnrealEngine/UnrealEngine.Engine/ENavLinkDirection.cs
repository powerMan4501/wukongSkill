using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENavLinkDirection", "Engine", UnrealModuleType.Engine)]
public enum ENavLinkDirection
{
	BothWays,
	LeftToRight,
	RightToLeft
}
