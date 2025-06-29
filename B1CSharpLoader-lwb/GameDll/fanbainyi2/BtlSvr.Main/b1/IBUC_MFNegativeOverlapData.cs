using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public interface IBUC_MFNegativeOverlapData
{
	HashSet<AActor> InnerActors { get; }
}
