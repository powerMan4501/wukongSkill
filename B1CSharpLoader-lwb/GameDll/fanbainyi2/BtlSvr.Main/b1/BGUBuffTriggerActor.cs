using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUBuffTriggerActor")]
public class BGUBuffTriggerActor : BGUActorBaseCS
{
	private static bool BuffTriggerConfigComp_IsValid;

	private static int BuffTriggerConfigComp_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUBuffTriggerActor:BuffTriggerConfigComp")]
	public BUS_BuffTriggerConfigComp BuffTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!BuffTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBuffTriggerActor:BuffTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_BuffTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, BuffTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBuffTriggerActor:BuffTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_BuffTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, BuffTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		BuffTriggerConfigComp = initializer.CreateDefaultSubobject<BUS_BuffTriggerConfigComp>(this, B1GlobalFNames.BuffTriggerConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_BuffTriggerComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_BuffTriggerDataComp>(this, B1GlobalFNames.BuffTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUBuffTriggerActor");
		BuffTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffTriggerConfigComp");
		BuffTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUBuffTriggerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUBuffTriggerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUBuffTriggerActor));
	}
}
