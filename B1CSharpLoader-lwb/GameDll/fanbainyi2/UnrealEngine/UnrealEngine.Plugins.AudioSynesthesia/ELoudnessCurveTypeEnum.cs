using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AudioSynesthesia.ELoudnessCurveTypeEnum", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public enum ELoudnessCurveTypeEnum : byte
{
	A,
	B,
	C,
	D,
	None
}
