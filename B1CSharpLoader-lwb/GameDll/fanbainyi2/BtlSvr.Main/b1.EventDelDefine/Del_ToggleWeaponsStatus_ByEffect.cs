using System.Collections.Generic;

namespace b1.EventDelDefine;

public delegate void Del_ToggleWeaponsStatus_ByEffect(List<int> WeaponIndexes, bool TriggerActivate, bool NeedOverride, int FlagID1, int FlagID2, bool Reset2Default);
