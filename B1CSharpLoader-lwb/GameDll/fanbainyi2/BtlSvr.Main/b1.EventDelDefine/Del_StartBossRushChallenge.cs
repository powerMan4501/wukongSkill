using System.Collections.Generic;
using ArchiveB1;
using ResB1;

namespace b1.EventDelDefine;

public delegate void Del_StartBossRushChallenge(EBossRushType BossRushType, EReChallengeLevel ReChallengeLevel, List<int> DebuffList, int TargetId, int Index, bool AllowAssociationUnit);
