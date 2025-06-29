using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.ECameraBlendType", "b1", UnrealModuleType.Game)]
public enum ECameraBlendType : byte
{
	None,
	BlendBySpeed,
	BlendByTime
}
