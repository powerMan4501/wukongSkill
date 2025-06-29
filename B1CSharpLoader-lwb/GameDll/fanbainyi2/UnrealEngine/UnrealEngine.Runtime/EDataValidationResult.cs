namespace UnrealEngine.Runtime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.EDataValidationResult", "CoreUObject", UnrealModuleType.Engine)]
public enum EDataValidationResult : byte
{
	Invalid,
	Valid,
	NotValidated
}
