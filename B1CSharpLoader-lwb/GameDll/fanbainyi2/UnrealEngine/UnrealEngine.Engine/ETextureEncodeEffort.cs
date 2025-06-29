using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureEncodeEffort", "Engine", UnrealModuleType.Engine)]
public enum ETextureEncodeEffort
{
	Default = 0,
	Low = 10,
	Normal = 20,
	High = 30
}
