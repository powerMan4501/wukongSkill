using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ESourceBusSendLevelControlMethod", "Engine", UnrealModuleType.Engine)]
public enum ESourceBusSendLevelControlMethod : byte
{
	Linear,
	CustomCurve,
	Manual
}
