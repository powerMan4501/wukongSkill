using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[UMetaPath("/Script/b1.EBUTargetFilter", "b1", UnrealModuleType.Game)]
public enum EBUTargetFilter
{
	Default = 0,
	MySelf = 1,
	TeamMate = 2,
	Enemy = 4
}
