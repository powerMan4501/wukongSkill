using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_ActorChannelCleanUp(long ActorNetGUID, APlayerController PlayerController, EChannelCloseReason CloseReason);
