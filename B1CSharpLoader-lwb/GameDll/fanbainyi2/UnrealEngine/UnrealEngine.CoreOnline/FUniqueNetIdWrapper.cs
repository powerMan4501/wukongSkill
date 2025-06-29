using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.CoreOnline;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 57352)]
[UMetaPath("/Script/CoreOnline.UniqueNetIdWrapper", "CoreOnline", UnrealModuleType.Engine)]
public struct FUniqueNetIdWrapper
{
	private static int FUniqueNetIdWrapper_StructSize;

	public FUniqueNetIdWrapper Copy()
	{
		return this;
	}

	static FUniqueNetIdWrapper()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FUniqueNetIdWrapper)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUniqueNetIdWrapper));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/CoreOnline.UniqueNetIdWrapper");
		FUniqueNetIdWrapper_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FUniqueNetIdWrapper));
	}
}
