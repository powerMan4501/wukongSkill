using UnrealEngine.Runtime;

namespace b1.AutoQA;

[UEnum]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GetTamerMethod")]
public enum GetTamerMethod : byte
{
	[DisplayName("使用DA来制定一个TamerList")]
	Use_DA,
	[DisplayName("单独指定仅一个Tamer")]
	Use_SingleMonster
}
