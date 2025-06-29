using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUShadowActorBase")]
public class BGUShadowActorBase : BGUActorBaseCS
{
	private static bool Mesh_IsValid;

	private static int Mesh_Offset;

	private static bool CharacterModularComp_IsValid;

	private static int CharacterModularComp_Offset;

	private static bool OnConstructionCS_IsValid;

	private static IntPtr OnConstructionCS_FunctionAddress;

	private static int OnConstructionCS_ParamsSize;

	private static bool OnConstructionCS_Transform_IsValid;

	private static int OnConstructionCS_Transform_Offset;

	private static FFieldAddress OnConstructionCS_Transform_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUShadowActorBase:Mesh")]
	public USkeletalMeshComponent Mesh
	{
		get
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorBase:Mesh");
				return null;
			}
			return UObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, Mesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Mesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorBase:Mesh");
			}
			else
			{
				UObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, Mesh_Offset), value);
			}
		}
	}

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUShadowActorBase:CharacterModularComp")]
	private BUS_CharacterModularComp CharacterModularComp
	{
		get
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorBase:CharacterModularComp");
				return null;
			}
			return UObjectMarshaler<BUS_CharacterModularComp>.FromNative(IntPtr.Add(base.Address, CharacterModularComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CharacterModularComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorBase:CharacterModularComp");
			}
			else
			{
				UObjectMarshaler<BUS_CharacterModularComp>.ToNative(IntPtr.Add(base.Address, CharacterModularComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Mesh = initializer.CreateDefaultSubobject<USkeletalMeshComponent>(this, B1GlobalFNames.CharacterMesh0);
		SetRootComponentCS(Mesh);
		Mesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		CharacterModularComp = initializer.CreateDefaultSubobject<BUS_CharacterModularComp>(this, B1GlobalFNames.CharacterModularComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_ShadowPoseableComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_CustomDepthStencilComp());
		base.ActorCompContainerCS.AddComp(new BUS_CharacterModularCompImpl(), 1);
		base.ActorCompContainerCS.AddComp(new BUS_EquipComp(), 1);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ShadowActorDataComp>(this, B1GlobalFNames.ShadowActorDataComp);
	}

	[USharpPath("/Script/b1-Managed.BGUShadowActorBase:OnConstructionCS")]
	protected override void OnConstructionCS_Implementation(FTransform Transform)
	{
		CharacterModularComp.OnActorConstruction();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUShadowActorBase:OnConstructionCS")]
	private static void OnConstructionCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUShadowActorBase bGUShadowActorBase = GCHelper.Find<BGUShadowActorBase>(obj);
		FTransform transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(buffer, OnConstructionCS_Transform_Offset));
		bGUShadowActorBase.OnConstructionCS_Implementation(transform);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUShadowActorBase");
		Mesh_Offset = NativeReflection.GetPropertyOffset(intPtr, "Mesh");
		Mesh_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Mesh", Classes.FObjectProperty);
		CharacterModularComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CharacterModularComp");
		CharacterModularComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CharacterModularComp", Classes.FObjectProperty);
		OnConstructionCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnConstructionCS");
		OnConstructionCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnConstructionCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref OnConstructionCS_Transform_PropertyAddress, OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_Offset = NativeReflection.GetPropertyOffset(OnConstructionCS_FunctionAddress, "Transform");
		OnConstructionCS_Transform_IsValid = NativeReflection.ValidatePropertyClass(OnConstructionCS_FunctionAddress, "Transform", Classes.FStructProperty);
		OnConstructionCS_IsValid = OnConstructionCS_FunctionAddress != IntPtr.Zero && OnConstructionCS_Transform_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUShadowActorBase:OnConstructionCS", OnConstructionCS_IsValid);
	}

	static BGUShadowActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUShadowActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUShadowActorBase));
	}
}
