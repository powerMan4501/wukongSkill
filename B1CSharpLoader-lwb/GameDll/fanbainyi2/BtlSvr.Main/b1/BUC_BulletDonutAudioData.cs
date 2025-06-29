using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_BulletDonutAudioData
{
	public UAkAudioEvent DonutAudio { get; set; }

	public EDonutBulletAudioLocationType DonutAudioLocationType { get; set; }

	public EAkEventStopMode StopMode { get; set; }

	public int StopTimeMs { get; set; }

	public int FadeOutTimeMs { get; set; }

	public EAkCurveInterpolationCS CurveInterpolation { get; set; }

	public float RemainPlayingTime { get; set; }

	public int NearestPlayingID { get; set; }

	public int FarthestPlayingID { get; set; }

	public TWeakObject<UAkComponent> NearestAkCompPtr { get; set; }

	public TWeakObject<UAkComponent> FarthestAkCompPtr { get; set; }
}
