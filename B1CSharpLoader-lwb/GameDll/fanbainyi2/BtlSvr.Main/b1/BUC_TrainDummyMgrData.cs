using System.Collections.Generic;

namespace b1;

public class BUC_TrainDummyMgrData : b1.IBUC_TrainDummyMgrData
{
	public DPSCalculateInfo CurrentDPSInfo { get; set; }

	public List<DPSCalculateInfo> FinishedDPSInfos { get; set; }

	public string SpawnUnitGuid { get; set; }

	public bool IsUnitSpawned { get; set; }

	public bool IsUnitManaged { get; set; }

	public bool IsNeedDestroyUnitAfterFinish { get; set; }

	public bool IsPlayerInit { get; set; }

	public bool TrainDummyFailed { get; set; }

	public BUC_TrainDummyMgrData()
	{
		CurrentDPSInfo = null;
		FinishedDPSInfos = new List<DPSCalculateInfo>();
	}
}
