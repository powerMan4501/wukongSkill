using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BeginInteractSyncAnimation(AActor GuestActor, in FName AttachSocketOnHost, in FName AttachSocketOnDummyMesh, UAnimationAsset DummyMeshAnimation);
