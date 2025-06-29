using UnrealEngine.Runtime;

namespace UnrealEngine.ComponentVisualizers;

[UEnum]
[UMetaPath("/Script/ComponentVisualizers.EShapeAddMode", "ComponentVisualizers", UnrealModuleType.Engine)]
public enum EShapeAddMode
{
	AppendAfter = 1,
	AppendBefore = 2,
	InsertAfter = 4,
	InsertBefore = 8
}
