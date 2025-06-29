using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EInertializationState", "Engine", UnrealModuleType.Engine)]
public enum EInertializationState
{
	Inactive,
	Pending,
	Active
}
