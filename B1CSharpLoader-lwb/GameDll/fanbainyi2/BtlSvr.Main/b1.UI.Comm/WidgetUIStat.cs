using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.WidgetUIStat")]
public enum WidgetUIStat : byte
{
	[DisplayName("None")]
	None,
	[DisplayName("Empty")]
	Empty,
	[DisplayName("NorReady")]
	NorReady,
	[DisplayName("NorInCD")]
	NorInCD,
	[DisplayName("LockReady")]
	LockReady,
	[DisplayName("LockInCD")]
	LockInCD,
	[DisplayName("Actived")]
	Actived
}
