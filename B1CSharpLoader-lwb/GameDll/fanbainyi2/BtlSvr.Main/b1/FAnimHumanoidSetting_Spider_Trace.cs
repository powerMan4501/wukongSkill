using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace")]
public struct FAnimHumanoidSetting_Spider_Trace
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace:traceHeadDistance")]
	public float traceHeadDistance;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace:traceHalfHeight")]
	public float traceHalfHeight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace:traceHalfWidth")]
	public float traceHalfWidth;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace:traceGridHeight")]
	public float traceGridHeight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace:traceGridWidth")]
	public float traceGridWidth;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace:maxTraceNumber")]
	public int maxTraceNumber;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace:verticalDivisionNumber")]
	public int verticalDivisionNumber;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace:horizontalDivisionNumber")]
	public int horizontalDivisionNumber;

	[UProperty]
	[BlueprintReadOnly]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace:IKTraceDistance")]
	public float IKTraceDistance;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace:maxLegIkOffset")]
	public float maxLegIkOffset;

	private static int AnimHumanoidSetting_Spider_Trace_StructSize;

	public FAnimHumanoidSetting_Spider_Trace Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.AnimHumanoidSetting_Spider_Trace");
		AnimHumanoidSetting_Spider_Trace_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FAnimHumanoidSetting_Spider_Trace));
	}

	static FAnimHumanoidSetting_Spider_Trace()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAnimHumanoidSetting_Spider_Trace)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimHumanoidSetting_Spider_Trace));
	}
}
