using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[UEnum]
[UMetaPath("/Script/Niagara.ENiagaraBakerViewMode", "Niagara", UnrealModuleType.EnginePlugin)]
public enum ENiagaraBakerViewMode
{
	Perspective,
	OrthoFront,
	OrthoBack,
	OrthoLeft,
	OrthoRight,
	OrthoTop,
	OrthoBottom,
	Num
}
