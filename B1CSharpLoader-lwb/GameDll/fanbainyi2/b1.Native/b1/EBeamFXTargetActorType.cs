using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EBeamFXTargetActorType", "b1", UnrealModuleType.Game)]
public enum EBeamFXTargetActorType : byte
{
	Zero,
	Self,
	CameraLockActor
}
