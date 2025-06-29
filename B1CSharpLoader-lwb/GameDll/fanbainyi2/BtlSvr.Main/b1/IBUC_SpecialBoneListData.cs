using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public interface IBUC_SpecialBoneListData
{
	HashSet<FName> ExcludedBonesFromSweepCheck { get; }
}
