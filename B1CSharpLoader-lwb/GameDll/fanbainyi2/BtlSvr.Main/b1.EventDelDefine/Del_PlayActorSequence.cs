using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_PlayActorSequence(AActor MasterActor, ULevelSequence LevelSeq, FName Socket, bool AttachToSocket, bool bAttachToCapsuleRoot, bool bDontRotateWithMaster);
