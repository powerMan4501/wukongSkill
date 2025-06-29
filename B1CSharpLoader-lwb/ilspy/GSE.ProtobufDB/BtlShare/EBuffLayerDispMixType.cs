using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.BuffLayerDispMixType")]
public enum EBuffLayerDispMixType : byte
{
	Override,
	Overlay,
	EnumMax
}
