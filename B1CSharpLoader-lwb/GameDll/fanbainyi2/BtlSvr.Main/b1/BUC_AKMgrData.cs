using System.Collections.Generic;
using b1.ECS;
using b1.Plugins.AkAudio;

namespace b1;

public class BUC_AKMgrData : b1.IBUC_AkMgrData, IPersistentECSData
{
	public bool bIsPlayingSubtitle;

	public Dictionary<int, float> AudioLength = new Dictionary<int, float>();

	public Dictionary<int, List<float>> SubtitleStamp = new Dictionary<int, List<float>>();

	public bool InAkPause { get; set; }

	public int LastPlayingID { get; set; }

	public UAkComponent LastFollowAkComp { get; set; }

	public Dictionary<int, List<AkUnitInfo>> AkMap { get; } = new Dictionary<int, List<AkUnitInfo>>();

	public UAkEventConfig LoopEvent { get; set; }

	public UAkEventConfig DeadEvent { get; set; }

	public List<UAkEventConfig> StopWhenDeadAkEvents { get; } = new List<UAkEventConfig>();

	public Dictionary<UAkEventConfig, float> StopByTimeAkEvents { get; } = new Dictionary<UAkEventConfig, float>();

	public List<UAkEventConfig> ExpireEvents { get; } = new List<UAkEventConfig>();

	public Dictionary<UAkComponent, int> AutoDestroyCompMap { get; } = new Dictionary<UAkComponent, int>();
}
