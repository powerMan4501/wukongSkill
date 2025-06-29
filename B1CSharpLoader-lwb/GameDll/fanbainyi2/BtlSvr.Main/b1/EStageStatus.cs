using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.StageStatus")]
public enum EStageStatus : byte
{
	[UMeta(MD.Hidden)]
	Default,
	[UMeta(MD.DisplayName, "激活")]
	Activated,
	[UMeta(MD.DisplayName, "完成")]
	Finished
}
