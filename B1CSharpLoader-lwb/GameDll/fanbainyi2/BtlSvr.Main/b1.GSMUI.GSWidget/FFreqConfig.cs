using System;
using UnrealEngine.Runtime;

namespace b1.GSMUI.GSWidget;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FreqConfig")]
public struct FFreqConfig
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FreqConfig:Percent")]
	public float Percent;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FreqConfig:Freq")]
	public float Freq;

	private static int FreqConfig_StructSize;

	public FFreqConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.FreqConfig");
		FreqConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FFreqConfig));
	}

	static FFreqConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FFreqConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFreqConfig));
	}
}
