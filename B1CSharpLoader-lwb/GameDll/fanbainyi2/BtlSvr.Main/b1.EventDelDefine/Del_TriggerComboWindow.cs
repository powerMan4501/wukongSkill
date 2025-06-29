using System.Collections.Generic;

namespace b1.EventDelDefine;

public delegate void Del_TriggerComboWindow(int MontageInstanceID, uint NotifyUniqueID, int GroupID, List<int> BlackListComboSkillID, List<int> WhiteListComboSkillID, float TotalDuration);
