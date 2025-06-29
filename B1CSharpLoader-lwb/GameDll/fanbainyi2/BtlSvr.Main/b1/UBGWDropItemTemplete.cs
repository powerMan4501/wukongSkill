using System;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete")]
public class UBGWDropItemTemplete : UBGWDataAsset
{
	private static bool TempleteType_IsValid;

	private static int TempleteType_Offset;

	private static FFieldAddress TempleteType_PropertyAddress;

	private static bool BPClass_IsValid;

	private static int BPClass_Offset;

	private static bool DADropFixed_IsValid;

	private static int DADropFixed_Offset;

	private static bool DAWaitSign_IsValid;

	private static int DAWaitSign_Offset;

	private static bool DAPickedSign_IsValid;

	private static int DAPickedSign_Offset;

	private static bool DropingCurve_IsValid;

	private static int DropingCurve_Offset;

	private static bool PickingCurve_IsValid;

	private static int PickingCurve_Offset;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool EQSActivationDistance_IsValid;

	private static int EQSActivationDistance_Offset;

	private static bool PickingConditionConfig_IsValid;

	private static int PickingConditionConfig_Offset;

	private static FFieldAddress PickingConditionConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FPickingConditionItem> PickingConditionConfig_Marshaler;

	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[DisplayName("掉落物表现类型")]
	[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete:TempleteType")]
	public EDropItemPerfromType TempleteType
	{
		get
		{
			CheckDestroyed();
			if (!TempleteType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:TempleteType");
				return EDropItemPerfromType.WithOutPick;
			}
			return EnumMarshaler<EDropItemPerfromType>.FromNative(IntPtr.Add(base.Address, TempleteType_Offset), 0, TempleteType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TempleteType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:TempleteType");
			}
			else
			{
				EnumMarshaler<EDropItemPerfromType>.ToNative(IntPtr.Add(base.Address, TempleteType_Offset), 0, TempleteType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("掉落物蓝图")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete:BPClass")]
	public TSubclassOf<BGUDropItemActorCS> BPClass
	{
		get
		{
			CheckDestroyed();
			if (!BPClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:BPClass");
				return default(TSubclassOf<BGUDropItemActorCS>);
			}
			return TSubclassOfMarshaler<BGUDropItemActorCS>.FromNative(IntPtr.Add(base.Address, BPClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BPClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:BPClass");
			}
			else
			{
				TSubclassOfMarshaler<BGUDropItemActorCS>.ToNative(IntPtr.Add(base.Address, BPClass_Offset), value);
			}
		}
	}

	[DisplayName("掉落时掉落物附带特效")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete:DADropFixed")]
	public BGWDataAsset_B1DBC DADropFixed
	{
		get
		{
			CheckDestroyed();
			if (!DADropFixed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:DADropFixed");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, DADropFixed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DADropFixed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:DADropFixed");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, DADropFixed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("光柱特效")]
	[UMeta(MDProp.EditCondition, "TempleteType != EDropItemPerfromType::WithOutPick")]
	[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete:DAWaitSign")]
	public BGWDataAsset_B1DBC DAWaitSign
	{
		get
		{
			CheckDestroyed();
			if (!DAWaitSign_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:DAWaitSign");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, DAWaitSign_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DAWaitSign_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:DAWaitSign");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, DAWaitSign_Offset), value);
			}
		}
	}

	[BlueprintReadOnly]
	[EditAnywhere]
	[DisplayName("吸收时角色特效")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete:DAPickedSign")]
	public BGWDataAsset_B1DBC DAPickedSign
	{
		get
		{
			CheckDestroyed();
			if (!DAPickedSign_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:DAPickedSign");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_B1DBC>.FromNative(IntPtr.Add(base.Address, DAPickedSign_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DAPickedSign_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:DAPickedSign");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_B1DBC>.ToNative(IntPtr.Add(base.Address, DAPickedSign_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("掉落飞行曲线")]
	[UMeta(MDProp.EditCondition, "TempleteType == EDropItemPerfromType::Standard")]
	[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete:DropingCurve")]
	public UCurveVector DropingCurve
	{
		get
		{
			CheckDestroyed();
			if (!DropingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:DropingCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, DropingCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DropingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:DropingCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, DropingCurve_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "TempleteType == EDropItemPerfromType::Standard")]
	[DisplayName("拾取飞行曲线")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete:PickingCurve")]
	public UCurveVector PickingCurve
	{
		get
		{
			CheckDestroyed();
			if (!PickingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:PickingCurve");
				return null;
			}
			return UObjectMarshaler<UCurveVector>.FromNative(IntPtr.Add(base.Address, PickingCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PickingCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:PickingCurve");
			}
			else
			{
				UObjectMarshaler<UCurveVector>.ToNative(IntPtr.Add(base.Address, PickingCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("生成选点EQS")]
	[UMeta(MDProp.EditCondition, "TempleteType == EDropItemPerfromType::Standard")]
	[Tooltip("如果掉落者的pelvis位置寻路不可达，则尝试使用EQSTemplate寻找一个新的位置作为掉落交互物的生成位置")]
	[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete:EQSTemplate")]
	public UEnvQuery EQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:EQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, EQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:EQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, EQSTemplate_Offset), value);
			}
		}
	}

	[Tooltip("掉落者的pelvis位置寻路不可达，且超出该距离时，才使用EQS；否则直接生成到pelvis点。")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("EQS策略启用距离")]
	[UMeta(MDProp.EditCondition, "TempleteType == EDropItemPerfromType::Standard")]
	[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete:EQSActivationDistance")]
	public float EQSActivationDistance
	{
		get
		{
			CheckDestroyed();
			if (!EQSActivationDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:EQSActivationDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, EQSActivationDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSActivationDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:EQSActivationDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, EQSActivationDistance_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("拾取条件配置")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UBGWDropItemTemplete:PickingConditionConfig")]
	public TArrayReadWrite<FPickingConditionItem> PickingConditionConfig
	{
		get
		{
			CheckDestroyed();
			if (!PickingConditionConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UBGWDropItemTemplete:PickingConditionConfig");
				return null;
			}
			if (PickingConditionConfig_Marshaler == null)
			{
				PickingConditionConfig_Marshaler = new TArrayReadWriteMarshaler<FPickingConditionItem>(1, PickingConditionConfig_PropertyAddress, CachedMarshalingDelegates<FPickingConditionItem, FPickingConditionItem>.FromNative, CachedMarshalingDelegates<FPickingConditionItem, FPickingConditionItem>.ToNative);
			}
			return PickingConditionConfig_Marshaler.FromNative(IntPtr.Add(base.Address, PickingConditionConfig_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.UBGWDropItemTemplete");
		NativeReflection.GetPropertyRef(ref TempleteType_PropertyAddress, unrealStruct, "TempleteType");
		TempleteType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TempleteType");
		TempleteType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TempleteType", Classes.FEnumProperty);
		BPClass_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BPClass");
		BPClass_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BPClass", Classes.FClassProperty);
		DADropFixed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DADropFixed");
		DADropFixed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DADropFixed", Classes.FObjectProperty);
		DAWaitSign_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DAWaitSign");
		DAWaitSign_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DAWaitSign", Classes.FObjectProperty);
		DAPickedSign_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DAPickedSign");
		DAPickedSign_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DAPickedSign", Classes.FObjectProperty);
		DropingCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DropingCurve");
		DropingCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DropingCurve", Classes.FObjectProperty);
		PickingCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PickingCurve");
		PickingCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PickingCurve", Classes.FObjectProperty);
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EQSTemplate", Classes.FObjectProperty);
		EQSActivationDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EQSActivationDistance");
		EQSActivationDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EQSActivationDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref PickingConditionConfig_PropertyAddress, unrealStruct, "PickingConditionConfig");
		PickingConditionConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PickingConditionConfig");
		PickingConditionConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PickingConditionConfig", Classes.FArrayProperty);
	}

	static UBGWDropItemTemplete()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UBGWDropItemTemplete)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWDropItemTemplete));
	}
}
