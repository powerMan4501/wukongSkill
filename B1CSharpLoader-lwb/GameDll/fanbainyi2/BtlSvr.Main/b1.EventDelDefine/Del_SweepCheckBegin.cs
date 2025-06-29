using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_SweepCheckBegin(int NotifyID, int WeaponIndex, List<FUStCheckShape> SweepCheckShape, List<int> EffectIDList, List<AbnormalStateAccConfig> AbnormalStateEffectList, List<int> EffectIDListForSceneItem, FHitDestructibleActorConfig HitDestructibleActorConfig, int HitChrAudioID, int HitChrFXWeight, FHitCheckConf HitCheckConf, bool CanHitBackBullet, float SweepCheckProtectTime, UAnimSequenceBase Animation, UAnimMontage AtkReboundingAM, UAnimMontage LowAtkRebounding, int SweepCheckGroupID, int FromInstanceID, List<FTriggerEffectWithCondition> EffectsWithCondition_Before, List<FTriggerEffectWithCondition> EffectsWithCondition_After, float NotifyBeginTime);
