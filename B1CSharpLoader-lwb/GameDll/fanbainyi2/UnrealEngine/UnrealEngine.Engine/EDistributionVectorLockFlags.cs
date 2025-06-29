using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EDistributionVectorLockFlags", "Engine", UnrealModuleType.Engine)]
public enum EDistributionVectorLockFlags
{
	EDVLF_None,
	EDVLF_XY,
	EDVLF_XZ,
	EDVLF_YZ,
	EDVLF_XYZ
}
