using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.ETextureEncodeSpeed", "Engine", UnrealModuleType.Engine)]
public enum ETextureEncodeSpeed
{
	Final,
	FinalIfAvailable,
	Fast
}
