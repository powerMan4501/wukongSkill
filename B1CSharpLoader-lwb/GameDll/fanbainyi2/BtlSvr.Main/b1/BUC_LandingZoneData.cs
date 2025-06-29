using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_LandingZoneData
{
	public List<FVector> LandingPoints { get; } = new List<FVector>();

	public bool bEnableDebug { get; set; }
}
