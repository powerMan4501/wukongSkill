using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.EStartGameInstanceTypeForCS", "b1", UnrealModuleType.Game)]
public enum EStartGameInstanceTypeForCS : byte
{
	StartCS_UnKnow,
	StartCS_StandAlone,
	StartCS_DedicateServer,
	StartCS_PIE_Standalone,
	StartCS_PIE_ListenServer,
	StartCS_PIE_Client,
	StartCS_PIE_DedicateServer
}
