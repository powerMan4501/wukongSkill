using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor")]
public class BGUSplineFlyMoveTriggerActor : BGUActorBaseCS
{
	private static bool TriggerBox_IsValid;

	private static int TriggerBox_Offset;

	private static bool EndTriggerBox_IsValid;

	private static int EndTriggerBox_Offset;

	private static bool SplineFlyMoveTriggerConfigComp_IsValid;

	private static int SplineFlyMoveTriggerConfigComp_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor:TriggerBox")]
	public UBoxComponent TriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor:TriggerBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, TriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor:TriggerBox");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, TriggerBox_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor:EndTriggerBox")]
	public UBoxComponent EndTriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!EndTriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor:EndTriggerBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, EndTriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EndTriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor:EndTriggerBox");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, EndTriggerBox_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor:SplineFlyMoveTriggerConfigComp")]
	public BUS_SplineFlyMoveTriggerConfigComp SplineFlyMoveTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!SplineFlyMoveTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor:SplineFlyMoveTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_SplineFlyMoveTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, SplineFlyMoveTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SplineFlyMoveTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor:SplineFlyMoveTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_SplineFlyMoveTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, SplineFlyMoveTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		TriggerBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.BeginBox);
		EndTriggerBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.EndBox);
		SplineFlyMoveTriggerConfigComp = initializer.CreateDefaultSubobject<BUS_SplineFlyMoveTriggerConfigComp>(this, B1GlobalFNames.SplineFlyMoveTriggerConfigComp);
		TriggerBox.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		EndTriggerBox.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		TriggerBox.SetCollisionProfileName(B1GlobalFNames.DispInteractAreaVolume);
		EndTriggerBox.SetCollisionProfileName(B1GlobalFNames.DispInteractAreaVolume);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_SplineFlyMoveTriggerComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_SplineFlyMoveTriggerDataComp>(this, B1GlobalFNames.SplineFlyMoveTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSplineFlyMoveTriggerActor");
		TriggerBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerBox");
		TriggerBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerBox", Classes.FObjectProperty);
		EndTriggerBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EndTriggerBox");
		EndTriggerBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EndTriggerBox", Classes.FObjectProperty);
		SplineFlyMoveTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SplineFlyMoveTriggerConfigComp");
		SplineFlyMoveTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SplineFlyMoveTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUSplineFlyMoveTriggerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSplineFlyMoveTriggerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSplineFlyMoveTriggerActor));
	}
}
