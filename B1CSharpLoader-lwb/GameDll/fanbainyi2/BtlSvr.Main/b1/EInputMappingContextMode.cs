using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.InputMappingContextMode")]
public enum EInputMappingContextMode : byte
{
	[DisplayName("只允许在UI模式下注册")]
	UIOnly,
	[DisplayName("只允许在Battle模式下注册")]
	GameOnly,
	[DisplayName("只允许UI和Battle模式下注册")]
	UIAndGame,
	[DisplayName("只允许Replay模式下注册")]
	Replay,
	[DisplayName("全模式下均允许注册")]
	All
}
