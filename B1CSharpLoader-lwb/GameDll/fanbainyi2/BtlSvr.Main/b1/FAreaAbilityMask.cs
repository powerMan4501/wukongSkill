using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AreaAbilityMask")]
public struct FAreaAbilityMask
{
	[UMeta(MDEnum.BitmaskEnum, "AreaAbilityType")]
	[UMeta(MDEnum.Bitmask)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AreaAbilityMask:Mask")]
	public int Mask;

	private static int AreaAbilityMask_StructSize;

	public FAreaAbilityMask Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.AreaAbilityMask");
		AreaAbilityMask_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FAreaAbilityMask));
	}

	static FAreaAbilityMask()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAreaAbilityMask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAreaAbilityMask));
	}
}
