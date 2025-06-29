using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.ComboConditionSkill_UnitResIDInfo")]
public struct FComboConditionSkill_UnitResIDInfo
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ComboConditionSkill_UnitResIDInfo:ResID")]
	public int ResID;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.ComboConditionSkill_UnitResIDInfo:SkillID")]
	public int SkillID;

	private static int ComboConditionSkill_UnitResIDInfo_StructSize;

	public FComboConditionSkill_UnitResIDInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.ComboConditionSkill_UnitResIDInfo");
		ComboConditionSkill_UnitResIDInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FComboConditionSkill_UnitResIDInfo));
	}

	static FComboConditionSkill_UnitResIDInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FComboConditionSkill_UnitResIDInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FComboConditionSkill_UnitResIDInfo));
	}
}
