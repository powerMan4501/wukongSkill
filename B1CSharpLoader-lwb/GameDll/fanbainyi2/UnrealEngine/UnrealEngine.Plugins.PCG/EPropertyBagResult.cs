using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UEnum]
[UMetaPath("/Script/PCG.EPropertyBagResult", "PCG", UnrealModuleType.EnginePlugin)]
public enum EPropertyBagResult
{
	Success,
	TypeMismatch,
	OutOfBounds,
	PropertyNotFound
}
