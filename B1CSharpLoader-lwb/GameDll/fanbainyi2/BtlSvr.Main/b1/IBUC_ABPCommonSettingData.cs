using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public interface IBUC_ABPCommonSettingData
{
	EABPMoveMode FinalABPMoveMode { get; }

	UAnimSequence AnimIdle { get; }

	List<UAnimSequence> ExtendAnimIdleList { get; }

	UAnimSequence DefaultAnimIdle { get; }

	List<UAnimSequence> DefaultExtendAnimIdleList { get; }

	UBlendSpace BSStart { get; }

	UBlendSpace BSEnd { get; }

	UBlendSpace BSWalkFwd { get; }

	UBlendSpace BSWalkBwd { get; }

	UBlendSpace BSWalkLeft { get; }

	UBlendSpace BSWalkRight { get; }

	UBlendSpace BSRunFwd { get; }

	UBlendSpace BSRunBwd { get; }

	UBlendSpace BSRunLeft { get; }

	UBlendSpace BSRunRight { get; }

	UBlendSpace BSSprint { get; }

	bool bLockUseFreeMode { get; }

	float AnimTurnMinAngle { get; }

	UAnimSequence AnimTurnInPlaceLeft { get; }

	UAnimSequence AnimTurnInPlaceRight { get; }

	UAnimSequence AnimTurnInPlaceLeft180 { get; }

	UAnimSequence AnimTurnInPlaceRight180 { get; }

	bool bTurnAnimValid { get; }

	float CardinalDirectionBlendTime { get; }
}
