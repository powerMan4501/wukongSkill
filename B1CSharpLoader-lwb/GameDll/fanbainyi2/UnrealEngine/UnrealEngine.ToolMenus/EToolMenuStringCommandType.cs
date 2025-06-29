using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.EToolMenuStringCommandType", "ToolMenus", UnrealModuleType.Engine)]
public enum EToolMenuStringCommandType : byte
{
	Command,
	Python,
	Custom
}
