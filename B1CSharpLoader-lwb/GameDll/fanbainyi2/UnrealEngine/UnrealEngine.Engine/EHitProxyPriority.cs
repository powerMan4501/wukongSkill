using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EHitProxyPriority", "Engine", UnrealModuleType.Engine)]
public enum EHitProxyPriority
{
	HPP_World,
	HPP_Wireframe,
	HPP_Foreground,
	HPP_UI
}
