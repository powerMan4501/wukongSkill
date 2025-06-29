using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_OnReqLightningSpawnPos(List<FVector> TargetPoints, UMeshComponent AttachMeshComp = null, List<FName> SocketList = null);
