using System.Collections.Generic;

namespace b1;

public interface IBGC_LevelBattleData
{
	Dictionary<string, int> OnlineItemTempList { get; }

	int GetGamePlayerNum();

	int GetGameDifficultBuffId();
}
