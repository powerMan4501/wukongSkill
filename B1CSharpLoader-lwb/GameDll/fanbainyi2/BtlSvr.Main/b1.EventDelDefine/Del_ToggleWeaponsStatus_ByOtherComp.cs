using System.Collections.Generic;

namespace b1.EventDelDefine;

public delegate void Del_ToggleWeaponsStatus_ByOtherComp(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, EToggleWeaponStatusCompType CompType);
