using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TreeImposter_OverrideMatScalarParam")]
public struct TreeImposter_OverrideMatScalarParam
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideMatScalarParam:ParamName")]
	public FName ParamName;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideMatScalarParam:Value")]
	public float Value;

	private static int TreeImposter_OverrideMatScalarParam_StructSize;

	public TreeImposter_OverrideMatScalarParam Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.TreeImposter_OverrideMatScalarParam");
		TreeImposter_OverrideMatScalarParam_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(TreeImposter_OverrideMatScalarParam));
	}

	static TreeImposter_OverrideMatScalarParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TreeImposter_OverrideMatScalarParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TreeImposter_OverrideMatScalarParam));
	}
}
