using System;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUEquipPreviewActorBase")]
internal class BGUEquipPreviewActorBase : BGUActorBaseCS
{
	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	private static bool CharacterModularComp_IsValid;

	private static int CharacterModularComp_Offset;

	private static bool Datas_IsValid;

	private static int Datas_Offset;

	private static FFieldAddress Datas_PropertyAddress;

	private TArrayReadWriteMarshaler<UObject> Datas_Marshaler;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUEquipPreviewActorBase:Mesh")]
	public USkeletalMeshComponent Mesh
	{
		get
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEquipPreviewActorBase:Mesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, Mesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEquipPreviewActorBase:Mesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, Mesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUEquipPreviewActorBase:CharacterModularComp")]
	private BUS_CharacterModularComp CharacterModularComp
	{
		get
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEquipPreviewActorBase:CharacterModularComp");
				return null;
			}
			return UObjectMarshaler<BUS_CharacterModularComp>.FromNative(IntPtr.Add(base.Address, CharacterModularComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEquipPreviewActorBase:CharacterModularComp");
			}
			else
			{
				UObjectMarshaler<BUS_CharacterModularComp>.ToNative(IntPtr.Add(base.Address, CharacterModularComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUEquipPreviewActorBase:Datas")]
	private TArrayReadWrite<UObject> Datas
	{
		get
		{
			CheckDestroyed();
			if (!Datas_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEquipPreviewActorBase:Datas");
				return null;
			}
			if (Datas_Marshaler == null)
			{
				Datas_Marshaler = new TArrayReadWriteMarshaler<UObject>(1, Datas_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return Datas_Marshaler.FromNative(IntPtr.Add(base.Address, Datas_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.PrimaryActorTick.SetCanEverTick(canEverTick: true);
		Mesh = initializer.CreateDefaultSubobject<USkeletalMeshComponent>(this, B1GlobalFNames.CharacterMesh);
		CharacterModularComp = initializer.CreateDefaultSubobject<BUS_CharacterModularComp>(this, B1GlobalFNames.CharacterModularComp);
		SetRootComponentCS(Mesh);
		Mesh.ComponentTags.Add(B1GlobalFNames.master);
		Mesh.SetHiddenInGame(NewHidden: true);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_EquipPreviewActorDataComp>(this, B1GlobalFNames.EquipPreviewActorDataComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(this);
		bGW_ECSWorld?.SetObject(base.ECSEntity, new BUS_DispLibEventCollection());
		USkeletalMeshComponent componentByClass = GetComponentByClass<USkeletalMeshComponent>();
		BUC_DispLibUnitRendererBaseData bUC_DispLibUnitRendererBaseData = CreateDataClass<BUC_DispLibUnitRendererBaseData>(bGW_ECSWorld);
		bUC_DispLibUnitRendererBaseData.Init(300f, 0, componentByClass);
		CreateDataClass<BUC_DispLibSetUnitMaterialsParamsRequestsQueueData>(bGW_ECSWorld).Init(bUC_DispLibUnitRendererBaseData);
		CreateDataClass<BUC_DispLibDBCBaseData>(bGW_ECSWorld).Init(componentByClass, DispLibDBCActorGroup.EquipPreview);
		CreateDataClass<BUC_DispLibDBCQueueData>(bGW_ECSWorld).Init();
		base.ActorCompContainerCS.AddComp(new BUS_DispLibUnitMaterialsManageComp());
		base.ActorCompContainerCS.AddComp(new BUS_DispLibDBCManageComp(), 1);
		base.ActorCompContainerCS.AddComp(new BUS_CharacterModularCompImpl(), 1);
		base.ActorCompContainerCS.AddComp(new BUS_EquipComp(), 1);
		base.ActorCompContainerCS.AddComp(new BUS_TickEvenPausedComp());
	}

	[USharpPath("/Script/b1-Managed.BGUEquipPreviewActorBase:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
		CharacterModularComp?.OnActorConstruction();
	}

	protected T CreateData<T>(BGW_ECSWorld ECSWorld) where T : UObject
	{
		T val = UObject.NewObject<T>(this);
		ECSWorld.SetObject(base.ECSEntity, val);
		Datas.Add(val);
		return val;
	}

	protected T CreateDataClass<T>(BGW_ECSWorld ECSWorld) where T : class, new()
	{
		T val = new T();
		ECSWorld?.SetObject(base.ECSEntity, val);
		return val;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUEquipPreviewActorBase:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUEquipPreviewActorBase bGUEquipPreviewActorBase = GCHelper.Find<b1.BGUEquipPreviewActorBase>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUEquipPreviewActorBase.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUEquipPreviewActorBase");
		Mesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "Mesh");
		Mesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Mesh", Classes.FObjectProperty);
		CharacterModularComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CharacterModularComp");
		CharacterModularComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CharacterModularComp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref Datas_PropertyAddress, intPtr, "Datas");
		Datas_Offset = NativeReflection.GetPropertyOffset(intPtr, "Datas");
		Datas_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Datas", Classes.FArrayProperty);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUEquipPreviewActorBase:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUEquipPreviewActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUEquipPreviewActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUEquipPreviewActorBase));
	}
}
