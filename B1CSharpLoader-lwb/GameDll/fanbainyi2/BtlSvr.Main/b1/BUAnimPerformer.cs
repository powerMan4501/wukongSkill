using System;
using System.Collections.Generic;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BUAnimPerformer")]
public class BUAnimPerformer : UAnimInstance
{
	private FRandomAnims BlinkAnim;

	private FInterpSpeed HeadAimOffsetTurnSpeed;

	private FInterpSpeed EyeAimOffsetTurnSpeed;

	private FVector2D HeadAimOffsetPitchRange;

	private FVector2D HeadAimOffsetYawRange;

	private FVector2D EyeAimOffsetPitchRange;

	private FVector2D EyeAimOffsetYawRange;

	private float RandomBlinkTime;

	private FVector2D BlinkTimeRange;

	private static bool ABPSetting_IsValid;

	private static int ABPSetting_Offset;

	private static bool EnableHeadAimOffset_IsValid;

	private static int EnableHeadAimOffset_Offset;

	private static FFieldAddress EnableHeadAimOffset_PropertyAddress;

	private static bool HeadAimLookAtRotation_IsValid;

	private static int HeadAimLookAtRotation_Offset;

	private static bool HeadAimAlpha_IsValid;

	private static int HeadAimAlpha_Offset;

	private static bool AimOffsetMappingCurve_IsValid;

	private static int AimOffsetMappingCurve_Offset;

	private static bool EnableEyeAimOffset_IsValid;

	private static int EnableEyeAimOffset_Offset;

	private static FFieldAddress EnableEyeAimOffset_PropertyAddress;

	private static bool EyeAimLookAtRotation_IsValid;

	private static int EyeAimLookAtRotation_Offset;

	private static bool EyeAimAlpha_IsValid;

	private static int EyeAimAlpha_Offset;

	private static bool bCanSwitchBlinkAnim_IsValid;

	private static int bCanSwitchBlinkAnim_Offset;

	private static FFieldAddress bCanSwitchBlinkAnim_PropertyAddress;

	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool HeadAimOffset_IsValid;

	private static int HeadAimOffset_Offset;

	private static bool EyeAimOffset_IsValid;

	private static int EyeAimOffset_Offset;

	private static bool GetRandomBlinkAnim_IsValid;

	private static IntPtr GetRandomBlinkAnim_FunctionAddress;

	private static int GetRandomBlinkAnim_ParamsSize;

	private static bool GetRandomBlinkAnim_Context_IsValid;

	private static int GetRandomBlinkAnim_Context_Offset;

	private static FFieldAddress GetRandomBlinkAnim_Context_PropertyAddress;

	private static bool GetRandomBlinkAnim_Node_IsValid;

	private static int GetRandomBlinkAnim_Node_Offset;

	private static FFieldAddress GetRandomBlinkAnim_Node_PropertyAddress;

	private static bool BlueprintUpdateAnimation_IsValid;

	private static IntPtr BlueprintUpdateAnimation_FunctionAddress;

	private static int BlueprintUpdateAnimation_ParamsSize;

	private static bool BlueprintUpdateAnimation_DeltaTimeX_IsValid;

	private static int BlueprintUpdateAnimation_DeltaTimeX_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	[Category("ABP Setting")]
	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:ABPSetting")]
	public BGWDataAsset_AbpPerformerSetting ABPSetting
	{
		get
		{
			CheckDestroyed();
			if (!ABPSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:ABPSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AbpPerformerSetting>.FromNative(IntPtr.Add(base.Address, ABPSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ABPSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:ABPSetting");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AbpPerformerSetting>.ToNative(IntPtr.Add(base.Address, ABPSetting_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("Head Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:EnableHeadAimOffset")]
	public bool EnableHeadAimOffset
	{
		get
		{
			CheckDestroyed();
			if (!EnableHeadAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:EnableHeadAimOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableHeadAimOffset_Offset), 0, EnableHeadAimOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableHeadAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:EnableHeadAimOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableHeadAimOffset_Offset), 0, EnableHeadAimOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("Head Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:HeadAimLookAtRotation")]
	public FRotator HeadAimLookAtRotation
	{
		get
		{
			CheckDestroyed();
			if (!HeadAimLookAtRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:HeadAimLookAtRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, HeadAimLookAtRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeadAimLookAtRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:HeadAimLookAtRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, HeadAimLookAtRotation_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("Head Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:HeadAimAlpha")]
	public float HeadAimAlpha
	{
		get
		{
			CheckDestroyed();
			if (!HeadAimAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:HeadAimAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HeadAimAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeadAimAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:HeadAimAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HeadAimAlpha_Offset), value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[Category("Head Aim")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:AimOffsetMappingCurve")]
	public UCurveVector AimOffsetMappingCurve
	{
		get
		{
			CheckDestroyed();
			if (!AimOffsetMappingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:AimOffsetMappingCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, AimOffsetMappingCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AimOffsetMappingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:AimOffsetMappingCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, AimOffsetMappingCurve_Offset), value);
			}
		}
	}

	[Category("Eye Aim")]
	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:EnableEyeAimOffset")]
	public bool EnableEyeAimOffset
	{
		get
		{
			CheckDestroyed();
			if (!EnableEyeAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:EnableEyeAimOffset");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableEyeAimOffset_Offset), 0, EnableEyeAimOffset_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableEyeAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:EnableEyeAimOffset");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableEyeAimOffset_Offset), 0, EnableEyeAimOffset_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintVisible(ReadOnly = true)]
	[Category("Eye Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:EyeAimLookAtRotation")]
	public FRotator EyeAimLookAtRotation
	{
		get
		{
			CheckDestroyed();
			if (!EyeAimLookAtRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:EyeAimLookAtRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, EyeAimLookAtRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EyeAimLookAtRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:EyeAimLookAtRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, EyeAimLookAtRotation_Offset), value);
			}
		}
	}

	[BlueprintVisible(ReadOnly = true)]
	[UProperty]
	[Category("Eye Aim")]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:EyeAimAlpha")]
	public float EyeAimAlpha
	{
		get
		{
			CheckDestroyed();
			if (!EyeAimAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:EyeAimAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EyeAimAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EyeAimAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:EyeAimAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EyeAimAlpha_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Eye Aim")]
	[BlueprintVisible(ReadOnly = true)]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:bCanSwitchBlinkAnim")]
	public bool bCanSwitchBlinkAnim
	{
		get
		{
			CheckDestroyed();
			if (!bCanSwitchBlinkAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:bCanSwitchBlinkAnim");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bCanSwitchBlinkAnim_Offset), 0, bCanSwitchBlinkAnim_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bCanSwitchBlinkAnim_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:bCanSwitchBlinkAnim");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bCanSwitchBlinkAnim_Offset), 0, bCanSwitchBlinkAnim_PropertyAddress.Address, value);
			}
		}
	}

	[Category("Anims")]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	[Category("Anims")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:HeadAimOffset")]
	public UAimOffsetBlendSpace HeadAimOffset
	{
		get
		{
			CheckDestroyed();
			if (!HeadAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:HeadAimOffset");
				return null;
			}
			return UObjectMarshaler<UAimOffsetBlendSpace>.FromNative(IntPtr.Add(base.Address, HeadAimOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeadAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:HeadAimOffset");
			}
			else
			{
				UObjectMarshaler<UAimOffsetBlendSpace>.ToNative(IntPtr.Add(base.Address, HeadAimOffset_Offset), value);
			}
		}
	}

	[Category("Anims")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:EyeAimOffset")]
	public UAimOffsetBlendSpace EyeAimOffset
	{
		get
		{
			CheckDestroyed();
			if (!EyeAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:EyeAimOffset");
				return null;
			}
			return UObjectMarshaler<UAimOffsetBlendSpace>.FromNative(IntPtr.Add(base.Address, EyeAimOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EyeAimOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimPerformer:EyeAimOffset");
			}
			else
			{
				UObjectMarshaler<UAimOffsetBlendSpace>.ToNative(IntPtr.Add(base.Address, EyeAimOffset_Offset), value);
			}
		}
	}

	public void SetHeadAimOffsetIndex(int Index)
	{
		if (Index >= 0 && ABPSetting.HeadAimOffset.Count > Index)
		{
			HeadAimOffset = ABPSetting.HeadAimOffset[Index];
		}
		else
		{
			HeadAimOffset = null;
		}
		if (Index >= 0 && ABPSetting.BlinkAnim.Count > Index)
		{
			BlinkAnim = ABPSetting.BlinkAnim[Index];
		}
		else
		{
			BlinkAnim = default(FRandomAnims);
		}
		EnableHeadAimOffset = HeadAimOffset != null;
	}

	public void SetEyeAimOffsetIndex(int Index)
	{
		if (Index >= 0 && ABPSetting.EyeAimOffset.Count > Index)
		{
			EyeAimOffset = ABPSetting.EyeAimOffset[Index];
		}
		else
		{
			EyeAimOffset = null;
		}
		EnableEyeAimOffset = EyeAimOffset != null;
	}

	[USharpPath("/Script/b1-Managed.BUAnimPerformer:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
		if (ABPSetting != null)
		{
			HeadAimOffsetTurnSpeed = ABPSetting.HeadAimOffsetTurnSpeed;
			EyeAimOffsetTurnSpeed = ABPSetting.EyeAimOffsetTurnSpeed;
			AnimIdle = ABPSetting.IdleAnim;
			SetHeadAimOffsetIndex(0);
			HeadAimAlpha = 1f;
			HeadAimOffsetPitchRange = ABPSetting.HeadAimPitchRange;
			HeadAimOffsetYawRange = ABPSetting.HeadAimYawRange;
			EyeAimOffset = null;
			EnableEyeAimOffset = EyeAimOffset != null;
			EyeAimAlpha = 1f;
			EyeAimOffsetPitchRange = ABPSetting.EyeAimPitchRange;
			EyeAimOffsetYawRange = ABPSetting.EyeAimYawRange;
			BlinkTimeRange = ABPSetting.BlinkTimeRange;
			AimOffsetMappingCurve = ABPSetting.AimOffsetMappingCurve;
		}
		else
		{
			BlinkTimeRange = new FVector2D(3.0, 5.0);
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnimPerformer:BlueprintUpdateAnimation")]
	protected override void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
	{
		USkeletalMeshComponent owningComponent = GetOwningComponent();
		AActor owningActor = GetOwningActor();
		if (owningComponent != null && owningActor != null)
		{
			FRotator Target = FRotator.ZeroRotator;
			FRotator Target2 = FRotator.ZeroRotator;
			APawn aPawn = UGSE_EngineFuncLib.GetFirstLocalPlayerController(owningActor)?.GetControlledPawn();
			if (aPawn != null)
			{
				FVector actorLocation = aPawn.GetActorLocation();
				FVector socketLocation = owningComponent.GetSocketLocation(B1GlobalFNames.head);
				owningComponent.GetSocketRotation(B1GlobalFNames.head);
				FVector socketLocation2 = owningComponent.GetSocketLocation(B1GlobalFNames.AO_Eye);
				FRotator socketRotation = owningComponent.GetSocketRotation(B1GlobalFNames.AO_EyeBase);
				FRotator actorRotation = owningActor.GetActorRotation();
				FRotator a = MathLib.FindLookAtRotation(socketLocation, actorLocation);
				Target = MathLib.NormalizedDeltaRotator(a, actorRotation);
				FRotator a2 = MathLib.FindLookAtRotation(socketLocation2, actorLocation);
				Target2 = MathLib.NormalizedDeltaRotator(a2, socketRotation);
			}
			if (AimOffsetMappingCurve != null)
			{
				Target.Yaw = AimOffsetMappingCurve.GetVectorValue(Target.Yaw).X;
				Target.Pitch = AimOffsetMappingCurve.GetVectorValue(Target.Pitch).Y;
			}
			FRotator Current = HeadAimLookAtRotation;
			switch (HeadAimOffsetTurnSpeed.InterpMode)
			{
			case ESpeedInterpMode.ByPercentage:
				Current = MathLib.RInterpTo(in Current, in Target, DeltaTimeX, HeadAimOffsetTurnSpeed.Speed);
				break;
			case ESpeedInterpMode.ByValue:
				Current = MathLib.RInterpConstantTo(in Current, in Target, DeltaTimeX, HeadAimOffsetTurnSpeed.Speed);
				break;
			}
			Current.Pitch = FMath.ClampAngle(Current.Pitch, HeadAimOffsetPitchRange.X, HeadAimOffsetPitchRange.Y);
			Current.Yaw = FMath.ClampAngle(Current.Yaw, HeadAimOffsetYawRange.X, HeadAimOffsetYawRange.Y);
			HeadAimLookAtRotation = Current;
			Current = EyeAimLookAtRotation;
			switch (EyeAimOffsetTurnSpeed.InterpMode)
			{
			case ESpeedInterpMode.ByPercentage:
				Current = MathLib.RInterpTo(in Current, in Target2, DeltaTimeX, EyeAimOffsetTurnSpeed.Speed);
				break;
			case ESpeedInterpMode.ByValue:
				Current = MathLib.RInterpConstantTo(in Current, in Target2, DeltaTimeX, EyeAimOffsetTurnSpeed.Speed);
				break;
			}
			Current.Pitch = FMath.ClampAngle(Current.Pitch, EyeAimOffsetPitchRange.X, EyeAimOffsetPitchRange.Y);
			Current.Yaw = FMath.ClampAngle(Current.Yaw, EyeAimOffsetYawRange.X, EyeAimOffsetYawRange.Y);
			EyeAimLookAtRotation = Current;
		}
		else
		{
			HeadAimLookAtRotation = FRotator.ZeroRotator;
			EyeAimLookAtRotation = FRotator.ZeroRotator;
		}
		RandomBlinkTime -= DeltaTimeX;
		bCanSwitchBlinkAnim = RandomBlinkTime <= 1E-08f;
	}

	[UFunction]
	[BlueprintCallable]
	[UMeta(MDClass.BlueprintThreadSafe)]
	[Category("Thread Safe")]
	[USharpPath("/Script/b1-Managed.BUAnimPerformer:GetRandomBlinkAnim")]
	private void GetRandomBlinkAnim(ref FAnimUpdateContext Context, ref FAnimNodeReference Node)
	{
		USequencePlayerLibrary.ConvertToSequencePlayerPure(Node, out var SequencePlayer, out var Result);
		if (Result)
		{
			UAnimSequence uAnimSequence = null;
			List<UAnimSequence> animSequences = BlinkAnim.AnimSequences;
			if (animSequences == null || animSequences.Count == 0)
			{
				uAnimSequence = null;
			}
			else
			{
				int index = FMath.RandRange(0, animSequences.Count - 1);
				uAnimSequence = animSequences[index];
			}
			RandomBlinkTime = FMath.RandRange(BlinkTimeRange.X, BlinkTimeRange.Y);
			bCanSwitchBlinkAnim = RandomBlinkTime <= 1E-08f;
			USequencePlayerLibrary.SetSequence(SequencePlayer, uAnimSequence);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimPerformer:GetRandomBlinkAnim")]
	private static void GetRandomBlinkAnim__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimPerformer bUAnimPerformer = GCHelper.Find<BUAnimPerformer>(obj);
		FAnimUpdateContext Context = StructAsClassMarshaler<FAnimUpdateContext>.FromNative(IntPtr.Add(buffer, GetRandomBlinkAnim_Context_Offset));
		FAnimNodeReference Node = StructAsClassMarshaler<FAnimNodeReference>.FromNative(IntPtr.Add(buffer, GetRandomBlinkAnim_Node_Offset));
		bUAnimPerformer.GetRandomBlinkAnim(ref Context, ref Node);
		StructAsClassMarshaler<FAnimUpdateContext>.ToNative(IntPtr.Add(buffer, GetRandomBlinkAnim_Context_Offset), Context);
		StructAsClassMarshaler<FAnimNodeReference>.ToNative(IntPtr.Add(buffer, GetRandomBlinkAnim_Node_Offset), Node);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimPerformer:BlueprintUpdateAnimation")]
	private static void BlueprintUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimPerformer bUAnimPerformer = GCHelper.Find<BUAnimPerformer>(obj);
		float deltaTimeX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateAnimation_DeltaTimeX_Offset));
		bUAnimPerformer.BlueprintUpdateAnimation_Implementation(deltaTimeX);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimPerformer:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimPerformer bUAnimPerformer = GCHelper.Find<BUAnimPerformer>(obj);
		bUAnimPerformer.BlueprintInitializeAnimation_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimPerformer");
		ABPSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "ABPSetting");
		ABPSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ABPSetting", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref EnableHeadAimOffset_PropertyAddress, intPtr, "EnableHeadAimOffset");
		EnableHeadAimOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableHeadAimOffset");
		EnableHeadAimOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableHeadAimOffset", Classes.FBoolProperty);
		HeadAimLookAtRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeadAimLookAtRotation");
		HeadAimLookAtRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeadAimLookAtRotation", Classes.FStructProperty);
		HeadAimAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeadAimAlpha");
		HeadAimAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeadAimAlpha", Classes.FFloatProperty);
		AimOffsetMappingCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "AimOffsetMappingCurve");
		AimOffsetMappingCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AimOffsetMappingCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref EnableEyeAimOffset_PropertyAddress, intPtr, "EnableEyeAimOffset");
		EnableEyeAimOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableEyeAimOffset");
		EnableEyeAimOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableEyeAimOffset", Classes.FBoolProperty);
		EyeAimLookAtRotation_Offset = NativeReflection.GetPropertyOffset(intPtr, "EyeAimLookAtRotation");
		EyeAimLookAtRotation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EyeAimLookAtRotation", Classes.FStructProperty);
		EyeAimAlpha_Offset = NativeReflection.GetPropertyOffset(intPtr, "EyeAimAlpha");
		EyeAimAlpha_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EyeAimAlpha", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bCanSwitchBlinkAnim_PropertyAddress, intPtr, "bCanSwitchBlinkAnim");
		bCanSwitchBlinkAnim_Offset = NativeReflection.GetPropertyOffset(intPtr, "bCanSwitchBlinkAnim");
		bCanSwitchBlinkAnim_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bCanSwitchBlinkAnim", Classes.FBoolProperty);
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdle", Classes.FObjectProperty);
		HeadAimOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeadAimOffset");
		HeadAimOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeadAimOffset", Classes.FObjectProperty);
		EyeAimOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "EyeAimOffset");
		EyeAimOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EyeAimOffset", Classes.FObjectProperty);
		GetRandomBlinkAnim_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRandomBlinkAnim");
		GetRandomBlinkAnim_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomBlinkAnim_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetRandomBlinkAnim_Context_PropertyAddress, GetRandomBlinkAnim_FunctionAddress, "Context");
		GetRandomBlinkAnim_Context_Offset = NativeReflection.GetPropertyOffset(GetRandomBlinkAnim_FunctionAddress, "Context");
		GetRandomBlinkAnim_Context_IsValid = NativeReflection.ValidatePropertyClass(GetRandomBlinkAnim_FunctionAddress, "Context", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref GetRandomBlinkAnim_Node_PropertyAddress, GetRandomBlinkAnim_FunctionAddress, "Node");
		GetRandomBlinkAnim_Node_Offset = NativeReflection.GetPropertyOffset(GetRandomBlinkAnim_FunctionAddress, "Node");
		GetRandomBlinkAnim_Node_IsValid = NativeReflection.ValidatePropertyClass(GetRandomBlinkAnim_FunctionAddress, "Node", Classes.FStructProperty);
		GetRandomBlinkAnim_IsValid = GetRandomBlinkAnim_FunctionAddress != IntPtr.Zero && GetRandomBlinkAnim_Context_IsValid && GetRandomBlinkAnim_Node_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimPerformer:GetRandomBlinkAnim", GetRandomBlinkAnim_IsValid);
		BlueprintUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintUpdateAnimation");
		BlueprintUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateAnimation_FunctionAddress);
		BlueprintUpdateAnimation_DeltaTimeX_Offset = NativeReflection.GetPropertyOffset(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX");
		BlueprintUpdateAnimation_DeltaTimeX_IsValid = NativeReflection.ValidatePropertyClass(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX", Classes.FFloatProperty);
		BlueprintUpdateAnimation_IsValid = BlueprintUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintUpdateAnimation_DeltaTimeX_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimPerformer:BlueprintUpdateAnimation", BlueprintUpdateAnimation_IsValid);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimPerformer:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
	}

	static BUAnimPerformer()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimPerformer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimPerformer));
	}
}
