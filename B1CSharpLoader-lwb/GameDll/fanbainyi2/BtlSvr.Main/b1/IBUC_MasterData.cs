using UnrealEngine.Engine;

namespace b1;

public interface IBUC_MasterData
{
	AActor GetMasterActor();

	IBGUActorI GetMaster();

	bool IsMasterHiddenInGame();

	int GetMasterResID();

	int GetMasterBattleInfoID();
}
