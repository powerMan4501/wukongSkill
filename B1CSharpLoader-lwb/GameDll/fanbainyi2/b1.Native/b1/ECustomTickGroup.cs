using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/b1.ECustomTickGroup", "b1", UnrealModuleType.Game)]
public enum ECustomTickGroup : byte
{
	ECustomTickGroup_None = 0,
	PreAnimation = 101,
	BeforeStartPhsics = 111,
	BeforePostPhsics = 141,
	BeforePostUpdateWork = 151
}
