using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColor")]
public struct BUC_DispLibUtil_NameAndLColor
{
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("LColor参数名")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColor:ParamName")]
	public FName ParamName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("值")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColor:Value")]
	public FLinearColor Value;

	private static int BUC_DispLibUtil_NameAndLColor_StructSize;

	public BUC_DispLibUtil_NameAndLColor Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_NameAndLColor");
		BUC_DispLibUtil_NameAndLColor_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(BUC_DispLibUtil_NameAndLColor));
	}

	static BUC_DispLibUtil_NameAndLColor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_NameAndLColor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_NameAndLColor));
	}
}
