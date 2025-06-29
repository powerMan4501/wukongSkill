using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSTurnSkillRange")]
public struct FGSTurnSkillRange
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSTurnSkillRange:AngleLow")]
	public float AngleLow;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSTurnSkillRange:AngleHigh")]
	public float AngleHigh;

	private static int FGSTurnSkillRange_StructSize;

	public FGSTurnSkillRange Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.FGSTurnSkillRange");
		FGSTurnSkillRange_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGSTurnSkillRange));
	}

	static FGSTurnSkillRange()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSTurnSkillRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSTurnSkillRange));
	}
}
