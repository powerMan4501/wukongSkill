using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint")]
public class BGUNeutralFXAnimalSpawnPoint : BGUActorBaseCS
{
	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool ConfigComp_IsValid;

	private static int ConfigComp_Offset;

	private static bool TriggerBox_IsValid;

	private static int TriggerBox_Offset;

	private static bool TriggerBox_OutSide_IsValid;

	private static int TriggerBox_OutSide_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:Root")]
	public USceneComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:Root");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:Root");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:ConfigComp")]
	public BUS_NeutralFXAnimalSpawnConfigComp ConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:ConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_NeutralFXAnimalSpawnConfigComp>.FromNative(IntPtr.Add(base.Address, ConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:ConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_NeutralFXAnimalSpawnConfigComp>.ToNative(IntPtr.Add(base.Address, ConfigComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:TriggerBox")]
	public UBoxComponent TriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:TriggerBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, TriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:TriggerBox");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, TriggerBox_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:TriggerBox_OutSide")]
	public UBoxComponent TriggerBox_OutSide
	{
		get
		{
			CheckDestroyed();
			if (!TriggerBox_OutSide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:TriggerBox_OutSide");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, TriggerBox_OutSide_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerBox_OutSide_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint:TriggerBox_OutSide");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, TriggerBox_OutSide_Offset), value);
			}
		}
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_NeutralFXAnimalSpawnPointDataComp>(this, B1GlobalFNames.NeutralFXAnimalSpawnPointDataComp);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Root = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Root);
		SetRootComponentCS(Root);
		ConfigComp = initializer.CreateDefaultSubobject<BUS_NeutralFXAnimalSpawnConfigComp>(this, B1GlobalFNames.ModularMgrConfigComp);
		TriggerBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.TriggerBox);
		TriggerBox.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		TriggerBox.SetCollisionProfileName(B1GlobalFNames.Trigger);
		TriggerBox.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
		TriggerBox_OutSide = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.TriggerBox_OutSide);
		TriggerBox_OutSide.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		TriggerBox_OutSide.SetCollisionProfileName(B1GlobalFNames.Trigger);
		TriggerBox_OutSide.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<b1.BUS_NeutralFXAnimalSpawnLogicComp>();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUNeutralFXAnimalSpawnPoint");
		Root_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Root", Classes.FObjectProperty);
		ConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ConfigComp");
		ConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ConfigComp", Classes.FObjectProperty);
		TriggerBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerBox");
		TriggerBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerBox", Classes.FObjectProperty);
		TriggerBox_OutSide_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerBox_OutSide");
		TriggerBox_OutSide_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerBox_OutSide", Classes.FObjectProperty);
	}

	static BGUNeutralFXAnimalSpawnPoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUNeutralFXAnimalSpawnPoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUNeutralFXAnimalSpawnPoint));
	}
}
