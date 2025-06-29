using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EBoneRotationSource", "Engine", UnrealModuleType.Engine)]
public enum EBoneRotationSource
{
	BRS_KeepComponentSpaceRotation,
	BRS_KeepLocalSpaceRotation,
	BRS_CopyFromTarget
}
