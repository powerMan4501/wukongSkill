using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EGSBuffLayerCounterType")]
public enum EGSBuffLayerCounterType : byte
{
	ReduceLayer,
	RemoveDirectly,
	EnumMax
}
