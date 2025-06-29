using UnrealEngine.Runtime;

namespace UnrealEngine.ComponentVisualizers;

[UEnum]
[UMetaPath("/Script/ComponentVisualizers.ESelectedTangentHandle", "ComponentVisualizers", UnrealModuleType.Engine)]
public enum ESelectedTangentHandle
{
	None,
	Leave,
	Arrive
}
