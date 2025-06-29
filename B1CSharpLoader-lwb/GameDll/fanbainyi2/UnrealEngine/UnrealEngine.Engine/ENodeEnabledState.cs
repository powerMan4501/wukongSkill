using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENodeEnabledState", "Engine", UnrealModuleType.Engine)]
public enum ENodeEnabledState
{
	Enabled,
	Disabled,
	DevelopmentOnly
}
