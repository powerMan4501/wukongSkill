using System;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAIT_EQSRun")]
[UClass]
[USharpPath("/Script/b1-Managed.BAIT_EQSRun")]
internal class BAIT_EQSRun : BAIT_Base
{
	private static bool AcceptableRadius_IsValid;

	private static int AcceptableRadius_Offset;

	private static bool IncludeSelfRadius_IsValid;

	private static int IncludeSelfRadius_Offset;

	private static FFieldAddress IncludeSelfRadius_PropertyAddress;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool MotionMatchingState_IsValid;

	private static int MotionMatchingState_Offset;

	private static FFieldAddress MotionMatchingState_PropertyAddress;

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

	private static bool bEnableContinuousPathFinding_IsValid;

	private static int bEnableContinuousPathFinding_Offset;

	private static FFieldAddress bEnableContinuousPathFinding_PropertyAddress;

	private static bool ContinuousPathFindingRadiusThreshold_IsValid;

	private static int ContinuousPathFindingRadiusThreshold_Offset;

	private static bool bAutoCastTurnSkillIfNeeded_IsValid;

	private static int bAutoCastTurnSkillIfNeeded_Offset;

	private static FFieldAddress bAutoCastTurnSkillIfNeeded_PropertyAddress;

	private static bool TurnSkillConfig_IsValid;

	private static int TurnSkillConfig_Offset;

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

	private static bool EnableDrawLineDebug_IsValid;

	private static int EnableDrawLineDebug_Offset;

	private static FFieldAddress EnableDrawLineDebug_PropertyAddress;

	[UMeta(MDProp.EditCondition, "!EnableRangeAcceptableRadius")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:AcceptableRadius")]
	public float AcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:AcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:AcceptableRadius");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:IncludeSelfRadius")]
	public bool IncludeSelfRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:IncludeSelfRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:IncludeSelfRadius");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:EQSTemplate")]
	public UEnvQuery EQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:EQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, EQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:EQSTemplate");
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
	[Tooltip("如果是None，不触发调整逻辑")]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:MotionMatchingState")]
	public EState_MM MotionMatchingState
	{
		get
		{
			CheckDestroyed();
			if (!MotionMatchingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:MotionMatchingState");
				return EState_MM.None;
			}
			return EnumMarshaler<EState_MM>.FromNative(IntPtr.Add(base.Address, MotionMatchingState_Offset), 0, MotionMatchingState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MotionMatchingState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:MotionMatchingState");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:MoveAIType");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:SpeedRateType");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:SpeedRateDistanceCurve")]
	public UCurveFloat SpeedRateDistanceCurve
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateDistanceCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:SpeedRateDistanceCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, SpeedRateDistanceCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateDistanceCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:SpeedRateDistanceCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, SpeedRateDistanceCurve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:EnableRangeAcceptableRadius")]
	public bool EnableRangeAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!EnableRangeAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:EnableRangeAcceptableRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableRangeAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:EnableRangeAcceptableRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableRangeAcceptableRadius_Offset), 0, EnableRangeAcceptableRadius_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "EnableRangeAcceptableRadius")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:MinAcceptableRadius")]
	public float MinAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MinAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:MinAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:MinAcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinAcceptableRadius_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EnableRangeAcceptableRadius")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:MaxAcceptableRadius")]
	public float MaxAcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!MaxAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:MaxAcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxAcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxAcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:MaxAcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxAcceptableRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("是否启用连续EQS寻路，勾选此项来解决两个连续EQS执行期间由于结果返回延迟导致的短暂回idle的问题；启用之后EQS寻路会变得连续无缝丝滑")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:bEnableContinuousPathFinding")]
	public bool bEnableContinuousPathFinding
	{
		get
		{
			CheckDestroyed();
			if (!bEnableContinuousPathFinding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:bEnableContinuousPathFinding");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableContinuousPathFinding_Offset), 0, bEnableContinuousPathFinding_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableContinuousPathFinding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:bEnableContinuousPathFinding");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableContinuousPathFinding_Offset), 0, bEnableContinuousPathFinding_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("当位置距离目标点多远会提前执行下次EQS查询，该阈值会加上之前设置的AcceptableRadius以及SelfRadius（若IncludeSelfRadius为true）来作为最终范围判定")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "bEnableContinuousPathFinding")]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:ContinuousPathFindingRadiusThreshold")]
	public float ContinuousPathFindingRadiusThreshold
	{
		get
		{
			CheckDestroyed();
			if (!ContinuousPathFindingRadiusThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:ContinuousPathFindingRadiusThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ContinuousPathFindingRadiusThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContinuousPathFindingRadiusThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:ContinuousPathFindingRadiusThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ContinuousPathFindingRadiusThreshold_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:bAutoCastTurnSkillIfNeeded")]
	public bool bAutoCastTurnSkillIfNeeded
	{
		get
		{
			CheckDestroyed();
			if (!bAutoCastTurnSkillIfNeeded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:bAutoCastTurnSkillIfNeeded");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoCastTurnSkillIfNeeded_Offset), 0, bAutoCastTurnSkillIfNeeded_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoCastTurnSkillIfNeeded_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:bAutoCastTurnSkillIfNeeded");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoCastTurnSkillIfNeeded_Offset), 0, bAutoCastTurnSkillIfNeeded_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "bAutoCastTurnSkillIfNeeded")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:TurnSkillConfig")]
	public FGSTurnSkillConfig TurnSkillConfig
	{
		get
		{
			CheckDestroyed();
			if (!TurnSkillConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:TurnSkillConfig");
				return default(FGSTurnSkillConfig);
			}
			return FGSTurnSkillConfig.FromNative(IntPtr.Add(base.Address, TurnSkillConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TurnSkillConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:TurnSkillConfig");
			}
			else
			{
				FGSTurnSkillConfig.ToNative(IntPtr.Add(base.Address, TurnSkillConfig_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:AutoUpdatePathTime")]
	public float AutoUpdatePathTime
	{
		get
		{
			CheckDestroyed();
			if (!AutoUpdatePathTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:AutoUpdatePathTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AutoUpdatePathTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoUpdatePathTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:AutoUpdatePathTime");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:EnableLeisure")]
	public bool EnableLeisure
	{
		get
		{
			CheckDestroyed();
			if (!EnableLeisure_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:EnableLeisure");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableLeisure_Offset), 0, EnableLeisure_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableLeisure_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:EnableLeisure");
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
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:IntervalTime")]
	public float IntervalTime
	{
		get
		{
			CheckDestroyed();
			if (!IntervalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:IntervalTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IntervalTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IntervalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:IntervalTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IntervalTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:LeisureList")]
	public TArrayReadWrite<FGSLeisureWithWeight> LeisureList
	{
		get
		{
			CheckDestroyed();
			if (!LeisureList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:LeisureList");
				return null;
			}
			if (LeisureList_Marshaler == null)
			{
				LeisureList_Marshaler = new TArrayReadWriteMarshaler<FGSLeisureWithWeight>(1, LeisureList_PropertyAddress, CachedMarshalingDelegates<FGSLeisureWithWeight, FGSLeisureWithWeight>.FromNative, CachedMarshalingDelegates<FGSLeisureWithWeight, FGSLeisureWithWeight>.ToNative);
			}
			return LeisureList_Marshaler.FromNative(IntPtr.Add(base.Address, LeisureList_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("开启连线Debug")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_EQSRun:EnableDrawLineDebug")]
	public bool EnableDrawLineDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDrawLineDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:EnableDrawLineDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDrawLineDebug_Offset), 0, EnableDrawLineDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDrawLineDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EQSRun:EnableDrawLineDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDrawLineDebug_Offset), 0, EnableDrawLineDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SpeedRateType = EAIMoveSpeedType.RUN;
		IncludeSelfRadius = true;
		AutoUpdatePathTime = 0f;
		MotionMatchingState = EState_MM.None;
		ContinuousPathFindingRadiusThreshold = 100f;
		TurnSkillConfig = new FGSTurnSkillConfig
		{
			TurnDegreeThresholdLow = 30,
			TurnDegreeThresholdHigh = 105
		};
		EnableDrawLineDebug = false;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ChangeMotionMatchingState.Invoke(MotionMatchingState);
				bUS_GSEventCollection.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.EQSRun, new AINodeAction_EQSRunParamInfo
				{
					AcceptableRadius = AcceptableRadius,
					IncludeSelfRadius = IncludeSelfRadius,
					EQSTemplate = EQSTemplate,
					MoveAIType = MoveAIType,
					SpeedRateType = SpeedRateType,
					SpeedRateDistanceCurve = SpeedRateDistanceCurve,
					EnableRangeAcceptableRadius = EnableRangeAcceptableRadius,
					MinAcceptableRadius = MinAcceptableRadius,
					MaxAcceptableRadius = MaxAcceptableRadius,
					bEnableContinuousPathFinding = bEnableContinuousPathFinding,
					ContinuousPathFindingRadiusThreshold = ContinuousPathFindingRadiusThreshold,
					TurnSkillConfig = new GSTurnSkillConfig(TurnSkillConfig),
					AutoUpdatePathTime = AutoUpdatePathTime,
					EnableLeisure = EnableLeisure,
					IntervalTime = IntervalTime,
					LeisureList = LeisureList.ToList(),
					EnableDrawLineDebug = EnableDrawLineDebug
				});
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_EQSRun");
		AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AcceptableRadius");
		AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IncludeSelfRadius_PropertyAddress, unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncludeSelfRadius", Classes.FBoolProperty);
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EQSTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref MotionMatchingState_PropertyAddress, unrealStruct, "MotionMatchingState");
		MotionMatchingState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MotionMatchingState");
		MotionMatchingState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MotionMatchingState", Classes.FEnumProperty);
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
		NativeReflection.GetPropertyRef(ref bEnableContinuousPathFinding_PropertyAddress, unrealStruct, "bEnableContinuousPathFinding");
		bEnableContinuousPathFinding_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bEnableContinuousPathFinding");
		bEnableContinuousPathFinding_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bEnableContinuousPathFinding", Classes.FBoolProperty);
		ContinuousPathFindingRadiusThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ContinuousPathFindingRadiusThreshold");
		ContinuousPathFindingRadiusThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ContinuousPathFindingRadiusThreshold", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bAutoCastTurnSkillIfNeeded_PropertyAddress, unrealStruct, "bAutoCastTurnSkillIfNeeded");
		bAutoCastTurnSkillIfNeeded_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAutoCastTurnSkillIfNeeded");
		bAutoCastTurnSkillIfNeeded_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAutoCastTurnSkillIfNeeded", Classes.FBoolProperty);
		TurnSkillConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TurnSkillConfig");
		TurnSkillConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TurnSkillConfig", Classes.FStructProperty);
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
		NativeReflection.GetPropertyRef(ref EnableDrawLineDebug_PropertyAddress, unrealStruct, "EnableDrawLineDebug");
		EnableDrawLineDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableDrawLineDebug");
		EnableDrawLineDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableDrawLineDebug", Classes.FBoolProperty);
	}

	static BAIT_EQSRun()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_EQSRun)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_EQSRun));
	}
}
