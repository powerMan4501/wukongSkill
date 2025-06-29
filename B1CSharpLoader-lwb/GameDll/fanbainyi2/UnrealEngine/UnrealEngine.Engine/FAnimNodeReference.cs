using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimNodeReference", "Engine", UnrealModuleType.Engine)]
public class FAnimNodeReference : StructAsClass
{
	private static bool FAnimNodeReference_IsValid;

	private static IntPtr FAnimNodeReference_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FAnimNodeReference_StructAddress;
	}

	static FAnimNodeReference()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNodeReference)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNodeReference));
	}

	private static void LoadNativeType()
	{
		FAnimNodeReference_IsValid = (FAnimNodeReference_StructAddress = NativeReflection.GetStruct("/Script/Engine.AnimNodeReference")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimNodeReference", FAnimNodeReference_IsValid);
	}
}
