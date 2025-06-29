using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.CloudMoveBreakSkillConfig")]
public struct FCloudMoveBreakSkillConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("填技能ID，如果值<=0则不使用技能直接进下落动画")]
	[USharpPath("/Script/b1-Managed.CloudMoveBreakSkillConfig:BreakSkill_Low")]
	public int BreakSkill_Low;

	[Tooltip("填技能ID，如果值<=0则不使用技能直接进下落动画")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CloudMoveBreakSkillConfig:BreakSkill_High")]
	public int BreakSkill_High;

	private static int CloudMoveBreakSkillConfig_StructSize;

	public FCloudMoveBreakSkillConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.CloudMoveBreakSkillConfig");
		CloudMoveBreakSkillConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FCloudMoveBreakSkillConfig));
	}

	static FCloudMoveBreakSkillConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCloudMoveBreakSkillConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCloudMoveBreakSkillConfig));
	}
}
