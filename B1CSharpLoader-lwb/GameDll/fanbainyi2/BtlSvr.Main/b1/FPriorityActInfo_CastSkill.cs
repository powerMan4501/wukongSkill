using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.PriorityActInfo_CastSkill")]
public struct FPriorityActInfo_CastSkill
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CastSkillAction")]
	[DisplayName("技能ID")]
	[USharpPath("/Script/b1-Managed.PriorityActInfo_CastSkill:SkillID")]
	public int SkillID;

	private static int PriorityActInfo_CastSkill_StructSize;

	public FPriorityActInfo_CastSkill Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.PriorityActInfo_CastSkill");
		PriorityActInfo_CastSkill_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FPriorityActInfo_CastSkill));
	}

	static FPriorityActInfo_CastSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPriorityActInfo_CastSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPriorityActInfo_CastSkill));
	}
}
