using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[StructLayout(LayoutKind.Sequential, Size = 8)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/V8.JavascriptProfileNode", "V8", UnrealModuleType.GamePlugin)]
public struct FJavascriptProfileNode
{
	private static int FJavascriptProfileNode_StructSize;

	public FJavascriptProfileNode Copy()
	{
		return this;
	}

	static FJavascriptProfileNode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptProfileNode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptProfileNode));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/V8.JavascriptProfileNode");
		FJavascriptProfileNode_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FJavascriptProfileNode));
	}
}
