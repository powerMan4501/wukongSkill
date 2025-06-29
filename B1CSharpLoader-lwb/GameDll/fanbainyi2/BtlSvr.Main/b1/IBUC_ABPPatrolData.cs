using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public interface IBUC_ABPPatrolData
{
	List<UAnimSequence> AnimIdleList { get; }

	UBlendSpace BSWalkFwd { get; }

	UBlendSpace BSWalkBwd { get; }

	UBlendSpace BSWalkLeft { get; }

	UBlendSpace BSWalkRight { get; }

	UBlendSpace BSRunFwd { get; }

	UBlendSpace BSRunBwd { get; }

	UBlendSpace BSRunLeft { get; }

	UBlendSpace BSRunRight { get; }

	UBlendSpace DefaultBSRunFwd { get; }

	UBlendSpace DefaultBSRunBwd { get; }

	UBlendSpace DefaultBSRunLeft { get; }

	UBlendSpace DefaultBSRunRight { get; }

	UBlendSpace DefaultBSWalkFwd { get; }

	UBlendSpace DefaultBSWalkBwd { get; }

	UBlendSpace DefaultBSWalkLeft { get; }

	UBlendSpace DefaultBSWalkRight { get; }
}
