using b1.ECS;

namespace b1.EventDelDefine;

public delegate void Del_BGS_TryStopBattleBGM(Entity RequestorEntity, EBGMStopCondition StopCondition = EBGMStopCondition.Default);
