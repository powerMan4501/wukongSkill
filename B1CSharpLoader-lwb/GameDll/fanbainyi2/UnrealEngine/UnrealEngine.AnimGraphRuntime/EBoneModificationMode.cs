using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.EBoneModificationMode", "AnimGraphRuntime", UnrealModuleType.Engine)]
public enum EBoneModificationMode : byte
{
	BMM_Ignore,
	BMM_Replace,
	BMM_Additive
}
