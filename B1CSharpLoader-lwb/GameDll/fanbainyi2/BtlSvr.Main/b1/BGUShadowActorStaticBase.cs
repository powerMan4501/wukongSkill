using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUShadowActorStaticBase")]
public class BGUShadowActorStaticBase : BGUActorBaseCS
{
	private static bool BodyMesh_IsValid;

	private static int BodyMesh_Offset;

	private static bool HeadMesh_IsValid;

	private static int HeadMesh_Offset;

	private static bool ArmMesh_IsValid;

	private static int ArmMesh_Offset;

	private static bool FootMesh_IsValid;

	private static int FootMesh_Offset;

	private static bool WeaponMesh_IsValid;

	private static int WeaponMesh_Offset;

	private static bool HuluMesh_IsValid;

	private static int HuluMesh_Offset;

	private static bool TailMesh_IsValid;

	private static int TailMesh_Offset;

	private static bool HairMesh_IsValid;

	private static int HairMesh_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUShadowActorStaticBase:BodyMesh")]
	public UStaticMeshComponent BodyMesh
	{
		get
		{
			CheckDestroyed();
			if (!BodyMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:BodyMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, BodyMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BodyMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:BodyMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, BodyMesh_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUShadowActorStaticBase:HeadMesh")]
	public UStaticMeshComponent HeadMesh
	{
		get
		{
			CheckDestroyed();
			if (!HeadMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:HeadMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, HeadMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeadMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:HeadMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, HeadMesh_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUShadowActorStaticBase:ArmMesh")]
	public UStaticMeshComponent ArmMesh
	{
		get
		{
			CheckDestroyed();
			if (!ArmMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:ArmMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, ArmMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ArmMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:ArmMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, ArmMesh_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUShadowActorStaticBase:FootMesh")]
	public UStaticMeshComponent FootMesh
	{
		get
		{
			CheckDestroyed();
			if (!FootMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:FootMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, FootMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FootMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:FootMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, FootMesh_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUShadowActorStaticBase:WeaponMesh")]
	public UStaticMeshComponent WeaponMesh
	{
		get
		{
			CheckDestroyed();
			if (!WeaponMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:WeaponMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, WeaponMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeaponMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:WeaponMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, WeaponMesh_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUShadowActorStaticBase:HuluMesh")]
	public UStaticMeshComponent HuluMesh
	{
		get
		{
			CheckDestroyed();
			if (!HuluMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:HuluMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, HuluMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HuluMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:HuluMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, HuluMesh_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUShadowActorStaticBase:TailMesh")]
	public UStaticMeshComponent TailMesh
	{
		get
		{
			CheckDestroyed();
			if (!TailMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:TailMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, TailMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TailMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:TailMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, TailMesh_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUShadowActorStaticBase:HairMesh")]
	public UStaticMeshComponent HairMesh
	{
		get
		{
			CheckDestroyed();
			if (!HairMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:HairMesh");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, HairMesh_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HairMesh_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUShadowActorStaticBase:HairMesh");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, HairMesh_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		BodyMesh = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.BodyMesh);
		SetRootComponentCS(BodyMesh);
		BodyMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		HeadMesh = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.HeadMesh);
		HeadMesh.AttachToComponent(BodyMesh, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		HeadMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		ArmMesh = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.ArmMesh);
		ArmMesh.AttachToComponent(BodyMesh, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		ArmMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		FootMesh = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.FootMesh);
		FootMesh.AttachToComponent(BodyMesh, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		FootMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		WeaponMesh = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.WeaponMesh);
		WeaponMesh.AttachToComponent(BodyMesh, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		WeaponMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		HuluMesh = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.HuluMesh);
		HuluMesh.AttachToComponent(BodyMesh, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		HuluMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		TailMesh = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.TailMesh);
		TailMesh.AttachToComponent(BodyMesh, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		TailMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		HairMesh = initializer.CreateDefaultSubobject<UStaticMeshComponent>(this, B1GlobalFNames.HairMesh);
		HairMesh.AttachToComponent(BodyMesh, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		HairMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_ShadowPoseableComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_CustomDepthStencilComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ShadowActorDataComp>(this, B1GlobalFNames.ShadowActorDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUShadowActorStaticBase");
		BodyMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BodyMesh");
		BodyMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BodyMesh", Classes.FObjectProperty);
		HeadMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HeadMesh");
		HeadMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HeadMesh", Classes.FObjectProperty);
		ArmMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ArmMesh");
		ArmMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ArmMesh", Classes.FObjectProperty);
		FootMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FootMesh");
		FootMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FootMesh", Classes.FObjectProperty);
		WeaponMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeaponMesh");
		WeaponMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeaponMesh", Classes.FObjectProperty);
		HuluMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HuluMesh");
		HuluMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HuluMesh", Classes.FObjectProperty);
		TailMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TailMesh");
		TailMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TailMesh", Classes.FObjectProperty);
		HairMesh_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "HairMesh");
		HairMesh_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "HairMesh", Classes.FObjectProperty);
	}

	static BGUShadowActorStaticBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUShadowActorStaticBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUShadowActorStaticBase));
	}
}
