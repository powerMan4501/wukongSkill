using System.Collections.Generic;

namespace b1;

public class BUC_FXActorAudioData
{
	public UAkEventConfig LoopEvent { get; set; }

	public UAkEventConfig DestructibleEvent { get; set; }

	public List<UAkEventConfig> StopWhenDeadAkEvents { get; } = new List<UAkEventConfig>();

	public Dictionary<UAkEventConfig, float> StopByTimeAkEvents { get; } = new Dictionary<UAkEventConfig, float>();

	public List<UAkEventConfig> ExpireEvents { get; } = new List<UAkEventConfig>();
}
