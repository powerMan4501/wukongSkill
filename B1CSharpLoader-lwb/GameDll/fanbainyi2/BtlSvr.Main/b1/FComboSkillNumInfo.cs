using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ComboSkillNumInfo")]
public struct FComboSkillNumInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AI|Skill")]
	[USharpPath("/Script/b1-Managed.ComboSkillNumInfo:ComboNum")]
	public int ComboNum;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AI|Skill")]
	[UMeta(MDProp.ClampMin, 1000)]
	[UMeta(MDProp.ClampMax, 10000)]
	[USharpPath("/Script/b1-Managed.ComboSkillNumInfo:ComboPercenRatio")]
	public int ComboPercenRatio;

	private static int ComboSkillNumInfo_StructSize;

	public FComboSkillNumInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.ComboSkillNumInfo");
		ComboSkillNumInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FComboSkillNumInfo));
	}

	static FComboSkillNumInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FComboSkillNumInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComboSkillNumInfo));
	}
}
