using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDumperTruckTriggerActor")]
public class BGUDumperTruckTriggerActor : BGUActorBaseCS
{
	private static bool TriggerBox_IsValid;

	private static int TriggerBox_Offset;

	private static bool EndTriggerBox_IsValid;

	private static int EndTriggerBox_Offset;

	private static bool DumperTruckTriggerConfigComp_IsValid;

	private static int DumperTruckTriggerConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUDumperTruckTriggerActor:TriggerBox")]
	public UBoxComponent TriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDumperTruckTriggerActor:TriggerBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, TriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDumperTruckTriggerActor:TriggerBox");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, TriggerBox_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDumperTruckTriggerActor:EndTriggerBox")]
	public UBoxComponent EndTriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!EndTriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDumperTruckTriggerActor:EndTriggerBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, EndTriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndTriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDumperTruckTriggerActor:EndTriggerBox");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, EndTriggerBox_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDumperTruckTriggerActor:DumperTruckTriggerConfigComp")]
	public BUS_DumperTruckTriggerConfigComp DumperTruckTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!DumperTruckTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDumperTruckTriggerActor:DumperTruckTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_DumperTruckTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, DumperTruckTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DumperTruckTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDumperTruckTriggerActor:DumperTruckTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_DumperTruckTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, DumperTruckTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		TriggerBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.ForceOriginalFormTriggerBox);
		EndTriggerBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.EndBox);
		DumperTruckTriggerConfigComp = initializer.CreateDefaultSubobject<BUS_DumperTruckTriggerConfigComp>(this, B1GlobalFNames.DumperTruckTriggerConfigComp);
		TriggerBox.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		EndTriggerBox.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		TriggerBox.SetCollisionProfileName(B1GlobalFNames.DispInteractAreaVolume);
		EndTriggerBox.SetCollisionProfileName(B1GlobalFNames.DispInteractAreaVolume);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_DumperTruckTriggerComp());
		base.ActorCompContainerCS.AddComp(new BUS_DumperTruckOverlapComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_DumperTruckTriggerDataComp>(this, B1GlobalFNames.DumperTruckTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUDumperTruckTriggerActor");
		TriggerBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerBox");
		TriggerBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerBox", Classes.FObjectProperty);
		EndTriggerBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EndTriggerBox");
		EndTriggerBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EndTriggerBox", Classes.FObjectProperty);
		DumperTruckTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DumperTruckTriggerConfigComp");
		DumperTruckTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DumperTruckTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUDumperTruckTriggerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDumperTruckTriggerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDumperTruckTriggerActor));
	}
}
