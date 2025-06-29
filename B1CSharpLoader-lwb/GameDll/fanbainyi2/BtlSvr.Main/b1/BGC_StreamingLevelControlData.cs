using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_StreamingLevelControlData
{
	public FName CurrentLevelName { get; set; }

	public List<FBossRoom> BossRoomList { get; } = new List<FBossRoom>();
}
