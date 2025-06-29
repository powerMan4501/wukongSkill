using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EAudioSpectrumType", "Engine", UnrealModuleType.Engine)]
public enum EAudioSpectrumType : byte
{
	MagnitudeSpectrum,
	PowerSpectrum,
	Decibel
}
