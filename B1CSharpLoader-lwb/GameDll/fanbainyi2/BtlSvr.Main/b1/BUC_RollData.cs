using System.Collections.Generic;

namespace b1;

public class BUC_RollData : IBUC_RollData
{
	public int DodgeStartSkillID { get; set; }

	public int CurStateIndex { get; set; }

	public List<int> RollCombo { get; } = new List<int>();

	public int RollComboLoopStartIdx { get; set; }

	public bool bCastRollingSkill { get; set; }

	public BUC_RollData()
	{
		DodgeStartSkillID = 0;
		CurStateIndex = 0;
		RollComboLoopStartIdx = -1;
	}
}
