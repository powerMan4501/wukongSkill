using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTriggerProcessControllerBase")]
internal class BGUTriggerProcessControllerBase : BGUActorBaseCS
{
	private static bool TriggerProcessControlComp_IsValid;

	private static int TriggerProcessControlComp_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUTriggerProcessControllerBase:TriggerProcessControlComp")]
	private b1.BUS_TriggerProcessControlComp TriggerProcessControlComp
	{
		get
		{
			CheckDestroyed();
			if (!TriggerProcessControlComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTriggerProcessControllerBase:TriggerProcessControlComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_TriggerProcessControlComp>.FromNative(IntPtr.Add(base.Address, TriggerProcessControlComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TriggerProcessControlComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTriggerProcessControllerBase:TriggerProcessControlComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_TriggerProcessControlComp>.ToNative(IntPtr.Add(base.Address, TriggerProcessControlComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		TriggerProcessControlComp = initializer.CreateDefaultSubobject<b1.BUS_TriggerProcessControlComp>(this, B1GlobalFNames.TriggerProcessControlSystem);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_TriggerProcessControlCompImpl());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_TriggerProcessControllerDataComp>(this, B1GlobalFNames.TriggerProcessControllerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUTriggerProcessControllerBase");
		TriggerProcessControlComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TriggerProcessControlComp");
		TriggerProcessControlComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TriggerProcessControlComp", Classes.FObjectProperty);
	}

	static BGUTriggerProcessControllerBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUTriggerProcessControllerBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUTriggerProcessControllerBase));
	}
}
