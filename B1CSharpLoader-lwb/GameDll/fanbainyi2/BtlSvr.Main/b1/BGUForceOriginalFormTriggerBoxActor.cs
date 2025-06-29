using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUForceOriginalFormTriggerBoxActor")]
public class BGUForceOriginalFormTriggerBoxActor : BGUActorBaseCS
{
	private static bool ForceOriginalFormTriggerBox_IsValid;

	private static int ForceOriginalFormTriggerBox_Offset;

	private static bool ForceOriginalFormConfigComp_IsValid;

	private static int ForceOriginalFormConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUForceOriginalFormTriggerBoxActor:ForceOriginalFormTriggerBox")]
	public UBoxComponent ForceOriginalFormTriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!ForceOriginalFormTriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUForceOriginalFormTriggerBoxActor:ForceOriginalFormTriggerBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, ForceOriginalFormTriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceOriginalFormTriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUForceOriginalFormTriggerBoxActor:ForceOriginalFormTriggerBox");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, ForceOriginalFormTriggerBox_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUForceOriginalFormTriggerBoxActor:ForceOriginalFormConfigComp")]
	public BUS_ForceOriginalFormConfigComp ForceOriginalFormConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ForceOriginalFormConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUForceOriginalFormTriggerBoxActor:ForceOriginalFormConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_ForceOriginalFormConfigComp>.FromNative(IntPtr.Add(base.Address, ForceOriginalFormConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ForceOriginalFormConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUForceOriginalFormTriggerBoxActor:ForceOriginalFormConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_ForceOriginalFormConfigComp>.ToNative(IntPtr.Add(base.Address, ForceOriginalFormConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ForceOriginalFormTriggerBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.ForceOriginalFormTriggerBox);
		ForceOriginalFormConfigComp = initializer.CreateDefaultSubobject<BUS_ForceOriginalFormConfigComp>(this, B1GlobalFNames.ForceOriginalFormConfigComp);
		ForceOriginalFormTriggerBox.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		ForceOriginalFormTriggerBox.SetCollisionProfileName(B1GlobalFNames.DispInteractAreaVolume);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_ForceOriginalFormComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ForceOriginalFormDataComp>(this, B1GlobalFNames.ForceOriginalFormDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUForceOriginalFormTriggerBoxActor");
		ForceOriginalFormTriggerBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForceOriginalFormTriggerBox");
		ForceOriginalFormTriggerBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForceOriginalFormTriggerBox", Classes.FObjectProperty);
		ForceOriginalFormConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ForceOriginalFormConfigComp");
		ForceOriginalFormConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ForceOriginalFormConfigComp", Classes.FObjectProperty);
	}

	static BGUForceOriginalFormTriggerBoxActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUForceOriginalFormTriggerBoxActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUForceOriginalFormTriggerBoxActor));
	}
}
