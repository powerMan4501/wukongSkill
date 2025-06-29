using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBlueprintNativizationFlag", "Engine", UnrealModuleType.Engine)]
public enum EBlueprintNativizationFlag
{
	Disabled,
	Dependency,
	ExplicitlyEnabled
}
