using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BIC_TeleportPointsData
{
	public Dictionary<FName, FTeleportInfo> TeleportPointsMap { get; } = new Dictionary<FName, FTeleportInfo>();
}
