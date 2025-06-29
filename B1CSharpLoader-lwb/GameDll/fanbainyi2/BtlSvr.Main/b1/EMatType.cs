using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MatType")]
public enum EMatType : byte
{
	Scale,
	Vector,
	Texture
}
