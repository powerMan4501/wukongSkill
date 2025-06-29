using UnrealEngine.Runtime;

namespace b1.UI.Comm;

[BlueprintType]
[UEnum]
[USharpPath("/Script/b1-Managed.InteractActionType")]
public enum EInteractActionType : byte
{
	[Tooltip("永远开启MouseEnterSetFocus")]
	Normal
}
