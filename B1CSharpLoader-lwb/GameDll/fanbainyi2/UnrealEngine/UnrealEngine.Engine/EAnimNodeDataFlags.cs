using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EAnimNodeDataFlags", "Engine", UnrealModuleType.Engine)]
public enum EAnimNodeDataFlags
{
	None = 0,
	HasInitialUpdateFunction = 1,
	HasBecomeRelevantFunction = 2,
	HasUpdateFunction = 4
}
