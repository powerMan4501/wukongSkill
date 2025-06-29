using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[CollapseCategories(true)]
[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting")]
public class BGWDataAsset_AbpPerformerSetting : UBGWDataAsset
{
	private static bool IdleAnim_IsValid;

	private static int IdleAnim_Offset;

	private static bool AimOffsetMappingCurve_IsValid;

	private static int AimOffsetMappingCurve_Offset;

	private static bool HeadAimOffset_IsValid;

	private static int HeadAimOffset_Offset;

	private static FFieldAddress HeadAimOffset_PropertyAddress;

	private TArrayReadWriteMarshaler<UAimOffsetBlendSpace> HeadAimOffset_Marshaler;

	private static bool HeadAimOffsetTurnSpeed_IsValid;

	private static int HeadAimOffsetTurnSpeed_Offset;

	private static bool HeadAimPitchRange_IsValid;

	private static int HeadAimPitchRange_Offset;

	private static bool HeadAimYawRange_IsValid;

	private static int HeadAimYawRange_Offset;

	private static bool EyeAimOffset_IsValid;

	private static int EyeAimOffset_Offset;

	private static FFieldAddress EyeAimOffset_PropertyAddress;

	private TArrayReadWriteMarshaler<UAimOffsetBlendSpace> EyeAimOffset_Marshaler;

	private static bool EyeAimOffsetTurnSpeed_IsValid;

	private static int EyeAimOffsetTurnSpeed_Offset;

	private static bool EyeAimPitchRange_IsValid;

	private static int EyeAimPitchRange_Offset;

	private static bool EyeAimYawRange_IsValid;

	private static int EyeAimYawRange_Offset;

	private static bool BlinkAnim_IsValid;

	private static int BlinkAnim_Offset;

	private static FFieldAddress BlinkAnim_PropertyAddress;

	private TArrayReadWriteMarshaler<FRandomAnims> BlinkAnim_Marshaler;

	private static bool BlinkTimeRange_IsValid;

	private static int BlinkTimeRange_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:IdleAnim")]
	public UAnimSequence IdleAnim
	{
		get
		{
			CheckDestroyed();
			if (!IdleAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:IdleAnim");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, IdleAnim_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IdleAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:IdleAnim");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, IdleAnim_Offset), value);
			}
		}
	}

	[DisplayName("AO映射曲线")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:AimOffsetMappingCurve")]
	public UCurveVector AimOffsetMappingCurve
	{
		get
		{
			CheckDestroyed();
			if (!AimOffsetMappingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:AimOffsetMappingCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, AimOffsetMappingCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AimOffsetMappingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:AimOffsetMappingCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, AimOffsetMappingCurve_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimOffset")]
	public TArrayReadWrite<UAimOffsetBlendSpace> HeadAimOffset
	{
		get
		{
			CheckDestroyed();
			if (!HeadAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimOffset");
				return null;
			}
			if (HeadAimOffset_Marshaler == null)
			{
				HeadAimOffset_Marshaler = new TArrayReadWriteMarshaler<UAimOffsetBlendSpace>(1, HeadAimOffset_PropertyAddress, CachedMarshalingDelegates<UAimOffsetBlendSpace, UObjectMarshaler<UAimOffsetBlendSpace>>.FromNative, CachedMarshalingDelegates<UAimOffsetBlendSpace, UObjectMarshaler<UAimOffsetBlendSpace>>.ToNative);
			}
			return HeadAimOffset_Marshaler.FromNative(IntPtr.Add(base.Address, HeadAimOffset_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimOffsetTurnSpeed")]
	public FInterpSpeed HeadAimOffsetTurnSpeed
	{
		get
		{
			CheckDestroyed();
			if (!HeadAimOffsetTurnSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimOffsetTurnSpeed");
				return default(FInterpSpeed);
			}
			return FInterpSpeed.FromNative(IntPtr.Add(base.Address, HeadAimOffsetTurnSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeadAimOffsetTurnSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimOffsetTurnSpeed");
			}
			else
			{
				FInterpSpeed.ToNative(IntPtr.Add(base.Address, HeadAimOffsetTurnSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimPitchRange")]
	public FVector2D HeadAimPitchRange
	{
		get
		{
			CheckDestroyed();
			if (!HeadAimPitchRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimPitchRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, HeadAimPitchRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeadAimPitchRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimPitchRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, HeadAimPitchRange_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimYawRange")]
	public FVector2D HeadAimYawRange
	{
		get
		{
			CheckDestroyed();
			if (!HeadAimYawRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimYawRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, HeadAimYawRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeadAimYawRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:HeadAimYawRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, HeadAimYawRange_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimOffset")]
	public TArrayReadWrite<UAimOffsetBlendSpace> EyeAimOffset
	{
		get
		{
			CheckDestroyed();
			if (!EyeAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimOffset");
				return null;
			}
			if (EyeAimOffset_Marshaler == null)
			{
				EyeAimOffset_Marshaler = new TArrayReadWriteMarshaler<UAimOffsetBlendSpace>(1, EyeAimOffset_PropertyAddress, CachedMarshalingDelegates<UAimOffsetBlendSpace, UObjectMarshaler<UAimOffsetBlendSpace>>.FromNative, CachedMarshalingDelegates<UAimOffsetBlendSpace, UObjectMarshaler<UAimOffsetBlendSpace>>.ToNative);
			}
			return EyeAimOffset_Marshaler.FromNative(IntPtr.Add(base.Address, EyeAimOffset_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimOffsetTurnSpeed")]
	public FInterpSpeed EyeAimOffsetTurnSpeed
	{
		get
		{
			CheckDestroyed();
			if (!EyeAimOffsetTurnSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimOffsetTurnSpeed");
				return default(FInterpSpeed);
			}
			return FInterpSpeed.FromNative(IntPtr.Add(base.Address, EyeAimOffsetTurnSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EyeAimOffsetTurnSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimOffsetTurnSpeed");
			}
			else
			{
				FInterpSpeed.ToNative(IntPtr.Add(base.Address, EyeAimOffsetTurnSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimPitchRange")]
	public FVector2D EyeAimPitchRange
	{
		get
		{
			CheckDestroyed();
			if (!EyeAimPitchRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimPitchRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, EyeAimPitchRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EyeAimPitchRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimPitchRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, EyeAimPitchRange_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimYawRange")]
	public FVector2D EyeAimYawRange
	{
		get
		{
			CheckDestroyed();
			if (!EyeAimYawRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimYawRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, EyeAimYawRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EyeAimYawRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:EyeAimYawRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, EyeAimYawRange_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("眨眼动画")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:BlinkAnim")]
	public TArrayReadWrite<FRandomAnims> BlinkAnim
	{
		get
		{
			CheckDestroyed();
			if (!BlinkAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:BlinkAnim");
				return null;
			}
			if (BlinkAnim_Marshaler == null)
			{
				BlinkAnim_Marshaler = new TArrayReadWriteMarshaler<FRandomAnims>(1, BlinkAnim_PropertyAddress, CachedMarshalingDelegates<FRandomAnims, FRandomAnims>.FromNative, CachedMarshalingDelegates<FRandomAnims, FRandomAnims>.ToNative);
			}
			return BlinkAnim_Marshaler.FromNative(IntPtr.Add(base.Address, BlinkAnim_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("眨眼随机间隔时间")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:BlinkTimeRange")]
	public FVector2D BlinkTimeRange
	{
		get
		{
			CheckDestroyed();
			if (!BlinkTimeRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:BlinkTimeRange");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, BlinkTimeRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlinkTimeRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting:BlinkTimeRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, BlinkTimeRange_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		FInterpSpeed fInterpSpeed = new FInterpSpeed
		{
			InterpMode = ESpeedInterpMode.ByPercentage,
			Speed = 1f
		};
		HeadAimOffsetTurnSpeed = fInterpSpeed;
		EyeAimOffsetTurnSpeed = fInterpSpeed;
		FVector2D eyeAimYawRange = (EyeAimPitchRange = (HeadAimYawRange = (HeadAimPitchRange = new FVector2D(-89.9000015258789, 89.9000015258789))));
		EyeAimYawRange = eyeAimYawRange;
		BlinkTimeRange = new FVector2D(3.0, 5.0);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_AbpPerformerSetting");
		IdleAnim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IdleAnim");
		IdleAnim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IdleAnim", Classes.FObjectProperty);
		AimOffsetMappingCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AimOffsetMappingCurve");
		AimOffsetMappingCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AimOffsetMappingCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref HeadAimOffset_PropertyAddress, unrealStruct, "HeadAimOffset");
		HeadAimOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeadAimOffset");
		HeadAimOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeadAimOffset", Classes.FArrayProperty);
		HeadAimOffsetTurnSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeadAimOffsetTurnSpeed");
		HeadAimOffsetTurnSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeadAimOffsetTurnSpeed", Classes.FStructProperty);
		HeadAimPitchRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeadAimPitchRange");
		HeadAimPitchRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeadAimPitchRange", Classes.FStructProperty);
		HeadAimYawRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeadAimYawRange");
		HeadAimYawRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeadAimYawRange", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref EyeAimOffset_PropertyAddress, unrealStruct, "EyeAimOffset");
		EyeAimOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EyeAimOffset");
		EyeAimOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EyeAimOffset", Classes.FArrayProperty);
		EyeAimOffsetTurnSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EyeAimOffsetTurnSpeed");
		EyeAimOffsetTurnSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EyeAimOffsetTurnSpeed", Classes.FStructProperty);
		EyeAimPitchRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EyeAimPitchRange");
		EyeAimPitchRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EyeAimPitchRange", Classes.FStructProperty);
		EyeAimYawRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EyeAimYawRange");
		EyeAimYawRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EyeAimYawRange", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref BlinkAnim_PropertyAddress, unrealStruct, "BlinkAnim");
		BlinkAnim_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlinkAnim");
		BlinkAnim_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlinkAnim", Classes.FArrayProperty);
		BlinkTimeRange_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BlinkTimeRange");
		BlinkTimeRange_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BlinkTimeRange", Classes.FStructProperty);
	}

	static BGWDataAsset_AbpPerformerSetting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_AbpPerformerSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_AbpPerformerSetting));
	}
}
