using System.Collections.Generic;

namespace b1;

public interface IBGC_TamerData
{
	bool TryGetTamerEntityRef(string UnitGuid, out FTamerRef OutTamerRef);

	bool GetTamerType(string UnitGuid, out ETamerType OutTamerType);

	bool IsUnitSpawnFinished(string UnitGuid);

	bool GetAllMonsterGuidByResID(int InResId, out List<string> OutResult);

	bool GetAllMonsterGuidByGroupGuid(string GroupGuid, out Dictionary<string, FTamerRef> OutResult);

	void GetSpawnedMonsterList(out List<string> OutMonsterList);

	bool GetTamerServantReqCacheAndRemove(string TamerGuid, out FServantReq? OutReq);
}
