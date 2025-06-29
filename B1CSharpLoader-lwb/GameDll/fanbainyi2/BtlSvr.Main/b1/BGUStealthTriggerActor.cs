using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUStealthTriggerActor")]
internal class BGUStealthTriggerActor : BGUActorBaseCS
{
	private static bool StealthTriggerConfigComp_IsValid;

	private static int StealthTriggerConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUStealthTriggerActor:StealthTriggerConfigComp")]
	public b1.BUS_StealthTriggerConfigComp StealthTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!StealthTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUStealthTriggerActor:StealthTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_StealthTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, StealthTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StealthTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUStealthTriggerActor:StealthTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_StealthTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, StealthTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		StealthTriggerConfigComp = initializer.CreateDefaultSubobject<b1.BUS_StealthTriggerConfigComp>(this, B1GlobalFNames.StealthTriggerConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_StealthTriggerComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_StealthTriggerDataComp>(this, B1GlobalFNames.StealthTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUStealthTriggerActor");
		StealthTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StealthTriggerConfigComp");
		StealthTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StealthTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUStealthTriggerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUStealthTriggerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUStealthTriggerActor));
	}
}
