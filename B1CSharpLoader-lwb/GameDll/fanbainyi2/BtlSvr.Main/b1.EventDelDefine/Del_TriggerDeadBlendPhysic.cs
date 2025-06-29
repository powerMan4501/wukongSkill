using System.Collections.Generic;

namespace b1.EventDelDefine;

public delegate void Del_TriggerDeadBlendPhysic(List<FPhysicBlendInfoForDeath> PhysicBlendInfoList, float TotalTime, bool CallDissolveWhenPhysicsFinish, bool DirectlyTurnIntoRagdoll);
