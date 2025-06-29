using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.EToolMenuInsertType", "ToolMenus", UnrealModuleType.Engine)]
public enum EToolMenuInsertType : byte
{
	Default,
	Before,
	After,
	First
}
