using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig")]
public class UBGWImmobilizeConfig : UBGWDataAsset
{
	private static bool DurationMs_IsValid;

	private static int DurationMs_Offset;

	private static bool AlmostEndAheadTimeMs_IsValid;

	private static int AlmostEndAheadTimeMs_Offset;

	private static bool BeginFXs_IsValid;

	private static int BeginFXs_Offset;

	private static FFieldAddress BeginFXs_PropertyAddress;

	private TMapReadWriteMarshaler<int, UBGWDataAsset> BeginFXs_Marshaler;

	private static bool AlmostEndFXs_IsValid;

	private static int AlmostEndFXs_Offset;

	private static FFieldAddress AlmostEndFXs_PropertyAddress;

	private TMapReadWriteMarshaler<int, UBGWDataAsset> AlmostEndFXs_Marshaler;

	private static bool EndFXs_IsValid;

	private static int EndFXs_Offset;

	private static FFieldAddress EndFXs_PropertyAddress;

	private TMapReadWriteMarshaler<int, UBGWDataAsset> EndFXs_Marshaler;

	private static bool ExtraFXs_IsValid;

	private static int ExtraFXs_Offset;

	private static FFieldAddress ExtraFXs_PropertyAddress;

	private TArrayReadWriteMarshaler<UBGWDataAsset> ExtraFXs_Marshaler;

	private static bool TargetFilter_IsValid;

	private static int TargetFilter_Offset;

	private static bool TargetTypeFilter_IsValid;

	private static int TargetTypeFilter_Offset;

	private static bool AffiliationTypeFilter_IsValid;

	private static int AffiliationTypeFilter_Offset;

	private static bool TargetCount_IsValid;

	private static int TargetCount_Offset;

	private static bool RangeRadius_IsValid;

	private static int RangeRadius_Offset;

	private static bool BeginBuffIDs_IsValid;

	private static int BeginBuffIDs_Offset;

	private static FFieldAddress BeginBuffIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> BeginBuffIDs_Marshaler;

	private static bool BeginSkillEffectIDs_IsValid;

	private static int BeginSkillEffectIDs_Offset;

	private static FFieldAddress BeginSkillEffectIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> BeginSkillEffectIDs_Marshaler;

	private static bool BreakBuffIDs_IsValid;

	private static int BreakBuffIDs_Offset;

	private static FFieldAddress BreakBuffIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> BreakBuffIDs_Marshaler;

	private static bool BreakSkillEffectIDs_IsValid;

	private static int BreakSkillEffectIDs_Offset;

	private static FFieldAddress BreakSkillEffectIDs_PropertyAddress;

	private TArrayReadWriteMarshaler<int> BreakSkillEffectIDs_Marshaler;

	[DisplayName("定身时长（毫秒），修正ID : 1001")]
	[Tooltip("受定身抗性影响")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:DurationMs")]
	public int DurationMs
	{
		get
		{
			CheckDestroyed();
			if (!DurationMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:DurationMs");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, DurationMs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DurationMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:DurationMs");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, DurationMs_Offset), value);
			}
		}
	}

	[Tooltip("受定身抗性影响")]
	[DisplayName("结束提示特效提前时长（毫秒），修正ID : 1002")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:AlmostEndAheadTimeMs")]
	public int AlmostEndAheadTimeMs
	{
		get
		{
			CheckDestroyed();
			if (!AlmostEndAheadTimeMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:AlmostEndAheadTimeMs");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AlmostEndAheadTimeMs_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AlmostEndAheadTimeMs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:AlmostEndAheadTimeMs");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AlmostEndAheadTimeMs_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("通过DBC播放特效,为方便修正，这里填写路径， Key为ResID, 默认配置填0即可, 修正时SubID填key, Value填备用特效中的编号ID")]
	[DisplayName("定身特效，修正ID : 1101")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:BeginFXs")]
	public TMapReadWrite<int, UBGWDataAsset> BeginFXs
	{
		get
		{
			CheckDestroyed();
			if (!BeginFXs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:BeginFXs");
				return null;
			}
			if (BeginFXs_Marshaler == null)
			{
				BeginFXs_Marshaler = new TMapReadWriteMarshaler<int, UBGWDataAsset>(1, BeginFXs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.FromNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.ToNative);
			}
			return BeginFXs_Marshaler.FromNative(IntPtr.Add(base.Address, BeginFXs_Offset));
		}
	}

	[DisplayName("定身结束提示特效，修正ID : 1102")]
	[BlueprintReadOnly]
	[Tooltip("通过DBC播放特效,为方便修正，这里填写路径， Key为ResID, 默认配置填0即可, 修正时SubID填key, Value填备用特效中的编号ID")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:AlmostEndFXs")]
	public TMapReadWrite<int, UBGWDataAsset> AlmostEndFXs
	{
		get
		{
			CheckDestroyed();
			if (!AlmostEndFXs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:AlmostEndFXs");
				return null;
			}
			if (AlmostEndFXs_Marshaler == null)
			{
				AlmostEndFXs_Marshaler = new TMapReadWriteMarshaler<int, UBGWDataAsset>(1, AlmostEndFXs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.FromNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.ToNative);
			}
			return AlmostEndFXs_Marshaler.FromNative(IntPtr.Add(base.Address, AlmostEndFXs_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[Tooltip("通过DBC播放特效,为方便修正，这里填写路径， Key为ResID, 默认配置填0即可, 修正时SubID填key, Value填备用特效中的编号ID")]
	[DisplayName("定身结束特效，修正ID : 1103")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:EndFXs")]
	public TMapReadWrite<int, UBGWDataAsset> EndFXs
	{
		get
		{
			CheckDestroyed();
			if (!EndFXs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:EndFXs");
				return null;
			}
			if (EndFXs_Marshaler == null)
			{
				EndFXs_Marshaler = new TMapReadWriteMarshaler<int, UBGWDataAsset>(1, EndFXs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.FromNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.ToNative);
			}
			return EndFXs_Marshaler.FromNative(IntPtr.Add(base.Address, EndFXs_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("额外备用特效，特效编号ID : 1200 + 序号")]
	[Tooltip("这里的特效用于修正其他相关特效参数时使用")]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:ExtraFXs")]
	public TArrayReadWrite<UBGWDataAsset> ExtraFXs
	{
		get
		{
			CheckDestroyed();
			if (!ExtraFXs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:ExtraFXs");
				return null;
			}
			if (ExtraFXs_Marshaler == null)
			{
				ExtraFXs_Marshaler = new TArrayReadWriteMarshaler<UBGWDataAsset>(1, ExtraFXs_PropertyAddress, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.FromNative, CachedMarshalingDelegates<UBGWDataAsset, UObjectMarshaler<UBGWDataAsset>>.ToNative);
			}
			return ExtraFXs_Marshaler.FromNative(IntPtr.Add(base.Address, ExtraFXs_Offset));
		}
	}

	[Tooltip("1:自己, 2：队友, 4:敌人")]
	[DisplayName("选取目标筛选，修正ID : 1501")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:TargetFilter")]
	public int TargetFilter
	{
		get
		{
			CheckDestroyed();
			if (!TargetFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:TargetFilter");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetFilter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:TargetFilter");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetFilter_Offset), value);
			}
		}
	}

	[Tooltip("1:角色, 2：子弹, 4:法术场")]
	[DisplayName("目标类型筛选，修正ID : 1502")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:TargetTypeFilter")]
	public int TargetTypeFilter
	{
		get
		{
			CheckDestroyed();
			if (!TargetTypeFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:TargetTypeFilter");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetTypeFilter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetTypeFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:TargetTypeFilter");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetTypeFilter_Offset), value);
			}
		}
	}

	[Tooltip("1: Master, 2：召唤物, 4: 其他")]
	[UProperty]
	[DisplayName("归属类型筛选，修正ID : 1503")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:AffiliationTypeFilter")]
	public int AffiliationTypeFilter
	{
		get
		{
			CheckDestroyed();
			if (!AffiliationTypeFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:AffiliationTypeFilter");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AffiliationTypeFilter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AffiliationTypeFilter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:AffiliationTypeFilter");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AffiliationTypeFilter_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[Tooltip("小于1时默认为1")]
	[DisplayName("定身目标个数，修正ID : 1601")]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:TargetCount")]
	public int TargetCount
	{
		get
		{
			CheckDestroyed();
			if (!TargetCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:TargetCount");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TargetCount_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetCount_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:TargetCount");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TargetCount_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("选择范围是锁定目标为原点的圆形指定半径范围内")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[DisplayName("定身目标选择范围，修正ID : 1602")]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:RangeRadius")]
	public int RangeRadius
	{
		get
		{
			CheckDestroyed();
			if (!RangeRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:RangeRadius");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RangeRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:RangeRadius");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RangeRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("定身开始时添加的Buff列表，修正ID : 2000 + 序号")]
	[Tooltip("填-1为占位符，默认不触发效果，可以被修正；Buff会在结束时移除")]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:BeginBuffIDs")]
	public TArrayReadWrite<int> BeginBuffIDs
	{
		get
		{
			CheckDestroyed();
			if (!BeginBuffIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:BeginBuffIDs");
				return null;
			}
			if (BeginBuffIDs_Marshaler == null)
			{
				BeginBuffIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, BeginBuffIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BeginBuffIDs_Marshaler.FromNative(IntPtr.Add(base.Address, BeginBuffIDs_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("定身开始时触发的SkillEffect列表，修正ID : 2500 + 序号")]
	[Tooltip("填-1为占位符，默认不触发效果，可以被修正")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:BeginSkillEffectIDs")]
	public TArrayReadWrite<int> BeginSkillEffectIDs
	{
		get
		{
			CheckDestroyed();
			if (!BeginSkillEffectIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:BeginSkillEffectIDs");
				return null;
			}
			if (BeginSkillEffectIDs_Marshaler == null)
			{
				BeginSkillEffectIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, BeginSkillEffectIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BeginSkillEffectIDs_Marshaler.FromNative(IntPtr.Add(base.Address, BeginSkillEffectIDs_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("定身破碎时添加的Buff列表，修正ID : 3000 + 序号")]
	[Tooltip("填-1为占位符，默认不触发效果，可以被修正；Buff不会被主动移除")]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:BreakBuffIDs")]
	public TArrayReadWrite<int> BreakBuffIDs
	{
		get
		{
			CheckDestroyed();
			if (!BreakBuffIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:BreakBuffIDs");
				return null;
			}
			if (BreakBuffIDs_Marshaler == null)
			{
				BreakBuffIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, BreakBuffIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BreakBuffIDs_Marshaler.FromNative(IntPtr.Add(base.Address, BreakBuffIDs_Offset));
		}
	}

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[DisplayName("定身破碎时触发的SkillEffect列表，修正ID : 3500 + 序号")]
	[Tooltip("填-1为占位符，默认不触发效果，可以被修正")]
	[USharpPath("/Script/b1-Managed.UBGWImmobilizeConfig:BreakSkillEffectIDs")]
	public TArrayReadWrite<int> BreakSkillEffectIDs
	{
		get
		{
			CheckDestroyed();
			if (!BreakSkillEffectIDs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWImmobilizeConfig:BreakSkillEffectIDs");
				return null;
			}
			if (BreakSkillEffectIDs_Marshaler == null)
			{
				BreakSkillEffectIDs_Marshaler = new TArrayReadWriteMarshaler<int>(1, BreakSkillEffectIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return BreakSkillEffectIDs_Marshaler.FromNative(IntPtr.Add(base.Address, BreakSkillEffectIDs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.UBGWImmobilizeConfig");
		DurationMs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DurationMs");
		DurationMs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DurationMs", Classes.FIntProperty);
		AlmostEndAheadTimeMs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AlmostEndAheadTimeMs");
		AlmostEndAheadTimeMs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AlmostEndAheadTimeMs", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BeginFXs_PropertyAddress, unrealStruct, "BeginFXs");
		BeginFXs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginFXs");
		BeginFXs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginFXs", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref AlmostEndFXs_PropertyAddress, unrealStruct, "AlmostEndFXs");
		AlmostEndFXs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AlmostEndFXs");
		AlmostEndFXs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AlmostEndFXs", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref EndFXs_PropertyAddress, unrealStruct, "EndFXs");
		EndFXs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EndFXs");
		EndFXs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EndFXs", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref ExtraFXs_PropertyAddress, unrealStruct, "ExtraFXs");
		ExtraFXs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExtraFXs");
		ExtraFXs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExtraFXs", Classes.FArrayProperty);
		TargetFilter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetFilter");
		TargetFilter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetFilter", Classes.FIntProperty);
		TargetTypeFilter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetTypeFilter");
		TargetTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetTypeFilter", Classes.FIntProperty);
		AffiliationTypeFilter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AffiliationTypeFilter");
		AffiliationTypeFilter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AffiliationTypeFilter", Classes.FIntProperty);
		TargetCount_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetCount");
		TargetCount_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetCount", Classes.FIntProperty);
		RangeRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RangeRadius");
		RangeRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RangeRadius", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BeginBuffIDs_PropertyAddress, unrealStruct, "BeginBuffIDs");
		BeginBuffIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginBuffIDs");
		BeginBuffIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginBuffIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BeginSkillEffectIDs_PropertyAddress, unrealStruct, "BeginSkillEffectIDs");
		BeginSkillEffectIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginSkillEffectIDs");
		BeginSkillEffectIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginSkillEffectIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BreakBuffIDs_PropertyAddress, unrealStruct, "BreakBuffIDs");
		BreakBuffIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BreakBuffIDs");
		BreakBuffIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BreakBuffIDs", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BreakSkillEffectIDs_PropertyAddress, unrealStruct, "BreakSkillEffectIDs");
		BreakSkillEffectIDs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BreakSkillEffectIDs");
		BreakSkillEffectIDs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BreakSkillEffectIDs", Classes.FArrayProperty);
	}

	static UBGWImmobilizeConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UBGWImmobilizeConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWImmobilizeConfig));
	}
}
