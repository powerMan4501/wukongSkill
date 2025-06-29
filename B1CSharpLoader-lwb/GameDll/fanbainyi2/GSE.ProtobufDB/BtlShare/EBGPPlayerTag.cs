using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBGPPlayerTag")]
public enum EBGPPlayerTag : byte
{
	None,
	Transforming,
	PauseEnergyCost,
	DisableTransforming,
	EnumMax
}
