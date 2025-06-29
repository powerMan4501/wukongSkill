using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ChaosNiagara;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/ChaosNiagara.ELocationFilteringModeEnum", "ChaosNiagara", UnrealModuleType.EnginePlugin)]
public enum ELocationFilteringModeEnum : byte
{
	ChaosNiagara_LocationFilteringMode_Inclusive,
	ChaosNiagara_LocationFilteringMode_Exclusive,
	ChaosNiagara_Max
}
