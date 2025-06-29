using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor")]
public class BGUEnvironmentItemStateMachineActor : BGUEnvironmentItemStateMachineActorBase
{
	private static bool EnvironmentItemStateMachineComp_IsValid;

	private static int EnvironmentItemStateMachineComp_Offset;

	private static bool TriggerBox_IsValid;

	private static int TriggerBox_Offset;

	private static bool ExtAbilityMask_IsValid;

	private static int ExtAbilityMask_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor:EnvironmentItemStateMachineComp")]
	public BUS_EnvironmentItemStateMachineComp EnvironmentItemStateMachineComp
	{
		get
		{
			CheckDestroyed();
			if (!EnvironmentItemStateMachineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor:EnvironmentItemStateMachineComp");
				return null;
			}
			return UObjectMarshaler<BUS_EnvironmentItemStateMachineComp>.FromNative(IntPtr.Add(base.Address, EnvironmentItemStateMachineComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EnvironmentItemStateMachineComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor:EnvironmentItemStateMachineComp");
			}
			else
			{
				UObjectMarshaler<BUS_EnvironmentItemStateMachineComp>.ToNative(IntPtr.Add(base.Address, EnvironmentItemStateMachineComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor:TriggerBox")]
	public UBoxComponent TriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor:TriggerBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, TriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor:TriggerBox");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, TriggerBox_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("额外附加的功能开关")]
	[USharpPath("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor:ExtAbilityMask")]
	public FEnvironmentItemStateMachineExtAbilityMask ExtAbilityMask
	{
		get
		{
			CheckDestroyed();
			if (!ExtAbilityMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor:ExtAbilityMask");
				return default(FEnvironmentItemStateMachineExtAbilityMask);
			}
			return BlittableTypeMarshaler<FEnvironmentItemStateMachineExtAbilityMask>.FromNative(IntPtr.Add(base.Address, ExtAbilityMask_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtAbilityMask_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor:ExtAbilityMask");
			}
			else
			{
				BlittableTypeMarshaler<FEnvironmentItemStateMachineExtAbilityMask>.ToNative(IntPtr.Add(base.Address, ExtAbilityMask_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.PrimaryActorTick.SetCanEverTick(canEverTick: true);
		EnvironmentItemStateMachineComp = initializer.CreateDefaultSubobject<BUS_EnvironmentItemStateMachineComp>(this, B1GlobalFNames.EnvironmentItemStateMachineComp);
		TriggerBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.EnvironmentItemStateMachineTriggerBox);
		TriggerBox.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		TriggerBox.SetCollisionProfileName(B1GlobalFNames.DispInteractAreaVolume);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_EnvironmentItemStateMachineCompImpl());
		RegisterCompUObjByMask<b1.BUS_AKMgrComp>(EEnvironmentItemStateMachineAbilityType.PlayDialogue);
		RegisterCompUObjByMask<b1.BUS_UIControlSystemV2>(EEnvironmentItemStateMachineAbilityType.PlayDialogue);
	}

	public T RegisterCompByMask<T>(EEnvironmentItemStateMachineAbilityType AbilityType = EEnvironmentItemStateMachineAbilityType.Default) where T : UActorCompBaseCS, new()
	{
		if (AbilityType == EEnvironmentItemStateMachineAbilityType.Default || ((uint)AbilityType & (uint)ExtAbilityMask.Mask) != 0)
		{
			T newComp = new T();
			return base.ActorCompContainerCS.AddComp(newComp);
		}
		return null;
	}

	public T RegisterCompUObjByMask<T>(EEnvironmentItemStateMachineAbilityType AbilityType = EEnvironmentItemStateMachineAbilityType.Default) where T : UActorCompBaseUObj
	{
		if (AbilityType == EEnvironmentItemStateMachineAbilityType.Default || ((uint)AbilityType & (uint)ExtAbilityMask.Mask) != 0)
		{
			return base.ActorCompContainerCS.AddCompUObj<T>();
		}
		return null;
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_EnvironmentItemStateMachineDataComp>(this, B1GlobalFNames.EnvironmentItemStateMachineDataComp);
	}

	protected T CreateDataClass<T>(BGW_ECSWorld ECSWorld) where T : class, new()
	{
		T val = new T();
		ECSWorld?.SetObject(base.ECSEntity, val);
		return val;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUEnvironmentItemStateMachineActor");
		EnvironmentItemStateMachineComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnvironmentItemStateMachineComp");
		EnvironmentItemStateMachineComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnvironmentItemStateMachineComp", Classes.FObjectProperty);
		TriggerBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerBox");
		TriggerBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerBox", Classes.FObjectProperty);
		ExtAbilityMask_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ExtAbilityMask");
		ExtAbilityMask_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ExtAbilityMask", Classes.FStructProperty);
	}

	static BGUEnvironmentItemStateMachineActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUEnvironmentItemStateMachineActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUEnvironmentItemStateMachineActor));
	}
}
