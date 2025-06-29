using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.MapSpriteConfig")]
public struct FMapSpriteConfig
{
	[BlueprintReadWrite]
	[DisplayName("地图边距")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MapSpriteConfig:MoveRangeOffset")]
	public FVector2D MoveRangeOffset;

	[DisplayName("地图最小缩放")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapSpriteConfig:MinScale")]
	public float MinScale;

	[DisplayName("地图最大缩放")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapSpriteConfig:MaxScale")]
	public float MaxScale;

	[UProperty]
	[EditAnywhere]
	[DisplayName("地图列表展开时默认缩放")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapSpriteConfig:SelectedScale")]
	public float SelectedScale;

	[DisplayName("地图图标通用配置")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MapSpriteConfig:MapLevelCommConfig")]
	public FMapLevelConfig MapLevelCommConfig;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("地图描述通用配置")]
	[USharpPath("/Script/b1-Managed.MapSpriteConfig:MapLevelDescConfig")]
	public FMapLevelConfig MapLevelDescConfig;

	[UProperty]
	[DisplayName("地图PaperMaskIndex参数")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MapSpriteConfig:PaperMaskIndex")]
	public int PaperMaskIndex;

	private static int MapSpriteConfig_StructSize;

	public FMapSpriteConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.MapSpriteConfig");
		MapSpriteConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FMapSpriteConfig));
	}

	static FMapSpriteConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMapSpriteConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMapSpriteConfig));
	}
}
