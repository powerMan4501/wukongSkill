using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimUpdateContext", "Engine", UnrealModuleType.Engine)]
public class FAnimUpdateContext : StructAsClass
{
	private static bool FAnimUpdateContext_IsValid;

	private static IntPtr FAnimUpdateContext_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FAnimUpdateContext_StructAddress;
	}

	static FAnimUpdateContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimUpdateContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimUpdateContext));
	}

	private static void LoadNativeType()
	{
		FAnimUpdateContext_IsValid = (FAnimUpdateContext_StructAddress = NativeReflection.GetStruct("/Script/Engine.AnimUpdateContext")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimUpdateContext", FAnimUpdateContext_IsValid);
	}
}
