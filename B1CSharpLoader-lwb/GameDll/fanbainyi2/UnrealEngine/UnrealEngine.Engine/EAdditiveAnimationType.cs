using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAdditiveAnimationType", "Engine", UnrealModuleType.Engine)]
public enum EAdditiveAnimationType
{
	AAT_None,
	AAT_LocalSpaceBase,
	AAT_RotationOffsetMeshSpace
}
