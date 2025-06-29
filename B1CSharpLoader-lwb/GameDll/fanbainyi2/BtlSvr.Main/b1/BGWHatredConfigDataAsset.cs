using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset")]
public class BGWHatredConfigDataAsset : UBGWDataAsset
{
	private static bool AttenuationBeginTime_IsValid;

	private static int AttenuationBeginTime_Offset;

	private static bool AttenuationSpeed_IsValid;

	private static int AttenuationSpeed_Offset;

	private static bool AttenuationSpeedForSkillExtra_IsValid;

	private static int AttenuationSpeedForSkillExtra_Offset;

	private static bool CommonCorrectionFactor_IsValid;

	private static int CommonCorrectionFactor_Offset;

	private static bool HatredTickInterval_IsValid;

	private static int HatredTickInterval_Offset;

	private static bool BeLockedCorrectionFactor_IsValid;

	private static int BeLockedCorrectionFactor_Offset;

	private static bool QualityCorrectionFactor_IsValid;

	private static int QualityCorrectionFactor_Offset;

	private static bool LockCorrectionFactor_IsValid;

	private static int LockCorrectionFactor_Offset;

	private static bool ForceUpdateHatredTargetTime_IsValid;

	private static int ForceUpdateHatredTargetTime_Offset;

	private static bool ReduceHatredValueWhenCastSkillSuccess_IsValid;

	private static int ReduceHatredValueWhenCastSkillSuccess_Offset;

	private static bool OneSideViewAngle_IsValid;

	private static int OneSideViewAngle_Offset;

	private static bool NotInViewHatredWeight_IsValid;

	private static int NotInViewHatredWeight_Offset;

	private static bool HatredBattleBlackList_IsValid;

	private static int HatredBattleBlackList_Offset;

	private static FFieldAddress HatredBattleBlackList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> HatredBattleBlackList_Marshaler;

	[UProperty]
	[DisplayName("【仇恨基础值】开始衰减时限(秒)")]
	[Category("CommSetting")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:AttenuationBeginTime")]
	public int AttenuationBeginTime
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationBeginTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:AttenuationBeginTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AttenuationBeginTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationBeginTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:AttenuationBeginTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AttenuationBeginTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("CommSetting")]
	[DisplayName("【仇恨基础值】衰减速度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:AttenuationSpeed")]
	public int AttenuationSpeed
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:AttenuationSpeed");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AttenuationSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:AttenuationSpeed");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AttenuationSpeed_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("CommSetting")]
	[DisplayName("【仇恨技能附带值】衰减速度")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:AttenuationSpeedForSkillExtra")]
	public int AttenuationSpeedForSkillExtra
	{
		get
		{
			CheckDestroyed();
			if (!AttenuationSpeedForSkillExtra_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:AttenuationSpeedForSkillExtra");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AttenuationSpeedForSkillExtra_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttenuationSpeedForSkillExtra_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:AttenuationSpeedForSkillExtra");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AttenuationSpeedForSkillExtra_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("伤害造成仇恨累计系数")]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:CommonCorrectionFactor")]
	public int CommonCorrectionFactor
	{
		get
		{
			CheckDestroyed();
			if (!CommonCorrectionFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:CommonCorrectionFactor");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CommonCorrectionFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CommonCorrectionFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:CommonCorrectionFactor");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CommonCorrectionFactor_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("搜索仇恨目标间隔")]
	[Tooltip("必须在拥有目标之后，才会定期范围更新仇恨列表")]
	[UProperty]
	[Category("CommSetting")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:HatredTickInterval")]
	public int HatredTickInterval
	{
		get
		{
			CheckDestroyed();
			if (!HatredTickInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:HatredTickInterval");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HatredTickInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HatredTickInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:HatredTickInterval");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HatredTickInterval_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("CommSetting")]
	[DisplayName("被锁定数量修正系数")]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:BeLockedCorrectionFactor")]
	public int BeLockedCorrectionFactor
	{
		get
		{
			CheckDestroyed();
			if (!BeLockedCorrectionFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:BeLockedCorrectionFactor");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BeLockedCorrectionFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeLockedCorrectionFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:BeLockedCorrectionFactor");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BeLockedCorrectionFactor_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("品质修正系数")]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:QualityCorrectionFactor")]
	public int QualityCorrectionFactor
	{
		get
		{
			CheckDestroyed();
			if (!QualityCorrectionFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:QualityCorrectionFactor");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, QualityCorrectionFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QualityCorrectionFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:QualityCorrectionFactor");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, QualityCorrectionFactor_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("锁定修正系数")]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:LockCorrectionFactor")]
	public int LockCorrectionFactor
	{
		get
		{
			CheckDestroyed();
			if (!LockCorrectionFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:LockCorrectionFactor");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LockCorrectionFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LockCorrectionFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:LockCorrectionFactor");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LockCorrectionFactor_Offset), value);
			}
		}
	}

	[Tooltip("当设定目标N秒内没有执行攻击，则执行仇恨目标更新，强制更新时间支持配置")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, 0)]
	[BlueprintReadWrite]
	[DisplayName("强制更新仇恨目标时间（秒）")]
	[Category("CommSetting")]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:ForceUpdateHatredTargetTime")]
	public int ForceUpdateHatredTargetTime
	{
		get
		{
			CheckDestroyed();
			if (!ForceUpdateHatredTargetTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:ForceUpdateHatredTargetTime");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ForceUpdateHatredTargetTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceUpdateHatredTargetTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:ForceUpdateHatredTargetTime");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ForceUpdateHatredTargetTime_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0)]
	[DisplayName("技能成功后减少仇恨值")]
	[UProperty]
	[Tooltip("当释放技能后，对当前目标单位基础仇恨值会减少固定值")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("CommSetting")]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:ReduceHatredValueWhenCastSkillSuccess")]
	public int ReduceHatredValueWhenCastSkillSuccess
	{
		get
		{
			CheckDestroyed();
			if (!ReduceHatredValueWhenCastSkillSuccess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:ReduceHatredValueWhenCastSkillSuccess");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ReduceHatredValueWhenCastSkillSuccess_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ReduceHatredValueWhenCastSkillSuccess_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:ReduceHatredValueWhenCastSkillSuccess");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ReduceHatredValueWhenCastSkillSuccess_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.ClampMax, 180)]
	[EditAnywhere]
	[DisplayName("单边视野夹角（°）")]
	[UMeta(MDProp.ClampMin, 0)]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[Tooltip("用于判断单位自身是否在目标的视野内")]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:OneSideViewAngle")]
	public int OneSideViewAngle
	{
		get
		{
			CheckDestroyed();
			if (!OneSideViewAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:OneSideViewAngle");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, OneSideViewAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OneSideViewAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:OneSideViewAngle");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, OneSideViewAngle_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, 0.01f)]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("不在目标视野内仇恨值权重")]
	[UMeta(MDProp.ClampMax, 1)]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:NotInViewHatredWeight")]
	public float NotInViewHatredWeight
	{
		get
		{
			CheckDestroyed();
			if (!NotInViewHatredWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:NotInViewHatredWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NotInViewHatredWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NotInViewHatredWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:NotInViewHatredWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NotInViewHatredWeight_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("CommSetting")]
	[DisplayName("附加仇恨单位黑名单")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWHatredConfigDataAsset:HatredBattleBlackList")]
	public TArrayReadWrite<int> HatredBattleBlackList
	{
		get
		{
			CheckDestroyed();
			if (!HatredBattleBlackList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWHatredConfigDataAsset:HatredBattleBlackList");
				return null;
			}
			if (HatredBattleBlackList_Marshaler == null)
			{
				HatredBattleBlackList_Marshaler = new TArrayReadWriteMarshaler<int>(1, HatredBattleBlackList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return HatredBattleBlackList_Marshaler.FromNative(IntPtr.Add(base.Address, HatredBattleBlackList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWHatredConfigDataAsset");
		AttenuationBeginTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttenuationBeginTime");
		AttenuationBeginTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttenuationBeginTime", Classes.FIntProperty);
		AttenuationSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttenuationSpeed");
		AttenuationSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttenuationSpeed", Classes.FIntProperty);
		AttenuationSpeedForSkillExtra_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AttenuationSpeedForSkillExtra");
		AttenuationSpeedForSkillExtra_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AttenuationSpeedForSkillExtra", Classes.FIntProperty);
		CommonCorrectionFactor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CommonCorrectionFactor");
		CommonCorrectionFactor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CommonCorrectionFactor", Classes.FIntProperty);
		HatredTickInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HatredTickInterval");
		HatredTickInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HatredTickInterval", Classes.FIntProperty);
		BeLockedCorrectionFactor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeLockedCorrectionFactor");
		BeLockedCorrectionFactor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeLockedCorrectionFactor", Classes.FIntProperty);
		QualityCorrectionFactor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "QualityCorrectionFactor");
		QualityCorrectionFactor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "QualityCorrectionFactor", Classes.FIntProperty);
		LockCorrectionFactor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LockCorrectionFactor");
		LockCorrectionFactor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LockCorrectionFactor", Classes.FIntProperty);
		ForceUpdateHatredTargetTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForceUpdateHatredTargetTime");
		ForceUpdateHatredTargetTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForceUpdateHatredTargetTime", Classes.FIntProperty);
		ReduceHatredValueWhenCastSkillSuccess_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ReduceHatredValueWhenCastSkillSuccess");
		ReduceHatredValueWhenCastSkillSuccess_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ReduceHatredValueWhenCastSkillSuccess", Classes.FIntProperty);
		OneSideViewAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OneSideViewAngle");
		OneSideViewAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OneSideViewAngle", Classes.FIntProperty);
		NotInViewHatredWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NotInViewHatredWeight");
		NotInViewHatredWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NotInViewHatredWeight", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref HatredBattleBlackList_PropertyAddress, unrealStruct, "HatredBattleBlackList");
		HatredBattleBlackList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HatredBattleBlackList");
		HatredBattleBlackList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HatredBattleBlackList", Classes.FArrayProperty);
	}

	static BGWHatredConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWHatredConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWHatredConfigDataAsset));
	}
}
