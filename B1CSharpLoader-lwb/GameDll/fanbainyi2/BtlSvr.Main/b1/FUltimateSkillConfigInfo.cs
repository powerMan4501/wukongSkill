using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.UltimateSkillConfigInfo")]
public struct FUltimateSkillConfigInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("队伍ID")]
	[USharpPath("/Script/b1-Managed.UltimateSkillConfigInfo:TeamID")]
	public int TeamID;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("最大鬼畜值")]
	[USharpPath("/Script/b1-Managed.UltimateSkillConfigInfo:MaxUltimateValue")]
	public float MaxUltimateValue;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("鬼畜阶段倒计时")]
	[USharpPath("/Script/b1-Managed.UltimateSkillConfigInfo:UltimateCastingCountDown")]
	public float UltimateCastingCountDown;

	private static int UltimateSkillConfigInfo_StructSize;

	public FUltimateSkillConfigInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.UltimateSkillConfigInfo");
		UltimateSkillConfigInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FUltimateSkillConfigInfo));
	}

	static FUltimateSkillConfigInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUltimateSkillConfigInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUltimateSkillConfigInfo));
	}
}
