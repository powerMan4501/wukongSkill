using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_TrainDummyMgrConfigData : b1.IBUC_TrainDummyMgrConfigData
{
	public TSubclassOf<ABGUTamerBase> TrainDummyClass { get; set; }

	public int PlayerRoleDataConfigID { get; set; }

	public EGSTrainDummyHPType TrainDummyHPType { get; set; }

	public int TrainDummyHPValue { get; set; }

	public bool NeedCloseTrainDummyAI { get; set; }

	public EDPSCalTimeType DPSCalTimeType { get; set; }

	public float DPSCalTime { get; set; }

	public List<FTrainDummySpecialDamageTypeConfig> SpecialDamageTypeConfigList { get; set; }

	public BUC_TrainDummyMgrConfigData()
	{
		SpecialDamageTypeConfigList = new List<FTrainDummySpecialDamageTypeConfig>();
	}
}
