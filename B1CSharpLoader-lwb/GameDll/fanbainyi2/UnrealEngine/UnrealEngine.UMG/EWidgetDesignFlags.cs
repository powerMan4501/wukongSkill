using UnrealEngine.Runtime;

namespace UnrealEngine.UMG;

[UEnum]
[UMetaPath("/Script/UMG.EWidgetDesignFlags", "UMG", UnrealModuleType.Engine)]
public enum EWidgetDesignFlags
{
	None = 0,
	Designing = 1,
	ShowOutline = 2,
	ExecutePreConstruct = 4
}
