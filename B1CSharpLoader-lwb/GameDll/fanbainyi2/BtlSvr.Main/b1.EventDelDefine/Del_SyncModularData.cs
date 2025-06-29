using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_SyncModularData(List<AActor> ModularActors, bool bAutoAttachModularActors, bool bAutoSnapToGround, bool bDestroyAfterOwnerDeath, bool bNeedsCopyPose, Dictionary<FName, int> BreakDownProjectileMap);
