using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EInterpToBehaviourType", "Engine", UnrealModuleType.Engine)]
public enum EInterpToBehaviourType : byte
{
	OneShot,
	OneShot_Reverse,
	Loop_Reset,
	PingPong
}
