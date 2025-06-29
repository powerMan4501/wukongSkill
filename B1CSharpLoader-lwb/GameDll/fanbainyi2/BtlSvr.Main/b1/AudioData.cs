using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

public struct AudioData
{
	public UAkAudioEvent Sound;

	public FVector Location;

	public AudioData(UAkAudioEvent InSound, FVector InLocation)
	{
		Sound = InSound;
		Location = InLocation;
	}
}
