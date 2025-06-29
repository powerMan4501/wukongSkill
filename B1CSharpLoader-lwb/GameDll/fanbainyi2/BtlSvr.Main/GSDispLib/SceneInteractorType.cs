using UnrealEngine.Runtime;

namespace GSDispLib;

[UEnum]
[USharpPath("/Script/b1-Managed.SceneInteractorType")]
public enum SceneInteractorType : byte
{
	NONE,
	HALF_CIRCLE,
	CIRCLE,
	MOVING_RECT
}
