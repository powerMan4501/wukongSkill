using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.TreeImposter_OverrideMatLinearColorParam")]
public struct TreeImposter_OverrideMatLinearColorParam
{
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideMatLinearColorParam:ParamName")]
	public FName ParamName;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TreeImposter_OverrideMatLinearColorParam:Value")]
	public FLinearColor Value;

	private static int TreeImposter_OverrideMatLinearColorParam_StructSize;

	public TreeImposter_OverrideMatLinearColorParam Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.TreeImposter_OverrideMatLinearColorParam");
		TreeImposter_OverrideMatLinearColorParam_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(TreeImposter_OverrideMatLinearColorParam));
	}

	static TreeImposter_OverrideMatLinearColorParam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(TreeImposter_OverrideMatLinearColorParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(TreeImposter_OverrideMatLinearColorParam));
	}
}
