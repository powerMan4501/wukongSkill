using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.EWASDType", "UnrealEd", UnrealModuleType.Engine)]
public enum EWASDType
{
	WASD_Always,
	WASD_RMBOnly,
	WASD_Never
}
