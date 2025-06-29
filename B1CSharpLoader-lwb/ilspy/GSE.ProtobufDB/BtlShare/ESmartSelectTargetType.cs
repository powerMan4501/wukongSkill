using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SmartSelectTargetType")]
public enum ESmartSelectTargetType : byte
{
	None,
	SstSimple,
	SstQuality,
	SstSelf,
	SstQuantity,
	SstElite,
	SstSame,
	SstMeleeAutoLock,
	SstCameraLock
}
