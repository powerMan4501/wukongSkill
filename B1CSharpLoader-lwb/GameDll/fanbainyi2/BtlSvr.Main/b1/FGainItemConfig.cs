using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.GainItemConfig")]
public struct FGainItemConfig
{
	[DisplayName("物品ID")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GainItemConfig:ItemID")]
	public int ItemID;

	[DisplayName("物品数量")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GainItemConfig:ItemCount")]
	public int ItemCount;

	private static int GainItemConfig_StructSize;

	public FGainItemConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.GainItemConfig");
		GainItemConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGainItemConfig));
	}

	static FGainItemConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGainItemConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGainItemConfig));
	}
}
