using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureDownscaleOptions", "Engine", UnrealModuleType.Engine)]
public enum ETextureDownscaleOptions
{
	Default,
	Unfiltered,
	SimpleAverage,
	Sharpen0,
	Sharpen1,
	Sharpen2,
	Sharpen3,
	Sharpen4,
	Sharpen5,
	Sharpen6,
	Sharpen7,
	Sharpen8,
	Sharpen9,
	Sharpen10
}
