using System.Collections.Generic;

namespace b1.EventDelDefine;

public delegate void Del_ToggleWeaponsStatus_ByNotifyState(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, int MontageInstanceID, int NotifyUniqueID);
