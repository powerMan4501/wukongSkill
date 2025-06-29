using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.LevelLoadState")]
public enum ELevelLoadState : byte
{
	[UMeta(MD.DisplayName, "自动")]
	Auto,
	[UMeta(MD.DisplayName, "加载")]
	Load,
	[UMeta(MD.DisplayName, "不加载")]
	Unload
}
