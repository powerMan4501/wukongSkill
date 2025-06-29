using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.EStrandsTexturesTraceType", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public enum EStrandsTexturesTraceType : byte
{
	TraceInside,
	TraceOuside,
	TraceBidirectional
}
