using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("FindSceneLocation")]
[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation")]
public class BAN_GSFindSceneLocation : BAN_GSBase
{
	private static bool SceneLocationType_IsValid;

	private static int SceneLocationType_Offset;

	private static FFieldAddress SceneLocationType_PropertyAddress;

	private static bool LocationCachedDataId_IsValid;

	private static int LocationCachedDataId_Offset;

	private static bool FindSceneItemWay_IsValid;

	private static int FindSceneItemWay_Offset;

	private static FFieldAddress FindSceneItemWay_PropertyAddress;

	private static bool DistanceWeight_IsValid;

	private static int DistanceWeight_Offset;

	private static bool AngleWeight_IsValid;

	private static int AngleWeight_Offset;

	private static bool LineTraceWeight_IsValid;

	private static int LineTraceWeight_Offset;

	private static bool DistanceCoefficient_IsValid;

	private static int DistanceCoefficient_Offset;

	private static bool AngleCoefficient_IsValid;

	private static int AngleCoefficient_Offset;

	private static bool BestLandingDistance_IsValid;

	private static int BestLandingDistance_Offset;

	private static bool EnableSearchDistanceScope_IsValid;

	private static int EnableSearchDistanceScope_Offset;

	private static FFieldAddress EnableSearchDistanceScope_PropertyAddress;

	private static bool MinSearchDistance_IsValid;

	private static int MinSearchDistance_Offset;

	private static bool MaxSearchDistance_IsValid;

	private static int MaxSearchDistance_Offset;

	private static bool EnableSearchAngleRequirement_IsValid;

	private static int EnableSearchAngleRequirement_Offset;

	private static FFieldAddress EnableSearchAngleRequirement_PropertyAddress;

	private static bool RequiredMaxSearchAngle_IsValid;

	private static int RequiredMaxSearchAngle_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("通用设置")]
	[DisplayName("位置类型")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:SceneLocationType")]
	public ESceneLocationType SceneLocationType
	{
		get
		{
			CheckDestroyed();
			if (!SceneLocationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:SceneLocationType");
				return ESceneLocationType.LandingPoint;
			}
			return EnumMarshaler<ESceneLocationType>.FromNative(IntPtr.Add(base.Address, SceneLocationType_Offset), 0, SceneLocationType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SceneLocationType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:SceneLocationType");
			}
			else
			{
				EnumMarshaler<ESceneLocationType>.ToNative(IntPtr.Add(base.Address, SceneLocationType_Offset), 0, SceneLocationType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("用于AMScale的CachedDataID,需保持一致")]
	[Category("通用设置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:LocationCachedDataId")]
	public int LocationCachedDataId
	{
		get
		{
			CheckDestroyed();
			if (!LocationCachedDataId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:LocationCachedDataId");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LocationCachedDataId_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocationCachedDataId_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:LocationCachedDataId");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LocationCachedDataId_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("算法")]
	[Category("通用设置")]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:FindSceneItemWay")]
	public EFindSceneItemWay FindSceneItemWay
	{
		get
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:FindSceneItemWay");
				return EFindSceneItemWay.FindNearest;
			}
			return EnumMarshaler<EFindSceneItemWay>.FromNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:FindSceneItemWay");
			}
			else
			{
				EnumMarshaler<EFindSceneItemWay>.ToNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "FindSceneItemWay==EFindSceneItemWay::Composite")]
	[UMeta(MDProp.ClampMax, 10f)]
	[EditAnywhere]
	[Tooltip(">0时值越大分越高，<0时值越小分越高, =0时不计算此项分值")]
	[DisplayName("距离分权重")]
	[Category("通用设置")]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.ClampMin, -10f)]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:DistanceWeight")]
	public float DistanceWeight
	{
		get
		{
			CheckDestroyed();
			if (!DistanceWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:DistanceWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:DistanceWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceWeight_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "FindSceneItemWay==EFindSceneItemWay::Composite")]
	[UMeta(MDProp.ClampMax, 10f)]
	[UMeta(MDProp.ClampMin, -10f)]
	[Tooltip(">0时值越大分越高，<0时值越小分越高, =0时不计算此项分值")]
	[DisplayName("角度分权重")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("通用设置")]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:AngleWeight")]
	public float AngleWeight
	{
		get
		{
			CheckDestroyed();
			if (!AngleWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:AngleWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngleWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngleWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:AngleWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngleWeight_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "FindSceneItemWay==EFindSceneItemWay::Composite")]
	[UMeta(MDProp.ClampMax, 10f)]
	[UMeta(MDProp.ClampMin, -10f)]
	[Tooltip(">0时值越大分越高，<0时值越小分越高, =0时不计算此项分值")]
	[Category("通用设置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("射线检测分权重")]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:LineTraceWeight")]
	public float LineTraceWeight
	{
		get
		{
			CheckDestroyed();
			if (!LineTraceWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:LineTraceWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LineTraceWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineTraceWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:LineTraceWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LineTraceWeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("通用设置")]
	[DisplayName("距离系数")]
	[UMeta(MDProp.EditCondition, "FindSceneItemWay==EFindSceneItemWay::CompositeV2")]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:DistanceCoefficient")]
	public float DistanceCoefficient
	{
		get
		{
			CheckDestroyed();
			if (!DistanceCoefficient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:DistanceCoefficient");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceCoefficient_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceCoefficient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:DistanceCoefficient");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceCoefficient_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("角度系数")]
	[Category("通用设置")]
	[UMeta(MDProp.EditCondition, "FindSceneItemWay==EFindSceneItemWay::CompositeV2")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:AngleCoefficient")]
	public float AngleCoefficient
	{
		get
		{
			CheckDestroyed();
			if (!AngleCoefficient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:AngleCoefficient");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngleCoefficient_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngleCoefficient_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:AngleCoefficient");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngleCoefficient_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "FindSceneItemWay==EFindSceneItemWay::CompositeV2")]
	[DisplayName("最适合降落距离")]
	[Category("通用设置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:BestLandingDistance")]
	public float BestLandingDistance
	{
		get
		{
			CheckDestroyed();
			if (!BestLandingDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:BestLandingDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BestLandingDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BestLandingDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:BestLandingDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BestLandingDistance_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("约束条件")]
	[DisplayName("启用搜索范围限制")]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:EnableSearchDistanceScope")]
	public bool EnableSearchDistanceScope
	{
		get
		{
			CheckDestroyed();
			if (!EnableSearchDistanceScope_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:EnableSearchDistanceScope");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSearchDistanceScope_Offset), 0, EnableSearchDistanceScope_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSearchDistanceScope_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:EnableSearchDistanceScope");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSearchDistanceScope_Offset), 0, EnableSearchDistanceScope_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("约束条件")]
	[DisplayName("最小搜索距离")]
	[UMeta(MDProp.EditCondition, "EnableSearchDistanceScope")]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:MinSearchDistance")]
	public float MinSearchDistance
	{
		get
		{
			CheckDestroyed();
			if (!MinSearchDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:MinSearchDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinSearchDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinSearchDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:MinSearchDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinSearchDistance_Offset), value);
			}
		}
	}

	[Category("约束条件")]
	[UProperty]
	[DisplayName("最大搜索距离")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EnableSearchDistanceScope")]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:MaxSearchDistance")]
	public float MaxSearchDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxSearchDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:MaxSearchDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSearchDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSearchDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:MaxSearchDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSearchDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("启用最大搜索角度限制")]
	[Category("约束条件")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:EnableSearchAngleRequirement")]
	public bool EnableSearchAngleRequirement
	{
		get
		{
			CheckDestroyed();
			if (!EnableSearchAngleRequirement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:EnableSearchAngleRequirement");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSearchAngleRequirement_Offset), 0, EnableSearchAngleRequirement_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSearchAngleRequirement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:EnableSearchAngleRequirement");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSearchAngleRequirement_Offset), 0, EnableSearchAngleRequirement_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("最大搜索角度")]
	[UMeta(MDProp.EditCondition, "EnableSearchAngleRequirement")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("约束条件")]
	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:RequiredMaxSearchAngle")]
	public float RequiredMaxSearchAngle
	{
		get
		{
			CheckDestroyed();
			if (!RequiredMaxSearchAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:RequiredMaxSearchAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RequiredMaxSearchAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RequiredMaxSearchAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSFindSceneLocation:RequiredMaxSearchAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RequiredMaxSearchAngle_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		LocationCachedDataId = 19;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSFindSceneLocation:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		base.GSNotifyCS_Implementation(NotifyParam);
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (!(aCharacter == null))
		{
			if (!EnableSearchDistanceScope || MinSearchDistance >= MaxSearchDistance)
			{
				MinSearchDistance = -1f;
				MaxSearchDistance = -1f;
			}
			if (!EnableSearchAngleRequirement)
			{
				RequiredMaxSearchAngle = -1f;
			}
			QueryBestLocationCondition queryBestLocationConditionObject = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(aCharacter).QueryBestLocationConditionObject;
			queryBestLocationConditionObject.Initialize();
			switch (FindSceneItemWay)
			{
			default:
				return;
			case EFindSceneItemWay.FindNearest:
			case EFindSceneItemWay.FindNearestToTarget:
				queryBestLocationConditionObject.DistanceWeight = -1f;
				break;
			case EFindSceneItemWay.FindFurthest:
			case EFindSceneItemWay.FindFurthestToTarget:
				queryBestLocationConditionObject.DistanceWeight = 1f;
				break;
			case EFindSceneItemWay.FindMinTotalAngle:
				queryBestLocationConditionObject.AngleWeight = -1f;
				break;
			case EFindSceneItemWay.Composite:
				queryBestLocationConditionObject.DistanceWeight = DistanceWeight;
				queryBestLocationConditionObject.AngleWeight = AngleWeight;
				queryBestLocationConditionObject.LineTraceWeight = LineTraceWeight;
				break;
			case EFindSceneItemWay.CompositeV2:
				queryBestLocationConditionObject.DistanceCoefficient = DistanceCoefficient;
				queryBestLocationConditionObject.AngleCoefficient = AngleCoefficient;
				queryBestLocationConditionObject.BestLandingDistance = BestLandingDistance;
				break;
			}
			queryBestLocationConditionObject.EnableDistanceScope = EnableSearchDistanceScope;
			queryBestLocationConditionObject.MinDistance = MinSearchDistance;
			queryBestLocationConditionObject.MaxDistance = MaxSearchDistance;
			queryBestLocationConditionObject.EnableAngleScope = EnableSearchAngleRequirement;
			queryBestLocationConditionObject.MinAngle = 0f;
			queryBestLocationConditionObject.MaxAngle = RequiredMaxSearchAngle;
			if (SceneLocationType == ESceneLocationType.LandingPoint)
			{
				BUS_EventCollectionCS.Get(aCharacter).Evt_OnTryCatchLandingPoint.Invoke(FindSceneItemWay, queryBestLocationConditionObject, LocationCachedDataId);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSFindSceneLocation:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSFindSceneLocation bAN_GSFindSceneLocation = GCHelper.Find<BAN_GSFindSceneLocation>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSFindSceneLocation.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSFindSceneLocation:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSFindSceneLocation bAN_GSFindSceneLocation = GCHelper.Find<BAN_GSFindSceneLocation>(obj);
		bool value = bAN_GSFindSceneLocation.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSFindSceneLocation");
		NativeReflection.GetPropertyRef(ref SceneLocationType_PropertyAddress, intPtr, "SceneLocationType");
		SceneLocationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneLocationType");
		SceneLocationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneLocationType", Classes.FEnumProperty);
		LocationCachedDataId_Offset = NativeReflection.GetPropertyOffset(intPtr, "LocationCachedDataId");
		LocationCachedDataId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LocationCachedDataId", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref FindSceneItemWay_PropertyAddress, intPtr, "FindSceneItemWay");
		FindSceneItemWay_Offset = NativeReflection.GetPropertyOffset(intPtr, "FindSceneItemWay");
		FindSceneItemWay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FindSceneItemWay", Classes.FEnumProperty);
		DistanceWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceWeight");
		DistanceWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceWeight", Classes.FFloatProperty);
		AngleWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "AngleWeight");
		AngleWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AngleWeight", Classes.FFloatProperty);
		LineTraceWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineTraceWeight");
		LineTraceWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineTraceWeight", Classes.FFloatProperty);
		DistanceCoefficient_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceCoefficient");
		DistanceCoefficient_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceCoefficient", Classes.FFloatProperty);
		AngleCoefficient_Offset = NativeReflection.GetPropertyOffset(intPtr, "AngleCoefficient");
		AngleCoefficient_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AngleCoefficient", Classes.FFloatProperty);
		BestLandingDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "BestLandingDistance");
		BestLandingDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BestLandingDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableSearchDistanceScope_PropertyAddress, intPtr, "EnableSearchDistanceScope");
		EnableSearchDistanceScope_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableSearchDistanceScope");
		EnableSearchDistanceScope_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableSearchDistanceScope", Classes.FBoolProperty);
		MinSearchDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinSearchDistance");
		MinSearchDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinSearchDistance", Classes.FFloatProperty);
		MaxSearchDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxSearchDistance");
		MaxSearchDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxSearchDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableSearchAngleRequirement_PropertyAddress, intPtr, "EnableSearchAngleRequirement");
		EnableSearchAngleRequirement_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableSearchAngleRequirement");
		EnableSearchAngleRequirement_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableSearchAngleRequirement", Classes.FBoolProperty);
		RequiredMaxSearchAngle_Offset = NativeReflection.GetPropertyOffset(intPtr, "RequiredMaxSearchAngle");
		RequiredMaxSearchAngle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RequiredMaxSearchAngle", Classes.FFloatProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSFindSceneLocation:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSFindSceneLocation:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSFindSceneLocation()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_GSFindSceneLocation)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_GSFindSceneLocation));
	}
}
