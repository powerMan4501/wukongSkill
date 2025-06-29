using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGMetadataMakeVector4", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGMetadataMakeVector4
{
	FourValues,
	Vector2AndTwoValues,
	TwoVector2,
	Vector3AndValue
}
