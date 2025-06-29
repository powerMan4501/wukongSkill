using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureUniversalTiling", "Engine", UnrealModuleType.Engine)]
public enum ETextureUniversalTiling
{
	Disabled,
	Enabled_256KB,
	Enabled_64KB
}
