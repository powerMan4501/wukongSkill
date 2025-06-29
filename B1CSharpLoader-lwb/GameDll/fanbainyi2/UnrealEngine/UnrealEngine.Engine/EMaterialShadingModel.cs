using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialShadingModel", "Engine", UnrealModuleType.Engine)]
public enum EMaterialShadingModel
{
	MSM_Unlit,
	MSM_DefaultLit,
	MSM_Subsurface,
	MSM_PreintegratedSkin,
	MSM_ClearCoat,
	MSM_SubsurfaceProfile,
	MSM_TwoSidedFoliage,
	MSM_Hair,
	MSM_Cloth,
	MSM_Eye,
	MSM_SingleLayerWater,
	MSM_ThinTranslucent,
	MSM_Strata,
	MSM_NUM,
	MSM_FromMaterialExpression
}
