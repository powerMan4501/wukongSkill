using System.Collections.Generic;

namespace b1;

public class BGC_DSDebugData : IBGC_DSDebugData
{
	public bool PlayerLogin { get; set; }

	public float KillDelayTime { get; set; }

	public int KillCount { get; set; }

	public bool DebugFinish { get; set; }

	public Dictionary<int, int> ItemDict { get; set; } = new Dictionary<int, int>();

	public int FrameDelay { get; set; }

	public int GCTestTime { get; set; }
}
