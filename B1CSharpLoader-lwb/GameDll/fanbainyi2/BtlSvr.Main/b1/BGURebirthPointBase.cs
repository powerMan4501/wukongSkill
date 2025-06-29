using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGURebirthPointBase")]
public class BGURebirthPointBase : BGUInteractiveActorBase
{
	private static bool RebirthPointConfigComp_IsValid;

	private static int RebirthPointConfigComp_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGURebirthPointBase:RebirthPointConfigComp")]
	public BUS_RebirthPointConfigComp RebirthPointConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!RebirthPointConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGURebirthPointBase:RebirthPointConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_RebirthPointConfigComp>.FromNative(IntPtr.Add(base.Address, RebirthPointConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RebirthPointConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGURebirthPointBase:RebirthPointConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_RebirthPointConfigComp>.ToNative(IntPtr.Add(base.Address, RebirthPointConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		RebirthPointConfigComp = initializer.CreateDefaultSubobject<BUS_RebirthPointConfigComp>(this, B1GlobalFNames.RebirthPointConfigSystem);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_RebirthPointCompImpl());
		base.ActorCompContainerCS.AddComp(new b1.BUS_RebirthPointInteractComp());
		base.ActorCompContainerCS.AddComp(new b1.BUS_PersistentLevelCheckComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_RebirthPointDataComp>(this, B1GlobalFNames.RebirthPointDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGURebirthPointBase");
		RebirthPointConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthPointConfigComp");
		RebirthPointConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthPointConfigComp", Classes.FObjectProperty);
	}

	static BGURebirthPointBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGURebirthPointBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGURebirthPointBase));
	}
}
