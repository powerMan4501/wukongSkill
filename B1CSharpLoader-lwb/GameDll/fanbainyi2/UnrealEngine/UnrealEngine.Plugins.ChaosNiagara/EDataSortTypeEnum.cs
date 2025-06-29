using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosNiagara;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ChaosNiagara.EDataSortTypeEnum", "ChaosNiagara", UnrealModuleType.EnginePlugin)]
public enum EDataSortTypeEnum : byte
{
	ChaosNiagara_DataSortType_NoSorting,
	ChaosNiagara_DataSortType_RandomShuffle,
	ChaosNiagara_DataSortType_SortByMassMaxToMin,
	ChaosNiagara_DataSortType_SortByMassMinToMax,
	ChaosNiagara_Max
}
