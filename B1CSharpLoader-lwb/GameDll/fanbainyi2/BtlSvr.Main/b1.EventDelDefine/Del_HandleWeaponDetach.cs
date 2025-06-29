using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_HandleWeaponDetach(EDetachmentRule LocationRule, EDetachmentRule RotationRule, EDetachmentRule ScaleRule, float DestroyDelayTime, bool WeaponEnablePhysic);
