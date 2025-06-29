using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProjectileExtAbilityMask")]
public struct FProjectileExtAbilityMask
{
	[EditAnywhere]
	[UMeta(MDEnum.BitmaskEnum, "ProjectileAbilityType")]
	[UMeta(MDEnum.Bitmask)]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProjectileExtAbilityMask:Mask")]
	public int Mask;

	private static int ProjectileExtAbilityMask_StructSize;

	public FProjectileExtAbilityMask Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.ProjectileExtAbilityMask");
		ProjectileExtAbilityMask_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FProjectileExtAbilityMask));
	}

	static FProjectileExtAbilityMask()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FProjectileExtAbilityMask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProjectileExtAbilityMask));
	}
}
