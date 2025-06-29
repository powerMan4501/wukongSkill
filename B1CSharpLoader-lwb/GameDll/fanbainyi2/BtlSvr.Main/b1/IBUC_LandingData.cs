using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_LandingData
{
	HashSet<FVector> LandingPoints { get; }
}
