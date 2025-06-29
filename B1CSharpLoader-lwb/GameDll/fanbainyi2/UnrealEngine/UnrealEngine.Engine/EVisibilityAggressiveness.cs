using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EVisibilityAggressiveness", "Engine", UnrealModuleType.Engine)]
public enum EVisibilityAggressiveness
{
	VIS_LeastAggressive,
	VIS_ModeratelyAggressive,
	VIS_MostAggressive,
	VIS_Max
}
