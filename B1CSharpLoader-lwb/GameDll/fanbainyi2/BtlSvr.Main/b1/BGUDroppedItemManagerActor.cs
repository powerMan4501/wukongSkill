using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUDroppedItemManagerActor")]
internal class BGUDroppedItemManagerActor : BGUActorBaseCS
{
	private static bool DroppedItemManagerConfigComp_IsValid;

	private static int DroppedItemManagerConfigComp_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDroppedItemManagerActor:DroppedItemManagerConfigComp")]
	public b1.BUS_DroppedItemManagerConfigComp DroppedItemManagerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!DroppedItemManagerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDroppedItemManagerActor:DroppedItemManagerConfigComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_DroppedItemManagerConfigComp>.FromNative(IntPtr.Add(base.Address, DroppedItemManagerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DroppedItemManagerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDroppedItemManagerActor:DroppedItemManagerConfigComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_DroppedItemManagerConfigComp>.ToNative(IntPtr.Add(base.Address, DroppedItemManagerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		DroppedItemManagerConfigComp = initializer.CreateDefaultSubobject<b1.BUS_DroppedItemManagerConfigComp>(this, B1GlobalFNames.DroppedItemManagerConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_DroppedItemManagerComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_DroppedItemManagerDataComp>(this, B1GlobalFNames.DroppedItemManagerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUDroppedItemManagerActor");
		DroppedItemManagerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DroppedItemManagerConfigComp");
		DroppedItemManagerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DroppedItemManagerConfigComp", Classes.FObjectProperty);
	}

	static BGUDroppedItemManagerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUDroppedItemManagerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUDroppedItemManagerActor));
	}
}
