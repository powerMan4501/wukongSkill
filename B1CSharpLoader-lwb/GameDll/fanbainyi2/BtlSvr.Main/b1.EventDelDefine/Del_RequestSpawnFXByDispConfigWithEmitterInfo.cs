using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_RequestSpawnFXByDispConfigWithEmitterInfo(string DispConfigDAPath, out int RequestID, USceneComponent EmitterDispOwnerComp, FVector EmitterPosWSOnSpawn);
