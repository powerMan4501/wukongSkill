using System;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTransPreviewActorBase")]
internal class BGUTransPreviewActorBase : BGUActorBaseCS
{
	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	private static bool NormalLight_IsValid;

	private static int NormalLight_Offset;

	private static bool Light_IsValid;

	private static int Light_Offset;

	private static bool DefaultRootComp_IsValid;

	private static int DefaultRootComp_Offset;

	private static bool AttachComp_IsValid;

	private static int AttachComp_Offset;

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
	[USharpPath("/Script/b1-Managed.BGUTransPreviewActorBase:Mesh")]
	public USkeletalMeshComponent Mesh
	{
		get
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:Mesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, Mesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:Mesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, Mesh_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUTransPreviewActorBase:NormalLight")]
	public USceneComponent NormalLight
	{
		get
		{
			CheckDestroyed();
			if (!NormalLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:NormalLight");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, NormalLight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalLight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:NormalLight");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, NormalLight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUTransPreviewActorBase:Light")]
	public USceneComponent Light
	{
		get
		{
			CheckDestroyed();
			if (!Light_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:Light");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Light_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Light_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:Light");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Light_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUTransPreviewActorBase:DefaultRootComp")]
	public USceneComponent DefaultRootComp
	{
		get
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:DefaultRootComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, DefaultRootComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DefaultRootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:DefaultRootComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, DefaultRootComp_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUTransPreviewActorBase:AttachComp")]
	public USceneComponent AttachComp
	{
		get
		{
			CheckDestroyed();
			if (!AttachComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:AttachComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, AttachComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AttachComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:AttachComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, AttachComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUTransPreviewActorBase:CharacterModularComp")]
	private BUS_CharacterModularComp CharacterModularComp
	{
		get
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:CharacterModularComp");
				return null;
			}
			return UObjectMarshaler<BUS_CharacterModularComp>.FromNative(IntPtr.Add(base.Address, CharacterModularComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:CharacterModularComp");
			}
			else
			{
				UObjectMarshaler<BUS_CharacterModularComp>.ToNative(IntPtr.Add(base.Address, CharacterModularComp_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUTransPreviewActorBase:Datas")]
	private TArrayReadWrite<UObject> Datas
	{
		get
		{
			CheckDestroyed();
			if (!Datas_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTransPreviewActorBase:Datas");
				return null;
			}
			if (Datas_Marshaler == null)
			{
				Datas_Marshaler = new TArrayReadWriteMarshaler<UObject>(1, Datas_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative);
			}
			return Datas_Marshaler.FromNative(IntPtr.Add(base.Address, Datas_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BGUTransPreviewActorBase:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		base.OnConstructionCS_Implementation(Transform);
		UpdateLight(IsNormal: true);
		Mesh?.SetUpdateAnimationInEditor(NewUpdateState: true);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DefaultRootComp = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.DefaultRootComp);
		SetRootComponentCS(DefaultRootComp);
		AttachComp = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.AttachPoint);
		AttachComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		Mesh = initializer.CreateDefaultSubobject<USkeletalMeshComponent>(this, B1GlobalFNames.CharacterMesh);
		Mesh.AttachToComponent(AttachComp, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		NormalLight = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.NormalLight);
		NormalLight.AttachToComponent(DefaultRootComp, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		Light = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Light);
		Light.AttachToComponent(AttachComp, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		CharacterModularComp = initializer.CreateDefaultSubobject<BUS_CharacterModularComp>(this, B1GlobalFNames.CharacterModularComp);
		Mesh.ComponentTags.Add(B1GlobalFNames.master);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_TransPreviewActorDataComp>(this, B1GlobalFNames.TransPreviewActorDataComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		BGW_ECSWorld.Get(this)?.SetObject(base.ECSEntity, new BUS_DispLibEventCollection());
		base.ActorCompContainerCS.AddComp(new BUS_DispLibUnitMaterialsManageComp());
		base.ActorCompContainerCS.AddComp(new BUS_DispLibDBCManageComp(), 1);
		base.ActorCompContainerCS.AddComp(new BUS_CharacterModularCompImpl(), 1);
		base.ActorCompContainerCS.AddComp(new BUS_TickEvenPausedComp());
	}

	protected T CreateData<T>(BGW_ECSWorld ECSWorld) where T : UObject
	{
		T val = UObject.NewObject<T>(this);
		ECSWorld.SetObject(base.ECSEntity, val);
		Datas.Add(val);
		return val;
	}

	public void UpdateLight(bool IsNormal)
	{
		NormalLight?.SetVisibility(IsNormal, bPropagateToChildren: true);
		Light?.SetVisibility(!IsNormal, bPropagateToChildren: true);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUTransPreviewActorBase:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGUTransPreviewActorBase bGUTransPreviewActorBase = GCHelper.Find<b1.BGUTransPreviewActorBase>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUTransPreviewActorBase.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUTransPreviewActorBase");
		Mesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "Mesh");
		Mesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Mesh", Classes.FObjectProperty);
		NormalLight_Offset = NativeReflection.GetPropertyOffset(intPtr, "NormalLight");
		NormalLight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NormalLight", Classes.FObjectProperty);
		Light_Offset = NativeReflection.GetPropertyOffset(intPtr, "Light");
		Light_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Light", Classes.FObjectProperty);
		DefaultRootComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaultRootComp");
		DefaultRootComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaultRootComp", Classes.FObjectProperty);
		AttachComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttachComp");
		AttachComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttachComp", Classes.FObjectProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUTransPreviewActorBase:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUTransPreviewActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUTransPreviewActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUTransPreviewActorBase));
	}
}
