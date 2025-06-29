using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_RebirthPointInfoSaveConfigComp")]
internal class BUS_RebirthPointInfoSaveConfigComp : UActorEditCompBase
{
	private static bool RebirthPointConfigID_IsValid;

	private static int RebirthPointConfigID_Offset;

	[UProperty]
	[EditAnywhere]
	[Category("Config")]
	[USharpPath("/Script/b1-Managed.BUS_RebirthPointInfoSaveConfigComp:RebirthPointConfigID")]
	public int RebirthPointConfigID
	{
		get
		{
			CheckDestroyed();
			if (!RebirthPointConfigID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_RebirthPointInfoSaveConfigComp:RebirthPointConfigID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RebirthPointConfigID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RebirthPointConfigID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_RebirthPointInfoSaveConfigComp:RebirthPointConfigID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RebirthPointConfigID_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<b1.BUC_RebirthPointInfoSaveData>().RebirthPointConfigID = RebirthPointConfigID;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_RebirthPointInfoSaveConfigComp");
		RebirthPointConfigID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RebirthPointConfigID");
		RebirthPointConfigID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RebirthPointConfigID", Classes.FIntProperty);
	}

	static BUS_RebirthPointInfoSaveConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_RebirthPointInfoSaveConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_RebirthPointInfoSaveConfigComp));
	}
}
