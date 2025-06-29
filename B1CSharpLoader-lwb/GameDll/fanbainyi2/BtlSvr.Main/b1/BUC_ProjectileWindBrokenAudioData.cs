using b1.ECS;
using b1.Plugins.AkAudio;

namespace b1;

public class BUC_ProjectileWindBrokenAudioData : IPersistentECSData
{
	public UAkAudioEvent AkEvent;

	public float TriggerDist;

	public bool bAlreadyTriggered;

	public bool bEnableDebug_WindBrokenAudio;

	public bool bAudioShutDown;

	public BUC_ProjectileWindBrokenAudioData()
	{
		AkEvent = null;
		TriggerDist = 0f;
		bAlreadyTriggered = false;
		bAudioShutDown = false;
	}
}
