using UnrealEngine.Runtime;

namespace UnrealEngine.IntroTutorials;

[UEnum]
[UMetaPath("/Script/IntroTutorials.ETutorialContent", "IntroTutorials", UnrealModuleType.Engine)]
public enum ETutorialContentType
{
	None,
	Text,
	UDNExcerpt,
	RichText
}
