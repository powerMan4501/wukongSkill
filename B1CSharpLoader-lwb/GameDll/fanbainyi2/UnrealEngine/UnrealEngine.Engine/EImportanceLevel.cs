using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EImportanceLevel", "Engine", UnrealModuleType.Engine)]
public enum EImportanceLevel
{
	IL_Off,
	IL_Lowest,
	IL_Low,
	IL_Normal,
	IL_High,
	IL_Highest,
	TEMP_BROKEN2
}
