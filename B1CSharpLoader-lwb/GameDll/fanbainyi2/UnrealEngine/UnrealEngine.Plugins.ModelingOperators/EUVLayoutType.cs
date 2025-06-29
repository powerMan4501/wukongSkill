using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ModelingOperators;

[UEnum]
[UMetaPath("/Script/ModelingOperators.EUVLayoutType", "ModelingOperators", UnrealModuleType.EnginePlugin)]
public enum EUVLayoutType
{
	Transform,
	Stack,
	Repack
}
