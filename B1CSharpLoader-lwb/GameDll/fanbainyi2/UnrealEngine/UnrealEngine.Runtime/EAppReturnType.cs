namespace UnrealEngine.Runtime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.EAppReturnType", "CoreUObject", UnrealModuleType.Engine)]
public enum EAppReturnType : byte
{
	No,
	Yes,
	YesAll,
	NoAll,
	Cancel,
	Ok,
	Retry,
	Continue
}
