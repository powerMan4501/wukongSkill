using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

public static class UAkGameplayStatics_CsExtensions
{
	public static void StopAllAmbientSounds(this UWorld WorldContextObject)
	{
		UAkGameplayStatics.StopAllAmbientSounds(WorldContextObject);
	}

	public static void StartAllAmbientSounds(this UWorld WorldContextObject)
	{
		UAkGameplayStatics.StartAllAmbientSounds(WorldContextObject);
	}

	public static UAkComponent SpawnAkComponentAtLocation(this UWorld WorldContextObject, UAkAudioEvent AkEvent, FVector Location, FRotator Orientation, bool AutoPost, string EventName, bool AutoDestroy = true)
	{
		return UAkGameplayStatics.SpawnAkComponentAtLocation(WorldContextObject, AkEvent, Location, Orientation, AutoPost, EventName, AutoDestroy);
	}

	public static void SetCurrentAudioCulture(this UWorld WorldContextObject, string AudioCulture, FLatentActionInfo LatentInfo)
	{
		UAkGameplayStatics.SetCurrentAudioCulture(AudioCulture, LatentInfo, WorldContextObject);
	}

	public static int PostEventAtLocation(this UWorld WorldContextObject, UAkAudioEvent AkEvent, FVector Location, FRotator Orientation, string EventName)
	{
		return UAkGameplayStatics.PostEventAtLocation(AkEvent, Location, Orientation, EventName, WorldContextObject);
	}
}
