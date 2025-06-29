using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_DetachSceneItemAndAttachByProjectileActor(BGUProjectileBaseActor NewBulletForAttach, float DelayEnableeCollisionTime, FVector FinalImpulse, AActor InnerSceneItem = null);
