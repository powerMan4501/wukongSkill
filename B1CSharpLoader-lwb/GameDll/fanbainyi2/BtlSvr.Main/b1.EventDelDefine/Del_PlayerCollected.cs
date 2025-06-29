using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_PlayerCollected(AActor Player, int DropId, int DropLevel, AActor CollectedActor, OverrideDropTempleteInfoClass OverrideDropTempleteInfo = null);
