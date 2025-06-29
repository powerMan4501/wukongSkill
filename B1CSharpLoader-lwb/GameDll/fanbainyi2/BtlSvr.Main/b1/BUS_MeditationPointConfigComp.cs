using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_MeditationPointConfigComp")]
public class BUS_MeditationPointConfigComp : UActorEditCompBase
{
	private static bool MeditationPointConfig_IsValid;

	private static int MeditationPointConfig_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("MeditationPointConfig")]
	[USharpPath("/Script/b1-Managed.BUS_MeditationPointConfigComp:MeditationPointConfig")]
	public FMeditationPointConfig MeditationPointConfig
	{
		get
		{
			CheckDestroyed();
			if (!MeditationPointConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MeditationPointConfigComp:MeditationPointConfig");
				return default(FMeditationPointConfig);
			}
			return BlittableTypeMarshaler<FMeditationPointConfig>.FromNative(IntPtr.Add(base.Address, MeditationPointConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MeditationPointConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_MeditationPointConfigComp:MeditationPointConfig");
			}
			else
			{
				BlittableTypeMarshaler<FMeditationPointConfig>.ToNative(IntPtr.Add(base.Address, MeditationPointConfig_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<BUC_MeditationPointData>().MeditationPointConfigID = MeditationPointConfig.MeditationPointID;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_MeditationPointConfigComp");
		MeditationPointConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MeditationPointConfig");
		MeditationPointConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MeditationPointConfig", Classes.FStructProperty);
	}

	static BUS_MeditationPointConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_MeditationPointConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_MeditationPointConfigComp));
	}
}
