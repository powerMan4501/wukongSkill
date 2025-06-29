using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EChildActorComponentTreeViewVisualizationMode", "Engine", UnrealModuleType.Engine)]
public enum EChildActorComponentTreeViewVisualizationMode
{
	UseDefault,
	ComponentOnly,
	ComponentWithChildActor,
	ChildActorOnly
}
