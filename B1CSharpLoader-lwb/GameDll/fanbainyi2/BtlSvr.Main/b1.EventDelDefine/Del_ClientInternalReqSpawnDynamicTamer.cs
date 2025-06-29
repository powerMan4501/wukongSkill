using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate string Del_ClientInternalReqSpawnDynamicTamer(TSubclassOf<BUTamerActor> TamerClass, FTransform SpawnWorldTransform, FUnitSpawnInfo UnitSpawnInfo, AActor SpawnTrggerActor);
