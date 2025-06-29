using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETrailWidthMode", "Engine", UnrealModuleType.Engine)]
public enum ETrailWidthMode
{
	ETrailWidthMode_FromCentre,
	ETrailWidthMode_FromFirst,
	ETrailWidthMode_FromSecond
}
