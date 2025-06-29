using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUNameTriggerActorBase")]
public class BGUNameTriggerActorBase : BGUActorBaseCS
{
	private static bool NameTriggerConfigComp_IsValid;

	private static int NameTriggerConfigComp_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUNameTriggerActorBase:NameTriggerConfigComp")]
	public BUS_NameTriggerConfigComp NameTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!NameTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNameTriggerActorBase:NameTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_NameTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, NameTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NameTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNameTriggerActorBase:NameTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_NameTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, NameTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		NameTriggerConfigComp = initializer.CreateDefaultSubobject<BUS_NameTriggerConfigComp>(this, B1GlobalFNames.NameTriggerConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_NameTriggerComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_NameTriggerDataComp>(this, B1GlobalFNames.NameTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUNameTriggerActorBase");
		NameTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NameTriggerConfigComp");
		NameTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NameTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUNameTriggerActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUNameTriggerActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUNameTriggerActorBase));
	}
}
