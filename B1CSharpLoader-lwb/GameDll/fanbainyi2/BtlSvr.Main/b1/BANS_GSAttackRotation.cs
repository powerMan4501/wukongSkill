using System;
using System.Collections.Generic;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Attack Rotation")]
[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation")]
public class BANS_GSAttackRotation : BANS_GSBase
{
	private static bool IsRotateTraceCurrentTarget_IsValid;

	private static int IsRotateTraceCurrentTarget_Offset;

	private static FFieldAddress IsRotateTraceCurrentTarget_PropertyAddress;

	private static bool IsRotateTraceSceneItem_IsValid;

	private static int IsRotateTraceSceneItem_Offset;

	private static FFieldAddress IsRotateTraceSceneItem_PropertyAddress;

	private static bool NeedFindSceneItem_IsValid;

	private static int NeedFindSceneItem_Offset;

	private static FFieldAddress NeedFindSceneItem_PropertyAddress;

	private static bool SceneActorTags_IsValid;

	private static int SceneActorTags_Offset;

	private static FFieldAddress SceneActorTags_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SceneActorTags_Marshaler;

	private static bool MinDistance_IsValid;

	private static int MinDistance_Offset;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	private static bool FindSceneItemWay_IsValid;

	private static int FindSceneItemWay_Offset;

	private static FFieldAddress FindSceneItemWay_PropertyAddress;

	private static bool Angle_IsValid;

	private static int Angle_Offset;

	private static bool NeedRemoveCurrentCatch_IsValid;

	private static int NeedRemoveCurrentCatch_Offset;

	private static FFieldAddress NeedRemoveCurrentCatch_PropertyAddress;

	private static bool IsRotateTraceRegisteredPointCache_IsValid;

	private static int IsRotateTraceRegisteredPointCache_Offset;

	private static FFieldAddress IsRotateTraceRegisteredPointCache_PropertyAddress;

	private static bool OverlayRotateTraceTargetType_IsValid;

	private static int OverlayRotateTraceTargetType_Offset;

	private static FFieldAddress OverlayRotateTraceTargetType_PropertyAddress;

	private static bool PointsRegisterID_IsValid;

	private static int PointsRegisterID_Offset;

	private static bool RotateTraceSocketName_IsValid;

	private static int RotateTraceSocketName_Offset;

	private static bool RotateSpeed_IsValid;

	private static int RotateSpeed_Offset;

	private static bool RotateDirection_IsValid;

	private static int RotateDirection_Offset;

	private static FFieldAddress RotateDirection_PropertyAddress;

	private static bool MaxRotateAngle_IsValid;

	private static int MaxRotateAngle_Offset;

	private static bool bStillRotateWhenAboveMaxRotateAngle_IsValid;

	private static int bStillRotateWhenAboveMaxRotateAngle_Offset;

	private static FFieldAddress bStillRotateWhenAboveMaxRotateAngle_PropertyAddress;

	private static bool RotateDeflectionAngle_IsValid;

	private static int RotateDeflectionAngle_Offset;

	private static bool DeadzoneAngle_IsValid;

	private static int DeadzoneAngle_Offset;

	private static bool FootType_IsValid;

	private static int FootType_Offset;

	private static FFieldAddress FootType_PropertyAddress;

	private static bool IsRotateAroundLoc_IsValid;

	private static int IsRotateAroundLoc_Offset;

	private static FFieldAddress IsRotateAroundLoc_PropertyAddress;

	private static bool EnableDebug_IsValid;

	private static int EnableDebug_Offset;

	private static FFieldAddress EnableDebug_PropertyAddress;

	private static bool IsNeedForceRotateToSceneItemInEnd_IsValid;

	private static int IsNeedForceRotateToSceneItemInEnd_Offset;

	private static FFieldAddress IsNeedForceRotateToSceneItemInEnd_PropertyAddress;

	private static bool MarkDirty_IsValid;

	private static IntPtr MarkDirty_FunctionAddress;

	private static int MarkDirty_ParamsSize;

	private static bool MarkDirty_ReturnValue_IsValid;

	private static int MarkDirty_ReturnValue_Offset;

	private static FFieldAddress MarkDirty_ReturnValue_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GSAllowCrossSection_IsValid;

	private static IntPtr GSAllowCrossSection_FunctionAddress;

	private static int GSAllowCrossSection_ParamsSize;

	private static bool GSAllowCrossSection_ReturnValue_IsValid;

	private static int GSAllowCrossSection_ReturnValue_Offset;

	private static FFieldAddress GSAllowCrossSection_ReturnValue_PropertyAddress;

	private static bool GSOnSectionManuallyChanged_IsValid;

	private static IntPtr GSOnSectionManuallyChanged_FunctionAddress;

	private static int GSOnSectionManuallyChanged_ParamsSize;

	private static bool GSOnSectionManuallyChanged_OwnerChar_IsValid;

	private static int GSOnSectionManuallyChanged_OwnerChar_Offset;

	private static bool GSOnSectionManuallyChanged_RemainingDuration_IsValid;

	private static int GSOnSectionManuallyChanged_RemainingDuration_Offset;

	[DisplayName("转向当前目标")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "OverlayRotateTraceTargetType == ChangeTargetType::None")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateTraceCurrentTarget")]
	public bool IsRotateTraceCurrentTarget
	{
		get
		{
			CheckDestroyed();
			if (!IsRotateTraceCurrentTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateTraceCurrentTarget");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRotateTraceCurrentTarget_Offset), 0, IsRotateTraceCurrentTarget_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRotateTraceCurrentTarget_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateTraceCurrentTarget");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRotateTraceCurrentTarget_Offset), 0, IsRotateTraceCurrentTarget_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("转向缓存的SceneItem")]
	[UMeta(MDProp.EditCondition, "OverlayRotateTraceTargetType == ChangeTargetType::None")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateTraceSceneItem")]
	public bool IsRotateTraceSceneItem
	{
		get
		{
			CheckDestroyed();
			if (!IsRotateTraceSceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateTraceSceneItem");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRotateTraceSceneItem_Offset), 0, IsRotateTraceSceneItem_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRotateTraceSceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateTraceSceneItem");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRotateTraceSceneItem_Offset), 0, IsRotateTraceSceneItem_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "IsRotateTraceSceneItem")]
	[DisplayName("是否需要重新找SceneItem")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:NeedFindSceneItem")]
	public bool NeedFindSceneItem
	{
		get
		{
			CheckDestroyed();
			if (!NeedFindSceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:NeedFindSceneItem");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedFindSceneItem_Offset), 0, NeedFindSceneItem_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedFindSceneItem_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:NeedFindSceneItem");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedFindSceneItem_Offset), 0, NeedFindSceneItem_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsRotateTraceSceneItem")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:SceneActorTags")]
	public TArrayReadWrite<FName> SceneActorTags
	{
		get
		{
			CheckDestroyed();
			if (!SceneActorTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:SceneActorTags");
				return null;
			}
			if (SceneActorTags_Marshaler == null)
			{
				SceneActorTags_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SceneActorTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SceneActorTags_Marshaler.FromNative(IntPtr.Add(base.Address, SceneActorTags_Offset));
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsRotateTraceSceneItem")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:MinDistance")]
	public float MinDistance
	{
		get
		{
			CheckDestroyed();
			if (!MinDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:MinDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:MinDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDistance_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsRotateTraceSceneItem")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:MaxDistance")]
	public float MaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:MaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:MaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsRotateTraceSceneItem")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:FindSceneItemWay")]
	public EFindSceneItemWay FindSceneItemWay
	{
		get
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:FindSceneItemWay");
				return EFindSceneItemWay.FindNearest;
			}
			return EnumMarshaler<EFindSceneItemWay>.FromNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:FindSceneItemWay");
			}
			else
			{
				EnumMarshaler<EFindSceneItemWay>.ToNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("【角度外】对比夹角")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsRotateTraceSceneItem && FindSceneItemWay != FindSceneItemWay::ClosestOutsideTheAngle && FindSceneItemWay != FindSceneItemWay::FarthestOutsideTheAngle")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:Angle")]
	public float Angle
	{
		get
		{
			CheckDestroyed();
			if (!Angle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:Angle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Angle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Angle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:Angle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Angle_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("重新查找前，清空当前已经缓存了的SceneItem")]
	[UMeta(MDProp.EditCondition, "NeedFindSceneItem && IsRotateTraceSceneItem")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:NeedRemoveCurrentCatch")]
	public bool NeedRemoveCurrentCatch
	{
		get
		{
			CheckDestroyed();
			if (!NeedRemoveCurrentCatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:NeedRemoveCurrentCatch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedRemoveCurrentCatch_Offset), 0, NeedRemoveCurrentCatch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedRemoveCurrentCatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:NeedRemoveCurrentCatch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedRemoveCurrentCatch_Offset), 0, NeedRemoveCurrentCatch_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("转向缓存点")]
	[UMeta(MDProp.EditCondition, "OverlayRotateTraceTargetType == ChangeTargetType::None")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateTraceRegisteredPointCache")]
	public bool IsRotateTraceRegisteredPointCache
	{
		get
		{
			CheckDestroyed();
			if (!IsRotateTraceRegisteredPointCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateTraceRegisteredPointCache");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRotateTraceRegisteredPointCache_Offset), 0, IsRotateTraceRegisteredPointCache_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRotateTraceRegisteredPointCache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateTraceRegisteredPointCache");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRotateTraceRegisteredPointCache_Offset), 0, IsRotateTraceRegisteredPointCache_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("如果覆盖目标不是None，则忽略")]
	[BlueprintReadWrite]
	[DisplayName("覆盖转向目标")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:OverlayRotateTraceTargetType")]
	public EChangeTargetType OverlayRotateTraceTargetType
	{
		get
		{
			CheckDestroyed();
			if (!OverlayRotateTraceTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:OverlayRotateTraceTargetType");
				return EChangeTargetType.None;
			}
			return EnumMarshaler<EChangeTargetType>.FromNative(IntPtr.Add(base.Address, OverlayRotateTraceTargetType_Offset), 0, OverlayRotateTraceTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!OverlayRotateTraceTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:OverlayRotateTraceTargetType");
			}
			else
			{
				EnumMarshaler<EChangeTargetType>.ToNative(IntPtr.Add(base.Address, OverlayRotateTraceTargetType_Offset), 0, OverlayRotateTraceTargetType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("缓存点集ID")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "IsRotateTraceRegisteredPointCache")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:PointsRegisterID")]
	public int PointsRegisterID
	{
		get
		{
			CheckDestroyed();
			if (!PointsRegisterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:PointsRegisterID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PointsRegisterID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointsRegisterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:PointsRegisterID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PointsRegisterID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("Set Rotate Trace Socket")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:RotateTraceSocketName")]
	public string RotateTraceSocketName
	{
		get
		{
			CheckDestroyed();
			if (!RotateTraceSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:RotateTraceSocketName");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, RotateTraceSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotateTraceSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:RotateTraceSocketName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, RotateTraceSocketName_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, "0")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Tooltip("Set Rotate Speed")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:RotateSpeed")]
	public float RotateSpeed
	{
		get
		{
			CheckDestroyed();
			if (!RotateSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:RotateSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotateSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotateSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:RotateSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotateSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("旋转方向")]
	[Tooltip("Set Rotate Direction")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:RotateDirection")]
	public ERotateDirection RotateDirection
	{
		get
		{
			CheckDestroyed();
			if (!RotateDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:RotateDirection");
				return ERotateDirection.Auto;
			}
			return EnumMarshaler<ERotateDirection>.FromNative(IntPtr.Add(base.Address, RotateDirection_Offset), 0, RotateDirection_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotateDirection_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:RotateDirection");
			}
			else
			{
				EnumMarshaler<ERotateDirection>.ToNative(IntPtr.Add(base.Address, RotateDirection_Offset), 0, RotateDirection_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("最大旋转角度")]
	[Tooltip("Set Max Rotate Angle, <= 0 means no limitation")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:MaxRotateAngle")]
	public float MaxRotateAngle
	{
		get
		{
			CheckDestroyed();
			if (!MaxRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:MaxRotateAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxRotateAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:MaxRotateAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxRotateAngle_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Tooltip("Should Still Rotate When Above Max Rotate Angle")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:bStillRotateWhenAboveMaxRotateAngle")]
	public bool bStillRotateWhenAboveMaxRotateAngle
	{
		get
		{
			CheckDestroyed();
			if (!bStillRotateWhenAboveMaxRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:bStillRotateWhenAboveMaxRotateAngle");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bStillRotateWhenAboveMaxRotateAngle_Offset), 0, bStillRotateWhenAboveMaxRotateAngle_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bStillRotateWhenAboveMaxRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:bStillRotateWhenAboveMaxRotateAngle");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bStillRotateWhenAboveMaxRotateAngle_Offset), 0, bStillRotateWhenAboveMaxRotateAngle_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("旋转开始时朝向偏转角度【玩家角色会先触发一次矫正，Evt_PlayerSkillDirFixed】")]
	[UMeta(MDProp.ClampMin, "-180")]
	[DisplayName("旋转偏转角度")]
	[UMeta(MDProp.ClampMax, "180")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:RotateDeflectionAngle")]
	public float RotateDeflectionAngle
	{
		get
		{
			CheckDestroyed();
			if (!RotateDeflectionAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:RotateDeflectionAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RotateDeflectionAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotateDeflectionAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:RotateDeflectionAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RotateDeflectionAngle_Offset), value);
			}
		}
	}

	[Tooltip("Start Rotate Deadzone Angle")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:DeadzoneAngle")]
	public float DeadzoneAngle
	{
		get
		{
			CheckDestroyed();
			if (!DeadzoneAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:DeadzoneAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DeadzoneAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DeadzoneAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:DeadzoneAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DeadzoneAngle_Offset), value);
			}
		}
	}

	[Tooltip("None指带用Root旋转；其他的选项需要Unit上也有对应名字的SceneComp")]
	[DisplayName("指定旋转轴")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:FootType")]
	public EBUHandFootType FootType
	{
		get
		{
			CheckDestroyed();
			if (!FootType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:FootType");
				return EBUHandFootType.None;
			}
			return EnumMarshaler<EBUHandFootType>.FromNative(IntPtr.Add(base.Address, FootType_Offset), 0, FootType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FootType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:FootType");
			}
			else
			{
				EnumMarshaler<EBUHandFootType>.ToNative(IntPtr.Add(base.Address, FootType_Offset), 0, FootType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否只朝着位置旋转")]
	[Tooltip("勾选上后，只会绕着触发时指定位置旋转，不会因为对方移动调整")]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateAroundLoc")]
	public bool IsRotateAroundLoc
	{
		get
		{
			CheckDestroyed();
			if (!IsRotateAroundLoc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateAroundLoc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsRotateAroundLoc_Offset), 0, IsRotateAroundLoc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsRotateAroundLoc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:IsRotateAroundLoc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsRotateAroundLoc_Offset), 0, IsRotateAroundLoc_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("显示Debug信息【Rotate目标信息】")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:EnableDebug")]
	public bool EnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:EnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:EnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("结束时强制对位(仅对SceneItem有效)")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:IsNeedForceRotateToSceneItemInEnd")]
	public bool IsNeedForceRotateToSceneItemInEnd
	{
		get
		{
			CheckDestroyed();
			if (!IsNeedForceRotateToSceneItemInEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:IsNeedForceRotateToSceneItemInEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNeedForceRotateToSceneItemInEnd_Offset), 0, IsNeedForceRotateToSceneItemInEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNeedForceRotateToSceneItemInEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAttackRotation:IsNeedForceRotateToSceneItemInEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNeedForceRotateToSceneItemInEnd_Offset), 0, IsNeedForceRotateToSceneItemInEnd_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		IsNeedForceRotateToSceneItemInEnd = true;
		IsRotateTraceCurrentTarget = true;
		IsRotateTraceSceneItem = false;
		NeedFindSceneItem = false;
		IsRotateAroundLoc = false;
		OverlayRotateTraceTargetType = EChangeTargetType.None;
		bStillRotateWhenAboveMaxRotateAngle = false;
		EnableDebug = false;
		RotateSpeed = 0f;
		RotateDirection = ERotateDirection.Auto;
		RotateDeflectionAngle = 0f;
		FootType = EBUHandFootType.None;
		UBGUFunctionLibraryForCS.BGUGetIsEditor();
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:MarkDirty")]
	public bool MarkDirty()
	{
		return false;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackRotationBegin, TotalDuration);
			IBUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_AIData, BUC_AIData>(bGUCharacterCS);
			if (unPersistentReadOnlyData == null || !unPersistentReadOnlyData.IsAI)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_PlayerSkillDirFixed.Invoke(RotateDeflectionAngle);
			}
			SetRotateOffsetAxis(bGUCharacterCS);
			SetRotateTarget(bGUCharacterCS, NotifyParam);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:GSAllowCrossSection")]
	protected override bool GSAllowCrossSection_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:GSOnSectionManuallyChanged")]
	protected override void GSOnSectionManuallyChanged_Implementation(ABGUCharacter OwnerChar, float RemainingDuration)
	{
		if (!(OwnerChar == null) && BGUFunctionLibraryCS.BGUHasUnitState(OwnerChar, EBGUUnitState.AttackRotation))
		{
			BUS_EventCollectionCS.Get(OwnerChar).Evt_UnitStateTrigger.Invoke(EBUStateTrigger.AttackRotationBegin, RemainingDuration, NeedForceUpdate: true);
		}
	}

	private bool FindAndEnsureSceneItemValid(BGUCharacterCS CharacterCS, FUStGSNotifyParam NotifyParam, out AActor OutSceneItemCatch, bool bCanBeginTryFindSceneItem = true)
	{
		OutSceneItemCatch = null;
		if (CharacterCS != null)
		{
			if (NeedFindSceneItem && bCanBeginTryFindSceneItem)
			{
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(CharacterCS, EBattleInfoType.TryFindSceneItem, "<character>" + CharacterCS?.GetName() + "</><action>=============================AttackRotation里重新找SceneItem开始=============================</>");
				}
				BUS_EventCollectionCS.Get(CharacterCS).Evt_TryCatchSceneItemByTag.Invoke(SceneActorTags.ToList(), FindSceneItemWay, NeedRemoveCurrentCatch, MinDistance, MaxDistance, NotifyParam.FromInstanceID, -1f, Angle, EnableDebug);
				if (DebugConfig.IsOpenBattleInfoTool)
				{
					BGUFunctionLibraryCS.LogBattleInfo(CharacterCS, EBattleInfoType.TryFindSceneItem, "<character>" + CharacterCS?.GetName() + "</><action>=============================AttackRotation里重新找SceneItem结束=============================</>");
				}
			}
			BUC_SceneItemData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(CharacterCS);
			if (readOnlyData != null)
			{
				bool flag = false;
				AActor catchedSceneItemByAMID = readOnlyData.GetCatchedSceneItemByAMID(NotifyParam.FromInstanceID);
				if (catchedSceneItemByAMID != null)
				{
					if (SceneActorTags.Count > 0)
					{
						foreach (FName item in SceneActorTags.ToList())
						{
							if (readOnlyData.SceneItemCatch.ActorHasTag(item))
							{
								OutSceneItemCatch = readOnlyData.SceneItemCatch;
								flag = true;
								break;
							}
						}
					}
					else
					{
						OutSceneItemCatch = catchedSceneItemByAMID;
						flag = true;
					}
				}
				if (!flag)
				{
					if (readOnlyData.SceneItemCatch != null)
					{
						if (SceneActorTags.Count > 0)
						{
							foreach (FName item2 in SceneActorTags.ToList())
							{
								if (readOnlyData.SceneItemCatch.ActorHasTag(item2))
								{
									OutSceneItemCatch = readOnlyData.SceneItemCatch;
									flag = true;
									break;
								}
							}
						}
						else
						{
							OutSceneItemCatch = readOnlyData.SceneItemCatch;
							flag = true;
						}
					}
					else if (SceneActorTags.Count == 0)
					{
						return false;
					}
				}
				if (!flag)
				{
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(CharacterCS, EBattleInfoType.TryFindSceneItem, "<character>" + CharacterCS?.GetName() + "</><action>=============================AttackRotation里重新找SceneItem开始=============================</>");
					}
					BUS_EventCollectionCS.Get(CharacterCS).Evt_TryCatchSceneItemByTag.Invoke(SceneActorTags.ToList(), FindSceneItemWay, NeedRemoveCurrentCatch: true, MinDistance, MaxDistance, NotifyParam.FromInstanceID, -1f, Angle, EnableDebug);
					if (DebugConfig.IsOpenBattleInfoTool)
					{
						BGUFunctionLibraryCS.LogBattleInfo(CharacterCS, EBattleInfoType.TryFindSceneItem, "<character>" + CharacterCS?.GetName() + "</><action>=============================AttackRotation里重新找SceneItem结束=============================</>");
					}
					if (readOnlyData.SceneItemCatch != null)
					{
						foreach (FName item3 in SceneActorTags.ToList())
						{
							if (readOnlyData.SceneItemCatch.ActorHasTag(item3))
							{
								OutSceneItemCatch = readOnlyData.SceneItemCatch;
								return true;
							}
						}
					}
				}
				return flag;
			}
		}
		return false;
	}

	private void SetRotateTarget(BGUCharacterCS CharacterCS, FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = null;
		UnitLockTargetInfo unitLockTargetInfo = null;
		bool flag = false;
		FVector targetPos = FVector.ZeroVector;
		if (IsRotateTraceCurrentTarget)
		{
			unitLockTargetInfo = BGUFunctionLibraryCS.BGUGetTargetInfo(CharacterCS);
			aActor = unitLockTargetInfo.LockTargetActor;
		}
		switch (OverlayRotateTraceTargetType)
		{
		case EChangeTargetType.Player:
			aActor = BGU_UnrealWorldUtil.GetNearestPlayerActor(CharacterCS.World, BGUFuncLibActorTransformCS.BGUGetActorLocation(CharacterCS));
			unitLockTargetInfo = BGUFuncLibAICS.BGUAIGetAutoLockTargetInfo(aActor, ETargetSourceType.None, ELockTargetWayType.Auto);
			break;
		case EChangeTargetType.Master:
		{
			IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(CharacterCS);
			if (readOnlyData != null)
			{
				aActor = readOnlyData.GetMasterActor();
				unitLockTargetInfo = BGUFuncLibAICS.BGUAIGetAutoLockTargetInfo(aActor, ETargetSourceType.None, ELockTargetWayType.Auto);
			}
			break;
		}
		case EChangeTargetType.Summon:
		{
			IBGC_SummonData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<IBGC_SummonData, BGC_SummonData>(CharacterCS);
			if (gameStateReadonlyData != null)
			{
				AActor summonerFirstServantActor = gameStateReadonlyData.GetSummonerFirstServantActor(CharacterCS);
				if (summonerFirstServantActor != null)
				{
					aActor = summonerFirstServantActor;
					unitLockTargetInfo = BGUFuncLibAICS.BGUAIGetAutoLockTargetInfo(aActor, ETargetSourceType.None, ELockTargetWayType.Auto);
				}
			}
			break;
		}
		case EChangeTargetType.SkillBaseTarget:
			unitLockTargetInfo = BGUFunctionLibraryCS.BGUGetSkillBaseTargetInfo(CharacterCS);
			if (unitLockTargetInfo != null && unitLockTargetInfo.LockTargetActor != null)
			{
				aActor = unitLockTargetInfo.LockTargetActor;
			}
			else if (unitLockTargetInfo != null && unitLockTargetInfo.LockTargetType == ELockTargetType.Point)
			{
				targetPos = unitLockTargetInfo.LockPointLocation;
				flag = true;
			}
			break;
		}
		if (aActor == null && !flag)
		{
			if (IsRotateTraceSceneItem)
			{
				if (!FindAndEnsureSceneItemValid(CharacterCS, NotifyParam, out var OutSceneItemCatch))
				{
					return;
				}
				if (OutSceneItemCatch != null)
				{
					flag = true;
					targetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutSceneItemCatch);
					BUC_SceneItemCommData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemCommData>(OutSceneItemCatch);
					if (readOnlyData2 != null)
					{
						targetPos = readOnlyData2.TeleportTransform.GetLocation();
					}
					BUS_EventCollectionCS.Get(CharacterCS)?.Evt_OnSceneItemAttackRotationBegin.Invoke(OutSceneItemCatch, NotifyParam.FromInstanceID, NotifyParam.UniqueID);
				}
			}
			else if (IsRotateTraceRegisteredPointCache)
			{
				List<FVector> list = BGUFunctionLibraryCS.BGUGetCachedPointSet(CharacterCS, PointsRegisterID);
				if (list.Count > 0)
				{
					flag = true;
					targetPos = list[0];
				}
			}
		}
		RotateSpeed = ((RotateSpeed > 0f) ? RotateSpeed : 0f);
		bool enableDebug = GSGameplayCVar.CVar_NSDebug_EnableShowAllAttackRotationDebug.GetValueInGameThread() == 1 || EnableDebug;
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(CharacterCS);
		if (aActor != null && unitLockTargetInfo != null)
		{
			if (RotateTraceSocketName.Length > 0)
			{
				FVector targetPos2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
				ACharacter aCharacter = aActor as ACharacter;
				if (aCharacter != null && aCharacter.Mesh != null)
				{
					targetPos2 = aCharacter.Mesh.GetSocketLocation(new FName(RotateTraceSocketName));
				}
				if (IsRotateAroundLoc)
				{
					bUS_GSEventCollection.Evt_MontageRotateAroundLocation.Invoke(targetPos2, RotateSpeed, RotateDeflectionAngle, MaxRotateAngle, RotateDirection, bStillRotateWhenAboveMaxRotateAngle, DeadzoneAngle, enableDebug);
				}
				else
				{
					bUS_GSEventCollection.Evt_MontageRotateTraceActor.Invoke(unitLockTargetInfo, RotateSpeed, RotateDeflectionAngle, MaxRotateAngle, RotateTraceSocketName, bIncludeAutoLockPoint: false, RotateDirection, bStillRotateWhenAboveMaxRotateAngle, DeadzoneAngle, enableDebug);
				}
			}
			else if (IsRotateAroundLoc)
			{
				bUS_GSEventCollection.Evt_MontageRotateAroundLocation.Invoke(BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor), RotateSpeed, RotateDeflectionAngle, MaxRotateAngle, RotateDirection, bStillRotateWhenAboveMaxRotateAngle, DeadzoneAngle, enableDebug);
			}
			else
			{
				bUS_GSEventCollection.Evt_MontageRotateTraceActor.Invoke(unitLockTargetInfo, RotateSpeed, RotateDeflectionAngle, MaxRotateAngle, "", unitLockTargetInfo.LockTargetType == ELockTargetType.SceneComp, RotateDirection, bStillRotateWhenAboveMaxRotateAngle, DeadzoneAngle, enableDebug);
			}
		}
		else if (flag)
		{
			bUS_GSEventCollection.Evt_MontageRotateAroundLocation.Invoke(targetPos, RotateSpeed, RotateDeflectionAngle, MaxRotateAngle, RotateDirection, bStillRotateWhenAboveMaxRotateAngle, DeadzoneAngle, enableDebug);
		}
	}

	private void SetRotateOffsetAxis(BGUCharacterCS CharacterCS)
	{
		if (FootType != EBUHandFootType.None)
		{
			FName name = FName.None;
			switch (FootType)
			{
			case EBUHandFootType.LeftHand:
				name = B1GlobalFNames.FootAxisFL;
				break;
			case EBUHandFootType.RightHand:
				name = B1GlobalFNames.FootAxisFR;
				break;
			case EBUHandFootType.LeftFoot:
				name = B1GlobalFNames.FootAxisBL;
				break;
			case EBUHandFootType.RightFoot:
				name = B1GlobalFNames.FootAxisBR;
				break;
			}
			USceneComponent uSceneComponent = BGUFunctionLibraryCS.TryGetComponentByFName(CharacterCS, name) as USceneComponent;
			if (uSceneComponent != null)
			{
				BUS_EventCollectionCS.Get(CharacterCS).Evt_SetOffsetRotationAxisComp.Invoke(uSceneComponent);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAttackRotation:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		if (IsRotateTraceSceneItem)
		{
			BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS)?.Evt_OnSceneItemAttackRotationEnd.Invoke(NotifyParam.FromInstanceID, NotifyParam.UniqueID, IsNeedForceRotateToSceneItemInEnd, RotateDeflectionAngle);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackRotation:MarkDirty")]
	private static void MarkDirty__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSAttackRotation bANS_GSAttackRotation = GCHelper.Find<BANS_GSAttackRotation>(obj);
		bool value = bANS_GSAttackRotation.MarkDirty();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, MarkDirty_ReturnValue_Offset), 0, MarkDirty_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackRotation:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSAttackRotation bANS_GSAttackRotation = GCHelper.Find<BANS_GSAttackRotation>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAttackRotation.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackRotation:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSAttackRotation bANS_GSAttackRotation = GCHelper.Find<BANS_GSAttackRotation>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAttackRotation.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackRotation:GSAllowCrossSection")]
	private static void GSAllowCrossSection__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSAttackRotation bANS_GSAttackRotation = GCHelper.Find<BANS_GSAttackRotation>(obj);
		bool value = bANS_GSAttackRotation.GSAllowCrossSection_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, GSAllowCrossSection_ReturnValue_Offset), 0, GSAllowCrossSection_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAttackRotation:GSOnSectionManuallyChanged")]
	private static void GSOnSectionManuallyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSAttackRotation bANS_GSAttackRotation = GCHelper.Find<BANS_GSAttackRotation>(obj);
		ABGUCharacter ownerChar = UObjectMarshaler<ABGUCharacter>.FromNative(IntPtr.Add(buffer, GSOnSectionManuallyChanged_OwnerChar_Offset));
		float remainingDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSOnSectionManuallyChanged_RemainingDuration_Offset));
		bANS_GSAttackRotation.GSOnSectionManuallyChanged_Implementation(ownerChar, remainingDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAttackRotation");
		NativeReflection.GetPropertyRef(ref IsRotateTraceCurrentTarget_PropertyAddress, intPtr, "IsRotateTraceCurrentTarget");
		IsRotateTraceCurrentTarget_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRotateTraceCurrentTarget");
		IsRotateTraceCurrentTarget_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRotateTraceCurrentTarget", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsRotateTraceSceneItem_PropertyAddress, intPtr, "IsRotateTraceSceneItem");
		IsRotateTraceSceneItem_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRotateTraceSceneItem");
		IsRotateTraceSceneItem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRotateTraceSceneItem", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedFindSceneItem_PropertyAddress, intPtr, "NeedFindSceneItem");
		NeedFindSceneItem_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedFindSceneItem");
		NeedFindSceneItem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedFindSceneItem", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SceneActorTags_PropertyAddress, intPtr, "SceneActorTags");
		SceneActorTags_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneActorTags");
		SceneActorTags_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneActorTags", Classes.FArrayProperty);
		MinDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinDistance");
		MinDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinDistance", Classes.FFloatProperty);
		MaxDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxDistance");
		MaxDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref FindSceneItemWay_PropertyAddress, intPtr, "FindSceneItemWay");
		FindSceneItemWay_Offset = NativeReflection.GetPropertyOffset(intPtr, "FindSceneItemWay");
		FindSceneItemWay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FindSceneItemWay", Classes.FEnumProperty);
		Angle_Offset = NativeReflection.GetPropertyOffset(intPtr, "Angle");
		Angle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Angle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref NeedRemoveCurrentCatch_PropertyAddress, intPtr, "NeedRemoveCurrentCatch");
		NeedRemoveCurrentCatch_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedRemoveCurrentCatch");
		NeedRemoveCurrentCatch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedRemoveCurrentCatch", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsRotateTraceRegisteredPointCache_PropertyAddress, intPtr, "IsRotateTraceRegisteredPointCache");
		IsRotateTraceRegisteredPointCache_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRotateTraceRegisteredPointCache");
		IsRotateTraceRegisteredPointCache_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRotateTraceRegisteredPointCache", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref OverlayRotateTraceTargetType_PropertyAddress, intPtr, "OverlayRotateTraceTargetType");
		OverlayRotateTraceTargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverlayRotateTraceTargetType");
		OverlayRotateTraceTargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverlayRotateTraceTargetType", Classes.FEnumProperty);
		PointsRegisterID_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointsRegisterID");
		PointsRegisterID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointsRegisterID", Classes.FIntProperty);
		RotateTraceSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateTraceSocketName");
		RotateTraceSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateTraceSocketName", Classes.FStrProperty);
		RotateSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateSpeed");
		RotateSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateSpeed", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref RotateDirection_PropertyAddress, intPtr, "RotateDirection");
		RotateDirection_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateDirection");
		RotateDirection_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateDirection", Classes.FEnumProperty);
		MaxRotateAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxRotateAngle");
		MaxRotateAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxRotateAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bStillRotateWhenAboveMaxRotateAngle_PropertyAddress, intPtr, "bStillRotateWhenAboveMaxRotateAngle");
		bStillRotateWhenAboveMaxRotateAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "bStillRotateWhenAboveMaxRotateAngle");
		bStillRotateWhenAboveMaxRotateAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bStillRotateWhenAboveMaxRotateAngle", Classes.FBoolProperty);
		RotateDeflectionAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotateDeflectionAngle");
		RotateDeflectionAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotateDeflectionAngle", Classes.FFloatProperty);
		DeadzoneAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "DeadzoneAngle");
		DeadzoneAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DeadzoneAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref FootType_PropertyAddress, intPtr, "FootType");
		FootType_Offset = NativeReflection.GetPropertyOffset(intPtr, "FootType");
		FootType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FootType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref IsRotateAroundLoc_PropertyAddress, intPtr, "IsRotateAroundLoc");
		IsRotateAroundLoc_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsRotateAroundLoc");
		IsRotateAroundLoc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsRotateAroundLoc", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableDebug_PropertyAddress, intPtr, "EnableDebug");
		EnableDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDebug");
		EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IsNeedForceRotateToSceneItemInEnd_PropertyAddress, intPtr, "IsNeedForceRotateToSceneItemInEnd");
		IsNeedForceRotateToSceneItemInEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "IsNeedForceRotateToSceneItemInEnd");
		IsNeedForceRotateToSceneItemInEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IsNeedForceRotateToSceneItemInEnd", Classes.FBoolProperty);
		MarkDirty_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MarkDirty");
		MarkDirty_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkDirty_FunctionAddress);
		NativeReflection.GetPropertyRef(ref MarkDirty_ReturnValue_PropertyAddress, MarkDirty_FunctionAddress, "ReturnValue");
		MarkDirty_ReturnValue_Offset = NativeReflection.GetPropertyOffset(MarkDirty_FunctionAddress, "ReturnValue");
		MarkDirty_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(MarkDirty_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MarkDirty_IsValid = MarkDirty_FunctionAddress != IntPtr.Zero && MarkDirty_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackRotation:MarkDirty", MarkDirty_IsValid);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackRotation:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackRotation:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GSAllowCrossSection_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSAllowCrossSection");
		GSAllowCrossSection_ParamsSize = NativeReflection.GetFunctionParamsSize(GSAllowCrossSection_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSAllowCrossSection_ReturnValue_PropertyAddress, GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GSAllowCrossSection_FunctionAddress, "ReturnValue");
		GSAllowCrossSection_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GSAllowCrossSection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GSAllowCrossSection_IsValid = GSAllowCrossSection_FunctionAddress != IntPtr.Zero && GSAllowCrossSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackRotation:GSAllowCrossSection", GSAllowCrossSection_IsValid);
		GSOnSectionManuallyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnSectionManuallyChanged");
		GSOnSectionManuallyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnSectionManuallyChanged_FunctionAddress);
		GSOnSectionManuallyChanged_OwnerChar_Offset = NativeReflection.GetPropertyOffset(GSOnSectionManuallyChanged_FunctionAddress, "OwnerChar");
		GSOnSectionManuallyChanged_OwnerChar_IsValid = NativeReflection.ValidatePropertyClass(GSOnSectionManuallyChanged_FunctionAddress, "OwnerChar", Classes.FObjectProperty);
		GSOnSectionManuallyChanged_RemainingDuration_Offset = NativeReflection.GetPropertyOffset(GSOnSectionManuallyChanged_FunctionAddress, "RemainingDuration");
		GSOnSectionManuallyChanged_RemainingDuration_IsValid = NativeReflection.ValidatePropertyClass(GSOnSectionManuallyChanged_FunctionAddress, "RemainingDuration", Classes.FFloatProperty);
		GSOnSectionManuallyChanged_IsValid = GSOnSectionManuallyChanged_FunctionAddress != IntPtr.Zero && GSOnSectionManuallyChanged_OwnerChar_IsValid && GSOnSectionManuallyChanged_RemainingDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAttackRotation:GSOnSectionManuallyChanged", GSOnSectionManuallyChanged_IsValid);
	}

	static BANS_GSAttackRotation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSAttackRotation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSAttackRotation));
	}
}
