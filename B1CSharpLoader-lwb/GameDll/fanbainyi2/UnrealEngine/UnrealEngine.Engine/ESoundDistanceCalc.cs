using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ESoundDistanceCalc", "Engine", UnrealModuleType.Engine)]
public enum ESoundDistanceCalc
{
	SOUNDDISTANCE_Normal,
	SOUNDDISTANCE_InfiniteXYPlane,
	SOUNDDISTANCE_InfiniteXZPlane,
	SOUNDDISTANCE_InfiniteYZPlane
}
