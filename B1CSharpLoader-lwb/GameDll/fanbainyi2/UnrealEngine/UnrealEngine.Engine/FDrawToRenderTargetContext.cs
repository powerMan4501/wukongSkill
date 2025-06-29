using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.DrawToRenderTargetContext", "Engine", UnrealModuleType.Engine)]
public class FDrawToRenderTargetContext : StructAsClass
{
	private static bool FDrawToRenderTargetContext_IsValid;

	private static IntPtr FDrawToRenderTargetContext_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FDrawToRenderTargetContext_StructAddress;
	}

	static FDrawToRenderTargetContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDrawToRenderTargetContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDrawToRenderTargetContext));
	}

	private static void LoadNativeType()
	{
		FDrawToRenderTargetContext_IsValid = (FDrawToRenderTargetContext_StructAddress = NativeReflection.GetStruct("/Script/Engine.DrawToRenderTargetContext")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/Engine.DrawToRenderTargetContext", FDrawToRenderTargetContext_IsValid);
	}
}
