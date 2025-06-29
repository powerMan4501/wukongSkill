namespace b1;

public interface IBGC_NeutralAnimalSpawnMgrData
{
	bool BPAnimalSpawnPause { get; }

	bool bLastBPAnimalSpawnReqSuccess { get; }

	int GetCurBPAnimalCount();

	int GetBPRemainSpawnSize();

	int GetCurAreaBPAnimalNum(string AreaGuid);
}
