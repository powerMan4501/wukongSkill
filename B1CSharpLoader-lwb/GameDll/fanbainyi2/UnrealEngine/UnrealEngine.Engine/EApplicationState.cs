using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EApplicationState", "Engine", UnrealModuleType.Engine)]
public enum EApplicationState : byte
{
	Unknown,
	Inactive,
	Background,
	Active
}
