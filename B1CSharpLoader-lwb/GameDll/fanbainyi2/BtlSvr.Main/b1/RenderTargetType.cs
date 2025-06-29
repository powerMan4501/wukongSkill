using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.RenderTargetType")]
public enum RenderTargetType : byte
{
	None,
	BeAttacked,
	TTTB,
	Shelter
}
