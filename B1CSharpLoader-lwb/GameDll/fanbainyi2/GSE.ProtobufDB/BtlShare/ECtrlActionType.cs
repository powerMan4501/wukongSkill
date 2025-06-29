using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.CtrlActionType")]
public enum ECtrlActionType : byte
{
	CatNone,
	CatRunTrace,
	CatAttack,
	CatTooFar,
	CatMoveToCast
}
