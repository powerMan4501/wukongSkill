using System.Collections.Generic;

namespace b1;

public interface IBUC_FallingData
{
	float FallingTimer { get; }

	float FloorDistance { get; }

	float CanDodge_Distance { get; }

	bool EnableDodge_InFalling { get; }

	Dictionary<int, int> SkillInAirRecordList { get; }

	bool CanFallingAttack();
}
