using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ECustomDepthStencil", "Engine", UnrealModuleType.Engine)]
public enum ECustomDepthStencil
{
	Disabled,
	Enabled,
	EnabledOnDemand,
	EnabledWithStencil
}
