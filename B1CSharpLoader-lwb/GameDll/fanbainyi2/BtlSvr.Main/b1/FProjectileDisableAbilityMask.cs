using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProjectileDisableAbilityMask")]
public struct FProjectileDisableAbilityMask
{
	[UMeta(MDEnum.BitmaskEnum, "ProjectileDisableAbilityType")]
	[UMeta(MDEnum.Bitmask)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.ProjectileDisableAbilityMask:Mask")]
	public int Mask;

	private static int ProjectileDisableAbilityMask_StructSize;

	public FProjectileDisableAbilityMask Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.ProjectileDisableAbilityMask");
		ProjectileDisableAbilityMask_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FProjectileDisableAbilityMask));
	}

	static FProjectileDisableAbilityMask()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FProjectileDisableAbilityMask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProjectileDisableAbilityMask));
	}
}
