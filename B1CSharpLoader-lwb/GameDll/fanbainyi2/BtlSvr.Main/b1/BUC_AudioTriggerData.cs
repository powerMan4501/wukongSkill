using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
internal class BUC_AudioTriggerData
{
	public float Timer;

	public int NextAudioIdx;

	public bool bEnableNextAudio;

	public FOnAkPostEventCallback PostEventCallback;
}
