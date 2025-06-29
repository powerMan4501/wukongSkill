using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/DownloadTookit.EDownloadStatus", "DownloadTookit", UnrealModuleType.Game)]
public enum EDownloadStatus : byte
{
	NotStarted,
	Downloading,
	Paused,
	Canceled,
	Failed,
	Succeeded
}
