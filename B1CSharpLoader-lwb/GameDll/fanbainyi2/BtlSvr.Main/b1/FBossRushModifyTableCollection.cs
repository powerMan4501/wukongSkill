using System.Collections.Generic;

namespace b1;

public class FBossRushModifyTableCollection
{
	public Dictionary<int, float> ModifyDeadDelayDestroyTime { get; } = new Dictionary<int, float>();

	public void Clean()
	{
		ModifyDeadDelayDestroyTime.Clear();
	}
}
