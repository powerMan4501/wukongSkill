using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.EEQSGenerator")]
public enum EEQSGenerator : byte
{
	None,
	ConeShape,
	RoundShape,
	RectangleShape,
	RoundShapeFill,
	RoundShapeRandom,
	EnumMax
}
