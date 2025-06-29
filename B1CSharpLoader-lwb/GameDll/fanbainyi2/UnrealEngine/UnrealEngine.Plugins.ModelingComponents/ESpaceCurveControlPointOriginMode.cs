using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[UEnum]
[UMetaPath("/Script/ModelingComponents.ESpaceCurveControlPointOriginMode", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public enum ESpaceCurveControlPointOriginMode
{
	Shared,
	First,
	Last
}
