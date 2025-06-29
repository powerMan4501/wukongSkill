using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECurveTableMode", "Engine", UnrealModuleType.Engine)]
public enum ECurveTableMode
{
	Empty,
	SimpleCurves,
	RichCurves
}
