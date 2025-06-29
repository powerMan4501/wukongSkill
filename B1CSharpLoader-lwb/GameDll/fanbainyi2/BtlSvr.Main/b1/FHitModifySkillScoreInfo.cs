using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.HitModifySkillScoreInfo")]
public struct FHitModifySkillScoreInfo
{
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("技能ID")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.HitModifySkillScoreInfo:SkillID")]
	public int SkillID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("修改分数")]
	[Tooltip("是增加or减少，不是替换")]
	[USharpPath("/Script/b1-Managed.HitModifySkillScoreInfo:ModifyScore")]
	public float ModifyScore;

	private static int HitModifySkillScoreInfo_StructSize;

	public FHitModifySkillScoreInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.HitModifySkillScoreInfo");
		HitModifySkillScoreInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FHitModifySkillScoreInfo));
	}

	static FHitModifySkillScoreInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FHitModifySkillScoreInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHitModifySkillScoreInfo));
	}
}
