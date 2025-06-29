using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[UEnum]
[UMetaPath("/Script/AnimGraph.EAnimGraphAttributesDisplayMode", "AnimGraph", UnrealModuleType.Engine)]
public enum EAnimGraphAttributesDisplayMode
{
	HideOnPins,
	ShowOnPins,
	Automatic
}
