using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EReverbSendMethod", "Engine", UnrealModuleType.Engine)]
public enum EReverbSendMethod : byte
{
	Linear,
	CustomCurve,
	Manual
}
