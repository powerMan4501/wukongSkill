using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SettingOPType")]
public enum ESettingOPType : byte
{
	Default = 0,
	OnOff = 1,
	SlideStep = 2,
	SlideContinue = 3,
	EnumMax = byte.MaxValue
}
