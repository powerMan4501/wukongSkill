namespace UnrealEngine.Runtime;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.EAppMsgType", "CoreUObject", UnrealModuleType.Engine)]
public enum EAppMsgType : byte
{
	Ok,
	YesNo,
	OkCancel,
	YesNoCancel,
	CancelRetryContinue,
	YesNoYesAllNoAll,
	YesNoYesAllNoAllCancel,
	YesNoYesAll
}
