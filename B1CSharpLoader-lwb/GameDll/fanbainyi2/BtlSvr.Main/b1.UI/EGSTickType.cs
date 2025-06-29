using UnrealEngine.Runtime;

namespace b1.UI;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.EGSTickType")]
public enum EGSTickType : byte
{
	NotSet,
	NeverGSTick,
	AutoGSTick,
	AlwaysGSTick
}
