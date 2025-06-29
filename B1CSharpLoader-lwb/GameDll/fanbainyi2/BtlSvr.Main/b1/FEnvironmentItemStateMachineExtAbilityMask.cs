using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.EnvironmentItemStateMachineExtAbilityMask")]
public struct FEnvironmentItemStateMachineExtAbilityMask
{
	[UMeta(MDEnum.BitmaskEnum, "EnvironmentItemStateMachineAbilityType")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDEnum.Bitmask)]
	[USharpPath("/Script/b1-Managed.EnvironmentItemStateMachineExtAbilityMask:Mask")]
	public int Mask;

	private static int EnvironmentItemStateMachineExtAbilityMask_StructSize;

	public FEnvironmentItemStateMachineExtAbilityMask Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.EnvironmentItemStateMachineExtAbilityMask");
		EnvironmentItemStateMachineExtAbilityMask_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FEnvironmentItemStateMachineExtAbilityMask));
	}

	static FEnvironmentItemStateMachineExtAbilityMask()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FEnvironmentItemStateMachineExtAbilityMask)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEnvironmentItemStateMachineExtAbilityMask));
	}
}
