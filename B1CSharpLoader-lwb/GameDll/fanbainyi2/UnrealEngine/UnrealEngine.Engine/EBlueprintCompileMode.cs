using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBlueprintCompileMode", "Engine", UnrealModuleType.Engine)]
public enum EBlueprintCompileMode
{
	Default,
	Development,
	FinalRelease
}
