using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[Blueprintable]
[UClass]
[USharpPath("/Script/b1-Managed.BAIS_SurroundObstacleTick")]
internal class BAIS_SurroundObstacleTick : BAIS_Base
{
	private static bool CheckObstacleEQSTemplate_IsValid;

	private static int CheckObstacleEQSTemplate_Offset;

	private static bool CheckDistance_IsValid;

	private static int CheckDistance_Offset;

	private static bool CheckPointNum_IsValid;

	private static int CheckPointNum_Offset;

	private static bool CheckPointsWeightList_IsValid;

	private static int CheckPointsWeightList_Offset;

	private static FFieldAddress CheckPointsWeightList_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector2D> CheckPointsWeightList_Marshaler;

	private static bool EscapeWay_IsValid;

	private static int EscapeWay_Offset;

	private static FFieldAddress EscapeWay_PropertyAddress;

	private static bool OwnerCharacter_IsValid;

	private static int OwnerCharacter_Offset;

	private static bool OnPropertyChanged_IsValid;

	private static IntPtr OnPropertyChanged_FunctionAddress;

	private static int OnPropertyChanged_ParamsSize;

	private static bool OnPropertyChanged_MemberName_IsValid;

	private static int OnPropertyChanged_MemberName_Offset;

	private static FFieldAddress OnPropertyChanged_MemberName_PropertyAddress;

	private static bool OnPropertyChanged_PropertyName_IsValid;

	private static int OnPropertyChanged_PropertyName_Offset;

	private static FFieldAddress OnPropertyChanged_PropertyName_PropertyAddress;

	[UProperty]
	[DisplayName("墙角判定EQS")]
	[Category("CheckSettings")]
	[BlueprintReadWrite]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckObstacleEQSTemplate")]
	public UEnvQuery CheckObstacleEQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!CheckObstacleEQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckObstacleEQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, CheckObstacleEQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckObstacleEQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckObstacleEQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, CheckObstacleEQSTemplate_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("CheckSettings")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("墙角判定距离")]
	[Tooltip("单位周围判定圈的半径")]
	[USharpPath("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckDistance")]
	public float CheckDistance
	{
		get
		{
			CheckDestroyed();
			if (!CheckDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CheckDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CheckDistance_Offset), value);
			}
		}
	}

	[Category("CheckSettings")]
	[BlueprintReadWrite]
	[DisplayName("墙角判定点数")]
	[Tooltip("判定圈中有多少个判定点，在圆周上均分")]
	[EditDefaultsOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckPointNum")]
	public int CheckPointNum
	{
		get
		{
			CheckDestroyed();
			if (!CheckPointNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckPointNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, CheckPointNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CheckPointNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckPointNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, CheckPointNum_Offset), value);
			}
		}
	}

	[DisplayName("判定点权重(X:角度 Y:权重值)")]
	[UProperty]
	[VisibleDefaultsOnly]
	[BlueprintReadOnly]
	[Category("CheckSettings")]
	[Tooltip("定义每个判定点的权重")]
	[USharpPath("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckPointsWeightList")]
	private TArrayReadWrite<FVector2D> CheckPointsWeightList
	{
		get
		{
			CheckDestroyed();
			if (!CheckPointsWeightList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:CheckPointsWeightList");
				return null;
			}
			if (CheckPointsWeightList_Marshaler == null)
			{
				CheckPointsWeightList_Marshaler = new TArrayReadWriteMarshaler<FVector2D>(1, CheckPointsWeightList_PropertyAddress, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.FromNative, CachedMarshalingDelegates<FVector2D, BlittableTypeMarshaler<FVector2D>>.ToNative);
			}
			return CheckPointsWeightList_Marshaler.FromNative(IntPtr.Add(base.Address, CheckPointsWeightList_Offset));
		}
	}

	[DisplayName("墙角脱困方式")]
	[Category("CheckSettings")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIS_SurroundObstacleTick:EscapeWay")]
	public EEscapeWay EscapeWay
	{
		get
		{
			CheckDestroyed();
			if (!EscapeWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:EscapeWay");
				return EEscapeWay.None;
			}
			return EnumMarshaler<EEscapeWay>.FromNative(IntPtr.Add(base.Address, EscapeWay_Offset), 0, EscapeWay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EscapeWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:EscapeWay");
			}
			else
			{
				EnumMarshaler<EEscapeWay>.ToNative(IntPtr.Add(base.Address, EscapeWay_Offset), 0, EscapeWay_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIS_SurroundObstacleTick:OwnerCharacter")]
	private ABGUCharacter OwnerCharacter
	{
		get
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:OwnerCharacter");
				return null;
			}
			return UObjectMarshaler<ABGUCharacter>.FromNative(IntPtr.Add(base.Address, OwnerCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIS_SurroundObstacleTick:OwnerCharacter");
			}
			else
			{
				UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(base.Address, OwnerCharacter_Offset), value);
			}
		}
	}

	private float AngleInterval { get; set; }

	public override void Initialize(FObjectInitializer Initializer)
	{
		CheckDistance = 1000f;
		CheckPointNum = 24;
		EscapeWay = EEscapeWay.CastSkill;
		for (int i = 0; i < CheckPointNum; i++)
		{
			FVector2D item = new FVector2D(0.0, 1.0);
			CheckPointsWeightList.Add(item);
		}
		RefreshAngles();
	}

	private void RefreshAngles()
	{
		AngleInterval = 360f / (float)CheckPointNum;
		for (int i = 0; i < CheckPointsWeightList.Count; i++)
		{
			FVector2D value = CheckPointsWeightList[i];
			value.X = MathLib.NormalizeAxis(AngleInterval * (float)i);
			CheckPointsWeightList[i] = value;
		}
	}

	[USharpPath("/Script/b1-Managed.BAIS_SurroundObstacleTick:OnPropertyChanged")]
	protected override void OnPropertyChanged_Implementation(string MemberName, string PropertyName)
	{
		if (MemberName.Equals("CheckPointNum"))
		{
			int count = CheckPointsWeightList.Count;
			int num = CheckPointNum - count;
			if (num == 0)
			{
				RefreshAngles();
				return;
			}
			if (num > 0)
			{
				for (int i = 0; i < num; i++)
				{
					FVector2D item = new FVector2D(0.0, 1.0);
					CheckPointsWeightList.Add(item);
				}
			}
			else
			{
				for (int num2 = count - 1; num2 >= CheckPointNum; num2--)
				{
					CheckPointsWeightList.RemoveAt(num2);
				}
			}
			RefreshAngles();
		}
		else if (MemberName.Equals("CheckPointsWeightList") && PropertyName.Equals("X"))
		{
			RefreshAngles();
		}
	}

	public override void ReceiveActivation(AActor OwnerActor)
	{
		OwnerCharacter = OwnerActor as ABGUCharacter;
		if (!(OwnerCharacter == null))
		{
			BUS_EventCollectionCS.Get(OwnerCharacter).Evt_EscapeWayChanged.Invoke(EscapeWay);
		}
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		FGSEnvNamedValue item = new FGSEnvNamedValue
		{
			ParamName = B1GlobalFNames.CheckDistance,
			ParamType = EAIParamType.Float,
			Value = CheckDistance
		};
		FGSEnvNamedValue item2 = new FGSEnvNamedValue
		{
			ParamName = B1GlobalFNames.CheckPointNum,
			ParamType = EAIParamType.Int,
			Value = CheckPointNum
		};
		List<FGSEnvNamedValue> eQSParamList = new List<FGSEnvNamedValue> { item, item2 };
		BGS_EventCollectionCS.Get(this).Evt_BGS_EQSObjRunWithCustomParams.Invoke(CheckObstacleEQSTemplate, OwnerCharacter, EBGURunEQSObjReason.None, eQSParamList, OnEQSFinish);
	}

	private void OnEQSFinish(List<FVector> Result, List<float> Scores, FGSEQSExParam ExParam, int QueryID)
	{
		if (OwnerCharacter == null)
		{
			return;
		}
		FVector actorForwardVector = OwnerCharacter.GetActorForwardVector();
		FVector actorRightVector = OwnerCharacter.GetActorRightVector();
		actorForwardVector.Normalize();
		actorRightVector.Normalize();
		float num = 0f;
		for (int i = 0; i < Result.Count; i++)
		{
			if (!(Scores[i] <= 1E-08f))
			{
				FVector2D safeNormal = (Result[i] - BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter)).Conv_VectorToVector2D().GetSafeNormal();
				float num2 = MathLib.DotProduct2D(actorForwardVector.Conv_VectorToVector2D(), safeNormal);
				float angle = ((!(MathLib.DotProduct2D(actorRightVector.Conv_VectorToVector2D(), safeNormal) >= 0f)) ? ((float)UMathLibrary.ClampAngle(UMathLibrary.RadiansToDegrees(UMathLibrary.Acos(0f - num2)) + 180.0, 180.0, 360.0)) : ((float)UMathLibrary.ClampAngle(UMathLibrary.RadiansToDegrees(UMathLibrary.Acos(num2)), 0.0, 180.0)));
				angle = UMathLibrary.ClampAxis(angle);
				int num3 = (int)(angle / AngleInterval);
				if (num3 <= CheckPointsWeightList.Count)
				{
					num += CheckPointsWeightList[num3].Y;
				}
			}
		}
		BUS_EventCollectionCS.Get(OwnerCharacter).Evt_SetObstacleCheckResult.Invoke(num);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAIS_SurroundObstacleTick:OnPropertyChanged")]
	private static void OnPropertyChanged__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAIS_SurroundObstacleTick bAIS_SurroundObstacleTick = GCHelper.Find<b1.BAIS_SurroundObstacleTick>(obj);
		string memberName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_MemberName_Offset));
		string propertyName = FStringMarshaler.FromNative(IntPtr.Add(buffer, OnPropertyChanged_PropertyName_Offset));
		bAIS_SurroundObstacleTick.OnPropertyChanged_Implementation(memberName, propertyName);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIS_SurroundObstacleTick");
		CheckObstacleEQSTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckObstacleEQSTemplate");
		CheckObstacleEQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckObstacleEQSTemplate", Classes.FObjectProperty);
		CheckDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckDistance");
		CheckDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckDistance", Classes.FFloatProperty);
		CheckPointNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckPointNum");
		CheckPointNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckPointNum", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref CheckPointsWeightList_PropertyAddress, intPtr, "CheckPointsWeightList");
		CheckPointsWeightList_Offset = NativeReflection.GetPropertyOffset(intPtr, "CheckPointsWeightList");
		CheckPointsWeightList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CheckPointsWeightList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EscapeWay_PropertyAddress, intPtr, "EscapeWay");
		EscapeWay_Offset = NativeReflection.GetPropertyOffset(intPtr, "EscapeWay");
		EscapeWay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EscapeWay", Classes.FEnumProperty);
		OwnerCharacter_Offset = NativeReflection.GetPropertyOffset(intPtr, "OwnerCharacter");
		OwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OwnerCharacter", Classes.FObjectProperty);
		OnPropertyChanged_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPropertyChanged");
		OnPropertyChanged_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPropertyChanged_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_MemberName_PropertyAddress, OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "MemberName");
		OnPropertyChanged_MemberName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "MemberName", Classes.FStrProperty);
		NativeReflection.GetPropertyRef(ref OnPropertyChanged_PropertyName_PropertyAddress, OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_Offset = NativeReflection.GetPropertyOffset(OnPropertyChanged_FunctionAddress, "PropertyName");
		OnPropertyChanged_PropertyName_IsValid = NativeReflection.ValidatePropertyClass(OnPropertyChanged_FunctionAddress, "PropertyName", Classes.FStrProperty);
		OnPropertyChanged_IsValid = OnPropertyChanged_FunctionAddress != IntPtr.Zero && OnPropertyChanged_MemberName_IsValid && OnPropertyChanged_PropertyName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAIS_SurroundObstacleTick:OnPropertyChanged", OnPropertyChanged_IsValid);
	}

	static BAIS_SurroundObstacleTick()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIS_SurroundObstacleTick)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIS_SurroundObstacleTick));
	}
}
