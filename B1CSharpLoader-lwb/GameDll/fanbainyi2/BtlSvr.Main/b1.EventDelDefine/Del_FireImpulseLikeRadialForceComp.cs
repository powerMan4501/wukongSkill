using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_FireImpulseLikeRadialForceComp(AActor OwnerActor, EPhysicsForceType PhysicsForceType, float ForceFieldSize, FVector ForceFieldOffset, float DestructibleDamage, float ImpulseStrength, List<EObjectTypeQuery> QueryObjectTypes, float forceDuration, bool IsDrawDebugShape = false);
