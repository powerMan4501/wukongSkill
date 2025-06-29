using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAIT_RunAway")]
[UClass]
[USharpPath("/Script/b1-Managed.BAIT_RunAway")]
internal class BAIT_RunAway : BAIT_Base
{
	private float bLifeTime;

	private float bRestTime;

	private float bRestTimeInterval;

	private float bMoveTimeInterval;

	private bool achieveTargetPos;

	private float bAchieveLifeTime;

	private static bool RestRadius_IsValid;

	private static int RestRadius_Offset;

	private static bool RestTime_IsValid;

	private static int RestTime_Offset;

	private static bool RestTimeInterval_IsValid;

	private static int RestTimeInterval_Offset;

	private static bool MoveTimeInterval_IsValid;

	private static int MoveTimeInterval_Offset;

	private static bool LifeTime_IsValid;

	private static int LifeTime_Offset;

	private static bool MoveToTargetPoint_IsValid;

	private static int MoveToTargetPoint_Offset;

	private static FFieldAddress MoveToTargetPoint_PropertyAddress;

	private static bool ToTargetPoint_IsValid;

	private static int ToTargetPoint_Offset;

	private static bool AchieveLifeTime_IsValid;

	private static int AchieveLifeTime_Offset;

	private static bool AcceptableRadius_IsValid;

	private static int AcceptableRadius_Offset;

	private static bool IncludeSelfRadius_IsValid;

	private static int IncludeSelfRadius_Offset;

	private static FFieldAddress IncludeSelfRadius_PropertyAddress;

	private static bool SpeedRateType_IsValid;

	private static int SpeedRateType_Offset;

	private static FFieldAddress SpeedRateType_PropertyAddress;

	private static bool MoveAIType_IsValid;

	private static int MoveAIType_Offset;

	private static FFieldAddress MoveAIType_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("逃离休息距离")]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:RestRadius")]
	public float RestRadius
	{
		get
		{
			CheckDestroyed();
			if (!RestRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:RestRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RestRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RestRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:RestRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RestRadius_Offset), value);
			}
		}
	}

	[DisplayName("逃离休息时间")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:RestTime")]
	public float RestTime
	{
		get
		{
			CheckDestroyed();
			if (!RestTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:RestTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RestTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RestTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:RestTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RestTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("逃离休息时间间隔")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:RestTimeInterval")]
	public float RestTimeInterval
	{
		get
		{
			CheckDestroyed();
			if (!RestTimeInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:RestTimeInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RestTimeInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RestTimeInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:RestTimeInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RestTimeInterval_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("移动决策时间间隔")]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:MoveTimeInterval")]
	public float MoveTimeInterval
	{
		get
		{
			CheckDestroyed();
			if (!MoveTimeInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:MoveTimeInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MoveTimeInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MoveTimeInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:MoveTimeInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MoveTimeInterval_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("存活时间")]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:LifeTime")]
	public float LifeTime
	{
		get
		{
			CheckDestroyed();
			if (!LifeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:LifeTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LifeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LifeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:LifeTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LifeTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("向固定点移动")]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:MoveToTargetPoint")]
	public bool MoveToTargetPoint
	{
		get
		{
			CheckDestroyed();
			if (!MoveToTargetPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:MoveToTargetPoint");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MoveToTargetPoint_Offset), 0, MoveToTargetPoint_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveToTargetPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:MoveToTargetPoint");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MoveToTargetPoint_Offset), 0, MoveToTargetPoint_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("固定点坐标")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:ToTargetPoint")]
	public FVector ToTargetPoint
	{
		get
		{
			CheckDestroyed();
			if (!ToTargetPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:ToTargetPoint");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ToTargetPoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ToTargetPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:ToTargetPoint");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ToTargetPoint_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("抵达固定点后存活时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:AchieveLifeTime")]
	public float AchieveLifeTime
	{
		get
		{
			CheckDestroyed();
			if (!AchieveLifeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:AchieveLifeTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AchieveLifeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AchieveLifeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:AchieveLifeTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AchieveLifeTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "!EnableRangeAcceptableRadius && !UseConfigRadius")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:AcceptableRadius")]
	public float AcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:AcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:AcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AcceptableRadius_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:IncludeSelfRadius")]
	public bool IncludeSelfRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:IncludeSelfRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:IncludeSelfRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:SpeedRateType");
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
	[USharpPath("/Script/b1-Managed.BAIT_RunAway:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_RunAway:MoveAIType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SpeedRateType = EAIMoveSpeedType.RUN;
		bRestTime = RestTime;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (OwnerActor as ACharacter == null)
		{
			USystemLibrary.PrintString(this, "BAIT_MoveTo Failed, OwnerCharacter is null!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
			FinishExecute(bSuccess: false);
		}
		bLifeTime = LifeTime;
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		if (!(OwnerActor is BGUCharacterCS bGUCharacterCS))
		{
			EndThisNode();
			return;
		}
		LifeTick(bGUCharacterCS, DeltaSeconds);
		bRestTimeInterval -= DeltaSeconds;
		if (bRestTime > 0f)
		{
			bRestTime -= DeltaSeconds;
		}
		else if (BGUFunctionLibraryCS.BGUHasUnitState(bGUCharacterCS, EBGUUnitState.Dead) || BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.PendingDeathInAnimationSyncing))
		{
			FinishExecute(bSuccess: true);
		}
		else if (bMoveTimeInterval >= 0f)
		{
			bMoveTimeInterval -= DeltaSeconds;
			if (!(bMoveTimeInterval < 0f))
			{
				return;
			}
			AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS);
			if (!(aActor != null))
			{
				return;
			}
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor) - BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
			if (fVector.Vector_Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS)) > (double)RestRadius && bRestTimeInterval <= 0f)
			{
				bRestTime = RestTime;
				bRestTimeInterval = RestTimeInterval;
				return;
			}
			fVector.Z = 0f;
			fVector.Normalize();
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS) - fVector * 500.0;
			if (MoveToTargetPoint)
			{
				fVector2 = ToTargetPoint;
			}
			if (!UNavigationSystemV1.ProjectPointToNavigation(bGUCharacterCS, fVector2, out var ProjectedLocation, null, null, new FVector(0.0, 0.0, 0.0)))
			{
				float value = (float)Math.PI / 2f;
				fVector.X *= FMath.Cos(value);
				fVector.Y *= FMath.Sin(value);
				fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS) - fVector * 500.0;
				if (!UNavigationSystemV1.ProjectPointToNavigation(bGUCharacterCS, fVector2, out ProjectedLocation, null, null, new FVector(0.0, 0.0, 0.0)))
				{
					value = (float)FMath.RandRange(90, 360) * (float)Math.PI / 180f;
					fVector.X *= FMath.Cos(value);
					fVector.Y *= FMath.Sin(value);
					fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS) - fVector * 5000.0;
					if (UNavigationSystemV1.ProjectPointToNavigation(bGUCharacterCS, fVector2, out ProjectedLocation, null, null, new FVector(0.0, 0.0, 0.0)))
					{
						bMoveTimeInterval = 5f;
					}
				}
			}
			BGUFuncLibForMove.BeginMoveToPos(bGUCharacterCS, fVector2, AcceptableRadius, SpeedRateType, MoveAIType, IncludeSelfRadius, IncludeTargetRadius: true, out var _);
		}
		else
		{
			bMoveTimeInterval = MoveTimeInterval;
		}
	}

	public override void ReceiveAbort(AActor OwnerActor)
	{
		ACharacter aCharacter = OwnerActor as ACharacter;
		if (aCharacter == null)
		{
			FinishAbort();
			return;
		}
		BGUFuncLibForMove.CancelMove(aCharacter);
		FinishAbort();
	}

	private void UnitHidden(APawn ControlledPawn)
	{
		ACharacter aCharacter = ControlledPawn as ACharacter;
		if (aCharacter != null)
		{
			BUS_EventCollectionCS.Get(aCharacter).Evt_UnitDead.Invoke(aCharacter, EDeadReason.OnlyDestroyUnit);
		}
	}

	private void LifeTick(APawn ControlledPawn, float DeltaSeconds)
	{
		if (!(bLifeTime > 0f))
		{
			return;
		}
		bLifeTime -= DeltaSeconds;
		if (bLifeTime <= 0f)
		{
			UnitHidden(ControlledPawn);
		}
		if (achieveTargetPos)
		{
			if (bAchieveLifeTime > 0f)
			{
				bAchieveLifeTime -= DeltaSeconds;
				if (bAchieveLifeTime <= 0f)
				{
					UnitHidden(ControlledPawn);
				}
			}
		}
		else
		{
			ACharacter needGetInfoActor = ControlledPawn as ACharacter;
			if (ToTargetPoint.Vector_Distance(BGUFuncLibActorTransformCS.BGUGetActorLocation(needGetInfoActor)) < 100.0)
			{
				achieveTargetPos = true;
				bAchieveLifeTime = AchieveLifeTime;
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_RunAway");
		RestRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RestRadius");
		RestRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RestRadius", Classes.FFloatProperty);
		RestTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RestTime");
		RestTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RestTime", Classes.FFloatProperty);
		RestTimeInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RestTimeInterval");
		RestTimeInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RestTimeInterval", Classes.FFloatProperty);
		MoveTimeInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveTimeInterval");
		MoveTimeInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveTimeInterval", Classes.FFloatProperty);
		LifeTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LifeTime");
		LifeTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LifeTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref MoveToTargetPoint_PropertyAddress, unrealStruct, "MoveToTargetPoint");
		MoveToTargetPoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveToTargetPoint");
		MoveToTargetPoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveToTargetPoint", Classes.FBoolProperty);
		ToTargetPoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ToTargetPoint");
		ToTargetPoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ToTargetPoint", Classes.FStructProperty);
		AchieveLifeTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AchieveLifeTime");
		AchieveLifeTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AchieveLifeTime", Classes.FFloatProperty);
		AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AcceptableRadius");
		AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IncludeSelfRadius_PropertyAddress, unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncludeSelfRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SpeedRateType_PropertyAddress, unrealStruct, "SpeedRateType");
		SpeedRateType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedRateType");
		SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedRateType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref MoveAIType_PropertyAddress, unrealStruct, "MoveAIType");
		MoveAIType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveAIType");
		MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveAIType", Classes.FEnumProperty);
	}

	static BAIT_RunAway()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_RunAway)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_RunAway));
	}
}
