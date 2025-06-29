using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EFXActorType")]
public enum EFXActorType : byte
{
	None,
	DestructibleObject,
	NonPreTracingDestructibleObject
}
