using System;
using System.Collections.Generic;
using System.Text;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAIT_EQSRunBeforeAtkTmp")]
[UClass]
[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp")]
internal class BAIT_EQSRunBeforeAtkTmp : BAIT_Base
{
	private bool EQSDone;

	private float FinalRadius;

	private FVector TargetLocation;

	private float UpdatePathTimer;

	private string AINodeName;

	private static bool ImmueStiff_IsValid;

	private static int ImmueStiff_Offset;

	private static FFieldAddress ImmueStiff_PropertyAddress;

	private static bool NeedTraceHitTargetBefore_IsValid;

	private static int NeedTraceHitTargetBefore_Offset;

	private static FFieldAddress NeedTraceHitTargetBefore_PropertyAddress;

	private static bool TraceTypeQuery_IsValid;

	private static int TraceTypeQuery_Offset;

	private static FFieldAddress TraceTypeQuery_PropertyAddress;

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

	private static bool EnableRangeAcceptableRadius_IsValid;

	private static int EnableRangeAcceptableRadius_Offset;

	private static FFieldAddress EnableRangeAcceptableRadius_PropertyAddress;

	private static bool MinAcceptableRadius_IsValid;

	private static int MinAcceptableRadius_Offset;

	private static bool MaxAcceptableRadius_IsValid;

	private static int MaxAcceptableRadius_Offset;

	private static bool AutoUpdatePathTime_IsValid;

	private static int AutoUpdatePathTime_Offset;

	private static bool IntervalTime_IsValid;

	private static int IntervalTime_Offset;

	private static bool OwnerCharacter_IsValid;

	private static int OwnerCharacter_Offset;

	[DisplayName("过程中免疫打断")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:ImmueStiff")]
	public bool ImmueStiff
	{
		get
		{
			CheckDestroyed();
			if (!ImmueStiff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:ImmueStiff");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ImmueStiff_Offset), 0, ImmueStiff_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImmueStiff_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:ImmueStiff");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ImmueStiff_Offset), 0, ImmueStiff_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("前置射线检测")]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:NeedTraceHitTargetBefore")]
	public bool NeedTraceHitTargetBefore
	{
		get
		{
			CheckDestroyed();
			if (!NeedTraceHitTargetBefore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:NeedTraceHitTargetBefore");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedTraceHitTargetBefore_Offset), 0, NeedTraceHitTargetBefore_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedTraceHitTargetBefore_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:NeedTraceHitTargetBefore");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedTraceHitTargetBefore_Offset), 0, NeedTraceHitTargetBefore_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("射线检测通道")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "NeedTraceHitTargetBefore")]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:TraceTypeQuery")]
	public ETraceTypeQuery TraceTypeQuery
	{
		get
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:TraceTypeQuery");
				return ETraceTypeQuery.TraceTypeQuery1;
			}
			return EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:TraceTypeQuery");
			}
			else
			{
				EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:AcceptableRadius")]
	public float AcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:AcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:AcceptableRadius");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:IncludeSelfRadius")]
	public bool IncludeSelfRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:IncludeSelfRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:IncludeSelfRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:EQSTemplate")]
	public UEnvQuery EQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:EQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, EQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:EQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, EQSTemplate_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:MoveAIType");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:SpeedRateType");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:EnableRangeAcceptableRadius")]
	public bool EnableRangeAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!EnableRangeAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:EnableRangeAcceptableRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRangeAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:EnableRangeAcceptableRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EnableRangeAcceptableRadius")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:MinAcceptableRadius")]
	public float MinAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MinAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:MinAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:MinAcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinAcceptableRadius_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "EnableRangeAcceptableRadius")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:MaxAcceptableRadius")]
	public float MaxAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MaxAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:MaxAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:MaxAcceptableRadius");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:AutoUpdatePathTime")]
	public float AutoUpdatePathTime
	{
		get
		{
			CheckDestroyed();
			if (!AutoUpdatePathTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:AutoUpdatePathTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AutoUpdatePathTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoUpdatePathTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:AutoUpdatePathTime");
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
	[UMeta(MDProp.EditCondition, "EnableLeisure")]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:IntervalTime")]
	public float IntervalTime
	{
		get
		{
			CheckDestroyed();
			if (!IntervalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:IntervalTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IntervalTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntervalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:IntervalTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IntervalTime_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:OwnerCharacter")]
	private ACharacter OwnerCharacter
	{
		get
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:OwnerCharacter");
				return null;
			}
			return UObjectMarshaler<ACharacter>.FromNative(IntPtr.Add(base.Address, OwnerCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp:OwnerCharacter");
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
		IncludeSelfRadius = true;
		AutoUpdatePathTime = 0f;
		AINodeName = "BAIT_EQSRunBeforeAtkTmp";
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		OwnerCharacter = OwnerActor as ACharacter;
		if (OwnerCharacter != null)
		{
			if (!IsTraceSuccess(OwnerCharacter as ABGUCharacter))
			{
				FinishExecute(bSuccess: false);
				return;
			}
			if (ShouldAbort(OwnerCharacter))
			{
				EndThisNode();
				return;
			}
			EQSDone = false;
			BGS_EventCollectionCS.Get(this).Evt_BGS_EQSObjRun.Invoke(EQSTemplate, OwnerCharacter, EBGURunEQSObjReason.None, default(FGSEQSExParam), OnEQSFinish);
			if (ImmueStiff)
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(OwnerCharacter, EBGUSimpleState.ImmueStiff, IsRemove: false);
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
			if (ImmueStiff)
			{
				BGUFunctionLibraryCS.BGUSetUnitSimpleState(OwnerCharacter, EBGUSimpleState.ImmueStiff, IsRemove: true);
			}
			EndThisNode();
			return;
		}
		if (EQSDone)
		{
			if ((BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter) - TargetLocation).Size() <= FinalRadius)
			{
				if (ImmueStiff)
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(OwnerCharacter, EBGUSimpleState.ImmueStiff, IsRemove: true);
				}
				FinishExecute(bSuccess: true);
			}
			if (!BGUFuncLibForMove.IsMoveActive(OwnerCharacter))
			{
				if (ImmueStiff)
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(OwnerCharacter, EBGUSimpleState.ImmueStiff, IsRemove: true);
				}
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
		if (ImmueStiff)
		{
			BGUFunctionLibraryCS.BGUSetUnitSimpleState(OwnerCharacter, EBGUSimpleState.ImmueStiff, IsRemove: true);
		}
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
				if (EnableRangeAcceptableRadius)
				{
					AcceptableRadius = MathLib.RandomFloatInRange(MinAcceptableRadius, MaxAcceptableRadius);
				}
				FinalRadius = AcceptableRadius;
				TargetLocation = Result[0];
				if (IncludeSelfRadius)
				{
					UNavMovementComponent movementComponent = OwnerCharacter.GetMovementComponent();
					if (movementComponent != null)
					{
						FinalRadius += movementComponent.NavAgentProps.AgentRadius * 2f;
					}
				}
				if (BGUFuncLibForMove.BeginMoveToPos(OwnerCharacter, TargetLocation, AcceptableRadius, SpeedRateType, MoveAIType, IncludeSelfRadius: false, IncludeTargetRadius: false, out var _))
				{
					if (DebugConfig.AINodeDebug)
					{
						USystemLibrary.DrawDebugPoint(this, Result[0], 50f, FLinearColor.Red, 10f);
					}
					return;
				}
				USystemLibrary.PrintString(this, "BAIT_EQSRun Failed, BeginMoveToPos Failed!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
				if (ImmueStiff)
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(OwnerCharacter, EBGUSimpleState.ImmueStiff, IsRemove: true);
				}
				FinishExecute(bSuccess: false);
			}
			else
			{
				USystemLibrary.PrintString(this, "BAIT_EQSRun Failed, No EQS Point!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
				if (ImmueStiff)
				{
					BGUFunctionLibraryCS.BGUSetUnitSimpleState(OwnerCharacter, EBGUSimpleState.ImmueStiff, IsRemove: true);
				}
				FinishExecute(bSuccess: false);
			}
		}
		else
		{
			USystemLibrary.PrintString(this, "BAIT_EQSRun Failed, OwnerCharacter is null!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
			FinishExecute(bSuccess: false);
		}
	}

	private bool IsTraceSuccess(ABGUCharacter Unit)
	{
		AActor aActor = BGUFunctionLibraryCS.BGUGetTarget(Unit);
		if (aActor == null)
		{
			return true;
		}
		if (NeedTraceHitTargetBefore)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
			FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit);
			UCapsuleComponent componentByClass = Unit.GetComponentByClass<UCapsuleComponent>();
			float num = 0f;
			if (componentByClass != null)
			{
				num = componentByClass.GetScaledCapsuleRadius() * 2f;
			}
			float num2 = FVector.Dist2D(fVector, fVector2);
			List<AActor> OutActors = new List<AActor>();
			List<int> list = new List<int>();
			list.Add((int)num + 50);
			list.Add((int)num2);
			BGUFuncLibSelectTargetsCS.SelectUnitsInRect(Unit.World, out OutActors, Unit, BGUFuncLibActorTransformCS.BGUGetActorLocation(Unit), 1, list);
			for (int i = 0; i < OutActors.Count; i++)
			{
				if (!BGUFuncLibSelectTargetsCS.BGUIsSelectTargetByTeamFilter(Unit, OutActors[i], 2))
				{
					OutActors.RemoveAt(i);
					i--;
				}
			}
			StringBuilder stringBuilder = new StringBuilder();
			if (OutActors.Count > 0)
			{
				stringBuilder.Append("检测到阻挡单位 当前节点中断");
				return false;
			}
			FVector safeNormal = (fVector - fVector2).GetSafeNormal();
			safeNormal.Z = 0f;
			FVector fVector3 = FVector.CrossProduct(safeNormal, new FVector(0.0, 0.0, -1.0)) * (num / 2f + 25f);
			FVector fVector4 = safeNormal * num2 / 2.0;
			FVector endTrace = 2.0 * fVector4 + -1.0 * fVector3 + fVector2;
			FVector endTrace2 = 2.0 * fVector4 + fVector3 + fVector2;
			FVector startTrace = fVector3 + fVector2;
			FVector startTrace2 = -1.0 * fVector3 + fVector2;
			FHitResultSimple HitResult;
			int num3 = UBGUSelectUtil.LineTraceSimple(Unit, startTrace, endTrace2, TraceTypeQuery, DebugConfig.AINodeDebug, out HitResult, null);
			FHitResultSimple HitResult2;
			int num4 = UBGUSelectUtil.LineTraceSimple(Unit, startTrace2, endTrace, TraceTypeQuery, DebugConfig.AINodeDebug, out HitResult2, null);
			if (num3 == 0 && num4 == 0)
			{
				return true;
			}
			if (num3 > 0)
			{
				AActor hitActor = HitResult.HitActor;
				BGUCharacterCS bGUCharacterCS = hitActor as BGUCharacterCS;
				stringBuilder.Append(", 射线检测击中目标: ");
				stringBuilder.Append(hitActor.GetFName().ToString());
				if (!(bGUCharacterCS != null) || !(bGUCharacterCS == aActor))
				{
					stringBuilder.Append(", 是不可被击中单位, 当前节点中断");
					return false;
				}
				stringBuilder.Append(", 是可被击中单位!");
			}
			if (num4 > 0)
			{
				AActor hitActor2 = HitResult2.HitActor;
				BGUCharacterCS bGUCharacterCS2 = hitActor2 as BGUCharacterCS;
				stringBuilder.Append(", 射线检测击中目标: ");
				stringBuilder.Append(hitActor2.GetFName().ToString());
				if (!(bGUCharacterCS2 != null) || !(bGUCharacterCS2 == aActor))
				{
					stringBuilder.Append(", 是不可被击中单位, 当前节点中断");
					return false;
				}
				stringBuilder.Append(", 是可被击中单位!");
			}
			AIFuncLibForCS.PrintDebugMessage(Unit, AINodeName, stringBuilder.ToString());
		}
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_EQSRunBeforeAtkTmp");
		NativeReflection.GetPropertyRef(ref ImmueStiff_PropertyAddress, unrealStruct, "ImmueStiff");
		ImmueStiff_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ImmueStiff");
		ImmueStiff_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ImmueStiff", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref NeedTraceHitTargetBefore_PropertyAddress, unrealStruct, "NeedTraceHitTargetBefore");
		NeedTraceHitTargetBefore_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedTraceHitTargetBefore");
		NeedTraceHitTargetBefore_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedTraceHitTargetBefore", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref TraceTypeQuery_PropertyAddress, unrealStruct, "TraceTypeQuery");
		TraceTypeQuery_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TraceTypeQuery");
		TraceTypeQuery_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TraceTypeQuery", Classes.FEnumProperty);
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
		NativeReflection.GetPropertyRef(ref EnableRangeAcceptableRadius_PropertyAddress, unrealStruct, "EnableRangeAcceptableRadius");
		EnableRangeAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableRangeAcceptableRadius");
		EnableRangeAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableRangeAcceptableRadius", Classes.FBoolProperty);
		MinAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinAcceptableRadius");
		MinAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinAcceptableRadius", Classes.FFloatProperty);
		MaxAcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxAcceptableRadius");
		MaxAcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxAcceptableRadius", Classes.FFloatProperty);
		AutoUpdatePathTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoUpdatePathTime");
		AutoUpdatePathTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoUpdatePathTime", Classes.FFloatProperty);
		IntervalTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IntervalTime");
		IntervalTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IntervalTime", Classes.FFloatProperty);
		OwnerCharacter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OwnerCharacter");
		OwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OwnerCharacter", Classes.FObjectProperty);
	}

	static BAIT_EQSRunBeforeAtkTmp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_EQSRunBeforeAtkTmp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_EQSRunBeforeAtkTmp));
	}
}
