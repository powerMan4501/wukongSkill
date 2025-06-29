using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESceneDepthPriorityGroup", "Engine", UnrealModuleType.Engine)]
public enum ESceneDepthPriorityGroup
{
	SDPG_World,
	SDPG_Foreground
}
