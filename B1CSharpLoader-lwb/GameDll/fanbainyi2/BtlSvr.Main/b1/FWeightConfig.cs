using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.WeightConfig")]
internal struct FWeightConfig
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("权重值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.WeightConfig:Weight")]
	public int Weight;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("备注")]
	[USharpPath("/Script/b1-Managed.WeightConfig:Comment")]
	public FName Comment;

	[DisplayName("概率值")]
	[BlueprintReadWrite]
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.WeightConfig:RandomValue")]
	public float RandomValue;

	private static int WeightConfig_StructSize;

	public b1.FWeightConfig Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.WeightConfig");
		WeightConfig_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(b1.FWeightConfig));
	}

	static FWeightConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.FWeightConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.FWeightConfig));
	}
}
