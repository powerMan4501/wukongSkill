using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UEnum]
[UMetaPath("/Script/AIModule.EEnvQueryTrace", "AIModule", UnrealModuleType.Engine)]
public enum EEnvQueryTrace
{
	None,
	Navigation,
	GeometryByChannel,
	GeometryByProfile,
	NavigationOverLedges
}
