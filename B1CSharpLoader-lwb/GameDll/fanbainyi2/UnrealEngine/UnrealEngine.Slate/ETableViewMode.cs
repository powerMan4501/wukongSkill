using UnrealEngine.Runtime;

namespace UnrealEngine.Slate;

[UEnum]
[UMetaPath("/Script/Slate.ETableViewMode", "Slate", UnrealModuleType.Engine)]
public enum ETableViewMode
{
	List,
	Tile,
	Tree
}
