using UnrealEngine.Runtime;

namespace UnrealEngine.InteractiveToolsFramework;

[UEnum]
[UMetaPath("/Script/InteractiveToolsFramework.EToolChangeTrackingMode", "InteractiveToolsFramework", UnrealModuleType.Engine)]
public enum EToolChangeTrackingMode
{
	NoChangeTracking = 1,
	UndoToExit,
	FullUndoRedo
}
