using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.CameraType")]
public enum ECameraType : byte
{
	None,
	Normal,
	Cine,
	Rail,
	Crane
}
