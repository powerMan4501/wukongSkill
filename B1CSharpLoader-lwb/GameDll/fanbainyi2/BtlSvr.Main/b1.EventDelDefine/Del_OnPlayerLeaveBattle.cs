using OssB1;

namespace b1.EventDelDefine;

public delegate void Del_OnPlayerLeaveBattle(ulong RoleId, BattlePlayer Player, int LeaveFightTime, bool bIsTransUnit, bool bBecauseOfTrans);
