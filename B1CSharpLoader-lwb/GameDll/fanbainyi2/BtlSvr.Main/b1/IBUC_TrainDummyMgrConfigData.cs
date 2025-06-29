using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

internal interface IBUC_TrainDummyMgrConfigData
{
	TSubclassOf<ABGUTamerBase> TrainDummyClass { get; }

	EGSTrainDummyHPType TrainDummyHPType { get; }

	int TrainDummyHPValue { get; }

	bool NeedCloseTrainDummyAI { get; }

	EDPSCalTimeType DPSCalTimeType { get; }

	float DPSCalTime { get; }

	List<FTrainDummySpecialDamageTypeConfig> SpecialDamageTypeConfigList { get; }
}
