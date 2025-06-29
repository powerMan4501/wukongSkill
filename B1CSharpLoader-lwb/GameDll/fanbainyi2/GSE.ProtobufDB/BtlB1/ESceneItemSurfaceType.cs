using UnrealEngine.Runtime;

namespace BtlB1;

[UEnum]
[BlueprintType]
[USharpPath("/Script/GSE-ProtobufDB.SceneItemSurfaceType")]
public enum ESceneItemSurfaceType : byte
{
	DefaultSurface,
	GrassSurface,
	WaterSurface,
	CloudSurface,
	StoneSurface,
	MudSurface,
	SoilSurface,
	WoodSurface,
	HfmsoftSandSurface,
	GlideSandSurface,
	SnowSurface,
	IceSurface,
	LavaSurface,
	YinSurface,
	YangSurface,
	BloodSurface,
	GlideSnow,
	GlideIce,
	BajieMud,
	CricketBody,
	EnumMax
}
