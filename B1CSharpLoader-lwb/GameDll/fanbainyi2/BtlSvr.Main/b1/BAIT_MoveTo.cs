using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAIT_MoveTo")]
[UClass]
[USharpPath("/Script/b1-Managed.BAIT_MoveTo")]
internal class BAIT_MoveTo : BAIT_Base
{
	private static bool MaxMoveTime_IsValid;

	private static int MaxMoveTime_Offset;

	private static bool AcceptableRadius_IsValid;

	private static int AcceptableRadius_Offset;

	private static bool IncludeSelfRadius_IsValid;

	private static int IncludeSelfRadius_Offset;

	private static FFieldAddress IncludeSelfRadius_PropertyAddress;

	private static bool IncludeTargetRadius_IsValid;

	private static int IncludeTargetRadius_Offset;

	private static FFieldAddress IncludeTargetRadius_PropertyAddress;

	private static bool MotionMatchingState_IsValid;

	private static int MotionMatchingState_Offset;

	private static FFieldAddress MotionMatchingState_PropertyAddress;

	private static bool BTTargetType_IsValid;

	private static int BTTargetType_Offset;

	private static FFieldAddress BTTargetType_PropertyAddress;

	private static bool MoveAIType_IsValid;

	private static int MoveAIType_Offset;

	private static FFieldAddress MoveAIType_PropertyAddress;

	private static bool SpeedRateType_IsValid;

	private static int SpeedRateType_Offset;

	private static FFieldAddress SpeedRateType_PropertyAddress;

	private static bool SpeedRateDistanceCurve_IsValid;

	private static int SpeedRateDistanceCurve_Offset;

	private static bool EnableRangeAcceptableRadius_IsValid;

	private static int EnableRangeAcceptableRadius_Offset;

	private static FFieldAddress EnableRangeAcceptableRadius_PropertyAddress;

	private static bool MinAcceptableRadius_IsValid;

	private static int MinAcceptableRadius_Offset;

	private static bool MaxAcceptableRadius_IsValid;

	private static int MaxAcceptableRadius_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("最大移动时间")]
	[Tooltip("0表示无限制")]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:MaxMoveTime")]
	public float MaxMoveTime
	{
		get
		{
			CheckDestroyed();
			if (!MaxMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:MaxMoveTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxMoveTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:MaxMoveTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxMoveTime_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "!EnableRangeAcceptableRadius")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:AcceptableRadius")]
	public float AcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:AcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:AcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AcceptableRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:IncludeSelfRadius")]
	public bool IncludeSelfRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:IncludeSelfRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:IncludeSelfRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:IncludeTargetRadius")]
	public bool IncludeTargetRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeTargetRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:IncludeTargetRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeTargetRadius_Offset), 0, IncludeTargetRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeTargetRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:IncludeTargetRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeTargetRadius_Offset), 0, IncludeTargetRadius_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("如果是None，不触发调整逻辑")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:MotionMatchingState")]
	public EState_MM MotionMatchingState
	{
		get
		{
			CheckDestroyed();
			if (!MotionMatchingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:MotionMatchingState");
				return EState_MM.None;
			}
			return EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(base.Address, MotionMatchingState_Offset), 0, MotionMatchingState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MotionMatchingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:MotionMatchingState");
			}
			else
			{
				EnumMarshaler<EState_MM>.ToNative(IntPtr.Add(base.Address, MotionMatchingState_Offset), 0, MotionMatchingState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:BTTargetType")]
	public EBTTargetType BTTargetType
	{
		get
		{
			CheckDestroyed();
			if (!BTTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:BTTargetType");
				return EBTTargetType.Target;
			}
			return EnumMarshaler<EBTTargetType>.FromNative(IntPtr.Add(base.Address, BTTargetType_Offset), 0, BTTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BTTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:BTTargetType");
			}
			else
			{
				EnumMarshaler<EBTTargetType>.ToNative(IntPtr.Add(base.Address, BTTargetType_Offset), 0, BTTargetType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:MoveAIType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:SpeedRateType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:SpeedRateDistanceCurve")]
	public UCurveFloat SpeedRateDistanceCurve
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateDistanceCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:SpeedRateDistanceCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, SpeedRateDistanceCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateDistanceCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:SpeedRateDistanceCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, SpeedRateDistanceCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:EnableRangeAcceptableRadius")]
	public bool EnableRangeAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!EnableRangeAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:EnableRangeAcceptableRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRangeAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:EnableRangeAcceptableRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "EnableRangeAcceptableRadius")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:MinAcceptableRadius")]
	public float MinAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MinAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:MinAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:MinAcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinAcceptableRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EnableRangeAcceptableRadius")]
	[USharpPath("/Script/b1-Managed.BAIT_MoveTo:MaxAcceptableRadius")]
	public float MaxAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MaxAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:MaxAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_MoveTo:MaxAcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAcceptableRadius_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		MaxMoveTime = 0f;
		SpeedRateType = EAIMoveSpeedType.RUN;
		IncludeTargetRadius = false;
		IncludeSelfRadius = true;
		MotionMatchingState = EState_MM.None;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ChangeMotionMatchingState.Invoke(MotionMatchingState);
				bUS_GSEventCollection.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.MoveTo, new AINodeAction_MoveToParamInfo
				{
					MaxMoveTime = MaxMoveTime,
					AcceptableRadius = AcceptableRadius,
					IncludeSelfRadius = IncludeSelfRadius,
					IncludeTargetRadius = IncludeTargetRadius,
					BTTargetType = BTTargetType,
					MoveAIType = MoveAIType,
					SpeedRateType = SpeedRateType,
					SpeedRateDistanceCurve = SpeedRateDistanceCurve,
					EnableRangeAcceptableRadius = EnableRangeAcceptableRadius,
					MinAcceptableRadius = MinAcceptableRadius,
					MaxAcceptableRadius = MaxAcceptableRadius
				});
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_MoveTo");
		MaxMoveTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxMoveTime");
		MaxMoveTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxMoveTime", Classes.FFloatProperty);
		AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AcceptableRadius");
		AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IncludeSelfRadius_PropertyAddress, unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncludeSelfRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IncludeTargetRadius_PropertyAddress, unrealStruct, "IncludeTargetRadius");
		IncludeTargetRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncludeTargetRadius");
		IncludeTargetRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncludeTargetRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MotionMatchingState_PropertyAddress, unrealStruct, "MotionMatchingState");
		MotionMatchingState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MotionMatchingState");
		MotionMatchingState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MotionMatchingState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref BTTargetType_PropertyAddress, unrealStruct, "BTTargetType");
		BTTargetType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BTTargetType");
		BTTargetType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BTTargetType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveAIType_PropertyAddress, unrealStruct, "MoveAIType");
		MoveAIType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveAIType");
		MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SpeedRateType_PropertyAddress, unrealStruct, "SpeedRateType");
		SpeedRateType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedRateType");
		SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedRateType", Classes.FEnumProperty);
		SpeedRateDistanceCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedRateDistanceCurve");
		SpeedRateDistanceCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedRateDistanceCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref EnableRangeAcceptableRadius_PropertyAddress, unrealStruct, "EnableRangeAcceptableRadius");
		EnableRangeAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableRangeAcceptableRadius");
		EnableRangeAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableRangeAcceptableRadius", Classes.FBoolProperty);
		MinAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinAcceptableRadius");
		MinAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinAcceptableRadius", Classes.FFloatProperty);
		MaxAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxAcceptableRadius");
		MaxAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxAcceptableRadius", Classes.FFloatProperty);
	}

	static BAIT_MoveTo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_MoveTo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_MoveTo));
	}
}
