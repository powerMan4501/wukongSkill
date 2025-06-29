using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_SetAttackIKTargetActor(AActor CharacterCS, bool enableAttackPlaneIK, EAttackIKType attackIKType, TArrayReadWrite<FAttackIKBonePairs> attackIKBonePairList);
