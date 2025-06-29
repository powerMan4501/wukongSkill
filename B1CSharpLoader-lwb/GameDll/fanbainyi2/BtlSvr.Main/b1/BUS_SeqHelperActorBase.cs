using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorBase")]
public class BUS_SeqHelperActorBase : BGUActorBaseCS
{
	private static bool SeqHelperActorComp_IsValid;

	private static int SeqHelperActorComp_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_SeqHelperActorBase:SeqHelperActorComp")]
	public BUS_SeqHelperActorComp SeqHelperActorComp
	{
		get
		{
			CheckDestroyed();
			if (!SeqHelperActorComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SeqHelperActorBase:SeqHelperActorComp");
				return null;
			}
			return UObjectMarshaler<BUS_SeqHelperActorComp>.FromNative(IntPtr.Add(base.Address, SeqHelperActorComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SeqHelperActorComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SeqHelperActorBase:SeqHelperActorComp");
			}
			else
			{
				UObjectMarshaler<BUS_SeqHelperActorComp>.ToNative(IntPtr.Add(base.Address, SeqHelperActorComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SeqHelperActorComp = initializer.CreateDefaultSubobject<BUS_SeqHelperActorComp>(this, B1GlobalFNames.SeqHelperActorComp);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_SeqHelperActorDataComp>(this, B1GlobalFNames.SeqHelperActorDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_SeqHelperActorBase");
		SeqHelperActorComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SeqHelperActorComp");
		SeqHelperActorComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SeqHelperActorComp", Classes.FObjectProperty);
	}

	static BUS_SeqHelperActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SeqHelperActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SeqHelperActorBase));
	}
}
