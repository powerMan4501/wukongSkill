using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMeshFeatureImportance", "Engine", UnrealModuleType.Engine)]
public enum EMeshFeatureImportance
{
	Off,
	Lowest,
	Low,
	Normal,
	High,
	Highest
}
