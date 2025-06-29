using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EComponentCreationMethod", "Engine", UnrealModuleType.Engine)]
public enum EComponentCreationMethod
{
	Native,
	SimpleConstructionScript,
	UserConstructionScript,
	Instance
}
