using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_BuffAdd(int BuffID, AActor Caster, AActor RootCaster, float Duration, EBuffSourceType BuffSourceType = EBuffSourceType.Default, bool bRecursed = false, FBattleAttrSnapShot BattleAttrSnapShot = default(FBattleAttrSnapShot));
