using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENavigationQueryResult", "Engine", UnrealModuleType.Engine)]
public enum ENavigationQueryResult
{
	Invalid,
	Error,
	Fail,
	Success
}
