using System.Collections.Generic;
using ArchiveB1;
using ResB1;

namespace b1;

public interface IBIC_BossRushData
{
	bool IsInBattleState { get; }

	int TargetLevelId { get; }

	int TargetId { get; }

	EBossRushType BossRushType { get; }

	int BossIterationsGroupId { get; }

	int BossIterationsIndex { get; }

	BossRushBattleData BossRushBattleData { get; }

	Dictionary<int, float> BossIterationsAttrCacheDict { get; }

	bool? bAllowAssociationUnit { get; }

	bool AllowAssociationUnit { get; }

	List<ItemOne> CostItemList { get; }

	float GetRemainTime();

	float GetLimitTime();
}
