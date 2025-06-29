using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/PCG.EPCGExclusiveDataType", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPCGExclusiveDataType : byte
{
	None,
	Point,
	Spline,
	LandscapeSpline,
	PolyLine,
	Landscape,
	Texture,
	RenderTarget,
	BaseTexture,
	Surface,
	Volume,
	Primitive,
	Concrete,
	Composite,
	Spatial,
	Param,
	Settings,
	Other,
	Any
}
