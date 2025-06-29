using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.MapLevelConfig")]
public struct FMapLevelConfig
{
	[DisplayName("优先级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapLevelConfig:Priority")]
	public int Priority;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("半径")]
	[USharpPath("/Script/b1-Managed.MapLevelConfig:Size")]
	public float Size;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("吸附范围")]
	[USharpPath("/Script/b1-Managed.MapLevelConfig:Range")]
	public float Range;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("摩擦力")]
	[USharpPath("/Script/b1-Managed.MapLevelConfig:Friction")]
	public float Friction;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("最小缩放")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MapLevelConfig:MinScale")]
	public float MinScale;

	[BlueprintReadWrite]
	[DisplayName("最大缩放")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MapLevelConfig:MaxScale")]
	public float MaxScale;

	[DisplayName("选中缩放")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MapLevelConfig:SelectedScale")]
	public float SelectedScale;

	[UProperty]
	[DisplayName("可显示最小缩放")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MapLevelConfig:MinCanShowScale")]
	public float MinCanShowScale;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("可显示最大缩放")]
	[USharpPath("/Script/b1-Managed.MapLevelConfig:MaxCanShowScale")]
	public float MaxCanShowScale;

	private static int MapLevelConfig_StructSize;

	public FMapLevelConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.MapLevelConfig");
		MapLevelConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FMapLevelConfig));
	}

	static FMapLevelConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMapLevelConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMapLevelConfig));
	}
}
