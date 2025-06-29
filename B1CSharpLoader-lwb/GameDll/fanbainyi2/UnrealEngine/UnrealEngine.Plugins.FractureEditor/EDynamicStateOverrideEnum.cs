using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.FractureEditor;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/FractureEditor.EDynamicStateOverrideEnum", "FractureEditor", UnrealModuleType.EnginePlugin)]
public enum EDynamicStateOverrideEnum : byte
{
	NoOverride,
	Sleeping,
	Kinematic,
	Static
}
