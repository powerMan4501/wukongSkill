using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public interface IBIC_BossRushBattleData
{
	FTransform PlayerStartForSingle { get; }

	FTransform PlayerStartForGroup { get; }

	string TargetPersistentLevelName { get; }

	Dictionary<string, FBossRushTamerPropertyOverride> TamerPropertyOverrideList { get; }

	Dictionary<int, FBossRushServantPropertyOverride> ServantPropertyOverrideList { get; }

	FBossRushModifyTableCollection ModifyTableCollection { get; }

	float AdditionalHPMaxMul { get; }

	float AdditionalAtkMul { get; }

	FBossRoom BossRushRoom { get; }

	IDictionary<string, EBossRushLevelLoadState> GetFinalLevelLoadConfig();

	List<string> GetGraphManagedLevels();

	bool IsInSlowTime();
}
