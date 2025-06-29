using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_SkillCoolDown")]
public struct FDetectCondition_SkillCoolDown
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_SkillCoolDown:SkillId")]
	public int SkillId;

	private static int DetectCondition_SkillCoolDown_StructSize;

	public FDetectCondition_SkillCoolDown Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_SkillCoolDown");
		DetectCondition_SkillCoolDown_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FDetectCondition_SkillCoolDown));
	}

	static FDetectCondition_SkillCoolDown()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_SkillCoolDown)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_SkillCoolDown));
	}
}
