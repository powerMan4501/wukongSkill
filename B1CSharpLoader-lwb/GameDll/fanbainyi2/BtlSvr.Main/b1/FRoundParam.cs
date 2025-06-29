using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.RoundParam")]
public struct FRoundParam
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.RoundParam:Radius")]
	public float Radius;

	private static int RoundParam_StructSize;

	public FRoundParam Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.RoundParam");
		RoundParam_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FRoundParam));
	}

	static FRoundParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FRoundParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRoundParam));
	}
}
