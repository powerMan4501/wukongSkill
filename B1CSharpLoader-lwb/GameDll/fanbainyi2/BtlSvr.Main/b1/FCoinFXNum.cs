using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.CoinFXNum")]
public struct FCoinFXNum
{
	[BlueprintReadWrite]
	[DisplayName("下限")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.CoinFXNum:LowerLimit")]
	public int LowerLimit;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("数量")]
	[USharpPath("/Script/b1-Managed.CoinFXNum:FXNum")]
	public int FXNum;

	private static int CoinFXNum_StructSize;

	public FCoinFXNum Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.CoinFXNum");
		CoinFXNum_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FCoinFXNum));
	}

	static FCoinFXNum()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FCoinFXNum)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCoinFXNum));
	}
}
