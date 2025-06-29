using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAIT_EQSTurnAround")]
[USharpPath("/Script/b1-Managed.BAIT_EQSTurnAround")]
internal class BAIT_EQSTurnAround : BAIT_Base
{
	private bool EQSDone;

	private float FinalRadius;

	private FVector TargetLocation;

	private float UpdatePathTimer;

	private readonly float PACE_RANGE_MIN = 40f;

	private readonly float PACE_RANGE_MAX = 60f;

	private static bool PerferCloser_IsValid;

	private static int PerferCloser_Offset;

	private static FFieldAddress PerferCloser_PropertyAddress;

	private static bool BeginRotateAngle_IsValid;

	private static int BeginRotateAngle_Offset;

	private static bool AcceptableRadius_IsValid;

	private static int AcceptableRadius_Offset;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool MoveAIType_IsValid;

	private static int MoveAIType_Offset;

	private static FFieldAddress MoveAIType_PropertyAddress;

	private static bool SpeedRateType_IsValid;

	private static int SpeedRateType_Offset;

	private static FFieldAddress SpeedRateType_PropertyAddress;

	private static bool AutoUpdatePathTime_IsValid;

	private static int AutoUpdatePathTime_Offset;

	private static bool EnableDebug_IsValid;

	private static int EnableDebug_Offset;

	private static FFieldAddress EnableDebug_PropertyAddress;

	private static bool OwnerCharacter_IsValid;

	private static int OwnerCharacter_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("倾向于靠近")]
	[USharpPath("/Script/b1-Managed.BAIT_EQSTurnAround:PerferCloser")]
	public bool PerferCloser
	{
		get
		{
			CheckDestroyed();
			if (!PerferCloser_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:PerferCloser");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PerferCloser_Offset), 0, PerferCloser_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PerferCloser_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:PerferCloser");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PerferCloser_Offset), 0, PerferCloser_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("触发旋转的角度")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_EQSTurnAround:BeginRotateAngle")]
	public float BeginRotateAngle
	{
		get
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:BeginRotateAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginRotateAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:BeginRotateAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeginRotateAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("抵达半径 防止抖动")]
	[USharpPath("/Script/b1-Managed.BAIT_EQSTurnAround:AcceptableRadius")]
	public float AcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:AcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:AcceptableRadius");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSTurnAround:EQSTemplate")]
	public UEnvQuery EQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:EQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, EQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:EQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, EQSTemplate_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSTurnAround:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:MoveAIType");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSTurnAround:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:SpeedRateType");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSTurnAround:AutoUpdatePathTime")]
	public float AutoUpdatePathTime
	{
		get
		{
			CheckDestroyed();
			if (!AutoUpdatePathTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:AutoUpdatePathTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AutoUpdatePathTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoUpdatePathTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:AutoUpdatePathTime");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSTurnAround:EnableDebug")]
	public bool EnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:EnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:EnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSTurnAround:OwnerCharacter")]
	private ACharacter OwnerCharacter
	{
		get
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:OwnerCharacter");
				return null;
			}
			return UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(base.Address, OwnerCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSTurnAround:OwnerCharacter");
			}
			else
			{
				UObjectMarshaler<ACharacter>.ToNative(IntPtr.Add(base.Address, OwnerCharacter_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SpeedRateType = EAIMoveSpeedType.RUN;
		AutoUpdatePathTime = 0f;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		OwnerCharacter = OwnerActor as ACharacter;
		if (OwnerCharacter != null)
		{
			if (ShouldAbort(OwnerCharacter))
			{
				EndThisNode();
				return;
			}
			AActor lockTargetActor = ((IBUC_TargetInfoData)BGU_DataUtil.GetReadOnlyData<BUC_TargetInfoData>(OwnerCharacter)).GetTargetInfo().LockTargetActor;
			if (lockTargetActor.IsNullOrDestroyed())
			{
				FinishExecute(bSuccess: false);
				return;
			}
			FVector targetPos = BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor);
			AIFuncLibForCS.GetTurnAngle(OwnerCharacter, targetPos, out var AbsDegValue, out var _);
			if (AbsDegValue > BeginRotateAngle)
			{
				EQSDone = false;
				float num = (BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter) - BGUFuncLibActorTransformCS.BGUGetActorLocation(lockTargetActor)).Size();
				if (num <= PACE_RANGE_MAX + 100f)
				{
					PerferCloser = false;
				}
				List<FGSEnvNamedValue> list = new List<FGSEnvNamedValue>();
				FGSEnvNamedValue item = new FGSEnvNamedValue
				{
					ParamName = B1GlobalFNames.InnerRadius,
					ParamType = EAIParamType.Float,
					Value = (PerferCloser ? (num - PACE_RANGE_MIN) : (num + PACE_RANGE_MIN))
				};
				FGSEnvNamedValue item2 = new FGSEnvNamedValue
				{
					ParamName = B1GlobalFNames.OuterRadius,
					ParamType = EAIParamType.Float,
					Value = (PerferCloser ? (num - PACE_RANGE_MAX) : (num + PACE_RANGE_MAX))
				};
				list.Add(item);
				list.Add(item2);
				BGS_EventCollectionCS.Get(this).Evt_BGS_EQSObjRunWithCustomParams.Invoke(EQSTemplate, OwnerCharacter, EBGURunEQSObjReason.None, list, OnEQSFinish);
			}
			else
			{
				FinishExecute(bSuccess: true);
			}
		}
		else
		{
			USystemLibrary.PrintString(this, "BAIT_EQSRun Failed, OwnerCharacter is null!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
			FinishExecute(bSuccess: false);
		}
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		if (!(OwnerActor is BGUCharacterCS unit) || ShouldAbort(unit))
		{
			EndThisNode();
			return;
		}
		if (EQSDone)
		{
			(BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter) - TargetLocation).Size();
			if ((BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter) - TargetLocation).Size() <= FinalRadius)
			{
				FinishExecute(bSuccess: true);
			}
			if (!BGUFuncLibForMove.IsMoveActive(OwnerCharacter))
			{
				FinishExecute(bSuccess: true);
			}
		}
		if (AutoUpdatePathTime > 0f)
		{
			UpdatePathTimer += DeltaSeconds;
			if (UpdatePathTimer >= AutoUpdatePathTime)
			{
				BGUFuncLibForMove.BeginMoveToPos(OwnerCharacter, TargetLocation, AcceptableRadius, SpeedRateType, MoveAIType, IncludeSelfRadius: false, IncludeTargetRadius: false, out var _);
				UpdatePathTimer = 0f;
			}
		}
	}

	public override void ReceiveAbort(AActor OwnerActor)
	{
		BGUFuncLibForMove.CancelMove(OwnerCharacter);
		FinishAbort();
	}

	private void OnEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		if (OwnerCharacter != null)
		{
			EQSDone = true;
			if (Result.Count > 0)
			{
				FinalRadius = AcceptableRadius;
				TargetLocation = Result[0];
				if (BGUFuncLibForMove.BeginMoveToPos(OwnerCharacter, TargetLocation, AcceptableRadius, SpeedRateType, MoveAIType, IncludeSelfRadius: false, IncludeTargetRadius: false, out var _))
				{
					if (EnableDebug)
					{
						USystemLibrary.DrawDebugPoint(this, Result[0], 50f, FLinearColor.Red, 10f);
					}
				}
				else
				{
					USystemLibrary.PrintString(this, "BAIT_EQSRun Failed, BeginMoveToPos Failed!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
					FinishExecute(bSuccess: false);
				}
			}
			else
			{
				USystemLibrary.PrintString(this, "BAIT_EQSRun Failed, No EQS Point!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
				FinishExecute(bSuccess: false);
			}
		}
		else
		{
			USystemLibrary.PrintString(this, "BAIT_EQSRun Failed, OwnerCharacter is null!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
			FinishExecute(bSuccess: false);
		}
	}

	private int GetRandomIndexByWeight(List<FGSLeisureWithWeight> LeisureList)
	{
		int num = FMath.RandRange(0, 100);
		for (int i = 0; i < LeisureList.Count; i++)
		{
			if (num <= LeisureList[i].Weight)
			{
				return i;
			}
			num -= LeisureList[i].Weight;
		}
		return -1;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_EQSTurnAround");
		NativeReflection.GetPropertyRef(ref PerferCloser_PropertyAddress, unrealStruct, "PerferCloser");
		PerferCloser_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PerferCloser");
		PerferCloser_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PerferCloser", Classes.FBoolProperty);
		BeginRotateAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BeginRotateAngle");
		BeginRotateAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BeginRotateAngle", Classes.FFloatProperty);
		AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AcceptableRadius");
		AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AcceptableRadius", Classes.FFloatProperty);
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EQSTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref MoveAIType_PropertyAddress, unrealStruct, "MoveAIType");
		MoveAIType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveAIType");
		MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SpeedRateType_PropertyAddress, unrealStruct, "SpeedRateType");
		SpeedRateType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedRateType");
		SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedRateType", Classes.FEnumProperty);
		AutoUpdatePathTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoUpdatePathTime");
		AutoUpdatePathTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoUpdatePathTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableDebug_PropertyAddress, unrealStruct, "EnableDebug");
		EnableDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableDebug");
		EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableDebug", Classes.FBoolProperty);
		OwnerCharacter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OwnerCharacter");
		OwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OwnerCharacter", Classes.FObjectProperty);
	}

	static BAIT_EQSTurnAround()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_EQSTurnAround)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_EQSTurnAround));
	}
}
