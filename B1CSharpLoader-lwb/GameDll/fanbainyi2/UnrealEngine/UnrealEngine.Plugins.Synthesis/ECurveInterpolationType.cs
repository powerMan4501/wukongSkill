using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Synthesis.CurveInterpolationType", "Synthesis", UnrealModuleType.EnginePlugin)]
public enum ECurveInterpolationType : byte
{
	AUTOINTERP,
	LINEAR,
	CONSTANT
}
