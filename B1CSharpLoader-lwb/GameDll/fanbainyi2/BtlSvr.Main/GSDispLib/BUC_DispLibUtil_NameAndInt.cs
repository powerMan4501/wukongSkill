using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt")]
public struct BUC_DispLibUtil_NameAndInt
{
	[DisplayName("Int参数名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt:ParamName")]
	public FName ParamName;

	[BlueprintReadWrite]
	[DisplayName("值")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt:Value")]
	public int Value;

	private static int BUC_DispLibUtil_NameAndInt_StructSize;

	public BUC_DispLibUtil_NameAndInt Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_NameAndInt");
		BUC_DispLibUtil_NameAndInt_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(BUC_DispLibUtil_NameAndInt));
	}

	static BUC_DispLibUtil_NameAndInt()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_NameAndInt)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_NameAndInt));
	}
}
