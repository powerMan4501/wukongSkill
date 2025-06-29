using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSelectAreaActor")]
public class BGUSelectAreaActor : BGUActorBaseCS
{
	private static bool BoxArea_IsValid;

	private static int BoxArea_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSelectAreaActor:BoxArea")]
	protected UBoxComponent BoxArea
	{
		get
		{
			CheckDestroyed();
			if (!BoxArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSelectAreaActor:BoxArea");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, BoxArea_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoxArea_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSelectAreaActor:BoxArea");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, BoxArea_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		BoxArea = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.BoxArea);
		BoxArea.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_SelectAreaDataComp>(this, B1GlobalFNames.SelectAreaDataComp);
	}

	public UBoxComponent GetBoxComp()
	{
		return BoxArea;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSelectAreaActor");
		BoxArea_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoxArea");
		BoxArea_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoxArea", Classes.FObjectProperty);
	}

	static BGUSelectAreaActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSelectAreaActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSelectAreaActor));
	}
}
