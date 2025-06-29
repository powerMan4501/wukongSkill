using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig")]
public class BGWDataAsset_BulletSmartSelectTargetConfig : UBGWDataAsset
{
	private static bool SearchRadius_IsValid;

	private static int SearchRadius_Offset;

	private static bool TargetTeamFilter_IsValid;

	private static int TargetTeamFilter_Offset;

	private static bool TargetTypeFilter_IsValid;

	private static int TargetTypeFilter_Offset;

	private static bool MultiTargetConditionTyp_IsValid;

	private static int MultiTargetConditionTyp_Offset;

	private static FFieldAddress MultiTargetConditionTyp_PropertyAddress;

	private static bool Param1_IsValid;

	private static int Param1_Offset;

	private static bool Param2_IsValid;

	private static int Param2_Offset;

	private static bool SearchTargetDelayTime_IsValid;

	private static int SearchTargetDelayTime_Offset;

	private static bool BeAttackedDecreaseValue_IsValid;

	private static int BeAttackedDecreaseValue_Offset;

	private static bool BulletDistanceDecreaseValue_IsValid;

	private static int BulletDistanceDecreaseValue_Offset;

	private static bool LastTargetDotDecreaseValue_IsValid;

	private static int LastTargetDotDecreaseValue_Offset;

	private static bool MasterDistanceDecreaseValue_IsValid;

	private static int MasterDistanceDecreaseValue_Offset;

	private static bool HitCountAddition_IsValid;

	private static int HitCountAddition_Offset;

	private static bool PerformanceProjectileID_IsValid;

	private static int PerformanceProjectileID_Offset;

	private static bool BackNestProjectileID_IsValid;

	private static int BackNestProjectileID_Offset;

	private static bool LifeTime_IsValid;

	private static int LifeTime_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("以Master为基准的索敌检索Radius")]
	[Category("SearchConfig")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:SearchRadius")]
	public int SearchRadius
	{
		get
		{
			CheckDestroyed();
			if (!SearchRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:SearchRadius");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SearchRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SearchRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:SearchRadius");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SearchRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("目标阵营筛选")]
	[Category("SearchConfig")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:TargetTeamFilter")]
	public int TargetTeamFilter
	{
		get
		{
			CheckDestroyed();
			if (!TargetTeamFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:TargetTeamFilter");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetTeamFilter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetTeamFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:TargetTeamFilter");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetTeamFilter_Offset), value);
			}
		}
	}

	[DisplayName("目标类型筛选")]
	[Category("SearchConfig")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:TargetTypeFilter")]
	public int TargetTypeFilter
	{
		get
		{
			CheckDestroyed();
			if (!TargetTypeFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:TargetTypeFilter");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetTypeFilter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetTypeFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:TargetTypeFilter");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetTypeFilter_Offset), value);
			}
		}
	}

	[DisplayName("多目标筛选条件")]
	[Category("SearchConfig")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:MultiTargetConditionTyp")]
	public EMultiTargetConditionType MultiTargetConditionTyp
	{
		get
		{
			CheckDestroyed();
			if (!MultiTargetConditionTyp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:MultiTargetConditionTyp");
				return EMultiTargetConditionType.None;
			}
			return EnumMarshaler<EMultiTargetConditionType>.FromNative(IntPtr.Add(base.Address, MultiTargetConditionTyp_Offset), 0, MultiTargetConditionTyp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MultiTargetConditionTyp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:MultiTargetConditionTyp");
			}
			else
			{
				EnumMarshaler<EMultiTargetConditionType>.ToNative(IntPtr.Add(base.Address, MultiTargetConditionTyp_Offset), 0, MultiTargetConditionTyp_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "MultiTargetConditionTyp != MultiTargetConditionType::None")]
	[DisplayName("筛选变量1")]
	[Category("SearchConfig")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:Param1")]
	public int Param1
	{
		get
		{
			CheckDestroyed();
			if (!Param1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:Param1");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Param1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Param1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:Param1");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Param1_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "MultiTargetConditionTyp != MultiTargetConditionType::None")]
	[Category("SearchConfig")]
	[UProperty]
	[DisplayName("筛选变量2")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:Param2")]
	public int Param2
	{
		get
		{
			CheckDestroyed();
			if (!Param2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:Param2");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Param2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Param2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:Param2");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Param2_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("查找目标间隔时间")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SearchConfig")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:SearchTargetDelayTime")]
	public float SearchTargetDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!SearchTargetDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:SearchTargetDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SearchTargetDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SearchTargetDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:SearchTargetDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SearchTargetDelayTime_Offset), value);
			}
		}
	}

	[Category("HitConfig")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("命中次数扣分值")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:BeAttackedDecreaseValue")]
	public float BeAttackedDecreaseValue
	{
		get
		{
			CheckDestroyed();
			if (!BeAttackedDecreaseValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:BeAttackedDecreaseValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeAttackedDecreaseValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeAttackedDecreaseValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:BeAttackedDecreaseValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeAttackedDecreaseValue_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("HitConfig")]
	[DisplayName("与子弹距离每100单位距离扣分值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:BulletDistanceDecreaseValue")]
	public float BulletDistanceDecreaseValue
	{
		get
		{
			CheckDestroyed();
			if (!BulletDistanceDecreaseValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:BulletDistanceDecreaseValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BulletDistanceDecreaseValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BulletDistanceDecreaseValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:BulletDistanceDecreaseValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BulletDistanceDecreaseValue_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("每单位Dot扣分值")]
	[UProperty]
	[EditAnywhere]
	[Category("HitConfig")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:LastTargetDotDecreaseValue")]
	public float LastTargetDotDecreaseValue
	{
		get
		{
			CheckDestroyed();
			if (!LastTargetDotDecreaseValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:LastTargetDotDecreaseValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LastTargetDotDecreaseValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LastTargetDotDecreaseValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:LastTargetDotDecreaseValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LastTargetDotDecreaseValue_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("HitConfig")]
	[DisplayName("与Master距离每100单位距离扣分值")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:MasterDistanceDecreaseValue")]
	public float MasterDistanceDecreaseValue
	{
		get
		{
			CheckDestroyed();
			if (!MasterDistanceDecreaseValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:MasterDistanceDecreaseValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MasterDistanceDecreaseValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MasterDistanceDecreaseValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:MasterDistanceDecreaseValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MasterDistanceDecreaseValue_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("HitCount冗余值")]
	[BlueprintReadWrite]
	[Category("HitConfig")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:HitCountAddition")]
	public int HitCountAddition
	{
		get
		{
			CheckDestroyed();
			if (!HitCountAddition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:HitCountAddition");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HitCountAddition_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitCountAddition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:HitCountAddition");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HitCountAddition_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("BulletConfig")]
	[DisplayName("表演子弹ID")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:PerformanceProjectileID")]
	public int PerformanceProjectileID
	{
		get
		{
			CheckDestroyed();
			if (!PerformanceProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:PerformanceProjectileID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PerformanceProjectileID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformanceProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:PerformanceProjectileID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PerformanceProjectileID_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("归巢子弹ID")]
	[Category("BulletConfig")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:BackNestProjectileID")]
	public int BackNestProjectileID
	{
		get
		{
			CheckDestroyed();
			if (!BackNestProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:BackNestProjectileID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BackNestProjectileID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BackNestProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:BackNestProjectileID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BackNestProjectileID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("BulletConfig")]
	[DisplayName("整体生命周期")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:LifeTime")]
	public float LifeTime
	{
		get
		{
			CheckDestroyed();
			if (!LifeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:LifeTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LifeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LifeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig:LifeTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LifeTime_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_BulletSmartSelectTargetConfig");
		SearchRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SearchRadius");
		SearchRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SearchRadius", Classes.FIntProperty);
		TargetTeamFilter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetTeamFilter");
		TargetTeamFilter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetTeamFilter", Classes.FIntProperty);
		TargetTypeFilter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetTypeFilter");
		TargetTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetTypeFilter", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref MultiTargetConditionTyp_PropertyAddress, unrealStruct, "MultiTargetConditionTyp");
		MultiTargetConditionTyp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MultiTargetConditionTyp");
		MultiTargetConditionTyp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MultiTargetConditionTyp", Classes.FEnumProperty);
		Param1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Param1");
		Param1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Param1", Classes.FIntProperty);
		Param2_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Param2");
		Param2_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Param2", Classes.FIntProperty);
		SearchTargetDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SearchTargetDelayTime");
		SearchTargetDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SearchTargetDelayTime", Classes.FFloatProperty);
		BeAttackedDecreaseValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeAttackedDecreaseValue");
		BeAttackedDecreaseValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeAttackedDecreaseValue", Classes.FFloatProperty);
		BulletDistanceDecreaseValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BulletDistanceDecreaseValue");
		BulletDistanceDecreaseValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BulletDistanceDecreaseValue", Classes.FFloatProperty);
		LastTargetDotDecreaseValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LastTargetDotDecreaseValue");
		LastTargetDotDecreaseValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LastTargetDotDecreaseValue", Classes.FFloatProperty);
		MasterDistanceDecreaseValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MasterDistanceDecreaseValue");
		MasterDistanceDecreaseValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MasterDistanceDecreaseValue", Classes.FFloatProperty);
		HitCountAddition_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HitCountAddition");
		HitCountAddition_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HitCountAddition", Classes.FIntProperty);
		PerformanceProjectileID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PerformanceProjectileID");
		PerformanceProjectileID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PerformanceProjectileID", Classes.FIntProperty);
		BackNestProjectileID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BackNestProjectileID");
		BackNestProjectileID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BackNestProjectileID", Classes.FIntProperty);
		LifeTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LifeTime");
		LifeTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LifeTime", Classes.FFloatProperty);
	}

	static BGWDataAsset_BulletSmartSelectTargetConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_BulletSmartSelectTargetConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_BulletSmartSelectTargetConfig));
	}
}
