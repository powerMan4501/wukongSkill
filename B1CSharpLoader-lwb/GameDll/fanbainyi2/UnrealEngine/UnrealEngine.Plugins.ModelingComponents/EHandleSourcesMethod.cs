using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingComponents;

[UEnum]
[UMetaPath("/Script/ModelingComponents.EHandleSourcesMethod", "ModelingComponents", UnrealModuleType.EnginePlugin)]
public enum EHandleSourcesMethod
{
	DeleteSources,
	HideSources,
	KeepSources,
	KeepFirstSource,
	KeepLastSource
}
