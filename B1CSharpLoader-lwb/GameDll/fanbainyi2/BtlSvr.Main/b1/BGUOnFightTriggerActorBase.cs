using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUOnFightTriggerActorBase")]
public class BGUOnFightTriggerActorBase : BGUActorBaseCS
{
	private static bool OnFightTriggerConfigComp_IsValid;

	private static int OnFightTriggerConfigComp_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUOnFightTriggerActorBase:OnFightTriggerConfigComp")]
	public BUS_OnFightTriggerConfigComp OnFightTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!OnFightTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUOnFightTriggerActorBase:OnFightTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_OnFightTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, OnFightTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnFightTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUOnFightTriggerActorBase:OnFightTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_OnFightTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, OnFightTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		OnFightTriggerConfigComp = initializer.CreateDefaultSubobject<BUS_OnFightTriggerConfigComp>(this, B1GlobalFNames.OnFightTriggerConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_OnFightTriggerComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_OnFightTriggerDataComp>(this, B1GlobalFNames.OnFightTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUOnFightTriggerActorBase");
		OnFightTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OnFightTriggerConfigComp");
		OnFightTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OnFightTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUOnFightTriggerActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUOnFightTriggerActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUOnFightTriggerActorBase));
	}
}
