using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataprepLibraries;

[UEnum]
[UMetaPath("/Script/DataprepLibraries.EDataprepHierarchySelectionPolicy", "DataprepLibraries", UnrealModuleType.EnginePlugin)]
public enum EDataprepHierarchySelectionPolicy
{
	ImmediateChildren,
	AllDescendants
}
