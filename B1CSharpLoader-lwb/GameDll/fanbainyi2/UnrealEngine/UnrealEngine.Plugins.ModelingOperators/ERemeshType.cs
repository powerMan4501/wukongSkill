using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.ERemeshType", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum ERemeshType
{
	Standard,
	FullPass,
	NormalFlow
}
