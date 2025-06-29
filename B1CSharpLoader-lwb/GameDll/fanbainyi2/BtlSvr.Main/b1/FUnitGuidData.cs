using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.UnitGuidData")]
public struct FUnitGuidData
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitGuidData:GameplayTagGuid")]
	public FGameplayTag GameplayTagGuid;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UnitGuidData:GameplayTagGuidForGroup")]
	public FGameplayTag GameplayTagGuidForGroup;

	private static int UnitGuidData_StructSize;

	public FUnitGuidData Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.UnitGuidData");
		UnitGuidData_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FUnitGuidData));
	}

	static FUnitGuidData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitGuidData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitGuidData));
	}
}
