using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndScalar")]
public struct BUC_DispLibUtil_NameAndScalar
{
	[BlueprintReadWrite]
	[DisplayName("Scalar参数名")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndScalar:ParamName")]
	public FName ParamName;

	[DisplayName("值")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndScalar:Value")]
	public float Value;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("时间阶段")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUtil_NameAndScalar:TimeStage")]
	public FVector TimeStage;

	private static int BUC_DispLibUtil_NameAndScalar_StructSize;

	public BUC_DispLibUtil_NameAndScalar Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibUtil_NameAndScalar");
		BUC_DispLibUtil_NameAndScalar_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(BUC_DispLibUtil_NameAndScalar));
	}

	static BUC_DispLibUtil_NameAndScalar()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUtil_NameAndScalar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUtil_NameAndScalar));
	}
}
