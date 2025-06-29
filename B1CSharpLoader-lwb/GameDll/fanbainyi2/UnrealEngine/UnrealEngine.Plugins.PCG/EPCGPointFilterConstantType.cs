using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPCGPointFilterConstantType", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGPointFilterConstantType
{
	Integer64,
	Float,
	Vector,
	Vector4,
	String,
	Unknown
}
