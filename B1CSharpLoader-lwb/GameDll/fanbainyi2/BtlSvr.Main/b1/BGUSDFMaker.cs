using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSDFMaker")]
public class BGUSDFMaker : BGUActorBaseCS
{
	private static bool RootComp_IsValid;

	private static int RootComp_Offset;

	private static bool Interact_1_IsValid;

	private static int Interact_1_Offset;

	private static bool Interact_2_IsValid;

	private static int Interact_2_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSDFMaker:RootComp")]
	public USceneComponent RootComp
	{
		get
		{
			CheckDestroyed();
			if (!RootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSDFMaker:RootComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, RootComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSDFMaker:RootComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, RootComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUSDFMaker:Interact_1")]
	protected USphereComponent Interact_1
	{
		get
		{
			CheckDestroyed();
			if (!Interact_1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSDFMaker:Interact_1");
				return null;
			}
			return UObjectMarshaler<USphereComponent>.FromNative(IntPtr.Add(base.Address, Interact_1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interact_1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSDFMaker:Interact_1");
			}
			else
			{
				UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(base.Address, Interact_1_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUSDFMaker:Interact_2")]
	protected USphereComponent Interact_2
	{
		get
		{
			CheckDestroyed();
			if (!Interact_2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSDFMaker:Interact_2");
				return null;
			}
			return UObjectMarshaler<USphereComponent>.FromNative(IntPtr.Add(base.Address, Interact_2_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interact_2_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSDFMaker:Interact_2");
			}
			else
			{
				UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(base.Address, Interact_2_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		RootComp = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.RootComp);
		SetRootComponentCS(RootComp);
		Interact_1 = initializer.CreateDefaultSubobject<USphereComponent>(this, B1GlobalFNames.Interact_1);
		Interact_1.AttachToComponent(RootComp, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		Interact_1.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		Interact_1.SetSphereRadius(50f);
		Interact_2 = initializer.CreateDefaultSubobject<USphereComponent>(this, B1GlobalFNames.Interact_2);
		Interact_2.AttachToComponent(RootComp, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		Interact_2.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		Interact_2.SetSphereRadius(50f);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_TickRateLogicSimpleComp());
		base.ActorCompContainerCS.AddComp(new BUS_SDFMakerCommComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_SDFMakerDataComp>(this, B1GlobalFNames.DataComp);
	}

	public void GetInteractWorldPosAndScaledRadius(out FVector Pos_1, out FVector Pos_2, out float ScaledRadius_1, out float ScaledRadius_2)
	{
		Pos_2 = (Pos_1 = GetActorLocation());
		ScaledRadius_1 = 0f;
		ScaledRadius_2 = 0f;
		if (!Interact_1.IsNullOrDestroyed() && !Interact_2.IsNullOrDestroyed())
		{
			Pos_1 = Interact_1.GetWorldLocation();
			ScaledRadius_1 = Interact_1.GetScaledSphereRadius();
			Pos_2 = Interact_2.GetWorldLocation();
			ScaledRadius_2 = Interact_2.GetScaledSphereRadius();
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSDFMaker");
		RootComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RootComp");
		RootComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RootComp", Classes.FObjectProperty);
		Interact_1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Interact_1");
		Interact_1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Interact_1", Classes.FObjectProperty);
		Interact_2_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Interact_2");
		Interact_2_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Interact_2", Classes.FObjectProperty);
	}

	static BGUSDFMaker()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSDFMaker)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSDFMaker));
	}
}
