using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_OnTeleport(AActor Querier, int TeleportType, int TeleportIntParam, string TeleportStrParam, string ActorSocketName, bool SelectRandom, float MinDistInRandom, bool IsKeepFacingCurTarget, int SelectType, bool bFindFloor);
