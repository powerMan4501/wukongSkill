using System.Collections.Generic;

namespace b1;

internal interface IBUC_TrainDummyMgrData
{
	List<DPSCalculateInfo> FinishedDPSInfos { get; }

	string SpawnUnitGuid { get; }

	bool IsUnitManaged { get; }
}
