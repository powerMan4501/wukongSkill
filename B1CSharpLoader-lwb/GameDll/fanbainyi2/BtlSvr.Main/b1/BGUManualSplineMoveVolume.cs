using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUManualSplineMoveVolume")]
public class BGUManualSplineMoveVolume : BGUActorBaseCS
{
	private static bool ManualSplineMoveVolumeComp_IsValid;

	private static int ManualSplineMoveVolumeComp_Offset;

	private static bool BoxCollisionComponent_IsValid;

	private static int BoxCollisionComponent_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUManualSplineMoveVolume:ManualSplineMoveVolumeComp")]
	public BUS_ManualSplineMoveVolumeComp ManualSplineMoveVolumeComp
	{
		get
		{
			CheckDestroyed();
			if (!ManualSplineMoveVolumeComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUManualSplineMoveVolume:ManualSplineMoveVolumeComp");
				return null;
			}
			return UObjectMarshaler<BUS_ManualSplineMoveVolumeComp>.FromNative(IntPtr.Add(base.Address, ManualSplineMoveVolumeComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ManualSplineMoveVolumeComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUManualSplineMoveVolume:ManualSplineMoveVolumeComp");
			}
			else
			{
				UObjectMarshaler<BUS_ManualSplineMoveVolumeComp>.ToNative(IntPtr.Add(base.Address, ManualSplineMoveVolumeComp_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUManualSplineMoveVolume:BoxCollisionComponent")]
	protected UBoxComponent BoxCollisionComponent
	{
		get
		{
			CheckDestroyed();
			if (!BoxCollisionComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUManualSplineMoveVolume:BoxCollisionComponent");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, BoxCollisionComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoxCollisionComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUManualSplineMoveVolume:BoxCollisionComponent");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, BoxCollisionComponent_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ManualSplineMoveVolumeComp = initializer.CreateDefaultSubobject<BUS_ManualSplineMoveVolumeComp>(this, B1GlobalFNames.ManualSplineMoveVolumeComp);
		BoxCollisionComponent = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.BoxComp);
		SetRootComponentCS(BoxCollisionComponent);
		BoxCollisionComponent.SetCollisionProfileName(B1GlobalFNames.ManualSplineMoveOverlapVolume);
		base.Tags.Add(B1GlobalFNames.ManualSplineMoveOverlapVolume);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_ManualSplineMoveVolumeDataComp>(this, B1GlobalFNames.ManualSplineMoveVolumeDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUManualSplineMoveVolume");
		ManualSplineMoveVolumeComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ManualSplineMoveVolumeComp");
		ManualSplineMoveVolumeComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ManualSplineMoveVolumeComp", Classes.FObjectProperty);
		BoxCollisionComponent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoxCollisionComponent");
		BoxCollisionComponent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoxCollisionComponent", Classes.FObjectProperty);
	}

	static BGUManualSplineMoveVolume()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUManualSplineMoveVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUManualSplineMoveVolume));
	}
}
