using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_SkillCanCast")]
public struct FDetectCondition_SkillCanCast
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_SkillCanCast:SkillId")]
	public int SkillId;

	private static int DetectCondition_SkillCanCast_StructSize;

	public FDetectCondition_SkillCanCast Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_SkillCanCast");
		DetectCondition_SkillCanCast_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FDetectCondition_SkillCanCast));
	}

	static FDetectCondition_SkillCanCast()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_SkillCanCast)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_SkillCanCast));
	}
}
