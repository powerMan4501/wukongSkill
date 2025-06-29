using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSceneItemBase")]
public class BGUSceneItemBase : BGUActorBaseCS
{
	private static bool StaticMeshComp_IsValid;

	private static int StaticMeshComp_Offset;

	private static bool SceneItemCommComp_IsValid;

	private static int SceneItemCommComp_Offset;

	private static bool SphereCollisionComp_IsValid;

	private static int SphereCollisionComp_Offset;

	private static bool BoxCollisionComp_IsValid;

	private static int BoxCollisionComp_Offset;

	private static bool CapsuleCollisionComp_IsValid;

	private static int CapsuleCollisionComp_Offset;

	private static bool BeginPlayCS_IsValid;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSceneItemBase:StaticMeshComp")]
	public UStaticMeshComponent StaticMeshComp
	{
		get
		{
			CheckDestroyed();
			if (!StaticMeshComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneItemBase:StaticMeshComp");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, StaticMeshComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMeshComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneItemBase:StaticMeshComp");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, StaticMeshComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSceneItemBase:SceneItemCommComp")]
	public BUS_SceneItemCommComp SceneItemCommComp
	{
		get
		{
			CheckDestroyed();
			if (!SceneItemCommComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneItemBase:SceneItemCommComp");
				return null;
			}
			return UObjectMarshaler<BUS_SceneItemCommComp>.FromNative(IntPtr.Add(base.Address, SceneItemCommComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneItemCommComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneItemBase:SceneItemCommComp");
			}
			else
			{
				UObjectMarshaler<BUS_SceneItemCommComp>.ToNative(IntPtr.Add(base.Address, SceneItemCommComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSceneItemBase:SphereCollisionComp")]
	protected USphereComponent SphereCollisionComp
	{
		get
		{
			CheckDestroyed();
			if (!SphereCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneItemBase:SphereCollisionComp");
				return null;
			}
			return UObjectMarshaler<USphereComponent>.FromNative(IntPtr.Add(base.Address, SphereCollisionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SphereCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneItemBase:SphereCollisionComp");
			}
			else
			{
				UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(base.Address, SphereCollisionComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSceneItemBase:BoxCollisionComp")]
	protected UBoxComponent BoxCollisionComp
	{
		get
		{
			CheckDestroyed();
			if (!BoxCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneItemBase:BoxCollisionComp");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, BoxCollisionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoxCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneItemBase:BoxCollisionComp");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, BoxCollisionComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUSceneItemBase:CapsuleCollisionComp")]
	protected UCapsuleComponent CapsuleCollisionComp
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneItemBase:CapsuleCollisionComp");
				return null;
			}
			return UObjectMarshaler<UCapsuleComponent>.FromNative(IntPtr.Add(base.Address, CapsuleCollisionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleCollisionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSceneItemBase:CapsuleCollisionComp");
			}
			else
			{
				UObjectMarshaler<UCapsuleComponent>.ToNative(IntPtr.Add(base.Address, CapsuleCollisionComp_Offset), value);
			}
		}
	}

	public USphereComponent GetSphereCollisionComp()
	{
		return SphereCollisionComp;
	}

	public UBoxComponent GetBoxCollisionComp()
	{
		return BoxCollisionComp;
	}

	public UCapsuleComponent GetCapsuleCollisionComp()
	{
		return CapsuleCollisionComp;
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		BaseInitialize(initializer);
		SceneItemCommComp = initializer.CreateDefaultSubobject<BUS_SceneItemCommComp>(this, B1GlobalFNames.SceneItemCommComp);
		SphereCollisionComp = initializer.CreateDefaultSubobject<USphereComponent>(this, B1GlobalFNames.SphereComp);
		SphereCollisionComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		SphereCollisionComp.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		BoxCollisionComp = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.BoxComp);
		BoxCollisionComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		BoxCollisionComp.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		CapsuleCollisionComp = initializer.CreateDefaultSubobject<UCapsuleComponent>(this, B1GlobalFNames.CapsuleComp);
		CapsuleCollisionComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		CapsuleCollisionComp.SetCollisionEnabled(ECollisionEnabled.NoCollision);
	}

	private void BaseInitialize(FObjectInitializer initializer)
	{
		StaticMeshComp = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.StaticMeshComp);
		SetRootComponentCS(StaticMeshComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_SceneItemCommCompImpl());
	}

	[USharpPath("/Script/b1-Managed.BGUSceneItemBase:BeginPlayCS")]
	protected override void BeginPlayCS_Implementation()
	{
		base.BeginPlayCS_Implementation();
		StaticMeshComp.SetSimulatePhysics(bSimulate: false);
		StaticMeshComp.SetEnableGravity(bGravityEnabled: true);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_SceneItemDataComp>(this, B1GlobalFNames.SceneItemDataComp);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSceneItemBase:BeginPlayCS")]
	private static void BeginPlayCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSceneItemBase bGUSceneItemBase = GCHelper.Find<BGUSceneItemBase>(obj);
		bGUSceneItemBase.BeginPlayCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSceneItemBase");
		StaticMeshComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "StaticMeshComp");
		StaticMeshComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StaticMeshComp", Classes.FObjectProperty);
		SceneItemCommComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneItemCommComp");
		SceneItemCommComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneItemCommComp", Classes.FObjectProperty);
		SphereCollisionComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "SphereCollisionComp");
		SphereCollisionComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SphereCollisionComp", Classes.FObjectProperty);
		BoxCollisionComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BoxCollisionComp");
		BoxCollisionComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BoxCollisionComp", Classes.FObjectProperty);
		CapsuleCollisionComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CapsuleCollisionComp");
		CapsuleCollisionComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CapsuleCollisionComp", Classes.FObjectProperty);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSceneItemBase:BeginPlayCS", BeginPlayCS_IsValid);
	}

	static BGUSceneItemBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSceneItemBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSceneItemBase));
	}
}
