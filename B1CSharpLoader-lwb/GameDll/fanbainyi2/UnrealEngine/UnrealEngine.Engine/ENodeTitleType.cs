using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ENodeTitleType", "Engine", UnrealModuleType.Engine)]
public enum ENodeTitleType
{
	FullTitle,
	ListView,
	EditableTitle,
	MenuTitle,
	MAX_TitleTypes
}
