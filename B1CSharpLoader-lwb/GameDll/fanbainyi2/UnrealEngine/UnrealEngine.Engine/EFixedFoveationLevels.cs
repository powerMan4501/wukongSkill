using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[UMetaPath("/Script/Engine.EFixedFoveationLevels", "Engine", UnrealModuleType.Engine)]
public enum EFixedFoveationLevels
{
	Disabled,
	Low,
	Medium,
	High,
	HighTop
}
