using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptStubStruct", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptStubStruct
{
	private static int FJavascriptStubStruct_StructSize;

	public FJavascriptStubStruct Copy()
	{
		return this;
	}

	static FJavascriptStubStruct()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptStubStruct)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptStubStruct));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/V8.JavascriptStubStruct");
		FJavascriptStubStruct_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FJavascriptStubStruct));
	}
}
