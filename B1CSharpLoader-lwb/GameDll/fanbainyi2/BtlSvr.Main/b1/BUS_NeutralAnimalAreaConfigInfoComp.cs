using System;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp")]
public class BUS_NeutralAnimalAreaConfigInfoComp : UActorEditCompBase
{
	private static bool bDrawDebug_IsValid;

	private static int bDrawDebug_Offset;

	private static FFieldAddress bDrawDebug_PropertyAddress;

	private static bool DestroyAllAnimalWhenPlaySeq_IsValid;

	private static int DestroyAllAnimalWhenPlaySeq_Offset;

	private static FFieldAddress DestroyAllAnimalWhenPlaySeq_PropertyAddress;

	private static bool DontSpawnInCloudMove_IsValid;

	private static int DontSpawnInCloudMove_Offset;

	private static FFieldAddress DontSpawnInCloudMove_PropertyAddress;

	private static bool DistributionSpawnTendency_IsValid;

	private static int DistributionSpawnTendency_Offset;

	private static FFieldAddress DistributionSpawnTendency_PropertyAddress;

	private static bool PresetCD_IsValid;

	private static int PresetCD_Offset;

	private static bool SpawnCD_IsValid;

	private static int SpawnCD_Offset;

	private static bool DestroyProtectCD_IsValid;

	private static int DestroyProtectCD_Offset;

	private static bool SpawnPosType_IsValid;

	private static int SpawnPosType_Offset;

	private static FFieldAddress SpawnPosType_PropertyAddress;

	private static bool AnimalTemplates_IsValid;

	private static int AnimalTemplates_Offset;

	private static FFieldAddress AnimalTemplates_PropertyAddress;

	private TArrayReadWriteMarshaler<FAnimalSpawnTemplate> AnimalTemplates_Marshaler;

	private static bool EQSTemplate_IsValid;

	private static int EQSTemplate_Offset;

	private static bool SpawnRotType_IsValid;

	private static int SpawnRotType_Offset;

	private static FFieldAddress SpawnRotType_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("调试开关")]
	[Category("Debug")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:bDrawDebug")]
	public bool bDrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:bDrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bDrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:bDrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bDrawDebug_Offset), 0, bDrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Default")]
	[UProperty]
	[DisplayName("进入Seq时销毁所有生物")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DestroyAllAnimalWhenPlaySeq")]
	public bool DestroyAllAnimalWhenPlaySeq
	{
		get
		{
			CheckDestroyed();
			if (!DestroyAllAnimalWhenPlaySeq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DestroyAllAnimalWhenPlaySeq");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DestroyAllAnimalWhenPlaySeq_Offset), 0, DestroyAllAnimalWhenPlaySeq_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DestroyAllAnimalWhenPlaySeq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DestroyAllAnimalWhenPlaySeq");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DestroyAllAnimalWhenPlaySeq_Offset), 0, DestroyAllAnimalWhenPlaySeq_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("筋斗云上不触发生成事件")]
	[Category("Default")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DontSpawnInCloudMove")]
	public bool DontSpawnInCloudMove
	{
		get
		{
			CheckDestroyed();
			if (!DontSpawnInCloudMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DontSpawnInCloudMove");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DontSpawnInCloudMove_Offset), 0, DontSpawnInCloudMove_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DontSpawnInCloudMove_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DontSpawnInCloudMove");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DontSpawnInCloudMove_Offset), 0, DontSpawnInCloudMove_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("留坑，后续可扩展")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("生成分布倾向")]
	[Category("Default")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DistributionSpawnTendency")]
	public EAnimalDistributionSpawnTendency DistributionSpawnTendency
	{
		get
		{
			CheckDestroyed();
			if (!DistributionSpawnTendency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DistributionSpawnTendency");
				return EAnimalDistributionSpawnTendency.Concentrated;
			}
			return EnumMarshaler<EAnimalDistributionSpawnTendency>.FromNative(IntPtr.Add(base.Address, DistributionSpawnTendency_Offset), 0, DistributionSpawnTendency_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DistributionSpawnTendency_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DistributionSpawnTendency");
			}
			else
			{
				EnumMarshaler<EAnimalDistributionSpawnTendency>.ToNative(IntPtr.Add(base.Address, DistributionSpawnTendency_Offset), 0, DistributionSpawnTendency_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("进入区域时开始进入预置CD，CD结束后若玩家还在刷新区域内，则执行刷新")]
	[BlueprintReadWrite]
	[Category("Default")]
	[DisplayName("触发预置冷却时间")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:PresetCD")]
	public float PresetCD
	{
		get
		{
			CheckDestroyed();
			if (!PresetCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:PresetCD");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PresetCD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PresetCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:PresetCD");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PresetCD_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Default")]
	[DisplayName("生成冷却时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:SpawnCD")]
	public float SpawnCD
	{
		get
		{
			CheckDestroyed();
			if (!SpawnCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:SpawnCD");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SpawnCD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:SpawnCD");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SpawnCD_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Default")]
	[DisplayName("销毁后再生成的保护CD")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DestroyProtectCD")]
	public float DestroyProtectCD
	{
		get
		{
			CheckDestroyed();
			if (!DestroyProtectCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DestroyProtectCD");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestroyProtectCD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestroyProtectCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:DestroyProtectCD");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestroyProtectCD_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Default")]
	[DisplayName("生成位置类型")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:SpawnPosType")]
	public EAnimalSpawnPosType SpawnPosType
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPosType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:SpawnPosType");
				return EAnimalSpawnPosType.EQS_Runtime;
			}
			return EnumMarshaler<EAnimalSpawnPosType>.FromNative(IntPtr.Add(base.Address, SpawnPosType_Offset), 0, SpawnPosType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpawnPosType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:SpawnPosType");
			}
			else
			{
				EnumMarshaler<EAnimalSpawnPosType>.ToNative(IntPtr.Add(base.Address, SpawnPosType_Offset), 0, SpawnPosType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[DisplayName("生物模板列表EQS")]
	[EditAnywhere]
	[Category("Default")]
	[UMeta(MDProp.EditCondition, "SpawnPosType == AnimalSpawnPosType::EQS_Runtime")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:AnimalTemplates")]
	public TArrayReadWrite<FAnimalSpawnTemplate> AnimalTemplates
	{
		get
		{
			CheckDestroyed();
			if (!AnimalTemplates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:AnimalTemplates");
				return null;
			}
			if (AnimalTemplates_Marshaler == null)
			{
				AnimalTemplates_Marshaler = new TArrayReadWriteMarshaler<FAnimalSpawnTemplate>(1, AnimalTemplates_PropertyAddress, CachedMarshalingDelegates<FAnimalSpawnTemplate, FAnimalSpawnTemplate>.FromNative, CachedMarshalingDelegates<FAnimalSpawnTemplate, FAnimalSpawnTemplate>.ToNative);
			}
			return AnimalTemplates_Marshaler.FromNative(IntPtr.Add(base.Address, AnimalTemplates_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "SpawnPosType == AnimalSpawnPosType::EQS_Runtime")]
	[DisplayName("生成点EQS")]
	[Category("Default")]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:EQSTemplate")]
	public UEnvQuery EQSTemplate
	{
		get
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:EQSTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, EQSTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EQSTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:EQSTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, EQSTemplate_Offset), value);
			}
		}
	}

	[Category("Default")]
	[DisplayName("生成旋转类型")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:SpawnRotType")]
	public EAnimalSpawnRotType SpawnRotType
	{
		get
		{
			CheckDestroyed();
			if (!SpawnRotType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:SpawnRotType");
				return EAnimalSpawnRotType.RandomYaw;
			}
			return EnumMarshaler<EAnimalSpawnRotType>.FromNative(IntPtr.Add(base.Address, SpawnRotType_Offset), 0, SpawnRotType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpawnRotType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp:SpawnRotType");
			}
			else
			{
				EnumMarshaler<EAnimalSpawnRotType>.ToNative(IntPtr.Add(base.Address, SpawnRotType_Offset), 0, SpawnRotType_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DestroyAllAnimalWhenPlaySeq = true;
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_NeutralAnimalAreaLogicData bUC_NeutralAnimalAreaLogicData = RequireWritableData<BUC_NeutralAnimalAreaLogicData>();
		bUC_NeutralAnimalAreaLogicData.bDrawDebug = bDrawDebug;
		bUC_NeutralAnimalAreaLogicData.DestroyAllAnimalWhenPlaySeq = DestroyAllAnimalWhenPlaySeq;
		bUC_NeutralAnimalAreaLogicData.DontSpawnInCloudMove = DontSpawnInCloudMove;
		bUC_NeutralAnimalAreaLogicData.DistributionSpawnTendency = DistributionSpawnTendency;
		bUC_NeutralAnimalAreaLogicData.PresetCD = PresetCD;
		bUC_NeutralAnimalAreaLogicData.SpawnCD = SpawnCD;
		bUC_NeutralAnimalAreaLogicData.DestroyProtectCD = DestroyProtectCD;
		bUC_NeutralAnimalAreaLogicData.SpawnPosType = SpawnPosType;
		bUC_NeutralAnimalAreaLogicData.EQSTemplate = EQSTemplate;
		bUC_NeutralAnimalAreaLogicData.SpawnRotType = SpawnRotType;
		foreach (FAnimalSpawnTemplate animalTemplate in AnimalTemplates)
		{
			bUC_NeutralAnimalAreaLogicData.AnimalTemplates.Add(animalTemplate);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_NeutralAnimalAreaConfigInfoComp");
		NativeReflection.GetPropertyRef(ref bDrawDebug_PropertyAddress, unrealStruct, "bDrawDebug");
		bDrawDebug_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bDrawDebug");
		bDrawDebug_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bDrawDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DestroyAllAnimalWhenPlaySeq_PropertyAddress, unrealStruct, "DestroyAllAnimalWhenPlaySeq");
		DestroyAllAnimalWhenPlaySeq_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestroyAllAnimalWhenPlaySeq");
		DestroyAllAnimalWhenPlaySeq_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestroyAllAnimalWhenPlaySeq", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DontSpawnInCloudMove_PropertyAddress, unrealStruct, "DontSpawnInCloudMove");
		DontSpawnInCloudMove_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DontSpawnInCloudMove");
		DontSpawnInCloudMove_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DontSpawnInCloudMove", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref DistributionSpawnTendency_PropertyAddress, unrealStruct, "DistributionSpawnTendency");
		DistributionSpawnTendency_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DistributionSpawnTendency");
		DistributionSpawnTendency_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DistributionSpawnTendency", Classes.FEnumProperty);
		PresetCD_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PresetCD");
		PresetCD_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PresetCD", Classes.FFloatProperty);
		SpawnCD_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnCD");
		SpawnCD_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnCD", Classes.FFloatProperty);
		DestroyProtectCD_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DestroyProtectCD");
		DestroyProtectCD_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DestroyProtectCD", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SpawnPosType_PropertyAddress, unrealStruct, "SpawnPosType");
		SpawnPosType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnPosType");
		SpawnPosType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnPosType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref AnimalTemplates_PropertyAddress, unrealStruct, "AnimalTemplates");
		AnimalTemplates_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AnimalTemplates");
		AnimalTemplates_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AnimalTemplates", Classes.FArrayProperty);
		EQSTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EQSTemplate");
		EQSTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EQSTemplate", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref SpawnRotType_PropertyAddress, unrealStruct, "SpawnRotType");
		SpawnRotType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpawnRotType");
		SpawnRotType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpawnRotType", Classes.FEnumProperty);
	}

	static BUS_NeutralAnimalAreaConfigInfoComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_NeutralAnimalAreaConfigInfoComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_NeutralAnimalAreaConfigInfoComp));
	}
}
