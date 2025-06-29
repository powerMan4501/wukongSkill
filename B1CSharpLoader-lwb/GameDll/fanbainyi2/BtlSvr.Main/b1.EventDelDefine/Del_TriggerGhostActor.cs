using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_TriggerGhostActor(ACharacter PoseableChr, BGWDataAsset_GhostActorSetting GhostConfigDataAsset, FEffectInstReq EffectInstReq = default(FEffectInstReq), UAnimMontage MontageToMapTo = null);
