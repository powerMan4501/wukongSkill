using System.Collections.Generic;

namespace b1;

public interface IBUC_RollData
{
	int DodgeStartSkillID { get; set; }

	int CurStateIndex { get; set; }

	List<int> RollCombo { get; }

	int RollComboLoopStartIdx { get; }

	bool bCastRollingSkill { get; set; }
}
