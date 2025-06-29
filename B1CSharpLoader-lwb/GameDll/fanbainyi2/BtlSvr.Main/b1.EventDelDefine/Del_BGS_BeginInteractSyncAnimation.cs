using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BGS_BeginInteractSyncAnimation(AActor Host, AActor Guest, in FName AttachSocketOnHost, in FName AttachSocketOnDummyMesh, UAnimationAsset DummyMeshAnimation);
