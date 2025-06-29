using System.Collections.Generic;
using b1.Plugins.AkAudio;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ProjectileAudioData
{
	public TStrongObjectPtr<UAkComponent> AkComp { get; set; }

	public UAkEventConfig LoopEvent { get; set; }

	public UAkEventConfig DeadEvent { get; set; }

	public List<UAkEventConfig> StopWhenDeadAkEvents { get; } = new List<UAkEventConfig>();

	public Dictionary<UAkEventConfig, float> StopByTimeAkEvents { get; } = new Dictionary<UAkEventConfig, float>();

	public List<UAkEventConfig> ExpireEvents { get; } = new List<UAkEventConfig>();

	public BUC_ProjectileAudioData()
	{
		AkComp = new TStrongObjectPtr<UAkComponent>();
	}
}
