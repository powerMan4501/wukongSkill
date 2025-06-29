using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[UMetaPath("/Script/b1.ESortType", "b1", UnrealModuleType.Game)]
public enum ESortType
{
	None,
	Big_to_small,
	Small_to_big
}
