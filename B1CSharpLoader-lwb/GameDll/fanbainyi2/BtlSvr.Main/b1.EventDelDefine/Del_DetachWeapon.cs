using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_DetachWeapon(int Index, EDetachmentRule LocationRule = EDetachmentRule.KeepWorld, EDetachmentRule RotationRule = EDetachmentRule.KeepWorld, EDetachmentRule ScaleRule = EDetachmentRule.KeepWorld, float WeaponDestroyDelayTime = 10f, bool WeaponEnablePhysic = true);
