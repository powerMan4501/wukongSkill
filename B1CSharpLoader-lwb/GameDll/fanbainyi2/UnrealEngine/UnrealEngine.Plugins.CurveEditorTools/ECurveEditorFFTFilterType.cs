using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.CurveEditorTools;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/CurveEditorTools.ECurveEditorFFTFilterType", "CurveEditorTools", UnrealModuleType.EnginePlugin)]
public enum ECurveEditorFFTFilterType : byte
{
	Lowpass,
	Highpass
}
