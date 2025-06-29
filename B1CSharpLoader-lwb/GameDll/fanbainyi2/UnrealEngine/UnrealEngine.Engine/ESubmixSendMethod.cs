using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.ESubmixSendMethod", "Engine", UnrealModuleType.Engine)]
public enum ESubmixSendMethod : byte
{
	Linear,
	CustomCurve,
	Manual
}
