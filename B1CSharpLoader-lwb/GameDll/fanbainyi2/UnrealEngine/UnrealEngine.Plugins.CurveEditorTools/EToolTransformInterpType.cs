using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CurveEditorTools;

[UEnum]
[UMetaPath("/Script/CurveEditorTools.EToolTransformInterpType", "CurveEditorTools", UnrealModuleType.EnginePlugin)]
public enum EToolTransformInterpType
{
	Linear,
	Sinusoidal,
	Cubic,
	CircularIn,
	CircularOut,
	ExpIn,
	ExpOut
}
