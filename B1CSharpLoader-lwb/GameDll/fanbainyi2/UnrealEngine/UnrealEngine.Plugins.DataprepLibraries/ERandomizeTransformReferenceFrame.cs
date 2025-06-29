using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/DataprepLibraries.ERandomizeTransformReferenceFrame", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public enum ERandomizeTransformReferenceFrame : byte
{
	World,
	Relative
}
