using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_RequestSpawnFXByDispConfigDA(UBGWDataAsset DispConfig, out int RequestID, USceneComponent EmitterDispOwnerComp = null, bool NeedSetSpawnTransform = false, FTransform SpawnTransform = default(FTransform), DBCSetCallbackParams CallbackParams = default(DBCSetCallbackParams));
