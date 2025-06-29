using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig")]
public class BGWDataAsset_AutoTestMoveToConfig : UBGWDataAsset
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

	[Tooltip("0表示无限制")]
	[DisplayName("最大移动时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MaxMoveTime")]
	public float MaxMoveTime
	{
		get
		{
			CheckDestroyed();
			if (!MaxMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MaxMoveTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxMoveTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MaxMoveTime");
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
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:AcceptableRadius")]
	public float AcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:AcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:AcceptableRadius");
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
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:IncludeSelfRadius")]
	public bool IncludeSelfRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:IncludeSelfRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:IncludeSelfRadius");
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
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:IncludeTargetRadius")]
	public bool IncludeTargetRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeTargetRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:IncludeTargetRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeTargetRadius_Offset), 0, IncludeTargetRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeTargetRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:IncludeTargetRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeTargetRadius_Offset), 0, IncludeTargetRadius_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:BTTargetType")]
	public EBTTargetType BTTargetType
	{
		get
		{
			CheckDestroyed();
			if (!BTTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:BTTargetType");
				return EBTTargetType.Target;
			}
			return EnumMarshaler<EBTTargetType>.FromNative(IntPtr.Add(base.Address, BTTargetType_Offset), 0, BTTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BTTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:BTTargetType");
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
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MoveAIType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:SpeedRateType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:SpeedRateDistanceCurve")]
	public UCurveFloat SpeedRateDistanceCurve
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateDistanceCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:SpeedRateDistanceCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, SpeedRateDistanceCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateDistanceCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:SpeedRateDistanceCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, SpeedRateDistanceCurve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:EnableRangeAcceptableRadius")]
	public bool EnableRangeAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!EnableRangeAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:EnableRangeAcceptableRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRangeAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:EnableRangeAcceptableRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "EnableRangeAcceptableRadius")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MinAcceptableRadius")]
	public float MinAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MinAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MinAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MinAcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinAcceptableRadius_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "EnableRangeAcceptableRadius")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MaxAcceptableRadius")]
	public float MaxAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MaxAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MaxAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig:MaxAcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAcceptableRadius_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AutoTestMoveToConfig");
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

	static BGWDataAsset_AutoTestMoveToConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AutoTestMoveToConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AutoTestMoveToConfig));
	}
}
