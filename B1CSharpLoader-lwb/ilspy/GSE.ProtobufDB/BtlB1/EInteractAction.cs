using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.InteractAction")]
public enum EInteractAction : byte
{
	None,
	DummyMeshAnim,
	RebirthPoint,
	Meditation,
	SkillAndBuff,
	ComplexSkill,
	Montage,
	ComplexMontage,
	Dialogue,
	Seq,
	ToolNpc,
	LoopMontage,
	LongPressRescue,
	PartyRoom,
	OnlineTeleport,
	OpenUi,
	StrangeBox,
	EnterSplineMove,
	DaShengEquipOpen,
	XiShuaiSpecial,
	Echo,
	EnumMax
}
