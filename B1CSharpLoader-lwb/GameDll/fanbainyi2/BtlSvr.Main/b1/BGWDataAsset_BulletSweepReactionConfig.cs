using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig")]
public class BGWDataAsset_BulletSweepReactionConfig : UBGWDataAsset
{
	private static bool UseBeHitedReactionConfig_IsValid;

	private static int UseBeHitedReactionConfig_Offset;

	private static FFieldAddress UseBeHitedReactionConfig_PropertyAddress;

	private static bool BulletBeHitedReactionConfigInfo_IsValid;

	private static int BulletBeHitedReactionConfigInfo_Offset;

	private static FFieldAddress BulletBeHitedReactionConfigInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<BulletBeAttackedReactionInfo> BulletBeHitedReactionConfigInfo_Marshaler;

	private static bool UseSweepBuffReactionConfig_IsValid;

	private static int UseSweepBuffReactionConfig_Offset;

	private static FFieldAddress UseSweepBuffReactionConfig_PropertyAddress;

	private static bool BulletSweepBuffReactionConfigInfo_IsValid;

	private static int BulletSweepBuffReactionConfigInfo_Offset;

	private static FFieldAddress BulletSweepBuffReactionConfigInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<BulletSweepReactionInfo> BulletSweepBuffReactionConfigInfo_Marshaler;

	private static bool UseSweepSimpleStateReactionConfig_IsValid;

	private static int UseSweepSimpleStateReactionConfig_Offset;

	private static FFieldAddress UseSweepSimpleStateReactionConfig_PropertyAddress;

	private static bool BulletSweepSimpleStateReactionConfigInfo_IsValid;

	private static int BulletSweepSimpleStateReactionConfigInfo_Offset;

	private static FFieldAddress BulletSweepSimpleStateReactionConfigInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<BulletSweepSimpleStateReactionInfo> BulletSweepSimpleStateReactionConfigInfo_Marshaler;

	[DisplayName("使用子弹被命中时触发效果")]
	[BlueprintReadWrite]
	[Category("BeHited Reaction Config")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:UseBeHitedReactionConfig")]
	public bool UseBeHitedReactionConfig
	{
		get
		{
			CheckDestroyed();
			if (!UseBeHitedReactionConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:UseBeHitedReactionConfig");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseBeHitedReactionConfig_Offset), 0, UseBeHitedReactionConfig_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseBeHitedReactionConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:UseBeHitedReactionConfig");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseBeHitedReactionConfig_Offset), 0, UseBeHitedReactionConfig_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("子弹被命中触发效果配置")]
	[Category("BeHited Reaction Config")]
	[UMeta(MDProp.EditCondition, "UseBeHitedReactionConfig")]
	[Tooltip("触发条件ID用于筛选命中子弹的EffectID，被对应的Effect命中子弹会触发对应效果；特殊情况：若触发条件ID为0，意味着不进行Effect筛选，任意Effect命中子弹都会触发该效果")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:BulletBeHitedReactionConfigInfo")]
	public TArrayReadWrite<BulletBeAttackedReactionInfo> BulletBeHitedReactionConfigInfo
	{
		get
		{
			CheckDestroyed();
			if (!BulletBeHitedReactionConfigInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:BulletBeHitedReactionConfigInfo");
				return null;
			}
			if (BulletBeHitedReactionConfigInfo_Marshaler == null)
			{
				BulletBeHitedReactionConfigInfo_Marshaler = new TArrayReadWriteMarshaler<BulletBeAttackedReactionInfo>(1, BulletBeHitedReactionConfigInfo_PropertyAddress, CachedMarshalingDelegates<BulletBeAttackedReactionInfo, BulletBeAttackedReactionInfo>.FromNative, CachedMarshalingDelegates<BulletBeAttackedReactionInfo, BulletBeAttackedReactionInfo>.ToNative);
			}
			return BulletBeHitedReactionConfigInfo_Marshaler.FromNative(IntPtr.Add(base.Address, BulletBeHitedReactionConfigInfo_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("Sweep Buff Reaction Config")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("使用子弹命中单位Buff触发效果")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:UseSweepBuffReactionConfig")]
	public bool UseSweepBuffReactionConfig
	{
		get
		{
			CheckDestroyed();
			if (!UseSweepBuffReactionConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:UseSweepBuffReactionConfig");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSweepBuffReactionConfig_Offset), 0, UseSweepBuffReactionConfig_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSweepBuffReactionConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:UseSweepBuffReactionConfig");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSweepBuffReactionConfig_Offset), 0, UseSweepBuffReactionConfig_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("子弹命中Buff触发效果配置")]
	[Category("Sweep Buff Reaction Config")]
	[Tooltip("触发条件ID用于筛选子弹命中的目标所持有的BuffID，目标持有的BuffID会触发对应效果")]
	[UMeta(MDProp.EditCondition, "UseSweepBuffReactionConfig")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:BulletSweepBuffReactionConfigInfo")]
	public TArrayReadWrite<BulletSweepReactionInfo> BulletSweepBuffReactionConfigInfo
	{
		get
		{
			CheckDestroyed();
			if (!BulletSweepBuffReactionConfigInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:BulletSweepBuffReactionConfigInfo");
				return null;
			}
			if (BulletSweepBuffReactionConfigInfo_Marshaler == null)
			{
				BulletSweepBuffReactionConfigInfo_Marshaler = new TArrayReadWriteMarshaler<BulletSweepReactionInfo>(1, BulletSweepBuffReactionConfigInfo_PropertyAddress, CachedMarshalingDelegates<BulletSweepReactionInfo, BulletSweepReactionInfo>.FromNative, CachedMarshalingDelegates<BulletSweepReactionInfo, BulletSweepReactionInfo>.ToNative);
			}
			return BulletSweepBuffReactionConfigInfo_Marshaler.FromNative(IntPtr.Add(base.Address, BulletSweepBuffReactionConfigInfo_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("使用子弹命中单位SimpleState触发效果")]
	[UProperty]
	[Category("Sweep SimpleState Reaction Config")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:UseSweepSimpleStateReactionConfig")]
	public bool UseSweepSimpleStateReactionConfig
	{
		get
		{
			CheckDestroyed();
			if (!UseSweepSimpleStateReactionConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:UseSweepSimpleStateReactionConfig");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSweepSimpleStateReactionConfig_Offset), 0, UseSweepSimpleStateReactionConfig_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSweepSimpleStateReactionConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:UseSweepSimpleStateReactionConfig");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSweepSimpleStateReactionConfig_Offset), 0, UseSweepSimpleStateReactionConfig_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("子弹命中SimpleState触发效果配置")]
	[Tooltip("触发条件ID用于筛选子弹命中的目标所持有的SimpleStateID，目标持有的SimpleState会触发对应效果")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("Sweep SimpleState Reaction Config")]
	[UMeta(MDProp.EditCondition, "UseSweepSimpleStateReactionConfig")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:BulletSweepSimpleStateReactionConfigInfo")]
	public TArrayReadWrite<BulletSweepSimpleStateReactionInfo> BulletSweepSimpleStateReactionConfigInfo
	{
		get
		{
			CheckDestroyed();
			if (!BulletSweepSimpleStateReactionConfigInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig:BulletSweepSimpleStateReactionConfigInfo");
				return null;
			}
			if (BulletSweepSimpleStateReactionConfigInfo_Marshaler == null)
			{
				BulletSweepSimpleStateReactionConfigInfo_Marshaler = new TArrayReadWriteMarshaler<BulletSweepSimpleStateReactionInfo>(1, BulletSweepSimpleStateReactionConfigInfo_PropertyAddress, CachedMarshalingDelegates<BulletSweepSimpleStateReactionInfo, BulletSweepSimpleStateReactionInfo>.FromNative, CachedMarshalingDelegates<BulletSweepSimpleStateReactionInfo, BulletSweepSimpleStateReactionInfo>.ToNative);
			}
			return BulletSweepSimpleStateReactionConfigInfo_Marshaler.FromNative(IntPtr.Add(base.Address, BulletSweepSimpleStateReactionConfigInfo_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_BulletSweepReactionConfig");
		NativeReflection.GetPropertyRef(ref UseBeHitedReactionConfig_PropertyAddress, unrealStruct, "UseBeHitedReactionConfig");
		UseBeHitedReactionConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseBeHitedReactionConfig");
		UseBeHitedReactionConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseBeHitedReactionConfig", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BulletBeHitedReactionConfigInfo_PropertyAddress, unrealStruct, "BulletBeHitedReactionConfigInfo");
		BulletBeHitedReactionConfigInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BulletBeHitedReactionConfigInfo");
		BulletBeHitedReactionConfigInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BulletBeHitedReactionConfigInfo", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UseSweepBuffReactionConfig_PropertyAddress, unrealStruct, "UseSweepBuffReactionConfig");
		UseSweepBuffReactionConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseSweepBuffReactionConfig");
		UseSweepBuffReactionConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseSweepBuffReactionConfig", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BulletSweepBuffReactionConfigInfo_PropertyAddress, unrealStruct, "BulletSweepBuffReactionConfigInfo");
		BulletSweepBuffReactionConfigInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BulletSweepBuffReactionConfigInfo");
		BulletSweepBuffReactionConfigInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BulletSweepBuffReactionConfigInfo", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref UseSweepSimpleStateReactionConfig_PropertyAddress, unrealStruct, "UseSweepSimpleStateReactionConfig");
		UseSweepSimpleStateReactionConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseSweepSimpleStateReactionConfig");
		UseSweepSimpleStateReactionConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseSweepSimpleStateReactionConfig", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BulletSweepSimpleStateReactionConfigInfo_PropertyAddress, unrealStruct, "BulletSweepSimpleStateReactionConfigInfo");
		BulletSweepSimpleStateReactionConfigInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BulletSweepSimpleStateReactionConfigInfo");
		BulletSweepSimpleStateReactionConfigInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BulletSweepSimpleStateReactionConfigInfo", Classes.FArrayProperty);
	}

	static BGWDataAsset_BulletSweepReactionConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_BulletSweepReactionConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_BulletSweepReactionConfig));
	}
}
