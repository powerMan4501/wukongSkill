using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSpiderOceanMgrActor")]
public class BGUSpiderOceanMgrActor : BGUActorBaseCS
{
	private static bool SpiderOceanMgrComp_IsValid;

	private static int SpiderOceanMgrComp_Offset;

	private static bool TriggerBox_IsValid;

	private static int TriggerBox_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSpiderOceanMgrActor:SpiderOceanMgrComp")]
	public BUS_SpiderOceanMgrComp SpiderOceanMgrComp
	{
		get
		{
			CheckDestroyed();
			if (!SpiderOceanMgrComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderOceanMgrActor:SpiderOceanMgrComp");
				return null;
			}
			return UObjectMarshaler<BUS_SpiderOceanMgrComp>.FromNative(IntPtr.Add(base.Address, SpiderOceanMgrComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpiderOceanMgrComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderOceanMgrActor:SpiderOceanMgrComp");
			}
			else
			{
				UObjectMarshaler<BUS_SpiderOceanMgrComp>.ToNative(IntPtr.Add(base.Address, SpiderOceanMgrComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSpiderOceanMgrActor:TriggerBox")]
	public UBoxComponent TriggerBox
	{
		get
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderOceanMgrActor:TriggerBox");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, TriggerBox_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerBox_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderOceanMgrActor:TriggerBox");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, TriggerBox_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SpiderOceanMgrComp = initializer.CreateDefaultSubobject<BUS_SpiderOceanMgrComp>(this, B1GlobalFNames.SpiderOceanMgrComp);
		TriggerBox = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.SpiderOceanTriggerBox);
		TriggerBox.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		TriggerBox.SetCollisionProfileName(B1GlobalFNames.DispInteractAreaVolume);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_SpiderOceanMgrCompImpl());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_SpiderOceanMgrDataComp>(this, B1GlobalFNames.SpiderOceanMgrDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSpiderOceanMgrActor");
		SpiderOceanMgrComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpiderOceanMgrComp");
		SpiderOceanMgrComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpiderOceanMgrComp", Classes.FObjectProperty);
		TriggerBox_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerBox");
		TriggerBox_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerBox", Classes.FObjectProperty);
	}

	static BGUSpiderOceanMgrActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSpiderOceanMgrActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSpiderOceanMgrActor));
	}
}
