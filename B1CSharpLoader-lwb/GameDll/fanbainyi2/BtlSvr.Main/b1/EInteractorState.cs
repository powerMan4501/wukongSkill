using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.InteractorState")]
public enum EInteractorState : byte
{
	[DisplayName("打开（可交互）")]
	Interactive,
	[DisplayName("关闭（不可交互）")]
	NotInteractive
}
