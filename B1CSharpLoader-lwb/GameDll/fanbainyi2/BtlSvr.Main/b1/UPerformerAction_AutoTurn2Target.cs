using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("演员自动转向玩家")]
[USharpPath("/Script/b1-Managed.PerformerAction_AutoTurn2Target")]
public class UPerformerAction_AutoTurn2Target : UPerformerActionBase
{
	private static bool Performer_IsValid;

	private static int Performer_Offset;

	private static bool TurnLeftMontage_IsValid;

	private static int TurnLeftMontage_Offset;

	private static bool TurnRightMontage_IsValid;

	private static int TurnRightMontage_Offset;

	private static bool TurnThreshold_IsValid;

	private static int TurnThreshold_Offset;

	private static bool TurnSpeed_IsValid;

	private static int TurnSpeed_Offset;

	private static bool PerformerOriginRotation_IsValid;

	private static int PerformerOriginRotation_Offset;

	private static bool PerformerActor_IsValid;

	private static int PerformerActor_Offset;

	private static bool PlayerActor_IsValid;

	private static int PlayerActor_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("演员")]
	[USharpPath("/Script/b1-Managed.PerformerAction_AutoTurn2Target:Performer")]
	public FGsSmartParam Performer
	{
		get
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:Performer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Performer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:Performer");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Performer_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("左转动画")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnLeftMontage")]
	public UAnimMontage TurnLeftMontage
	{
		get
		{
			CheckDestroyed();
			if (!TurnLeftMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnLeftMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, TurnLeftMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnLeftMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnLeftMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, TurnLeftMontage_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("右转动画")]
	[USharpPath("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnRightMontage")]
	public UAnimMontage TurnRightMontage
	{
		get
		{
			CheckDestroyed();
			if (!TurnRightMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnRightMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, TurnRightMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnRightMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnRightMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, TurnRightMontage_Offset), value);
			}
		}
	}

	[DisplayName("转身阈值（角度）")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnThreshold")]
	public float TurnThreshold
	{
		get
		{
			CheckDestroyed();
			if (!TurnThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TurnThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TurnThreshold_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("转身速度")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnSpeed")]
	public FInterpSpeed TurnSpeed
	{
		get
		{
			CheckDestroyed();
			if (!TurnSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnSpeed");
				return default(FInterpSpeed);
			}
			return FInterpSpeed.FromNative(IntPtr.Add(base.Address, TurnSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:TurnSpeed");
			}
			else
			{
				FInterpSpeed.ToNative(IntPtr.Add(base.Address, TurnSpeed_Offset), value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.PerformerAction_AutoTurn2Target:PerformerOriginRotation")]
	public FRotator PerformerOriginRotation
	{
		get
		{
			CheckDestroyed();
			if (!PerformerOriginRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:PerformerOriginRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, PerformerOriginRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformerOriginRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:PerformerOriginRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, PerformerOriginRotation_Offset), value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.PerformerAction_AutoTurn2Target:PerformerActor")]
	public BGUPerformerActorCS PerformerActor
	{
		get
		{
			CheckDestroyed();
			if (!PerformerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:PerformerActor");
				return null;
			}
			return UObjectMarshaler<BGUPerformerActorCS>.FromNative(IntPtr.Add(base.Address, PerformerActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:PerformerActor");
			}
			else
			{
				UObjectMarshaler<BGUPerformerActorCS>.ToNative(IntPtr.Add(base.Address, PerformerActor_Offset), value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.PerformerAction_AutoTurn2Target:PlayerActor")]
	public AActor PlayerActor
	{
		get
		{
			CheckDestroyed();
			if (!PlayerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:PlayerActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, PlayerActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlayerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_AutoTurn2Target:PlayerActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, PlayerActor_Offset), value);
			}
		}
	}

	protected override bool bCanAlwaysTick => true;

	public FRotator? PerformerBeginRotation { get; set; }

	public FRotator? PerformerEndRotation { get; set; }

	public float RotateTime { get; set; }

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		TurnThreshold = 45f;
		FInterpSpeed turnSpeed = new FInterpSpeed
		{
			InterpMode = ESpeedInterpMode.ByPercentage,
			Speed = 0.5f
		};
		TurnSpeed = turnSpeed;
	}

	protected override bool DoAction()
	{
		PerformerActor = GetPerformer(Performer);
		if (PerformerActor == null)
		{
			return true;
		}
		PlayerActor = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this).GetControlledPawn();
		PerformerOriginRotation = PerformerActor.GetActorRotation();
		return true;
	}

	protected override bool OnTick(float InDeltaTime)
	{
		if (PerformerActor == null)
		{
			return true;
		}
		if (!PerformerEndRotation.HasValue)
		{
			FRotator fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(PerformerActor);
			FVector start = BGUFuncLibActorTransformCS.BGUGetActorLocation(PerformerActor);
			FVector target = BGUFuncLibActorTransformCS.BGUGetActorLocation(PlayerActor);
			FRotator fRotator2 = MathLib.FindLookAtRotation(start, target);
			float num = FRotator.NormalizeAxis(MathLib.NormalizedDeltaRotator(fRotator2, fRotator).Yaw);
			if (FMath.Abs(num) > TurnThreshold)
			{
				PerformerEndRotation = fRotator2;
				PerformerBeginRotation = fRotator;
				RotateTime = 0f;
				BGUFuncLibAnim.BGUActorTryPlayMontage(PerformerActor, (num > 0f) ? TurnLeftMontage : TurnRightMontage, FName.None);
			}
		}
		if (PerformerBeginRotation.HasValue && PerformerEndRotation.HasValue)
		{
			RotateTime += InDeltaTime;
			FInterpSpeed turnSpeed = TurnSpeed;
			FRotator newRotation = PerformerEndRotation.Value;
			switch (turnSpeed.InterpMode)
			{
			case ESpeedInterpMode.ByPercentage:
				newRotation = FMath.RInterpTo(PerformerBeginRotation.Value, PerformerEndRotation.Value, RotateTime, turnSpeed.Speed);
				break;
			case ESpeedInterpMode.ByValue:
				newRotation = FMath.RInterpConstantTo(PerformerBeginRotation.Value, PerformerEndRotation.Value, RotateTime, turnSpeed.Speed);
				break;
			}
			if (FMath.Abs(newRotation.Yaw - PerformerEndRotation.Value.Yaw) < 0.1f)
			{
				newRotation = PerformerEndRotation.Value;
				PerformerBeginRotation = null;
				PerformerEndRotation = null;
			}
			PerformerActor.SetActorRotation(newRotation, bTeleportPhysics: true);
		}
		return true;
	}

	protected override void OnEndAction()
	{
		if (!(PerformerActor == null))
		{
			PerformerActor.SetActorRotation(PerformerOriginRotation, bTeleportPhysics: true);
			PerformerActor = null;
			PlayerActor = null;
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerAction_AutoTurn2Target");
		Performer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Performer");
		Performer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Performer", Classes.FStructProperty);
		TurnLeftMontage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TurnLeftMontage");
		TurnLeftMontage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TurnLeftMontage", Classes.FObjectProperty);
		TurnRightMontage_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TurnRightMontage");
		TurnRightMontage_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TurnRightMontage", Classes.FObjectProperty);
		TurnThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TurnThreshold");
		TurnThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TurnThreshold", Classes.FFloatProperty);
		TurnSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TurnSpeed");
		TurnSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TurnSpeed", Classes.FStructProperty);
		PerformerOriginRotation_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PerformerOriginRotation");
		PerformerOriginRotation_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PerformerOriginRotation", Classes.FStructProperty);
		PerformerActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PerformerActor");
		PerformerActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PerformerActor", Classes.FObjectProperty);
		PlayerActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PlayerActor");
		PlayerActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PlayerActor", Classes.FObjectProperty);
	}

	static UPerformerAction_AutoTurn2Target()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerAction_AutoTurn2Target)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerAction_AutoTurn2Target));
	}
}
