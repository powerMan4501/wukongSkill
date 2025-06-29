using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_LandingData : IBUC_LandingData
{
	public HashSet<FVector> LandingPoints { get; } = new HashSet<FVector>();
}
