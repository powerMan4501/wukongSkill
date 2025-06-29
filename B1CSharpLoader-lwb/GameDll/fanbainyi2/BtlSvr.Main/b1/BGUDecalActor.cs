using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDecalActor")]
public class BGUDecalActor : BGUFXActorBase
{
	private static bool RootComp_IsValid;

	private static int RootComp_Offset;

	private static bool DecalComp_IsValid;

	private static int DecalComp_Offset;

	private static bool DecalConfigComp_IsValid;

	private static int DecalConfigComp_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDecalActor:RootComp")]
	public USceneComponent RootComp
	{
		get
		{
			CheckDestroyed();
			if (!RootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDecalActor:RootComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, RootComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDecalActor:RootComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, RootComp_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDecalActor:DecalComp")]
	public UDecalComponent DecalComp
	{
		get
		{
			CheckDestroyed();
			if (!DecalComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDecalActor:DecalComp");
				return null;
			}
			return UObjectMarshaler<UDecalComponent>.FromNative(IntPtr.Add(base.Address, DecalComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DecalComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDecalActor:DecalComp");
			}
			else
			{
				UObjectMarshaler<UDecalComponent>.ToNative(IntPtr.Add(base.Address, DecalComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDecalActor:DecalConfigComp")]
	public BUS_DecalConfigComp DecalConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!DecalConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDecalActor:DecalConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_DecalConfigComp>.FromNative(IntPtr.Add(base.Address, DecalConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DecalConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDecalActor:DecalConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_DecalConfigComp>.ToNative(IntPtr.Add(base.Address, DecalConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		RootComp = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.RootComp);
		SetRootComponentCS(RootComp);
		DecalComp = initializer.CreateDefaultSubobject<UDecalComponent>(this, B1GlobalFNames.Decal);
		DecalComp.AttachToComponent(RootComp, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		DecalComp.SetRelativeRotation(new FRotator(0.0, -90.0, 0.0), bSweep: true, out var _, bTeleport: true);
		DecalConfigComp = initializer.CreateDefaultSubobject<BUS_DecalConfigComp>(this, B1GlobalFNames.DecalConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_DecalMatComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_DecalDataComp>(this, B1GlobalFNames.DecalDataComp);
	}

	public UDecalComponent GetDecal()
	{
		return DecalComp;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUDecalActor");
		RootComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RootComp");
		RootComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RootComp", Classes.FObjectProperty);
		DecalComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DecalComp");
		DecalComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DecalComp", Classes.FObjectProperty);
		DecalConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DecalConfigComp");
		DecalConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DecalConfigComp", Classes.FObjectProperty);
	}

	static BGUDecalActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDecalActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDecalActor));
	}
}
