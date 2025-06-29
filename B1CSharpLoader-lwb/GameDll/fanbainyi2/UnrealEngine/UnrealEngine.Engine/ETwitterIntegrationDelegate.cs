using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETwitterIntegrationDelegate", "Engine", UnrealModuleType.Engine)]
public enum ETwitterIntegrationDelegate
{
	TID_AuthorizeComplete,
	TID_TweetUIComplete,
	TID_RequestComplete
}
