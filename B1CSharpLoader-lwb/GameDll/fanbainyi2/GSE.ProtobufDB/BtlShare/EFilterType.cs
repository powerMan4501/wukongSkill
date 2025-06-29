using UnrealEngine.Runtime;

namespace BtlShare;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.FilterType")]
public enum EFilterType : byte
{
	CheckAngle,
	SkillArea,
	SkillCastRange,
	CharacterBlock,
	NavPathExist,
	Visible,
	Height,
	Distance,
	Score,
	Team,
	PointsGen,
	UnitState,
	FixedDistance,
	Hppercent,
	InNavMesh,
	ValidSkill,
	UnitResId,
	FeatureDesc
}
