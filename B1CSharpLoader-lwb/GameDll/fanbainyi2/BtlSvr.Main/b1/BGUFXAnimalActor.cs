using System;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFXAnimalActor")]
public class BGUFXAnimalActor : BGUActorBaseCS
{
	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool NiagaraComp_IsValid;

	private static int NiagaraComp_Offset;

	private static bool TriggerBox_IsValid;

	private static int TriggerBox_Offset;

	private static bool FXAnimalConfigComp_IsValid;

	private static int FXAnimalConfigComp_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUFXAnimalActor:Root")]
	public USceneComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXAnimalActor:Root");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXAnimalActor:Root");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUFXAnimalActor:NiagaraComp")]
	public UNiagaraComponent NiagaraComp
	{
		get
		{
			CheckDestroyed();
			if (!NiagaraComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXAnimalActor:NiagaraComp");
				return null;
			}
			return UObjectMarshaler<UNiagaraComponent>.FromNative(IntPtr.Add(base.Address, NiagaraComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NiagaraComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXAnimalActor:NiagaraComp");
			}
			else
			{
				UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(base.Address, NiagaraComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUFXAnimalActor:TriggerBox")]
	public UBoxComponent TriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXAnimalActor:TriggerBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, TriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXAnimalActor:TriggerBox");
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
	[USharpPath("/Script/b1-Managed.BGUFXAnimalActor:FXAnimalConfigComp")]
	public BUS_FXAnimalEditComp FXAnimalConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!FXAnimalConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXAnimalActor:FXAnimalConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_FXAnimalEditComp>.FromNative(IntPtr.Add(base.Address, FXAnimalConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FXAnimalConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFXAnimalActor:FXAnimalConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_FXAnimalEditComp>.ToNative(IntPtr.Add(base.Address, FXAnimalConfigComp_Offset), value);
			}
		}
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_FXAnimalDataComp>(this, B1GlobalFNames.FXDataComp);
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Root = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Root);
		SetRootComponentCS(Root);
		FXAnimalConfigComp = initializer.CreateDefaultSubobject<BUS_FXAnimalEditComp>(this, B1GlobalFNames.FXAnimalConfigComp);
		NiagaraComp = initializer.CreateDefaultSubobject<UNiagaraComponent>(this, B1GlobalFNames.NiagaraComp);
		NiagaraComp.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		TriggerBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.TriggerBox);
		TriggerBox.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		TriggerBox.SetCollisionProfileName(B1GlobalFNames.Trigger);
		TriggerBox.SetGenerateOverlapEvents(bInGenerateOverlapEvents: false);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<BUS_FXAnimalCommComp>();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUFXAnimalActor");
		Root_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Root", Classes.FObjectProperty);
		NiagaraComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NiagaraComp");
		NiagaraComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NiagaraComp", Classes.FObjectProperty);
		TriggerBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerBox");
		TriggerBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerBox", Classes.FObjectProperty);
		FXAnimalConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FXAnimalConfigComp");
		FXAnimalConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FXAnimalConfigComp", Classes.FObjectProperty);
	}

	static BGUFXAnimalActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFXAnimalActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFXAnimalActor));
	}
}
