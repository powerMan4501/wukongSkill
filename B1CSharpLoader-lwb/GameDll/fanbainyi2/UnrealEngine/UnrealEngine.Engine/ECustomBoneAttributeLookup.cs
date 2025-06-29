using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECustomBoneAttributeLookup", "Engine", UnrealModuleType.Engine)]
public enum ECustomBoneAttributeLookup
{
	BoneOnly,
	ImmediateParent,
	ParentHierarchy
}
