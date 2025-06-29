using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UEnum]
[UMetaPath("/Script/HoudiniEngineRuntime.EHoudiniEngineBakeOption", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public enum EHoudiniEngineBakeOption
{
	ToActor,
	ToBlueprint,
	ToFoliage,
	ToWorldOutliner
}
