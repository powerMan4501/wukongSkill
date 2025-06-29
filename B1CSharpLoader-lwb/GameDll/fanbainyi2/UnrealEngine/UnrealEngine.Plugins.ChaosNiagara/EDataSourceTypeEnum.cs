using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosNiagara;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ChaosNiagara.EDataSourceTypeEnum", "ChaosNiagara", UnrealModuleType.EnginePlugin)]
public enum EDataSourceTypeEnum : byte
{
	ChaosNiagara_DataSourceType_Collision,
	ChaosNiagara_DataSourceType_Breaking,
	ChaosNiagara_DataSourceType_Trailing,
	ChaosNiagara_Max
}
