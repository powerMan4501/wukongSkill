using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.SequencePhase")]
public enum ESequencePhase : byte
{
	[UMeta(MD.Hidden)]
	None,
	[UMeta(MD.DisplayName, "播放开始后")]
	Started,
	[UMeta(MD.DisplayName, "播放结束后")]
	Finished
}
