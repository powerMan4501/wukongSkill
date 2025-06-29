using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSWakeUpDirectionOnFightSkillConfig")]
public struct FGSWakeUpDirectionOnFightSkillConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSWakeUpDirectionOnFightSkillConfig:OnFightSkillIDBack")]
	public int OnFightSkillIDBack;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSWakeUpDirectionOnFightSkillConfig:OnFightSkillIDLeft")]
	public int OnFightSkillIDLeft;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSWakeUpDirectionOnFightSkillConfig:OnFightSkillIDRight")]
	public int OnFightSkillIDRight;

	private static int FGSWakeUpDirectionOnFightSkillConfig_StructSize;

	public FGSWakeUpDirectionOnFightSkillConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.FGSWakeUpDirectionOnFightSkillConfig");
		FGSWakeUpDirectionOnFightSkillConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGSWakeUpDirectionOnFightSkillConfig));
	}

	static FGSWakeUpDirectionOnFightSkillConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSWakeUpDirectionOnFightSkillConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSWakeUpDirectionOnFightSkillConfig));
	}
}
