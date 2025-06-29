using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EVirtualizationMode", "Engine", UnrealModuleType.Engine)]
public enum EVirtualizationMode : byte
{
	Disabled,
	PlayWhenSilent,
	Restart
}
