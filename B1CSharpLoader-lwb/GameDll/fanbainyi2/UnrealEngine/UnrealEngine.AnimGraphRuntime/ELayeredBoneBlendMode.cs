using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[UMetaPath("/Script/AnimGraphRuntime.ELayeredBoneBlendMode", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum ELayeredBoneBlendMode
{
	BranchFilter,
	BlendMask
}
