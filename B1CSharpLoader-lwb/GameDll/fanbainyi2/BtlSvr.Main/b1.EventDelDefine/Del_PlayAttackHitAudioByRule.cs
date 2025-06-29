using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_PlayAttackHitAudioByRule(AActor Attacker, int HitAudioID, EHitPerformAudioEventType HitPerformAudioEventType, FVector HitResultLocation, FRotator DirectionRotator, int CasterResID, int HitPartID);
