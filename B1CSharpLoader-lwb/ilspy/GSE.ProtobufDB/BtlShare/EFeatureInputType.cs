using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.FeatureInputType")]
public enum EFeatureInputType : byte
{
	NoInput,
	FeatureOutput,
	AllCharacters,
	OwnCharacter,
	CenterCharacter
}
