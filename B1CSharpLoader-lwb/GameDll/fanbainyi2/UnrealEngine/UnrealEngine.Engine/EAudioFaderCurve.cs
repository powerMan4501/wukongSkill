using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAudioFaderCurve", "Engine", UnrealModuleType.Engine)]
public enum EAudioFaderCurve : byte
{
	Linear,
	Logarithmic,
	SCurve,
	Sin,
	Count
}
