using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DataValidation;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/DataValidation.EDataValidationUsecase", "DataValidation", UnrealModuleType.EnginePlugin)]
public enum EDataValidationUsecase : byte
{
	None,
	Manual,
	Commandlet,
	Save,
	PreSubmit,
	Script
}
