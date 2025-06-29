using OssB1;

namespace b1;

public interface IBUC_OSSCollectData
{
	int BeginFightTime { get; set; }

	BattlePlayer BattlePlayerData { get; set; }

	bool IsFight { get; set; }
}
