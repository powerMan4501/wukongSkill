using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraphRuntime;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AnimGraphRuntime.SequencePlayerReference", "AnimGraphRuntime", UnrealModuleType.Engine)]
public class FSequencePlayerReference : StructAsClass
{
	private static bool FSequencePlayerReference_IsValid;

	private static IntPtr FSequencePlayerReference_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FSequencePlayerReference_StructAddress;
	}

	static FSequencePlayerReference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSequencePlayerReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSequencePlayerReference));
	}

	private static void LoadNativeType()
	{
		FSequencePlayerReference_IsValid = (FSequencePlayerReference_StructAddress = NativeReflection.GetStruct("/Script/AnimGraphRuntime.SequencePlayerReference")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/AnimGraphRuntime.SequencePlayerReference", FSequencePlayerReference_IsValid);
	}
}
