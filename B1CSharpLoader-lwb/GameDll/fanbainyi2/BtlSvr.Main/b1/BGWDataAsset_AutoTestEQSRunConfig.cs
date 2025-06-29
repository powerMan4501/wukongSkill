using System;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig")]
public class BGWDataAsset_AutoTestEQSRunConfig : UBGWDataAsset
{
	private static bool AcceptableRadius_IsValid;

	private static int AcceptableRadius_Offset;

	private static bool IncludeSelfRadius_IsValid;

	private static int IncludeSelfRadius_Offset;

	private static FFieldAddress IncludeSelfRadius_PropertyAddress;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

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

	private static bool AutoUpdatePathTime_IsValid;

	private static int AutoUpdatePathTime_Offset;

	private static bool EnableLeisure_IsValid;

	private static int EnableLeisure_Offset;

	private static FFieldAddress EnableLeisure_PropertyAddress;

	private static bool IntervalTime_IsValid;

	private static int IntervalTime_Offset;

	private static bool LeisureList_IsValid;

	private static int LeisureList_Offset;

	private static FFieldAddress LeisureList_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSLeisureWithWeight> LeisureList_Marshaler;

	[UMeta(MDProp.EditCondition, "!EnableRangeAcceptableRadius")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:AcceptableRadius")]
	public float AcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:AcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:AcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AcceptableRadius_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:IncludeSelfRadius")]
	public bool IncludeSelfRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:IncludeSelfRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:IncludeSelfRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:EQSTemplate")]
	public UEnvQuery EQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:EQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, EQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:EQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, EQSTemplate_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:MoveAIType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:SpeedRateType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:SpeedRateDistanceCurve")]
	public UCurveFloat SpeedRateDistanceCurve
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateDistanceCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:SpeedRateDistanceCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, SpeedRateDistanceCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateDistanceCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:SpeedRateDistanceCurve");
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
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:EnableRangeAcceptableRadius")]
	public bool EnableRangeAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!EnableRangeAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:EnableRangeAcceptableRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRangeAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:EnableRangeAcceptableRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "EnableRangeAcceptableRadius")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:MinAcceptableRadius")]
	public float MinAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MinAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:MinAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:MinAcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinAcceptableRadius_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "EnableRangeAcceptableRadius")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:MaxAcceptableRadius")]
	public float MaxAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MaxAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:MaxAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:MaxAcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAcceptableRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:AutoUpdatePathTime")]
	public float AutoUpdatePathTime
	{
		get
		{
			CheckDestroyed();
			if (!AutoUpdatePathTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:AutoUpdatePathTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AutoUpdatePathTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoUpdatePathTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:AutoUpdatePathTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AutoUpdatePathTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:EnableLeisure")]
	public bool EnableLeisure
	{
		get
		{
			CheckDestroyed();
			if (!EnableLeisure_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:EnableLeisure");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableLeisure_Offset), 0, EnableLeisure_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableLeisure_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:EnableLeisure");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableLeisure_Offset), 0, EnableLeisure_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "EnableLeisure")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:IntervalTime")]
	public float IntervalTime
	{
		get
		{
			CheckDestroyed();
			if (!IntervalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:IntervalTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IntervalTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntervalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:IntervalTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IntervalTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:LeisureList")]
	public TArrayReadWrite<FGSLeisureWithWeight> LeisureList
	{
		get
		{
			CheckDestroyed();
			if (!LeisureList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig:LeisureList");
				return null;
			}
			if (LeisureList_Marshaler == null)
			{
				LeisureList_Marshaler = new TArrayReadWriteMarshaler<FGSLeisureWithWeight>(1, LeisureList_PropertyAddress, CachedMarshalingDelegates<FGSLeisureWithWeight, FGSLeisureWithWeight>.FromNative, CachedMarshalingDelegates<FGSLeisureWithWeight, FGSLeisureWithWeight>.ToNative);
			}
			return LeisureList_Marshaler.FromNative(IntPtr.Add(base.Address, LeisureList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AutoTestEQSRunConfig");
		AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AcceptableRadius");
		AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IncludeSelfRadius_PropertyAddress, unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncludeSelfRadius", Classes.FBoolProperty);
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EQSTemplate", Classes.FObjectProperty);
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
		AutoUpdatePathTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoUpdatePathTime");
		AutoUpdatePathTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoUpdatePathTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableLeisure_PropertyAddress, unrealStruct, "EnableLeisure");
		EnableLeisure_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableLeisure");
		EnableLeisure_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableLeisure", Classes.FBoolProperty);
		IntervalTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IntervalTime");
		IntervalTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IntervalTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref LeisureList_PropertyAddress, unrealStruct, "LeisureList");
		LeisureList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LeisureList");
		LeisureList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LeisureList", Classes.FArrayProperty);
	}

	static BGWDataAsset_AutoTestEQSRunConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AutoTestEQSRunConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AutoTestEQSRunConfig));
	}
}
