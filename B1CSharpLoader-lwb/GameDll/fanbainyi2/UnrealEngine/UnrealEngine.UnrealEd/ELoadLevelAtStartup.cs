using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[UMetaPath("/Script/UnrealEd.ELoadLevelAtStartup", "UnrealEd", UnrealModuleType.Engine)]
public enum ELoadLevelAtStartup
{
	None,
	ProjectDefault,
	LastOpened
}
