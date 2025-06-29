using UnrealEngine.Engine;

namespace b1;

public interface IBUC_ABPAimOffsetData
{
	float AOAlpha { get; }

	bool IsUseThisAlpha { get; }

	UAimOffsetBlendSpace DefaultAimOffset { get; }

	UAimOffsetBlendSpace AttackAimOffset { get; }
}
