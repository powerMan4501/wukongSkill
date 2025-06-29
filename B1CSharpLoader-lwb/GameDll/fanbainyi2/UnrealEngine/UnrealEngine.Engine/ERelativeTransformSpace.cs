using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ERelativeTransformSpace", "Engine", UnrealModuleType.Engine)]
public enum ERelativeTransformSpace
{
	RTS_World,
	RTS_Actor,
	RTS_Component,
	RTS_ParentBoneSpace
}
