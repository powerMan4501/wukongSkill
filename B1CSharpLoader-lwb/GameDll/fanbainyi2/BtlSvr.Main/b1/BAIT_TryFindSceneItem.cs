using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem")]
internal class BAIT_TryFindSceneItem : BAIT_Base
{
	private static bool SceneActorTags_IsValid;

	private static int SceneActorTags_Offset;

	private static FFieldAddress SceneActorTags_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SceneActorTags_Marshaler;

	private static bool FindSceneItemWay_IsValid;

	private static int FindSceneItemWay_Offset;

	private static FFieldAddress FindSceneItemWay_PropertyAddress;

	private static bool DistanceWeight_IsValid;

	private static int DistanceWeight_Offset;

	private static bool AngleWeight_IsValid;

	private static int AngleWeight_Offset;

	private static bool LineTraceWeight_IsValid;

	private static int LineTraceWeight_Offset;

	private static bool NeedRemoveCurrentCatch_IsValid;

	private static int NeedRemoveCurrentCatch_Offset;

	private static FFieldAddress NeedRemoveCurrentCatch_PropertyAddress;

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

	[EditAnywhere]
	[UProperty]
	[Category("通用设置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:SceneActorTags")]
	public TArrayReadWrite<FName> SceneActorTags
	{
		get
		{
			CheckDestroyed();
			if (!SceneActorTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:SceneActorTags");
				return null;
			}
			if (SceneActorTags_Marshaler == null)
			{
				SceneActorTags_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SceneActorTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SceneActorTags_Marshaler.FromNative(IntPtr.Add(base.Address, SceneActorTags_Offset));
		}
	}

	[Category("通用设置")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:FindSceneItemWay")]
	public EFindSceneItemWay FindSceneItemWay
	{
		get
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:FindSceneItemWay");
				return EFindSceneItemWay.FindNearest;
			}
			return EnumMarshaler<EFindSceneItemWay>.FromNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:FindSceneItemWay");
			}
			else
			{
				EnumMarshaler<EFindSceneItemWay>.ToNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[DisplayName("距离分权重")]
	[UProperty]
	[Tooltip(">0时值越大分越高，<0时值越小分越高, =0时不计算此项分值")]
	[UMeta(MDProp.ClampMin, -10f)]
	[UMeta(MDProp.ClampMax, 10f)]
	[Category("通用设置")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:DistanceWeight")]
	public float DistanceWeight
	{
		get
		{
			CheckDestroyed();
			if (!DistanceWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:DistanceWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DistanceWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DistanceWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:DistanceWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DistanceWeight_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, 10f)]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("通用设置")]
	[DisplayName("角度分权重")]
	[Tooltip(">0时值越大分越高，<0时值越小分越高, =0时不计算此项分值")]
	[UMeta(MDProp.ClampMin, -10f)]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:AngleWeight")]
	public float AngleWeight
	{
		get
		{
			CheckDestroyed();
			if (!AngleWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:AngleWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AngleWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngleWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:AngleWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AngleWeight_Offset), value);
			}
		}
	}

	[Category("通用设置")]
	[UProperty]
	[DisplayName("射线检测分权重")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, -10f)]
	[Tooltip(">0时值越大分越高，<0时值越小分越高, =0时不计算此项分值")]
	[UMeta(MDProp.ClampMax, 10f)]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:LineTraceWeight")]
	public float LineTraceWeight
	{
		get
		{
			CheckDestroyed();
			if (!LineTraceWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:LineTraceWeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LineTraceWeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineTraceWeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:LineTraceWeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LineTraceWeight_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("约束条件")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:NeedRemoveCurrentCatch")]
	public bool NeedRemoveCurrentCatch
	{
		get
		{
			CheckDestroyed();
			if (!NeedRemoveCurrentCatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:NeedRemoveCurrentCatch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedRemoveCurrentCatch_Offset), 0, NeedRemoveCurrentCatch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedRemoveCurrentCatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:NeedRemoveCurrentCatch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedRemoveCurrentCatch_Offset), 0, NeedRemoveCurrentCatch_PropertyAddress.Address, value);
			}
		}
	}

	[Category("约束条件")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:EnableSearchDistanceScope")]
	public bool EnableSearchDistanceScope
	{
		get
		{
			CheckDestroyed();
			if (!EnableSearchDistanceScope_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:EnableSearchDistanceScope");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSearchDistanceScope_Offset), 0, EnableSearchDistanceScope_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSearchDistanceScope_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:EnableSearchDistanceScope");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSearchDistanceScope_Offset), 0, EnableSearchDistanceScope_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("约束条件")]
	[UMeta(MDProp.EditCondition, "EnableSearchDistanceScope")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:MinSearchDistance")]
	public float MinSearchDistance
	{
		get
		{
			CheckDestroyed();
			if (!MinSearchDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:MinSearchDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinSearchDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinSearchDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:MinSearchDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinSearchDistance_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "EnableSearchDistanceScope")]
	[Category("约束条件")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:MaxSearchDistance")]
	public float MaxSearchDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxSearchDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:MaxSearchDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSearchDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSearchDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:MaxSearchDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSearchDistance_Offset), value);
			}
		}
	}

	[Category("约束条件")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:EnableSearchAngleRequirement")]
	public bool EnableSearchAngleRequirement
	{
		get
		{
			CheckDestroyed();
			if (!EnableSearchAngleRequirement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:EnableSearchAngleRequirement");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableSearchAngleRequirement_Offset), 0, EnableSearchAngleRequirement_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableSearchAngleRequirement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:EnableSearchAngleRequirement");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableSearchAngleRequirement_Offset), 0, EnableSearchAngleRequirement_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "EnableSearchAngleRequirement")]
	[Category("约束条件")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_TryFindSceneItem:RequiredMaxSearchAngle")]
	public float RequiredMaxSearchAngle
	{
		get
		{
			CheckDestroyed();
			if (!RequiredMaxSearchAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:RequiredMaxSearchAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RequiredMaxSearchAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RequiredMaxSearchAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_TryFindSceneItem:RequiredMaxSearchAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RequiredMaxSearchAngle_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		NeedRemoveCurrentCatch = true;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		ACharacter aCharacter = OwnerActor as ACharacter;
		if (aCharacter != null)
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
				queryBestLocationConditionObject.DistanceWeight = -1f;
				break;
			case EFindSceneItemWay.FindFurthest:
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
			}
			queryBestLocationConditionObject.EnableDistanceScope = EnableSearchDistanceScope;
			queryBestLocationConditionObject.MinDistance = MinSearchDistance;
			queryBestLocationConditionObject.MaxDistance = MaxSearchDistance;
			queryBestLocationConditionObject.EnableAngleScope = EnableSearchAngleRequirement;
			queryBestLocationConditionObject.MinAngle = 0f;
			queryBestLocationConditionObject.MaxAngle = RequiredMaxSearchAngle;
			BUS_EventCollectionCS.Get(aCharacter).Evt_TryCatchSceneItemByCondition.Invoke(SceneActorTags.ToList(), queryBestLocationConditionObject, NeedRemoveCurrentCatch);
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_TryFindSceneItem");
		NativeReflection.GetPropertyRef(ref SceneActorTags_PropertyAddress, unrealStruct, "SceneActorTags");
		SceneActorTags_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneActorTags");
		SceneActorTags_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneActorTags", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref FindSceneItemWay_PropertyAddress, unrealStruct, "FindSceneItemWay");
		FindSceneItemWay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FindSceneItemWay");
		FindSceneItemWay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FindSceneItemWay", Classes.FEnumProperty);
		DistanceWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistanceWeight");
		DistanceWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistanceWeight", Classes.FFloatProperty);
		AngleWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AngleWeight");
		AngleWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AngleWeight", Classes.FFloatProperty);
		LineTraceWeight_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LineTraceWeight");
		LineTraceWeight_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LineTraceWeight", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref NeedRemoveCurrentCatch_PropertyAddress, unrealStruct, "NeedRemoveCurrentCatch");
		NeedRemoveCurrentCatch_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedRemoveCurrentCatch");
		NeedRemoveCurrentCatch_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedRemoveCurrentCatch", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref EnableSearchDistanceScope_PropertyAddress, unrealStruct, "EnableSearchDistanceScope");
		EnableSearchDistanceScope_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableSearchDistanceScope");
		EnableSearchDistanceScope_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableSearchDistanceScope", Classes.FBoolProperty);
		MinSearchDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinSearchDistance");
		MinSearchDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinSearchDistance", Classes.FFloatProperty);
		MaxSearchDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxSearchDistance");
		MaxSearchDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxSearchDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableSearchAngleRequirement_PropertyAddress, unrealStruct, "EnableSearchAngleRequirement");
		EnableSearchAngleRequirement_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnableSearchAngleRequirement");
		EnableSearchAngleRequirement_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnableSearchAngleRequirement", Classes.FBoolProperty);
		RequiredMaxSearchAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RequiredMaxSearchAngle");
		RequiredMaxSearchAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RequiredMaxSearchAngle", Classes.FFloatProperty);
	}

	static BAIT_TryFindSceneItem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_TryFindSceneItem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_TryFindSceneItem));
	}
}
