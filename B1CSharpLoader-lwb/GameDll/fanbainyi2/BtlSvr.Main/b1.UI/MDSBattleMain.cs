using System;
using System.Collections.Generic;
using BtlB1;

namespace b1.UI;

public class MDSBattleMain
{
	public List<SpellType> ShortcutSpellList = new List<SpellType>();

	public Func<int, int> GetSpellIDBySkillID;

	public Func<bool> GetIsTrans;

	public Func<bool> GetIsActive;

	public Action<EnMainShowState> TriggerShowState;

	public Action<List<EnMainAreaType>> UpdateShowAreaList;

	public bool IsTrans => GetIsTrans();
}
