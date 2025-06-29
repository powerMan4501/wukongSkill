using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/AkAudio.PanningRule", "AkAudio", UnrealModuleType.GamePlugin)]
public enum EPanningRule : byte
{
	PanningRule_Speakers,
	PanningRule_Headphones
}
