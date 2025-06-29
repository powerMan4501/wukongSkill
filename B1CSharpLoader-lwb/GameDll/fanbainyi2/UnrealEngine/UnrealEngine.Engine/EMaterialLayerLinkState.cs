using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EMaterialLayerLinkState", "Engine", UnrealModuleType.Engine)]
public enum EMaterialLayerLinkState
{
	Uninitialized,
	LinkedToParent,
	UnlinkedFromParent,
	NotFromParent
}
