using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_QuerySpawnClass(List<EMobAttackType> AttackTypes, in int WaveIndex, in int MinNum, in int MaxNum, FVector SpawnerLoc, out Dictionary<TSubclassOf<BGUCharacterCS>, int> OutSpawnClassNum);
