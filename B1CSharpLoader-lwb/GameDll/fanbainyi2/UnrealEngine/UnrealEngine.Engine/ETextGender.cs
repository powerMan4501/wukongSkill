using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ETextGender", "Engine", UnrealModuleType.Engine)]
public enum ETextGender : byte
{
	Masculine,
	Feminine,
	Neuter
}
