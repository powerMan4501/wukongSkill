using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_PerformCutDeath(ACharacter OriginalChar, float DelayClearArmorTime, float DelayDestroyActorTime, float StiffLevelCauseDead = 0f, FVector KillerLocation = default(FVector), bool UseBoomForce = false);
