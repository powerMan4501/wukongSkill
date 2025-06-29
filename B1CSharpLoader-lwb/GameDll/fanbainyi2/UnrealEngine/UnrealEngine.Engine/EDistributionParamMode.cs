using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.DistributionParamMode", "Engine", UnrealModuleType.Engine)]
public enum EDistributionParamMode
{
	DPM_Normal,
	DPM_Abs,
	DPM_Direct
}
