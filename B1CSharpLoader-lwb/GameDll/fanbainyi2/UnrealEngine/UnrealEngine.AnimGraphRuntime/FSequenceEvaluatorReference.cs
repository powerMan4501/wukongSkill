using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.SequenceEvaluatorReference", "AnimGraphRuntime", UnrealModuleType.Engine)]
public class FSequenceEvaluatorReference : StructAsClass
{
	private static bool FSequenceEvaluatorReference_IsValid;

	private static IntPtr FSequenceEvaluatorReference_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FSequenceEvaluatorReference_StructAddress;
	}

	static FSequenceEvaluatorReference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSequenceEvaluatorReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSequenceEvaluatorReference));
	}

	private static void LoadNativeType()
	{
		FSequenceEvaluatorReference_IsValid = (FSequenceEvaluatorReference_StructAddress = NativeReflection.GetStruct("/Script/AnimGraphRuntime.SequenceEvaluatorReference")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.SequenceEvaluatorReference", FSequenceEvaluatorReference_IsValid);
	}
}
