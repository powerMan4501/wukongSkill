using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUBattleTriggerActor")]
public class BGUBattleTriggerActor : BGUActorBaseCS
{
	private static bool BattleTriggerConfigComp_IsValid;

	private static int BattleTriggerConfigComp_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUBattleTriggerActor:BattleTriggerConfigComp")]
	public BUS_BattleTriggerConfigComp BattleTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!BattleTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBattleTriggerActor:BattleTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_BattleTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, BattleTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BattleTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBattleTriggerActor:BattleTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_BattleTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, BattleTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		BattleTriggerConfigComp = initializer.CreateDefaultSubobject<BUS_BattleTriggerConfigComp>(this, B1GlobalFNames.BattleTriggerConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_BattleTriggerComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_BattleTriggerDataComp>(this, B1GlobalFNames.BattleTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUBattleTriggerActor");
		BattleTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BattleTriggerConfigComp");
		BattleTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BattleTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUBattleTriggerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUBattleTriggerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUBattleTriggerActor));
	}
}
