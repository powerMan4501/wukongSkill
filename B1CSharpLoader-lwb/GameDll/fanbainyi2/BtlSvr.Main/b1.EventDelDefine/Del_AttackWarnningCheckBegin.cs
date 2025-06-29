using System.Collections.Generic;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_AttackWarnningCheckBegin(int FromInstanceID, int AttackWarningGroupID, int NotifyID, int WeaponIndex, List<FUStCheckShape> AttackWarnningCheckShape, FVector FixedLocalOffset, ESweepCheckHitFilterType ResultFilterType, int HitLevel, EHitActionDir HitActionDir, float Duration, UAnimSequenceBase Animation, float NotifyBeginTime);
