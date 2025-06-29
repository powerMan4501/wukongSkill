using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EMIDCreationFlags", "Engine", UnrealModuleType.Engine)]
public enum EMIDCreationFlags : byte
{
	None,
	Transient
}
