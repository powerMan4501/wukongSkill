using System;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAIT_AdjustTransformBySpline")]
[USharpPath("/Script/b1-Managed.BAIT_AdjustTransformBySpline")]
internal class BAIT_AdjustTransformBySpline : BAIT_Base
{
	private static bool bHint_IsValid;

	private static int bHint_Offset;

	private static FFieldAddress bHint_PropertyAddress;

	private static bool bShowDebug_IsValid;

	private static int bShowDebug_Offset;

	private static FFieldAddress bShowDebug_PropertyAddress;

	private static bool SplineGuid_IsValid;

	private static int SplineGuid_Offset;

	private static bool RotateType_IsValid;

	private static int RotateType_Offset;

	private static FFieldAddress RotateType_PropertyAddress;

	private static bool AdjustTime_IsValid;

	private static int AdjustTime_Offset;

	[UProperty]
	[VisibleAnywhere]
	[BlueprintReadWrite]
	[DisplayName("放一条BGUSplineActor到场景以后给个GUID")]
	[USharpPath("/Script/b1-Managed.BAIT_AdjustTransformBySpline:bHint")]
	public bool bHint
	{
		get
		{
			CheckDestroyed();
			if (!bHint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AdjustTransformBySpline:bHint");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bHint_Offset), 0, bHint_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bHint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AdjustTransformBySpline:bHint");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bHint_Offset), 0, bHint_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_AdjustTransformBySpline:bShowDebug")]
	public bool bShowDebug
	{
		get
		{
			CheckDestroyed();
			if (!bShowDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AdjustTransformBySpline:bShowDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bShowDebug_Offset), 0, bShowDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bShowDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AdjustTransformBySpline:bShowDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bShowDebug_Offset), 0, bShowDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_AdjustTransformBySpline:SplineGuid")]
	public FGameplayTag SplineGuid
	{
		get
		{
			CheckDestroyed();
			if (!SplineGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AdjustTransformBySpline:SplineGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, SplineGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AdjustTransformBySpline:SplineGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, SplineGuid_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_AdjustTransformBySpline:RotateType")]
	public ETransformBySplineRotateType RotateType
	{
		get
		{
			CheckDestroyed();
			if (!RotateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AdjustTransformBySpline:RotateType");
				return ETransformBySplineRotateType.RotateToSplineTangentByTargetSide;
			}
			return EnumMarshaler<ETransformBySplineRotateType>.FromNative(IntPtr.Add(base.Address, RotateType_Offset), 0, RotateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AdjustTransformBySpline:RotateType");
			}
			else
			{
				EnumMarshaler<ETransformBySplineRotateType>.ToNative(IntPtr.Add(base.Address, RotateType_Offset), 0, RotateType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("允许调整时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_AdjustTransformBySpline:AdjustTime")]
	public float AdjustTime
	{
		get
		{
			CheckDestroyed();
			if (!AdjustTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AdjustTransformBySpline:AdjustTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AdjustTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdjustTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AdjustTransformBySpline:AdjustTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AdjustTime_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AdjustTime = 0.5f;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actor);
			AActor _Target = BGU_DataUtil.GetUnPersistentReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(actor).GetTargetInfo().LockTargetActor;
			if (bUS_GSEventCollection != null)
			{
				GSDel_AITransformBySplineChange evt_AITransformBySplineChange = bUS_GSEventCollection.Evt_AITransformBySplineChange;
				float adjustTime = AdjustTime;
				ETransformBySplineRotateType rotateType = RotateType;
				FGameplayTag SplineGuid = this.SplineGuid;
				bool num = bShowDebug;
				BAIT_Base _BAITRef = this;
				evt_AITransformBySplineChange.Invoke(adjustTime, rotateType, in _Target, in SplineGuid, num, in _BAITRef, (BANS_GSBase)null);
				bUS_GSEventCollection.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.AdjustTransformBySpline, new AINodeAction_AdjustTransformBySplineParamInfo
				{
					bShowDebug = bShowDebug,
					SplineGuid = this.SplineGuid.TagName.ToString(),
					AdjustTime = AdjustTime
				});
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_AdjustTransformBySpline");
		NativeReflection.GetPropertyRef(ref bHint_PropertyAddress, unrealStruct, "bHint");
		bHint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bHint");
		bHint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bHint", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bShowDebug_PropertyAddress, unrealStruct, "bShowDebug");
		bShowDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bShowDebug");
		bShowDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bShowDebug", Classes.FBoolProperty);
		SplineGuid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SplineGuid");
		SplineGuid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SplineGuid", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref RotateType_PropertyAddress, unrealStruct, "RotateType");
		RotateType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RotateType");
		RotateType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RotateType", Classes.FEnumProperty);
		AdjustTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AdjustTime");
		AdjustTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AdjustTime", Classes.FFloatProperty);
	}

	static BAIT_AdjustTransformBySpline()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_AdjustTransformBySpline)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_AdjustTransformBySpline));
	}
}
