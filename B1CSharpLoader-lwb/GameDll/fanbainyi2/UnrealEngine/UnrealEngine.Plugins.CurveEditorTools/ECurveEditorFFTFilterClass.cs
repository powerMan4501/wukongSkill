using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CurveEditorTools;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/CurveEditorTools.ECurveEditorFFTFilterClass", "CurveEditorTools", UnrealModuleType.EnginePlugin)]
public enum ECurveEditorFFTFilterClass : byte
{
	Butterworth,
	Chebyshev
}
