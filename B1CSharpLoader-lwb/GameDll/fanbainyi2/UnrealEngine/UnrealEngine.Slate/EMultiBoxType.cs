using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Slate.EMultiBoxType", "Slate", UnrealModuleType.Engine)]
public enum EMultiBoxType : byte
{
	MenuBar,
	ToolBar,
	VerticalToolBar,
	SlimHorizontalToolBar,
	UniformToolBar,
	Menu,
	ButtonRow
}
