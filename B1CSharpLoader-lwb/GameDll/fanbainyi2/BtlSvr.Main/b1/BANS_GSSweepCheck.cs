using System;
using System.Collections.Generic;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Sweep Check")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck")]
public class BANS_GSSweepCheck : BANS_GSBase
{
	private Dictionary<int, FUStCheckTransformArray> SweepCheckPreTransformMap;

	private static bool WeaponIndex_IsValid;

	private static int WeaponIndex_Offset;

	private static bool SweepCheckShape_IsValid;

	private static int SweepCheckShape_Offset;

	private static FFieldAddress SweepCheckShape_PropertyAddress;

	private TArrayReadWriteMarshaler<FUStCheckShape> SweepCheckShape_Marshaler;

	private static bool SweepCheckShapeExtend_IsValid;

	private static int SweepCheckShapeExtend_Offset;

	private static FFieldAddress SweepCheckShapeExtend_PropertyAddress;

	private TArrayReadWriteMarshaler<int> SweepCheckShapeExtend_Marshaler;

	private static bool bForceUpdateDescData_IsValid;

	private static int bForceUpdateDescData_Offset;

	private static FFieldAddress bForceUpdateDescData_PropertyAddress;

	private static bool AbnormalStateEffectList_IsValid;

	private static int AbnormalStateEffectList_Offset;

	private static FFieldAddress AbnormalStateEffectList_PropertyAddress;

	private TArrayReadWriteMarshaler<AbnormalStateAccConfig> AbnormalStateEffectList_Marshaler;

	private static bool EffectsWithCondition_Before_IsValid;

	private static int EffectsWithCondition_Before_Offset;

	private static FFieldAddress EffectsWithCondition_Before_PropertyAddress;

	private TArrayReadWriteMarshaler<FTriggerEffectWithCondition> EffectsWithCondition_Before_Marshaler;

	private static bool EffectIDList_IsValid;

	private static int EffectIDList_Offset;

	private static FFieldAddress EffectIDList_PropertyAddress;

	private TArrayReadWriteMarshaler<int> EffectIDList_Marshaler;

	private static bool EffectsWithCondition_After_IsValid;

	private static int EffectsWithCondition_After_Offset;

	private static FFieldAddress EffectsWithCondition_After_PropertyAddress;

	private TArrayReadWriteMarshaler<FTriggerEffectWithCondition> EffectsWithCondition_After_Marshaler;

	private static bool EffectIDListForSceneItem_IsValid;

	private static int EffectIDListForSceneItem_Offset;

	private static FFieldAddress EffectIDListForSceneItem_PropertyAddress;

	private TArrayReadWriteMarshaler<int> EffectIDListForSceneItem_Marshaler;

	private static bool HitChrAudioID_IsValid;

	private static int HitChrAudioID_Offset;

	private static bool HitChrFXWeight_IsValid;

	private static int HitChrFXWeight_Offset;

	private static bool HitCheckConf_IsValid;

	private static int HitCheckConf_Offset;

	private static bool CanHitBackBullet_IsValid;

	private static int CanHitBackBullet_Offset;

	private static FFieldAddress CanHitBackBullet_PropertyAddress;

	private static bool HitDestructibleConfig_IsValid;

	private static int HitDestructibleConfig_Offset;

	private static bool AtkReboundingAM_IsValid;

	private static int AtkReboundingAM_Offset;

	private static bool LowAtkReboundingAM_IsValid;

	private static int LowAtkReboundingAM_Offset;

	private static bool SweepCheckGroupID_IsValid;

	private static int SweepCheckGroupID_Offset;

	private static bool HasAbnormalStateData_IsValid;

	private static IntPtr HasAbnormalStateData_FunctionAddress;

	private static int HasAbnormalStateData_ParamsSize;

	private static bool HasAbnormalStateData_ReturnValue_IsValid;

	private static int HasAbnormalStateData_ReturnValue_Offset;

	private static FFieldAddress HasAbnormalStateData_ReturnValue_PropertyAddress;

	private static bool ResetSweepCheckChanel_IsValid;

	private static IntPtr ResetSweepCheckChanel_FunctionAddress;

	private static int ResetSweepCheckChanel_ParamsSize;

	private static bool ResetSweepCheckChanel_NewCollisionChanel_IsValid;

	private static int ResetSweepCheckChanel_NewCollisionChanel_Offset;

	private static FFieldAddress ResetSweepCheckChanel_NewCollisionChanel_PropertyAddress;

	private static bool ReplaceEffectIDByPreID_IsValid;

	private static IntPtr ReplaceEffectIDByPreID_FunctionAddress;

	private static int ReplaceEffectIDByPreID_ParamsSize;

	private static bool ReplaceEffectIDByPreID_OldPreID_IsValid;

	private static int ReplaceEffectIDByPreID_OldPreID_Offset;

	private static bool ReplaceEffectIDByPreID_NewPreID_IsValid;

	private static int ReplaceEffectIDByPreID_NewPreID_Offset;

	private static bool ReplaceEffectIDByPreID_ReturnValue_IsValid;

	private static int ReplaceEffectIDByPreID_ReturnValue_Offset;

	private static FFieldAddress ReplaceEffectIDByPreID_ReturnValue_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool AddAssistBreakFrozenEffectID_IsValid;

	private static IntPtr AddAssistBreakFrozenEffectID_FunctionAddress;

	private static int AddAssistBreakFrozenEffectID_ParamsSize;

	private static bool AddAssistBreakFrozenEffectID_AssistBreakFrozenEffectID_IsValid;

	private static int AddAssistBreakFrozenEffectID_AssistBreakFrozenEffectID_Offset;

	private static bool AddAssistBreakFrozenEffectID_ReturnValue_IsValid;

	private static int AddAssistBreakFrozenEffectID_ReturnValue_Offset;

	private static FFieldAddress AddAssistBreakFrozenEffectID_ReturnValue_PropertyAddress;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GSValidateInputCS_IsValid;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_actor_IsValid;

	private static int GSValidateInputCS_actor_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SweepCheck")]
	[Tooltip("-1 is Body")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:WeaponIndex")]
	public int WeaponIndex
	{
		get
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:WeaponIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WeaponIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:WeaponIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WeaponIndex_Offset), value);
			}
		}
	}

	[Category("SweepCheck")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:SweepCheckShape")]
	public TArrayReadWrite<FUStCheckShape> SweepCheckShape
	{
		get
		{
			CheckDestroyed();
			if (!SweepCheckShape_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:SweepCheckShape");
				return null;
			}
			if (SweepCheckShape_Marshaler == null)
			{
				SweepCheckShape_Marshaler = new TArrayReadWriteMarshaler<FUStCheckShape>(1, SweepCheckShape_PropertyAddress, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.FromNative, CachedMarshalingDelegates<FUStCheckShape, FUStCheckShape>.ToNative);
			}
			return SweepCheckShape_Marshaler.FromNative(IntPtr.Add(base.Address, SweepCheckShape_Offset));
		}
	}

	[Category("SweepCheck")]
	[Tooltip("SweepCheck拓展支持索引扫地僧配置表的数据")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:SweepCheckShapeExtend")]
	public TArrayReadWrite<int> SweepCheckShapeExtend
	{
		get
		{
			CheckDestroyed();
			if (!SweepCheckShapeExtend_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:SweepCheckShapeExtend");
				return null;
			}
			if (SweepCheckShapeExtend_Marshaler == null)
			{
				SweepCheckShapeExtend_Marshaler = new TArrayReadWriteMarshaler<int>(1, SweepCheckShapeExtend_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return SweepCheckShapeExtend_Marshaler.FromNative(IntPtr.Add(base.Address, SweepCheckShapeExtend_Offset));
		}
	}

	[BlueprintReadWrite]
	[Category("SweepCheck")]
	[Tooltip("强制刷新SweepCheckDesc表格数据，用于可视化SweepCheckShapeExtend")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:bForceUpdateDescData")]
	public bool bForceUpdateDescData
	{
		get
		{
			CheckDestroyed();
			if (!bForceUpdateDescData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:bForceUpdateDescData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bForceUpdateDescData_Offset), 0, bForceUpdateDescData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bForceUpdateDescData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:bForceUpdateDescData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bForceUpdateDescData_Offset), 0, bForceUpdateDescData_PropertyAddress.Address, value);
			}
		}
	}

	[Category("SweepCheck")]
	[DisplayName("附加异常属性积累")]
	[Tooltip("顺序说明：最优先触发并附加异常属性")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:AbnormalStateEffectList")]
	public TArrayReadWrite<AbnormalStateAccConfig> AbnormalStateEffectList
	{
		get
		{
			CheckDestroyed();
			if (!AbnormalStateEffectList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:AbnormalStateEffectList");
				return null;
			}
			if (AbnormalStateEffectList_Marshaler == null)
			{
				AbnormalStateEffectList_Marshaler = new TArrayReadWriteMarshaler<AbnormalStateAccConfig>(1, AbnormalStateEffectList_PropertyAddress, CachedMarshalingDelegates<AbnormalStateAccConfig, AbnormalStateAccConfig>.FromNative, CachedMarshalingDelegates<AbnormalStateAccConfig, AbnormalStateAccConfig>.ToNative);
			}
			return AbnormalStateEffectList_Marshaler.FromNative(IntPtr.Add(base.Address, AbnormalStateEffectList_Offset));
		}
	}

	[Tooltip("于EffectIDList触发之前触发结算")]
	[Category("SweepCheck")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("带条件触发效果列表_Before")]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:EffectsWithCondition_Before")]
	public TArrayReadWrite<FTriggerEffectWithCondition> EffectsWithCondition_Before
	{
		get
		{
			CheckDestroyed();
			if (!EffectsWithCondition_Before_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:EffectsWithCondition_Before");
				return null;
			}
			if (EffectsWithCondition_Before_Marshaler == null)
			{
				EffectsWithCondition_Before_Marshaler = new TArrayReadWriteMarshaler<FTriggerEffectWithCondition>(1, EffectsWithCondition_Before_PropertyAddress, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.FromNative, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.ToNative);
			}
			return EffectsWithCondition_Before_Marshaler.FromNative(IntPtr.Add(base.Address, EffectsWithCondition_Before_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[Category("SweepCheck")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:EffectIDList")]
	public TArrayReadWrite<int> EffectIDList
	{
		get
		{
			CheckDestroyed();
			if (!EffectIDList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:EffectIDList");
				return null;
			}
			if (EffectIDList_Marshaler == null)
			{
				EffectIDList_Marshaler = new TArrayReadWriteMarshaler<int>(1, EffectIDList_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return EffectIDList_Marshaler.FromNative(IntPtr.Add(base.Address, EffectIDList_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("于EffectIDList触发之后触发结算")]
	[DisplayName("带条件触发效果列表_After")]
	[Category("SweepCheck")]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:EffectsWithCondition_After")]
	public TArrayReadWrite<FTriggerEffectWithCondition> EffectsWithCondition_After
	{
		get
		{
			CheckDestroyed();
			if (!EffectsWithCondition_After_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:EffectsWithCondition_After");
				return null;
			}
			if (EffectsWithCondition_After_Marshaler == null)
			{
				EffectsWithCondition_After_Marshaler = new TArrayReadWriteMarshaler<FTriggerEffectWithCondition>(1, EffectsWithCondition_After_PropertyAddress, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.FromNative, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.ToNative);
			}
			return EffectsWithCondition_After_Marshaler.FromNative(IntPtr.Add(base.Address, EffectsWithCondition_After_Offset));
		}
	}

	[Category("SweepCheck")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:EffectIDListForSceneItem")]
	public TArrayReadWrite<int> EffectIDListForSceneItem
	{
		get
		{
			CheckDestroyed();
			if (!EffectIDListForSceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:EffectIDListForSceneItem");
				return null;
			}
			if (EffectIDListForSceneItem_Marshaler == null)
			{
				EffectIDListForSceneItem_Marshaler = new TArrayReadWriteMarshaler<int>(1, EffectIDListForSceneItem_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return EffectIDListForSceneItem_Marshaler.FromNative(IntPtr.Add(base.Address, EffectIDListForSceneItem_Offset));
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("攻击命中音效BaseID")]
	[Category("SweepCheck")]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:HitChrAudioID")]
	public int HitChrAudioID
	{
		get
		{
			CheckDestroyed();
			if (!HitChrAudioID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:HitChrAudioID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HitChrAudioID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitChrAudioID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:HitChrAudioID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HitChrAudioID_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, 9)]
	[UProperty]
	[DisplayName("攻击命中特效挡位")]
	[Category("SweepCheck")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:HitChrFXWeight")]
	public int HitChrFXWeight
	{
		get
		{
			CheckDestroyed();
			if (!HitChrFXWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:HitChrFXWeight");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, HitChrFXWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitChrFXWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:HitChrFXWeight");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, HitChrFXWeight_Offset), value);
			}
		}
	}

	[Category("SweepCheck")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:HitCheckConf")]
	public FHitCheckConf HitCheckConf
	{
		get
		{
			CheckDestroyed();
			if (!HitCheckConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:HitCheckConf");
				return default(FHitCheckConf);
			}
			return FHitCheckConf.FromNative(IntPtr.Add(base.Address, HitCheckConf_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitCheckConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:HitCheckConf");
			}
			else
			{
				FHitCheckConf.ToNative(IntPtr.Add(base.Address, HitCheckConf_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("可以命中抛射物")]
	[Category("SweepCheck")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:CanHitBackBullet")]
	public bool CanHitBackBullet
	{
		get
		{
			CheckDestroyed();
			if (!CanHitBackBullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:CanHitBackBullet");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, CanHitBackBullet_Offset), 0, CanHitBackBullet_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CanHitBackBullet_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:CanHitBackBullet");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, CanHitBackBullet_Offset), 0, CanHitBackBullet_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("命中破碎物效果")]
	[Category("SweepCheck")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:HitDestructibleConfig")]
	public FHitDestructibleActorConfig HitDestructibleConfig
	{
		get
		{
			CheckDestroyed();
			if (!HitDestructibleConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:HitDestructibleConfig");
				return default(FHitDestructibleActorConfig);
			}
			return FHitDestructibleActorConfig.FromNative(IntPtr.Add(base.Address, HitDestructibleConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HitDestructibleConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:HitDestructibleConfig");
			}
			else
			{
				FHitDestructibleActorConfig.ToNative(IntPtr.Add(base.Address, HitDestructibleConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SweepCheck")]
	[DisplayName("指定弹刀动画")]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:AtkReboundingAM")]
	public UAnimMontage AtkReboundingAM
	{
		get
		{
			CheckDestroyed();
			if (!AtkReboundingAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:AtkReboundingAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, AtkReboundingAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AtkReboundingAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:AtkReboundingAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, AtkReboundingAM_Offset), value);
			}
		}
	}

	[DisplayName("指定小弹刀动画")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("SweepCheck")]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:LowAtkReboundingAM")]
	public UAnimMontage LowAtkReboundingAM
	{
		get
		{
			CheckDestroyed();
			if (!LowAtkReboundingAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:LowAtkReboundingAM");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, LowAtkReboundingAM_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LowAtkReboundingAM_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:LowAtkReboundingAM");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, LowAtkReboundingAM_Offset), value);
			}
		}
	}

	[Category("SweepCheck")]
	[DisplayName("SweepCheck编组ID")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:SweepCheckGroupID")]
	public int SweepCheckGroupID
	{
		get
		{
			CheckDestroyed();
			if (!SweepCheckGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:SweepCheckGroupID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SweepCheckGroupID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SweepCheckGroupID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSweepCheck:SweepCheckGroupID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SweepCheckGroupID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.AnimNSType = EGsEnAnimNS.SweepCheck;
		WeaponIndex = -1;
		HitCheckConf = new FHitCheckConf(EHitActionDir.Default, ESweepCheckHitFilterType.NotInSameTeam, IsRenderDebugShape: false);
		HitDestructibleConfig = new FHitDestructibleActorConfig(EGSHitDestructibleStrengthLevel.Light, EGSHitDestructibleDirection.AttackerRelativeDirection);
		SweepCheckGroupID = -1;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:ResetSweepCheckChanel")]
	public void ResetSweepCheckChanel(ECollisionChannel NewCollisionChanel)
	{
		FHitCheckConf fHitCheckConf = default(FHitCheckConf);
		fHitCheckConf = HitCheckConf;
		HitCheckConf = fHitCheckConf;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:HasAbnormalStateData")]
	public bool HasAbnormalStateData()
	{
		if (AbnormalStateEffectList.Count > 0)
		{
			return true;
		}
		return false;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:AddAssistBreakFrozenEffectID")]
	public bool AddAssistBreakFrozenEffectID(int AssistBreakFrozenEffectID)
	{
		if (EffectIDList.Contains(AssistBreakFrozenEffectID))
		{
			return false;
		}
		BGUFuncLibNonRuntime.LoadProtobufData<FUStSkillEffectDesc>();
		bool flag = false;
		foreach (int effectID in EffectIDList)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(effectID, null);
			if (skillEffectDesc != null && skillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
			{
				flag = true;
				break;
			}
		}
		if (flag)
		{
			FHitCheckConf fHitCheckConf = default(FHitCheckConf);
			fHitCheckConf = HitCheckConf;
			fHitCheckConf.ResultFilterType = ESweepCheckHitFilterType.Zero;
			HitCheckConf = fHitCheckConf;
			EffectIDList.Add(AssistBreakFrozenEffectID);
			return true;
		}
		return false;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:ReplaceEffectIDByPreID")]
	public bool ReplaceEffectIDByPreID(int OldPreID, int NewPreID)
	{
		bool result = false;
		string text = OldPreID.ToString();
		string text2 = NewPreID.ToString();
		for (int i = 0; i < EffectIDList.Count; i++)
		{
			string text3 = EffectIDList[i].ToString();
			if (text3.Length >= text.Length && text3.StartsWith(text))
			{
				string text4 = ((text3.Length > text.Length) ? text3.Substring(text.Length, text3.Length - text.Length) : "");
				if (int.TryParse(text2 + text4, out var result2))
				{
					EffectIDList[i] = result2;
					result = true;
				}
			}
		}
		return result;
	}

	public TArrayReadWrite<int> GetEffectIDList()
	{
		return EffectIDList;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		int fromInstanceID = NotifyParam.FromInstanceID;
		int uniqueID = (int)GetUniqueID();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_SweepCheckBegin.Invoke(uniqueID, WeaponIndex, WrapCheckShapeList(NotifyParam.owner), EffectIDList.ToList(), AbnormalStateEffectList.ToList(), EffectIDListForSceneItem.ToList(), HitDestructibleConfig, HitChrAudioID, HitChrFXWeight, HitCheckConf, CanHitBackBullet, TotalDuration, NotifyParam.Animation, AtkReboundingAM, LowAtkReboundingAM, SweepCheckGroupID, fromInstanceID, EffectsWithCondition_Before.ToList(), EffectsWithCondition_After.ToList(), NotifyParam.NotifyBeginTime);
		}
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World))
		{
			SweepCheckPreTransformMap = new Dictionary<int, FUStCheckTransformArray>();
			if (!SweepCheckPreTransformMap.ContainsKey(fromInstanceID))
			{
				FUStCheckTransformArray value = new FUStCheckTransformArray
				{
					TransformList = new List<FTransform>()
				};
				SweepCheckPreTransformMap.Add(fromInstanceID, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World))
		{
			SweepCheckShowDebugInfo(NotifyParam.World, NotifyParam.owner, NotifyParam.FromInstanceID, NotifyParam.MeshComp);
			if (bForceUpdateDescData)
			{
				BGUFuncLibNonRuntime.LoadProtobufDataNoneRunTime_SweepCheckDesc();
				bForceUpdateDescData = false;
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		int fromInstanceID = NotifyParam.FromInstanceID;
		int uniqueID = (int)GetUniqueID();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(NotifyParam.owner);
		if (bUS_GSEventCollection != null)
		{
			bUS_GSEventCollection.Evt_SweepCheckEnd.Invoke(uniqueID, fromInstanceID, NotifyParam.NotifyEndTime);
		}
	}

	private List<FUStCheckShape> WrapCheckShapeList(AActor Owner)
	{
		List<FUStCheckShape> list = new List<FUStCheckShape>();
		if (WeaponIndex < 0)
		{
			foreach (FUStCheckShape item2 in SweepCheckShape)
			{
				FUStCheckShape fUStCheckShape = default(FUStCheckShape);
				fUStCheckShape = item2;
				fUStCheckShape.SKComp = BGU_ObjActorUtil.GetSocketBelongToSKComp(Owner as ACharacter, item2.SocketName);
				list.Add(fUStCheckShape);
			}
			foreach (int item3 in SweepCheckShapeExtend)
			{
				FUStSweepCheckDesc sweepCheckDesc = BGW_GameDB.GetSweepCheckDesc(item3);
				if (sweepCheckDesc != null)
				{
					FUStCheckShape item = default(FUStCheckShape);
					item.Radius = sweepCheckDesc.Radius;
					item.SocketName = new FName(sweepCheckDesc.SocketName);
					item.SKComp = BGU_ObjActorUtil.GetSocketBelongToSKComp(Owner as ACharacter, item.SocketName);
					list.Add(item);
				}
			}
		}
		else
		{
			BGUWeaponBase bGUWeaponBase = BGUFunctionLibraryCS.BGUGetWeaponByIndex(Owner, WeaponIndex) as BGUWeaponBase;
			if (bGUWeaponBase != null)
			{
				if (!BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_WeaponCommData, BUC_WeaponCommData>(bGUWeaponBase).bIsActive)
				{
					BGW_LogUtil.LogError("ERROR: Current sweep check will not work as weapon with index " + WeaponIndex + " is not active! Please verify sweep check notifystate!");
					return list;
				}
				foreach (FUStCheckShape item4 in SweepCheckShape)
				{
					FUStCheckShape fUStCheckShape2 = default(FUStCheckShape);
					fUStCheckShape2 = item4;
					fUStCheckShape2.SKComp = bGUWeaponBase.SkeletalMeshComp;
					list.Add(fUStCheckShape2);
				}
				foreach (int item5 in SweepCheckShapeExtend)
				{
					FUStSweepCheckDesc sweepCheckDesc2 = BGW_GameDB.GetSweepCheckDesc(item5);
					if (sweepCheckDesc2 != null)
					{
						list.Add(new FUStCheckShape
						{
							Radius = sweepCheckDesc2.Radius,
							SocketName = new FName(sweepCheckDesc2.SocketName),
							SKComp = bGUWeaponBase.SkeletalMeshComp
						});
					}
				}
			}
		}
		return list;
	}

	private AActor GSGetActorByTag(UWorld World, FName TagName)
	{
		UGameplayStatics.GetAllActorsOfClass(World, UClass.GetClass<AActor>(), out var OutActors);
		foreach (AActor item in OutActors)
		{
			if (item.ActorHasTag(TagName))
			{
				return item;
			}
		}
		return null;
	}

	private void InitSetPreCheckTransform(USkeletalMeshComponent MeshComp, List<FTransform> SweepCheckPreTransform)
	{
		for (int i = 0; i < SweepCheckShape.Count; i++)
		{
			SweepCheckPreTransform.Add(GetSocketWorldTransform(MeshComp, SweepCheckShape[i].SocketName));
		}
		foreach (int item in SweepCheckShapeExtend)
		{
			FUStSweepCheckDesc sweepCheckDesc = BGW_GameDB.GetSweepCheckDesc(item);
			if (sweepCheckDesc != null)
			{
				SweepCheckPreTransform.Add(GetSocketWorldTransform(MeshComp, new FName(sweepCheckDesc.SocketName)));
			}
		}
	}

	private FTransform GetSocketWorldTransform(USkeletalMeshComponent MeshComp, FName SocketName)
	{
		FTransform result = default(FTransform);
		result.SetTranslation(MeshComp.GetSocketLocation(SocketName));
		result.SetRotation(FQuat.MakeFromEuler(MeshComp.GetSocketRotation(SocketName).Euler()));
		return result;
	}

	private void SweepCheckShowDebugInfo(UWorld World, AActor Owner, int FromInstanceID, USkeletalMeshComponent MeshComp)
	{
		if (World == null || Owner == null || !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(World) || !HitCheckConf.IsRenderDebugShape || SweepCheckPreTransformMap == null || !SweepCheckPreTransformMap.ContainsKey(FromInstanceID))
		{
			return;
		}
		FUStCheckTransformArray fUStCheckTransformArray = new FUStCheckTransformArray
		{
			TransformList = new List<FTransform>()
		};
		fUStCheckTransformArray = SweepCheckPreTransformMap[FromInstanceID];
		if (fUStCheckTransformArray.TransformList == null)
		{
			return;
		}
		USkeletalMeshComponent uSkeletalMeshComponent = MeshComp;
		if (WeaponIndex == -1)
		{
			uSkeletalMeshComponent = MeshComp;
		}
		else
		{
			FName tagName = new FName("weapon_" + WeaponIndex);
			AActor aActor = GSGetActorByTag(World, tagName);
			if (aActor != null)
			{
				uSkeletalMeshComponent = aActor.GetComponentByClass<USkeletalMeshComponent>();
			}
		}
		if (uSkeletalMeshComponent == null)
		{
			return;
		}
		List<FTransform> list = new List<FTransform>();
		list = fUStCheckTransformArray.TransformList;
		if (list != null && list.Count < 1)
		{
			InitSetPreCheckTransform(uSkeletalMeshComponent, list);
		}
		if (EffectIDList.Count < 0)
		{
			return;
		}
		new List<FUStGSHitResult>();
		int count = SweepCheckShape.Count;
		for (int i = 0; i < count; i++)
		{
			FUStCheckShape fUStCheckShape = SweepCheckShape[i];
			SweepCheckShowDebugInfoImpl(Owner, list[i], uSkeletalMeshComponent, fUStCheckShape.Radius, fUStCheckShape.SocketName, fUStCheckShape.Rotation, fUStCheckShape.Scale);
		}
		for (int j = 0; j < SweepCheckShapeExtend.Count; j++)
		{
			FUStSweepCheckDesc sweepCheckDesc = BGW_GameDB.GetSweepCheckDesc(SweepCheckShapeExtend[j]);
			if (sweepCheckDesc != null)
			{
				SweepCheckShowDebugInfoImpl(Owner, list[count + j], uSkeletalMeshComponent, sweepCheckDesc.Radius, new FName(sweepCheckDesc.SocketName), FVector.ZeroVector, FVector.ZeroVector);
			}
		}
	}

	private void SweepCheckShowDebugInfoImpl(AActor Owner, FTransform SweepCheckPreTransform, USkeletalMeshComponent MeshCompForGetSocketLocation, float Radius, FName SocketName, FVector Rotation, FVector Scale)
	{
		FTransform fTransform = SweepCheckPreTransform;
		FTransform socketWorldTransform = GetSocketWorldTransform(MeshCompForGetSocketLocation, SocketName);
		FTransform fTransform2 = socketWorldTransform;
		if ((socketWorldTransform.GetLocation() - fTransform.GetLocation()).Size() == 0f)
		{
			fTransform2.SetLocation(socketWorldTransform.GetLocation() + FVector.OneVector);
		}
		FGSSweepCheckShapeInfo sweepCheckShapeInfo = new FGSSweepCheckShapeInfo
		{
			SweepCheckShapeType = EGSSweepCheckShapeType.SphereShape,
			ShapeParamFloat = Radius * Owner.GetActorScale3D().X,
			ShapeParamVector = Scale
		};
		FQuat rotation = socketWorldTransform.Rotation;
		rotation *= new FQuat(new FVector(1.0, 0.0, 0.0), (float)Math.PI / (180f / Rotation.X));
		rotation *= new FQuat(new FVector(0.0, 1.0, 0.0), (float)Math.PI / (180f / Rotation.Y));
		rotation *= new FQuat(new FVector(0.0, 0.0, 1.0), (float)Math.PI / (180f / Rotation.Z));
		UBGUFunctionLibraryForCS.BGUDrawSweepCheckShape(Owner.World, socketWorldTransform.GetLocation(), rotation, sweepCheckShapeInfo);
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSweepCheck:GSValidateInputCS")]
	protected override void GSValidateInputCS_Implementation(AActor actor)
	{
		BGW_ValiDateMgr bGW_ValiDateMgr = BGW_ValiDateMgr.Get(actor.World);
		string pathName = GetOuter().GetPathName();
		string name = GetName();
		int num = 0;
		int num2 = 0;
		foreach (int effectID in EffectIDList)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(effectID, actor);
			if (skillEffectDesc == null)
			{
				string logStr = $"Montage（{pathName}）中的Notify（{name}）的EffectID（{effectID}）未在SkillEffect表中找到索引";
				bGW_ValiDateMgr.ShowValidateWindow(logStr);
				break;
			}
			if (skillEffectDesc.EffectType == EBuffAndSkillEffectType.SkillDamage)
			{
				num++;
				if (num > 1)
				{
					string logStr2 = $"Montage（{pathName}）中的Notify（{name}）的EffectIDList中只允许存在一个SkillDamage类型的Effect";
					bGW_ValiDateMgr.ShowValidateWindow(logStr2);
					break;
				}
				if (skillEffectDesc.EffectParamsInt.Count > 0)
				{
					num2++;
				}
			}
			if (skillEffectDesc.EffectType == EBuffAndSkillEffectType.AttackStiff)
			{
				num2++;
			}
			if (num2 > 1)
			{
				string logStr3 = $"Montage（{pathName}）中的Notify（{name}）的EffectList中存在多个硬直效果，请检查SkillDamage类型的整形参数1，以及AttackStiff类型的SkillEffect";
				bGW_ValiDateMgr.ShowValidateWindow(logStr3);
				break;
			}
			if (effectID <= 100101)
			{
				continue;
			}
			BGUCharacterCS bGUCharacterCS = actor as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				int resID = bGUCharacterCS.GetResID();
				int num3 = ((resID > 100) ? (effectID / 10000) : (effectID / 100000));
				if (num3 != resID)
				{
					string logStr4 = $"Montage（{pathName}）中的Notify（{GetName()}）的EffectID（{effectID}）未对应单位的ResID（{resID}）";
					bGW_ValiDateMgr.ShowValidateWindow(logStr4);
					break;
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSweepCheck:HasAbnormalStateData")]
	private static void HasAbnormalStateData__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSweepCheck bANS_GSSweepCheck = GCHelper.Find<BANS_GSSweepCheck>(obj);
		bool value = bANS_GSSweepCheck.HasAbnormalStateData();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, HasAbnormalStateData_ReturnValue_Offset), 0, HasAbnormalStateData_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSweepCheck:ResetSweepCheckChanel")]
	private static void ResetSweepCheckChanel__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSweepCheck bANS_GSSweepCheck = GCHelper.Find<BANS_GSSweepCheck>(obj);
		ECollisionChannel newCollisionChanel = EnumMarshaler<ECollisionChannel>.FromNative(IntPtr.Add(buffer, ResetSweepCheckChanel_NewCollisionChanel_Offset), 0, ResetSweepCheckChanel_NewCollisionChanel_PropertyAddress.Address);
		bANS_GSSweepCheck.ResetSweepCheckChanel(newCollisionChanel);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSweepCheck:ReplaceEffectIDByPreID")]
	private static void ReplaceEffectIDByPreID__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSweepCheck bANS_GSSweepCheck = GCHelper.Find<BANS_GSSweepCheck>(obj);
		int oldPreID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, ReplaceEffectIDByPreID_OldPreID_Offset));
		int newPreID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, ReplaceEffectIDByPreID_NewPreID_Offset));
		bool value = bANS_GSSweepCheck.ReplaceEffectIDByPreID(oldPreID, newPreID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ReplaceEffectIDByPreID_ReturnValue_Offset), 0, ReplaceEffectIDByPreID_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSweepCheck:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSweepCheck bANS_GSSweepCheck = GCHelper.Find<BANS_GSSweepCheck>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSweepCheck.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSweepCheck:AddAssistBreakFrozenEffectID")]
	private static void AddAssistBreakFrozenEffectID__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSweepCheck bANS_GSSweepCheck = GCHelper.Find<BANS_GSSweepCheck>(obj);
		int assistBreakFrozenEffectID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, AddAssistBreakFrozenEffectID_AssistBreakFrozenEffectID_Offset));
		bool value = bANS_GSSweepCheck.AddAssistBreakFrozenEffectID(assistBreakFrozenEffectID);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, AddAssistBreakFrozenEffectID_ReturnValue_Offset), 0, AddAssistBreakFrozenEffectID_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSweepCheck:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSweepCheck bANS_GSSweepCheck = GCHelper.Find<BANS_GSSweepCheck>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSSweepCheck.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSweepCheck:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSweepCheck bANS_GSSweepCheck = GCHelper.Find<BANS_GSSweepCheck>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSweepCheck.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSweepCheck:GSValidateInputCS")]
	private static void GSValidateInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSSweepCheck bANS_GSSweepCheck = GCHelper.Find<BANS_GSSweepCheck>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSValidateInputCS_actor_Offset));
		bANS_GSSweepCheck.GSValidateInputCS_Implementation(actor);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSweepCheck");
		WeaponIndex_Offset = NativeReflection.GetPropertyOffset(intPtr, "WeaponIndex");
		WeaponIndex_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WeaponIndex", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref SweepCheckShape_PropertyAddress, intPtr, "SweepCheckShape");
		SweepCheckShape_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepCheckShape");
		SweepCheckShape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepCheckShape", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref SweepCheckShapeExtend_PropertyAddress, intPtr, "SweepCheckShapeExtend");
		SweepCheckShapeExtend_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepCheckShapeExtend");
		SweepCheckShapeExtend_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepCheckShapeExtend", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref bForceUpdateDescData_PropertyAddress, intPtr, "bForceUpdateDescData");
		bForceUpdateDescData_Offset = NativeReflection.GetPropertyOffset(intPtr, "bForceUpdateDescData");
		bForceUpdateDescData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bForceUpdateDescData", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref AbnormalStateEffectList_PropertyAddress, intPtr, "AbnormalStateEffectList");
		AbnormalStateEffectList_Offset = NativeReflection.GetPropertyOffset(intPtr, "AbnormalStateEffectList");
		AbnormalStateEffectList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AbnormalStateEffectList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EffectsWithCondition_Before_PropertyAddress, intPtr, "EffectsWithCondition_Before");
		EffectsWithCondition_Before_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectsWithCondition_Before");
		EffectsWithCondition_Before_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectsWithCondition_Before", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EffectIDList_PropertyAddress, intPtr, "EffectIDList");
		EffectIDList_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectIDList");
		EffectIDList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectIDList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EffectsWithCondition_After_PropertyAddress, intPtr, "EffectsWithCondition_After");
		EffectsWithCondition_After_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectsWithCondition_After");
		EffectsWithCondition_After_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectsWithCondition_After", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EffectIDListForSceneItem_PropertyAddress, intPtr, "EffectIDListForSceneItem");
		EffectIDListForSceneItem_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectIDListForSceneItem");
		EffectIDListForSceneItem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectIDListForSceneItem", Classes.FArrayProperty);
		HitChrAudioID_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitChrAudioID");
		HitChrAudioID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitChrAudioID", Classes.FIntProperty);
		HitChrFXWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitChrFXWeight");
		HitChrFXWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitChrFXWeight", Classes.FIntProperty);
		HitCheckConf_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitCheckConf");
		HitCheckConf_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitCheckConf", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CanHitBackBullet_PropertyAddress, intPtr, "CanHitBackBullet");
		CanHitBackBullet_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanHitBackBullet");
		CanHitBackBullet_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanHitBackBullet", Classes.FBoolProperty);
		HitDestructibleConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "HitDestructibleConfig");
		HitDestructibleConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HitDestructibleConfig", Classes.FStructProperty);
		AtkReboundingAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "AtkReboundingAM");
		AtkReboundingAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AtkReboundingAM", Classes.FObjectProperty);
		LowAtkReboundingAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "LowAtkReboundingAM");
		LowAtkReboundingAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LowAtkReboundingAM", Classes.FObjectProperty);
		SweepCheckGroupID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepCheckGroupID");
		SweepCheckGroupID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepCheckGroupID", Classes.FIntProperty);
		HasAbnormalStateData_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasAbnormalStateData");
		HasAbnormalStateData_ParamsSize = NativeReflection.GetFunctionParamsSize(HasAbnormalStateData_FunctionAddress);
		NativeReflection.GetPropertyRef(ref HasAbnormalStateData_ReturnValue_PropertyAddress, HasAbnormalStateData_FunctionAddress, "ReturnValue");
		HasAbnormalStateData_ReturnValue_Offset = NativeReflection.GetPropertyOffset(HasAbnormalStateData_FunctionAddress, "ReturnValue");
		HasAbnormalStateData_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(HasAbnormalStateData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasAbnormalStateData_IsValid = HasAbnormalStateData_FunctionAddress != IntPtr.Zero && HasAbnormalStateData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSweepCheck:HasAbnormalStateData", HasAbnormalStateData_IsValid);
		ResetSweepCheckChanel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetSweepCheckChanel");
		ResetSweepCheckChanel_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetSweepCheckChanel_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ResetSweepCheckChanel_NewCollisionChanel_PropertyAddress, ResetSweepCheckChanel_FunctionAddress, "NewCollisionChanel");
		ResetSweepCheckChanel_NewCollisionChanel_Offset = NativeReflection.GetPropertyOffset(ResetSweepCheckChanel_FunctionAddress, "NewCollisionChanel");
		ResetSweepCheckChanel_NewCollisionChanel_IsValid = NativeReflection.ValidatePropertyClass(ResetSweepCheckChanel_FunctionAddress, "NewCollisionChanel", Classes.FEnumProperty);
		ResetSweepCheckChanel_IsValid = ResetSweepCheckChanel_FunctionAddress != IntPtr.Zero && ResetSweepCheckChanel_NewCollisionChanel_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSweepCheck:ResetSweepCheckChanel", ResetSweepCheckChanel_IsValid);
		ReplaceEffectIDByPreID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReplaceEffectIDByPreID");
		ReplaceEffectIDByPreID_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceEffectIDByPreID_FunctionAddress);
		ReplaceEffectIDByPreID_OldPreID_Offset = NativeReflection.GetPropertyOffset(ReplaceEffectIDByPreID_FunctionAddress, "OldPreID");
		ReplaceEffectIDByPreID_OldPreID_IsValid = NativeReflection.ValidatePropertyClass(ReplaceEffectIDByPreID_FunctionAddress, "OldPreID", Classes.FIntProperty);
		ReplaceEffectIDByPreID_NewPreID_Offset = NativeReflection.GetPropertyOffset(ReplaceEffectIDByPreID_FunctionAddress, "NewPreID");
		ReplaceEffectIDByPreID_NewPreID_IsValid = NativeReflection.ValidatePropertyClass(ReplaceEffectIDByPreID_FunctionAddress, "NewPreID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref ReplaceEffectIDByPreID_ReturnValue_PropertyAddress, ReplaceEffectIDByPreID_FunctionAddress, "ReturnValue");
		ReplaceEffectIDByPreID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ReplaceEffectIDByPreID_FunctionAddress, "ReturnValue");
		ReplaceEffectIDByPreID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ReplaceEffectIDByPreID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReplaceEffectIDByPreID_IsValid = ReplaceEffectIDByPreID_FunctionAddress != IntPtr.Zero && ReplaceEffectIDByPreID_OldPreID_IsValid && ReplaceEffectIDByPreID_NewPreID_IsValid && ReplaceEffectIDByPreID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSweepCheck:ReplaceEffectIDByPreID", ReplaceEffectIDByPreID_IsValid);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSweepCheck:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		AddAssistBreakFrozenEffectID_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddAssistBreakFrozenEffectID");
		AddAssistBreakFrozenEffectID_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAssistBreakFrozenEffectID_FunctionAddress);
		AddAssistBreakFrozenEffectID_AssistBreakFrozenEffectID_Offset = NativeReflection.GetPropertyOffset(AddAssistBreakFrozenEffectID_FunctionAddress, "AssistBreakFrozenEffectID");
		AddAssistBreakFrozenEffectID_AssistBreakFrozenEffectID_IsValid = NativeReflection.ValidatePropertyClass(AddAssistBreakFrozenEffectID_FunctionAddress, "AssistBreakFrozenEffectID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref AddAssistBreakFrozenEffectID_ReturnValue_PropertyAddress, AddAssistBreakFrozenEffectID_FunctionAddress, "ReturnValue");
		AddAssistBreakFrozenEffectID_ReturnValue_Offset = NativeReflection.GetPropertyOffset(AddAssistBreakFrozenEffectID_FunctionAddress, "ReturnValue");
		AddAssistBreakFrozenEffectID_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(AddAssistBreakFrozenEffectID_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddAssistBreakFrozenEffectID_IsValid = AddAssistBreakFrozenEffectID_FunctionAddress != IntPtr.Zero && AddAssistBreakFrozenEffectID_AssistBreakFrozenEffectID_IsValid && AddAssistBreakFrozenEffectID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSweepCheck:AddAssistBreakFrozenEffectID", AddAssistBreakFrozenEffectID_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSweepCheck:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSweepCheck:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		GSValidateInputCS_actor_Offset = NativeReflection.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflection.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSweepCheck:GSValidateInputCS", GSValidateInputCS_IsValid);
	}

	static BANS_GSSweepCheck()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSSweepCheck)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSSweepCheck));
	}
}
