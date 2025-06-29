using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UMG.EUMGSequencePlayMode", "UMG", UnrealModuleType.Engine)]
public enum EUMGSequencePlayMode : byte
{
	Forward,
	Reverse,
	PingPong
}
