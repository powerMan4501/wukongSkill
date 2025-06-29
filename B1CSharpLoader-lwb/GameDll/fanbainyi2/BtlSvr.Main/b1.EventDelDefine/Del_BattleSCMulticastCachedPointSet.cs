using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BattleSCMulticastCachedPointSet(string BattleSCGUID, AActor Sender, int RegisterID, List<FVector> PointSet);
