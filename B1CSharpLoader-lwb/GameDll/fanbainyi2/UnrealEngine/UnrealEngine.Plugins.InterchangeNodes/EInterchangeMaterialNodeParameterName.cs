using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.InterchangeNodes;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/InterchangeNodes.EInterchangeMaterialNodeParameterName", "InterchangeNodes", UnrealModuleType.EnginePlugin)]
public enum EInterchangeMaterialNodeParameterName : byte
{
	BaseColor,
	EmissiveColor,
	Specular,
	Roughness,
	Metallic,
	Normal,
	Opacity,
	OpacityMask
}
