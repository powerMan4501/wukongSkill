using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.GlideMoveAnimState")]
public enum EGlideMoveAnimState : byte
{
	None,
	GlideStart,
	GlideLoop,
	GlideEnd
}
