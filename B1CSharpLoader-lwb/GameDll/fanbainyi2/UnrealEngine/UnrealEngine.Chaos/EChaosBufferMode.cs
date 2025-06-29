using UnrealEngine.Runtime;

namespace UnrealEngine.Chaos;

[UEnum]
[UMetaPath("/Script/Chaos.EChaosBufferMode", "Chaos", UnrealModuleType.Engine)]
public enum EChaosBufferMode
{
	Double,
	Triple,
	Num,
	Invalid
}
