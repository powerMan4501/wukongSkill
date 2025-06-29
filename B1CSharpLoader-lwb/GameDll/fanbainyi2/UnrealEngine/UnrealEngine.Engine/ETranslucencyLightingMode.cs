using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETranslucencyLightingMode", "Engine", UnrealModuleType.Engine)]
public enum ETranslucencyLightingMode
{
	TLM_VolumetricNonDirectional,
	TLM_VolumetricDirectional,
	TLM_VolumetricPerVertexNonDirectional,
	TLM_VolumetricPerVertexDirectional,
	TLM_Surface,
	TLM_SurfacePerPixelLighting
}
