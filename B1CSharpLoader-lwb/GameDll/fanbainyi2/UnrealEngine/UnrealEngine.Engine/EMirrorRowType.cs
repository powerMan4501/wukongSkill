using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMirrorRowType", "Engine", UnrealModuleType.Engine)]
public enum EMirrorRowType
{
	Bone,
	AnimationNotify,
	Curve,
	SyncMarker,
	Custom
}
