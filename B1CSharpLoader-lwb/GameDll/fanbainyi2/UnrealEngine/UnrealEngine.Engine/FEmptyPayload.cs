using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/Engine.EmptyPayload", "Engine", UnrealModuleType.Engine)]
public struct FEmptyPayload
{
	private static int FEmptyPayload_StructSize;

	public FEmptyPayload Copy()
	{
		return this;
	}

	static FEmptyPayload()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEmptyPayload)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEmptyPayload));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/Engine.EmptyPayload");
		FEmptyPayload_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FEmptyPayload));
	}
}
