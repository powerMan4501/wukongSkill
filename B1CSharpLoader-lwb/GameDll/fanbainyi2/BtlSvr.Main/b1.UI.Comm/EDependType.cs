using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.DependType")]
public enum EDependType : byte
{
	[DisplayName("自动")]
	Auto,
	[DisplayName("上下")]
	UpDown
}
