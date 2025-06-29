using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMoveComponentAction", "Engine", UnrealModuleType.Engine)]
public enum EMoveComponentAction
{
	Move,
	Stop,
	Return
}
