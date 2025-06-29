using UnrealEngine.AudioAnalyzer;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioSynesthesia;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AudioSynesthesia.AudioSynesthesiaSettings", "AudioSynesthesia", UnrealModuleType.EnginePlugin)]
public class UAudioSynesthesiaSettings : UAudioAnalyzerSettings
{
}
