using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngine;

[UEnum]
[UMetaPath("/Script/HoudiniEngine.EHoudiniSessionStatus", "HoudiniEngine", UnrealModuleType.GamePlugin)]
public enum EHoudiniSessionStatus
{
	Invalid = -1,
	NotStarted,
	Connected,
	None,
	Stopped,
	Failed,
	Lost,
	NoLicense
}
