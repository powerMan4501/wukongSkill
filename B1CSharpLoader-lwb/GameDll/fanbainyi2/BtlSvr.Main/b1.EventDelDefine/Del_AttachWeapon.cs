using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_AttachWeapon(AActor Weapon, int Index, FName SocketName, EAttachmentRule LocationRule = EAttachmentRule.SnapToTarget, EAttachmentRule RotationRule = EAttachmentRule.SnapToTarget, EAttachmentRule ScaleRule = EAttachmentRule.KeepRelative);
