using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MeditationPointConfig")]
public struct FMeditationPointConfig
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MeditationPointConfig:MeditationPointID")]
	public int MeditationPointID;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MeditationPointConfig:TargetCheckRange")]
	public int TargetCheckRange;

	private static int MeditationPointConfig_StructSize;

	public FMeditationPointConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.MeditationPointConfig");
		MeditationPointConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FMeditationPointConfig));
	}

	static FMeditationPointConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMeditationPointConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeditationPointConfig));
	}
}
