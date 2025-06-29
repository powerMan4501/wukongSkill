using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BattleSCReceiveMessage(string BattleSCGUID, AActor Sender, FGameplayTag Message, EDistributionType DistributionType);
