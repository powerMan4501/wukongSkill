using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUActionTriggerActor")]
internal class BGUActionTriggerActor : BGUActorBaseCS
{
	private static bool ActionTriggerConfigComp_IsValid;

	private static int ActionTriggerConfigComp_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUActionTriggerActor:ActionTriggerConfigComp")]
	public b1.BUS_ActionTriggerConfigComp ActionTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!ActionTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUActionTriggerActor:ActionTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_ActionTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, ActionTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActionTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUActionTriggerActor:ActionTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_ActionTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, ActionTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ActionTriggerConfigComp = initializer.CreateDefaultSubobject<b1.BUS_ActionTriggerConfigComp>(this, B1GlobalFNames.ActionTriggerConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_ActionTriggerComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_ActionTriggerDataComp>(this, B1GlobalFNames.ActionTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUActionTriggerActor");
		ActionTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ActionTriggerConfigComp");
		ActionTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ActionTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUActionTriggerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUActionTriggerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUActionTriggerActor));
	}
}
