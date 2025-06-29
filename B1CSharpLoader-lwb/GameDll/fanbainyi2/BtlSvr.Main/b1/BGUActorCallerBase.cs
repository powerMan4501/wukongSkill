using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUActorCallerBase")]
internal class BGUActorCallerBase : BGUActorBaseCS
{
	private static bool ActorCallComp_IsValid;

	private static int ActorCallComp_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUActorCallerBase:ActorCallComp")]
	public b1.BUS_ActorCallComp ActorCallComp
	{
		get
		{
			CheckDestroyed();
			if (!ActorCallComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUActorCallerBase:ActorCallComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_ActorCallComp>.FromNative(IntPtr.Add(base.Address, ActorCallComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorCallComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUActorCallerBase:ActorCallComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_ActorCallComp>.ToNative(IntPtr.Add(base.Address, ActorCallComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ActorCallComp = initializer.CreateDefaultSubobject<b1.BUS_ActorCallComp>(this, B1GlobalFNames.ActorCallSystem);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_ActorCallCompImpl());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_ActorCallerDataComp>(this, B1GlobalFNames.ActorCallerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUActorCallerBase");
		ActorCallComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ActorCallComp");
		ActorCallComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ActorCallComp", Classes.FObjectProperty);
	}

	static BGUActorCallerBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUActorCallerBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUActorCallerBase));
	}
}
