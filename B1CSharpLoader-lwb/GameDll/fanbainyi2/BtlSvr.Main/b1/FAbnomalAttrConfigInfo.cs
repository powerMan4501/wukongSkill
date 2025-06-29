using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AbnomalAttrConfigInfo")]
public struct FAbnomalAttrConfigInfo
{
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("默认累积上限值")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.AbnomalAttrConfigInfo:DefaultAccumulatedValue")]
	public int DefaultAccumulatedValue;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("累积值默认下降速度")]
	[Tooltip("每秒异常属性累积值自然下降的数值")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.AbnomalAttrConfigInfo:DefaultAccValueDecreaseSpd")]
	public int DefaultAccValueDecreaseSpd;

	[Tooltip("如冻结期间输出超过该血量上限的万分比，可打破冻结状态，目前只有冰异常有用")]
	[DisplayName("解除最终状态所需扣减的血量万分比")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AbnomalAttrConfigInfo:BRKAbnormalNeedHP_INV10000")]
	public int BRKAbnormalNeedHP_INV10000;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("因为血量扣减打破最终状态时需要触发得SkillEffectID")]
	[Tooltip("目前只有冰异常有用, Caster是攻击者，SkillEffect记得配置敌方单位筛选")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AbnomalAttrConfigInfo:BRKAbnormalTriggerSkillEffectID")]
	public int BRKAbnormalTriggerSkillEffectID;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("每次异常后属性累积值上限增加万分比")]
	[Tooltip("增加值，与万分比只能选一个")]
	[USharpPath("/Script/b1-Managed.AbnomalAttrConfigInfo:MaxAccumulatedValue_Increase_PerINV10000")]
	public int MaxAccumulatedValue_Increase_PerINV10000;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("增加属性累积值上限的最大次数")]
	[USharpPath("/Script/b1-Managed.AbnomalAttrConfigInfo:MaxAccumulatedValue_Increase_CounterMax")]
	public int MaxAccumulatedValue_Increase_CounterMax;

	private static int AbnomalAttrConfigInfo_StructSize;

	public FAbnomalAttrConfigInfo Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.AbnomalAttrConfigInfo");
		AbnomalAttrConfigInfo_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FAbnomalAttrConfigInfo));
	}

	static FAbnomalAttrConfigInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAbnomalAttrConfigInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAbnomalAttrConfigInfo));
	}
}
