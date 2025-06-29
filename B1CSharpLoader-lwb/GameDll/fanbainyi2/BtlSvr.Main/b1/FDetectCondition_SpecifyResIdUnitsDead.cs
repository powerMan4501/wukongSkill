using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_SpecifyResIdUnitsDead")]
public struct FDetectCondition_SpecifyResIdUnitsDead
{
	[UProperty]
	[EditAnywhere]
	[DisplayName("指定ResID")]
	[USharpPath("/Script/b1-Managed.DetectCondition_SpecifyResIdUnitsDead:ResId")]
	public int ResId;

	private static int DetectCondition_SpecifyResIdUnitsDead_StructSize;

	public FDetectCondition_SpecifyResIdUnitsDead Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_SpecifyResIdUnitsDead");
		DetectCondition_SpecifyResIdUnitsDead_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FDetectCondition_SpecifyResIdUnitsDead));
	}

	static FDetectCondition_SpecifyResIdUnitsDead()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_SpecifyResIdUnitsDead)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_SpecifyResIdUnitsDead));
	}
}
