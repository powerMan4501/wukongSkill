using UnrealEngine.Runtime;

namespace UnrealEngine.IntroTutorials;

[UEnum]
[UMetaPath("/Script/IntroTutorials.ETutorialAnchorIdentifier", "IntroTutorials", UnrealModuleType.Engine)]
public enum ETutorialAnchorIdentifier
{
	None,
	NamedWidget,
	Asset
}
