using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EStrataShadingModel", "Engine", UnrealModuleType.Engine)]
public enum EStrataShadingModel
{
	SSM_Unlit,
	SSM_DefaultLit,
	SSM_SubsurfaceLit,
	SSM_VolumetricFogCloud,
	SSM_Hair,
	SSM_SingleLayerWater,
	SSM_NUM
}
