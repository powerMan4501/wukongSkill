using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.ECSVImportType", "UnrealEd", UnrealModuleType.Engine)]
public enum ECSVImportType : byte
{
	ECSV_DataTable,
	ECSV_CurveTable,
	ECSV_CurveFloat,
	ECSV_CurveVector,
	ECSV_CurveLinearColor
}
