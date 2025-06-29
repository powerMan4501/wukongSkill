using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ENaturalSoundFalloffMode", "Engine", UnrealModuleType.Engine)]
public enum ENaturalSoundFalloffMode : byte
{
	Continues,
	Silent,
	Hold
}
