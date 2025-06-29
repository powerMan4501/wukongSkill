using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EBoneControlSpace", "Engine", UnrealModuleType.Engine)]
public enum EBoneControlSpace : byte
{
	BCS_WorldSpace,
	BCS_ComponentSpace,
	BCS_ParentBoneSpace,
	BCS_BoneSpace
}
