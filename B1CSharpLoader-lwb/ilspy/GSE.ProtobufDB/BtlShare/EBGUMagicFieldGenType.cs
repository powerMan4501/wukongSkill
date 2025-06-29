using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EBGUMagicFieldGenType")]
public enum EBGUMagicFieldGenType : byte
{
	EbgumagicFieldGenTypeCaster = 0,
	Target = 1,
	EnumMax = 3
}
