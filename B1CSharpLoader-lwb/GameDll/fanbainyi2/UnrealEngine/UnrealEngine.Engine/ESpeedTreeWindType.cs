using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESpeedTreeWindType", "Engine", UnrealModuleType.Engine)]
public enum ESpeedTreeWindType
{
	STW_None,
	STW_Fastest,
	STW_Fast,
	STW_Better,
	STW_Best,
	STW_Palm,
	STW_BestPlus
}
