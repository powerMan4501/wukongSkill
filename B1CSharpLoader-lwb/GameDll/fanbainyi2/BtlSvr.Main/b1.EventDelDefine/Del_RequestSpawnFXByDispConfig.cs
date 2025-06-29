using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_RequestSpawnFXByDispConfig(string DispConfigDAPath, out int RequestID, USceneComponent EmitterDispOwnerComp = null, bool NeedSetSpawnTransform = false, FTransform SpawnTransform = default(FTransform));
