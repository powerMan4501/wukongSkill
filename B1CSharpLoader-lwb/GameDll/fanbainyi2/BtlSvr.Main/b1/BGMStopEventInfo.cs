using b1.Plugins.AkAudio;

namespace b1;

public class BGMStopEventInfo
{
	public UAkAudioEvent StopEvent;

	public BGMStopEventInfo(UAkAudioEvent _StopEvent)
	{
		StopEvent = _StopEvent;
	}
}
