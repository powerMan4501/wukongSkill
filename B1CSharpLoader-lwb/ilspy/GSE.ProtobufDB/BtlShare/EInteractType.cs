using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.InteractType")]
public enum EInteractType : byte
{
	None,
	RebirthPoint,
	StandardObj,
	DropItem,
	TaskNpc,
	Rescue,
	Collection,
	MeditationPoint,
	BoLangGu,
	RequireItem,
	Focus,
	NotForPlayer,
	StrangeBox,
	Cricket,
	EnumMax
}
