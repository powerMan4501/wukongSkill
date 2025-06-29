using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialExposedViewProperty", "Engine", UnrealModuleType.Engine)]
public enum EMaterialExposedViewProperty
{
	MEVP_BufferSize,
	MEVP_FieldOfView,
	MEVP_TanHalfFieldOfView,
	MEVP_ViewSize,
	MEVP_WorldSpaceViewPosition,
	MEVP_WorldSpaceCameraPosition,
	MEVP_ViewportOffset,
	MEVP_TemporalSampleCount,
	MEVP_TemporalSampleIndex,
	MEVP_TemporalSampleOffset,
	MEVP_RuntimeVirtualTextureOutputLevel,
	MEVP_RuntimeVirtualTextureOutputDerivative,
	MEVP_PreExposure,
	MEVP_RuntimeVirtualTextureMaxLevel
}
