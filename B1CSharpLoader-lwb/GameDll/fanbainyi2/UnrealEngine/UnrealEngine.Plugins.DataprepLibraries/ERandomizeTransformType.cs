using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/DataprepLibraries.ERandomizeTransformType", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public enum ERandomizeTransformType : byte
{
	Rotation,
	Location,
	Scale
}
