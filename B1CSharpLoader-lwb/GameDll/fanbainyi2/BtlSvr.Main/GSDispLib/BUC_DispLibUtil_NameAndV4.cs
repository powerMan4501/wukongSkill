using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndV4")]
public struct BUC_DispLibUtil_NameAndV4
{
	[DisplayName("V4参数名")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndV4:ParamName")]
	public FName ParamName;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndV4:Value")]
	public FVector4 Value;

	private static int BUC_DispLibUtil_NameAndV4_StructSize;

	public BUC_DispLibUtil_NameAndV4 Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_NameAndV4");
		BUC_DispLibUtil_NameAndV4_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(BUC_DispLibUtil_NameAndV4));
	}

	static BUC_DispLibUtil_NameAndV4()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_NameAndV4)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_NameAndV4));
	}
}
