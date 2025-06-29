using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[UMetaPath("/Script/b1.EBGU_PathFindingResult", "b1", UnrealModuleType.Game)]
public enum EBGU_PathFindingResult
{
	FirstFindingSuccess,
	SecondFindingSussess,
	Fail
}
