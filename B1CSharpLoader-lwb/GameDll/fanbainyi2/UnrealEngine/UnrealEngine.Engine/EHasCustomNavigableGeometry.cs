using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EHasCustomNavigableGeometry", "Engine", UnrealModuleType.Engine)]
public enum EHasCustomNavigableGeometry
{
	No,
	Yes,
	EvenIfNotCollidable,
	DontExport
}
