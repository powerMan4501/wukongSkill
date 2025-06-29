using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCGEditor;

[UEnum]
[UMetaPath("/Script/PCGEditor.EPCGElementType", "PCGEditor", UnrealModuleType.EnginePlugin)]
public enum EPCGElementType
{
	Native = 1,
	Blueprint = 2,
	Subgraph = 4,
	Settings = 8,
	Other = 16,
	All = 31
}
