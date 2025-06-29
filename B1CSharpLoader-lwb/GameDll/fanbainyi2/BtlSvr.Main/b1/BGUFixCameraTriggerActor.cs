using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFixCameraTriggerActor")]
internal class BGUFixCameraTriggerActor : BGUActorBaseCS
{
	private static bool FixCameraTriggerConfigComp_IsValid;

	private static int FixCameraTriggerConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUFixCameraTriggerActor:FixCameraTriggerConfigComp")]
	public b1.BUS_FixCameraTriggerConfigComp FixCameraTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!FixCameraTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFixCameraTriggerActor:FixCameraTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_FixCameraTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, FixCameraTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FixCameraTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUFixCameraTriggerActor:FixCameraTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_FixCameraTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, FixCameraTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		FixCameraTriggerConfigComp = initializer.CreateDefaultSubobject<b1.BUS_FixCameraTriggerConfigComp>(this, B1GlobalFNames.FixCameraTriggerConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_FixCameraTriggerCompImpl());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_FixCameraTriggerDataComp>(this, B1GlobalFNames.FixCameraTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUFixCameraTriggerActor");
		FixCameraTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FixCameraTriggerConfigComp");
		FixCameraTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FixCameraTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUFixCameraTriggerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUFixCameraTriggerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUFixCameraTriggerActor));
	}
}
